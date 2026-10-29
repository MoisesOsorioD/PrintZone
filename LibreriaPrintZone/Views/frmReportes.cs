using LibreriaPrintZone.Components;
using LibreriaPrintZone.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LibreriaPrintZone.Views
{
    public partial class frmReportes : Form
    {
        private bool actualizandoVista;
        private bool filtroFechasActivado;

        private DataTable tablaActual = new DataTable();
        private string tituloActual = "Reporte";
        private string totalesActuales = "";

        private readonly Color colorEncabezado = Color.FromArgb(0, 105, 200);
        private readonly Color colorTextoEncabezado = Color.White;

        public frmReportes()
        {
            InitializeComponent();
            PanelRedondeado.Aplicar(panelFiltros, 20);
            PanelRedondeado.Aplicar(panelOpcionesAdicionales, 20);
            PanelRedondeado.Aplicar(panelTipoReporte, 20);
            PanelRedondeado.Aplicar(panelVistaPrevia, 20);

            BotonRedondeado.Aplicar(btnGenerarReporte, 10);




            btnGenerarReporte.Click -= btnGenerarReporte_Click;
            btnGenerarReporte.Click += btnGenerarReporte_Click;

            rbInventarioGeneral.CheckedChanged += RadioButton_CheckedChanged;
            rbProductosBajoStock.CheckedChanged += RadioButton_CheckedChanged;
            rbEntradasProductos.CheckedChanged += RadioButton_CheckedChanged;
            rbSalidasProductos.CheckedChanged += RadioButton_CheckedChanged;
            rbProveedores.CheckedChanged += RadioButton_CheckedChanged;

            dtpFechaDesde.ValueChanged += Fecha_ValueChanged;
            dtpFechaHasta.ValueChanged += Fecha_ValueChanged;

            chkIncluirPrecios.CheckedChanged += Opciones_CheckedChanged;
            chkMostrarTotales.CheckedChanged += Opciones_CheckedChanged;

            ActualizarFiltrosFecha();
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is RadioButton radio && radio.Checked)
            {
                ActualizarFiltrosFecha();
                ActualizarVistaPrevia();
            }
        }

        private void Fecha_ValueChanged(object sender, EventArgs e)
        {
            filtroFechasActivado = true;
            ActualizarVistaPrevia();
        }

        private void Opciones_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarVistaPrevia();
        }

        private void ActualizarFiltrosFecha()
        {
            bool mostrarFechas =
                rbEntradasProductos.Checked ||
                rbSalidasProductos.Checked;

            dtpFechaDesde.Enabled = mostrarFechas;
            dtpFechaHasta.Enabled = mostrarFechas;
        }

        private bool HayReporteSeleccionado()
        {
            return rbInventarioGeneral.Checked ||
                   rbProductosBajoStock.Checked ||
                   rbEntradasProductos.Checked ||
                   rbSalidasProductos.Checked ||
                   rbProveedores.Checked;
        }

        private void ActualizarVistaPrevia()
        {
            if (actualizandoVista)
                return;

            actualizandoVista = true;

            try
            {
                if (!HayReporteSeleccionado())
                {
                    tablaActual = new DataTable();
                    MostrarMensajePrevia("Seleccioná un tipo de reporte.");
                    return;
                }

                bool esMovimiento =
                    rbEntradasProductos.Checked ||
                    rbSalidasProductos.Checked;

                if (esMovimiento &&
                    filtroFechasActivado &&
                    dtpFechaDesde.Value.Date > dtpFechaHasta.Value.Date)
                {
                    tablaActual = new DataTable();
                    totalesActuales = "";

                    MostrarMensajePrevia(
                        "La fecha inicial no puede ser posterior a la fecha final.");

                    return;
                }

                using var contexto = new InventarioPrintzoneContext();

                tablaActual = CrearTablaReporte(contexto);
                tituloActual = ObtenerTituloReporte();

                totalesActuales = chkMostrarTotales.Checked
                    ? ObtenerTotales(tablaActual)
                    : "";

                MostrarVistaPrevia(tablaActual);
            }
            catch (Exception ex)
            {
                tablaActual = new DataTable();
                totalesActuales = "";

                MostrarMensajePrevia(
                    "No se pudo cargar el reporte.\n\n" + ex.Message);
            }
            finally
            {
                actualizandoVista = false;
            }
        }

        private DataTable CrearTablaReporte(
            InventarioPrintzoneContext contexto)
        {
            if (rbInventarioGeneral.Checked)
            {
                var datos = contexto.Productos
                    .AsNoTracking()
                    .Where(p => p.Activo)
                    .Select(p => new
                    {
                        Producto = p.Nombre,
                        Marca = p.Marca,
                        Categoria = p.IdCategoriaNavigation.NombreCategoria,
                        Existencias = p.StockActual,
                        StockMinimo = p.StockMinimo,
                        PrecioCompra = p.PrecioCompra,
                        PrecioVenta = p.PrecioVenta
                    })
                    .ToList();

                DataTable tabla = ConvertirATabla(datos);

                if (!chkIncluirPrecios.Checked)
                    QuitarColumnas(tabla, "PrecioCompra", "PrecioVenta");

                return tabla;
            }

            if (rbProductosBajoStock.Checked)
            {
                var datos = contexto.Productos
                    .AsNoTracking()
                    .Where(p => p.Activo && p.StockActual <= p.StockMinimo)
                    .OrderBy(p => p.StockActual)
                    .Select(p => new
                    {
                        Producto = p.Nombre,
                        Marca = p.Marca,
                        Categoria = p.IdCategoriaNavigation.NombreCategoria,
                        Existencias = p.StockActual,
                        StockMinimo = p.StockMinimo,
                        PrecioCompra = p.PrecioCompra,
                        PrecioVenta = p.PrecioVenta
                    })
                    .ToList();

                DataTable tabla = ConvertirATabla(datos);

                if (!chkIncluirPrecios.Checked)
                    QuitarColumnas(tabla, "PrecioCompra", "PrecioVenta");

                return tabla;
            }

            if (rbEntradasProductos.Checked)
            {
                var consulta = contexto.Entradas
                    .AsNoTracking()
                    .AsQueryable();

                if (filtroFechasActivado)
                {
                    DateTime desde = dtpFechaDesde.Value.Date;
                    DateTime hasta = dtpFechaHasta.Value.Date.AddDays(1);

                    consulta = consulta.Where(e =>
                        e.FechaEntrada >= desde &&
                        e.FechaEntrada < hasta);
                }

                var datos = consulta
                    .OrderByDescending(e => e.FechaEntrada)
                    .Select(e => new
                    {
                        Fecha = e.FechaEntrada,
                        Producto = e.IdProductoNavigation.Nombre,
                        Proveedor = e.IdProveedorNavigation.NombreEmpresa,
                        Cantidad = e.Cantidad,
                        CostoLote = e.CostoLote
                    })
                    .ToList();

                DataTable tabla = ConvertirATabla(datos);

                if (!chkIncluirPrecios.Checked)
                    QuitarColumnas(tabla, "CostoLote");

                return tabla;
            }

            if (rbSalidasProductos.Checked)
            {
                var consulta = contexto.Salidas
                    .AsNoTracking()
                    .AsQueryable();

                if (filtroFechasActivado)
                {
                    DateTime desde = dtpFechaDesde.Value.Date;
                    DateTime hasta = dtpFechaHasta.Value.Date.AddDays(1);

                    consulta = consulta.Where(s =>
                        s.FechaSalida >= desde &&
                        s.FechaSalida < hasta);
                }

                var datos = consulta
                    .OrderByDescending(s => s.FechaSalida)
                    .Select(s => new
                    {
                        Fecha = s.FechaSalida,
                        Producto = s.IdProductoNavigation.Nombre,
                        Cantidad = s.Cantidad,
                        Motivo = s.Motivo,
                        Vendedor = s.IdUsuarioNavigation.NombreCompleto
                    })
                    .ToList();

                return ConvertirATabla(datos);
            }

            if (rbProveedores.Checked)
            {
                var datos = contexto.Proveedores
                    .AsNoTracking()
                    .Select(p => new
                    {
                        Empresa = p.NombreEmpresa,
                        Direccion = p.Direccion,
                        Correo = p.Correo,
                        Telefono = p.Telefono,
                        Agente = p.NombreAgente,
                        TelefonoAgente = p.TelefonoAgente,
                        CompraMinima = p.MontoMinimoCompra
                    })
                    .ToList();

                DataTable tabla = ConvertirATabla(datos);

                if (!chkIncluirPrecios.Checked)
                    QuitarColumnas(tabla, "CompraMinima");

                return tabla;
            }

            return new DataTable();
        }

        private DataTable ConvertirATabla<T>(List<T> datos)
        {
            DataTable tabla = new DataTable();
            var propiedades = typeof(T).GetProperties();

            foreach (var propiedad in propiedades)
            {
                Type tipo =
                    Nullable.GetUnderlyingType(propiedad.PropertyType)
                    ?? propiedad.PropertyType;

                tabla.Columns.Add(propiedad.Name, tipo);
            }

            foreach (var dato in datos)
            {
                DataRow fila = tabla.NewRow();

                foreach (var propiedad in propiedades)
                {
                    fila[propiedad.Name] =
                        propiedad.GetValue(dato) ?? DBNull.Value;
                }

                tabla.Rows.Add(fila);
            }

            return tabla;
        }

        private void QuitarColumnas(DataTable tabla, params string[] columnas)
        {
            foreach (string nombre in columnas)
            {
                if (tabla.Columns.Contains(nombre))
                    tabla.Columns.Remove(nombre);
            }
        }

        private Dictionary<string, string> ObtenerEncabezados()
        {
            return new Dictionary<string, string>
            {
                ["Producto"] = "Producto",
                ["Marca"] = "Marca",
                ["Categoria"] = "Categoría",
                ["Existencias"] = "Stock actual",
                ["StockMinimo"] = "Stock mínimo",
                ["PrecioCompra"] = "Precio compra",
                ["PrecioVenta"] = "Precio venta",
                ["Fecha"] = "Fecha y hora",
                ["Proveedor"] = "Proveedor",
                ["Cantidad"] = "Cantidad",
                ["CostoLote"] = "Costo del lote",
                ["Motivo"] = "Motivo",
                ["Vendedor"] = "Vendedor",
                ["Empresa"] = "Empresa",
                ["Direccion"] = "Dirección",
                ["Correo"] = "Correo",
                ["Telefono"] = "Teléfono",
                ["Agente"] = "Agente",
                ["TelefonoAgente"] = "Teléfono del agente",
                ["CompraMinima"] = "Compra mínima"
            };
        }

        private void AplicarEstiloEncabezados(DataGridView vista)
        {
            vista.EnableHeadersVisualStyles = false;

            vista.ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle
            {
                BackColor = colorEncabezado,
                ForeColor = colorTextoEncabezado,
                Font = new Font("Segoe UI", 7.5f, FontStyle.Bold),
                Alignment = DataGridViewContentAlignment.MiddleLeft,
                WrapMode = DataGridViewTriState.True,
                Padding = new Padding(4, 2, 4, 2),
                SelectionBackColor = colorEncabezado,
                SelectionForeColor = colorTextoEncabezado
            };

            foreach (DataGridViewColumn columna in vista.Columns)
            {
                var estilo = new DataGridViewCellStyle(
                    vista.ColumnHeadersDefaultCellStyle);

                columna.HeaderCell.Style = estilo;
                columna.HeaderCell.Style.BackColor = colorEncabezado;
                columna.HeaderCell.Style.ForeColor = colorTextoEncabezado;
                columna.HeaderCell.Style.Font =
                    new Font("Segoe UI", 7.5f, FontStyle.Bold);
                columna.HeaderCell.Style.Alignment =
                    DataGridViewContentAlignment.MiddleLeft;
                columna.HeaderCell.Style.WrapMode =
                    DataGridViewTriState.True;
                columna.HeaderCell.Style.Padding =
                    new Padding(4, 2, 4, 2);
                columna.HeaderCell.Style.SelectionBackColor =
                    colorEncabezado;
                columna.HeaderCell.Style.SelectionForeColor =
                    colorTextoEncabezado;

                columna.MinimumWidth = 55;

                if (columna.ValueType == typeof(decimal))
                    columna.DefaultCellStyle.Format = "N2";

                if (columna.Name == "Fecha")
                    columna.DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
            }

            vista.ClearSelection();
            vista.CurrentCell = null;
        }

        private void MostrarVistaPrevia(DataTable tabla)
        {
            pnlDocumentoPrevia.SuspendLayout();

            try
            {
                pnlDocumentoPrevia.Controls.Clear();

                TableLayoutPanel distribucion = new TableLayoutPanel
                {
                    Dock = DockStyle.Fill,
                    ColumnCount = 1,
                    RowCount = 3,
                    Padding = new Padding(5),
                    Margin = new Padding(0),
                    BackColor = Color.White
                };

                distribucion.ColumnStyles.Add(
                    new ColumnStyle(SizeType.Percent, 100));

                distribucion.RowStyles.Add(
                    new RowStyle(SizeType.Absolute, 30));

                distribucion.RowStyles.Add(
                    new RowStyle(SizeType.Percent, 100));

                distribucion.RowStyles.Add(
                    new RowStyle(SizeType.Absolute, 32));

                Label titulo = new Label
                {
                    Text = tituloActual,
                    Dock = DockStyle.Fill,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Font = new Font("Segoe UI", 9, FontStyle.Bold),
                    ForeColor = Color.FromArgb(25, 50, 80),
                    AutoEllipsis = true
                };

                DataGridView vista = new DataGridView
                {
                    Dock = DockStyle.Fill,
                    ReadOnly = true,
                    AllowUserToAddRows = false,
                    AllowUserToDeleteRows = false,
                    AllowUserToResizeRows = false,
                    AutoGenerateColumns = true,
                    AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                    AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None,
                    BackgroundColor = Color.White,
                    BorderStyle = BorderStyle.None,
                    RowHeadersVisible = false,
                    ColumnHeadersVisible = true,
                    SelectionMode = DataGridViewSelectionMode.FullRowSelect,
                    MultiSelect = false,
                    ScrollBars = ScrollBars.Both,
                    EnableHeadersVisualStyles = false,
                    ColumnHeadersHeight = 30,
                    ColumnHeadersHeightSizeMode =
                        DataGridViewColumnHeadersHeightSizeMode.DisableResizing,
                    RowTemplate = { Height = 23 },
                    DataSource = tabla
                };

                vista.DefaultCellStyle = new DataGridViewCellStyle
                {
                    Font = new Font("Segoe UI", 7.5f),
                    Padding = new Padding(2),
                    SelectionBackColor = Color.FromArgb(215, 232, 250),
                    SelectionForeColor = Color.Black,
                    WrapMode = DataGridViewTriState.False
                };

                vista.AlternatingRowsDefaultCellStyle.BackColor =
                    Color.FromArgb(245, 249, 253);

                // El estilo se aplica al terminar el enlace de datos.
                // Así Producto y las demás columnas quedan iguales.
                vista.DataBindingComplete += (s, e) =>
                {
                    var encabezados = ObtenerEncabezados();

                    foreach (DataGridViewColumn columna in vista.Columns)
                    {
                        if (encabezados.TryGetValue(
                            columna.Name, out string encabezado))
                        {
                            columna.HeaderText = encabezado;
                        }
                    }

                    AplicarEstiloEncabezados(vista);
                };

                // Aplicar también el estilo inicial por si el enlace
                // de datos ya se completó antes de registrar el evento.
                if (vista.Columns.Count > 0)
                    AplicarEstiloEncabezados(vista);

                string textoResumen =
                    $"Registros encontrados: {tabla.Rows.Count}";

                if (chkMostrarTotales.Checked &&
                    !string.IsNullOrWhiteSpace(totalesActuales))
                {
                    textoResumen += " | " + totalesActuales;
                }

                Label resumen = new Label
                {
                    Text = textoResumen,
                    Dock = DockStyle.Fill,
                    TextAlign = ContentAlignment.MiddleLeft,
                    Font = new Font("Segoe UI", 7.5f, FontStyle.Bold),
                    AutoEllipsis = true
                };

                distribucion.Controls.Add(titulo, 0, 0);
                distribucion.Controls.Add(vista, 0, 1);
                distribucion.Controls.Add(resumen, 0, 2);

                pnlDocumentoPrevia.Controls.Add(distribucion);
            }
            finally
            {
                pnlDocumentoPrevia.ResumeLayout();
            }
        }

        private string ObtenerTotales(DataTable tabla)
        {
            List<string> resultados = new List<string>();

            string[] columnasSumables =
            {
                "Existencias",
                "Cantidad",
                "StockMinimo",
                "PrecioCompra",
                "PrecioVenta",
                "CostoLote",
                "CompraMinima"
            };

            foreach (string nombre in columnasSumables)
            {
                if (!tabla.Columns.Contains(nombre))
                    continue;

                decimal total = 0;

                foreach (DataRow fila in tabla.Rows)
                {
                    if (fila[nombre] != DBNull.Value)
                        total += Convert.ToDecimal(fila[nombre]);
                }

                resultados.Add(
                    $"{ObtenerEncabezados().GetValueOrDefault(nombre, nombre)}: {total:N2}");
            }

            return string.Join(" | ", resultados);
        }

        private string ObtenerTituloReporte()
        {
            if (rbInventarioGeneral.Checked)
                return "Inventario general";

            if (rbProductosBajoStock.Checked)
                return "Productos con bajo stock";

            if (rbEntradasProductos.Checked)
                return "Entradas de productos";

            if (rbSalidasProductos.Checked)
                return "Salidas de productos";

            if (rbProveedores.Checked)
                return "Proveedores";

            return "Reporte";
        }

        private void MostrarMensajePrevia(string mensaje)
        {
            pnlDocumentoPrevia.Controls.Clear();

            pnlDocumentoPrevia.Controls.Add(new Label
            {
                Text = mensaje,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                Padding = new Padding(12),
                Font = new Font("Segoe UI", 8.5f)
            });
        }

        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            if (!HayReporteSeleccionado())
            {
                MessageBox.Show(
                    "Seleccioná un tipo de reporte.",
                    "Reportes",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            ActualizarVistaPrevia();

            if (tablaActual.Columns.Count == 0)
            {
                MessageBox.Show(
                    "No hay datos para generar el reporte.",
                    "Reportes",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            using Form opciones = new Form
            {
                Text = "Generar reporte",
                StartPosition = FormStartPosition.CenterParent,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                ClientSize = new Size(330, 165),
                MaximizeBox = false,
                MinimizeBox = false,
                ShowInTaskbar = false,
                BackColor = Color.FromArgb(220, 233, 247)
            };

            Label texto = new Label
            {
                Text = "Seleccioná el formato del reporte:",
                Location = new Point(10, 12),
                Size = new Size(310, 28),
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Segoe UI", 9, FontStyle.Bold)
            };

            Button btnPdf = CrearBotonOpcion("Guardar como PDF", 48);
            Button btnExcel = CrearBotonOpcion("Exportar a Excel", 94);

            BotonRedondeado.Aplicar(btnPdf, 10);
            BotonRedondeado.Aplicar(btnExcel, 10);



            btnPdf.Click += (s, args) =>
            {
                opciones.Close();
                GuardarComoPdf();
            };

            btnExcel.Click += (s, args) =>
            {
                opciones.Close();
                ExportarExcel();
            };

            opciones.Controls.Add(texto);
            opciones.Controls.Add(btnPdf);
            opciones.Controls.Add(btnExcel);

            opciones.ShowDialog(this);
        }

        private Button CrearBotonOpcion(string texto, int posicionY)
        {
            Button boton = new Button
            {
                Text = texto,
                Location = new Point(40, posicionY),
                Size = new Size(250, 36),
                Font = new Font("Segoe UI", 9, FontStyle.Bold),
                BackColor = Color.FromArgb(0, 105, 200),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                UseVisualStyleBackColor = false,
                Cursor = Cursors.Hand
            };

            boton.FlatAppearance.BorderSize = 0;
            boton.FlatAppearance.MouseOverBackColor =
                Color.FromArgb(0, 85, 165);
            boton.FlatAppearance.MouseDownBackColor =
                Color.FromArgb(0, 70, 140);

            return boton;
        }

        private void ExportarExcel()
        {
            using SaveFileDialog dialogo = new SaveFileDialog
            {
                Title = "Exportar reporte",
                Filter = "Archivo CSV (*.csv)|*.csv",
                FileName = $"{tituloActual.Replace(' ', '_')}.csv"
            };

            if (dialogo.ShowDialog(this) != DialogResult.OK)
                return;

            try
            {
                using StreamWriter escritor =
                    new StreamWriter(dialogo.FileName, false, Encoding.UTF8);

                escritor.WriteLine(EscaparCsv(tituloActual));
                escritor.WriteLine(EscaparCsv(
                    $"Fecha de generación: {DateTime.Now:dd/MM/yyyy HH:mm}"));
                escritor.WriteLine();

                var encabezados = ObtenerEncabezados();

                escritor.WriteLine(string.Join(";",
                    tablaActual.Columns.Cast<DataColumn>()
                        .Select(c => EscaparCsv(
                            encabezados.TryGetValue(c.ColumnName, out string h)
                                ? h
                                : c.ColumnName))));

                foreach (DataRow fila in tablaActual.Rows)
                {
                    escritor.WriteLine(string.Join(";",
                        fila.ItemArray.Select(valor =>
                            EscaparCsv(valor == DBNull.Value
                                ? ""
                                : valor is DateTime fecha
                                    ? fecha.ToString("dd/MM/yyyy HH:mm")
                                    : Convert.ToString(valor) ?? ""))));
                }

                if (chkMostrarTotales.Checked &&
                    !string.IsNullOrWhiteSpace(totalesActuales))
                {
                    escritor.WriteLine();
                    escritor.WriteLine(EscaparCsv("Totales"));
                    escritor.WriteLine(EscaparCsv(totalesActuales));
                }

                MessageBox.Show(
                    "El reporte se exportó correctamente.",
                    "Exportación completada",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se pudo exportar el reporte:\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private string EscaparCsv(string valor)
        {
            valor ??= "";
            return "\"" + valor.Replace("\"", "\"\"") + "\"";
        }

        private void GuardarComoPdf()
        {
            using SaveFileDialog dialogo = new SaveFileDialog
            {
                Title = "Guardar reporte como PDF",
                Filter = "Archivo PDF (*.pdf)|*.pdf",
                FileName = $"{tituloActual.Replace(' ', '_')}.pdf"
            };

            if (dialogo.ShowDialog(this) != DialogResult.OK)
                return;

            try
            {
                using PrintDocument documento = CrearDocumentoPdf();

                documento.PrinterSettings.PrinterName =
                    "Microsoft Print to PDF";

                documento.PrinterSettings.PrintToFile = true;
                documento.PrinterSettings.PrintFileName = dialogo.FileName;

                if (!documento.PrinterSettings.IsValid)
                {
                    MessageBox.Show(
                        "Microsoft Print to PDF no está disponible en Windows.",
                        "PDF no disponible",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                documento.Print();

                MessageBox.Show(
                    "El reporte se guardó como PDF.",
                    "PDF generado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se pudo crear el PDF:\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private PrintDocument CrearDocumentoPdf()
        {
            int indiceFila = 0;

            PrintDocument documento = new PrintDocument
            {
                DocumentName = tituloActual
            };

            documento.DefaultPageSettings.Landscape = true;
            documento.DefaultPageSettings.Margins =
                new Margins(35, 35, 45, 45);

            documento.PrintPage += (sender, e) =>
            {
                Graphics g = e.Graphics;
                float x = e.MarginBounds.Left;
                float y = e.MarginBounds.Top;
                float ancho = e.MarginBounds.Width;

                using Font fuenteTitulo =
                    new Font("Arial", 15, FontStyle.Bold);

                using Font fuenteNormal = new Font("Arial", 8);

                using Font fuenteEncabezado =
                    new Font("Arial", 8, FontStyle.Bold);

                using Brush pincel = new SolidBrush(Color.Black);

                g.DrawString(tituloActual, fuenteTitulo, pincel, x, y);
                y += 28;

                g.DrawString(
                    $"Fecha de generación: {DateTime.Now:dd/MM/yyyy HH:mm}",
                    fuenteNormal, pincel, x, y);

                y += 24;

                int columnas = tablaActual.Columns.Count;

                if (columnas == 0)
                {
                    e.HasMorePages = false;
                    return;
                }

                float anchoColumna = ancho / columnas;
                float altoFila = 25;
                var encabezados = ObtenerEncabezados();

                for (int c = 0; c < columnas; c++)
                {
                    string nombre = tablaActual.Columns[c].ColumnName;

                    string encabezado =
                        encabezados.TryGetValue(nombre, out string h)
                            ? h
                            : nombre;

                    RectangleF rectangulo = new RectangleF(
                        x + c * anchoColumna, y,
                        anchoColumna, altoFila);

                    g.FillRectangle(
                        new SolidBrush(colorEncabezado), rectangulo);

                    g.DrawRectangle(
                        Pens.Gray, Rectangle.Round(rectangulo));

                    g.DrawString(
                        encabezado, fuenteEncabezado,
                        Brushes.White, rectangulo);
                }

                y += altoFila;

                while (indiceFila < tablaActual.Rows.Count)
                {
                    if (y + altoFila > e.MarginBounds.Bottom)
                    {
                        e.HasMorePages = true;
                        return;
                    }

                    for (int c = 0; c < columnas; c++)
                    {
                        object valor = tablaActual.Rows[indiceFila][c];

                        string contenido = valor == DBNull.Value
                            ? ""
                            : valor is DateTime fecha
                                ? fecha.ToString("dd/MM/yyyy HH:mm")
                                : Convert.ToString(valor) ?? "";

                        RectangleF rectangulo = new RectangleF(
                            x + c * anchoColumna, y,
                            anchoColumna, altoFila);

                        g.DrawRectangle(
                            Pens.LightGray, Rectangle.Round(rectangulo));

                        g.DrawString(
                            contenido, fuenteNormal, pincel, rectangulo);
                    }

                    y += altoFila;
                    indiceFila++;
                }

                e.HasMorePages = false;
            };

            return documento;
        }
    }
}
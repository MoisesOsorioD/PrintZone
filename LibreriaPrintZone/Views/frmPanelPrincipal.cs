using LibreriaPrintZone.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Windows.Forms;

namespace LibreriaPrintZone.Views
{
    public partial class frmPanelPrincipal : Form
    {
        private readonly string _rol;
        private readonly string _nombreCompleto;

        public frmPanelPrincipal(string rol, string nombreCompleto)
        {
            InitializeComponent();

            _rol = rol;
            _nombreCompleto = nombreCompleto;

            ConfigurarPanel();
            CargarInformacion();
        }

        // =========================================================
        // CONFIGURAR PANEL
        // =========================================================

        private void ConfigurarPanel()
        {
            if (_rol == "Administrador")
            {
                lblBienvenida.Text =
                    $"¡Bienvenido, {_nombreCompleto}!";

                lblDescripcion.Text =
                    "Aquí tienes un resumen del estado de tu inventario.";

                lblTituloTarjeta1.Text =
                    "Total de productos";

                lblTituloTarjeta2.Text =
                    "Productos con stock mínimo";

                lblTituloTarjeta3.Text =
                    "Total de entradas hoy";

                lblDescripcionProductos.Text =
                    "Productos registrados en el sistema";

                lblDescripcionStock.Text =
                    "Requiere atención";

                lblDescripcionEntradas.Text =
                    "Registros de entradas";
            }
            else if (_rol == "Vendedor")
            {
                lblBienvenida.Text =
                    $"¡Bienvenido, {_nombreCompleto}!";

                lblDescripcion.Text =
                    "Aquí tienes un resumen de las salidas realizadas.";

                lblTituloTarjeta1.Text =
                    "Total de salidas hoy";

                lblTituloTarjeta2.Text =
                    "Producto con más salidas";

                lblTituloTarjeta3.Text =
                    "Categoría con más salidas";

                lblDescripcionProductos.Text =
                    "Salidas registradas hoy";

                lblDescripcionStock.Text =
                    "Producto con mayor cantidad de salidas";

                lblDescripcionEntradas.Text =
                    "Categoría con mayor cantidad de salidas";
            }
        }

        // =========================================================
        // CARGAR INFORMACIÓN
        // =========================================================

        private void CargarInformacion()
        {
            try
            {
                using var context = new InventarioPrintzoneContext();

                if (_rol == "Administrador")
                {
                    CargarDashboardAdministrador(context);
                }
                else if (_rol == "Vendedor")
                {
                    CargarDashboardVendedor(context);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se pudo cargar la información del panel.\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // =========================================================
        // DASHBOARD ADMINISTRADOR
        // =========================================================

        private void CargarDashboardAdministrador(
            InventarioPrintzoneContext context)
        {
            // =====================================================
            // TARJETAS
            // =====================================================

            var resultado = context.Database
                .SqlQueryRaw<DashboardAdminResultado>(
                    "EXEC sp_Dashboard_Admin"
                )
                .AsEnumerable()
                .FirstOrDefault();

            if (resultado != null)
            {
                lblTotalProductos.Text =
                    resultado.total_productos.ToString();

                lblProductosStockMinimo.Text =
                    resultado.productos_stock_minimo.ToString();

                lblEntradasHoy.Text =
                    resultado.entradas_hoy.ToString();
            }
            else
            {
                lblTotalProductos.Text = "0";
                lblProductosStockMinimo.Text = "0";
                lblEntradasHoy.Text = "0";
            }

            // =====================================================
            // DATAGRID DEL ADMINISTRADOR
            // =====================================================

            CargarMovimientosAdministrador(context);
        }

        // =========================================================
        // MOVIMIENTOS DEL ADMINISTRADOR
        // =========================================================

        private void CargarMovimientosAdministrador(
            InventarioPrintzoneContext context)
        {
            // =====================================================
            // ENTRADAS
            // =====================================================

            var entradas = context.Entradas
                .AsNoTracking()
                .Include(e => e.IdProductoNavigation)
                .Include(e => e.IdProveedorNavigation)
                .Select(e => new MovimientoViewModel
                {
                    Fecha = e.FechaEntrada,
                    Movimiento = "Entrada",
                    Producto = e.IdProductoNavigation.Nombre,
                    Cantidad = e.Cantidad
                })
                .ToList();

            // =====================================================
            // SALIDAS
            // =====================================================

            var salidas = context.Salidas
                .AsNoTracking()
                .Include(s => s.IdProductoNavigation)
                .Select(s => new MovimientoViewModel
                {
                    Fecha = s.FechaSalida,
                    Movimiento = "Salida",
                    Producto = s.IdProductoNavigation.Nombre,
                    Cantidad = s.Cantidad
                })
                .ToList();

            // =====================================================
            // UNIR ENTRADAS Y SALIDAS
            // =====================================================

            var movimientos = entradas
                .Concat(salidas)
                .OrderByDescending(m => m.Fecha)
                .Take(10)
                .ToList();

            // =====================================================
            // LIMPIAR DATAGRID
            // =====================================================

            dgvMovimientos.Rows.Clear();

            // =====================================================
            // CARGAR DATOS
            // =====================================================

            foreach (var movimiento in movimientos)
            {
                dgvMovimientos.Rows.Add(
                    movimiento.Fecha.ToString("dd/MM/yyyy"),
                    movimiento.Movimiento,
                    movimiento.Producto,
                    movimiento.Cantidad
                );
            }

            dgvMovimientos.ClearSelection();
        }

        // =========================================================
        // DASHBOARD VENDEDOR
        // =========================================================

        private void CargarDashboardVendedor(
            InventarioPrintzoneContext context)
        {
            // =====================================================
            // TARJETAS
            // =====================================================

            var resultado = context.Database
                .SqlQueryRaw<DashboardVendedorResultado>(
                    "EXEC sp_Dashboard_Vendedor"
                )
                .AsEnumerable()
                .FirstOrDefault();

            if (resultado != null)
            {
                lblTotalProductos.Text =
                    resultado.total_salidas_hoy.ToString();

                lblProductosStockMinimo.Text =
                    string.IsNullOrWhiteSpace(
                        resultado.producto_mas_salidas)
                        ? "-"
                        : resultado.producto_mas_salidas;

                lblEntradasHoy.Text =
                    string.IsNullOrWhiteSpace(
                        resultado.categoria_mas_salidas)
                        ? "-"
                        : resultado.categoria_mas_salidas;
            }
            else
            {
                lblTotalProductos.Text = "0";
                lblProductosStockMinimo.Text = "-";
                lblEntradasHoy.Text = "-";
            }

            // =====================================================
            // DATAGRID DEL VENDEDOR
            // =====================================================

            CargarMovimientosVendedor(context);
        }

        // =========================================================
        // MOVIMIENTOS DEL VENDEDOR
        // =========================================================

        private void CargarMovimientosVendedor(
            InventarioPrintzoneContext context)
        {
            var salidas = context.Salidas
                .AsNoTracking()
                .Include(s => s.IdProductoNavigation)
                .OrderByDescending(s => s.FechaSalida)
                .Take(10)
                .ToList();

            dgvMovimientos.Rows.Clear();

            foreach (var salida in salidas)
            {
                dgvMovimientos.Rows.Add(
                    salida.FechaSalida.ToString("dd/MM/yyyy"),
                    "Salida",
                    salida.IdProductoNavigation.Nombre,
                    salida.Cantidad
                );
            }

            dgvMovimientos.ClearSelection();
        }

        // =========================================================
        // RESULTADO DEL PROCEDIMIENTO DEL ADMINISTRADOR
        // =========================================================

        public class DashboardAdminResultado
        {
            public int total_productos { get; set; }

            public int productos_stock_minimo { get; set; }

            public int entradas_hoy { get; set; }
        }

        // =========================================================
        // RESULTADO DEL PROCEDIMIENTO DEL VENDEDOR
        // =========================================================

        public class DashboardVendedorResultado
        {
            public int total_salidas_hoy { get; set; }

            public string? producto_mas_salidas { get; set; }

            public string? categoria_mas_salidas { get; set; }
        }

        // =========================================================
        // MODELO PARA LOS MOVIMIENTOS
        // =========================================================

        private class MovimientoViewModel
        {
            public DateTime Fecha { get; set; }

            public string Movimiento { get; set; } = "";

            public string Producto { get; set; } = "";

            public int Cantidad { get; set; }
        }

        private void btnVerTodos_Click(object sender, EventArgs e)
        {
            if (_rol == "Administrador")
            {
                using Form dialogo = new Form();

                dialogo.Text = "Consultar movimientos";
                dialogo.StartPosition = FormStartPosition.CenterParent;
                dialogo.FormBorderStyle = FormBorderStyle.FixedDialog;
                dialogo.MaximizeBox = false;
                dialogo.MinimizeBox = false;
                dialogo.ShowInTaskbar = false;
                dialogo.ClientSize = new Size(360, 170);
                dialogo.BackColor = Color.White;

                Label lblPregunta = new Label
                {
                    Text = "¿A dónde desea ir?",
                    Font = new Font(
                        "Segoe UI",
                        11,
                        FontStyle.Bold
                    ),
                    ForeColor = Color.FromArgb(16, 42, 82),
                    AutoSize = true,
                    Location = new Point(105, 25)
                };

                Button btnEntradas = new Button
                {
                    Text = "Entradas",
                    Font = new Font(
                        "Segoe UI",
                        9,
                        FontStyle.Bold
                    ),
                    ForeColor = Color.White,
                    BackColor = Color.FromArgb(36, 111, 219),
                    FlatStyle = FlatStyle.Flat,
                    Size = new Size(110, 40),
                    Location = new Point(55, 70),
                    Cursor = Cursors.Hand
                };

                btnEntradas.FlatAppearance.BorderSize = 0;

                Button btnSalidas = new Button
                {
                    Text = "Salidas",
                    Font = new Font(
                        "Segoe UI",
                        9,
                        FontStyle.Bold
                    ),
                    ForeColor = Color.White,
                    BackColor = Color.FromArgb(36, 111, 219),
                    FlatStyle = FlatStyle.Flat,
                    Size = new Size(110, 40),
                    Location = new Point(195, 70),
                    Cursor = Cursors.Hand
                };

                btnSalidas.FlatAppearance.BorderSize = 0;

                btnEntradas.Click += (s, args) =>
                {
                    dialogo.DialogResult = DialogResult.Yes;
                    dialogo.Close();
                };

                btnSalidas.Click += (s, args) =>
                {
                    dialogo.DialogResult = DialogResult.No;
                    dialogo.Close();
                };

                dialogo.Controls.Add(lblPregunta);
                dialogo.Controls.Add(btnEntradas);
                dialogo.Controls.Add(btnSalidas);

                DialogResult resultado = dialogo.ShowDialog(this);

                if (resultado == DialogResult.Yes)
                {
                    if (this.ParentForm is frmLayouts layout)
                    {
                        layout.AbrirFormulario(new frmEntradas());
                    }
                }
                else if (resultado == DialogResult.No)
                {
                    if (this.ParentForm is frmLayouts layout)
                    {
                        layout.AbrirFormulario(new frmSalidas());
                    }
                }
            }
            else if (_rol == "Vendedor")
            {
                if (this.ParentForm is frmLayouts layout)
                {
                    layout.AbrirFormulario(new frmSalidas());
                }
            }
        }




    }
}
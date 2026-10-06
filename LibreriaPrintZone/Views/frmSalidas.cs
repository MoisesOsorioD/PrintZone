using LibreriaPrintZone.Controllers;
using LibreriaPrintZone.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace LibreriaPrintZone.Views
{
    public partial class frmSalidas : Form
    {
        private readonly SalidasController _controller;

        private List<SalidaListado> _salidas =
            new List<SalidaListado>();

        private int _idUsuarioActual = 0;

        private const int COLOR_AZUL_R = 220;
        private const int COLOR_AZUL_G = 233;
        private const int COLOR_AZUL_B = 247;

        private const int COLOR_ROJO_R = 247;
        private const int COLOR_ROJO_G = 220;
        private const int COLOR_ROJO_B = 220;

        public frmSalidas()
        {
            InitializeComponent();

            _controller = new SalidasController();

            ConfigurarFormulario();

            ConfigurarDataGridView();

            cmbProducto.SelectedIndexChanged +=
                cmbProducto_SelectedIndexChanged;

            txtBuscar.TextChanged +=
                txtBuscar_TextChanged;

            Load += frmSalidas_Load;
            CargarProductos();
            CargarSalidas();
        }


        private void frmSalidas_Load(
    object? sender,
    EventArgs e)
        {
            CargarUsuarioActual();
        }

        // =========================================================
        // CONFIGURAR FORMULARIO
        // =========================================================

        private void ConfigurarFormulario()
        {
            txtUsuario.ReadOnly = true;
            txtUsuario.TabStop = false;

            panelStockDisponible.BackColor =
                Color.FromArgb(
                    COLOR_AZUL_R,
                    COLOR_AZUL_G,
                    COLOR_AZUL_B
                );

            lblCantidadStock.Text = "0";

            cmbProducto.SelectedIndex = -1;
        }

        // =========================================================
        // CONFIGURAR DATAGRIDVIEW
        // =========================================================

        private void ConfigurarDataGridView()
        {
            dgvSalidas.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvSalidas.MultiSelect = false;
            dgvSalidas.ReadOnly = true;
            dgvSalidas.AllowUserToAddRows = false;
            dgvSalidas.AllowUserToDeleteRows = false;
            dgvSalidas.AutoGenerateColumns = false;
            dgvSalidas.ClearSelection();
        }

        // =========================================================
        // CARGAR USUARIO ACTUAL
        // =========================================================

        private void CargarUsuarioActual()
        {
            try
            {
                if (this.ParentForm is frmLayouts layout)
                {
                    _idUsuarioActual =
                        layout.IdUsuarioActual;

                    txtUsuario.Text =
                        layout.NombreUsuarioActual;
                }
                else
                {
                    txtUsuario.Text =
                        "Usuario no disponible";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se pudo cargar el usuario actual.\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // =========================================================
        // CARGAR PRODUCTOS
        // =========================================================

        private void CargarProductos()
        {
            try
            {
                List<ProductoListado> productos =
                    _controller.ObtenerProductos();

                cmbProducto.DataSource = null;
                cmbProducto.DataSource = productos;
                cmbProducto.DisplayMember = "nombre";
                cmbProducto.ValueMember = "id_producto";
                cmbProducto.SelectedIndex = -1;

                lblCantidadStock.Text = "0";

                panelStockDisponible.BackColor =
                    Color.FromArgb(
                        COLOR_AZUL_R,
                        COLOR_AZUL_G,
                        COLOR_AZUL_B
                    );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se pudieron cargar los productos.\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // =========================================================
        // PRODUCTO SELECCIONADO
        // =========================================================

        private void cmbProducto_SelectedIndexChanged(
            object? sender,
            EventArgs e)
        {
            if (cmbProducto.SelectedIndex == -1 ||
                cmbProducto.SelectedValue == null)
            {
                lblCantidadStock.Text = "0";

                panelStockDisponible.BackColor =
                    Color.FromArgb(
                        COLOR_AZUL_R,
                        COLOR_AZUL_G,
                        COLOR_AZUL_B
                    );

                return;
            }

            if (!int.TryParse(
                    cmbProducto.SelectedValue.ToString(),
                    out int idProducto))
            {
                lblCantidadStock.Text = "0";

                panelStockDisponible.BackColor =
                    Color.FromArgb(
                        COLOR_AZUL_R,
                        COLOR_AZUL_G,
                        COLOR_AZUL_B
                    );

                return;
            }

            CargarStockProducto(idProducto);
        }

        // =========================================================
        // CARGAR STOCK DEL PRODUCTO
        // =========================================================

        private void CargarStockProducto(
            int idProducto)
        {
            try
            {
                StockProducto? stock =
                    _controller.ObtenerStockProducto(
                        idProducto
                    );

                if (stock == null)
                {
                    lblCantidadStock.Text = "0";

                    panelStockDisponible.BackColor =
                        Color.FromArgb(
                            COLOR_AZUL_R,
                            COLOR_AZUL_G,
                            COLOR_AZUL_B
                        );

                    return;
                }

                lblCantidadStock.Text =
                    stock.stock_actual.ToString("N0");

                ActualizarAlertaStock(
                    stock.stock_actual,
                    stock.stock_minimo
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se pudo consultar el stock del producto.\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // =========================================================
        // ALERTA DE STOCK
        // =========================================================

        private void ActualizarAlertaStock(
            int stockActual,
            int stockMinimo)
        {
            if (stockActual <= stockMinimo)
            {
                panelStockDisponible.BackColor =
                    Color.FromArgb(
                        COLOR_ROJO_R,
                        COLOR_ROJO_G,
                        COLOR_ROJO_B
                    );
            }
            else
            {
                panelStockDisponible.BackColor =
                    Color.FromArgb(
                        COLOR_AZUL_R,
                        COLOR_AZUL_G,
                        COLOR_AZUL_B
                    );
            }
        }

        // =========================================================
        // CARGAR SALIDAS
        // =========================================================

        private void CargarSalidas()
        {
            try
            {
                _salidas =
                    _controller.ObtenerSalidas();

                MostrarSalidas(_salidas);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se pudieron cargar las salidas.\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // =========================================================
        // MOSTRAR SALIDAS
        // =========================================================

        private void MostrarSalidas(
            List<SalidaListado> salidas)
        {
            dgvSalidas.Rows.Clear();

            foreach (SalidaListado salida in salidas)
            {
                int fila = dgvSalidas.Rows.Add(
                    salida.fecha_salida.ToString(
                        "dd/MM/yyyy HH:mm"
                    ),
                    salida.nombre_producto,
                    salida.cantidad,
                    salida.motivo,
                    salida.nombre_usuario
                );

                dgvSalidas.Rows[fila].Tag =
                    salida.id_salida;
            }

            dgvSalidas.ClearSelection();
        }

        // =========================================================
        // REGISTRAR SALIDA
        // =========================================================

        private void btnRegistrarSalida_Click(
            object? sender,
            EventArgs e)
        {
            if (cmbProducto.SelectedIndex == -1 ||
                cmbProducto.SelectedValue == null)
            {
                MessageBox.Show(
                    "Seleccione un producto.",
                    "Producto no seleccionado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                cmbProducto.Focus();
                return;
            }

            if (_idUsuarioActual <= 0)
            {
                MessageBox.Show(
                    "No se pudo identificar al usuario actual.",
                    "Usuario no identificado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            if (!int.TryParse(
                    cmbProducto.SelectedValue.ToString(),
                    out int idProducto))
            {
                MessageBox.Show(
                    "El producto seleccionado no es válido.",
                    "Dato inválido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            if (!int.TryParse(
                    txtCantidad.Text.Trim(),
                    out int cantidad))
            {
                MessageBox.Show(
                    "Ingrese una cantidad válida.",
                    "Cantidad inválida",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtCantidad.Focus();
                return;
            }

            if (cantidad <= 0)
            {
                MessageBox.Show(
                    "La cantidad debe ser mayor que cero.",
                    "Cantidad inválida",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtCantidad.Focus();
                return;
            }

            StockProducto? stock =
                _controller.ObtenerStockProducto(
                    idProducto
                );

            if (stock == null)
            {
                MessageBox.Show(
                    "No se pudo obtener el stock del producto.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                return;
            }

            if (stock.stock_actual <= 0)
            {
                MessageBox.Show(
                    "El producto no tiene stock disponible.",
                    "Stock insuficiente",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            if (cantidad > stock.stock_actual)
            {
                MessageBox.Show(
                    "La cantidad solicitada es mayor que el stock disponible.\n\n" +
                    "Stock disponible: " +
                    stock.stock_actual,
                    "Stock insuficiente",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtCantidad.Focus();
                return;
            }

            string motivo =
                txtMotivo.Text.Trim();

            if (string.IsNullOrWhiteSpace(motivo))
            {
                MessageBox.Show(
                    "Ingrese el motivo de la salida.",
                    "Motivo requerido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtMotivo.Focus();
                return;
            }

            try
            {
                _controller.RegistrarSalida(
                    cantidad,
                    motivo,
                    _idUsuarioActual,
                    idProducto
                );

                MessageBox.Show(
                    "La salida se registró correctamente.",
                    "Salida registrada",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                LimpiarFormulario();

                CargarProductos();

                CargarSalidas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se pudo registrar la salida.\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // =========================================================
        // LIMPIAR
        // =========================================================

        private void btnLimpiar_Click(
            object? sender,
            EventArgs e)
        {
            LimpiarFormulario();
        }

        // =========================================================
        // LIMPIAR FORMULARIO
        // =========================================================

        private void LimpiarFormulario()
        {
            cmbProducto.SelectedIndex = -1;

            txtCantidad.Clear();
            txtMotivo.Clear();

            txtBuscar.Clear();

            lblCantidadStock.Text = "0";

            panelStockDisponible.BackColor =
                Color.FromArgb(
                    COLOR_AZUL_R,
                    COLOR_AZUL_G,
                    COLOR_AZUL_B
                );

            dgvSalidas.ClearSelection();

            txtCantidad.Focus();
        }

        // =========================================================
        // BUSCAR SALIDAS
        // =========================================================

        private void txtBuscar_TextChanged(
            object? sender,
            EventArgs e)
        {
            string texto =
                txtBuscar.Text.Trim();

            if (string.IsNullOrWhiteSpace(texto))
            {
                MostrarSalidas(_salidas);
                return;
            }

            try
            {
                List<SalidaListado> resultados =
                    _controller.BuscarSalidas(
                        texto
                    );

                MostrarSalidas(resultados);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se pudieron buscar las salidas.\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}
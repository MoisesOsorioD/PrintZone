using LibreriaPrintZone.Controllers;
using LibreriaPrintZone.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LibreriaPrintZone.Views
{
    public partial class frmEntradas : Form
    {
        private readonly EntradasController _controller;

        private List<EntradaListado> _entradas =
            new List<EntradaListado>();

        public frmEntradas()
        {
            InitializeComponent();

            _controller = new EntradasController();

            ConfigurarDataGridView();

            txtBuscar.TextChanged += txtBuscar_TextChanged;

            CargarProveedores();
            CargarProductos();
            CargarEntradas();
            ActualizarTarjetas();
        }

        // =========================================================
        // CONFIGURAR DATAGRIDVIEW
        // =========================================================

        private void ConfigurarDataGridView()
        {
            dgvEntradas.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvEntradas.MultiSelect = false;

            dgvEntradas.ReadOnly = true;

            dgvEntradas.AllowUserToAddRows = false;

            dgvEntradas.AllowUserToDeleteRows = false;

            dgvEntradas.AutoGenerateColumns = false;

            dgvEntradas.ClearSelection();
        }

        // =========================================================
        // CARGAR PROVEEDORES
        // =========================================================

        private void CargarProveedores()
        {
            try
            {
                List<Proveedore> proveedores =
                    _controller.ObtenerProveedores();

                cmbProveedor.DataSource = null;

                cmbProveedor.DataSource = proveedores;

                cmbProveedor.DisplayMember =
                    "NombreEmpresa";

                cmbProveedor.ValueMember =
                    "IdProveedor";

                cmbProveedor.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se pudieron cargar los proveedores.\n\n" +
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

                cmbProducto.DisplayMember =
                    "nombre";

                cmbProducto.ValueMember =
                    "id_producto";

                cmbProducto.SelectedIndex = -1;
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
        // CARGAR ENTRADAS
        // =========================================================

        private void CargarEntradas()
        {
            try
            {
                _entradas =
                    _controller.ObtenerEntradas();

                MostrarEntradas(_entradas);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se pudieron cargar las entradas.\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // =========================================================
        // MOSTRAR ENTRADAS
        // =========================================================

        private void MostrarEntradas(
            List<EntradaListado> entradas)
        {
            dgvEntradas.Rows.Clear();

            foreach (EntradaListado entrada in entradas)
            {
                int fila = dgvEntradas.Rows.Add(
                    entrada.fecha_entrada.ToString(
                        "dd/MM/yyyy HH:mm"
                    ),
                    entrada.nombre_producto,
                    entrada.nombre_empresa,
                    entrada.cantidad,
                    entrada.costo_lote.ToString("C2")
                );

                dgvEntradas.Rows[fila].Tag =
                    entrada.id_entrada;
            }

            dgvEntradas.ClearSelection();
        }

        // =========================================================
        // ACTUALIZAR TARJETAS
        // =========================================================

        private void ActualizarTarjetas()
        {
            try
            {
                int totalEntradas =
                    _controller.ObtenerTotalEntradas();

                int totalUnidades =
                    _controller.ObtenerTotalUnidades();

                decimal inversion =
                    _controller.ObtenerInversionInventario();

                lblTotalEntradas.Text =
                    totalEntradas.ToString("N0");

                lblUnidadesIngresadas.Text =
                    totalUnidades.ToString("N0");

                lblInversionInventario.Text =
                    inversion.ToString("C2");
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se pudieron actualizar las tarjetas.\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // =========================================================
        // REGISTRAR ENTRADA
        // =========================================================

        private void btnRegistrarEntrada_Click(
            object? sender,
            EventArgs e)
        {
            // -----------------------------------------------------
            // VALIDAR PROVEEDOR
            // -----------------------------------------------------

            if (cmbProveedor.SelectedIndex == -1 ||
                cmbProveedor.SelectedValue == null)
            {
                MessageBox.Show(
                    "Seleccione un proveedor.",
                    "Proveedor no seleccionado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                cmbProveedor.Focus();

                return;
            }

            // -----------------------------------------------------
            // VALIDAR PRODUCTO
            // -----------------------------------------------------

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

            // -----------------------------------------------------
            // OBTENER ID PROVEEDOR
            // -----------------------------------------------------

            if (!int.TryParse(
                    cmbProveedor.SelectedValue.ToString(),
                    out int idProveedor))
            {
                MessageBox.Show(
                    "El proveedor seleccionado no es válido.",
                    "Dato inválido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            // -----------------------------------------------------
            // OBTENER ID PRODUCTO
            // -----------------------------------------------------

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

            // -----------------------------------------------------
            // VALIDAR CANTIDAD
            // -----------------------------------------------------

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

            // -----------------------------------------------------
            // VALIDAR COSTO DEL LOTE
            // -----------------------------------------------------

            if (!decimal.TryParse(
                    txtCostoLote.Text.Trim(),
                    out decimal costoLote))
            {
                MessageBox.Show(
                    "Ingrese un costo de lote válido.",
                    "Costo inválido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtCostoLote.Focus();

                return;
            }

            if (costoLote < 0)
            {
                MessageBox.Show(
                    "El costo del lote no puede ser negativo.",
                    "Costo inválido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtCostoLote.Focus();

                return;
            }

            // -----------------------------------------------------
            // REGISTRAR
            // -----------------------------------------------------

            try
            {
                _controller.RegistrarEntrada(
                    cantidad,
                    costoLote,
                    idProveedor,
                    idProducto
                );

                MessageBox.Show(
                    "La entrada se registró correctamente.",
                    "Entrada registrada",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                LimpiarFormulario();

                CargarEntradas();

                ActualizarTarjetas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se pudo registrar la entrada.\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // =========================================================
        // LIMPIAR FORMULARIO
        // =========================================================

        private void btnLimpiar_Click(
            object? sender,
            EventArgs e)
        {
            LimpiarFormulario();
        }

        private void LimpiarFormulario()
        {
            cmbProveedor.SelectedIndex = -1;

            cmbProducto.SelectedIndex = -1;

            txtCantidad.Clear();

            txtCostoLote.Clear();

            txtBuscar.Clear();

            dgvEntradas.ClearSelection();

            txtCantidad.Focus();
        }

        // =========================================================
        // BUSCAR ENTRADAS
        // =========================================================

        private void txtBuscar_TextChanged(
            object? sender,
            EventArgs e)
        {
            string texto =
                txtBuscar.Text.Trim();

            if (string.IsNullOrWhiteSpace(texto))
            {
                MostrarEntradas(_entradas);

                return;
            }

            try
            {
                List<EntradaListado> resultados =
                    _controller.BuscarEntradas(texto);

                MostrarEntradas(resultados);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se pudieron buscar las entradas.\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}
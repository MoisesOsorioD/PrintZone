using LibreriaPrintZone.Controllers;
using System;
using System.Windows.Forms;

namespace LibreriaPrintZone.Views
{
    public partial class frmNuevoProductos : Form
    {
        private readonly ProductosController _controller;

        public frmNuevoProductos()
        {
            InitializeComponent();

            _controller = new ProductosController();

            CargarCategorias();
        }

        private void CargarCategorias()
        {
            try
            {
                cmbCategoria.DataSource =
                    _controller.ObtenerCategorias();

                cmbCategoria.DisplayMember = "NombreCategoria";
                cmbCategoria.ValueMember = "IdCategoria";

                cmbCategoria.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se pudieron cargar las categorías.\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();

            if (string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show(
                    "Ingrese el nombre del producto.",
                    "Campo obligatorio",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtNombre.Focus();
                return;
            }

            if (cmbCategoria.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Seleccione una categoría.",
                    "Campo obligatorio",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                cmbCategoria.Focus();
                return;
            }

            string? descripcion =
                string.IsNullOrWhiteSpace(txtDescripcion.Text)
                    ? null
                    : txtDescripcion.Text.Trim();

            string? marca =
                string.IsNullOrWhiteSpace(txtMarca.Text)
                    ? null
                    : txtMarca.Text.Trim();

            string? codigoBarras =
                string.IsNullOrWhiteSpace(txtCodigoBarras.Text)
                    ? null
                    : txtCodigoBarras.Text.Trim();

            decimal? precioCompra = null;

            if (!string.IsNullOrWhiteSpace(txtPrecioCompra.Text))
            {
                if (!decimal.TryParse(
                        txtPrecioCompra.Text.Trim(),
                        out decimal valorCompra) ||
                    valorCompra < 0)
                {
                    MessageBox.Show(
                        "Ingrese un precio de compra válido.",
                        "Dato inválido",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    txtPrecioCompra.Focus();
                    return;
                }

                precioCompra = valorCompra;
            }

            decimal? precioVenta = null;

            if (!string.IsNullOrWhiteSpace(txtPrecioVenta.Text))
            {
                if (!decimal.TryParse(
                        txtPrecioVenta.Text.Trim(),
                        out decimal valorVenta) ||
                    valorVenta < 0)
                {
                    MessageBox.Show(
                        "Ingrese un precio de venta válido.",
                        "Dato inválido",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    txtPrecioVenta.Focus();
                    return;
                }

                precioVenta = valorVenta;
            }

            int? stockMinimo = null;

            if (!string.IsNullOrWhiteSpace(txtStockMinimo.Text))
            {
                if (!int.TryParse(
                        txtStockMinimo.Text.Trim(),
                        out int valorStock) ||
                    valorStock < 0)
                {
                    MessageBox.Show(
                        "Ingrese un stock mínimo válido.",
                        "Dato inválido",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    txtStockMinimo.Focus();
                    return;
                }

                stockMinimo = valorStock;
            }

            int idCategoria = Convert.ToInt32(
                cmbCategoria.SelectedValue
            );

            try
            {
                _controller.InsertarProducto(
                    nombre,
                    descripcion,
                    marca,
                    precioCompra,
                    precioVenta,
                    codigoBarras,
                    stockMinimo,
                    idCategoria
                );

                MessageBox.Show(
                    "El producto se creó correctamente.",
                    "Producto creado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                LimpiarFormulario();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se pudo crear el producto.\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }




        private void LimpiarFormulario()
        {
            txtNombre.Clear();
            txtMarca.Clear();
            txtDescripcion.Clear();
            txtCodigoBarras.Clear();
            txtPrecioCompra.Clear();
            txtPrecioVenta.Clear();
            txtStockMinimo.Clear();

            cmbCategoria.SelectedIndex = -1;

            txtNombre.Focus();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (this.ParentForm is frmLayouts layout)
            {
                layout.AbrirFormulario(new frmProductos(layout.RolUsuarioActual));
            }
        }
    }
}
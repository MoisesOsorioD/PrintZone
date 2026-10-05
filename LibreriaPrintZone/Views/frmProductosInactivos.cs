using LibreriaPrintZone.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace LibreriaPrintZone.Views
{
    public partial class frmProductosInactivos : Form
    {
        private readonly ProductosController _controller;
        private List<ProductoListado> _productosInactivos = new List<ProductoListado>();

        private int _idProductoSeleccionado = 0;

        public frmProductosInactivos()
        {
            InitializeComponent();

            _controller = new ProductosController();

            ConfigurarDataGridView();

            txtBuscar.TextChanged += txtBuscar_TextChanged;
            dgvProductosInactivos.CellClick += dgvProductosInactivos_CellClick;
            

            CargarProductosInactivos();
        }

        private void ConfigurarDataGridView()
        {
            dgvProductosInactivos.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvProductosInactivos.MultiSelect = false;
            dgvProductosInactivos.ReadOnly = true;
            dgvProductosInactivos.AllowUserToAddRows = false;
            dgvProductosInactivos.AllowUserToDeleteRows = false;

            dgvProductosInactivos.AutoGenerateColumns = false;

            dgvProductosInactivos.ClearSelection();
        }

        private void CargarProductosInactivos()
        {
            try
            {
                _productosInactivos = _controller
                    .ObtenerProductosInactivos();

                MostrarProductos(_productosInactivos);

                _idProductoSeleccionado = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se pudieron cargar los productos inactivos.\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void MostrarProductos(List<ProductoListado> productos)
        {
            dgvProductosInactivos.Rows.Clear();

            foreach (ProductoListado producto in productos)
            {
                int fila = dgvProductosInactivos.Rows.Add(
                    producto.nombre,
                    producto.descripcion,
                    producto.marca,
                    producto.precio_compra.ToString("C2"),
                    producto.precio_venta.ToString("C2"),
                    producto.codigo_barras,
                    producto.stock_actual,
                    producto.stock_minimo,
                    producto.nombre_categoria
                );

                dgvProductosInactivos.Rows[fila].Tag =
                    producto.id_producto;
            }

            dgvProductosInactivos.ClearSelection();
        }

        private void txtBuscar_TextChanged(object? sender, EventArgs e)
        {
            string texto = txtBuscar.Text.Trim();

            if (string.IsNullOrWhiteSpace(texto))
            {
                MostrarProductos(_productosInactivos);
                return;
            }

            List<ProductoListado> resultados = _productosInactivos
                .Where(p =>
                    p.nombre.Contains(
                        texto,
                        StringComparison.OrdinalIgnoreCase
                    )
                    ||
                    (p.codigo_barras != null &&
                     p.codigo_barras.Contains(
                         texto,
                         StringComparison.OrdinalIgnoreCase
                     ))
                )
                .ToList();

            MostrarProductos(resultados);
        }

        private void dgvProductosInactivos_CellClick(
            object? sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow fila =
                dgvProductosInactivos.Rows[e.RowIndex];

            if (fila.Tag == null)
                return;

            _idProductoSeleccionado =
                Convert.ToInt32(fila.Tag);
        }

        private void btnReactivar_Click(object? sender, EventArgs e)
        {
            if (_idProductoSeleccionado == 0)
            {
                MessageBox.Show(
                    "Seleccione un producto para reactivarlo.",
                    "Producto no seleccionado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            DialogResult resultado = MessageBox.Show(
                "¿Está seguro que desea reactivar este producto?",
                "Reactivar producto",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resultado != DialogResult.Yes)
                return;

            try
            {
                _controller.ReactivarProducto(
                    _idProductoSeleccionado
                );

                MessageBox.Show(
                    "El producto se reactivó correctamente.",
                    "Producto reactivado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                _idProductoSeleccionado = 0;

                CargarProductosInactivos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se pudo reactivar el producto.\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}
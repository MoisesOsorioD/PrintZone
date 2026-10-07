using LibreriaPrintZone.Controllers;
using LibreriaPrintZone.Models;
using LibreriaPrintZone.Views;
using LibreriaPrintZone.Components;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace LibreriaPrintZone
{
    public partial class frmProductos : Form
    {
        private readonly ProductosController _productosController;
        private readonly PaginacionComponent _paginacion;
        private readonly string _rolUsuario;

        private int _idProductoSeleccionado = 0;
        private bool _activoProductoSeleccionado = true;


        public frmProductos(string rolUsuario)
        {
            InitializeComponent();

            _rolUsuario = rolUsuario;

            _productosController =
                new ProductosController();


            // =====================================================
            // CONFIGURAR PAGINACIÓN
            // =====================================================

            _paginacion =
                new PaginacionComponent(
                    panelPaginacion,
                    10
                );


            dgvProductos.CellClick +=
                dgvProductos_CellClick;


            ConfigurarFormulario();

            ConfigurarPermisos();

            CargarCategorias();

            CargarProductos();
        }


        // ==========================================
        // CONFIGURAR PERMISOS SEGÚN ROL
        // ==========================================

        private void ConfigurarPermisos()
        {
            bool esVendedor =
                _rolUsuario.Equals(
                    "Vendedor",
                    StringComparison.OrdinalIgnoreCase
                );


            if (!esVendedor)
                return;


            // ==========================================
            // VENDEDOR: SOLO CONSULTA
            // ==========================================

            btnNuevoProductos.Visible =
                false;

            btnProductosInactivos.Visible =
                false;

            btnGuardar.Visible =
                false;

            btnEliminar.Visible =
                false;


            // ==========================================
            // MOSTRAR SOLAMENTE LIMPIAR
            // ==========================================

            btnLimpiar.Visible =
                true;


            btnLimpiar.Location =
                btnNuevoProductos.Location;


            // ==========================================
            // CAMPOS SOLO PARA CONSULTA
            // ==========================================

            txtProducto.ReadOnly =
                true;

            txtDescripcion.ReadOnly =
                true;

            txtMarca.ReadOnly =
                true;

            txtCodigoBarras.ReadOnly =
                true;

            txtPrecioCompra.ReadOnly =
                true;

            txtPrecioVenta.ReadOnly =
                true;

            txtStockActual.ReadOnly =
                true;

            txtStockMinimo.ReadOnly =
                true;


            cmbCategoria.Enabled =
                false;
        }


        private void ConfigurarFormulario()
        {
            txtStockActual.ReadOnly =
                true;


            txtPrecioCompra.TextAlign =
                HorizontalAlignment.Right;


            txtPrecioVenta.TextAlign =
                HorizontalAlignment.Right;


            txtStockActual.TextAlign =
                HorizontalAlignment.Center;


            txtStockMinimo.TextAlign =
                HorizontalAlignment.Center;


            ConfigurarGrid();
        }


        private void ConfigurarGrid()
        {
            dgvProductos.AutoGenerateColumns =
                false;

            dgvProductos.Columns.Clear();


            dgvProductos.Columns.Add(
                CrearColumna(
                    "colProducto",
                    "Producto",
                    "nombre",
                    120
                )
            );


            dgvProductos.Columns.Add(
                CrearColumna(
                    "colDescripcion",
                    "Descripción",
                    "descripcion",
                    150
                )
            );


            dgvProductos.Columns.Add(
                CrearColumna(
                    "colMarca",
                    "Marca",
                    "marca",
                    100
                )
            );


            dgvProductos.Columns.Add(
                CrearColumna(
                    "colPrecioCompra",
                    "Precio de compra",
                    "precio_compra",
                    100
                )
            );


            dgvProductos.Columns.Add(
                CrearColumna(
                    "colPrecioVenta",
                    "Precio de venta",
                    "precio_venta",
                    100
                )
            );


            dgvProductos.Columns.Add(
                CrearColumna(
                    "colCodigoBarras",
                    "Código de barras",
                    "codigo_barras",
                    110
                )
            );


            dgvProductos.Columns.Add(
                CrearColumna(
                    "colStockActual",
                    "Stock actual",
                    "stock_actual",
                    85
                )
            );


            dgvProductos.Columns.Add(
                CrearColumna(
                    "colStockMinimo",
                    "Stock mínimo",
                    "stock_minimo",
                    85
                )
            );


            dgvProductos.Columns.Add(
                CrearColumna(
                    "colCategoria",
                    "Categoría",
                    "nombre_categoria",
                    100
                )
            );


            dgvProductos.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;


            dgvProductos.MultiSelect =
                false;


            dgvProductos.ReadOnly =
                true;


            dgvProductos.AllowUserToAddRows =
                false;


            dgvProductos.AllowUserToDeleteRows =
                false;


            dgvProductos.AllowUserToResizeRows =
                false;


            dgvProductos.AutoSizeRowsMode =
                DataGridViewAutoSizeRowsMode.None;


            dgvProductos.RowHeadersVisible =
                false;
        }


        private DataGridViewTextBoxColumn CrearColumna(
            string nombre,
            string encabezado,
            string propiedad,
            int ancho)
        {
            return new DataGridViewTextBoxColumn
            {
                Name = nombre,
                HeaderText = encabezado,
                DataPropertyName = propiedad,
                Width = ancho,
                SortMode =
                    DataGridViewColumnSortMode.NotSortable
            };
        }


        // =========================================================
        // CARGAR CATEGORÍAS
        // =========================================================

        private void CargarCategorias()
        {
            try
            {
                List<Categoria> categorias =
                    _productosController
                        .ObtenerCategorias();


                cmbCategoria.DataSource =
                    categorias;


                cmbCategoria.DisplayMember =
                    "NombreCategoria";


                cmbCategoria.ValueMember =
                    "IdCategoria";


                cmbCategoria.SelectedIndex =
                    -1;
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


        // =========================================================
        // CARGAR PRODUCTOS
        // =========================================================

        private void CargarProductos()
        {
            try
            {
                List<ProductoListado> productos =
                    _productosController
                        .ObtenerProductos();


                // =================================================
                // LA PAGINACIÓN CONTROLA QUÉ PRODUCTOS SE MUESTRAN
                // =================================================

                _paginacion.Configurar(
                    productos,
                    MostrarProductos
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
        // MOSTRAR PRODUCTOS DE LA PÁGINA ACTUAL
        // =========================================================

        private void MostrarProductos(
            List<ProductoListado> productos)
        {
            dgvProductos.DataSource =
                productos;


            dgvProductos.ClearSelection();
        }


        // =========================================================
        // BUSCAR PRODUCTOS
        // =========================================================

        private void BuscarProductos()
        {
            try
            {
                string texto =
                    txtBuscar.Text.Trim();


                List<ProductoListado> productos;


                if (
                    string.IsNullOrWhiteSpace(
                        texto
                    )
                )
                {
                    productos =
                        _productosController
                            .ObtenerProductos();
                }
                else
                {
                    productos =
                        _productosController
                            .BuscarProductos(
                                texto
                            );
                }


                // =================================================
                // PAGINAR RESULTADOS
                // =================================================

                _paginacion.Configurar(
                    productos,
                    MostrarProductos
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se pudieron buscar los productos.\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }


        // =========================================================
        // SELECCIONAR PRODUCTO
        // =========================================================

        private void dgvProductos_CellClick(
            object? sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;


            if (
                dgvProductos.Rows[e.RowIndex]
                    .DataBoundItem
                    is not ProductoListado producto
            )
            {
                return;
            }


            _idProductoSeleccionado =
                producto.id_producto;


            _activoProductoSeleccionado =
                producto.activo;


            txtProducto.Text =
                producto.nombre;


            txtDescripcion.Text =
                producto.descripcion ?? "";


            txtMarca.Text =
                producto.marca ?? "";


            txtCodigoBarras.Text =
                producto.codigo_barras ?? "";


            txtPrecioCompra.Text =
                producto.precio_compra
                    .ToString("0.00");


            txtPrecioVenta.Text =
                producto.precio_venta
                    .ToString("0.00");


            txtStockActual.Text =
                producto.stock_actual
                    .ToString();


            txtStockMinimo.Text =
                producto.stock_minimo
                    .ToString();


            cmbCategoria.SelectedValue =
                producto.id_categoria;
        }


        // =========================================================
        // GUARDAR / ACTUALIZAR
        // =========================================================

        private void btnGuardar_Click(
            object? sender,
            EventArgs e)
        {
            if (
                _rolUsuario.Equals(
                    "Vendedor",
                    StringComparison.OrdinalIgnoreCase
                )
            )
            {
                return;
            }


            if (
                _idProductoSeleccionado == 0
            )
            {
                MessageBox.Show(
                    "Seleccione un producto para actualizar.",
                    "Producto",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );


                return;
            }


            if (!ValidarDatos())
                return;


            try
            {
                decimal precioCompra =
                    ObtenerDecimal(
                        txtPrecioCompra.Text
                    );


                decimal precioVenta =
                    ObtenerDecimal(
                        txtPrecioVenta.Text
                    );


                int stockMinimo =
                    int.Parse(
                        txtStockMinimo.Text.Trim()
                    );


                int idCategoria =
                    Convert.ToInt32(
                        cmbCategoria.SelectedValue
                    );


                _productosController
                    .ActualizarProducto(
                        _idProductoSeleccionado,
                        txtProducto.Text.Trim(),
                        txtDescripcion.Text.Trim(),
                        txtMarca.Text.Trim(),
                        precioCompra,
                        precioVenta,
                        txtCodigoBarras.Text.Trim(),
                        stockMinimo,
                        idCategoria,
                        _activoProductoSeleccionado
                    );


                MessageBox.Show(
                    "El producto se actualizó correctamente.",
                    "Producto",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );


                CargarProductos();

                LimpiarFormulario();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se pudo actualizar el producto.\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }


        // =========================================================
        // DESACTIVAR PRODUCTO
        // =========================================================

        private void btnEliminar_Click(
            object? sender,
            EventArgs e)
        {
            if (
                _rolUsuario.Equals(
                    "Vendedor",
                    StringComparison.OrdinalIgnoreCase
                )
            )
            {
                return;
            }


            if (
                _idProductoSeleccionado == 0
            )
            {
                MessageBox.Show(
                    "Seleccione un producto para eliminar.",
                    "Producto",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );


                return;
            }


            DialogResult resultado =
                MessageBox.Show(
                    "¿Está seguro que desea desactivar este producto?",
                    "Desactivar producto",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );


            if (
                resultado !=
                DialogResult.Yes
            )
            {
                return;
            }


            try
            {
                _productosController
                    .DesactivarProducto(
                        _idProductoSeleccionado
                    );


                MessageBox.Show(
                    "El producto se desactivó correctamente.",
                    "Producto",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );


                CargarProductos();

                LimpiarFormulario();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se pudo desactivar el producto.\n\n" +
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


        private void LimpiarFormulario()
        {
            _idProductoSeleccionado =
                0;


            _activoProductoSeleccionado =
                true;


            txtProducto.Clear();

            txtDescripcion.Clear();

            txtMarca.Clear();

            txtCodigoBarras.Clear();

            txtPrecioCompra.Clear();

            txtPrecioVenta.Clear();

            txtStockActual.Clear();

            txtStockMinimo.Clear();


            cmbCategoria.SelectedIndex =
                -1;


            dgvProductos.ClearSelection();
        }


        // =========================================================
        // NUEVO PRODUCTO
        // =========================================================

        private void btnNuevoProducto_Click(
            object? sender,
            EventArgs e)
        {
            if (
                _rolUsuario.Equals(
                    "Vendedor",
                    StringComparison.OrdinalIgnoreCase
                )
            )
            {
                return;
            }


            if (
                this.ParentForm
                is frmLayouts layout
            )
            {
                layout.AbrirFormulario(
                    new frmNuevoProductos()
                );
            }
        }


        // =========================================================
        // BUSCAR
        // =========================================================

        private void txtBuscar_TextChanged(
            object? sender,
            EventArgs e)
        {
            BuscarProductos();
        }


        // =========================================================
        // VALIDAR DATOS
        // =========================================================

        private bool ValidarDatos()
        {
            if (
                string.IsNullOrWhiteSpace(
                    txtProducto.Text
                )
            )
            {
                MessageBox.Show(
                    "Ingrese el nombre del producto.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );


                txtProducto.Focus();

                return false;
            }


            if (
                cmbCategoria.SelectedIndex == -1
            )
            {
                MessageBox.Show(
                    "Seleccione una categoría.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );


                cmbCategoria.Focus();

                return false;
            }


            if (
                !ObtenerDecimalSeguro(
                    txtPrecioCompra.Text,
                    out decimal precioCompra
                )
            )
            {
                MessageBox.Show(
                    "El precio de compra no es válido.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );


                txtPrecioCompra.Focus();

                return false;
            }


            if (
                !ObtenerDecimalSeguro(
                    txtPrecioVenta.Text,
                    out decimal precioVenta
                )
            )
            {
                MessageBox.Show(
                    "El precio de venta no es válido.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );


                txtPrecioVenta.Focus();

                return false;
            }


            if (
                !int.TryParse(
                    txtStockMinimo.Text.Trim(),
                    out int stockMinimo
                )
            )
            {
                MessageBox.Show(
                    "El stock mínimo debe ser un número entero.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );


                txtStockMinimo.Focus();

                return false;
            }


            if (precioCompra < 0)
            {
                MessageBox.Show(
                    "El precio de compra no puede ser negativo.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );


                txtPrecioCompra.Focus();

                return false;
            }


            if (precioVenta < 0)
            {
                MessageBox.Show(
                    "El precio de venta no puede ser negativo.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );


                txtPrecioVenta.Focus();

                return false;
            }


            if (stockMinimo < 0)
            {
                MessageBox.Show(
                    "El stock mínimo no puede ser negativo.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );


                txtStockMinimo.Focus();

                return false;
            }


            return true;
        }


        // =========================================================
        // OBTENER DECIMAL
        // =========================================================

        private decimal ObtenerDecimal(
            string texto)
        {
            texto =
                texto
                    .Replace("C$", "")
                    .Replace("$", "")
                    .Trim();


            if (
                decimal.TryParse(
                    texto,
                    NumberStyles.Number,
                    CultureInfo.CurrentCulture,
                    out decimal resultado
                )
            )
            {
                return resultado;
            }


            return 0;
        }


        // =========================================================
        // OBTENER DECIMAL SEGURO
        // =========================================================

        private bool ObtenerDecimalSeguro(
            string texto,
            out decimal resultado)
        {
            texto =
                texto
                    .Replace("C$", "")
                    .Replace("$", "")
                    .Trim();


            return decimal.TryParse(
                texto,
                NumberStyles.Number,
                CultureInfo.CurrentCulture,
                out resultado
            );
        }


        // =========================================================
        // PRODUCTOS INACTIVOS
        // =========================================================

        private void btnProductosInactivos_Click(
            object sender,
            EventArgs e)
        {
            if (
                _rolUsuario.Equals(
                    "Vendedor",
                    StringComparison.OrdinalIgnoreCase
                )
            )
            {
                return;
            }


            if (
                this.ParentForm
                is frmLayouts layout
            )
            {
                layout.AbrirFormulario(
                    new frmProductosInactivos()
                );
            }
        }
    }
}
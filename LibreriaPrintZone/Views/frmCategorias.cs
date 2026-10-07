using System;
using System.Collections.Generic;
using System.Windows.Forms;
using LibreriaPrintZone.Controllers;
using LibreriaPrintZone.Components;

namespace LibreriaPrintZone
{
    public partial class frmCategorias : Form
    {
        private readonly CategoriasController _controller;
        private readonly PaginacionComponent _paginacion;

        public frmCategorias()
        {
            InitializeComponent();

            dgvCategorias.AutoGenerateColumns = false;

            _controller = new CategoriasController();

            _paginacion =
                new PaginacionComponent(
                    panelPaginacion,
                    10
                );

            txtBuscar.TextChanged += txtBuscar_TextChanged;
            dgvCategorias.CellClick += dgvCategorias_CellClick;

            CargarCategorias();
        }

        private void CargarCategorias()
        {
            try
            {
                var categorias =
                    _controller.ObtenerCategorias();

                lblTotalCategorias.Text =
                    _controller
                        .ObtenerTotalCategorias()
                        .ToString();

                var categoriaMasProductos =
                    _controller
                        .ObtenerCategoriaMasProductos();

                if (categoriaMasProductos != null)
                {
                    lblCategoriaMasProductos.Text =
                        categoriaMasProductos.NombreCategoria;

                    lblCantidadMasProductos.Text =
                        $"{categoriaMasProductos.Productos.Count} productos";
                }
                else
                {
                    lblCategoriaMasProductos.Text = "-";
                    lblCantidadMasProductos.Text =
                        "0 productos";
                }

                var categoriaMenosProductos =
                    _controller
                        .ObtenerCategoriaMenosProductos();

                if (categoriaMenosProductos != null)
                {
                    lblCategoriaMenosUsada.Text =
                        categoriaMenosProductos.NombreCategoria;

                    lblCantidadMenosUsada.Text =
                        $"{categoriaMenosProductos.Productos.Count} productos";
                }
                else
                {
                    lblCategoriaMenosUsada.Text = "-";
                    lblCantidadMenosUsada.Text =
                        "0 productos";
                }

                _paginacion.Configurar(
                    categorias,
                    MostrarCategorias
                );

                txtNombreCategoria.Clear();
                txtNombreCategoria.Tag = null;

                btnGuardar.Text = "Guardar";
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

        private void MostrarCategorias(
            List<LibreriaPrintZone.Models.Categoria> categorias)
        {
            dgvCategorias.Rows.Clear();

            foreach (
                var categoria
                in categorias
            )
            {
                int fila =
                    dgvCategorias.Rows.Add(
                        categoria.NombreCategoria,
                        categoria.Productos.Count
                    );

                dgvCategorias.Rows[fila].Tag =
                    categoria.IdCategoria;
            }

            dgvCategorias.ClearSelection();
        }

        private void dgvCategorias_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow fila =
                dgvCategorias.Rows[e.RowIndex];

            txtNombreCategoria.Text =
                fila.Cells[
                    "colNombreCategoria"
                ].Value?.ToString();

            txtNombreCategoria.Tag =
                fila.Tag;

            btnGuardar.Text = "Actualizar";
        }

        private void btnGuardar_Click(
            object sender,
            EventArgs e)
        {
            string nombreCategoria =
                txtNombreCategoria.Text.Trim();

            if (
                string.IsNullOrWhiteSpace(
                    nombreCategoria
                )
            )
            {
                MessageBox.Show(
                    "Ingrese el nombre de la categoría.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            try
            {
                if (txtNombreCategoria.Tag == null)
                {
                    _controller.GuardarCategoria(
                        nombreCategoria
                    );

                    MessageBox.Show(
                        "Categoría guardada correctamente.",
                        "Categorías",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
                else
                {
                    int idCategoria =
                        Convert.ToInt32(
                            txtNombreCategoria.Tag
                        );

                    _controller.ActualizarCategoria(
                        idCategoria,
                        nombreCategoria
                    );

                    MessageBox.Show(
                        "Categoría actualizada correctamente.",
                        "Categorías",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }

                txtNombreCategoria.Clear();
                txtNombreCategoria.Tag = null;

                btnGuardar.Text = "Guardar";

                CargarCategorias();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se pudo guardar la categoría.\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btnEliminar_Click(
            object sender,
            EventArgs e)
        {
            if (txtNombreCategoria.Tag == null)
            {
                MessageBox.Show(
                    "Seleccione una categoría para eliminar.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            DialogResult resultado =
                MessageBox.Show(
                    $"¿Está seguro de eliminar la categoría \"{txtNombreCategoria.Text}\"?",
                    "Confirmar eliminación",
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
                int idCategoria =
                    Convert.ToInt32(
                        txtNombreCategoria.Tag
                    );

                bool eliminada =
                    _controller.EliminarCategoria(
                        idCategoria
                    );

                if (!eliminada)
                {
                    MessageBox.Show(
                        "No se puede eliminar esta categoría porque tiene productos asociados.",
                        "Categoría en uso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    return;
                }

                MessageBox.Show(
                    "Categoría eliminada correctamente.",
                    "Categorías",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                txtNombreCategoria.Clear();
                txtNombreCategoria.Tag = null;

                btnGuardar.Text = "Guardar";

                CargarCategorias();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se pudo eliminar la categoría.\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btnLimpiar_Click(
            object sender,
            EventArgs e)
        {
            txtNombreCategoria.Clear();
            txtNombreCategoria.Tag = null;

            btnGuardar.Text = "Guardar";

            dgvCategorias.ClearSelection();
        }

        private void txtBuscar_TextChanged(
            object sender,
            EventArgs e)
        {
            string texto =
                txtBuscar.Text.Trim();

            try
            {
                var categorias =
                    string.IsNullOrWhiteSpace(texto)
                        ? _controller.ObtenerCategorias()
                        : _controller.BuscarCategorias(
                            texto
                        );

                _paginacion.Configurar(
                    categorias,
                    MostrarCategorias
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se pudieron buscar las categorías.\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}
using LibreriaPrintZone.Controllers;
using LibreriaPrintZone.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LibreriaPrintZone.Views
{
    public partial class frmUsuarios : Form
    {
        private readonly UsuariosController _controller;

        private List<Usuario> _usuarios =
            new List<Usuario>();

        private int _idUsuarioSeleccionado = 0;

        public frmUsuarios()
        {
            InitializeComponent();

            _controller = new UsuariosController();

            ConfigurarFormulario();

            ConfigurarDataGridView();

            txtBuscar.TextChanged +=
                txtBuscar_TextChanged;

            dgvUsuarios.CellClick +=
                dgvUsuarios_CellClick;

            CargarUsuarios();
            ActualizarTarjetas();
        }

        // =========================================================
        // CONFIGURAR FORMULARIO
        // =========================================================

        private void ConfigurarFormulario()
        {
            btnGuardar.Text = "Guardar";

            chkActivo.Checked = true;

            dtpFechaCreacion.Value =
                DateTime.Now;

            dtpFechaCreacion.Enabled = false;
        }

        // =========================================================
        // CONFIGURAR DATAGRIDVIEW
        // =========================================================

        private void ConfigurarDataGridView()
        {
            dgvUsuarios.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvUsuarios.MultiSelect = false;
            dgvUsuarios.ReadOnly = true;
            dgvUsuarios.AllowUserToAddRows = false;
            dgvUsuarios.AllowUserToDeleteRows = false;
            dgvUsuarios.AutoGenerateColumns = false;

            dgvUsuarios.ClearSelection();
        }

        // =========================================================
        // CARGAR USUARIOS
        // =========================================================

        private void CargarUsuarios()
        {
            try
            {
                _usuarios =
                    _controller.ObtenerUsuarios();

                MostrarUsuarios(_usuarios);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se pudieron cargar los usuarios.\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // =========================================================
        // MOSTRAR USUARIOS
        // =========================================================

        private void MostrarUsuarios(
            List<Usuario> usuarios)
        {
            dgvUsuarios.Rows.Clear();

            foreach (Usuario usuario in usuarios)
            {
                string estado =
                    usuario.Activo
                        ? "Activo"
                        : "Inactivo";

                int fila = dgvUsuarios.Rows.Add(
                    usuario.NombreUsuario,
                    usuario.NombreCompleto,
                    usuario.Rol,
                    estado,
                    usuario.FechaCreacion.ToString(
                        "dd/MM/yyyy"
                    )
                );

                dgvUsuarios.Rows[fila].Tag =
                    usuario.IdUsuario;
            }

            dgvUsuarios.ClearSelection();
        }

        // =========================================================
        // SELECCIONAR USUARIO
        // =========================================================

        private void dgvUsuarios_CellClick(
            object? sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            if (dgvUsuarios.Rows[e.RowIndex].Tag == null)
            {
                return;
            }

            if (!int.TryParse(
                    dgvUsuarios.Rows[e.RowIndex]
                        .Tag
                        .ToString(),
                    out int idUsuario))
            {
                return;
            }

            CargarUsuarioEnFormulario(idUsuario);
        }

        // =========================================================
        // CARGAR USUARIO EN FORMULARIO
        // =========================================================

        private void CargarUsuarioEnFormulario(
            int idUsuario)
        {
            try
            {
                Usuario? usuario =
                    _controller.ObtenerUsuarioPorId(
                        idUsuario
                    );

                if (usuario == null)
                {
                    MessageBox.Show(
                        "No se encontró el usuario seleccionado.",
                        "Usuario no encontrado",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    return;
                }

                _idUsuarioSeleccionado =
                    usuario.IdUsuario;

                txtNombreUsuario.Text =
                    usuario.NombreUsuario;

                txtNombreCompleto.Text =
                    usuario.NombreCompleto;

                txtClave.Text =
                    usuario.Clave;

                cmbRol.Text =
                    usuario.Rol;

                chkActivo.Checked =
                    usuario.Activo;

                dtpFechaCreacion.Value =
                    usuario.FechaCreacion;

                btnGuardar.Text =
                    "Actualizar";
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se pudo cargar el usuario.\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // =========================================================
        // GUARDAR / ACTUALIZAR
        // =========================================================

        private void btnGuardar_Click(
            object? sender,
            EventArgs e)
        {
            string nombreUsuario =
                txtNombreUsuario.Text.Trim();

            string nombreCompleto =
                txtNombreCompleto.Text.Trim();

            string clave =
                txtClave.Text;

            string rol =
                cmbRol.Text.Trim();

            bool activo =
                chkActivo.Checked;

            // -----------------------------------------------------
            // VALIDAR NOMBRE DE USUARIO
            // -----------------------------------------------------

            if (string.IsNullOrWhiteSpace(nombreUsuario))
            {
                MessageBox.Show(
                    "Ingrese el nombre de usuario.",
                    "Dato requerido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtNombreUsuario.Focus();
                return;
            }

            // -----------------------------------------------------
            // VALIDAR NOMBRE COMPLETO
            // -----------------------------------------------------

            if (string.IsNullOrWhiteSpace(nombreCompleto))
            {
                MessageBox.Show(
                    "Ingrese el nombre completo.",
                    "Dato requerido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtNombreCompleto.Focus();
                return;
            }

            // -----------------------------------------------------
            // VALIDAR CLAVE
            // -----------------------------------------------------

            if (string.IsNullOrWhiteSpace(clave))
            {
                MessageBox.Show(
                    "Ingrese la contraseña.",
                    "Dato requerido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtClave.Focus();
                return;
            }

            // -----------------------------------------------------
            // VALIDAR ROL
            // -----------------------------------------------------

            if (string.IsNullOrWhiteSpace(rol))
            {
                MessageBox.Show(
                    "Seleccione un rol.",
                    "Dato requerido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                cmbRol.Focus();
                return;
            }

            try
            {
                // =================================================
                // NUEVO USUARIO
                // =================================================

                if (_idUsuarioSeleccionado == 0)
                {
                    _controller.GuardarUsuario(
                        nombreUsuario,
                        nombreCompleto,
                        clave,
                        rol,
                        activo
                    );

                    MessageBox.Show(
                        "El usuario se registró correctamente.",
                        "Usuario registrado",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }

                // =================================================
                // ACTUALIZAR USUARIO
                // =================================================

                else
                {
                    _controller.ActualizarUsuario(
                        _idUsuarioSeleccionado,
                        nombreUsuario,
                        nombreCompleto,
                        clave,
                        rol,
                        activo
                    );

                    MessageBox.Show(
                        "El usuario se actualizó correctamente.",
                        "Usuario actualizado",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }

                LimpiarFormulario();

                CargarUsuarios();

                ActualizarTarjetas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se pudo guardar el usuario.\n\n" +
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
            _idUsuarioSeleccionado = 0;

            txtNombreUsuario.Clear();
            txtNombreCompleto.Clear();
            txtClave.Clear();

            cmbRol.SelectedIndex = -1;
            cmbRol.Text = "";

            chkActivo.Checked = true;

            dtpFechaCreacion.Value =
                DateTime.Now;

            btnGuardar.Text =
                "Guardar";

            dgvUsuarios.ClearSelection();

            txtNombreUsuario.Focus();
        }

        // =========================================================
        // BUSCAR USUARIOS
        // =========================================================

        private void txtBuscar_TextChanged(
            object? sender,
            EventArgs e)
        {
            string texto =
                txtBuscar.Text.Trim();

            if (string.IsNullOrWhiteSpace(texto))
            {
                MostrarUsuarios(_usuarios);
                return;
            }

            try
            {
                List<Usuario> resultados =
                    _controller.BuscarUsuarios(
                        texto
                    );

                MostrarUsuarios(resultados);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se pudieron buscar los usuarios.\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // =========================================================
        // ACTUALIZAR TARJETAS
        // =========================================================

        private void ActualizarTarjetas()
        {
            try
            {
                int totalUsuarios =
                    _controller.ObtenerTotalUsuarios();

                int usuariosActivos =
                    _controller.ObtenerUsuariosActivos();

                int usuariosDesactivados =
                    _controller.ObtenerUsuariosDesactivados();

                lblTotalUsuarios.Text =
                    totalUsuarios.ToString("N0");

                lblUsuariosActivos.Text =
                    usuariosActivos.ToString("N0");

                lblUsuariosDesactivados.Text =
                    usuariosDesactivados.ToString("N0");
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
    }
}
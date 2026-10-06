using LibreriaPrintZone.Controllers;
using LibreriaPrintZone.Models;
using LibreriaPrintZone.Views;

namespace LibreriaPrintZone
{
    public partial class frmInicioSesion : Form
    {
        private readonly UsuariosController _usuariosController;

        public frmInicioSesion()
        {
            InitializeComponent();

            _usuariosController = new UsuariosController();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            string nombreUsuario = txtUsuario.Text.Trim();
            string clave = txtContra.Text;

            if (string.IsNullOrWhiteSpace(nombreUsuario))
            {
                MessageBox.Show(
                    "Ingrese su nombre de usuario.",
                    "Inicio de sesión",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtUsuario.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(clave))
            {
                MessageBox.Show(
                    "Ingrese su contraseña.",
                    "Inicio de sesión",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtContra.Focus();
                return;
            }

            try
            {
                UsuarioLogin? usuario = _usuariosController.IniciarSesion(
                    nombreUsuario,
                    clave
                );

                if (usuario == null)
                {
                    MessageBox.Show(
                        "El usuario o la contraseña son incorrectos.",
                        "Inicio de sesión",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    txtContra.Clear();
                    txtContra.Focus();

                    return;
                }

                frmLayouts principal = new frmLayouts(
                    usuario.IdUsuario,
                    usuario.Rol,
                    usuario.NombreUsuario,
                    usuario.NombreCompleto
                    );

                principal.Show();

                this.Hide();

                principal.FormClosed += (s, args) =>
                {
                    this.Close();
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Ocurrió un error al iniciar sesión.\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}
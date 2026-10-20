
using LibreriaPrintZone.Components;
using LibreriaPrintZone.Controllers;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace LibreriaPrintZone.Views
{
    public partial class frmConfiguracion : Form
    {
        private Panel _panelRespaldoAutomatico;

        private readonly string cadenaConexion =
            "Server=ELMK;Database=Inventario_Printzone;Trusted_Connection=True;TrustServerCertificate=True;";

        private const string carpetaPredeterminada =
            @"C:\SQLBackups\PrintZone";

        private readonly int _idUsuarioActual;
        private readonly string _nombreCompletoUsuario;
        private readonly string _nombreUsuario;
        private readonly string _rolUsuario;

        public frmConfiguracion(
            int idUsuario,
            string nombreCompleto,
            string nombreUsuario,
            string rolUsuario)
        {
            InitializeComponent();

            _idUsuarioActual = idUsuario;
            _nombreCompletoUsuario = nombreCompleto;
            _nombreUsuario = nombreUsuario;
            _rolUsuario = rolUsuario;

            CargarDatosRespaldo();
            CargarUltimoRespaldo();
        }

        private void CargarDatosRespaldo()
        {
            txtUbicacionRespaldo.Text = carpetaPredeterminada;

            try
            {
                using (SqlConnection conexion =
                       new SqlConnection(cadenaConexion))
                {
                    conexion.Open();

                    using (SqlCommand comando =
                           new SqlCommand("SELECT DB_NAME()", conexion))
                    {
                        lblNombreBaseDatos.Text =
                            comando.ExecuteScalar()?.ToString() ?? "";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se pudo obtener el nombre de la base de datos:\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void CargarUltimoRespaldo()
        {
            try
            {
                string carpeta = txtUbicacionRespaldo.Text.Trim();

                if (string.IsNullOrWhiteSpace(carpeta) ||
                    !Directory.Exists(carpeta))
                {
                    lblFechaHoraUltimoRespaldo.Text = "No disponible";
                    lblNombreUltimoRespaldo.Text = "No disponible";
                    lblEstadoUltimoRespaldo.Text = "Carpeta no encontrada";
                    return;
                }

                string ultimoArchivo = Directory
                    .GetFiles(carpeta, "*.bak")
                    .OrderByDescending(
                        archivo => File.GetLastWriteTime(archivo))
                    .FirstOrDefault();

                if (ultimoArchivo == null)
                {
                    lblFechaHoraUltimoRespaldo.Text = "Sin respaldos";
                    lblNombreUltimoRespaldo.Text = "No hay archivos .bak";
                    lblEstadoUltimoRespaldo.Text =
                        "No hay respaldos disponibles";
                    return;
                }

                FileInfo informacion = new FileInfo(ultimoArchivo);

                lblFechaHoraUltimoRespaldo.Text =
                    informacion.LastWriteTime.ToString("dd/MM/yyyy hh:mm tt");

                lblNombreUltimoRespaldo.Text = informacion.Name;

                lblEstadoUltimoRespaldo.Text =
                    "Último respaldo encontrado";
            }
            catch (Exception ex)
            {
                lblFechaHoraUltimoRespaldo.Text = "No disponible";
                lblNombreUltimoRespaldo.Text = "No disponible";
                lblEstadoUltimoRespaldo.Text = "Error al consultar";

                MessageBox.Show(
                    "No se pudo consultar el último respaldo:\n" +
                    ex.Message,
                    "Último respaldo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnRespaldoManual_Click(object sender, EventArgs e)
        {
            if (_panelRespaldoAutomatico != null)
            {
                _panelRespaldoAutomatico.Visible = false;
            }

            pnlRespaldoManual.Visible = true;
            pnlRespaldoManual.BringToFront();
        }

        private void btnRespaldoAutomatico_Click(object sender, EventArgs e)
        {
            if (_panelRespaldoAutomatico == null)
            {
                using (frmRespaldoAutomatico formulario =
                       new frmRespaldoAutomatico())
                {
                    _panelRespaldoAutomatico =
                        formulario.ObtenerPanelRespaldoAutomatico();

                    formulario.Controls.Remove(_panelRespaldoAutomatico);
                }

                _panelRespaldoAutomatico.Location =
                    pnlRespaldoManual.Location;

                _panelRespaldoAutomatico.Size =
                    pnlRespaldoManual.Size;

                _panelRespaldoAutomatico.Anchor =
                    pnlRespaldoManual.Anchor;

                Controls.Add(_panelRespaldoAutomatico);
            }

            pnlRespaldoManual.Visible = false;
            _panelRespaldoAutomatico.Visible = true;
            _panelRespaldoAutomatico.BringToFront();
        }

        private void btnCambiarUbicacion_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dialogo = new FolderBrowserDialog())
            {
                dialogo.Description =
                    "Selecciona la carpeta donde se guardarán los respaldos";

                dialogo.ShowNewFolderButton = true;

                if (Directory.Exists(txtUbicacionRespaldo.Text))
                {
                    dialogo.SelectedPath = txtUbicacionRespaldo.Text;
                }

                if (dialogo.ShowDialog() == DialogResult.OK)
                {
                    txtUbicacionRespaldo.Text = dialogo.SelectedPath;

                    CargarUltimoRespaldo();
                }
            }
        }

        private async void btnCrearRespaldo_Click(object sender, EventArgs e)
        {
            if (cmbTipoRespaldo.SelectedItem == null)
            {
                MessageBox.Show(
                    "Selecciona un tipo de respaldo.",
                    "Respaldo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            string tipo = cmbTipoRespaldo.SelectedItem.ToString();
            string carpeta = txtUbicacionRespaldo.Text.Trim();

            try
            {
                RespaldoController controlador = new RespaldoController();

                RespaldoController.ResultadoRespaldo respaldo =
                    controlador.CrearRespaldoConDetalles(tipo, carpeta);

                CargarUltimoRespaldo();

                try
                {
                    string apiKey = Environment.GetEnvironmentVariable(
                        "RESEND_API_KEY",
                        EnvironmentVariableTarget.User);

                    if (string.IsNullOrWhiteSpace(apiKey))
                    {
                        throw new InvalidOperationException(
                            "No se encontró RESEND_API_KEY. " +
                            "Cierra y vuelve a abrir Visual Studio.");
                    }

                    CorreoService correoService =
                        new CorreoService(apiKey);

                    await correoService.EnviarNotificacionRespaldoAsync(
                        respaldo,
                        _nombreCompletoUsuario,
                        _nombreUsuario,
                        _rolUsuario);

                    MessageBox.Show(
    respaldo.Mensaje,
    "Respaldo",
    MessageBoxButtons.OK,
    MessageBoxIcon.Information
);
                }
                catch (Exception exCorreo)
                {
                    MessageBox.Show(
                        respaldo.Mensaje +
                        "\n\nEl respaldo se creó correctamente, pero no se pudo " +
                        "enviar la notificación por correo.\n\nDetalle: " +
                        exCorreo.Message,
                        "Respaldo completado; correo no enviado",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se pudo crear el respaldo:\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnSeleccionarRespaldo_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialogo = new OpenFileDialog())
            {
                dialogo.Title = "Seleccionar respaldo de PrintZone";
                dialogo.Filter = "Archivos de respaldo (*.bak)|*.bak";
                dialogo.CheckFileExists = true;
                dialogo.Multiselect = false;

                if (dialogo.ShowDialog() == DialogResult.OK)
                {
                    txtArchivoRespaldo.Text = dialogo.FileName;
                }
            }
        }

        private void btnRestaurarRespaldo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtArchivoRespaldo.Text) ||
                !File.Exists(txtArchivoRespaldo.Text))
            {
                MessageBox.Show(
                    "Selecciona un archivo de respaldo válido.",
                    "Restaurar respaldo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            DialogResult confirmacion = MessageBox.Show(
                "ADVERTENCIA: esta operación reemplazará la base de datos " +
                "Inventario_Printzone con la información del respaldo seleccionado.\n\n" +
                "Los cambios realizados después de ese respaldo se perderán.\n\n" +
                "¿Deseas continuar?",
                "Confirmar restauración",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirmacion != DialogResult.Yes)
            {
                return;
            }

            try
            {
                RespaldoController controlador = new RespaldoController();

                string resultado =
                    controlador.RestaurarRespaldo(txtArchivoRespaldo.Text);

                CargarUltimoRespaldo();

                MessageBox.Show(
                    resultado,
                    "Restauración completada",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se pudo restaurar la base de datos:\n" +
                    ex.Message,
                    "Error de restauración",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}


using LibreriaPrintZone.Components;
using LibreriaPrintZone.Models;
using LibreriaPrintZone.Services;
using System;
using System.IO;
using System.Windows.Forms;

namespace LibreriaPrintZone.Views
{
    public partial class frmRespaldoAutomatico : Form
    {
        private readonly ConfiguracionRespaldoService _servicio =
            new ConfiguracionRespaldoService();


        private readonly ProgramadorTareasRespaldoService _programador =
    new ProgramadorTareasRespaldoService();

        public frmRespaldoAutomatico()
        {
            InitializeComponent();
            PanelRedondeado.Aplicar(panelInfoAutomatico, 20);
            PanelRedondeado.Aplicar(panelInfoAutomatico2, 20);
            PanelRedondeado.Aplicar(panelRespaldoAutomatico, 20);

            BotonRedondeado.Aplicar(btnGuardarConfiguracion, 10);
            BotonRedondeado.Aplicar(btnSeleccionarCarpeta, 10);




            CargarFrecuencias();
            CargarTiposRespaldo();

            cmbFrecuencia.SelectedIndexChanged +=
                cmbFrecuencia_SelectedIndexChanged;

            CargarConfiguracion();
        }

        public Panel ObtenerPanelRespaldoAutomatico()
        {
            return pnlRespaldoAutomatico;
        }

        private void CargarFrecuencias()
        {
            cmbFrecuencia.Items.Clear();

            cmbFrecuencia.Items.Add("Diario");
            cmbFrecuencia.Items.Add("Semanal");
            cmbFrecuencia.Items.Add("Mensual");

            cmbFrecuencia.SelectedIndex = 0;
        }

        private void CargarTiposRespaldo()
        {
            cmbTipoRespaldoAutomatico.Items.Clear();

            cmbTipoRespaldoAutomatico.Items.Add("FULL");
            cmbTipoRespaldoAutomatico.Items.Add("INCREMENTAL");

            cmbTipoRespaldoAutomatico.SelectedIndex = 0;
        }

        private void cmbFrecuencia_SelectedIndexChanged(
            object sender, EventArgs e)
        {
            string diaGuardado =
                cmbDiaSemana.SelectedItem?.ToString();

            cmbDiaSemana.Items.Clear();

            if (cmbFrecuencia.SelectedItem == null)
                return;

            string frecuencia =
                cmbFrecuencia.SelectedItem.ToString();

            lblDiaSemana.Visible = true;
            cmbDiaSemana.Visible = true;
            cmbDiaSemana.Enabled = true;

            if (frecuencia == "Diario")
            {
                lblDiaSemana.Text = "Día de ejecución";

                cmbDiaSemana.Items.Add("No aplica");
                cmbDiaSemana.SelectedIndex = 0;
                cmbDiaSemana.Enabled = false;
            }
            else if (frecuencia == "Semanal")
            {
                lblDiaSemana.Text = "Día de la semana";

                cmbDiaSemana.Items.AddRange(new object[]
                {
                    "Lunes", "Martes", "Miércoles", "Jueves",
                    "Viernes", "Sábado", "Domingo"
                });

                cmbDiaSemana.SelectedIndex =
                    diaGuardado != null &&
                    cmbDiaSemana.Items.Contains(diaGuardado)
                        ? cmbDiaSemana.Items.IndexOf(diaGuardado)
                        : 0;
            }
            else if (frecuencia == "Mensual")
            {
                lblDiaSemana.Text = "Día del mes";

                for (int dia = 1; dia <= 31; dia++)
                {
                    cmbDiaSemana.Items.Add(dia.ToString());
                }

                cmbDiaSemana.SelectedIndex =
                    diaGuardado != null &&
                    cmbDiaSemana.Items.Contains(diaGuardado)
                        ? cmbDiaSemana.Items.IndexOf(diaGuardado)
                        : 0;
            }
        }

        // Permite seleccionar la carpeta de destino.
        private void btnSeleccionarCarpeta_Click(
            object sender, EventArgs e)
        {
            using (FolderBrowserDialog dialogo =
                   new FolderBrowserDialog())
            {
                dialogo.Description =
                    "Selecciona la carpeta donde se guardarán los respaldos de PrintZone";

                dialogo.ShowNewFolderButton = true;

                string carpetaActual =
                    txtCarpetaDestino.Text.Trim();

                if (!string.IsNullOrWhiteSpace(carpetaActual) &&
                    Directory.Exists(carpetaActual))
                {
                    dialogo.SelectedPath = carpetaActual;
                }

                if (dialogo.ShowDialog() == DialogResult.OK)
                {
                    txtCarpetaDestino.Text = dialogo.SelectedPath;
                }
            }
        }

        private void CargarConfiguracion()
        {
            try
            {
                ConfiguracionRespaldo configuracion =
                    _servicio.Cargar();

                chkRespaldoActivado.Checked =
                    configuracion.Activado;

                cmbFrecuencia.SelectedItem =
                    configuracion.Frecuencia;

                if (cmbFrecuencia.SelectedIndex == -1)
                    cmbFrecuencia.SelectedIndex = 0;

                cmbDiaSemana.SelectedItem =
                    configuracion.DiaEjecucion;

                if (cmbDiaSemana.SelectedIndex == -1 &&
                    cmbDiaSemana.Items.Count > 0)
                {
                    cmbDiaSemana.SelectedIndex = 0;
                }

                dtpHoraInicio.Value =
                    DateTime.Today.Add(configuracion.HoraInicio);

                cmbTipoRespaldoAutomatico.SelectedItem =
                    configuracion.TipoRespaldo;

                if (cmbTipoRespaldoAutomatico.SelectedIndex == -1)
                    cmbTipoRespaldoAutomatico.SelectedIndex = 0;

                txtCarpetaDestino.Text =
                    configuracion.CarpetaDestino;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se pudo cargar la configuración del respaldo:\n" +
                    ex.Message,
                    "Configuración",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void btnGuardarConfiguracion_Click(
            object sender, EventArgs e)
        {
            if (cmbFrecuencia.SelectedItem == null ||
                cmbTipoRespaldoAutomatico.SelectedItem == null)
            {
                MessageBox.Show(
                    "Selecciona la frecuencia y el tipo de respaldo.",
                    "Configuración",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            string frecuencia =
                cmbFrecuencia.SelectedItem.ToString();

            if (frecuencia != "Diario" &&
                cmbDiaSemana.SelectedItem == null)
            {
                MessageBox.Show(
                    "Selecciona el día de ejecución.",
                    "Configuración",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            string carpeta = txtCarpetaDestino.Text.Trim();

            if (chkRespaldoActivado.Checked &&
                (string.IsNullOrWhiteSpace(carpeta) ||
                 !Directory.Exists(carpeta)))
            {
                MessageBox.Show(
                    "Selecciona una carpeta de destino existente.",
                    "Configuración",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            try
            {
                ConfiguracionRespaldo configuracion =
                    new ConfiguracionRespaldo
                    {
                        Activado = chkRespaldoActivado.Checked,
                        Frecuencia = frecuencia,
                        DiaEjecucion =
                            cmbDiaSemana.SelectedItem?.ToString()
                            ?? "No aplica",
                        HoraInicio =
                            dtpHoraInicio.Value.TimeOfDay,
                        TipoRespaldo =
                            cmbTipoRespaldoAutomatico.SelectedItem.ToString(),
                        CarpetaDestino = carpeta
                    };

                _servicio.Guardar(configuracion);
                _programador.ActualizarTarea(configuracion);

                MessageBox.Show(
                    "La configuración se guardó correctamente.",
                    "Configuración",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se pudo guardar la configuración:\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}

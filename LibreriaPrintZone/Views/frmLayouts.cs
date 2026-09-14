using LibreriaPrintZone.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LibreriaPrintZone
{
    public partial class frmLayouts : Form
    {
        // ==========================================
        // VARIABLES DEL SIDEBAR
        // ==========================================

        private bool sidebarExpandido = false;

        private int anchoContraido = 100;
        private int anchoExpandido = 258;

        // Formulario que actualmente está dentro
        // de panelContenido
        private Form formularioActivo = null;


        // ==========================================
        // CONSTRUCTOR
        // ==========================================

        public frmLayouts()
        {
            InitializeComponent();

            // El sidebar inicia contraído
            panelSidebar.Width = anchoContraido;

            // Configurar el mouse para el sidebar
            // y todos sus controles internos
            ConfigurarEventosSidebar(panelSidebar);

            // Ajustar el logo al iniciar
            AjustarLogo();

            AbrirFormulario(new frmPanelPrincipal());
        }


        // ==========================================
        // CONFIGURAR MOUSE DEL SIDEBAR
        // ==========================================

        private void ConfigurarEventosSidebar(Control control)
        {
            control.MouseEnter += ControlSidebar_MouseEnter;
            control.MouseLeave += ControlSidebar_MouseLeave;

            foreach (Control hijo in control.Controls)
            {
                ConfigurarEventosSidebar(hijo);
            }
        }


        // ==========================================
        // MOUSE ENTRA AL SIDEBAR
        // ==========================================

        private void ControlSidebar_MouseEnter(object sender, EventArgs e)
        {
            ExpandirSidebar();
        }


        // ==========================================
        // MOUSE SALE DEL SIDEBAR
        // ==========================================

        private void ControlSidebar_MouseLeave(object sender, EventArgs e)
        {
            VerificarMouseSidebar();
        }


        // ==========================================
        // VERIFICAR SI EL MOUSE SIGUE DENTRO
        // ==========================================

        private void VerificarMouseSidebar()
        {
            Point posicion = panelSidebar.PointToClient(Cursor.Position);

            if (!panelSidebar.ClientRectangle.Contains(posicion))
            {
                ContraerSidebar();
            }
        }


        // ==========================================
        // EXPANDIR SIDEBAR
        // ==========================================

        private void ExpandirSidebar()
        {
            if (sidebarExpandido)
                return;

            sidebarExpandido = true;

            timerSidebar.Start();
        }


        // ==========================================
        // CONTRAER SIDEBAR
        // ==========================================

        private void ContraerSidebar()
        {
            if (!sidebarExpandido)
                return;

            sidebarExpandido = false;

            timerSidebar.Start();
        }


        // ==========================================
        // TIMER DEL SIDEBAR
        // ==========================================

        private void timerSidebar_Tick(object sender, EventArgs e)
        {
            // ======================================
            // EXPANDIR
            // ======================================

            if (sidebarExpandido)
            {
                if (panelSidebar.Width < anchoExpandido)
                {
                    panelSidebar.Width += 10;

                    if (panelSidebar.Width > anchoExpandido)
                    {
                        panelSidebar.Width = anchoExpandido;
                    }
                }
                else
                {
                    panelSidebar.Width = anchoExpandido;

                    timerSidebar.Stop();
                }
            }

            // ======================================
            // CONTRAER
            // ======================================

            else
            {
                if (panelSidebar.Width > anchoContraido)
                {
                    panelSidebar.Width -= 10;

                    if (panelSidebar.Width < anchoContraido)
                    {
                        panelSidebar.Width = anchoContraido;
                    }
                }
                else
                {
                    panelSidebar.Width = anchoContraido;

                    timerSidebar.Stop();
                }
            }

            // Actualizar tamaño del logo
            AjustarLogo();
        }


        // ==========================================
        // AJUSTAR LOGO
        // ==========================================

        private void AjustarLogo()
        {
            pbLogo.Left = 0;
            pbLogo.Width = panelSidebar.Width;
        }


        // ==========================================
        // ABRIR FORMULARIO DENTRO DE PANELCONTENIDO
        // ==========================================

        private void AbrirFormulario(Form formulario)
        {
            // Si ya hay un formulario abierto,
            // lo cerramos
            if (formularioActivo != null)
            {
                formularioActivo.Close();
            }

            formularioActivo = formulario;

            // Configurar el formulario para que
            // funcione dentro del panel
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;

            // Agregarlo al panelContenido
            panelContenido.Controls.Add(formulario);

            // Guardarlo como formulario activo
            panelContenido.Tag = formulario;

            // Mostrarlo
            formulario.BringToFront();
            formulario.Show();
        }


        // ==========================================
        // BOTÓN PRODUCTOS
        // ==========================================

        private void btnProductos_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmProductos());
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmPanelPrincipal());
        }
    }
}

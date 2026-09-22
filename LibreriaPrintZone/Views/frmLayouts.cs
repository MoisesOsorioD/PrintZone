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
        // VARIABLES DEL MENÚ DESPLEGABLE
        // ==========================================

        private int alturaMenu = 0;

        // La altura original de panelMenu es 221
        private int alturaMaxima = 221;

        private bool abrirMenu = false;


        // ==========================================
        // CONSTRUCTOR
        // ==========================================

        public frmLayouts()
        {
            InitializeComponent();

            // ======================================
            // CONFIGURAR SIDEBAR
            // ======================================

            // El sidebar inicia contraído
            panelSidebar.Width = anchoContraido;

            // Configurar el mouse para el sidebar
            // y todos sus controles internos
            ConfigurarEventosSidebar(panelSidebar);

            // Ajustar el logo al iniciar
            AjustarLogo();


            // ==========================================
            // CONFIGURAR MENÚ DESPLEGABLE
            // ==========================================

            // El menú inicia cerrado
            alturaMenu = 0;

            panelMenu.Height = 0;
            panelMenu.Visible = false;


            // ======================================
            // FORMULARIO INICIAL
            // ======================================

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
            // Tamaño normal del logo
            int anchoLogo = 150;
            int altoLogo = 150;

            pbLogo.Width = anchoLogo;
            pbLogo.Height = altoLogo;

            // Cuando el Sidebar está completamente cerrado
            if (panelSidebar.Width <= anchoContraido)
            {
                pbLogo.Visible = false;

                // Lo dejamos fuera hacia la izquierda
                pbLogo.Left = -anchoLogo;

                return;
            }

            // Mostrar el logo
            pbLogo.Visible = true;

            // Calculamos la posición horizontal del logo
            int posicionFinal = (panelSidebar.Width - anchoLogo) / 2;

            // El logo se mueve siguiendo el crecimiento del Sidebar
            pbLogo.Left = posicionFinal;
        }


        // ==========================================
        // ABRIR FORMULARIO DENTRO DE PANELCONTENIDO
        // ==========================================

        public void AbrirFormulario(Form formulario)
        {
            // Si ya hay un formulario abierto,
            // lo cerramos
            if (formularioActivo != null)
            {
                formularioActivo.Close();
                formularioActivo = null;
            }

            formularioActivo = formulario;

            // Cambiar el título de frmLayouts
            // según el formulario que se está mostrando
            this.Text = formulario.Text;


            // Configurar el formulario para que
            // funcione dentro del panel
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;

            // Agregarlo al panelContenido
            panelContenido.Controls.Add(formulario);

            // Guardarlo como formulario activo
            //panelContenido.Tag = formulario;

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


        // ==========================================
        // BOTÓN INICIO
        // ==========================================

        private void btnInicio_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmPanelPrincipal());
        }


        // ==========================================
        // TIMER DEL MENÚ DESPLEGABLE
        // ==========================================

        private void timerMenu_Tick(object sender, EventArgs e)
        {
            if (abrirMenu)
            {
                // Aumentar la altura poco a poco
                alturaMenu += 25;

                if (alturaMenu >= alturaMaxima)
                {
                    alturaMenu = alturaMaxima;
                    timerMenu.Stop();
                }
            }
            else
            {
                // Disminuir la altura poco a poco
                alturaMenu -= 25;

                if (alturaMenu <= 0)
                {
                    alturaMenu = 0;

                    panelMenu.Height = 0;
                    panelMenu.Visible = false;

                    timerMenu.Stop();
                    return;
                }
            }

            panelMenu.Height = alturaMenu;
        }


        // ==========================================
        // BOTÓN ROL USUARIO
        // ==========================================

        private void btnRolUsuario_Click(object sender, EventArgs e)
        {
            if (panelMenu.Visible == false)
            {
                // Preparar el menú para abrirse
                abrirMenu = true;

                alturaMenu = 0;
                panelMenu.Height = 0;

                panelMenu.Visible = true;
                panelMenu.BringToFront();

                timerMenu.Start();
            }
            else
            {
                // Preparar el menú para cerrarse
                abrirMenu = false;

                timerMenu.Start();
            }
        }


        // ==========================================
        // BOTÓN PERFIL
        // ==========================================

        


        // ==========================================
        // BOTÓN CERRAR SESIÓN
        // ==========================================

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
                "¿Está seguro que desea cerrar sesión?",
                "Cerrar sesión",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resultado == DialogResult.Yes)
            {
                // Crear el formulario de inicio de sesión
                frmInicioSesion login = new frmInicioSesion();

                // Mostrar el login
                login.Show();

                // Cuando se cierre el login,
                // cerramos también este formulario
                login.FormClosed += (s, args) =>
                {
                    this.Close();
                };

                // Ocultar el formulario principal
                this.Hide();
            }
        }


        // ==========================================
        // BOTÓN SALIR
        // ==========================================

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
                "¿Está seguro que desea salir del programa?",
                "Salir",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmCategorias());
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmProveedores());
        }

        private void btnEntradas_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmEntradas());
        }

        private void btnSalidas_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmSalidas());
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmUsuarios());
        }

        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmConfiguracion());
        }
    }
}
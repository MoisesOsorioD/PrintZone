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
        // DATOS DEL USUARIO
        // ==========================================

        private string RolUsuario;
        private string NombreUsuario;

        // AGREGADO: nombre de usuario de la cuenta
        private string NombreUsuarioCuenta;

        private readonly int _idUsuarioActual;
        private readonly string _nombreUsuarioActual;





        // ==========================================
        // VARIABLES DEL SIDEBAR
        // ==========================================

        private bool sidebarExpandido = false;

        private int anchoContraido = 100;
        private int anchoExpandido = 258;

        private Form formularioActivo = null;

        // Guardar posición original de Salidas
        private int posicionOriginalSalidas;

        // Guardar posición original del icono de Salidas
        private int posicionOriginalIconoSalidas;


        // ==========================================
        // VARIABLES DEL MENÚ DESPLEGABLE
        // ==========================================

        private int alturaMenu = 0;

        private int alturaMaxima = 221;

        private bool abrirMenu = false;


        // ==========================================
        // CONSTRUCTOR
        // ==========================================

        public frmLayouts(
            int idUsuario,
            string rol,
            string nombreUsuario,
            string nombreCompleto)
        {
            InitializeComponent();

            _idUsuarioActual = idUsuario;
            _nombreUsuarioActual = nombreCompleto;

            // Guardar información del usuario
            RolUsuario = rol;
            NombreUsuario = nombreCompleto;

            // AGREGADO:
            // Guardar el nombre de usuario de la cuenta
            NombreUsuarioCuenta = nombreUsuario;

            // AGREGADO:
            // Mostrar el nombre de usuario en el botón
            btnRolUsuario.Text = NombreUsuarioCuenta;


            // ======================================
            // CONFIGURAR SIDEBAR
            // ======================================

            panelSidebar.Width = anchoContraido;

            ConfigurarEventosSidebar(panelSidebar);

            AjustarLogo();


            // ======================================
            // GUARDAR POSICIONES ORIGINALES
            // ======================================

            posicionOriginalSalidas = btnSalidas.Top;
            posicionOriginalIconoSalidas = pbIconoSalidas.Top;


            // ==========================================
            // CONFIGURAR MENÚ
            // ==========================================

            alturaMenu = 0;

            panelMenu.Height = 0;
            panelMenu.Visible = false;


            // ======================================
            // CONFIGURAR PERMISOS
            // ======================================

            ConfigurarPermisos();


            // ======================================
            // FORMULARIO INICIAL
            // ======================================

            AbrirFormulario(
                new frmPanelPrincipal(
                    RolUsuario,
                    NombreUsuario
                )
            );
        }


        public int IdUsuarioActual
        {
            get
            {
                return _idUsuarioActual;
            }
        }


        public string NombreUsuarioActual
        {
            get
            {
                return _nombreUsuarioActual;
            }
        }

        public string RolUsuarioActual
        {
            get
            {
                return RolUsuario;
            }
        }


        // ==========================================
        // CONFIGURAR PERMISOS SEGÚN ROL
        // ==========================================

        private void ConfigurarPermisos()
        {
            bool esAdmin = RolUsuario.Equals(
                "Administrador",
                StringComparison.OrdinalIgnoreCase
            );

            bool esVendedor = RolUsuario.Equals(
                "Vendedor",
                StringComparison.OrdinalIgnoreCase
            );


            // ======================================
            // ADMINISTRADOR
            // ======================================

            if (esAdmin)
            {
                btnInicio.Visible = true;
                btnProductos.Visible = true;
                btnCategorias.Visible = true;
                btnProveedores.Visible = true;
                btnEntradas.Visible = true;
                btnSalidas.Visible = true;
                btnUsuarios.Visible = true;
                btnConfiguracion.Visible = true;


                // Mostrar iconos
                pbIconoInicio.Visible = true;
                pbIconoProductos.Visible = true;
                pbIconoCategorias.Visible = true;
                pbIconoProveedores.Visible = true;
                pbIconoEntradas.Visible = true;
                pbIconoSalidas.Visible = true;
                pbIconoUsuarios.Visible = true;
                pbIconoConfiguracion.Visible = true;


                // Restaurar posición original de Salidas
                btnSalidas.Top = posicionOriginalSalidas;
                pbIconoSalidas.Top = posicionOriginalIconoSalidas;
            }


            // ======================================
            // VENDEDOR
            // ======================================

            if (esVendedor)
            {
                // ----------------------------------
                // OPCIONES PERMITIDAS
                // ----------------------------------

                btnInicio.Visible = true;
                btnProductos.Visible = true;
                btnSalidas.Visible = true;


                // Mostrar iconos permitidos
                pbIconoInicio.Visible = true;
                pbIconoProductos.Visible = true;
                pbIconoSalidas.Visible = true;


                // ----------------------------------
                // OPCIONES NO PERMITIDAS
                // ----------------------------------

                btnCategorias.Visible = false;
                btnProveedores.Visible = false;
                btnEntradas.Visible = false;
                btnUsuarios.Visible = false;
                btnConfiguracion.Visible = false;


                // Ocultar iconos no permitidos
                pbIconoCategorias.Visible = false;
                pbIconoProveedores.Visible = false;
                pbIconoEntradas.Visible = false;
                pbIconoUsuarios.Visible = false;
                pbIconoConfiguracion.Visible = false;


                // ----------------------------------
                // MOVER SALIDAS HACIA ARRIBA
                // ----------------------------------

                btnSalidas.Top = btnCategorias.Top;

                pbIconoSalidas.Top = btnSalidas.Top;
            }
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

        private void ControlSidebar_MouseEnter(
            object sender,
            EventArgs e)
        {
            ExpandirSidebar();
        }


        // ==========================================
        // MOUSE SALE DEL SIDEBAR
        // ==========================================

        private void ControlSidebar_MouseLeave(
            object sender,
            EventArgs e)
        {
            VerificarMouseSidebar();
        }


        // ==========================================
        // VERIFICAR MOUSE
        // ==========================================

        private void VerificarMouseSidebar()
        {
            Point posicion =
                panelSidebar.PointToClient(Cursor.Position);

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
        // TIMER SIDEBAR
        // ==========================================

        private void timerSidebar_Tick(
            object sender,
            EventArgs e)
        {
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

            AjustarLogo();
        }


        // ==========================================
        // AJUSTAR LOGO
        // ==========================================

        private void AjustarLogo()
        {
            int anchoLogo = 150;
            int altoLogo = 150;

            pbLogo.Width = anchoLogo;
            pbLogo.Height = altoLogo;

            if (panelSidebar.Width <= anchoContraido)
            {
                pbLogo.Visible = false;

                pbLogo.Left = -anchoLogo;

                return;
            }

            pbLogo.Visible = true;

            int posicionFinal =
                (panelSidebar.Width - anchoLogo) / 2;

            pbLogo.Left = posicionFinal;
        }


        // ==========================================
        // ABRIR FORMULARIO
        // ==========================================

        public void AbrirFormulario(Form formulario)
        {
            if (formularioActivo != null)
            {
                formularioActivo.Close();

                formularioActivo = null;
            }

            formularioActivo = formulario;

            this.Text = formulario.Text;

            formulario.TopLevel = false;

            formulario.FormBorderStyle =
                FormBorderStyle.None;

            formulario.Dock =
                DockStyle.Fill;

            panelContenido.Controls.Add(formulario);

            formulario.BringToFront();

            formulario.Show();
        }


        // ==========================================
        // BOTÓN INICIO
        // ==========================================

        private void btnInicio_Click(
            object sender,
            EventArgs e)
        {
            AbrirFormulario(
                new frmPanelPrincipal(
                    RolUsuario,
                    NombreUsuario
                )
            );
        }


        // ==========================================
        // BOTÓN PRODUCTOS
        // ==========================================

        private void btnProductos_Click(
            object sender,
            EventArgs e)
        {
            AbrirFormulario(
                new frmProductos(RolUsuario)
            );
        }


        // ==========================================
        // BOTÓN CATEGORÍAS
        // ==========================================

        private void btnCategorias_Click(
            object sender,
            EventArgs e)
        {
            AbrirFormulario(
                new frmCategorias()
            );
        }


        // ==========================================
        // BOTÓN PROVEEDORES
        // ==========================================

        private void btnProveedores_Click(
            object sender,
            EventArgs e)
        {
            AbrirFormulario(
                new frmProveedores()
            );
        }


        // ==========================================
        // BOTÓN ENTRADAS
        // ==========================================

        private void btnEntradas_Click(
            object sender,
            EventArgs e)
        {
            AbrirFormulario(
                new frmEntradas()
            );
        }


        // ==========================================
        // BOTÓN SALIDAS
        // ==========================================

        private void btnSalidas_Click(
            object sender,
            EventArgs e)
        {
            AbrirFormulario(
                new frmSalidas()
            );
        }


        // ==========================================
        // BOTÓN USUARIOS
        // ==========================================

        private void btnUsuarios_Click(
            object sender,
            EventArgs e)
        {
            AbrirFormulario(
                new frmUsuarios()
            );
        }


        // ==========================================
        // BOTÓN CONFIGURACIÓN
        // ==========================================

        private void btnConfiguracion_Click(
            object sender,
            EventArgs e)
        {
            AbrirFormulario(
                new frmConfiguracion()
            );
        }


        // ==========================================
        // BOTÓN ROL USUARIO
        // ==========================================

        private void btnRolUsuario_Click(
            object sender,
            EventArgs e)
        {
            if (panelMenu.Visible == false)
            {
                abrirMenu = true;

                alturaMenu = 0;

                panelMenu.Height = 0;

                panelMenu.Visible = true;

                panelMenu.BringToFront();

                timerMenu.Start();
            }
            else
            {
                abrirMenu = false;

                timerMenu.Start();
            }
        }


        // ==========================================
        // TIMER MENÚ
        // ==========================================

        private void timerMenu_Tick(
            object sender,
            EventArgs e)
        {
            if (abrirMenu)
            {
                alturaMenu += 25;

                if (alturaMenu >= alturaMaxima)
                {
                    alturaMenu = alturaMaxima;

                    timerMenu.Stop();
                }
            }
            else
            {
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
        // CERRAR SESIÓN
        // ==========================================

        private void btnCerrarSesion_Click(
            object sender,
            EventArgs e)
        {
            DialogResult resultado =
                MessageBox.Show(
                    "¿Está seguro que desea cerrar sesión?",
                    "Cerrar sesión",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

            if (resultado != DialogResult.Yes)
                return;


            frmInicioSesion login =
                new frmInicioSesion();

            login.Show();

            login.FormClosed += (s, args) =>
            {
                this.Close();
            };

            this.Hide();
        }


        // ==========================================
        // SALIR
        // ==========================================

        private void btnSalir_Click(
            object sender,
            EventArgs e)
        {
            DialogResult resultado =
                MessageBox.Show(
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
    }
}
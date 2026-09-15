using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LibreriaPrintZone.Views
{
    public partial class frmNuevoProductos : Form
    {
        public frmNuevoProductos()
        {
            InitializeComponent();
        }

        private void btnRegresarFrmProductos_Click(object sender, EventArgs e)
        {
            frmLayouts principal = this.ParentForm as frmLayouts;

            if (principal != null)
            {
                principal.AbrirFormulario(new frmProductos());
            }
        }
    }
}

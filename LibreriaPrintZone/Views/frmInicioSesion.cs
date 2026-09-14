namespace LibreriaPrintZone
{
    public partial class frmInicioSesion : Form
    {
        public frmInicioSesion()
        {
            InitializeComponent();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            frmLayouts frmLayouts = new frmLayouts();
            frmLayouts.Show();
            this.Hide();
        }
    }
}

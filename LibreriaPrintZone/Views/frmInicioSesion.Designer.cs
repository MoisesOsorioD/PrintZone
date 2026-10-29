namespace LibreriaPrintZone
{
    partial class frmInicioSesion
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicioSesion));
            pictureBox1 = new PictureBox();
            label3 = new Label();
            txtUsuario = new TextBox();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            txtContra = new TextBox();
            btnIniciarSesion = new Button();
            panelLogin = new Panel();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Usuario;
            pictureBox1.Location = new Point(13, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(77, 70);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label3.Location = new Point(96, 12);
            label3.Name = "label3";
            label3.Size = new Size(81, 28);
            label3.TabIndex = 3;
            label3.Text = "Usuario";
            // 
            // txtUsuario
            // 
            txtUsuario.BorderStyle = BorderStyle.FixedSingle;
            txtUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsuario.Location = new Point(96, 48);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = " Ingresa tu usuario";
            txtUsuario.Size = new Size(359, 34);
            txtUsuario.TabIndex = 4;
            txtUsuario.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Contraseña;
            pictureBox2.Location = new Point(13, 137);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(77, 70);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label4.Location = new Point(96, 137);
            label4.Name = "label4";
            label4.Size = new Size(114, 28);
            label4.TabIndex = 6;
            label4.Text = "Contraseña";
            // 
            // txtContra
            // 
            txtContra.BorderStyle = BorderStyle.FixedSingle;
            txtContra.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtContra.Location = new Point(96, 173);
            txtContra.Name = "txtContra";
            txtContra.PasswordChar = '*';
            txtContra.PlaceholderText = " Ingresa tu contraseña";
            txtContra.Size = new Size(359, 34);
            txtContra.TabIndex = 7;
            txtContra.TabStop = false;
            // 
            // btnIniciarSesion
            // 
            btnIniciarSesion.BackColor = Color.FromArgb(26, 99, 212);
            btnIniciarSesion.Cursor = Cursors.Hand;
            btnIniciarSesion.FlatAppearance.BorderSize = 0;
            btnIniciarSesion.FlatStyle = FlatStyle.Flat;
            btnIniciarSesion.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIniciarSesion.ForeColor = Color.White;
            btnIniciarSesion.Location = new Point(25, 235);
            btnIniciarSesion.Name = "btnIniciarSesion";
            btnIniciarSesion.Size = new Size(430, 46);
            btnIniciarSesion.TabIndex = 8;
            btnIniciarSesion.Text = "Iniciar Sesión";
            btnIniciarSesion.UseVisualStyleBackColor = false;
            btnIniciarSesion.Click += btnIniciarSesion_Click;
            // 
            // panelLogin
            // 
            panelLogin.BackColor = Color.White;
            panelLogin.Controls.Add(btnIniciarSesion);
            panelLogin.Controls.Add(txtContra);
            panelLogin.Controls.Add(pictureBox1);
            panelLogin.Controls.Add(label4);
            panelLogin.Controls.Add(label3);
            panelLogin.Controls.Add(pictureBox2);
            panelLogin.Controls.Add(txtUsuario);
            panelLogin.Location = new Point(1256, 328);
            panelLogin.Name = "panelLogin";
            panelLogin.Size = new Size(480, 325);
            panelLogin.TabIndex = 9;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(-411, -7);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(2788, 999);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 10;
            pictureBox3.TabStop = false;
            // 
            // frmInicioSesion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(3, 37, 91);
            ClientSize = new Size(1902, 983);
            Controls.Add(panelLogin);
            Controls.Add(pictureBox3);
            Name = "frmInicioSesion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio de Sesión";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panelLogin.ResumeLayout(false);
            panelLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBox1;
        private Label label3;
        private TextBox txtUsuario;
        private PictureBox pictureBox2;
        private Label label4;
        private TextBox txtContra;
        private Button btnIniciarSesion;
        private Panel panelLogin;
        private PictureBox pictureBox3;
    }
}

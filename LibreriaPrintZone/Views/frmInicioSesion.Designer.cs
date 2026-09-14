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
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            txtUsuario = new TextBox();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            txtContrasena = new TextBox();
            btnIniciarSesion = new Button();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(450, 89);
            label1.Name = "label1";
            label1.Size = new Size(411, 46);
            label1.TabIndex = 0;
            label1.Text = "Bienvenidos a PrintZone";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(439, 135);
            label2.Name = "label2";
            label2.Size = new Size(442, 28);
            label2.TabIndex = 1;
            label2.Text = "Inicia sesión para acceder al sistema de inventario";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Usuario;
            pictureBox1.Location = new Point(451, 194);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(77, 70);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(522, 194);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 3;
            label3.Text = "Usuario";
            // 
            // txtUsuario
            // 
            txtUsuario.BorderStyle = BorderStyle.FixedSingle;
            txtUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsuario.Location = new Point(522, 217);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = " Ingresa tu usuario";
            txtUsuario.Size = new Size(359, 34);
            txtUsuario.TabIndex = 4;
            txtUsuario.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Contraseña;
            pictureBox2.Location = new Point(451, 298);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(77, 70);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(522, 298);
            label4.Name = "label4";
            label4.Size = new Size(86, 20);
            label4.TabIndex = 6;
            label4.Text = "Contraseña";
            // 
            // txtContrasena
            // 
            txtContrasena.BorderStyle = BorderStyle.FixedSingle;
            txtContrasena.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtContrasena.Location = new Point(522, 321);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.PasswordChar = '*';
            txtContrasena.PlaceholderText = " Ingresa tu contraseña";
            txtContrasena.Size = new Size(359, 34);
            txtContrasena.TabIndex = 7;
            txtContrasena.TabStop = false;
            // 
            // btnIniciarSesion
            // 
            btnIniciarSesion.BackColor = Color.FromArgb(26, 99, 212);
            btnIniciarSesion.Cursor = Cursors.Hand;
            btnIniciarSesion.FlatStyle = FlatStyle.Popup;
            btnIniciarSesion.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIniciarSesion.ForeColor = Color.White;
            btnIniciarSesion.Location = new Point(463, 401);
            btnIniciarSesion.Name = "btnIniciarSesion";
            btnIniciarSesion.Size = new Size(418, 46);
            btnIniciarSesion.TabIndex = 8;
            btnIniciarSesion.Text = "Iniciar Sesión";
            btnIniciarSesion.UseVisualStyleBackColor = false;
            btnIniciarSesion.Click += btnIniciarSesion_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Dock = DockStyle.Left;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(0, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(377, 582);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
            // 
            // frmInicioSesion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(220, 233, 247);
            ClientSize = new Size(933, 582);
            Controls.Add(pictureBox3);
            Controls.Add(btnIniciarSesion);
            Controls.Add(txtContrasena);
            Controls.Add(label4);
            Controls.Add(pictureBox2);
            Controls.Add(txtUsuario);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmInicioSesion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio de Sesión";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label3;
        private TextBox txtUsuario;
        private PictureBox pictureBox2;
        private Label label4;
        private TextBox txtContrasena;
        private Button btnIniciarSesion;
        private PictureBox pictureBox3;
    }
}

namespace LibreriaPrintZone.Views
{
    partial class frmUsuarios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsuarios));
            pictureBox14 = new PictureBox();
            textBox1 = new TextBox();
            panel7 = new Panel();
            dataGridView1 = new DataGridView();
            colUsuarioU = new DataGridViewTextBoxColumn();
            colNombreCompletoU = new DataGridViewTextBoxColumn();
            colRolU = new DataGridViewTextBoxColumn();
            colEstadoU = new DataGridViewTextBoxColumn();
            colFechaCreacionU = new DataGridViewTextBoxColumn();
            label17 = new Label();
            pictureBox3 = new PictureBox();
            panel5 = new Panel();
            label15 = new Label();
            dateTimePicker1 = new DateTimePicker();
            checkBox1 = new CheckBox();
            comboBox1 = new ComboBox();
            textBox3 = new TextBox();
            label19 = new Label();
            button11 = new Button();
            textBox7 = new TextBox();
            button10 = new Button();
            label13 = new Label();
            label14 = new Label();
            textBox4 = new TextBox();
            label12 = new Label();
            pictureBox2 = new PictureBox();
            label16 = new Label();
            panel4 = new Panel();
            label10 = new Label();
            pictureBox13 = new PictureBox();
            label7 = new Label();
            label8 = new Label();
            panel3 = new Panel();
            label9 = new Label();
            pictureBox12 = new PictureBox();
            label4 = new Label();
            label6 = new Label();
            panel2 = new Panel();
            label11 = new Label();
            pictureBox11 = new PictureBox();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox10 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox14).BeginInit();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            SuspendLayout();
            // 
            // pictureBox14
            // 
            pictureBox14.Image = (Image)resources.GetObject("pictureBox14.Image");
            pictureBox14.Location = new Point(632, 263);
            pictureBox14.Name = "pictureBox14";
            pictureBox14.Size = new Size(40, 40);
            pictureBox14.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox14.TabIndex = 79;
            pictureBox14.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(678, 270);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = " Buscar usuarios...";
            textBox1.Size = new Size(614, 30);
            textBox1.TabIndex = 78;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(242, 249, 254);
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel7.Controls.Add(dataGridView1);
            panel7.Controls.Add(label17);
            panel7.Controls.Add(pictureBox3);
            panel7.Location = new Point(632, 328);
            panel7.Name = "panel7";
            panel7.Size = new Size(935, 509);
            panel7.TabIndex = 77;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(220, 233, 247);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colUsuarioU, colNombreCompletoU, colRolU, colEstadoU, colFechaCreacionU });
            dataGridView1.Location = new Point(20, 81);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(896, 405);
            dataGridView1.TabIndex = 8;
            // 
            // colUsuarioU
            // 
            colUsuarioU.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colUsuarioU.HeaderText = "Usuario";
            colUsuarioU.MinimumWidth = 6;
            colUsuarioU.Name = "colUsuarioU";
            // 
            // colNombreCompletoU
            // 
            colNombreCompletoU.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colNombreCompletoU.HeaderText = "Nombre completo";
            colNombreCompletoU.MinimumWidth = 6;
            colNombreCompletoU.Name = "colNombreCompletoU";
            // 
            // colRolU
            // 
            colRolU.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colRolU.HeaderText = "Rol";
            colRolU.MinimumWidth = 6;
            colRolU.Name = "colRolU";
            // 
            // colEstadoU
            // 
            colEstadoU.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colEstadoU.HeaderText = "Estado";
            colEstadoU.MinimumWidth = 6;
            colEstadoU.Name = "colEstadoU";
            // 
            // colFechaCreacionU
            // 
            colFechaCreacionU.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colFechaCreacionU.HeaderText = "Nombre de creación";
            colFechaCreacionU.MinimumWidth = 6;
            colFechaCreacionU.Name = "colFechaCreacionU";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label17.Location = new Point(82, 32);
            label17.Name = "label17";
            label17.Size = new Size(187, 25);
            label17.TabIndex = 6;
            label17.Text = "Listas de usuarios";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Categoria_Menos;
            pictureBox3.Location = new Point(20, 11);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(60, 60);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(247, 251, 255);
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(label15);
            panel5.Controls.Add(dateTimePicker1);
            panel5.Controls.Add(checkBox1);
            panel5.Controls.Add(comboBox1);
            panel5.Controls.Add(textBox3);
            panel5.Controls.Add(label19);
            panel5.Controls.Add(button11);
            panel5.Controls.Add(textBox7);
            panel5.Controls.Add(button10);
            panel5.Controls.Add(label13);
            panel5.Controls.Add(label14);
            panel5.Controls.Add(textBox4);
            panel5.Controls.Add(label12);
            panel5.Controls.Add(pictureBox2);
            panel5.Controls.Add(label16);
            panel5.Location = new Point(112, 259);
            panel5.Name = "panel5";
            panel5.Size = new Size(475, 578);
            panel5.TabIndex = 76;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(18, 432);
            label15.Name = "label15";
            label15.Size = new Size(132, 20);
            label15.TabIndex = 80;
            label15.Text = "Fecha de creación";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(19, 455);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(424, 27);
            dateTimePicker1.TabIndex = 79;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(18, 386);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(125, 24);
            checkBox1.TabIndex = 78;
            checkBox1.Text = "Usuario activo";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(18, 336);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(425, 28);
            comboBox1.TabIndex = 77;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(19, 103);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = " Ej. 50";
            textBox3.Size = new Size(425, 27);
            textBox3.TabIndex = 76;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label19.Location = new Point(19, 313);
            label19.Name = "label19";
            label19.Size = new Size(31, 20);
            label19.TabIndex = 75;
            label19.Text = "Rol";
            // 
            // button11
            // 
            button11.BackColor = Color.FromArgb(2, 113, 249);
            button11.FlatAppearance.BorderSize = 0;
            button11.FlatStyle = FlatStyle.Flat;
            button11.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button11.ForeColor = Color.White;
            button11.Image = (Image)resources.GetObject("button11.Image");
            button11.ImageAlign = ContentAlignment.MiddleLeft;
            button11.Location = new Point(283, 506);
            button11.Name = "button11";
            button11.Size = new Size(160, 37);
            button11.TabIndex = 56;
            button11.Text = "Limpiar";
            button11.UseVisualStyleBackColor = false;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(18, 261);
            textBox7.Name = "textBox7";
            textBox7.PlaceholderText = " Ej. Venta";
            textBox7.Size = new Size(425, 27);
            textBox7.TabIndex = 54;
            // 
            // button10
            // 
            button10.BackColor = Color.FromArgb(2, 113, 249);
            button10.FlatAppearance.BorderSize = 0;
            button10.FlatStyle = FlatStyle.Flat;
            button10.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button10.ForeColor = Color.White;
            button10.Image = (Image)resources.GetObject("button10.Image");
            button10.ImageAlign = ContentAlignment.MiddleLeft;
            button10.Location = new Point(18, 506);
            button10.Name = "button10";
            button10.Size = new Size(160, 37);
            button10.TabIndex = 57;
            button10.Text = "Guardar";
            button10.UseVisualStyleBackColor = false;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(19, 238);
            label13.Name = "label13";
            label13.Size = new Size(86, 20);
            label13.TabIndex = 55;
            label13.Text = "Contraseña";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(18, 157);
            label14.Name = "label14";
            label14.Size = new Size(134, 20);
            label14.TabIndex = 52;
            label14.Text = "Nombre completo";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(18, 180);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = " Ej. 50";
            textBox4.Size = new Size(425, 27);
            textBox4.TabIndex = 51;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(19, 80);
            label12.Name = "label12";
            label12.Size = new Size(142, 20);
            label12.TabIndex = 19;
            label12.Text = "Nombre de usuario";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Usuario_4;
            pictureBox2.Location = new Point(19, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(60, 60);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label16.Location = new Point(82, 22);
            label16.Name = "label16";
            label16.Size = new Size(228, 25);
            label16.TabIndex = 6;
            label16.Text = "Agregar o editar usuarios";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(242, 249, 254);
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(label10);
            panel4.Controls.Add(pictureBox13);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(label8);
            panel4.Location = new Point(1119, 118);
            panel4.Name = "panel4";
            panel4.Size = new Size(441, 116);
            panel4.TabIndex = 75;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(99, 83);
            label10.Name = "label10";
            label10.Size = new Size(142, 23);
            label10.TabIndex = 10;
            label10.Text = "Cuentas inactivas";
            // 
            // pictureBox13
            // 
            pictureBox13.Image = Properties.Resources.Usuario_2;
            pictureBox13.Location = new Point(3, 12);
            pictureBox13.Name = "pictureBox13";
            pictureBox13.Size = new Size(90, 94);
            pictureBox13.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox13.TabIndex = 5;
            pictureBox13.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(99, 38);
            label7.Name = "label7";
            label7.Size = new Size(33, 38);
            label7.TabIndex = 2;
            label7.Text = "0";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label8.Location = new Point(99, 12);
            label8.Name = "label8";
            label8.Size = new Size(200, 25);
            label8.TabIndex = 0;
            label8.Text = "Usuarios desactivados";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(242, 249, 254);
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label9);
            panel3.Controls.Add(pictureBox12);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label6);
            panel3.Location = new Point(628, 118);
            panel3.Name = "panel3";
            panel3.Size = new Size(445, 116);
            panel3.TabIndex = 74;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(99, 83);
            label9.Name = "label9";
            label9.Size = new Size(228, 23);
            label9.TabIndex = 9;
            label9.Text = "Cuentas activas actualmente";
            // 
            // pictureBox12
            // 
            pictureBox12.Image = Properties.Resources.Categoria_Menos;
            pictureBox12.Location = new Point(3, 12);
            pictureBox12.Name = "pictureBox12";
            pictureBox12.Size = new Size(90, 94);
            pictureBox12.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox12.TabIndex = 5;
            pictureBox12.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(99, 38);
            label4.Name = "label4";
            label4.Size = new Size(33, 38);
            label4.TabIndex = 2;
            label4.Text = "2";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label6.Location = new Point(99, 12);
            label6.Name = "label6";
            label6.Size = new Size(150, 25);
            label6.TabIndex = 0;
            label6.Text = "Usuarios activos";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(242, 249, 254);
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label11);
            panel2.Controls.Add(pictureBox11);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(112, 118);
            panel2.Name = "panel2";
            panel2.Size = new Size(445, 116);
            panel2.TabIndex = 73;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(99, 83);
            label11.Name = "label11";
            label11.Size = new Size(264, 23);
            label11.TabIndex = 10;
            label11.Text = "Cuentas registradas en el sistema";
            // 
            // pictureBox11
            // 
            pictureBox11.Image = Properties.Resources.Usuario_3;
            pictureBox11.Location = new Point(3, 12);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(90, 94);
            pictureBox11.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox11.TabIndex = 5;
            pictureBox11.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(99, 38);
            label5.Name = "label5";
            label5.Size = new Size(33, 38);
            label5.TabIndex = 2;
            label5.Text = "2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label3.Location = new Point(99, 12);
            label3.Name = "label3";
            label3.Size = new Size(155, 25);
            label3.TabIndex = 0;
            label3.Text = "Total de usuarios";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(232, 77);
            label2.Name = "label2";
            label2.Size = new Size(360, 23);
            label2.TabIndex = 71;
            label2.Text = "Administra las cuentas de usuario del sistema.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(201, 21);
            label1.Name = "label1";
            label1.Size = new Size(159, 46);
            label1.TabIndex = 70;
            label1.Text = "Usuarios";
            // 
            // pictureBox10
            // 
            pictureBox10.Image = Properties.Resources.Usuario_3;
            pictureBox10.Location = new Point(112, 12);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(100, 100);
            pictureBox10.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox10.TabIndex = 72;
            pictureBox10.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(2, 113, 249);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Image = Properties.Resources.Buscar;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(1307, 263);
            button1.Name = "button1";
            button1.Size = new Size(121, 37);
            button1.TabIndex = 81;
            button1.Text = "Buscar";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(2, 113, 249);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(1446, 263);
            button2.Name = "button2";
            button2.Size = new Size(121, 37);
            button2.TabIndex = 80;
            button2.Text = "Limpiar";
            button2.TextAlign = ContentAlignment.MiddleRight;
            button2.UseVisualStyleBackColor = false;
            // 
            // frmUsuarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(220, 233, 247);
            ClientSize = new Size(1632, 915);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(pictureBox14);
            Controls.Add(textBox1);
            Controls.Add(panel7);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox10);
            Name = "frmUsuarios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Librería PrintZone - Gestión de usuarios";
            ((System.ComponentModel.ISupportInitialize)pictureBox14).EndInit();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox14;
        private TextBox textBox1;
        private Panel panel7;
        private DataGridView dataGridView1;
        private Label label17;
        private PictureBox pictureBox3;
        private Panel panel5;
        private Label label19;
        private Button button11;
        private TextBox textBox7;
        private Button button10;
        private Label label13;
        private Label label14;
        private TextBox textBox4;
        private Label label12;
        private PictureBox pictureBox2;
        private Label label16;
        private Panel panel4;
        private Label label10;
        private PictureBox pictureBox13;
        private Label label7;
        private Label label8;
        private Panel panel3;
        private Label label9;
        private PictureBox pictureBox12;
        private Label label4;
        private Label label6;
        private Panel panel2;
        private Label label11;
        private PictureBox pictureBox11;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox10;
        private Button button1;
        private Button button2;
        private TextBox textBox3;
        private ComboBox comboBox1;
        private CheckBox checkBox1;
        private DateTimePicker dateTimePicker1;
        private Label label15;
        private DataGridViewTextBoxColumn colUsuarioU;
        private DataGridViewTextBoxColumn colNombreCompletoU;
        private DataGridViewTextBoxColumn colRolU;
        private DataGridViewTextBoxColumn colEstadoU;
        private DataGridViewTextBoxColumn colFechaCreacionU;
    }
}
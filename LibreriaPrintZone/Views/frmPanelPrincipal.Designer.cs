namespace LibreriaPrintZone.Views
{
    partial class frmPanelPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPanelPrincipal));
            panel7 = new Panel();
            label11 = new Label();
            label12 = new Label();
            pictureBox14 = new PictureBox();
            label13 = new Label();
            panel6 = new Panel();
            dataGridView1 = new DataGridView();
            colFechaPP = new DataGridViewTextBoxColumn();
            colMovimientoPP = new DataGridViewTextBoxColumn();
            colProductoPP = new DataGridViewTextBoxColumn();
            colCantidadPP = new DataGridViewTextBoxColumn();
            colProveedorPP = new DataGridViewTextBoxColumn();
            button11 = new Button();
            label14 = new Label();
            pictureBox15 = new PictureBox();
            panel3 = new Panel();
            label8 = new Label();
            label7 = new Label();
            pictureBox11 = new PictureBox();
            label6 = new Label();
            panel2 = new Panel();
            pictureBox10 = new PictureBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            pictureBox1 = new PictureBox();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox14).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox15).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(242, 249, 254);
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel7.Controls.Add(label11);
            panel7.Controls.Add(label12);
            panel7.Controls.Add(pictureBox14);
            panel7.Controls.Add(label13);
            panel7.Location = new Point(1101, 154);
            panel7.Name = "panel7";
            panel7.Size = new Size(424, 164);
            panel7.TabIndex = 17;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(98, 63);
            label11.Name = "label11";
            label11.Size = new Size(49, 38);
            label11.TabIndex = 8;
            label11.Text = "20";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(98, 101);
            label12.Name = "label12";
            label12.Size = new Size(174, 23);
            label12.TabIndex = 7;
            label12.Text = "Registros de entradas";
            // 
            // pictureBox14
            // 
            pictureBox14.Image = (Image)resources.GetObject("pictureBox14.Image");
            pictureBox14.Location = new Point(2, 30);
            pictureBox14.Name = "pictureBox14";
            pictureBox14.Size = new Size(90, 94);
            pictureBox14.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox14.TabIndex = 6;
            pictureBox14.TabStop = false;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label13.Location = new Point(98, 32);
            label13.Name = "label13";
            label13.Size = new Size(195, 25);
            label13.TabIndex = 0;
            label13.Text = "Total de entradas hoy";
            // 
            // panel6
            // 
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(dataGridView1);
            panel6.Controls.Add(button11);
            panel6.Controls.Add(label14);
            panel6.Controls.Add(pictureBox15);
            panel6.Location = new Point(171, 367);
            panel6.Name = "panel6";
            panel6.Size = new Size(1354, 413);
            panel6.TabIndex = 18;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(220, 233, 247);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colFechaPP, colMovimientoPP, colProductoPP, colCantidadPP, colProveedorPP });
            dataGridView1.Location = new Point(-1, 95);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1354, 317);
            dataGridView1.TabIndex = 11;
            // 
            // colFechaPP
            // 
            colFechaPP.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colFechaPP.HeaderText = "Fecha";
            colFechaPP.MinimumWidth = 6;
            colFechaPP.Name = "colFechaPP";
            // 
            // colMovimientoPP
            // 
            colMovimientoPP.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colMovimientoPP.HeaderText = "Movimiento";
            colMovimientoPP.MinimumWidth = 6;
            colMovimientoPP.Name = "colMovimientoPP";
            // 
            // colProductoPP
            // 
            colProductoPP.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colProductoPP.HeaderText = "Producto";
            colProductoPP.MinimumWidth = 6;
            colProductoPP.Name = "colProductoPP";
            // 
            // colCantidadPP
            // 
            colCantidadPP.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colCantidadPP.HeaderText = "Cantidad";
            colCantidadPP.MinimumWidth = 6;
            colCantidadPP.Name = "colCantidadPP";
            // 
            // colProveedorPP
            // 
            colProveedorPP.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colProveedorPP.HeaderText = "Proveedor";
            colProveedorPP.MinimumWidth = 6;
            colProveedorPP.Name = "colProveedorPP";
            // 
            // button11
            // 
            button11.Cursor = Cursors.Hand;
            button11.FlatAppearance.BorderSize = 0;
            button11.FlatStyle = FlatStyle.Flat;
            button11.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button11.Image = (Image)resources.GetObject("button11.Image");
            button11.ImageAlign = ContentAlignment.MiddleRight;
            button11.Location = new Point(1195, 31);
            button11.Name = "button11";
            button11.Size = new Size(143, 35);
            button11.TabIndex = 10;
            button11.Text = "Ver todos";
            button11.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label14.Location = new Point(99, 35);
            label14.Name = "label14";
            label14.Size = new Size(207, 25);
            label14.TabIndex = 9;
            label14.Text = "Movimientos recientes";
            // 
            // pictureBox15
            // 
            pictureBox15.Image = (Image)resources.GetObject("pictureBox15.Image");
            pictureBox15.Location = new Point(6, 3);
            pictureBox15.Name = "pictureBox15";
            pictureBox15.Size = new Size(87, 86);
            pictureBox15.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox15.TabIndex = 10;
            pictureBox15.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(242, 249, 254);
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(pictureBox11);
            panel3.Controls.Add(label6);
            panel3.Location = new Point(637, 154);
            panel3.Name = "panel3";
            panel3.Size = new Size(424, 164);
            panel3.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(99, 63);
            label8.Name = "label8";
            label8.Size = new Size(33, 38);
            label8.TabIndex = 8;
            label8.Text = "8";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(99, 101);
            label7.Name = "label7";
            label7.Size = new Size(148, 23);
            label7.TabIndex = 7;
            label7.Text = "Requiere atención";
            // 
            // pictureBox11
            // 
            pictureBox11.Image = (Image)resources.GetObject("pictureBox11.Image");
            pictureBox11.Location = new Point(3, 30);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(90, 94);
            pictureBox11.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox11.TabIndex = 6;
            pictureBox11.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label6.Location = new Point(99, 32);
            label6.Name = "label6";
            label6.Size = new Size(255, 25);
            label6.TabIndex = 0;
            label6.Text = "Productos con stock mínimo";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(242, 249, 254);
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(pictureBox10);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(171, 154);
            panel2.Name = "panel2";
            panel2.Size = new Size(424, 164);
            panel2.TabIndex = 13;
            // 
            // pictureBox10
            // 
            pictureBox10.Image = (Image)resources.GetObject("pictureBox10.Image");
            pictureBox10.Location = new Point(3, 32);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(90, 94);
            pictureBox10.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox10.TabIndex = 5;
            pictureBox10.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(99, 58);
            label5.Name = "label5";
            label5.Size = new Size(65, 38);
            label5.TabIndex = 2;
            label5.Text = "100";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(99, 101);
            label4.Name = "label4";
            label4.Size = new Size(280, 23);
            label4.TabIndex = 1;
            label4.Text = "Productos registrado en el sistemas";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label3.Location = new Point(99, 32);
            label3.Name = "label3";
            label3.Size = new Size(170, 25);
            label3.TabIndex = 0;
            label3.Text = "Total de productos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(189, 100);
            label2.Name = "label2";
            label2.Size = new Size(406, 23);
            label2.TabIndex = 12;
            label2.Text = "Aquí tienes un resumen del estado de tu inventario.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(158, 44);
            label1.Name = "label1";
            label1.Size = new Size(473, 46);
            label1.TabIndex = 11;
            label1.Text = "¡Bienvenido, Administrador!";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(1238, 91);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(287, 27);
            dateTimePicker1.TabIndex = 19;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1178, 76);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(60, 60);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // frmPanelPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(220, 233, 247);
            ClientSize = new Size(1632, 915);
            Controls.Add(pictureBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(panel7);
            Controls.Add(panel6);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmPanelPrincipal";
            Text = "Librería PrintZone - Sistema de Inventario";
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox14).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox15).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel7;
        private Label label11;
        private Label label12;
        private PictureBox pictureBox14;
        private Label label13;
        private Panel panel6;
        private Button button11;
        private Label label14;
        private PictureBox pictureBox15;
        private Panel panel3;
        private Label label8;
        private Label label7;
        private PictureBox pictureBox11;
        private Label label6;
        private Panel panel2;
        private PictureBox pictureBox10;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn colFechaPP;
        private DataGridViewTextBoxColumn colMovimientoPP;
        private DataGridViewTextBoxColumn colProductoPP;
        private DataGridViewTextBoxColumn colCantidadPP;
        private DataGridViewTextBoxColumn colProveedorPP;
        private PictureBox pictureBox1;
    }
}
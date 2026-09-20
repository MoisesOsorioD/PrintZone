namespace LibreriaPrintZone
{
    partial class frmProductos
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductos));
            label2 = new Label();
            label1 = new Label();
            pictureBox10 = new PictureBox();
            dataGridView1 = new DataGridView();
            colProductoP = new DataGridViewTextBoxColumn();
            colDescripcionP = new DataGridViewTextBoxColumn();
            colMarcaP = new DataGridViewTextBoxColumn();
            colPrecioCompraP = new DataGridViewTextBoxColumn();
            colPrecioVentaP = new DataGridViewTextBoxColumn();
            colCodigoBarrasP = new DataGridViewTextBoxColumn();
            colStockActualP = new DataGridViewTextBoxColumn();
            colStockMinimoP = new DataGridViewTextBoxColumn();
            colCategoriaP = new DataGridViewTextBoxColumn();
            panel5 = new Panel();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            comboBox1 = new ComboBox();
            label15 = new Label();
            label14 = new Label();
            textBox9 = new TextBox();
            label12 = new Label();
            textBox7 = new TextBox();
            label11 = new Label();
            textBox8 = new TextBox();
            label10 = new Label();
            textBox6 = new TextBox();
            label9 = new Label();
            textBox5 = new TextBox();
            label8 = new Label();
            textBox4 = new TextBox();
            label7 = new Label();
            textBox3 = new TextBox();
            label13 = new Label();
            textBox2 = new TextBox();
            button9 = new Button();
            button11 = new Button();
            btnNuevoProductos = new Button();
            button1 = new Button();
            textBox1 = new TextBox();
            pictureBox14 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel5.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox14).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(260, 81);
            label2.Name = "label2";
            label2.Size = new Size(415, 23);
            label2.TabIndex = 7;
            label2.Text = "Consulta y administra los productos de tu inventario.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(229, 25);
            label1.Name = "label1";
            label1.Size = new Size(183, 46);
            label1.TabIndex = 6;
            label1.Text = "Productos";
            // 
            // pictureBox10
            // 
            pictureBox10.Image = Properties.Resources.Total_de_productos;
            pictureBox10.Location = new Point(140, 16);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(100, 100);
            pictureBox10.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox10.TabIndex = 8;
            pictureBox10.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.BackgroundColor = Color.FromArgb(220, 233, 247);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colProductoP, colDescripcionP, colMarcaP, colPrecioCompraP, colPrecioVentaP, colCodigoBarrasP, colStockActualP, colStockMinimoP, colCategoriaP });
            dataGridView1.Location = new Point(687, 209);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(933, 647);
            dataGridView1.TabIndex = 8;
            // 
            // colProductoP
            // 
            colProductoP.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colProductoP.HeaderText = "Producto";
            colProductoP.MinimumWidth = 6;
            colProductoP.Name = "colProductoP";
            // 
            // colDescripcionP
            // 
            colDescripcionP.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colDescripcionP.HeaderText = "Descripción";
            colDescripcionP.MinimumWidth = 6;
            colDescripcionP.Name = "colDescripcionP";
            // 
            // colMarcaP
            // 
            colMarcaP.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colMarcaP.HeaderText = "Marca";
            colMarcaP.MinimumWidth = 6;
            colMarcaP.Name = "colMarcaP";
            // 
            // colPrecioCompraP
            // 
            colPrecioCompraP.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colPrecioCompraP.HeaderText = "Precio de compra";
            colPrecioCompraP.MinimumWidth = 6;
            colPrecioCompraP.Name = "colPrecioCompraP";
            // 
            // colPrecioVentaP
            // 
            colPrecioVentaP.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colPrecioVentaP.HeaderText = "Precio de venta";
            colPrecioVentaP.MinimumWidth = 6;
            colPrecioVentaP.Name = "colPrecioVentaP";
            // 
            // colCodigoBarrasP
            // 
            colCodigoBarrasP.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colCodigoBarrasP.HeaderText = "Código de barras";
            colCodigoBarrasP.MinimumWidth = 6;
            colCodigoBarrasP.Name = "colCodigoBarrasP";
            // 
            // colStockActualP
            // 
            colStockActualP.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colStockActualP.HeaderText = "Stock actual";
            colStockActualP.MinimumWidth = 6;
            colStockActualP.Name = "colStockActualP";
            // 
            // colStockMinimoP
            // 
            colStockMinimoP.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colStockMinimoP.HeaderText = "Stock minimo";
            colStockMinimoP.MinimumWidth = 6;
            colStockMinimoP.Name = "colStockMinimoP";
            // 
            // colCategoriaP
            // 
            colCategoriaP.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colCategoriaP.HeaderText = "Categoría";
            colCategoriaP.MinimumWidth = 6;
            colCategoriaP.Name = "colCategoriaP";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(242, 249, 254);
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(panel1);
            panel5.Controls.Add(comboBox1);
            panel5.Controls.Add(label15);
            panel5.Controls.Add(label14);
            panel5.Controls.Add(textBox9);
            panel5.Controls.Add(label12);
            panel5.Controls.Add(textBox7);
            panel5.Controls.Add(label11);
            panel5.Controls.Add(textBox8);
            panel5.Controls.Add(label10);
            panel5.Controls.Add(textBox6);
            panel5.Controls.Add(label9);
            panel5.Controls.Add(textBox5);
            panel5.Controls.Add(label8);
            panel5.Controls.Add(textBox4);
            panel5.Controls.Add(label7);
            panel5.Controls.Add(textBox3);
            panel5.Controls.Add(label13);
            panel5.Controls.Add(textBox2);
            panel5.Location = new Point(139, 209);
            panel5.Name = "panel5";
            panel5.Size = new Size(524, 647);
            panel5.TabIndex = 12;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(220, 233, 247);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(27, 494);
            panel1.Name = "panel1";
            panel1.Size = new Size(475, 103);
            panel1.TabIndex = 38;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(18, 19);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(76, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(93, 27);
            label3.Name = "label3";
            label3.Size = new Size(336, 46);
            label3.TabIndex = 0;
            label3.Text = "El stock actual no se edita manualmente.\r\nSe actualiza desde las Entradas y Salidas.";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(27, 280);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(227, 28);
            comboBox1.TabIndex = 35;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(27, 257);
            label15.Name = "label15";
            label15.Size = new Size(75, 20);
            label15.TabIndex = 37;
            label15.Text = "Categoría";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(276, 413);
            label14.Name = "label14";
            label14.Size = new Size(102, 20);
            label14.TabIndex = 34;
            label14.Text = "Stock minimo";
            // 
            // textBox9
            // 
            textBox9.Location = new Point(276, 438);
            textBox9.Name = "textBox9";
            textBox9.PlaceholderText = " 10";
            textBox9.Size = new Size(227, 27);
            textBox9.TabIndex = 33;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(27, 413);
            label12.Name = "label12";
            label12.Size = new Size(91, 20);
            label12.TabIndex = 31;
            label12.Text = "Stock actual";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(276, 280);
            textBox7.Name = "textBox7";
            textBox7.PlaceholderText = " 18495632";
            textBox7.Size = new Size(226, 27);
            textBox7.TabIndex = 27;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(276, 257);
            label11.Name = "label11";
            label11.Size = new Size(126, 20);
            label11.TabIndex = 28;
            label11.Text = "Código de barras";
            // 
            // textBox8
            // 
            textBox8.Location = new Point(27, 438);
            textBox8.Name = "textBox8";
            textBox8.PlaceholderText = " 50";
            textBox8.ReadOnly = true;
            textBox8.Size = new Size(226, 27);
            textBox8.TabIndex = 30;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(276, 335);
            label10.Name = "label10";
            label10.Size = new Size(115, 20);
            label10.TabIndex = 25;
            label10.Text = "Precio de venta";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(276, 360);
            textBox6.Name = "textBox6";
            textBox6.PlaceholderText = "  C$ 200.00";
            textBox6.Size = new Size(227, 27);
            textBox6.TabIndex = 24;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(27, 335);
            label9.Name = "label9";
            label9.Size = new Size(129, 20);
            label9.TabIndex = 22;
            label9.Text = "Precio de compra";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(27, 360);
            textBox5.Name = "textBox5";
            textBox5.PlaceholderText = " C$ 150.00";
            textBox5.Size = new Size(226, 27);
            textBox5.TabIndex = 21;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(276, 69);
            label8.Name = "label8";
            label8.Size = new Size(52, 20);
            label8.TabIndex = 19;
            label8.Text = "Marca";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(277, 92);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = " Report";
            textBox4.Size = new Size(226, 27);
            textBox4.TabIndex = 18;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(27, 149);
            label7.Name = "label7";
            label7.Size = new Size(89, 20);
            label7.TabIndex = 16;
            label7.Text = "Descripción";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(27, 172);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = " Papel bond tamaño carta, 500 hojas.";
            textBox3.Size = new Size(475, 57);
            textBox3.TabIndex = 15;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(27, 69);
            label13.Name = "label13";
            label13.Size = new Size(72, 20);
            label13.TabIndex = 13;
            label13.Text = "Producto";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(27, 92);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = " Resma de papel";
            textBox2.Size = new Size(226, 27);
            textBox2.TabIndex = 12;
            // 
            // button9
            // 
            button9.BackColor = Color.FromArgb(234, 45, 89);
            button9.FlatAppearance.BorderSize = 0;
            button9.FlatStyle = FlatStyle.Flat;
            button9.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button9.ForeColor = Color.White;
            button9.Image = (Image)resources.GetObject("button9.Image");
            button9.ImageAlign = ContentAlignment.MiddleLeft;
            button9.Location = new Point(687, 133);
            button9.Name = "button9";
            button9.Size = new Size(121, 37);
            button9.TabIndex = 40;
            button9.Text = "Eliminar";
            button9.TextAlign = ContentAlignment.MiddleRight;
            button9.UseVisualStyleBackColor = false;
            // 
            // button11
            // 
            button11.BackColor = Color.FromArgb(2, 113, 249);
            button11.FlatAppearance.BorderSize = 0;
            button11.FlatStyle = FlatStyle.Flat;
            button11.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button11.ForeColor = Color.White;
            button11.Image = Properties.Resources.Guardar;
            button11.ImageAlign = ContentAlignment.MiddleLeft;
            button11.Location = new Point(365, 133);
            button11.Name = "button11";
            button11.Size = new Size(121, 37);
            button11.TabIndex = 38;
            button11.Text = "Guardar";
            button11.TextAlign = ContentAlignment.MiddleRight;
            button11.UseVisualStyleBackColor = false;
            // 
            // btnNuevoProductos
            // 
            btnNuevoProductos.BackColor = Color.FromArgb(2, 113, 249);
            btnNuevoProductos.FlatAppearance.BorderSize = 0;
            btnNuevoProductos.FlatStyle = FlatStyle.Flat;
            btnNuevoProductos.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNuevoProductos.ForeColor = Color.White;
            btnNuevoProductos.Image = Properties.Resources.Agregar;
            btnNuevoProductos.ImageAlign = ContentAlignment.MiddleLeft;
            btnNuevoProductos.Location = new Point(139, 133);
            btnNuevoProductos.Name = "btnNuevoProductos";
            btnNuevoProductos.Size = new Size(189, 37);
            btnNuevoProductos.TabIndex = 39;
            btnNuevoProductos.Text = "Nuevo Producto";
            btnNuevoProductos.TextAlign = ContentAlignment.MiddleRight;
            btnNuevoProductos.UseVisualStyleBackColor = false;
            btnNuevoProductos.Click += btnNuevoProductos_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(2, 113, 249);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(522, 133);
            button1.Name = "button1";
            button1.Size = new Size(121, 37);
            button1.TabIndex = 41;
            button1.Text = "Limipar";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(999, 140);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = " Buscar productos por nombre o código de barra";
            textBox1.Size = new Size(621, 30);
            textBox1.TabIndex = 42;
            // 
            // pictureBox14
            // 
            pictureBox14.Image = (Image)resources.GetObject("pictureBox14.Image");
            pictureBox14.Location = new Point(953, 140);
            pictureBox14.Name = "pictureBox14";
            pictureBox14.Size = new Size(40, 40);
            pictureBox14.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox14.TabIndex = 60;
            pictureBox14.TabStop = false;
            // 
            // frmProductos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(220, 233, 247);
            ClientSize = new Size(1632, 915);
            Controls.Add(pictureBox14);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(button9);
            Controls.Add(button11);
            Controls.Add(panel5);
            Controls.Add(btnNuevoProductos);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox10);
            Name = "frmProductos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Librería PrintZone - Gestión de Productos";
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox14).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label1;
        private PictureBox pictureBox10;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn colProductoP;
        private DataGridViewTextBoxColumn colDescripcionP;
        private DataGridViewTextBoxColumn colMarcaP;
        private DataGridViewTextBoxColumn colPrecioCompraP;
        private DataGridViewTextBoxColumn colPrecioVentaP;
        private DataGridViewTextBoxColumn colCodigoBarrasP;
        private DataGridViewTextBoxColumn colStockActualP;
        private DataGridViewTextBoxColumn colStockMinimoP;
        private DataGridViewTextBoxColumn colCategoriaP;
        private Panel panel5;
        private Label label10;
        private TextBox textBox6;
        private Label label9;
        private TextBox textBox5;
        private Label label8;
        private TextBox textBox4;
        private Label label7;
        private TextBox textBox3;
        private Label label13;
        private TextBox textBox2;
        private Label label12;
        private TextBox textBox8;
        private Label label11;
        private TextBox textBox7;
        private ComboBox comboBox1;
        private Label label15;
        private Label label14;
        private TextBox textBox9;
        private Button button9;
        private Button button11;
        private Button btnNuevoProductos;
        private Button button1;
        private TextBox textBox1;
        private Panel panel1;
        private Label label3;
        private PictureBox pictureBox1;
        private PictureBox pictureBox14;
    }
}
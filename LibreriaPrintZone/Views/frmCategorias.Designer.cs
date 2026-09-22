namespace LibreriaPrintZone
{
    partial class frmCategorias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCategorias));
            label2 = new Label();
            label1 = new Label();
            pictureBox10 = new PictureBox();
            panel2 = new Panel();
            pictureBox11 = new PictureBox();
            lblTotalCategorias = new Label();
            label3 = new Label();
            panel3 = new Panel();
            lblCantidadMasProductos = new Label();
            pictureBox12 = new PictureBox();
            lblCategoriaMasProductos = new Label();
            label6 = new Label();
            panel4 = new Panel();
            lblCantidadMenosUsada = new Label();
            pictureBox13 = new PictureBox();
            lblCategoriaMenosUsada = new Label();
            label8 = new Label();
            panel5 = new Panel();
            label11 = new Label();
            pictureBox15 = new PictureBox();
            dgvCategorias = new DataGridView();
            colNombreCategoria = new DataGridViewTextBoxColumn();
            colCantidadProductos = new DataGridViewTextBoxColumn();
            pictureBox14 = new PictureBox();
            txtBuscar = new TextBox();
            panel6 = new Panel();
            label12 = new Label();
            pictureBox1 = new PictureBox();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            btnGuardar = new Button();
            label13 = new Label();
            txtNombreCategoria = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox15).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox14).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(251, 66);
            label2.Name = "label2";
            label2.Size = new Size(599, 23);
            label2.TabIndex = 4;
            label2.Text = "Gestiona las categorías utilizadas para organizar los productos del inventario.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(220, 10);
            label1.Name = "label1";
            label1.Size = new Size(189, 46);
            label1.TabIndex = 3;
            label1.Text = "Categorías";
            // 
            // pictureBox10
            // 
            pictureBox10.Image = (Image)resources.GetObject("pictureBox10.Image");
            pictureBox10.Location = new Point(131, 1);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(100, 100);
            pictureBox10.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox10.TabIndex = 5;
            pictureBox10.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(242, 249, 254);
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(pictureBox11);
            panel2.Controls.Add(lblTotalCategorias);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(131, 107);
            panel2.Name = "panel2";
            panel2.Size = new Size(445, 116);
            panel2.TabIndex = 6;
            // 
            // pictureBox11
            // 
            pictureBox11.Image = (Image)resources.GetObject("pictureBox11.Image");
            pictureBox11.Location = new Point(3, 12);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(90, 94);
            pictureBox11.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox11.TabIndex = 5;
            pictureBox11.TabStop = false;
            // 
            // lblTotalCategorias
            // 
            lblTotalCategorias.AutoSize = true;
            lblTotalCategorias.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalCategorias.Location = new Point(99, 38);
            lblTotalCategorias.Name = "lblTotalCategorias";
            lblTotalCategorias.Size = new Size(49, 38);
            lblTotalCategorias.TabIndex = 2;
            lblTotalCategorias.Text = "10";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label3.Location = new Point(99, 12);
            label3.Name = "label3";
            label3.Size = new Size(172, 25);
            label3.TabIndex = 0;
            label3.Text = "Total de categorías";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(242, 249, 254);
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(lblCantidadMasProductos);
            panel3.Controls.Add(pictureBox12);
            panel3.Controls.Add(lblCategoriaMasProductos);
            panel3.Controls.Add(label6);
            panel3.Location = new Point(647, 107);
            panel3.Name = "panel3";
            panel3.Size = new Size(445, 116);
            panel3.TabIndex = 7;
            // 
            // lblCantidadMasProductos
            // 
            lblCantidadMasProductos.AutoSize = true;
            lblCantidadMasProductos.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCantidadMasProductos.Location = new Point(99, 83);
            lblCantidadMasProductos.Name = "lblCantidadMasProductos";
            lblCantidadMasProductos.Size = new Size(110, 23);
            lblCantidadMasProductos.TabIndex = 9;
            lblCantidadMasProductos.Text = "40 productos";
            // 
            // pictureBox12
            // 
            pictureBox12.Image = Properties.Resources.CategoriaMas;
            pictureBox12.Location = new Point(3, 12);
            pictureBox12.Name = "pictureBox12";
            pictureBox12.Size = new Size(90, 94);
            pictureBox12.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox12.TabIndex = 5;
            pictureBox12.TabStop = false;
            // 
            // lblCategoriaMasProductos
            // 
            lblCategoriaMasProductos.AutoSize = true;
            lblCategoriaMasProductos.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCategoriaMasProductos.Location = new Point(99, 38);
            lblCategoriaMasProductos.Name = "lblCategoriaMasProductos";
            lblCategoriaMasProductos.Size = new Size(137, 38);
            lblCategoriaMasProductos.TabIndex = 2;
            lblCategoriaMasProductos.Text = "Papelería";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label6.Location = new Point(99, 12);
            label6.Name = "label6";
            label6.Size = new Size(262, 25);
            label6.TabIndex = 0;
            label6.Text = "Categoría con más productos";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(242, 249, 254);
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(lblCantidadMenosUsada);
            panel4.Controls.Add(pictureBox13);
            panel4.Controls.Add(lblCategoriaMenosUsada);
            panel4.Controls.Add(label8);
            panel4.Location = new Point(1138, 107);
            panel4.Name = "panel4";
            panel4.Size = new Size(441, 116);
            panel4.TabIndex = 8;
            // 
            // lblCantidadMenosUsada
            // 
            lblCantidadMenosUsada.AutoSize = true;
            lblCantidadMenosUsada.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCantidadMenosUsada.Location = new Point(99, 83);
            lblCantidadMenosUsada.Name = "lblCantidadMenosUsada";
            lblCantidadMenosUsada.Size = new Size(101, 23);
            lblCantidadMenosUsada.TabIndex = 10;
            lblCantidadMenosUsada.Text = "4 productos";
            // 
            // pictureBox13
            // 
            pictureBox13.Image = Properties.Resources.Categoria_Menos;
            pictureBox13.Location = new Point(3, 12);
            pictureBox13.Name = "pictureBox13";
            pictureBox13.Size = new Size(90, 94);
            pictureBox13.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox13.TabIndex = 5;
            pictureBox13.TabStop = false;
            // 
            // lblCategoriaMenosUsada
            // 
            lblCategoriaMenosUsada.AutoSize = true;
            lblCategoriaMenosUsada.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCategoriaMenosUsada.Location = new Point(99, 38);
            lblCategoriaMenosUsada.Name = "lblCategoriaMenosUsada";
            lblCategoriaMenosUsada.Size = new Size(110, 38);
            lblCategoriaMenosUsada.TabIndex = 2;
            lblCategoriaMenosUsada.Text = "Oficina";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label8.Location = new Point(99, 12);
            label8.Name = "label8";
            label8.Size = new Size(212, 25);
            label8.TabIndex = 0;
            label8.Text = "Categoría menos usada";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(242, 249, 254);
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(label11);
            panel5.Controls.Add(pictureBox15);
            panel5.Controls.Add(dgvCategorias);
            panel5.Location = new Point(647, 293);
            panel5.Name = "panel5";
            panel5.Size = new Size(932, 455);
            panel5.TabIndex = 9;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label11.Location = new Point(99, 40);
            label11.Name = "label11";
            label11.Size = new Size(230, 25);
            label11.TabIndex = 6;
            label11.Text = "Categorías registradas";
            // 
            // pictureBox15
            // 
            pictureBox15.Image = Properties.Resources.Detalle_categoria;
            pictureBox15.Location = new Point(33, 22);
            pictureBox15.Name = "pictureBox15";
            pictureBox15.Size = new Size(60, 60);
            pictureBox15.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox15.TabIndex = 7;
            pictureBox15.TabStop = false;
            // 
            // dgvCategorias
            // 
            dgvCategorias.BackgroundColor = Color.FromArgb(220, 233, 247);
            dgvCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategorias.Columns.AddRange(new DataGridViewColumn[] { colNombreCategoria, colCantidadProductos });
            dgvCategorias.Location = new Point(33, 97);
            dgvCategorias.Name = "dgvCategorias";
            dgvCategorias.RowHeadersWidth = 51;
            dgvCategorias.Size = new Size(877, 317);
            dgvCategorias.TabIndex = 0;
            dgvCategorias.CellClick += dgvCategorias_CellClick;
            // 
            // colNombreCategoria
            // 
            colNombreCategoria.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colNombreCategoria.HeaderText = "Nombre de Categoría";
            colNombreCategoria.MinimumWidth = 6;
            colNombreCategoria.Name = "colNombreCategoria";
            // 
            // colCantidadProductos
            // 
            colCantidadProductos.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colCantidadProductos.HeaderText = "Producto";
            colCantidadProductos.MinimumWidth = 6;
            colCantidadProductos.Name = "colCantidadProductos";
            // 
            // pictureBox14
            // 
            pictureBox14.Image = (Image)resources.GetObject("pictureBox14.Image");
            pictureBox14.Location = new Point(651, 240);
            pictureBox14.Name = "pictureBox14";
            pictureBox14.Size = new Size(40, 40);
            pictureBox14.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox14.TabIndex = 6;
            pictureBox14.TabStop = false;
            // 
            // txtBuscar
            // 
            txtBuscar.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscar.Location = new Point(697, 245);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = " Buscar categoría por nombre...";
            txtBuscar.Size = new Size(882, 30);
            txtBuscar.TabIndex = 1;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(242, 249, 254);
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(label12);
            panel6.Controls.Add(pictureBox1);
            panel6.Controls.Add(btnEliminar);
            panel6.Controls.Add(btnLimpiar);
            panel6.Controls.Add(btnGuardar);
            panel6.Controls.Add(label13);
            panel6.Controls.Add(txtNombreCategoria);
            panel6.Location = new Point(131, 240);
            panel6.Name = "panel6";
            panel6.Size = new Size(445, 508);
            panel6.TabIndex = 10;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label12.Location = new Point(88, 75);
            label12.Name = "label12";
            label12.Size = new Size(238, 25);
            label12.TabIndex = 8;
            label12.Text = "Detalles de la categoría";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Detalle_categoria;
            pictureBox1.Location = new Point(23, 52);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(60, 60);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(234, 45, 89);
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Image = (Image)resources.GetObject("btnEliminar.Image");
            btnEliminar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEliminar.Location = new Point(299, 245);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(109, 37);
            btnEliminar.TabIndex = 15;
            btnEliminar.Text = "Eliminar";
            btnEliminar.TextAlign = ContentAlignment.MiddleRight;
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(2, 113, 249);
            btnLimpiar.FlatAppearance.BorderSize = 0;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.Image = (Image)resources.GetObject("btnLimpiar.Image");
            btnLimpiar.ImageAlign = ContentAlignment.MiddleLeft;
            btnLimpiar.Location = new Point(171, 245);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(109, 37);
            btnLimpiar.TabIndex = 8;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.TextAlign = ContentAlignment.MiddleRight;
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(2, 113, 249);
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Image = (Image)resources.GetObject("btnGuardar.Image");
            btnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardar.Location = new Point(23, 245);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(125, 37);
            btnGuardar.TabIndex = 8;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextAlign = ContentAlignment.MiddleRight;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(41, 149);
            label13.Name = "label13";
            label13.Size = new Size(171, 20);
            label13.TabIndex = 10;
            label13.Text = "Nombre de la categoría";
            // 
            // txtNombreCategoria
            // 
            txtNombreCategoria.Location = new Point(41, 172);
            txtNombreCategoria.Name = "txtNombreCategoria";
            txtNombreCategoria.PlaceholderText = " Ej. Libros";
            txtNombreCategoria.Size = new Size(342, 27);
            txtNombreCategoria.TabIndex = 9;
            // 
            // frmCategorias
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(220, 233, 247);
            ClientSize = new Size(1614, 868);
            Controls.Add(panel6);
            Controls.Add(pictureBox14);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(txtBuscar);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox10);
            Name = "frmCategorias";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Librería PrintZone - Gestión de categorías";
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox15).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox14).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label1;
        private PictureBox pictureBox10;
        private Panel panel2;
        private PictureBox pictureBox11;
        private Label lblTotalCategorias;
        private Label label3;
        private Panel panel3;
        private PictureBox pictureBox12;
        private Label lblCategoriaMasProductos;
        private Label label6;
        private Panel panel4;
        private PictureBox pictureBox13;
        private Label lblCategoriaMenosUsada;
        private Label label8;
        private Label lblCantidadMasProductos;
        private Label lblCantidadMenosUsada;
        private Panel panel5;
        private DataGridView dgvCategorias;
        private TextBox txtBuscar;
        private PictureBox pictureBox14;
        private Label label11;
        private Panel panel6;
        private Label label12;
        private TextBox txtNombreCategoria;
        private Label label13;
        private Button btnGuardar;
        private Button btnLimpiar;
        private Button btnEliminar;
        private PictureBox pictureBox15;
        private PictureBox pictureBox1;
        private DataGridViewTextBoxColumn colNombreCategoria;
        private DataGridViewTextBoxColumn colCantidadProductos;
    }
}
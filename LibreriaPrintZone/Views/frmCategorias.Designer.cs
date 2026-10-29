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
            panelTotalCategoria = new Panel();
            pictureBox11 = new PictureBox();
            lblTotalCategorias = new Label();
            label3 = new Label();
            panelCategoriaMasProductos = new Panel();
            lblCantidadMasProductos = new Label();
            pictureBox12 = new PictureBox();
            lblCategoriaMasProductos = new Label();
            label6 = new Label();
            panelCategoriaMenosUsada = new Panel();
            lblCantidadMenosUsada = new Label();
            pictureBox13 = new PictureBox();
            lblCategoriaMenosUsada = new Label();
            label8 = new Label();
            panelCategoriasRegistradas = new Panel();
            pictureBox14 = new PictureBox();
            txtBuscar = new TextBox();
            panelPaginacion = new Panel();
            label11 = new Label();
            dgvCategorias = new DataGridView();
            colNombreCategoria = new DataGridViewTextBoxColumn();
            colCantidadProductos = new DataGridViewTextBoxColumn();
            pictureBox15 = new PictureBox();
            panelDetalles = new Panel();
            label12 = new Label();
            pictureBox1 = new PictureBox();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            btnGuardar = new Button();
            label13 = new Label();
            txtNombreCategoria = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            panelTotalCategoria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
            panelCategoriaMasProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).BeginInit();
            panelCategoriaMenosUsada.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).BeginInit();
            panelCategoriasRegistradas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox14).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox15).BeginInit();
            panelDetalles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(349, 112);
            label2.Name = "label2";
            label2.Size = new Size(599, 23);
            label2.TabIndex = 4;
            label2.Text = "Gestiona las categorías utilizadas para organizar los productos del inventario.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(318, 56);
            label1.Name = "label1";
            label1.Size = new Size(189, 46);
            label1.TabIndex = 3;
            label1.Text = "Categorías";
            // 
            // pictureBox10
            // 
            pictureBox10.Image = (Image)resources.GetObject("pictureBox10.Image");
            pictureBox10.Location = new Point(229, 47);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(100, 100);
            pictureBox10.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox10.TabIndex = 5;
            pictureBox10.TabStop = false;
            // 
            // panelTotalCategoria
            // 
            panelTotalCategoria.BackColor = Color.FromArgb(242, 249, 254);
            panelTotalCategoria.Controls.Add(pictureBox11);
            panelTotalCategoria.Controls.Add(lblTotalCategorias);
            panelTotalCategoria.Controls.Add(label3);
            panelTotalCategoria.Location = new Point(244, 153);
            panelTotalCategoria.Name = "panelTotalCategoria";
            panelTotalCategoria.Size = new Size(445, 116);
            panelTotalCategoria.TabIndex = 6;
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
            // panelCategoriaMasProductos
            // 
            panelCategoriaMasProductos.BackColor = Color.FromArgb(242, 249, 254);
            panelCategoriaMasProductos.Controls.Add(lblCantidadMasProductos);
            panelCategoriaMasProductos.Controls.Add(pictureBox12);
            panelCategoriaMasProductos.Controls.Add(lblCategoriaMasProductos);
            panelCategoriaMasProductos.Controls.Add(label6);
            panelCategoriaMasProductos.Location = new Point(745, 153);
            panelCategoriaMasProductos.Name = "panelCategoriaMasProductos";
            panelCategoriaMasProductos.Size = new Size(445, 116);
            panelCategoriaMasProductos.TabIndex = 7;
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
            // panelCategoriaMenosUsada
            // 
            panelCategoriaMenosUsada.BackColor = Color.FromArgb(242, 249, 254);
            panelCategoriaMenosUsada.Controls.Add(lblCantidadMenosUsada);
            panelCategoriaMenosUsada.Controls.Add(pictureBox13);
            panelCategoriaMenosUsada.Controls.Add(lblCategoriaMenosUsada);
            panelCategoriaMenosUsada.Controls.Add(label8);
            panelCategoriaMenosUsada.Location = new Point(1236, 153);
            panelCategoriaMenosUsada.Name = "panelCategoriaMenosUsada";
            panelCategoriaMenosUsada.Size = new Size(441, 116);
            panelCategoriaMenosUsada.TabIndex = 8;
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
            // panelCategoriasRegistradas
            // 
            panelCategoriasRegistradas.BackColor = Color.FromArgb(242, 249, 254);
            panelCategoriasRegistradas.Controls.Add(pictureBox14);
            panelCategoriasRegistradas.Controls.Add(txtBuscar);
            panelCategoriasRegistradas.Controls.Add(panelPaginacion);
            panelCategoriasRegistradas.Controls.Add(label11);
            panelCategoriasRegistradas.Controls.Add(dgvCategorias);
            panelCategoriasRegistradas.Controls.Add(pictureBox15);
            panelCategoriasRegistradas.Location = new Point(745, 286);
            panelCategoriasRegistradas.Name = "panelCategoriasRegistradas";
            panelCategoriasRegistradas.Size = new Size(932, 568);
            panelCategoriasRegistradas.TabIndex = 9;
            // 
            // pictureBox14
            // 
            pictureBox14.Image = (Image)resources.GetObject("pictureBox14.Image");
            pictureBox14.Location = new Point(33, 75);
            pictureBox14.Name = "pictureBox14";
            pictureBox14.Size = new Size(40, 40);
            pictureBox14.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox14.TabIndex = 6;
            pictureBox14.TabStop = false;
            // 
            // txtBuscar
            // 
            txtBuscar.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscar.Location = new Point(79, 80);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = " Buscar categoría por nombre...";
            txtBuscar.Size = new Size(831, 30);
            txtBuscar.TabIndex = 1;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // panelPaginacion
            // 
            panelPaginacion.BackColor = Color.FromArgb(220, 233, 247);
            panelPaginacion.Location = new Point(33, 500);
            panelPaginacion.Name = "panelPaginacion";
            panelPaginacion.Size = new Size(877, 59);
            panelPaginacion.TabIndex = 10;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label11.Location = new Point(99, 21);
            label11.Name = "label11";
            label11.Size = new Size(230, 25);
            label11.TabIndex = 6;
            label11.Text = "Categorías registradas";
            // 
            // dgvCategorias
            // 
            dgvCategorias.BackgroundColor = Color.FromArgb(220, 233, 247);
            dgvCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategorias.Columns.AddRange(new DataGridViewColumn[] { colNombreCategoria, colCantidadProductos });
            dgvCategorias.Location = new Point(33, 121);
            dgvCategorias.Name = "dgvCategorias";
            dgvCategorias.RowHeadersWidth = 51;
            dgvCategorias.Size = new Size(877, 373);
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
            // pictureBox15
            // 
            pictureBox15.Image = (Image)resources.GetObject("pictureBox15.Image");
            pictureBox15.Location = new Point(33, 3);
            pictureBox15.Name = "pictureBox15";
            pictureBox15.Size = new Size(60, 60);
            pictureBox15.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox15.TabIndex = 7;
            pictureBox15.TabStop = false;
            // 
            // panelDetalles
            // 
            panelDetalles.BackColor = Color.FromArgb(242, 249, 254);
            panelDetalles.Controls.Add(label12);
            panelDetalles.Controls.Add(pictureBox1);
            panelDetalles.Controls.Add(btnEliminar);
            panelDetalles.Controls.Add(btnLimpiar);
            panelDetalles.Controls.Add(btnGuardar);
            panelDetalles.Controls.Add(label13);
            panelDetalles.Controls.Add(txtNombreCategoria);
            panelDetalles.Location = new Point(244, 286);
            panelDetalles.Name = "panelDetalles";
            panelDetalles.Size = new Size(445, 568);
            panelDetalles.TabIndex = 10;
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
            ClientSize = new Size(1902, 983);
            Controls.Add(panelDetalles);
            Controls.Add(panelCategoriasRegistradas);
            Controls.Add(panelCategoriaMenosUsada);
            Controls.Add(panelCategoriaMasProductos);
            Controls.Add(panelTotalCategoria);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox10);
            Name = "frmCategorias";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Librería PrintZone - Gestión de categorías";
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            panelTotalCategoria.ResumeLayout(false);
            panelTotalCategoria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).EndInit();
            panelCategoriaMasProductos.ResumeLayout(false);
            panelCategoriaMasProductos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).EndInit();
            panelCategoriaMenosUsada.ResumeLayout(false);
            panelCategoriaMenosUsada.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).EndInit();
            panelCategoriasRegistradas.ResumeLayout(false);
            panelCategoriasRegistradas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox14).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox15).EndInit();
            panelDetalles.ResumeLayout(false);
            panelDetalles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label1;
        private PictureBox pictureBox10;
        private Panel panelTotalCategoria;
        private PictureBox pictureBox11;
        private Label lblTotalCategorias;
        private Label label3;
        private Panel panelCategoriaMasProductos;
        private PictureBox pictureBox12;
        private Label lblCategoriaMasProductos;
        private Label label6;
        private Panel panelCategoriaMenosUsada;
        private PictureBox pictureBox13;
        private Label lblCategoriaMenosUsada;
        private Label label8;
        private Label lblCantidadMasProductos;
        private Label lblCantidadMenosUsada;
        private Panel panelCategoriasRegistradas;
        private DataGridView dgvCategorias;
        private TextBox txtBuscar;
        private PictureBox pictureBox14;
        private Label label11;
        private Panel panelDetalles;
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
        private Panel panelPaginacion;
    }
}
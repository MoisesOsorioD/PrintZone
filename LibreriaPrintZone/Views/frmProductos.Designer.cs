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
            dgvProductos = new DataGridView();
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
            cmbCategoria = new ComboBox();
            label15 = new Label();
            label14 = new Label();
            txtStockMinimo = new TextBox();
            label12 = new Label();
            txtCodigoBarras = new TextBox();
            label11 = new Label();
            txtStockActual = new TextBox();
            label10 = new Label();
            txtPrecioVenta = new TextBox();
            label9 = new Label();
            txtPrecioCompra = new TextBox();
            label8 = new Label();
            txtMarca = new TextBox();
            label7 = new Label();
            txtDescripcion = new TextBox();
            label13 = new Label();
            txtProducto = new TextBox();
            btnEliminar = new Button();
            btnGuardar = new Button();
            btnNuevoProductos = new Button();
            btnLimpiar = new Button();
            txtBuscar = new TextBox();
            pictureBox14 = new PictureBox();
            btnProductosInactivos = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
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
            // dgvProductos
            // 
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgvProductos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvProductos.BackgroundColor = Color.FromArgb(220, 233, 247);
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Columns.AddRange(new DataGridViewColumn[] { colProductoP, colDescripcionP, colMarcaP, colPrecioCompraP, colPrecioVentaP, colCodigoBarrasP, colStockActualP, colStockMinimoP, colCategoriaP });
            dgvProductos.Location = new Point(687, 255);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.RowHeadersWidth = 51;
            dgvProductos.Size = new Size(933, 601);
            dgvProductos.TabIndex = 8;
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
            panel5.Controls.Add(cmbCategoria);
            panel5.Controls.Add(label15);
            panel5.Controls.Add(label14);
            panel5.Controls.Add(txtStockMinimo);
            panel5.Controls.Add(label12);
            panel5.Controls.Add(txtCodigoBarras);
            panel5.Controls.Add(label11);
            panel5.Controls.Add(txtStockActual);
            panel5.Controls.Add(label10);
            panel5.Controls.Add(txtPrecioVenta);
            panel5.Controls.Add(label9);
            panel5.Controls.Add(txtPrecioCompra);
            panel5.Controls.Add(label8);
            panel5.Controls.Add(txtMarca);
            panel5.Controls.Add(label7);
            panel5.Controls.Add(txtDescripcion);
            panel5.Controls.Add(label13);
            panel5.Controls.Add(txtProducto);
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
            // cmbCategoria
            // 
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(27, 280);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(227, 28);
            cmbCategoria.TabIndex = 35;
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
            // txtStockMinimo
            // 
            txtStockMinimo.Location = new Point(276, 438);
            txtStockMinimo.Name = "txtStockMinimo";
            txtStockMinimo.Size = new Size(227, 27);
            txtStockMinimo.TabIndex = 33;
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
            // txtCodigoBarras
            // 
            txtCodigoBarras.Location = new Point(276, 280);
            txtCodigoBarras.Name = "txtCodigoBarras";
            txtCodigoBarras.Size = new Size(226, 27);
            txtCodigoBarras.TabIndex = 27;
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
            // txtStockActual
            // 
            txtStockActual.Location = new Point(27, 438);
            txtStockActual.Name = "txtStockActual";
            txtStockActual.ReadOnly = true;
            txtStockActual.Size = new Size(226, 27);
            txtStockActual.TabIndex = 30;
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
            // txtPrecioVenta
            // 
            txtPrecioVenta.Location = new Point(276, 360);
            txtPrecioVenta.Name = "txtPrecioVenta";
            txtPrecioVenta.Size = new Size(227, 27);
            txtPrecioVenta.TabIndex = 24;
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
            // txtPrecioCompra
            // 
            txtPrecioCompra.Location = new Point(27, 360);
            txtPrecioCompra.Name = "txtPrecioCompra";
            txtPrecioCompra.Size = new Size(226, 27);
            txtPrecioCompra.TabIndex = 21;
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
            // txtMarca
            // 
            txtMarca.Location = new Point(277, 92);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(226, 27);
            txtMarca.TabIndex = 18;
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
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(27, 172);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(475, 57);
            txtDescripcion.TabIndex = 15;
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
            // txtProducto
            // 
            txtProducto.Location = new Point(27, 92);
            txtProducto.Name = "txtProducto";
            txtProducto.Size = new Size(226, 27);
            txtProducto.TabIndex = 12;
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
            btnEliminar.Location = new Point(911, 133);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(121, 37);
            btnEliminar.TabIndex = 40;
            btnEliminar.Text = "Eliminar";
            btnEliminar.TextAlign = ContentAlignment.MiddleRight;
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(2, 113, 249);
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Image = Properties.Resources.Guardar;
            btnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardar.Location = new Point(355, 133);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(137, 37);
            btnGuardar.TabIndex = 38;
            btnGuardar.Text = "Actualizar";
            btnGuardar.TextAlign = ContentAlignment.MiddleRight;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
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
            btnNuevoProductos.Click += btnNuevoProducto_Click;
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
            btnLimpiar.Location = new Point(528, 133);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(121, 37);
            btnLimpiar.TabIndex = 41;
            btnLimpiar.Text = "Limipar";
            btnLimpiar.TextAlign = ContentAlignment.MiddleRight;
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscar.Location = new Point(733, 209);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = " Buscar productos por nombre o código de barra";
            txtBuscar.Size = new Size(887, 30);
            txtBuscar.TabIndex = 42;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // pictureBox14
            // 
            pictureBox14.Image = (Image)resources.GetObject("pictureBox14.Image");
            pictureBox14.Location = new Point(687, 209);
            pictureBox14.Name = "pictureBox14";
            pictureBox14.Size = new Size(40, 40);
            pictureBox14.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox14.TabIndex = 60;
            pictureBox14.TabStop = false;
            // 
            // btnProductosInactivos
            // 
            btnProductosInactivos.BackColor = Color.FromArgb(2, 113, 249);
            btnProductosInactivos.FlatAppearance.BorderSize = 0;
            btnProductosInactivos.FlatStyle = FlatStyle.Flat;
            btnProductosInactivos.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProductosInactivos.ForeColor = Color.White;
            btnProductosInactivos.Image = (Image)resources.GetObject("btnProductosInactivos.Image");
            btnProductosInactivos.ImageAlign = ContentAlignment.MiddleLeft;
            btnProductosInactivos.Location = new Point(687, 133);
            btnProductosInactivos.Name = "btnProductosInactivos";
            btnProductosInactivos.Size = new Size(201, 37);
            btnProductosInactivos.TabIndex = 61;
            btnProductosInactivos.Text = "Productos Inactivos";
            btnProductosInactivos.TextAlign = ContentAlignment.MiddleRight;
            btnProductosInactivos.UseVisualStyleBackColor = false;
            btnProductosInactivos.Click += btnProductosInactivos_Click;
            // 
            // frmProductos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(220, 233, 247);
            ClientSize = new Size(1632, 915);
            Controls.Add(btnProductosInactivos);
            Controls.Add(pictureBox14);
            Controls.Add(txtBuscar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
            Controls.Add(panel5);
            Controls.Add(btnNuevoProductos);
            Controls.Add(dgvProductos);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox10);
            Name = "frmProductos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Librería PrintZone - Gestión de Productos";
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
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
        private DataGridView dgvProductos;
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
        private TextBox txtPrecioVenta;
        private Label label9;
        private TextBox txtPrecioCompra;
        private Label label8;
        private TextBox txtMarca;
        private Label label7;
        private TextBox txtDescripcion;
        private Label label13;
        private TextBox txtProducto;
        private Label label12;
        private TextBox txtStockActual;
        private Label label11;
        private TextBox txtCodigoBarras;
        private ComboBox cmbCategoria;
        private Label label15;
        private Label label14;
        private TextBox txtStockMinimo;
        private Button btnEliminar;
        private Button btnGuardar;
        private Button btnNuevoProductos;
        private Button btnLimpiar;
        private TextBox txtBuscar;
        private Panel panel1;
        private Label label3;
        private PictureBox pictureBox1;
        private PictureBox pictureBox14;
        private Button btnProductosInactivos;
    }
}
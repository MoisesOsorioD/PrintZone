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
            panelEntradasHoy = new Panel();
            lblEntradasHoy = new Label();
            lblDescripcionEntradas = new Label();
            pictureBox14 = new PictureBox();
            lblTituloTarjeta3 = new Label();
            panelMovimientosRecientes = new Panel();
            dgvMovimientos = new DataGridView();
            colFecha = new DataGridViewTextBoxColumn();
            colMovimiento = new DataGridViewTextBoxColumn();
            colProducto = new DataGridViewTextBoxColumn();
            colCantidad = new DataGridViewTextBoxColumn();
            btnVerTodos = new Button();
            label14 = new Label();
            pictureBox15 = new PictureBox();
            panelProductoStockMinimo = new Panel();
            lblProductosStockMinimo = new Label();
            lblDescripcionStock = new Label();
            pictureBox11 = new PictureBox();
            lblTituloTarjeta2 = new Label();
            panelTotalProductos = new Panel();
            lblTotalProductos = new Label();
            lblDescripcionProductos = new Label();
            lblTituloTarjeta1 = new Label();
            pictureBox10 = new PictureBox();
            lblDescripcion = new Label();
            lblBienvenida = new Label();
            panelEntradasHoy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox14).BeginInit();
            panelMovimientosRecientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMovimientos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox15).BeginInit();
            panelProductoStockMinimo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
            panelTotalProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            SuspendLayout();
            // 
            // panelEntradasHoy
            // 
            panelEntradasHoy.BackColor = Color.FromArgb(242, 249, 254);
            panelEntradasHoy.Controls.Add(lblEntradasHoy);
            panelEntradasHoy.Controls.Add(lblDescripcionEntradas);
            panelEntradasHoy.Controls.Add(pictureBox14);
            panelEntradasHoy.Controls.Add(lblTituloTarjeta3);
            panelEntradasHoy.Location = new Point(1202, 138);
            panelEntradasHoy.Name = "panelEntradasHoy";
            panelEntradasHoy.Size = new Size(424, 164);
            panelEntradasHoy.TabIndex = 17;
            // 
            // lblEntradasHoy
            // 
            lblEntradasHoy.AutoSize = true;
            lblEntradasHoy.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEntradasHoy.Location = new Point(98, 63);
            lblEntradasHoy.Name = "lblEntradasHoy";
            lblEntradasHoy.Size = new Size(49, 38);
            lblEntradasHoy.TabIndex = 8;
            lblEntradasHoy.Text = "20";
            // 
            // lblDescripcionEntradas
            // 
            lblDescripcionEntradas.AutoSize = true;
            lblDescripcionEntradas.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDescripcionEntradas.Location = new Point(98, 101);
            lblDescripcionEntradas.Name = "lblDescripcionEntradas";
            lblDescripcionEntradas.Size = new Size(174, 23);
            lblDescripcionEntradas.TabIndex = 7;
            lblDescripcionEntradas.Text = "Registros de entradas";
            // 
            // pictureBox14
            // 
            pictureBox14.Image = Properties.Resources.Entradas_hoy;
            pictureBox14.Location = new Point(2, 30);
            pictureBox14.Name = "pictureBox14";
            pictureBox14.Size = new Size(90, 94);
            pictureBox14.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox14.TabIndex = 6;
            pictureBox14.TabStop = false;
            // 
            // lblTituloTarjeta3
            // 
            lblTituloTarjeta3.AutoSize = true;
            lblTituloTarjeta3.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblTituloTarjeta3.Location = new Point(98, 32);
            lblTituloTarjeta3.Name = "lblTituloTarjeta3";
            lblTituloTarjeta3.Size = new Size(195, 25);
            lblTituloTarjeta3.TabIndex = 0;
            lblTituloTarjeta3.Text = "Total de entradas hoy";
            // 
            // panelMovimientosRecientes
            // 
            panelMovimientosRecientes.BackColor = Color.FromArgb(242, 249, 254);
            panelMovimientosRecientes.Controls.Add(dgvMovimientos);
            panelMovimientosRecientes.Controls.Add(btnVerTodos);
            panelMovimientosRecientes.Controls.Add(label14);
            panelMovimientosRecientes.Controls.Add(pictureBox15);
            panelMovimientosRecientes.Location = new Point(272, 351);
            panelMovimientosRecientes.Name = "panelMovimientosRecientes";
            panelMovimientosRecientes.Size = new Size(1354, 493);
            panelMovimientosRecientes.TabIndex = 18;
            // 
            // dgvMovimientos
            // 
            dgvMovimientos.BackgroundColor = Color.FromArgb(220, 233, 247);
            dgvMovimientos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMovimientos.Columns.AddRange(new DataGridViewColumn[] { colFecha, colMovimiento, colProducto, colCantidad });
            dgvMovimientos.Location = new Point(17, 95);
            dgvMovimientos.Name = "dgvMovimientos";
            dgvMovimientos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dgvMovimientos.RowHeadersWidth = 51;
            dgvMovimientos.Size = new Size(1321, 383);
            dgvMovimientos.TabIndex = 11;
            // 
            // colFecha
            // 
            colFecha.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colFecha.HeaderText = "Fecha";
            colFecha.MinimumWidth = 6;
            colFecha.Name = "colFecha";
            // 
            // colMovimiento
            // 
            colMovimiento.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colMovimiento.HeaderText = "Movimiento";
            colMovimiento.MinimumWidth = 6;
            colMovimiento.Name = "colMovimiento";
            // 
            // colProducto
            // 
            colProducto.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colProducto.HeaderText = "Producto";
            colProducto.MinimumWidth = 6;
            colProducto.Name = "colProducto";
            // 
            // colCantidad
            // 
            colCantidad.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colCantidad.HeaderText = "Cantidad";
            colCantidad.MinimumWidth = 6;
            colCantidad.Name = "colCantidad";
            // 
            // btnVerTodos
            // 
            btnVerTodos.Cursor = Cursors.Hand;
            btnVerTodos.FlatAppearance.BorderSize = 0;
            btnVerTodos.FlatStyle = FlatStyle.Flat;
            btnVerTodos.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVerTodos.Image = (Image)resources.GetObject("btnVerTodos.Image");
            btnVerTodos.ImageAlign = ContentAlignment.MiddleRight;
            btnVerTodos.Location = new Point(1195, 31);
            btnVerTodos.Name = "btnVerTodos";
            btnVerTodos.Size = new Size(143, 35);
            btnVerTodos.TabIndex = 10;
            btnVerTodos.Text = "Ver todos";
            btnVerTodos.UseVisualStyleBackColor = true;
            btnVerTodos.Click += btnVerTodos_Click;
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
            pictureBox15.Image = Properties.Resources.Movimiento_recientes;
            pictureBox15.Location = new Point(6, 3);
            pictureBox15.Name = "pictureBox15";
            pictureBox15.Size = new Size(87, 86);
            pictureBox15.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox15.TabIndex = 10;
            pictureBox15.TabStop = false;
            // 
            // panelProductoStockMinimo
            // 
            panelProductoStockMinimo.BackColor = Color.FromArgb(242, 249, 254);
            panelProductoStockMinimo.Controls.Add(lblProductosStockMinimo);
            panelProductoStockMinimo.Controls.Add(lblDescripcionStock);
            panelProductoStockMinimo.Controls.Add(pictureBox11);
            panelProductoStockMinimo.Controls.Add(lblTituloTarjeta2);
            panelProductoStockMinimo.Location = new Point(738, 138);
            panelProductoStockMinimo.Name = "panelProductoStockMinimo";
            panelProductoStockMinimo.Size = new Size(424, 164);
            panelProductoStockMinimo.TabIndex = 14;
            // 
            // lblProductosStockMinimo
            // 
            lblProductosStockMinimo.AutoSize = true;
            lblProductosStockMinimo.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProductosStockMinimo.Location = new Point(99, 63);
            lblProductosStockMinimo.Name = "lblProductosStockMinimo";
            lblProductosStockMinimo.Size = new Size(33, 38);
            lblProductosStockMinimo.TabIndex = 8;
            lblProductosStockMinimo.Text = "8";
            // 
            // lblDescripcionStock
            // 
            lblDescripcionStock.AutoSize = true;
            lblDescripcionStock.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDescripcionStock.Location = new Point(99, 101);
            lblDescripcionStock.Name = "lblDescripcionStock";
            lblDescripcionStock.Size = new Size(148, 23);
            lblDescripcionStock.TabIndex = 7;
            lblDescripcionStock.Text = "Requiere atención";
            // 
            // pictureBox11
            // 
            pictureBox11.Image = Properties.Resources.Alerta_stock_minino;
            pictureBox11.Location = new Point(3, 30);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(90, 94);
            pictureBox11.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox11.TabIndex = 6;
            pictureBox11.TabStop = false;
            // 
            // lblTituloTarjeta2
            // 
            lblTituloTarjeta2.AutoSize = true;
            lblTituloTarjeta2.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblTituloTarjeta2.Location = new Point(99, 32);
            lblTituloTarjeta2.Name = "lblTituloTarjeta2";
            lblTituloTarjeta2.Size = new Size(255, 25);
            lblTituloTarjeta2.TabIndex = 0;
            lblTituloTarjeta2.Text = "Productos con stock mínimo";
            // 
            // panelTotalProductos
            // 
            panelTotalProductos.BackColor = Color.FromArgb(242, 249, 254);
            panelTotalProductos.Controls.Add(lblTotalProductos);
            panelTotalProductos.Controls.Add(lblDescripcionProductos);
            panelTotalProductos.Controls.Add(lblTituloTarjeta1);
            panelTotalProductos.Controls.Add(pictureBox10);
            panelTotalProductos.Location = new Point(272, 138);
            panelTotalProductos.Name = "panelTotalProductos";
            panelTotalProductos.Size = new Size(424, 164);
            panelTotalProductos.TabIndex = 13;
            // 
            // lblTotalProductos
            // 
            lblTotalProductos.AutoSize = true;
            lblTotalProductos.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalProductos.Location = new Point(99, 58);
            lblTotalProductos.Name = "lblTotalProductos";
            lblTotalProductos.Size = new Size(65, 38);
            lblTotalProductos.TabIndex = 2;
            lblTotalProductos.Text = "100";
            // 
            // lblDescripcionProductos
            // 
            lblDescripcionProductos.AutoSize = true;
            lblDescripcionProductos.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDescripcionProductos.Location = new Point(99, 101);
            lblDescripcionProductos.Name = "lblDescripcionProductos";
            lblDescripcionProductos.Size = new Size(280, 23);
            lblDescripcionProductos.TabIndex = 1;
            lblDescripcionProductos.Text = "Productos registrado en el sistemas";
            // 
            // lblTituloTarjeta1
            // 
            lblTituloTarjeta1.AutoSize = true;
            lblTituloTarjeta1.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblTituloTarjeta1.Location = new Point(99, 32);
            lblTituloTarjeta1.Name = "lblTituloTarjeta1";
            lblTituloTarjeta1.Size = new Size(170, 25);
            lblTituloTarjeta1.TabIndex = 0;
            lblTituloTarjeta1.Text = "Total de productos";
            // 
            // pictureBox10
            // 
            pictureBox10.Image = Properties.Resources.Total_de_productos;
            pictureBox10.Location = new Point(3, 32);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(90, 94);
            pictureBox10.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox10.TabIndex = 5;
            pictureBox10.TabStop = false;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDescripcion.Location = new Point(290, 84);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(406, 23);
            lblDescripcion.TabIndex = 12;
            lblDescripcion.Text = "Aquí tienes un resumen del estado de tu inventario.";
            // 
            // lblBienvenida
            // 
            lblBienvenida.AutoSize = true;
            lblBienvenida.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBienvenida.Location = new Point(259, 28);
            lblBienvenida.Name = "lblBienvenida";
            lblBienvenida.Size = new Size(473, 46);
            lblBienvenida.TabIndex = 11;
            lblBienvenida.Text = "¡Bienvenido, Administrador!";
            // 
            // frmPanelPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(220, 233, 247);
            ClientSize = new Size(1902, 983);
            Controls.Add(panelEntradasHoy);
            Controls.Add(panelMovimientosRecientes);
            Controls.Add(panelProductoStockMinimo);
            Controls.Add(panelTotalProductos);
            Controls.Add(lblDescripcion);
            Controls.Add(lblBienvenida);
            Name = "frmPanelPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Librería PrintZone - Sistema de Inventario";
            panelEntradasHoy.ResumeLayout(false);
            panelEntradasHoy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox14).EndInit();
            panelMovimientosRecientes.ResumeLayout(false);
            panelMovimientosRecientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMovimientos).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox15).EndInit();
            panelProductoStockMinimo.ResumeLayout(false);
            panelProductoStockMinimo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).EndInit();
            panelTotalProductos.ResumeLayout(false);
            panelTotalProductos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panelEntradasHoy;
        private Label lblEntradasHoy;
        private Label lblDescripcionEntradas;
        private PictureBox pictureBox14;
        private Label lblTituloTarjeta3;
        private Panel panelMovimientosRecientes;
        private Button btnVerTodos;
        private Label label14;
        private PictureBox pictureBox15;
        private Panel panelProductoStockMinimo;
        private Label lblProductosStockMinimo;
        private Label lblDescripcionStock;
        private PictureBox pictureBox11;
        private Label lblTituloTarjeta2;
        private Panel panelTotalProductos;
        private PictureBox pictureBox10;
        private Label lblTotalProductos;
        private Label lblDescripcionProductos;
        private Label lblTituloTarjeta1;
        private Label lblDescripcion;
        private Label lblBienvenida;
        private DataGridView dgvMovimientos;
        private DataGridViewTextBoxColumn colFecha;
        private DataGridViewTextBoxColumn colMovimiento;
        private DataGridViewTextBoxColumn colProducto;
        private DataGridViewTextBoxColumn colCantidad;
    }
}
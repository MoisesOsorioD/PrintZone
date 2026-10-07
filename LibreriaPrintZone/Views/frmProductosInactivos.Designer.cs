namespace LibreriaPrintZone.Views
{
    partial class frmProductosInactivos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductosInactivos));
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            label2 = new Label();
            label1 = new Label();
            pictureBox10 = new PictureBox();
            panel5 = new Panel();
            btnReactivar = new Button();
            dgvProductosInactivos = new DataGridView();
            colProductoP = new DataGridViewTextBoxColumn();
            colDescripcionP = new DataGridViewTextBoxColumn();
            colMarcaP = new DataGridViewTextBoxColumn();
            colPrecioCompraP = new DataGridViewTextBoxColumn();
            colPrecioVentaP = new DataGridViewTextBoxColumn();
            colCodigoBarrasP = new DataGridViewTextBoxColumn();
            colStockActualP = new DataGridViewTextBoxColumn();
            colStockMinimoP = new DataGridViewTextBoxColumn();
            colCategoriaP = new DataGridViewTextBoxColumn();
            colFecha = new DataGridViewTextBoxColumn();
            pictureBox14 = new PictureBox();
            txtBuscar = new TextBox();
            panelPaginacion = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductosInactivos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox14).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(242, 77);
            label2.Name = "label2";
            label2.Size = new Size(642, 23);
            label2.TabIndex = 10;
            label2.Text = "Consulta y administra los productos que se encuentran desactivados en el sistema.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(211, 21);
            label1.Name = "label1";
            label1.Size = new Size(335, 46);
            label1.TabIndex = 9;
            label1.Text = "Productos Inactivos";
            // 
            // pictureBox10
            // 
            pictureBox10.Image = Properties.Resources.Total_de_productos;
            pictureBox10.Location = new Point(122, 12);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(100, 100);
            pictureBox10.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox10.TabIndex = 11;
            pictureBox10.TabStop = false;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(242, 249, 254);
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(panelPaginacion);
            panel5.Controls.Add(btnReactivar);
            panel5.Controls.Add(dgvProductosInactivos);
            panel5.Controls.Add(pictureBox14);
            panel5.Controls.Add(txtBuscar);
            panel5.Location = new Point(122, 134);
            panel5.Name = "panel5";
            panel5.Size = new Size(1498, 524);
            panel5.TabIndex = 13;
            // 
            // btnReactivar
            // 
            btnReactivar.BackColor = Color.FromArgb(2, 113, 249);
            btnReactivar.FlatAppearance.BorderSize = 0;
            btnReactivar.FlatStyle = FlatStyle.Flat;
            btnReactivar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReactivar.ForeColor = Color.White;
            btnReactivar.Image = (Image)resources.GetObject("btnReactivar.Image");
            btnReactivar.ImageAlign = ContentAlignment.MiddleLeft;
            btnReactivar.Location = new Point(1075, 14);
            btnReactivar.Name = "btnReactivar";
            btnReactivar.Size = new Size(121, 37);
            btnReactivar.TabIndex = 64;
            btnReactivar.Text = "Reactivar";
            btnReactivar.TextAlign = ContentAlignment.MiddleRight;
            btnReactivar.UseVisualStyleBackColor = false;
            btnReactivar.Click += btnReactivar_Click;
            // 
            // dgvProductosInactivos
            // 
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgvProductosInactivos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvProductosInactivos.BackgroundColor = Color.FromArgb(220, 233, 247);
            dgvProductosInactivos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductosInactivos.Columns.AddRange(new DataGridViewColumn[] { colProductoP, colDescripcionP, colMarcaP, colPrecioCompraP, colPrecioVentaP, colCodigoBarrasP, colStockActualP, colStockMinimoP, colCategoriaP, colFecha });
            dgvProductosInactivos.Location = new Point(7, 84);
            dgvProductosInactivos.Name = "dgvProductosInactivos";
            dgvProductosInactivos.RowHeadersWidth = 51;
            dgvProductosInactivos.Size = new Size(1481, 320);
            dgvProductosInactivos.TabIndex = 63;
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
            // colFecha
            // 
            colFecha.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colFecha.HeaderText = "Fecha de Desactivación";
            colFecha.MinimumWidth = 6;
            colFecha.Name = "colFecha";
            // 
            // pictureBox14
            // 
            pictureBox14.Image = (Image)resources.GetObject("pictureBox14.Image");
            pictureBox14.Location = new Point(77, 18);
            pictureBox14.Name = "pictureBox14";
            pictureBox14.Size = new Size(40, 40);
            pictureBox14.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox14.TabIndex = 62;
            pictureBox14.TabStop = false;
            // 
            // txtBuscar
            // 
            txtBuscar.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscar.Location = new Point(123, 18);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = " Buscar productos por nombre o código de barra";
            txtBuscar.Size = new Size(887, 30);
            txtBuscar.TabIndex = 61;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // panelPaginacion
            // 
            panelPaginacion.BackColor = Color.FromArgb(220, 233, 247);
            panelPaginacion.BorderStyle = BorderStyle.FixedSingle;
            panelPaginacion.Location = new Point(7, 433);
            panelPaginacion.Name = "panelPaginacion";
            panelPaginacion.Size = new Size(1481, 59);
            panelPaginacion.TabIndex = 65;
            // 
            // frmProductosInactivos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(220, 233, 247);
            ClientSize = new Size(1632, 915);
            Controls.Add(panel5);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox10);
            Name = "frmProductosInactivos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Librería PrintZone - Productos Inactivos";
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductosInactivos).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox14).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private PictureBox pictureBox10;
        private Panel panel5;
        private PictureBox pictureBox14;
        private TextBox txtBuscar;
        private DataGridView dgvProductosInactivos;
        private Button btnReactivar;
        private DataGridViewTextBoxColumn colProductoP;
        private DataGridViewTextBoxColumn colDescripcionP;
        private DataGridViewTextBoxColumn colMarcaP;
        private DataGridViewTextBoxColumn colPrecioCompraP;
        private DataGridViewTextBoxColumn colPrecioVentaP;
        private DataGridViewTextBoxColumn colCodigoBarrasP;
        private DataGridViewTextBoxColumn colStockActualP;
        private DataGridViewTextBoxColumn colStockMinimoP;
        private DataGridViewTextBoxColumn colCategoriaP;
        private DataGridViewTextBoxColumn colFecha;
        private Panel panelPaginacion;
    }
}
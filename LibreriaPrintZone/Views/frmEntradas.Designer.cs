namespace LibreriaPrintZone.Views
{
    partial class frmEntradas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEntradas));
            label2 = new Label();
            label1 = new Label();
            pictureBox10 = new PictureBox();
            panelInversion = new Panel();
            label10 = new Label();
            pictureBox13 = new PictureBox();
            lblInversionInventario = new Label();
            label8 = new Label();
            panelUnidadesIngresadas = new Panel();
            label9 = new Label();
            pictureBox12 = new PictureBox();
            lblUnidadesIngresadas = new Label();
            label6 = new Label();
            panelEntradasRegistradas = new Panel();
            label11 = new Label();
            pictureBox11 = new PictureBox();
            lblTotalEntradas = new Label();
            label3 = new Label();
            panelRegistrarEntrada = new Panel();
            btnLimpiar = new Button();
            txtCostoLote = new TextBox();
            btnRegistrarEntrada = new Button();
            label13 = new Label();
            label14 = new Label();
            txtCantidad = new TextBox();
            cmbProducto = new ComboBox();
            label12 = new Label();
            cmbProveedor = new ComboBox();
            label15 = new Label();
            pictureBox2 = new PictureBox();
            label16 = new Label();
            pictureBox14 = new PictureBox();
            txtBuscar = new TextBox();
            panelEntradas = new Panel();
            panelPaginacion = new Panel();
            dgvEntradas = new DataGridView();
            colFecha = new DataGridViewTextBoxColumn();
            colProducto = new DataGridViewTextBoxColumn();
            colProveedor = new DataGridViewTextBoxColumn();
            colCantidad = new DataGridViewTextBoxColumn();
            colCostoLote = new DataGridViewTextBoxColumn();
            label17 = new Label();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            panelInversion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).BeginInit();
            panelUnidadesIngresadas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).BeginInit();
            panelEntradasRegistradas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
            panelRegistrarEntrada.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox14).BeginInit();
            panelEntradas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEntradas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(343, 116);
            label2.Name = "label2";
            label2.Size = new Size(657, 23);
            label2.TabIndex = 10;
            label2.Text = "Registra los productos que ingresan al inventario y mantiene el historial de entradas.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(312, 60);
            label1.Name = "label1";
            label1.Size = new Size(158, 46);
            label1.TabIndex = 9;
            label1.Text = "Entradas";
            // 
            // pictureBox10
            // 
            pictureBox10.Image = Properties.Resources.Entrada_2;
            pictureBox10.Location = new Point(223, 51);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(100, 100);
            pictureBox10.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox10.TabIndex = 11;
            pictureBox10.TabStop = false;
            // 
            // panelInversion
            // 
            panelInversion.BackColor = Color.FromArgb(242, 249, 254);
            panelInversion.Controls.Add(label10);
            panelInversion.Controls.Add(pictureBox13);
            panelInversion.Controls.Add(lblInversionInventario);
            panelInversion.Controls.Add(label8);
            panelInversion.Location = new Point(1230, 157);
            panelInversion.Name = "panelInversion";
            panelInversion.Size = new Size(441, 116);
            panelInversion.TabIndex = 18;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(99, 83);
            label10.Name = "label10";
            label10.Size = new Size(274, 23);
            label10.TabIndex = 10;
            label10.Text = "Costo total de los lotes registrados";
            // 
            // pictureBox13
            // 
            pictureBox13.Image = Properties.Resources.Informacion_comercial;
            pictureBox13.Location = new Point(3, 12);
            pictureBox13.Name = "pictureBox13";
            pictureBox13.Size = new Size(90, 94);
            pictureBox13.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox13.TabIndex = 5;
            pictureBox13.TabStop = false;
            // 
            // lblInversionInventario
            // 
            lblInversionInventario.AutoSize = true;
            lblInversionInventario.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInversionInventario.Location = new Point(99, 38);
            lblInversionInventario.Name = "lblInversionInventario";
            lblInversionInventario.Size = new Size(146, 38);
            lblInversionInventario.TabIndex = 2;
            lblInversionInventario.Text = "C$ 67,500";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label8.Location = new Point(99, 12);
            label8.Name = "label8";
            label8.Size = new Size(209, 25);
            label8.TabIndex = 0;
            label8.Text = "Inversión en inventario";
            // 
            // panelUnidadesIngresadas
            // 
            panelUnidadesIngresadas.BackColor = Color.FromArgb(242, 249, 254);
            panelUnidadesIngresadas.Controls.Add(label9);
            panelUnidadesIngresadas.Controls.Add(pictureBox12);
            panelUnidadesIngresadas.Controls.Add(lblUnidadesIngresadas);
            panelUnidadesIngresadas.Controls.Add(label6);
            panelUnidadesIngresadas.Location = new Point(739, 157);
            panelUnidadesIngresadas.Name = "panelUnidadesIngresadas";
            panelUnidadesIngresadas.Size = new Size(445, 116);
            panelUnidadesIngresadas.TabIndex = 17;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(99, 83);
            label9.Name = "label9";
            label9.Size = new Size(311, 23);
            label9.TabIndex = 9;
            label9.Text = "Total de unidades en todas las entradas";
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
            // lblUnidadesIngresadas
            // 
            lblUnidadesIngresadas.AutoSize = true;
            lblUnidadesIngresadas.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUnidadesIngresadas.Location = new Point(99, 38);
            lblUnidadesIngresadas.Name = "lblUnidadesIngresadas";
            lblUnidadesIngresadas.Size = new Size(89, 38);
            lblUnidadesIngresadas.TabIndex = 2;
            lblUnidadesIngresadas.Text = "3,500";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label6.Location = new Point(99, 12);
            label6.Name = "label6";
            label6.Size = new Size(187, 25);
            label6.TabIndex = 0;
            label6.Text = "Unidades ingresadas";
            // 
            // panelEntradasRegistradas
            // 
            panelEntradasRegistradas.BackColor = Color.FromArgb(242, 249, 254);
            panelEntradasRegistradas.Controls.Add(label11);
            panelEntradasRegistradas.Controls.Add(pictureBox11);
            panelEntradasRegistradas.Controls.Add(lblTotalEntradas);
            panelEntradasRegistradas.Controls.Add(label3);
            panelEntradasRegistradas.Location = new Point(231, 157);
            panelEntradasRegistradas.Name = "panelEntradasRegistradas";
            panelEntradasRegistradas.Size = new Size(445, 116);
            panelEntradasRegistradas.TabIndex = 16;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(99, 83);
            label11.Name = "label11";
            label11.Size = new Size(261, 23);
            label11.TabIndex = 10;
            label11.Text = "Total de movimiento de entradas";
            // 
            // pictureBox11
            // 
            pictureBox11.Image = Properties.Resources.Entrada_2;
            pictureBox11.Location = new Point(3, 12);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(90, 94);
            pictureBox11.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox11.TabIndex = 5;
            pictureBox11.TabStop = false;
            // 
            // lblTotalEntradas
            // 
            lblTotalEntradas.AutoSize = true;
            lblTotalEntradas.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalEntradas.Location = new Point(99, 38);
            lblTotalEntradas.Name = "lblTotalEntradas";
            lblTotalEntradas.Size = new Size(49, 38);
            lblTotalEntradas.TabIndex = 2;
            lblTotalEntradas.Text = "10";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label3.Location = new Point(99, 12);
            label3.Name = "label3";
            label3.Size = new Size(185, 25);
            label3.TabIndex = 0;
            label3.Text = "Entradas registradas";
            // 
            // panelRegistrarEntrada
            // 
            panelRegistrarEntrada.BackColor = Color.FromArgb(247, 251, 255);
            panelRegistrarEntrada.Controls.Add(btnLimpiar);
            panelRegistrarEntrada.Controls.Add(txtCostoLote);
            panelRegistrarEntrada.Controls.Add(btnRegistrarEntrada);
            panelRegistrarEntrada.Controls.Add(label13);
            panelRegistrarEntrada.Controls.Add(label14);
            panelRegistrarEntrada.Controls.Add(txtCantidad);
            panelRegistrarEntrada.Controls.Add(cmbProducto);
            panelRegistrarEntrada.Controls.Add(label12);
            panelRegistrarEntrada.Controls.Add(cmbProveedor);
            panelRegistrarEntrada.Controls.Add(label15);
            panelRegistrarEntrada.Controls.Add(pictureBox2);
            panelRegistrarEntrada.Controls.Add(label16);
            panelRegistrarEntrada.Location = new Point(231, 298);
            panelRegistrarEntrada.Name = "panelRegistrarEntrada";
            panelRegistrarEntrada.Size = new Size(475, 578);
            panelRegistrarEntrada.TabIndex = 19;
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
            btnLimpiar.Location = new Point(255, 400);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(195, 37);
            btnLimpiar.TabIndex = 56;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // txtCostoLote
            // 
            txtCostoLote.Location = new Point(19, 334);
            txtCostoLote.Name = "txtCostoLote";
            txtCostoLote.PlaceholderText = " Ej. C$ 23,000";
            txtCostoLote.Size = new Size(425, 27);
            txtCostoLote.TabIndex = 54;
            // 
            // btnRegistrarEntrada
            // 
            btnRegistrarEntrada.BackColor = Color.FromArgb(2, 113, 249);
            btnRegistrarEntrada.FlatAppearance.BorderSize = 0;
            btnRegistrarEntrada.FlatStyle = FlatStyle.Flat;
            btnRegistrarEntrada.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrarEntrada.ForeColor = Color.White;
            btnRegistrarEntrada.Image = (Image)resources.GetObject("btnRegistrarEntrada.Image");
            btnRegistrarEntrada.ImageAlign = ContentAlignment.MiddleLeft;
            btnRegistrarEntrada.Location = new Point(19, 400);
            btnRegistrarEntrada.Name = "btnRegistrarEntrada";
            btnRegistrarEntrada.Size = new Size(195, 37);
            btnRegistrarEntrada.TabIndex = 57;
            btnRegistrarEntrada.Text = "Registrar entrada";
            btnRegistrarEntrada.TextAlign = ContentAlignment.MiddleRight;
            btnRegistrarEntrada.UseVisualStyleBackColor = false;
            btnRegistrarEntrada.Click += btnRegistrarEntrada_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(19, 311);
            label13.Name = "label13";
            label13.Size = new Size(102, 20);
            label13.TabIndex = 55;
            label13.Text = "Costo del lote";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(19, 229);
            label14.Name = "label14";
            label14.Size = new Size(70, 20);
            label14.TabIndex = 52;
            label14.Text = "Cantidad";
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(19, 252);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.PlaceholderText = " Ej. 50";
            txtCantidad.Size = new Size(425, 27);
            txtCantidad.TabIndex = 51;
            // 
            // cmbProducto
            // 
            cmbProducto.FormattingEnabled = true;
            cmbProducto.Location = new Point(19, 171);
            cmbProducto.Name = "cmbProducto";
            cmbProducto.Size = new Size(425, 28);
            cmbProducto.TabIndex = 20;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(19, 150);
            label12.Name = "label12";
            label12.Size = new Size(72, 20);
            label12.TabIndex = 19;
            label12.Text = "Producto";
            // 
            // cmbProveedor
            // 
            cmbProveedor.FormattingEnabled = true;
            cmbProveedor.Location = new Point(19, 93);
            cmbProveedor.Name = "cmbProveedor";
            cmbProveedor.Size = new Size(425, 28);
            cmbProveedor.TabIndex = 17;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(19, 70);
            label15.Name = "label15";
            label15.Size = new Size(81, 20);
            label15.TabIndex = 16;
            label15.Text = "Proveedor";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(19, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(50, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label16.Location = new Point(65, 15);
            label16.Name = "label16";
            label16.Size = new Size(159, 25);
            label16.TabIndex = 6;
            label16.Text = "Registrar entrada";
            // 
            // pictureBox14
            // 
            pictureBox14.Image = (Image)resources.GetObject("pictureBox14.Image");
            pictureBox14.Location = new Point(20, 69);
            pictureBox14.Name = "pictureBox14";
            pictureBox14.Size = new Size(40, 40);
            pictureBox14.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox14.TabIndex = 59;
            pictureBox14.TabStop = false;
            pictureBox14.Click += pictureBox14_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscar.Location = new Point(66, 76);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = " Buscar entradas...";
            txtBuscar.Size = new Size(850, 30);
            txtBuscar.TabIndex = 58;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // panelEntradas
            // 
            panelEntradas.BackColor = Color.FromArgb(242, 249, 254);
            panelEntradas.Controls.Add(pictureBox14);
            panelEntradas.Controls.Add(txtBuscar);
            panelEntradas.Controls.Add(panelPaginacion);
            panelEntradas.Controls.Add(dgvEntradas);
            panelEntradas.Controls.Add(label17);
            panelEntradas.Controls.Add(pictureBox3);
            panelEntradas.Location = new Point(739, 298);
            panelEntradas.Name = "panelEntradas";
            panelEntradas.Size = new Size(935, 578);
            panelEntradas.TabIndex = 57;
            // 
            // panelPaginacion
            // 
            panelPaginacion.BackColor = Color.FromArgb(220, 233, 247);
            panelPaginacion.Location = new Point(20, 506);
            panelPaginacion.Name = "panelPaginacion";
            panelPaginacion.Size = new Size(896, 59);
            panelPaginacion.TabIndex = 9;
            // 
            // dgvEntradas
            // 
            dgvEntradas.BackgroundColor = Color.FromArgb(220, 233, 247);
            dgvEntradas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEntradas.Columns.AddRange(new DataGridViewColumn[] { colFecha, colProducto, colProveedor, colCantidad, colCostoLote });
            dgvEntradas.Location = new Point(20, 115);
            dgvEntradas.Name = "dgvEntradas";
            dgvEntradas.RowHeadersWidth = 51;
            dgvEntradas.Size = new Size(896, 375);
            dgvEntradas.TabIndex = 8;
            // 
            // colFecha
            // 
            colFecha.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colFecha.HeaderText = "Fecha";
            colFecha.MinimumWidth = 6;
            colFecha.Name = "colFecha";
            // 
            // colProducto
            // 
            colProducto.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colProducto.HeaderText = "Producto";
            colProducto.MinimumWidth = 6;
            colProducto.Name = "colProducto";
            // 
            // colProveedor
            // 
            colProveedor.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colProveedor.HeaderText = "Proveedor";
            colProveedor.MinimumWidth = 6;
            colProveedor.Name = "colProveedor";
            // 
            // colCantidad
            // 
            colCantidad.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colCantidad.HeaderText = "Cantidad";
            colCantidad.MinimumWidth = 6;
            colCantidad.Name = "colCantidad";
            // 
            // colCostoLote
            // 
            colCostoLote.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colCostoLote.HeaderText = "Costo del lote";
            colCostoLote.MinimumWidth = 6;
            colCostoLote.Name = "colCostoLote";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label17.Location = new Point(83, 22);
            label17.Name = "label17";
            label17.Size = new Size(211, 25);
            label17.TabIndex = 6;
            label17.Text = "Entradas registradas";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Categoria_Menos;
            pictureBox3.Location = new Point(20, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(60, 60);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // frmEntradas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(220, 233, 247);
            ClientSize = new Size(1902, 983);
            Controls.Add(panelEntradas);
            Controls.Add(panelRegistrarEntrada);
            Controls.Add(panelInversion);
            Controls.Add(panelUnidadesIngresadas);
            Controls.Add(panelEntradasRegistradas);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox10);
            Name = "frmEntradas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Librería PrintZone - Gestión de entradas";
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            panelInversion.ResumeLayout(false);
            panelInversion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).EndInit();
            panelUnidadesIngresadas.ResumeLayout(false);
            panelUnidadesIngresadas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).EndInit();
            panelEntradasRegistradas.ResumeLayout(false);
            panelEntradasRegistradas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).EndInit();
            panelRegistrarEntrada.ResumeLayout(false);
            panelRegistrarEntrada.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox14).EndInit();
            panelEntradas.ResumeLayout(false);
            panelEntradas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEntradas).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private PictureBox pictureBox10;
        private Panel panelInversion;
        private Label label10;
        private PictureBox pictureBox13;
        private Label lblInversionInventario;
        private Label label8;
        private Panel panelUnidadesIngresadas;
        private Label label9;
        private PictureBox pictureBox12;
        private Label lblUnidadesIngresadas;
        private Label label6;
        private Panel panelEntradasRegistradas;
        private PictureBox pictureBox11;
        private Label lblTotalEntradas;
        private Label label3;
        private Label label11;
        private Panel panelRegistrarEntrada;
        private Label label15;
        private PictureBox pictureBox2;
        private Label label16;
        private ComboBox cmbProveedor;
        private ComboBox cmbProducto;
        private Label label12;
        private TextBox txtCostoLote;
        private Label label13;
        private Label label14;
        private TextBox txtCantidad;
        private Button btnLimpiar;
        private Button btnRegistrarEntrada;
        private PictureBox pictureBox14;
        private TextBox txtBuscar;
        private Panel panelEntradas;
        private DataGridView dgvEntradas;
        private Label label17;
        private PictureBox pictureBox3;
        private DataGridViewTextBoxColumn colFecha;
        private DataGridViewTextBoxColumn colProducto;
        private DataGridViewTextBoxColumn colProveedor;
        private DataGridViewTextBoxColumn colCantidad;
        private DataGridViewTextBoxColumn colCostoLote;
        private Panel panelPaginacion;
    }
}
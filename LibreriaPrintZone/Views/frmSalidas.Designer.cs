namespace LibreriaPrintZone.Views
{
    partial class frmSalidas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSalidas));
            pictureBox14 = new PictureBox();
            txtBuscar = new TextBox();
            panel7 = new Panel();
            dgvSalidas = new DataGridView();
            colFecha = new DataGridViewTextBoxColumn();
            colProducto = new DataGridViewTextBoxColumn();
            colCantidad = new DataGridViewTextBoxColumn();
            colMotivo = new DataGridViewTextBoxColumn();
            colUsuario = new DataGridViewTextBoxColumn();
            label17 = new Label();
            pictureBox3 = new PictureBox();
            panel5 = new Panel();
            txtUsuario = new TextBox();
            label19 = new Label();
            panelStockDisponible = new Panel();
            lblCantidadStock = new Label();
            pictureBox4 = new PictureBox();
            lblStockDisponible = new Label();
            btnLimpiar = new Button();
            txtMotivo = new TextBox();
            btnRegistrarSalida = new Button();
            label13 = new Label();
            label14 = new Label();
            txtCantidad = new TextBox();
            cmbProducto = new ComboBox();
            label12 = new Label();
            pictureBox2 = new PictureBox();
            label16 = new Label();
            panel4 = new Panel();
            lblCantidadProductoMasSalidas = new Label();
            pictureBox13 = new PictureBox();
            lblProductoMasSalidas = new Label();
            label8 = new Label();
            panel3 = new Panel();
            label9 = new Label();
            pictureBox12 = new PictureBox();
            lblUnidadesRetiradas = new Label();
            label6 = new Label();
            panel2 = new Panel();
            label11 = new Label();
            pictureBox11 = new PictureBox();
            lblTotalS = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox10 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox14).BeginInit();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSalidas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel5.SuspendLayout();
            panelStockDisponible.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
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
            pictureBox14.Location = new Point(642, 246);
            pictureBox14.Name = "pictureBox14";
            pictureBox14.Size = new Size(40, 40);
            pictureBox14.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox14.TabIndex = 69;
            pictureBox14.TabStop = false;
            // 
            // txtBuscar
            // 
            txtBuscar.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscar.Location = new Point(688, 253);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = " Buscar salidas...";
            txtBuscar.Size = new Size(893, 30);
            txtBuscar.TabIndex = 68;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(242, 249, 254);
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel7.Controls.Add(dgvSalidas);
            panel7.Controls.Add(label17);
            panel7.Controls.Add(pictureBox3);
            panel7.Location = new Point(646, 292);
            panel7.Name = "panel7";
            panel7.Size = new Size(935, 539);
            panel7.TabIndex = 67;
            // 
            // dgvSalidas
            // 
            dgvSalidas.BackgroundColor = Color.FromArgb(220, 233, 247);
            dgvSalidas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSalidas.Columns.AddRange(new DataGridViewColumn[] { colFecha, colProducto, colCantidad, colMotivo, colUsuario });
            dgvSalidas.Location = new Point(20, 81);
            dgvSalidas.Name = "dgvSalidas";
            dgvSalidas.RowHeadersWidth = 51;
            dgvSalidas.Size = new Size(896, 405);
            dgvSalidas.TabIndex = 8;
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
            // colCantidad
            // 
            colCantidad.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colCantidad.HeaderText = "Cantidad";
            colCantidad.MinimumWidth = 6;
            colCantidad.Name = "colCantidad";
            // 
            // colMotivo
            // 
            colMotivo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colMotivo.HeaderText = "Motivo";
            colMotivo.MinimumWidth = 6;
            colMotivo.Name = "colMotivo";
            // 
            // colUsuario
            // 
            colUsuario.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colUsuario.HeaderText = "Usuario";
            colUsuario.MinimumWidth = 6;
            colUsuario.Name = "colUsuario";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label17.Location = new Point(83, 34);
            label17.Name = "label17";
            label17.Size = new Size(197, 25);
            label17.TabIndex = 6;
            label17.Text = "Salidas registradas";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Categoria_Menos;
            pictureBox3.Location = new Point(20, 15);
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
            panel5.Controls.Add(txtUsuario);
            panel5.Controls.Add(label19);
            panel5.Controls.Add(panelStockDisponible);
            panel5.Controls.Add(btnLimpiar);
            panel5.Controls.Add(txtMotivo);
            panel5.Controls.Add(btnRegistrarSalida);
            panel5.Controls.Add(label13);
            panel5.Controls.Add(label14);
            panel5.Controls.Add(txtCantidad);
            panel5.Controls.Add(cmbProducto);
            panel5.Controls.Add(label12);
            panel5.Controls.Add(pictureBox2);
            panel5.Controls.Add(label16);
            panel5.Location = new Point(126, 253);
            panel5.Name = "panel5";
            panel5.Size = new Size(475, 578);
            panel5.TabIndex = 66;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(18, 431);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = " ...";
            txtUsuario.Size = new Size(425, 27);
            txtUsuario.TabIndex = 74;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label19.Location = new Point(20, 408);
            label19.Name = "label19";
            label19.Size = new Size(62, 20);
            label19.TabIndex = 75;
            label19.Text = "Usuario";
            // 
            // panelStockDisponible
            // 
            panelStockDisponible.BackColor = Color.FromArgb(220, 233, 247);
            panelStockDisponible.BorderStyle = BorderStyle.FixedSingle;
            panelStockDisponible.Controls.Add(lblCantidadStock);
            panelStockDisponible.Controls.Add(pictureBox4);
            panelStockDisponible.Controls.Add(lblStockDisponible);
            panelStockDisponible.Location = new Point(19, 149);
            panelStockDisponible.Name = "panelStockDisponible";
            panelStockDisponible.Size = new Size(425, 69);
            panelStockDisponible.TabIndex = 72;
            // 
            // lblCantidadStock
            // 
            lblCantidadStock.AutoSize = true;
            lblCantidadStock.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCantidadStock.Location = new Point(68, 34);
            lblCantidadStock.Name = "lblCantidadStock";
            lblCantidadStock.Size = new Size(102, 23);
            lblCantidadStock.TabIndex = 11;
            lblCantidadStock.Text = "25 unidades";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(3, 2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(60, 60);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 1;
            pictureBox4.TabStop = false;
            // 
            // lblStockDisponible
            // 
            lblStockDisponible.AutoSize = true;
            lblStockDisponible.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStockDisponible.ForeColor = SystemColors.ControlText;
            lblStockDisponible.Location = new Point(68, 11);
            lblStockDisponible.Name = "lblStockDisponible";
            lblStockDisponible.Size = new Size(146, 23);
            lblStockDisponible.TabIndex = 0;
            lblStockDisponible.Text = "Stock Disponible";
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
            btnLimpiar.Location = new Point(254, 484);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(195, 37);
            btnLimpiar.TabIndex = 56;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // txtMotivo
            // 
            txtMotivo.Location = new Point(18, 351);
            txtMotivo.Name = "txtMotivo";
            txtMotivo.PlaceholderText = " Ej. Venta";
            txtMotivo.Size = new Size(425, 27);
            txtMotivo.TabIndex = 54;
            // 
            // btnRegistrarSalida
            // 
            btnRegistrarSalida.BackColor = Color.FromArgb(2, 113, 249);
            btnRegistrarSalida.FlatAppearance.BorderSize = 0;
            btnRegistrarSalida.FlatStyle = FlatStyle.Flat;
            btnRegistrarSalida.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrarSalida.ForeColor = Color.White;
            btnRegistrarSalida.Image = (Image)resources.GetObject("btnRegistrarSalida.Image");
            btnRegistrarSalida.ImageAlign = ContentAlignment.MiddleLeft;
            btnRegistrarSalida.Location = new Point(18, 484);
            btnRegistrarSalida.Name = "btnRegistrarSalida";
            btnRegistrarSalida.Size = new Size(195, 37);
            btnRegistrarSalida.TabIndex = 57;
            btnRegistrarSalida.Text = "Registrar salida";
            btnRegistrarSalida.TextAlign = ContentAlignment.MiddleRight;
            btnRegistrarSalida.UseVisualStyleBackColor = false;
            btnRegistrarSalida.Click += btnRegistrarSalida_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(20, 328);
            label13.Name = "label13";
            label13.Size = new Size(58, 20);
            label13.TabIndex = 55;
            label13.Text = "Motivo";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(19, 247);
            label14.Name = "label14";
            label14.Size = new Size(135, 20);
            label14.TabIndex = 52;
            label14.Text = "Cantidad a retrirar";
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(18, 270);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.PlaceholderText = " Ej. 50";
            txtCantidad.Size = new Size(425, 27);
            txtCantidad.TabIndex = 51;
            // 
            // cmbProducto
            // 
            cmbProducto.FormattingEnabled = true;
            cmbProducto.Location = new Point(19, 103);
            cmbProducto.Name = "cmbProducto";
            cmbProducto.Size = new Size(425, 28);
            cmbProducto.TabIndex = 20;
            cmbProducto.SelectedIndexChanged += cmbProducto_SelectedIndexChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(18, 80);
            label12.Name = "label12";
            label12.Size = new Size(72, 20);
            label12.TabIndex = 19;
            label12.Text = "Producto";
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
            label16.Size = new Size(142, 25);
            label16.TabIndex = 6;
            label16.Text = "Registrar salida";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(242, 249, 254);
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(lblCantidadProductoMasSalidas);
            panel4.Controls.Add(pictureBox13);
            panel4.Controls.Add(lblProductoMasSalidas);
            panel4.Controls.Add(label8);
            panel4.Location = new Point(1133, 112);
            panel4.Name = "panel4";
            panel4.Size = new Size(448, 116);
            panel4.TabIndex = 65;
            // 
            // lblCantidadProductoMasSalidas
            // 
            lblCantidadProductoMasSalidas.AutoSize = true;
            lblCantidadProductoMasSalidas.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCantidadProductoMasSalidas.Location = new Point(99, 83);
            lblCantidadProductoMasSalidas.Name = "lblCantidadProductoMasSalidas";
            lblCantidadProductoMasSalidas.Size = new Size(111, 23);
            lblCantidadProductoMasSalidas.TabIndex = 10;
            lblCantidadProductoMasSalidas.Text = "300 unidades";
            // 
            // pictureBox13
            // 
            pictureBox13.Image = Properties.Resources.CategoriaMas;
            pictureBox13.Location = new Point(3, 12);
            pictureBox13.Name = "pictureBox13";
            pictureBox13.Size = new Size(90, 94);
            pictureBox13.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox13.TabIndex = 5;
            pictureBox13.TabStop = false;
            // 
            // lblProductoMasSalidas
            // 
            lblProductoMasSalidas.AutoSize = true;
            lblProductoMasSalidas.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProductoMasSalidas.Location = new Point(99, 38);
            lblProductoMasSalidas.Name = "lblProductoMasSalidas";
            lblProductoMasSalidas.Size = new Size(258, 38);
            lblProductoMasSalidas.TabIndex = 2;
            lblProductoMasSalidas.Text = "Cuaderno infantils";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label8.Location = new Point(99, 12);
            label8.Name = "label8";
            label8.Size = new Size(228, 25);
            label8.TabIndex = 0;
            label8.Text = "Producto con más salidas";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(242, 249, 254);
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label9);
            panel3.Controls.Add(pictureBox12);
            panel3.Controls.Add(lblUnidadesRetiradas);
            panel3.Controls.Add(label6);
            panel3.Location = new Point(642, 112);
            panel3.Name = "panel3";
            panel3.Size = new Size(445, 116);
            panel3.TabIndex = 64;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(99, 83);
            label9.Name = "label9";
            label9.Size = new Size(295, 23);
            label9.TabIndex = 9;
            label9.Text = "Total de unidades en todas las salidas";
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
            // lblUnidadesRetiradas
            // 
            lblUnidadesRetiradas.AutoSize = true;
            lblUnidadesRetiradas.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUnidadesRetiradas.Location = new Point(99, 38);
            lblUnidadesRetiradas.Name = "lblUnidadesRetiradas";
            lblUnidadesRetiradas.Size = new Size(33, 38);
            lblUnidadesRetiradas.TabIndex = 2;
            lblUnidadesRetiradas.Text = "1";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label6.Location = new Point(99, 12);
            label6.Name = "label6";
            label6.Size = new Size(171, 25);
            label6.TabIndex = 0;
            label6.Text = "Unidades retiradas";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(242, 249, 254);
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label11);
            panel2.Controls.Add(pictureBox11);
            panel2.Controls.Add(lblTotalS);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(126, 112);
            panel2.Name = "panel2";
            panel2.Size = new Size(445, 116);
            panel2.TabIndex = 63;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(99, 83);
            label11.Name = "label11";
            label11.Size = new Size(245, 23);
            label11.TabIndex = 10;
            label11.Text = "Total de movimiento de salidas";
            // 
            // pictureBox11
            // 
            pictureBox11.Image = Properties.Resources.Salida_2;
            pictureBox11.Location = new Point(3, 12);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(90, 94);
            pictureBox11.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox11.TabIndex = 5;
            pictureBox11.TabStop = false;
            // 
            // lblTotalS
            // 
            lblTotalS.AutoSize = true;
            lblTotalS.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalS.Location = new Point(99, 38);
            lblTotalS.Name = "lblTotalS";
            lblTotalS.Size = new Size(33, 38);
            lblTotalS.TabIndex = 2;
            lblTotalS.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label3.Location = new Point(99, 12);
            label3.Name = "label3";
            label3.Size = new Size(170, 25);
            label3.TabIndex = 0;
            label3.Text = "Salidas registradas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(246, 71);
            label2.Name = "label2";
            label2.Size = new Size(625, 23);
            label2.TabIndex = 61;
            label2.Text = "Registra los productos que salen del inventario y mantiene el historial de salidas.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(215, 15);
            label1.Name = "label1";
            label1.Size = new Size(131, 46);
            label1.TabIndex = 60;
            label1.Text = "Salidas";
            // 
            // pictureBox10
            // 
            pictureBox10.Image = Properties.Resources.Salida_2;
            pictureBox10.Location = new Point(126, 6);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(100, 100);
            pictureBox10.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox10.TabIndex = 62;
            pictureBox10.TabStop = false;
            // 
            // frmSalidas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(220, 233, 247);
            ClientSize = new Size(1632, 915);
            Controls.Add(pictureBox14);
            Controls.Add(txtBuscar);
            Controls.Add(panel7);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox10);
            Name = "frmSalidas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Librería PrintZone - Gestión de salidas";
            ((System.ComponentModel.ISupportInitialize)pictureBox14).EndInit();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSalidas).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panelStockDisponible.ResumeLayout(false);
            panelStockDisponible.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
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
        private TextBox txtBuscar;
        private Panel panel7;
        private DataGridView dgvSalidas;
        private Label label17;
        private PictureBox pictureBox3;
        private Panel panel5;
        private Button btnLimpiar;
        private TextBox txtMotivo;
        private Button btnRegistrarSalida;
        private Label label13;
        private Label label14;
        private TextBox txtCantidad;
        private ComboBox cmbProducto;
        private Label label12;
        private PictureBox pictureBox2;
        private Label label16;
        private Panel panel4;
        private Label lblCantidadProductoMasSalidas;
        private PictureBox pictureBox13;
        private Label lblProductoMasSalidas;
        private Label label8;
        private Panel panel3;
        private Label label9;
        private PictureBox pictureBox12;
        private Label lblUnidadesRetiradas;
        private Label label6;
        private Panel panel2;
        private Label label11;
        private PictureBox pictureBox11;
        private Label lblTotalS;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox10;
        private Panel panelStockDisponible;
        private PictureBox pictureBox4;
        private Label lblStockDisponible;
        private Label lblCantidadStock;
        private TextBox txtUsuario;
        private Label label19;
        private DataGridViewTextBoxColumn colFecha;
        private DataGridViewTextBoxColumn colProducto;
        private DataGridViewTextBoxColumn colCantidad;
        private DataGridViewTextBoxColumn colMotivo;
        private DataGridViewTextBoxColumn colUsuario;
    }
}
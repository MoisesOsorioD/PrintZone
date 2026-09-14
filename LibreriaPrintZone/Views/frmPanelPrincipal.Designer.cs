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
            button11 = new Button();
            dataGridView3 = new DataGridView();
            colProductM = new DataGridViewTextBoxColumn();
            colCategoriaM = new DataGridViewTextBoxColumn();
            colStockActualM = new DataGridViewTextBoxColumn();
            colStockMinimoM = new DataGridViewTextBoxColumn();
            colEstadoM = new DataGridViewTextBoxColumn();
            label14 = new Label();
            pictureBox15 = new PictureBox();
            panel5 = new Panel();
            button10 = new Button();
            label10 = new Label();
            pictureBox13 = new PictureBox();
            panel4 = new Panel();
            button9 = new Button();
            label9 = new Label();
            pictureBox12 = new PictureBox();
            dataGridView1 = new DataGridView();
            colFecha = new DataGridViewTextBoxColumn();
            colProducto = new DataGridViewTextBoxColumn();
            colCantidad = new DataGridViewTextBoxColumn();
            colProveedor = new DataGridViewTextBoxColumn();
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
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox14).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox15).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
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
            panel7.Location = new Point(1061, 154);
            panel7.Name = "panel7";
            panel7.Size = new Size(384, 116);
            panel7.TabIndex = 17;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(99, 43);
            label11.Name = "label11";
            label11.Size = new Size(49, 38);
            label11.TabIndex = 8;
            label11.Text = "20";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(99, 81);
            label12.Name = "label12";
            label12.Size = new Size(193, 23);
            label12.TabIndex = 7;
            label12.Text = "Proveedores registrados\r\n";
            // 
            // pictureBox14
            // 
            pictureBox14.Image = (Image)resources.GetObject("pictureBox14.Image");
            pictureBox14.Location = new Point(3, 10);
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
            label13.Location = new Point(99, 12);
            label13.Name = "label13";
            label13.Size = new Size(200, 25);
            label13.TabIndex = 0;
            label13.Text = "Total de proveeedores";
            // 
            // panel6
            // 
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(button11);
            panel6.Controls.Add(dataGridView3);
            panel6.Controls.Add(label14);
            panel6.Controls.Add(pictureBox15);
            panel6.Location = new Point(171, 602);
            panel6.Name = "panel6";
            panel6.Size = new Size(1274, 274);
            panel6.TabIndex = 18;
            // 
            // button11
            // 
            button11.Cursor = Cursors.Hand;
            button11.FlatAppearance.BorderSize = 0;
            button11.FlatStyle = FlatStyle.Flat;
            button11.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button11.Image = (Image)resources.GetObject("button11.Image");
            button11.ImageAlign = ContentAlignment.MiddleRight;
            button11.Location = new Point(1112, 31);
            button11.Name = "button11";
            button11.Size = new Size(143, 35);
            button11.TabIndex = 10;
            button11.Text = "Ver todos";
            button11.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            dataGridView3.BackgroundColor = Color.FromArgb(220, 233, 247);
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Columns.AddRange(new DataGridViewColumn[] { colProductM, colCategoriaM, colStockActualM, colStockMinimoM, colEstadoM });
            dataGridView3.Location = new Point(-1, 95);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersWidth = 51;
            dataGridView3.Size = new Size(1274, 178);
            dataGridView3.TabIndex = 11;
            // 
            // colProductM
            // 
            colProductM.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colProductM.HeaderText = "Producto";
            colProductM.MinimumWidth = 6;
            colProductM.Name = "colProductM";
            // 
            // colCategoriaM
            // 
            colCategoriaM.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colCategoriaM.HeaderText = "Categoría";
            colCategoriaM.MinimumWidth = 6;
            colCategoriaM.Name = "colCategoriaM";
            // 
            // colStockActualM
            // 
            colStockActualM.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colStockActualM.HeaderText = "Stock Actual";
            colStockActualM.MinimumWidth = 6;
            colStockActualM.Name = "colStockActualM";
            // 
            // colStockMinimoM
            // 
            colStockMinimoM.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colStockMinimoM.HeaderText = "Stock Minimo";
            colStockMinimoM.MinimumWidth = 6;
            colStockMinimoM.Name = "colStockMinimoM";
            // 
            // colEstadoM
            // 
            colEstadoM.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colEstadoM.HeaderText = "Estado";
            colEstadoM.MinimumWidth = 6;
            colEstadoM.Name = "colEstadoM";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label14.Location = new Point(99, 35);
            label14.Name = "label14";
            label14.Size = new Size(255, 25);
            label14.TabIndex = 9;
            label14.Text = "Productos con stock mínimo";
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
            // panel5
            // 
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(button10);
            panel5.Controls.Add(label10);
            panel5.Controls.Add(pictureBox13);
            panel5.Location = new Point(821, 311);
            panel5.Name = "panel5";
            panel5.Size = new Size(624, 274);
            panel5.TabIndex = 16;
            // 
            // button10
            // 
            button10.FlatAppearance.BorderSize = 0;
            button10.FlatStyle = FlatStyle.Flat;
            button10.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button10.Image = (Image)resources.GetObject("button10.Image");
            button10.ImageAlign = ContentAlignment.MiddleRight;
            button10.Location = new Point(462, 23);
            button10.Name = "button10";
            button10.Size = new Size(143, 38);
            button10.TabIndex = 3;
            button10.Text = "Ver todas";
            button10.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(96, 28);
            label10.Name = "label10";
            label10.Size = new Size(154, 28);
            label10.TabIndex = 1;
            label10.Text = "Últimas salidas";
            // 
            // pictureBox13
            // 
            pictureBox13.Image = (Image)resources.GetObject("pictureBox13.Image");
            pictureBox13.Location = new Point(3, -1);
            pictureBox13.Name = "pictureBox13";
            pictureBox13.Size = new Size(87, 82);
            pictureBox13.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox13.TabIndex = 0;
            pictureBox13.TabStop = false;
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(button9);
            panel4.Controls.Add(label9);
            panel4.Controls.Add(pictureBox12);
            panel4.Controls.Add(dataGridView1);
            panel4.Location = new Point(171, 311);
            panel4.Name = "panel4";
            panel4.Size = new Size(624, 274);
            panel4.TabIndex = 15;
            // 
            // button9
            // 
            button9.Cursor = Cursors.Hand;
            button9.FlatAppearance.BorderSize = 0;
            button9.FlatStyle = FlatStyle.Flat;
            button9.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button9.Image = (Image)resources.GetObject("button9.Image");
            button9.ImageAlign = ContentAlignment.MiddleRight;
            button9.Location = new Point(465, 21);
            button9.Name = "button9";
            button9.Size = new Size(143, 35);
            button9.TabIndex = 9;
            button9.Text = "Ver todas";
            button9.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(99, 28);
            label9.Name = "label9";
            label9.Size = new Size(172, 28);
            label9.TabIndex = 8;
            label9.Text = "Últimas entradas";
            // 
            // pictureBox12
            // 
            pictureBox12.Image = (Image)resources.GetObject("pictureBox12.Image");
            pictureBox12.Location = new Point(6, -1);
            pictureBox12.Name = "pictureBox12";
            pictureBox12.Size = new Size(87, 86);
            pictureBox12.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox12.TabIndex = 7;
            pictureBox12.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(220, 233, 247);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colFecha, colProducto, colCantidad, colProveedor });
            dataGridView1.Location = new Point(-1, 91);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(624, 182);
            dataGridView1.TabIndex = 6;
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
            // colProveedor
            // 
            colProveedor.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colProveedor.HeaderText = "Proveedor";
            colProveedor.MinimumWidth = 6;
            colProveedor.Name = "colProveedor";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(242, 249, 254);
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(pictureBox11);
            panel3.Controls.Add(label6);
            panel3.Location = new Point(621, 154);
            panel3.Name = "panel3";
            panel3.Size = new Size(384, 116);
            panel3.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(99, 43);
            label8.Name = "label8";
            label8.Size = new Size(33, 38);
            label8.TabIndex = 8;
            label8.Text = "8";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(99, 81);
            label7.Name = "label7";
            label7.Size = new Size(148, 23);
            label7.TabIndex = 7;
            label7.Text = "Requiere atención";
            // 
            // pictureBox11
            // 
            pictureBox11.Image = (Image)resources.GetObject("pictureBox11.Image");
            pictureBox11.Location = new Point(3, 10);
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
            label6.Location = new Point(99, 12);
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
            panel2.Size = new Size(384, 116);
            panel2.TabIndex = 13;
            // 
            // pictureBox10
            // 
            pictureBox10.Image = (Image)resources.GetObject("pictureBox10.Image");
            pictureBox10.Location = new Point(3, 12);
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
            label5.Location = new Point(99, 38);
            label5.Name = "label5";
            label5.Size = new Size(65, 38);
            label5.TabIndex = 2;
            label5.Text = "100";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(99, 81);
            label4.Name = "label4";
            label4.Size = new Size(280, 23);
            label4.TabIndex = 1;
            label4.Text = "Productos registrado en el sistemas";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label3.Location = new Point(99, 12);
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
            // frmPanelPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(220, 233, 247);
            ClientSize = new Size(1632, 915);
            Controls.Add(panel7);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmPanelPrincipal";
            Text = "frmPanelPrincipal";
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox14).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox15).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
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
        private DataGridView dataGridView3;
        private DataGridViewTextBoxColumn colProductM;
        private DataGridViewTextBoxColumn colCategoriaM;
        private DataGridViewTextBoxColumn colStockActualM;
        private DataGridViewTextBoxColumn colStockMinimoM;
        private DataGridViewTextBoxColumn colEstadoM;
        private Label label14;
        private PictureBox pictureBox15;
        private Panel panel5;
        private Button button10;
        private Label label10;
        private PictureBox pictureBox13;
        private Panel panel4;
        private Button button9;
        private Label label9;
        private PictureBox pictureBox12;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn colFecha;
        private DataGridViewTextBoxColumn colProducto;
        private DataGridViewTextBoxColumn colCantidad;
        private DataGridViewTextBoxColumn colProveedor;
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
    }
}
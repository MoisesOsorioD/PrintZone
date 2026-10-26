using System.Drawing;
using System.Windows.Forms;

namespace LibreriaPrintZone.Components
{
    public static class DataGridViewEstilo
    {
        public static void Aplicar(DataGridView dgv)
        {
            if (dgv == null)
                return;

            // Configuración general
            dgv.BorderStyle = BorderStyle.None;
            dgv.BackgroundColor = Color.White;
            dgv.GridColor = Color.FromArgb(220, 228, 238);

            dgv.EnableHeadersVisualStyles = false;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;
            dgv.ReadOnly = true;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.RowHeadersVisible = false;

            // Encabezados de las columnas
            dgv.ColumnHeadersDefaultCellStyle.BackColor =
                Color.FromArgb(21, 78, 145);

            dgv.ColumnHeadersDefaultCellStyle.ForeColor =
                Color.White;

            dgv.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 10F, FontStyle.Bold);

            dgv.ColumnHeadersDefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleLeft;

            dgv.ColumnHeadersDefaultCellStyle.SelectionBackColor =
                Color.FromArgb(21, 78, 145);

            dgv.ColumnHeadersDefaultCellStyle.SelectionForeColor =
                Color.White;

            dgv.ColumnHeadersHeight = 38;
            dgv.ColumnHeadersHeightSizeMode =
                DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            // Filas normales
            dgv.DefaultCellStyle.BackColor = Color.White;
            dgv.DefaultCellStyle.ForeColor = Color.FromArgb(40, 50, 65);

            dgv.DefaultCellStyle.Font =
                new Font("Segoe UI", 9.5F, FontStyle.Regular);

            dgv.DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(210, 230, 255);

            dgv.DefaultCellStyle.SelectionForeColor =
                Color.FromArgb(20, 45, 75);

            dgv.DefaultCellStyle.Padding =
                new Padding(5, 2, 5, 2);

            // Filas alternas
            dgv.AlternatingRowsDefaultCellStyle.BackColor =
                Color.FromArgb(240, 246, 253);

            // Altura de las filas
            dgv.RowTemplate.Height = 32;

            // Bordes y ajuste de texto
            dgv.CellBorderStyle =
                DataGridViewCellBorderStyle.SingleHorizontal;

            dgv.DefaultCellStyle.WrapMode =
                DataGridViewTriState.False;

            dgv.ColumnHeadersDefaultCellStyle.WrapMode =
                DataGridViewTriState.False;
        }
    }
}
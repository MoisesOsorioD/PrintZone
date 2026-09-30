using LibreriaPrintZone.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace LibreriaPrintZone.Views
{
    public partial class frmPanelPrincipal : Form
    {
        private readonly string _rol;
        private readonly string _nombreCompleto;

        public frmPanelPrincipal(string rol, string nombreCompleto)
        {
            InitializeComponent();

            _rol = rol;
            _nombreCompleto = nombreCompleto;

            ConfigurarPanel();
            CargarInformacion();
        }

        // =========================================================
        // CONFIGURAR PANEL
        // =========================================================

        private void ConfigurarPanel()
        {
            if (_rol == "Administrador")
            {
                lblBienvenida.Text =
                    $"¡Bienvenido, {_nombreCompleto}!";

                lblDescripcion.Text =
                    "Aquí tienes un resumen del estado de tu inventario.";

                lblTituloTarjeta1.Text =
                    "Total de productos";

                lblTituloTarjeta2.Text =
                    "Productos con stock mínimo";

                lblTituloTarjeta3.Text =
                    "Total de entradas hoy";

                lblDescripcionProductos.Text =
                    "Productos registrados en el sistema";

                lblDescripcionStock.Text =
                    "Requiere atención";

                lblDescripcionEntradas.Text =
                    "Registros de entradas";
            }
            else if (_rol == "Vendedor")
            {
                lblBienvenida.Text =
                    $"¡Bienvenido, {_nombreCompleto}!";

                lblDescripcion.Text =
                    "Aquí tienes un resumen de las salidas realizadas.";

                lblTituloTarjeta1.Text =
                    "Total de salidas hoy";

                lblTituloTarjeta2.Text =
                    "Producto con más salidas";

                lblTituloTarjeta3.Text =
                    "Categoría con más salidas";

                lblDescripcionProductos.Text =
                    "Salidas registradas hoy";

                lblDescripcionStock.Text =
                    "Producto con mayor cantidad de salidas";

                lblDescripcionEntradas.Text =
                    "Categoría con mayor cantidad de salidas";
            }
        }

        // =========================================================
        // CARGAR INFORMACIÓN
        // =========================================================

        private void CargarInformacion()
        {
            try
            {
                using var context = new InventarioPrintzoneContext();

                // =================================================
                // POR AHORA NOS ENFOCAMOS EN ADMINISTRADOR
                // =================================================

                if (_rol == "Administrador")
                {
                    CargarDashboardAdministrador(context);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se pudo cargar la información del panel.\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // =========================================================
        // DASHBOARD ADMINISTRADOR
        // =========================================================

        private void CargarDashboardAdministrador(
            InventarioPrintzoneContext context)
        {
            // =====================================================
            // TARJETAS
            // =====================================================

            var resultado = context.Database
                .SqlQueryRaw<DashboardAdminResultado>(
                    "EXEC sp_Dashboard_Admin"
                )
                .AsEnumerable()
                .FirstOrDefault();

            if (resultado != null)
            {
                lblTotalProductos.Text =
                    resultado.total_productos.ToString();

                lblProductosStockMinimo.Text =
                    resultado.productos_stock_minimo.ToString();

                lblEntradasHoy.Text =
                    resultado.entradas_hoy.ToString();
            }
            else
            {
                lblTotalProductos.Text = "0";
                lblProductosStockMinimo.Text = "0";
                lblEntradasHoy.Text = "0";
            }

            // =====================================================
            // DATAGRID DEL ADMINISTRADOR
            // =====================================================

            CargarMovimientosAdministrador(context);
        }

        // =========================================================
        // MOVIMIENTOS DEL ADMINISTRADOR
        // =========================================================

        private void CargarMovimientosAdministrador(
            InventarioPrintzoneContext context)
        {
            // =====================================================
            // ENTRADAS
            // =====================================================

            var entradas = context.Entradas
                .AsNoTracking()
                .Include(e => e.IdProductoNavigation)
                .Include(e => e.IdProveedorNavigation)
                .Select(e => new MovimientoViewModel
                {
                    Fecha = e.FechaEntrada,
                    Movimiento = "Entrada",
                    Producto = e.IdProductoNavigation.Nombre,
                    Cantidad = e.Cantidad
                })
                .ToList();

            // =====================================================
            // SALIDAS
            // =====================================================

            var salidas = context.Salidas
                .AsNoTracking()
                .Include(s => s.IdProductoNavigation)
                .Select(s => new MovimientoViewModel
                {
                    Fecha = s.FechaSalida,
                    Movimiento = "Salida",
                    Producto = s.IdProductoNavigation.Nombre,
                    Cantidad = s.Cantidad
                })
                .ToList();

            // =====================================================
            // UNIR ENTRADAS Y SALIDAS
            // =====================================================

            var movimientos = entradas
                .Concat(salidas)
                .OrderByDescending(m => m.Fecha)
                .Take(10)
                .ToList();

            // =====================================================
            // LIMPIAR DATAGRID
            // =====================================================

            dgvMovimientos.Rows.Clear();

            // =====================================================
            // CARGAR DATOS
            // =====================================================

            foreach (var movimiento in movimientos)
            {
                dgvMovimientos.Rows.Add(
                    movimiento.Fecha.ToString("dd/MM/yyyy"),
                    movimiento.Movimiento,
                    movimiento.Producto,
                    movimiento.Cantidad
                );
            }

            dgvMovimientos.ClearSelection();
        }

        // =========================================================
        // RESULTADO DEL PROCEDIMIENTO DEL ADMINISTRADOR
        // =========================================================

        public class DashboardAdminResultado
        {
            public int total_productos { get; set; }

            public int productos_stock_minimo { get; set; }

            public int entradas_hoy { get; set; }
        }

        // =========================================================
        // MODELO PARA LOS MOVIMIENTOS
        // =========================================================

        private class MovimientoViewModel
        {
            public DateTime Fecha { get; set; }

            public string Movimiento { get; set; } = "";

            public string Producto { get; set; } = "";

            public int Cantidad { get; set; }

        }
    }
}
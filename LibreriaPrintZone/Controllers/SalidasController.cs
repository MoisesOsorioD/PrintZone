using LibreriaPrintZone.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LibreriaPrintZone.Controllers
{
    public class SalidasController
    {
        private readonly InventarioPrintzoneContext _context;

        public SalidasController()
        {
            _context = new InventarioPrintzoneContext();
        }

        // =========================================================
        // LISTAR SALIDAS
        // =========================================================

        public List<SalidaListado> ObtenerSalidas()
        {
            return _context.Database
                .SqlQueryRaw<SalidaListado>(
                    "EXEC sp_Salidas_Listar"
                )
                .AsEnumerable()
                .ToList();
        }

        // =========================================================
        // OBTENER SALIDA POR ID
        // =========================================================

        public SalidaListado? ObtenerSalidaPorId(
            int idSalida)
        {
            List<SalidaListado> resultado =
                _context.Database
                    .SqlQueryRaw<SalidaListado>(
                        "EXEC sp_Salidas_ObtenerPorId @p0",
                        idSalida
                    )
                    .AsEnumerable()
                    .ToList();

            return resultado.FirstOrDefault();
        }

        // =========================================================
        // REGISTRAR SALIDA
        // =========================================================

        public void RegistrarSalida(
            int cantidad,
            string motivo,
            int idUsuario,
            int idProducto)
        {
            DateTime fechaSalida = DateTime.Now;

            var parametroFecha = new SqlParameter(
                "@fecha_salida",
                System.Data.SqlDbType.DateTime
            )
            {
                Value = fechaSalida
            };

            var parametroCantidad = new SqlParameter(
                "@cantidad",
                System.Data.SqlDbType.Int
            )
            {
                Value = cantidad
            };

            var parametroMotivo = new SqlParameter(
                "@motivo",
                System.Data.SqlDbType.VarChar,
                250
            )
            {
                Value = motivo
            };

            var parametroUsuario = new SqlParameter(
                "@id_usuario",
                System.Data.SqlDbType.Int
            )
            {
                Value = idUsuario
            };

            var parametroProducto = new SqlParameter(
                "@id_producto",
                System.Data.SqlDbType.Int
            )
            {
                Value = idProducto
            };

            _context.Database.ExecuteSqlRaw(
                "EXEC sp_Salidas_Registrar " +
                "@fecha_salida, " +
                "@cantidad, " +
                "@motivo, " +
                "@id_usuario, " +
                "@id_producto",
                parametroFecha,
                parametroCantidad,
                parametroMotivo,
                parametroUsuario,
                parametroProducto
            );
        }

        // =========================================================
        // OBTENER PRODUCTOS ACTIVOS
        // =========================================================

        public List<ProductoListado> ObtenerProductos()
        {
            return _context.Database
                .SqlQueryRaw<ProductoListado>(
                    "EXEC sp_Productos_Listar"
                )
                .AsEnumerable()
                .ToList();
        }

        // =========================================================
        // OBTENER PRODUCTO POR ID
        // =========================================================

        public ProductoListado? ObtenerProductoPorId(
            int idProducto)
        {
            List<ProductoListado> resultado =
                _context.Database
                    .SqlQueryRaw<ProductoListado>(
                        "EXEC sp_Productos_ObtenerPorId @p0",
                        idProducto
                    )
                    .AsEnumerable()
                    .ToList();

            return resultado.FirstOrDefault();
        }

        // =========================================================
        // OBTENER USUARIO POR ID
        // =========================================================

        public Usuario? ObtenerUsuarioPorId(
            int idUsuario)
        {
            return _context.Usuarios
                .FromSqlRaw(
                    "EXEC sp_Usuarios_ObtenerPorId @p0",
                    idUsuario
                )
                .AsNoTracking()
                .FirstOrDefault();
        }

        // =========================================================
        // BUSCAR SALIDAS
        // =========================================================

        public List<SalidaListado> BuscarSalidas(
            string busqueda)
        {
            List<SalidaListado> salidas =
                ObtenerSalidas();

            string texto =
                busqueda.Trim();

            if (string.IsNullOrWhiteSpace(texto))
            {
                return salidas;
            }

            return salidas
                .Where(s =>
                    s.nombre_producto.Contains(
                        texto,
                        StringComparison.OrdinalIgnoreCase
                    )
                    ||
                    s.motivo.Contains(
                        texto,
                        StringComparison.OrdinalIgnoreCase
                    )
                    ||
                    s.nombre_usuario.Contains(
                        texto,
                        StringComparison.OrdinalIgnoreCase
                    )
                )
                .ToList();
        }

        // =========================================================
        // TOTAL DE SALIDAS REGISTRADAS
        // =========================================================

        public int ObtenerTotalSalidas()
        {
            return ObtenerSalidas().Count;
        }

        // =========================================================
        // TOTAL DE UNIDADES RETIRADAS
        // =========================================================

        public int ObtenerTotalUnidades()
        {
            return ObtenerSalidas()
                .Sum(s => s.cantidad);
        }

        // =========================================================
        // PRODUCTO CON MÁS SALIDAS
        // =========================================================

        public ProductoMasSalidas? ObtenerProductoConMasSalidas()
        {
            List<SalidaListado> salidas =
                ObtenerSalidas();

            if (salidas.Count == 0)
            {
                return null;
            }

            var resultado =
                salidas
                    .GroupBy(s => new
                    {
                        s.id_producto,
                        s.nombre_producto
                    })
                    .Select(g => new ProductoMasSalidas
                    {
                        id_producto = g.Key.id_producto,
                        nombre_producto = g.Key.nombre_producto,
                        total_unidades = g.Sum(
                            s => s.cantidad
                        )
                    })
                    .OrderByDescending(
                        p => p.total_unidades
                    )
                    .FirstOrDefault();

            return resultado;
        }

        // =========================================================
        // OBTENER STOCK ACTUAL Y STOCK MÍNIMO
        // =========================================================

        public StockProducto? ObtenerStockProducto(
            int idProducto)
        {
            ProductoListado? producto =
                ObtenerProductoPorId(idProducto);

            if (producto == null)
            {
                return null;
            }

            return new StockProducto
            {
                id_producto = producto.id_producto,
                nombre_producto = producto.nombre,
                stock_actual = producto.stock_actual,
                stock_minimo = producto.stock_minimo
            };
        }
    }

    // =============================================================
    // MODELO PARA MOSTRAR LAS SALIDAS
    // =============================================================

    public class SalidaListado
    {
        public int id_salida { get; set; }

        public DateTime fecha_salida { get; set; }

        public int cantidad { get; set; }

        public string motivo { get; set; } = "";

        public int id_usuario { get; set; }

        public int id_producto { get; set; }

        public string nombre_usuario { get; set; } = "";

        public string nombre_producto { get; set; } = "";
    }

    // =============================================================
    // MODELO PARA PRODUCTO CON MÁS SALIDAS
    // =============================================================

    public class ProductoMasSalidas
    {
        public int id_producto { get; set; }

        public string nombre_producto { get; set; } = "";

        public int total_unidades { get; set; }
    }

    // =============================================================
    // MODELO PARA STOCK DEL PRODUCTO
    // =============================================================

    public class StockProducto
    {
        public int id_producto { get; set; }

        public string nombre_producto { get; set; } = "";

        public int stock_actual { get; set; }

        public int stock_minimo { get; set; }
    }
}
using LibreriaPrintZone.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LibreriaPrintZone.Controllers
{
    public class EntradasController
    {
        private readonly InventarioPrintzoneContext _context;

        public EntradasController()
        {
            _context = new InventarioPrintzoneContext();
        }


        public List<EntradaListado> ObtenerEntradas()
        {
            return _context.Database
                .SqlQueryRaw<EntradaListado>(
                    "EXEC sp_Entradas_Listar"
                )
                .AsEnumerable()
                .ToList();
        }



        public EntradaListado? ObtenerEntradaPorId(
            int idEntrada)
        {
            List<EntradaListado> resultado =
                _context.Database
                    .SqlQueryRaw<EntradaListado>(
                        "EXEC sp_Entradas_ObtenerPorId @p0",
                        idEntrada
                    )
                    .AsEnumerable()
                    .ToList();

            return resultado.FirstOrDefault();
        }



        public void RegistrarEntrada(
            int cantidad,
            decimal costoLote,
            int idProveedor,
            int idProducto)
        {
            DateTime fechaEntrada = DateTime.Now;

            var parametroFecha = new SqlParameter(
                "@fecha_entrada",
                System.Data.SqlDbType.DateTime
            )
            {
                Value = fechaEntrada
            };

            var parametroCantidad = new SqlParameter(
                "@cantidad",
                System.Data.SqlDbType.Int
            )
            {
                Value = cantidad
            };

            var parametroCostoLote = new SqlParameter(
                "@costo_lote",
                System.Data.SqlDbType.Decimal
            )
            {
                Precision = 10,
                Scale = 2,
                Value = costoLote
            };

            var parametroProveedor = new SqlParameter(
                "@id_proveedor",
                System.Data.SqlDbType.Int
            )
            {
                Value = idProveedor
            };

            var parametroProducto = new SqlParameter(
                "@id_producto",
                System.Data.SqlDbType.Int
            )
            {
                Value = idProducto
            };

            _context.Database.ExecuteSqlRaw(
                "EXEC sp_Entradas_Registrar " +
                "@fecha_entrada, " +
                "@cantidad, " +
                "@costo_lote, " +
                "@id_proveedor, " +
                "@id_producto",
                parametroFecha,
                parametroCantidad,
                parametroCostoLote,
                parametroProveedor,
                parametroProducto
            );
        }


        public List<Proveedore> ObtenerProveedores()
        {
            return _context.Proveedores
                .FromSqlRaw(
                    "EXEC sp_Proveedores_Listar"
                )
                .AsNoTracking()
                .ToList();
        }



        public List<ProductoListado> ObtenerProductos()
        {
            return _context.Database
                .SqlQueryRaw<ProductoListado>(
                    "EXEC sp_Productos_Listar"
                )
                .AsEnumerable()
                .ToList();
        }


        public List<EntradaListado> BuscarEntradas(
            string busqueda)
        {
            List<EntradaListado> entradas =
                ObtenerEntradas();

            string texto =
                busqueda.Trim();

            if (string.IsNullOrWhiteSpace(texto))
            {
                return entradas;
            }

            return entradas
                .Where(e =>
                    e.nombre_producto.Contains(
                        texto,
                        StringComparison.OrdinalIgnoreCase
                    )
                    ||
                    e.nombre_empresa.Contains(
                        texto,
                        StringComparison.OrdinalIgnoreCase
                    )
                )
                .ToList();
        }



        public int ObtenerTotalEntradas()
        {
            return ObtenerEntradas().Count;
        }



        public int ObtenerTotalUnidades()
        {
            return ObtenerEntradas()
                .Sum(e => e.cantidad);
        }



        public decimal ObtenerInversionInventario()
        {
            return ObtenerEntradas()
                .Sum(e => e.costo_lote);
        }
    }



    public class EntradaListado
    {
        public int id_entrada { get; set; }

        public DateTime fecha_entrada { get; set; }

        public int cantidad { get; set; }

        public decimal costo_lote { get; set; }

        public int id_proveedor { get; set; }

        public int id_producto { get; set; }

        public string nombre_empresa { get; set; } = "";

        public string nombre_producto { get; set; } = "";
    }
}
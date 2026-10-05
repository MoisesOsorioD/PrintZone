using LibreriaPrintZone.Models;
using Microsoft.EntityFrameworkCore;

namespace LibreriaPrintZone.Controllers
{
    public class ProductosController
    {
        private readonly InventarioPrintzoneContext _context;

        public ProductosController()
        {
            _context = new InventarioPrintzoneContext();
        }

        public List<ProductoListado> ObtenerProductos()
        {
            return _context.Database
                .SqlQueryRaw<ProductoListado>("EXEC sp_Productos_Listar")
                .AsEnumerable()
                .ToList();
        }

        public List<ProductoListado> BuscarProductos(string busqueda)
        {
            return _context.Database
                .SqlQueryRaw<ProductoListado>(
                    "EXEC sp_Productos_Buscar @p0",
                    busqueda
                )
                .AsEnumerable()
                .ToList();
        }

        public void ActualizarProducto(
            int idProducto,
            string nombre,
            string descripcion,
            string marca,
            decimal precioCompra,
            decimal precioVenta,
            string codigoBarras,
            int stockMinimo,
            int idCategoria,
            bool activo)
        {
            _context.Database.ExecuteSqlRaw(
                "EXEC sp_Productos_Actualizar @p0, @p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8, @p9",
                idProducto,
                nombre,
                descripcion,
                marca,
                precioCompra,
                precioVenta,
                codigoBarras,
                stockMinimo,
                idCategoria,
                activo
            );
        }


        public List<ProductoListado> ObtenerProductosInactivos()
        {
            return _context.Database
                .SqlQueryRaw<ProductoListado>("EXEC sp_Productos_Inactivos")
                .AsEnumerable()
                .ToList();
        }

        public void ReactivarProducto(int idProducto)
        {
            _context.Database.ExecuteSqlRaw(
                "EXEC sp_Productos_Reactivar @p0",
                idProducto
            );
        }

        public void DesactivarProducto(int idProducto)
        {
            _context.Database.ExecuteSqlRaw(
                "EXEC sp_Productos_Desactivar @p0",
                idProducto
            );
        }

        public List<Categoria> ObtenerCategorias()
        {
            return _context.Categorias
                .FromSqlRaw("EXEC sp_Categorias_Listar")
                .AsNoTracking()
                .ToList();
        }
    }

    public class ProductoListado
    {
        public int id_producto { get; set; }

        public string nombre { get; set; } = "";

        public string? descripcion { get; set; }

        public string? marca { get; set; }

        public decimal precio_compra { get; set; }

        public decimal precio_venta { get; set; }

        public string? codigo_barras { get; set; }

        public int stock_actual { get; set; }

        public int stock_minimo { get; set; }

        public int id_categoria { get; set; }

        public string nombre_categoria { get; set; } = "";

        public bool activo { get; set; }
    }
}
using LibreriaPrintZone.Models;
using Microsoft.EntityFrameworkCore;

namespace LibreriaPrintZone.Controllers
{
    public class CategoriasController
    {
        private readonly InventarioPrintzoneContext _context;

        public CategoriasController()
        {
            _context = new InventarioPrintzoneContext();
        }

        public List<Categoria> ObtenerCategorias()
        {
            var categorias = _context.Categorias
                .FromSqlRaw("EXEC sp_Categorias_Listar")
                .AsNoTracking()
                .ToList();

            var idsCategorias = categorias
                .Select(c => c.IdCategoria)
                .ToList();

            var productos = _context.Productos
                .AsNoTracking()
                .Where(p => idsCategorias.Contains(p.IdCategoria))
                .ToList();

            foreach (var categoria in categorias)
            {
                categoria.Productos = productos
                    .Where(p => p.IdCategoria == categoria.IdCategoria)
                    .ToList();
            }

            return categorias;
        }

        public void GuardarCategoria(string nombreCategoria)
        {
            _context.Database.ExecuteSqlRaw(
                "EXEC sp_Categorias_Insertar @p0",
                nombreCategoria
            );
        }

        public void ActualizarCategoria(int idCategoria, string nombreCategoria)
        {
            _context.Database.ExecuteSqlRaw(
                "EXEC sp_Categorias_Actualizar @p0, @p1",
                idCategoria,
                nombreCategoria
            );
        }

        public bool EliminarCategoria(int idCategoria)
        {
            try
            {
                _context.Database.ExecuteSqlRaw(
                    "EXEC sp_Categorias_Eliminar @p0",
                    idCategoria
                );

                return true;
            }
            catch
            {
                return false;
            }
        }

        public int ObtenerTotalCategorias()
        {
            return _context.Categorias.Count();
        }

        public Categoria? ObtenerCategoriaMasProductos()
        {
            return _context.Categorias
                .Include(c => c.Productos)
                .OrderByDescending(c => c.Productos.Count)
                .FirstOrDefault();
        }

        public Categoria? ObtenerCategoriaMenosProductos()
        {
            return _context.Categorias
                .Include(c => c.Productos)
                .OrderBy(c => c.Productos.Count)
                .FirstOrDefault();
        }

        public List<Categoria> BuscarCategorias(string texto)
        {
            return _context.Categorias
                .Include(c => c.Productos)
                .Where(c => c.NombreCategoria.Contains(texto))
                .AsNoTracking()
                .ToList();
        }
    }
}
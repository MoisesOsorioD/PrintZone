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
            return _context.Categorias
                .Include(c => c.Productos)
                .AsNoTracking()
                .ToList();
        }


        public void GuardarCategoria(string nombreCategoria)
        {
            var categoria = new Categoria
            {
                NombreCategoria = nombreCategoria
            };

            _context.Categorias.Add(categoria);
            _context.SaveChanges();
        }


        public void ActualizarCategoria(int idCategoria, string nombreCategoria)
        {
            var categoria = _context.Categorias.Find(idCategoria);

            if (categoria == null)
                return;

            categoria.NombreCategoria = nombreCategoria;

            _context.SaveChanges();
        }


        public bool EliminarCategoria(int idCategoria)
        {
            var categoria = _context.Categorias
                .Include(c => c.Productos)
                .FirstOrDefault(c => c.IdCategoria == idCategoria);

            if (categoria == null)
                return false;

            if (categoria.Productos.Any())
                return false;

            _context.Categorias.Remove(categoria);
            _context.SaveChanges();

            return true;
        }

        //TARJETAS
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


        //BUSCADOR
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
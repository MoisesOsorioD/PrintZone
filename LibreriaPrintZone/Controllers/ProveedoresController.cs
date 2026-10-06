using LibreriaPrintZone.Models;
using Microsoft.EntityFrameworkCore;

namespace LibreriaPrintZone.Controllers
{
    public class ProveedoresController
    {
        private readonly InventarioPrintzoneContext _context;

        public ProveedoresController()
        {
            _context = new InventarioPrintzoneContext();
        }

        public List<Proveedore> ObtenerProveedores()
        {
            return _context.Proveedores
                .FromSqlRaw("EXEC sp_Proveedores_Listar")
                .AsNoTracking()
                .ToList();
        }

        public List<Proveedore> BuscarProveedores(string busqueda)
        {
            return _context.Proveedores
                .FromSqlRaw(
                    "EXEC sp_Proveedores_Buscar @p0",
                    busqueda
                )
                .AsNoTracking()
                .ToList();
        }

        public void InsertarProveedor(
            string nombreEmpresa,
            string direccion,
            string correo,
            string telefono,
            string nombreAgente,
            string telefonoAgente,
            decimal montoMinimoCompra)
        {
            _context.Database.ExecuteSqlRaw(
                "EXEC sp_Proveedores_Insertar " +
                "@p0, @p1, @p2, @p3, @p4, @p5, @p6",
                nombreEmpresa,
                direccion,
                correo,
                telefono,
                nombreAgente,
                telefonoAgente,
                montoMinimoCompra
            );
        }

        public void ActualizarProveedor(
            int idProveedor,
            string nombreEmpresa,
            string direccion,
            string correo,
            string telefono,
            string nombreAgente,
            string telefonoAgente,
            decimal montoMinimoCompra)
        {
            _context.Database.ExecuteSqlRaw(
                "EXEC sp_Proveedores_Actualizar " +
                "@p0, @p1, @p2, @p3, @p4, @p5, @p6, @p7",
                idProveedor,
                nombreEmpresa,
                direccion,
                correo,
                telefono,
                nombreAgente,
                telefonoAgente,
                montoMinimoCompra
            );
        }

        public void EliminarProveedor(int idProveedor)
        {
            _context.Database.ExecuteSqlRaw(
                "EXEC sp_Proveedores_Eliminar @p0",
                idProveedor
            );
        }
    }
}
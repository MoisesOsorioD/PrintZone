using LibreriaPrintZone.Models;
using Microsoft.EntityFrameworkCore;

namespace LibreriaPrintZone.Controllers
{
    public class UsuariosController
    {
        private readonly InventarioPrintzoneContext _context;

        public UsuariosController()
        {
            _context = new InventarioPrintzoneContext();
        }

        public UsuarioLogin? IniciarSesion(string nombreUsuario, string clave)
        {
            var resultado = _context.Database
                .SqlQueryRaw<UsuarioLogin>(
                    "EXEC sp_Usuarios_IniciarSesion @p0, @p1",
                    nombreUsuario,
                    clave
                )
                .AsEnumerable()
                .FirstOrDefault();

            return resultado;
        }

        public List<Usuario> ObtenerUsuarios()
        {
            return _context.Usuarios
                .FromSqlRaw("EXEC sp_Usuarios_Listar")
                .AsNoTracking()
                .ToList();
        }

        public Usuario? ObtenerUsuarioPorId(int idUsuario)
        {
            return _context.Usuarios
                .FromSqlRaw(
                    "EXEC sp_Usuarios_ObtenerPorId @p0",
                    idUsuario
                )
                .AsNoTracking()
                .AsEnumerable()
                .FirstOrDefault();
        }

        public void GuardarUsuario(
            string nombreUsuario,
            string nombreCompleto,
            string clave,
            string rol)
        {
            _context.Database.ExecuteSqlRaw(
                "EXEC sp_Usuarios_Insertar @p0, @p1, @p2, @p3",
                nombreUsuario,
                nombreCompleto,
                clave,
                rol
            );
        }

        public void ActualizarUsuario(
            int idUsuario,
            string nombreUsuario,
            string nombreCompleto,
            string clave,
            string rol,
            bool activo)
        {
            _context.Database.ExecuteSqlRaw(
                "EXEC sp_Usuarios_Actualizar @p0, @p1, @p2, @p3, @p4, @p5",
                idUsuario,
                nombreUsuario,
                nombreCompleto,
                clave,
                rol,
                activo
            );
        }

        public void DesactivarUsuario(int idUsuario)
        {
            _context.Database.ExecuteSqlRaw(
                "EXEC sp_Usuarios_Desactivar @p0",
                idUsuario
            );
        }
    }
}
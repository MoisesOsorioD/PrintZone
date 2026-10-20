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


        public UsuarioLogin? IniciarSesion(
            string nombreUsuario,
            string clave)
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
                .FromSqlRaw(
                    "EXEC sp_Usuarios_Listar"
                )
                .AsNoTracking()
                .ToList();
        }



        public Usuario? ObtenerUsuarioPorId(
            int idUsuario)
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
            string rol,
            bool activo)
        {
            _context.Database.ExecuteSqlRaw(
                "EXEC sp_Usuarios_Insertar " +
                "@p0, @p1, @p2, @p3, @p4",
                nombreUsuario,
                nombreCompleto,
                clave,
                rol,
                activo
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
                "EXEC sp_Usuarios_Actualizar " +
                "@p0, @p1, @p2, @p3, @p4, @p5",
                idUsuario,
                nombreUsuario,
                nombreCompleto,
                clave,
                rol,
                activo
            );
        }



        public void DesactivarUsuario(
            int idUsuario)
        {
            _context.Database.ExecuteSqlRaw(
                "EXEC sp_Usuarios_Desactivar @p0",
                idUsuario
            );
        }



        public List<Usuario> BuscarUsuarios(
            string busqueda)
        {
            List<Usuario> usuarios =
                ObtenerUsuarios();

            string texto =
                busqueda.Trim();

            if (string.IsNullOrWhiteSpace(texto))
            {
                return usuarios;
            }

            return usuarios
                .Where(u =>
                    u.NombreUsuario.Contains(
                        texto,
                        StringComparison.OrdinalIgnoreCase
                    )
                    ||
                    u.NombreCompleto.Contains(
                        texto,
                        StringComparison.OrdinalIgnoreCase
                    )
                    ||
                    u.Rol.Contains(
                        texto,
                        StringComparison.OrdinalIgnoreCase
                    )
                )
                .ToList();
        }



        public int ObtenerTotalUsuarios()
        {
            return ObtenerUsuarios().Count;
        }



        public int ObtenerUsuariosActivos()
        {
            return ObtenerUsuarios()
                .Count(u => u.Activo);
        }



        public int ObtenerUsuariosDesactivados()
        {
            return ObtenerUsuarios()
                .Count(u => !u.Activo);
        }
    }
}
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

        // =========================================================
        // INICIAR SESIÓN
        // =========================================================

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

        // =========================================================
        // LISTAR USUARIOS
        // =========================================================

        public List<Usuario> ObtenerUsuarios()
        {
            return _context.Usuarios
                .FromSqlRaw(
                    "EXEC sp_Usuarios_Listar"
                )
                .AsNoTracking()
                .ToList();
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
                .AsEnumerable()
                .FirstOrDefault();
        }

        // =========================================================
        // GUARDAR USUARIO
        // =========================================================

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

        // =========================================================
        // ACTUALIZAR USUARIO
        // =========================================================

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

        // =========================================================
        // DESACTIVAR USUARIO
        // =========================================================

        public void DesactivarUsuario(
            int idUsuario)
        {
            _context.Database.ExecuteSqlRaw(
                "EXEC sp_Usuarios_Desactivar @p0",
                idUsuario
            );
        }

        // =========================================================
        // BUSCAR USUARIOS
        // =========================================================

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

        // =========================================================
        // TOTAL DE USUARIOS
        // =========================================================

        public int ObtenerTotalUsuarios()
        {
            return ObtenerUsuarios().Count;
        }

        // =========================================================
        // TOTAL DE USUARIOS ACTIVOS
        // =========================================================

        public int ObtenerUsuariosActivos()
        {
            return ObtenerUsuarios()
                .Count(u => u.Activo);
        }

        // =========================================================
        // TOTAL DE USUARIOS DESACTIVADOS
        // =========================================================

        public int ObtenerUsuariosDesactivados()
        {
            return ObtenerUsuarios()
                .Count(u => !u.Activo);
        }
    }
}
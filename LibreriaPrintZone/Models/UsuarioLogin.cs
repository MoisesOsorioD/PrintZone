using System.ComponentModel.DataAnnotations.Schema;

namespace LibreriaPrintZone.Models
{
    public class UsuarioLogin
    {
        [Column("id_usuario")]
        public int IdUsuario { get; set; }

        [Column("nombre_usuario")]
        public string NombreUsuario { get; set; } = null!;

        [Column("nombre_completo")]
        public string NombreCompleto { get; set; } = null!;

        [Column("rol")]
        public string Rol { get; set; } = null!;
    }
}
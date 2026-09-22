using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LibreriaPrintZone.Models;

public partial class Usuario
{
    [Key]
    [Column("id_usuario")]
    public int IdUsuario { get; set; }

    [Column("nombre_usuario")]
    [StringLength(100)]
    [Unicode(false)]
    public string NombreUsuario { get; set; } = null!;

    [Column("nombre_completo")]
    [StringLength(100)]
    [Unicode(false)]
    public string NombreCompleto { get; set; } = null!;

    [Column("clave")]
    [StringLength(250)]
    [Unicode(false)]
    public string Clave { get; set; } = null!;

    [Column("rol")]
    [StringLength(20)]
    [Unicode(false)]
    public string Rol { get; set; } = null!;

    [Column("activo")]
    public bool Activo { get; set; }

    [Column("fecha_Creacion", TypeName = "datetime")]
    public DateTime FechaCreacion { get; set; }

    [InverseProperty("IdUsuarioNavigation")]
    public virtual ICollection<Salida> Salida { get; set; } = new List<Salida>();
}

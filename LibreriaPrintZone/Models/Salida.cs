using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LibreriaPrintZone.Models;

public partial class Salida
{
    [Key]
    [Column("id_salida")]
    public int IdSalida { get; set; }

    [Column("fecha_salida", TypeName = "datetime")]
    public DateTime FechaSalida { get; set; }

    [Column("cantidad")]
    public int Cantidad { get; set; }

    [Column("motivo")]
    [StringLength(255)]
    [Unicode(false)]
    public string Motivo { get; set; } = null!;

    [Column("id_usuario")]
    public int IdUsuario { get; set; }

    [Column("id_producto")]
    public int IdProducto { get; set; }

    [ForeignKey("IdProducto")]
    [InverseProperty("Salida")]
    public virtual Producto IdProductoNavigation { get; set; } = null!;

    [ForeignKey("IdUsuario")]
    [InverseProperty("Salida")]
    public virtual Usuario IdUsuarioNavigation { get; set; } = null!;
}

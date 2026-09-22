using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LibreriaPrintZone.Models;

public partial class Proveedore
{
    [Key]
    [Column("id_proveedor")]
    public int IdProveedor { get; set; }

    [Column("nombre_empresa")]
    [StringLength(150)]
    [Unicode(false)]
    public string NombreEmpresa { get; set; } = null!;

    [Column("direccion")]
    [StringLength(255)]
    [Unicode(false)]
    public string Direccion { get; set; } = null!;

    [Column("correo")]
    [StringLength(150)]
    [Unicode(false)]
    public string Correo { get; set; } = null!;

    [Column("telefono")]
    [StringLength(20)]
    [Unicode(false)]
    public string Telefono { get; set; } = null!;

    [Column("nombre_agente")]
    [StringLength(150)]
    [Unicode(false)]
    public string NombreAgente { get; set; } = null!;

    [Column("telefono_agente")]
    [StringLength(20)]
    [Unicode(false)]
    public string TelefonoAgente { get; set; } = null!;

    [Column("monto_minimo_compra", TypeName = "decimal(10, 2)")]
    public decimal MontoMinimoCompra { get; set; }

    [InverseProperty("IdProveedorNavigation")]
    public virtual ICollection<Entrada> Entrada { get; set; } = new List<Entrada>();
}

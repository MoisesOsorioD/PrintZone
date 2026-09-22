using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LibreriaPrintZone.Models;

public partial class Entrada
{
    [Key]
    [Column("id_entrada")]
    public int IdEntrada { get; set; }

    [Column("fecha_entrada", TypeName = "datetime")]
    public DateTime FechaEntrada { get; set; }

    [Column("cantidad")]
    public int Cantidad { get; set; }

    [Column("costo_lote", TypeName = "decimal(10, 2)")]
    public decimal CostoLote { get; set; }

    [Column("id_proveedor")]
    public int IdProveedor { get; set; }

    [Column("id_producto")]
    public int IdProducto { get; set; }

    [ForeignKey("IdProducto")]
    [InverseProperty("Entrada")]
    public virtual Producto IdProductoNavigation { get; set; } = null!;

    [ForeignKey("IdProveedor")]
    [InverseProperty("Entrada")]
    public virtual Proveedore IdProveedorNavigation { get; set; } = null!;
}

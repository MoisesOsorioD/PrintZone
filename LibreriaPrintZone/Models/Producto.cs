using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LibreriaPrintZone.Models;

public partial class Producto
{
    [Key]
    [Column("id_producto")]
    public int IdProducto { get; set; }

    [Column("nombre")]
    [StringLength(255)]
    [Unicode(false)]
    public string Nombre { get; set; } = null!;

    [Column("descripcion")]
    [StringLength(255)]
    [Unicode(false)]
    public string Descripcion { get; set; } = null!;

    [Column("marca")]
    [StringLength(100)]
    [Unicode(false)]
    public string Marca { get; set; } = null!;

    [Column("precio_compra", TypeName = "decimal(10, 2)")]
    public decimal PrecioCompra { get; set; }

    [Column("precio_venta", TypeName = "decimal(10, 2)")]
    public decimal PrecioVenta { get; set; }

    [Column("codigo_barras")]
    [StringLength(100)]
    [Unicode(false)]
    public string CodigoBarras { get; set; } = null!;

    [Column("stock_actual")]
    public int StockActual { get; set; }

    [Column("stock_minimo")]
    public int StockMinimo { get; set; }

    [Column("id_categoria")]
    public int IdCategoria { get; set; }

    [Column("activo")]
    public bool Activo { get; set; }

    [InverseProperty("IdProductoNavigation")]
    public virtual ICollection<Entrada> Entrada { get; set; } = new List<Entrada>();

    [ForeignKey("IdCategoria")]
    [InverseProperty("Productos")]
    public virtual Categoria IdCategoriaNavigation { get; set; } = null!;

    [InverseProperty("IdProductoNavigation")]
    public virtual ICollection<Salida> Salida { get; set; } = new List<Salida>();
}

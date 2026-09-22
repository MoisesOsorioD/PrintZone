using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace LibreriaPrintZone.Models;

public partial class InventarioPrintzoneContext : DbContext
{
    public InventarioPrintzoneContext()
    {
    }

    public InventarioPrintzoneContext(DbContextOptions<InventarioPrintzoneContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Categoria> Categorias { get; set; }

    public virtual DbSet<Entrada> Entradas { get; set; }

    public virtual DbSet<Producto> Productos { get; set; }

    public virtual DbSet<Proveedore> Proveedores { get; set; }

    public virtual DbSet<Salida> Salidas { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=ELMK;Database=Inventario_Printzone;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Categoria>(entity =>
        {
            entity.HasKey(e => e.IdCategoria).HasName("PK__Categori__CD54BC5ADC38E63D");
        });

        modelBuilder.Entity<Entrada>(entity =>
        {
            entity.HasKey(e => e.IdEntrada).HasName("PK__Entradas__167CD61B9685C20D");

            entity.Property(e => e.FechaEntrada).HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.IdProductoNavigation).WithMany(p => p.Entrada)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Entradas_Producto");

            entity.HasOne(d => d.IdProveedorNavigation).WithMany(p => p.Entrada)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Entradas_Proveedor");
        });

        modelBuilder.Entity<Producto>(entity =>
        {
            entity.HasKey(e => e.IdProducto).HasName("PK__Producto__FF341C0D75007661");

            entity.Property(e => e.Activo).HasDefaultValue(true);

            entity.HasOne(d => d.IdCategoriaNavigation).WithMany(p => p.Productos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Productos_Categorias");
        });

        modelBuilder.Entity<Proveedore>(entity =>
        {
            entity.HasKey(e => e.IdProveedor).HasName("PK__Proveedo__8D3DFE286530EE8A");
        });

        modelBuilder.Entity<Salida>(entity =>
        {
            entity.HasKey(e => e.IdSalida).HasName("PK__Salidas__BBF81F20F5DEE43F");

            entity.Property(e => e.FechaSalida).HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.IdProductoNavigation).WithMany(p => p.Salida)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Salidas_Producto");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.Salida)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Salidas_Usuario");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.IdUsuario).HasName("PK__Usuarios__4E3E04ADB0CA86A4");

            entity.Property(e => e.Activo).HasDefaultValue(true);
            entity.Property(e => e.FechaCreacion).HasDefaultValueSql("(getdate())");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

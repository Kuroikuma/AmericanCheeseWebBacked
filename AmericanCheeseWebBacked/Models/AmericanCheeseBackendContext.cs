using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace AmericanCheeseWebBacked.Models
{
    public partial class AmericanCheeseBackendContext : DbContext
    {
        public AmericanCheeseBackendContext()
        {
        }

        public AmericanCheeseBackendContext(DbContextOptions<AmericanCheeseBackendContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Administrador> Administrador { get; set; }
        public virtual DbSet<Categoria> Categoria { get; set; }
        public virtual DbSet<CrearProducto> CrearProducto { get; set; }
        public virtual DbSet<Empleado> Empleado { get; set; }
        public virtual DbSet<Factura> Factura { get; set; }
        public virtual DbSet<FacturaDetalle> FacturaDetalle { get; set; }
        public virtual DbSet<Ingredientes> Ingredientes { get; set; }
        public virtual DbSet<Producto> Producto { get; set; }

     

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Administrador>(entity =>
            {
                entity.HasKey(e => e.IdAdministrador);

                entity.ToTable("administrador");

                entity.Property(e => e.IdAdministrador).HasColumnName("idAdministrador");

                entity.Property(e => e.Apellido)
                    .HasColumnName("apellido")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Contraseña)
                    .HasColumnName("contraseña")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Usuario)
                    .HasColumnName("usuario")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Categoria>(entity =>
            {
                entity.HasKey(e => e.IdCategoria);

                entity.ToTable("categoria");

                entity.Property(e => e.IdCategoria).HasColumnName("idCategoria");

                entity.Property(e => e.Descripcion)
                    .HasColumnName("descripcion")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CrearProducto>(entity =>
            {
                entity.HasKey(e => e.IdCrearProducto);

                entity.ToTable("crearProducto");

                entity.Property(e => e.IdCrearProducto).HasColumnName("idCrearProducto");

                entity.Property(e => e.CantidadIngrediente)
                    .HasColumnName("cantidadIngrediente")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.IdIngrediente).HasColumnName("idIngrediente");

                entity.Property(e => e.IdProducto).HasColumnName("idProducto");

                entity.Property(e => e.PrecioIngrediente)
                    .HasColumnName("precioIngrediente")
                    .HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.IdIngredienteNavigation)
                    .WithMany(p => p.CrearProducto)
                    .HasForeignKey(d => d.IdIngrediente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ingredientes_idIngrediente");

                entity.HasOne(d => d.IdProductoNavigation)
                    .WithMany(p => p.CrearProducto)
                    .HasForeignKey(d => d.IdProducto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_crearProducto_idProducto");
            });

            modelBuilder.Entity<Empleado>(entity =>
            {
                entity.HasKey(e => e.IdEmpleado);

                entity.ToTable("empleado");

                entity.Property(e => e.IdEmpleado).HasColumnName("idEmpleado");

                entity.Property(e => e.Apellido)
                    .IsRequired()
                    .HasColumnName("apellido")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Contraseña)
                    .HasColumnName("contraseña")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Usuario)
                    .HasColumnName("usuario")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Factura>(entity =>
            {
                entity.HasKey(e => e.IdFactura);

                entity.ToTable("factura");

                entity.Property(e => e.IdFactura).HasColumnName("idFactura");

                entity.Property(e => e.Cliente)
                    .HasColumnName("cliente")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdEmpleado).HasColumnName("idEmpleado");

                entity.Property(e => e.Total)
                    .HasColumnName("total")
                    .HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.IdEmpleadoNavigation)
                    .WithMany(p => p.Factura)
                    .HasForeignKey(d => d.IdEmpleado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_factura_idEmpleado");
            });

            modelBuilder.Entity<FacturaDetalle>(entity =>
            {
                entity.HasKey(e => new { e.IdProducto, e.IdFactura })
                    .IsClustered(false);

                entity.ToTable("facturaDetalle");

                entity.Property(e => e.IdProducto).HasColumnName("idProducto");

                entity.Property(e => e.IdFactura).HasColumnName("idFactura");

                entity.Property(e => e.CantidadVendido)
                    .HasColumnName("cantidadVendido")
                    .HasColumnType("decimal(7, 2)");

                entity.Property(e => e.PrecioProducto)
                    .HasColumnName("precioProducto")
                    .HasColumnType("decimal(7, 2)");

                entity.Property(e => e.Total)
                    .HasColumnName("total")
                    .HasColumnType("decimal(7, 2)");
            });

            modelBuilder.Entity<Ingredientes>(entity =>
            {
                entity.HasKey(e => e.IdIngrediente);

                entity.ToTable("ingredientes");

                entity.Property(e => e.IdIngrediente).HasColumnName("idIngrediente");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Precio)
                    .HasColumnName("precio")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Stock).HasColumnName("stock");
            });

            modelBuilder.Entity<Producto>(entity =>
            {
                entity.HasKey(e => e.IdProducto);

                entity.ToTable("producto");

                entity.Property(e => e.IdProducto).HasColumnName("idProducto");

                entity.Property(e => e.IdCategoria).HasColumnName("idCategoria");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Precio)
                    .HasColumnName("precio")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Tamaño)
                    .HasColumnName("tamaño")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Imagen)
                    .HasColumnName("imagen")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdCategoriaNavigation)
                    .WithMany(p => p.Producto)
                    .HasForeignKey(d => d.IdCategoria)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_producto_idCategoria");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

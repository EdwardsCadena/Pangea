using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Contrato.Models
{
    public partial class edwardContext : DbContext
    {
        public edwardContext()
        {
        }

        public edwardContext(DbContextOptions<edwardContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<ContratoServicio> ContratoServicios { get; set; }
        public virtual DbSet<Producto> Productos { get; set; }
        public virtual DbSet<VwContrato> VwContratos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=181.60.98.183,11533;DataBase=edward;user=sa;password=Pangea2019*#");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.HasKey(e => e.IdCliente)
                    .HasName("PK__Cliente__D5946642872D3F1C");

                entity.ToTable("Cliente");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnType("datetime")
                    .HasColumnName("Fecha_Creacion");

                entity.Property(e => e.FechaModificacion)
                    .HasColumnType("datetime")
                    .HasColumnName("Fecha_Modificacion");

                entity.Property(e => e.FkRowId).HasColumnName("Fk_RowID");

                entity.Property(e => e.Identificacion)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RazonSocial)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Razon_Social");

                entity.Property(e => e.TipoIdentificacion)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("Tipo_Identificacion")
                    .IsFixedLength(true);

                entity.Property(e => e.UsuarioCreacion)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Usuario_Creacion");

                entity.Property(e => e.UsuarioModificacion)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Usuario_Modificacion");
            });

            modelBuilder.Entity<ContratoServicio>(entity =>
            {
                entity.HasKey(e => e.IdContrato)
                    .HasName("PK__Contrato__8569F05AF93ACBAE");

                entity.ToTable("ContratoServicio");

                entity.Property(e => e.ClaveLicencia)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("Clave_Licencia");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnType("datetime")
                    .HasColumnName("Fecha_Creacion");

                entity.Property(e => e.FechaLicencia)
                    .HasColumnType("datetime")
                    .HasColumnName("Fecha_Licencia");

                entity.Property(e => e.FechaModificacion)
                    .HasColumnType("datetime")
                    .HasColumnName("Fecha_Modificacion");

                entity.Property(e => e.FkIdCliente).HasColumnName("Fk_IdCliente");

                entity.Property(e => e.FkIdProducto).HasColumnName("Fk_IdProducto");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroLicencia)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("Numero_Licencia");

                entity.Property(e => e.UsuarioCreacion)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Usuario_Creacion");

                entity.Property(e => e.UsuarioModificacion)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Usuario_Modificacion");

                entity.HasOne(d => d.FkIdClienteNavigation)
                    .WithMany(p => p.ContratoServicios)
                    .HasForeignKey(d => d.FkIdCliente)
                    .HasConstraintName("FK__ContratoS__Fk_Id__3B75D760");

                entity.HasOne(d => d.FkIdProductoNavigation)
                    .WithMany(p => p.ContratoServicios)
                    .HasForeignKey(d => d.FkIdProducto)
                    .HasConstraintName("FK__ContratoS__Usuar__3A81B327");
            });

            modelBuilder.Entity<Producto>(entity =>
            {
                entity.HasKey(e => e.IdProducto)
                    .HasName("PK__Producto__09889210EB19F629");

                entity.ToTable("Producto");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCreacion)
                    .HasColumnType("datetime")
                    .HasColumnName("Fecha_Creacion");

                entity.Property(e => e.FechaModificacion)
                    .HasColumnType("datetime")
                    .HasColumnName("Fecha_Modificacion");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Precio).HasColumnType("money");

                entity.Property(e => e.UsuarioCreacion)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Usuario_Creacion");

                entity.Property(e => e.UsuarioModificacion)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Usuario_Modificacion");
            });

            modelBuilder.Entity<VwContrato>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Vw_Contrato");

                entity.Property(e => e.ClaveLicencia)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("Clave_Licencia");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnType("datetime")
                    .HasColumnName("Fecha_Creacion");

                entity.Property(e => e.FechaLicencia)
                    .HasColumnType("datetime")
                    .HasColumnName("Fecha_Licencia");

                entity.Property(e => e.FechaModificacion)
                    .HasColumnType("datetime")
                    .HasColumnName("Fecha_Modificacion");

                entity.Property(e => e.IdentificacionCliente)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.NombreContrato)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Nombreproducto)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroLicencia)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("Numero_Licencia");

                entity.Property(e => e.Precio).HasColumnType("money");

                entity.Property(e => e.UsuarioCreacion)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Usuario_Creacion");

                entity.Property(e => e.UsuarioModificacion)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Usuario_Modificacion");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Garsonum_API_MVC.Models
{
    public partial class GarsonumContext : DbContext
    {
        public GarsonumContext()
        {
        }

        public GarsonumContext(DbContextOptions<GarsonumContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cafe> Cafe { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Has> Has { get; set; }
        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<Table> Table { get; set; }
        public virtual DbSet<User> User { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=tcp:garsonum.database.windows.net,1433;Initial Catalog=Garsonum;Persist Security Info=False;User ID=Garsonum;Password=grsnm96bMe.;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;Database=Garsonum;Trusted_Connection=False;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cafe>(entity =>
            {
                entity.HasKey(e => e.CId);

                entity.Property(e => e.CId).HasColumnName("c_id");

                entity.Property(e => e.Address)
                    .HasColumnName("address")
                    .HasMaxLength(200);

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(50);

                entity.Property(e => e.Image)
                    .HasColumnName("image")
                    .HasMaxLength(50);

                entity.Property(e => e.Info)
                    .HasColumnName("info")
                    .HasMaxLength(500);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(50);

                entity.Property(e => e.Password)
                    .HasColumnName("password")
                    .HasMaxLength(50);

                entity.Property(e => e.QrId)
                    .IsRequired()
                    .HasColumnName("qr_id")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.HasKey(e => e.CatId);

                entity.Property(e => e.CatId).HasColumnName("cat_id");

                entity.Property(e => e.CId).HasColumnName("c_id");

                entity.Property(e => e.CatName)
                    .HasColumnName("cat_name")
                    .HasMaxLength(100);

                entity.HasOne(d => d.C)
                    .WithMany(p => p.Category)
                    .HasForeignKey(d => d.CId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Cafe1");
            });

            modelBuilder.Entity<Has>(entity =>
            {
                entity.HasKey(e => new { e.UId, e.OId, e.PId });

                entity.Property(e => e.UId).HasColumnName("u_id");

                entity.Property(e => e.OId).HasColumnName("o_id");

                entity.Property(e => e.PId).HasColumnName("p_id");

                entity.Property(e => e.PAmount).HasColumnName("p_amount");

                entity.Property(e => e.PPortion).HasColumnName("p_portion");

                entity.HasOne(d => d.O)
                    .WithMany(p => p.Has)
                    .HasForeignKey(d => d.OId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Has_Order");

                entity.HasOne(d => d.P)
                    .WithMany(p => p.Has)
                    .HasForeignKey(d => d.PId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Has_Product");

                entity.HasOne(d => d.U)
                    .WithMany(p => p.Has)
                    .HasForeignKey(d => d.UId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Has_Product1");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.HasKey(e => e.OId);

                entity.Property(e => e.OId).HasColumnName("o_id");

                entity.Property(e => e.PaidInfo).HasColumnName("paid_info");

                entity.Property(e => e.TotalPrice).HasColumnName("total_price");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.PId);

                entity.Property(e => e.PId).HasColumnName("p_id");

                entity.Property(e => e.CatId).HasColumnName("cat_id");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .HasMaxLength(500);

                entity.Property(e => e.PImage)
                    .HasColumnName("p_image")
                    .HasMaxLength(100);

                entity.Property(e => e.PName)
                    .HasColumnName("p_name")
                    .HasMaxLength(50);

                entity.Property(e => e.PType).HasColumnName("p_type");

                entity.Property(e => e.Price).HasColumnName("price");

                entity.HasOne(d => d.Cat)
                    .WithMany(p => p.Product)
                    .HasForeignKey(d => d.CatId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Product_Category");
            });

            modelBuilder.Entity<Table>(entity =>
            {
                entity.HasKey(e => e.TId);

                entity.Property(e => e.TId).HasColumnName("t_id");

                entity.Property(e => e.CId).HasColumnName("c_id");

                entity.Property(e => e.Enable).HasColumnName("enable");

                entity.Property(e => e.TName)
                    .HasColumnName("t_name")
                    .HasMaxLength(50);

                entity.Property(e => e.Type).HasColumnName("type");

                entity.HasOne(d => d.C)
                    .WithMany(p => p.Table)
                    .HasForeignKey(d => d.CId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Cafe");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.UId);

                entity.Property(e => e.UId)
                    .HasColumnName("u_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.City)
                    .HasColumnName("city")
                    .HasMaxLength(25);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasMaxLength(50);

                entity.Property(e => e.Firstname)
                    .IsRequired()
                    .HasColumnName("firstname")
                    .HasMaxLength(50);

                entity.Property(e => e.Lastname)
                    .IsRequired()
                    .HasColumnName("lastname")
                    .HasMaxLength(50);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password")
                    .HasMaxLength(50);

                entity.Property(e => e.TId).HasColumnName("t_id");

                entity.HasOne(d => d.T)
                    .WithMany(p => p.User)
                    .HasForeignKey(d => d.TId)
                    .HasConstraintName("FK_User_Table");
            });
        }
    }
}

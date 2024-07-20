using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DTO.Models
{
    public partial class SOF205_finalContext : DbContext
    {
        public SOF205_finalContext()
        {
        }

        public SOF205_finalContext(DbContextOptions<SOF205_finalContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CuaHang> CuaHangs { get; set; } = null!;
        public virtual DbSet<Dongvat> Dongvats { get; set; } = null!;
        public virtual DbSet<HocSinh> HocSinhs { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-Q6N4J46;Database=SOF205_final;User Id=sa;Password=123456;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CuaHang>(entity =>
            {
                entity.HasKey(e => e.Ma)
                    .HasName("PK__CuaHang__3214CC9FBBE8DEEF");

                entity.ToTable("CuaHang");

                entity.Property(e => e.Ma)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LoaiHang).HasMaxLength(50);

                entity.Property(e => e.Mota).HasMaxLength(50);
            });

            modelBuilder.Entity<Dongvat>(entity =>
            {
                entity.HasKey(e => e.Ma)
                    .HasName("PK__Dongvat__3214CC9F98FC62C9");

                entity.ToTable("Dongvat");

                entity.Property(e => e.Ma)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Mota).HasMaxLength(50);

                entity.Property(e => e.ThucAn).HasMaxLength(50);
            });

            modelBuilder.Entity<HocSinh>(entity =>
            {
                entity.HasKey(e => e.Ma)
                    .HasName("PK__HocSinh__3214CC9F4AFA5076");

                entity.ToTable("HocSinh");

                entity.Property(e => e.Ma)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Nganh).HasMaxLength(50);

                entity.Property(e => e.Ten).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

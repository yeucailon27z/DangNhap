using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace luyentapC_2.Models
{
    public partial class NET1021_Final2Context : DbContext
    {
        public NET1021_Final2Context()
        {
        }

        public NET1021_Final2Context(DbContextOptions<NET1021_Final2Context> options)
            : base(options)
        {
        }

        public virtual DbSet<NguoiLd> NguoiLds { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-Q6N4J46;Database=NET1021_Final2;User Id=sa;Password=123456;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<NguoiLd>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("NguoiLD");

                entity.Property(e => e.Gioitinh).HasColumnName("gioitinh");

                entity.Property(e => e.Nganh)
                    .HasMaxLength(50)
                    .HasColumnName("nganh");

                entity.Property(e => e.Ten)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ten");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

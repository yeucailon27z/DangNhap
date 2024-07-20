using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DTO.Models
{
    public partial class QLthucungContext : DbContext
    {
        public QLthucungContext()
        {
        }

        public QLthucungContext(DbContextOptions<QLthucungContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Dsthucung> Dsthucungs { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-Q6N4J46;Database=QLthucung;User Id=sa;Password=123456;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Dsthucung>(entity =>
            {
                entity.HasKey(e => e.Stt)
                    .HasName("PK__dsthucun__CA1EB69076FADF99");

                entity.ToTable("dsthucung");

                entity.Property(e => e.Stt)
                    .ValueGeneratedNever()
                    .HasColumnName("STT");

                entity.Property(e => e.Loai).HasMaxLength(20);

                entity.Property(e => e.Maulong).HasMaxLength(20);

                entity.Property(e => e.Ten).HasMaxLength(20);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

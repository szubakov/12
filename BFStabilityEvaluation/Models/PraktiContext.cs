using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace BFStabilityEvaluation.Models
{
    public partial class PraktiContext : DbContext
    {
        public PraktiContext()
        {
        }

        public PraktiContext(DbContextOptions<PraktiContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Parameter> Parameters { get; set; }
        public virtual DbSet<ParameterValue> ParameterValues { get; set; }
        public virtual DbSet<StabilitySign> StabilitySigns { get; set; }
        public virtual DbSet<StabilitySignKriterium> StabilitySignKriteria { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=MSI ;initial catalog=Prakti; trusted_connection=yes;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Cyrillic_General_CI_AS");

            modelBuilder.Entity<Parameter>(entity =>
            {
                entity.HasKey(e => e.IdParam)
                    .HasName("PK__Paramete__FD2AA0F98CC29996");

                entity.ToTable("Parameter");

                entity.Property(e => e.IdParam).HasColumnName("ID_param");

                entity.Property(e => e.Alias)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.MinValue).HasColumnName("MinValue_");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Unit)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Unit_");
            });

            modelBuilder.Entity<ParameterValue>(entity =>
            {
                entity.HasKey(e => e.IdPValue);

                entity.ToTable("ParameterValue");

                entity.Property(e => e.IdPValue).HasColumnName("ID_pValue");

                entity.Property(e => e.IdParam).HasColumnName("ID_param");

                entity.Property(e => e.Npech).HasColumnName("NPech_");

                entity.Property(e => e.TimeStamp).HasColumnType("date");

                entity.HasOne(d => d.IdParamNavigation)
                    .WithMany(p => p.ParameterValues)
                    .HasForeignKey(d => d.IdParam)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Parameter__ID_pa__1273C1CD");
            });

            modelBuilder.Entity<StabilitySign>(entity =>
            {
                entity.HasKey(e => e.IdstabPokaz)
                    .HasName("PK__Stabilit__1EEBF21482C3EADF");

                entity.ToTable("StabilitySign");

                entity.Property(e => e.IdstabPokaz).HasColumnName("IDstabPokaz");

                entity.Property(e => e.Alias)
                    .IsRequired()
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<StabilitySignKriterium>(entity =>
            {
                entity.ToTable("_StabilitySignKriteria");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IdParam).HasColumnName("ID_param");

                entity.Property(e => e.IdstabPokaz).HasColumnName("IDstabPokaz");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Npech).HasColumnName("NPech_");

                entity.Property(e => e.Rang).HasColumnName("Rang_");

                entity.Property(e => e.Unit)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasColumnName("Unit_");

                entity.HasOne(d => d.IdParamNavigation)
                    .WithMany(p => p.StabilitySignKriteria)
                    .HasForeignKey(d => d.IdParam)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK___Stabilit__ID_pa__182C9B23");

                entity.HasOne(d => d.IdstabPokazNavigation)
                    .WithMany(p => p.StabilitySignKriteria)
                    .HasForeignKey(d => d.IdstabPokaz)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK___Stabilit__IDsta__173876EA");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.CodeUser);

                entity.Property(e => e.CodeUser).ValueGeneratedOnAdd();

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength(true);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

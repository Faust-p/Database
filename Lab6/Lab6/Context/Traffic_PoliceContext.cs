using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Lab6.Context
{
    public partial class Traffic_PoliceContext : DbContext
    {
        public Traffic_PoliceContext()
        {
        }

        public Traffic_PoliceContext(DbContextOptions<Traffic_PoliceContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Car> Cars { get; set; } = null!;
        public virtual DbSet<Driver> Drivers { get; set; } = null!;
        public virtual DbSet<Penalty> Penalties { get; set; } = null!;
        public virtual DbSet<Violation> Violations { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=.\\;Initial Catalog=Traffic_Police;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>(entity =>
            {
                entity.HasKey(e => new { e.CarId, e.DriverId })
                    .HasName("PK__Car__5D7F4B78237CD8AC");

                entity.ToTable("Car");

                entity.Property(e => e.CarId).HasColumnName("Car_id");

                entity.Property(e => e.DriverId).HasColumnName("Driver_id");

                entity.Property(e => e.Brand)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PlateNumber)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Plate_Number");

                entity.HasOne(d => d.Driver)
                    .WithMany(p => p.Cars)
                    .HasForeignKey(d => d.DriverId)
                    .HasConstraintName("fk_Driver_id2");
            });

            modelBuilder.Entity<Driver>(entity =>
            {
                entity.ToTable("Driver");

                entity.Property(e => e.DriverId)
                    .ValueGeneratedNever()
                    .HasColumnName("Driver_id");

                entity.Property(e => e.Adress)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("First_Name");

                entity.Property(e => e.LastName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Last_Name");

                entity.Property(e => e.LicenseNumber)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("License_Number");

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("Phone_Number");
            });

            modelBuilder.Entity<Penalty>(entity =>
            {
                entity.HasKey(e => new { e.PenaltyId, e.DriverId, e.ViolationId })
                    .HasName("PK__Penalty__F8FD29DDDC0340BB");

                entity.ToTable("Penalty");

                entity.Property(e => e.PenaltyId).HasColumnName("Penalty_id");

                entity.Property(e => e.DriverId).HasColumnName("Driver_id");

                entity.Property(e => e.ViolationId).HasColumnName("Violation_id");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.HasOne(d => d.Driver)
                    .WithMany(p => p.Penalties)
                    .HasForeignKey(d => d.DriverId)
                    .HasConstraintName("fk_Driver_id");

                entity.HasOne(d => d.Violation)
                    .WithMany(p => p.Penalties)
                    .HasForeignKey(d => d.ViolationId)
                    .HasConstraintName("fk_Violation_id");
            });

            modelBuilder.Entity<Violation>(entity =>
            {
                entity.ToTable("Violation");

                entity.Property(e => e.ViolationId)
                    .ValueGeneratedNever()
                    .HasColumnName("Violation_id");

                entity.Property(e => e.Fine).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.ViolationName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Violation_Name");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

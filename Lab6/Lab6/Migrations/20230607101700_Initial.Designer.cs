﻿// <auto-generated />
using System;
using Lab6.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Lab6.Migrations
{
    [DbContext(typeof(Traffic_PoliceContext))]
    [Migration("20230607101700_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Lab6.Context.Car", b =>
                {
                    b.Property<int>("CarId")
                        .HasColumnType("int")
                        .HasColumnName("Car_id");

                    b.Property<int>("DriverId")
                        .HasColumnType("int")
                        .HasColumnName("Driver_id");

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("PlateNumber")
                        .IsRequired()
                        .HasMaxLength(8)
                        .IsUnicode(false)
                        .HasColumnType("varchar(8)")
                        .HasColumnName("Plate_Number");

                    b.HasKey("CarId", "DriverId")
                        .HasName("PK__Car__5D7F4B78237CD8AC");

                    b.HasIndex("DriverId");

                    b.ToTable("Car", (string)null);
                });

            modelBuilder.Entity("Lab6.Context.Driver", b =>
                {
                    b.Property<int>("DriverId")
                        .HasColumnType("int")
                        .HasColumnName("Driver_id");

                    b.Property<string>("Adress")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("First_Name");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("Last_Name");

                    b.Property<string>("LicenseNumber")
                        .IsRequired()
                        .HasMaxLength(8)
                        .IsUnicode(false)
                        .HasColumnType("varchar(8)")
                        .HasColumnName("License_Number");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(11)
                        .IsUnicode(false)
                        .HasColumnType("varchar(11)")
                        .HasColumnName("Phone_Number");

                    b.HasKey("DriverId");

                    b.ToTable("Driver", (string)null);
                });

            modelBuilder.Entity("Lab6.Context.Penalty", b =>
                {
                    b.Property<int>("PenaltyId")
                        .HasColumnType("int")
                        .HasColumnName("Penalty_id");

                    b.Property<int>("DriverId")
                        .HasColumnType("int")
                        .HasColumnName("Driver_id");

                    b.Property<int>("ViolationId")
                        .HasColumnType("int")
                        .HasColumnName("Violation_id");

                    b.Property<DateTime>("Date")
                        .HasColumnType("date");

                    b.HasKey("PenaltyId", "DriverId", "ViolationId")
                        .HasName("PK__Penalty__F8FD29DDDC0340BB");

                    b.HasIndex("DriverId");

                    b.HasIndex("ViolationId");

                    b.ToTable("Penalty", (string)null);
                });

            modelBuilder.Entity("Lab6.Context.Violation", b =>
                {
                    b.Property<int>("ViolationId")
                        .HasColumnType("int")
                        .HasColumnName("Violation_id");

                    b.Property<decimal?>("Fine")
                        .HasColumnType("decimal(10,2)");

                    b.Property<string>("ViolationName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("Violation_Name");

                    b.HasKey("ViolationId");

                    b.ToTable("Violation", (string)null);
                });

            modelBuilder.Entity("Lab6.Context.Car", b =>
                {
                    b.HasOne("Lab6.Context.Driver", "Driver")
                        .WithMany("Cars")
                        .HasForeignKey("DriverId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_Driver_id2");

                    b.Navigation("Driver");
                });

            modelBuilder.Entity("Lab6.Context.Penalty", b =>
                {
                    b.HasOne("Lab6.Context.Driver", "Driver")
                        .WithMany("Penalties")
                        .HasForeignKey("DriverId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_Driver_id");

                    b.HasOne("Lab6.Context.Violation", "Violation")
                        .WithMany("Penalties")
                        .HasForeignKey("ViolationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_Violation_id");

                    b.Navigation("Driver");

                    b.Navigation("Violation");
                });

            modelBuilder.Entity("Lab6.Context.Driver", b =>
                {
                    b.Navigation("Cars");

                    b.Navigation("Penalties");
                });

            modelBuilder.Entity("Lab6.Context.Violation", b =>
                {
                    b.Navigation("Penalties");
                });
#pragma warning restore 612, 618
        }
    }
}

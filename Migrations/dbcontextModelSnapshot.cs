﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ParkingSystemCore;

namespace ParkingSystemCore.Migrations
{
    [DbContext(typeof(dbcontext))]
    partial class dbcontextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ParkingSystemCore.backup", b =>
                {
                    b.Property<int>("sl")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("contactNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("cost")
                        .HasColumnType("float");

                    b.Property<DateTime>("date")
                        .HasColumnType("datetime2");

                    b.Property<double>("inTime")
                        .HasColumnType("float");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("outTime")
                        .HasColumnType("float");

                    b.Property<int>("slot")
                        .HasColumnType("int");

                    b.Property<string>("vehicleNo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("sl");

                    b.HasIndex("slot");

                    b.ToTable("Backups");
                });

            modelBuilder.Entity("ParkingSystemCore.details", b =>
                {
                    b.Property<string>("vehicleNo")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("Slot")
                        .HasColumnType("int");

                    b.Property<string>("contactNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("cost")
                        .HasColumnType("float");

                    b.Property<DateTime>("date")
                        .HasColumnType("datetime2");

                    b.Property<double>("inTime")
                        .HasColumnType("float");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("outTime")
                        .HasColumnType("float");

                    b.HasKey("vehicleNo");

                    b.HasIndex("Slot");

                    b.ToTable("Details");
                });

            modelBuilder.Entity("ParkingSystemCore.parkingslot", b =>
                {
                    b.Property<int>("sl")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("availability")
                        .HasColumnType("int");

                    b.Property<int>("floor")
                        .HasColumnType("int");

                    b.Property<string>("section")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("slot")
                        .HasColumnType("int");

                    b.HasKey("sl");

                    b.ToTable("Parkingslots");
                });

            modelBuilder.Entity("ParkingSystemCore.backup", b =>
                {
                    b.HasOne("ParkingSystemCore.parkingslot", "serialno")
                        .WithMany()
                        .HasForeignKey("slot")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ParkingSystemCore.details", b =>
                {
                    b.HasOne("ParkingSystemCore.parkingslot", "serialno")
                        .WithMany()
                        .HasForeignKey("Slot");
                });
#pragma warning restore 612, 618
        }
    }
}

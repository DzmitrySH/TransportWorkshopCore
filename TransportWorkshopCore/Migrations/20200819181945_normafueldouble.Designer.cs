﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TransportWorkshopCore.Data;

namespace TransportWorkshopCore.Migrations
{
    [DbContext(typeof(TransportWorkshopCoreContext))]
    [Migration("20200819181945_normafueldouble")]
    partial class normafueldouble
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TransportWorkshopCore.Models.AutoCar", b =>
                {
                    b.Property<int>("AutoCarId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DriverId")
                        .HasColumnType("int");

                    b.Property<int>("Harmfulness")
                        .HasColumnType("int");

                    b.Property<bool>("Injector")
                        .HasColumnType("bit");

                    b.Property<int>("Mileage")
                        .HasColumnType("int");

                    b.Property<string>("NameAuto")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<bool>("Navigation")
                        .HasColumnType("bit");

                    b.Property<int>("NormaFuelId")
                        .HasColumnType("int");

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasColumnType("nvarchar(12)")
                        .HasMaxLength(12);

                    b.Property<int>("TireId")
                        .HasColumnType("int");

                    b.Property<int>("TrailerId")
                        .HasColumnType("int");

                    b.Property<int>("TypeAutoId")
                        .HasColumnType("int");

                    b.Property<int>("TypeFuelId")
                        .HasColumnType("int");

                    b.HasKey("AutoCarId");

                    b.HasIndex("DriverId");

                    b.HasIndex("NormaFuelId");

                    b.HasIndex("TireId");

                    b.HasIndex("TrailerId");

                    b.HasIndex("TypeAutoId");

                    b.HasIndex("TypeFuelId");

                    b.ToTable("AutoCar");
                });

            modelBuilder.Entity("TransportWorkshopCore.Models.Balance", b =>
                {
                    b.Property<int>("BalanceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AutoCarId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("Leftovers")
                        .HasColumnType("int");

                    b.Property<int>("Sug")
                        .HasColumnType("int");

                    b.HasKey("BalanceId");

                    b.HasIndex("AutoCarId");

                    b.ToTable("Balance");
                });

            modelBuilder.Entity("TransportWorkshopCore.Models.Device", b =>
                {
                    b.Property<int>("DeviceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Harmfulness")
                        .HasColumnType("bit");

                    b.Property<string>("Namedevice")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<DateTime>("SumerTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("TireId")
                        .HasColumnType("int");

                    b.Property<int>("TypeFuelId")
                        .HasColumnType("int");

                    b.Property<int>("WinterTimeId")
                        .HasColumnType("int");

                    b.HasKey("DeviceId");

                    b.HasIndex("TireId");

                    b.HasIndex("TypeFuelId");

                    b.HasIndex("WinterTimeId");

                    b.ToTable("Device");
                });

            modelBuilder.Entity("TransportWorkshopCore.Models.Driver", b =>
                {
                    b.Property<int>("DriverId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Category")
                        .HasColumnType("int");

                    b.Property<string>("FirsLastMidName")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("RightsNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(15)")
                        .HasMaxLength(15);

                    b.HasKey("DriverId");

                    b.ToTable("Driver");
                });

            modelBuilder.Entity("TransportWorkshopCore.Models.Maintenance", b =>
                {
                    b.Property<int>("MaintenanceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AutoCarId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateTO")
                        .HasColumnType("datetime2");

                    b.Property<string>("TypeTO")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.HasKey("MaintenanceId");

                    b.HasIndex("AutoCarId");

                    b.ToTable("Maintenance");
                });

            modelBuilder.Entity("TransportWorkshopCore.Models.NormaFuel", b =>
                {
                    b.Property<int>("NormaFuelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Linear")
                        .HasColumnType("float");

                    b.Property<double>("Summer")
                        .HasColumnType("float");

                    b.Property<double>("Winter")
                        .HasColumnType("float");

                    b.HasKey("NormaFuelId");

                    b.ToTable("NormaFuel");
                });

            modelBuilder.Entity("TransportWorkshopCore.Models.Tire", b =>
                {
                    b.Property<int>("TireId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<int>("RunStart")
                        .HasColumnType("int");

                    b.HasKey("TireId");

                    b.ToTable("Tire");
                });

            modelBuilder.Entity("TransportWorkshopCore.Models.Trailer", b =>
                {
                    b.Property<int>("TrailerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Massa")
                        .HasColumnType("int");

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<int>("TireId")
                        .HasColumnType("int");

                    b.HasKey("TrailerId");

                    b.HasIndex("TireId");

                    b.ToTable("Trailer");
                });

            modelBuilder.Entity("TransportWorkshopCore.Models.TypeAuto", b =>
                {
                    b.Property<int>("TypeAutoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NameType")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("TypeAutoId");

                    b.ToTable("TypeAuto");
                });

            modelBuilder.Entity("TransportWorkshopCore.Models.TypeFuel", b =>
                {
                    b.Property<int>("TypeFuelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Cost")
                        .HasColumnType("float");

                    b.Property<string>("Fuel")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<DateTime>("ToDate")
                        .HasColumnType("datetime2");

                    b.HasKey("TypeFuelId");

                    b.ToTable("TypeFuel");
                });

            modelBuilder.Entity("TransportWorkshopCore.Models.WinterTime", b =>
                {
                    b.Property<int>("WinterTimeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateEnd")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateStart")
                        .HasColumnType("datetime2");

                    b.Property<double>("Temperature")
                        .HasColumnType("float");

                    b.Property<int>("WinterNorma")
                        .HasColumnType("int");

                    b.HasKey("WinterTimeId");

                    b.ToTable("WinterTime");
                });

            modelBuilder.Entity("TransportWorkshopCore.Models.AutoCar", b =>
                {
                    b.HasOne("TransportWorkshopCore.Models.Driver", "Driver")
                        .WithMany("AutoCars")
                        .HasForeignKey("DriverId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TransportWorkshopCore.Models.NormaFuel", "NormaFuel")
                        .WithMany("AutoCars")
                        .HasForeignKey("NormaFuelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TransportWorkshopCore.Models.Tire", "Tire")
                        .WithMany("AutoCars")
                        .HasForeignKey("TireId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TransportWorkshopCore.Models.Trailer", "Trailer")
                        .WithMany("AutoCars")
                        .HasForeignKey("TrailerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TransportWorkshopCore.Models.TypeAuto", "TypeAuto")
                        .WithMany("AutoCars")
                        .HasForeignKey("TypeAutoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TransportWorkshopCore.Models.TypeFuel", "TypeFuel")
                        .WithMany("AutoCars")
                        .HasForeignKey("TypeFuelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TransportWorkshopCore.Models.Balance", b =>
                {
                    b.HasOne("TransportWorkshopCore.Models.AutoCar", "AutoCar")
                        .WithMany("Balances")
                        .HasForeignKey("AutoCarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TransportWorkshopCore.Models.Device", b =>
                {
                    b.HasOne("TransportWorkshopCore.Models.Tire", "Tire")
                        .WithMany("Devices")
                        .HasForeignKey("TireId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TransportWorkshopCore.Models.TypeFuel", "TypeFuel")
                        .WithMany("Devices")
                        .HasForeignKey("TypeFuelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TransportWorkshopCore.Models.WinterTime", "WinterTime")
                        .WithMany("Devices")
                        .HasForeignKey("WinterTimeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TransportWorkshopCore.Models.Maintenance", b =>
                {
                    b.HasOne("TransportWorkshopCore.Models.AutoCar", "AutoCar")
                        .WithMany("Maintenances")
                        .HasForeignKey("AutoCarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TransportWorkshopCore.Models.Trailer", b =>
                {
                    b.HasOne("TransportWorkshopCore.Models.Tire", "Tire")
                        .WithMany("Trailers")
                        .HasForeignKey("TireId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}

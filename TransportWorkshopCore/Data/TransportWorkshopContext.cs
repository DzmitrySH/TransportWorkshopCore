using Microsoft.EntityFrameworkCore;
using System;
using TransportWorkshopCore.Models;

namespace TransportWorkshopCore.Data
{
    public class TransportWorkshopCoreContext : DbContext
    {
        public TransportWorkshopCoreContext(DbContextOptions<TransportWorkshopCoreContext> options) : base(options)
        { }

        public DbSet<AutoCar> AutoCars { get; set; }
        public DbSet<Balance> Balances { get; set; }
        public DbSet<Device> Devices { get; set; }
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Maintenance> Maintenances { get; set; }
        public DbSet<NormaFuel> NormaFuels { get; set; }
        public DbSet<Tire> Tires { get; set; }
        public DbSet<Trailer> Trailers { get; set; }
        public DbSet<TypeAuto> TypeAutos { get; set; }
        public DbSet<TypeFuel> TypeFuels { get; set; }
        public DbSet<WinterTime> WinterTimes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AutoCar>().ToTable("AutoCar");
            modelBuilder.Entity<Balance>().ToTable("Balance");
            modelBuilder.Entity<Device>().ToTable("Device");
            modelBuilder.Entity<Driver>().ToTable("Driver");
            modelBuilder.Entity<Maintenance>().ToTable("Maintenance");
            modelBuilder.Entity<NormaFuel>().ToTable("NormaFuel");
            modelBuilder.Entity<Tire>().ToTable("Tire");
            modelBuilder.Entity<Trailer>().ToTable("Trailer");
            modelBuilder.Entity<TypeAuto>().ToTable("TypeAuto");
            modelBuilder.Entity<TypeFuel>().ToTable("TypeFuel");
            modelBuilder.Entity<WinterTime>().ToTable("WinterTime");
        }
    }
}

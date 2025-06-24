using RideAggregatorApi.Models;
using System.Collections.Generic;
using System.Reflection.Emit;
using Microsoft.EntityFrameworkCore;
namespace RideAggregatorApi.Data
{
    public class RideDbContext : DbContext
    {
        

        public RideDbContext(DbContextOptions<RideDbContext> options) : base(options) { }
        public DbSet<User> Users { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Ride> Rides { get; set; }
        public DbSet<PickupDropRide> PickupDropRides { get; set; }
        public DbSet<RentalsRide> RentalsRides { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ride>()
                .HasDiscriminator<RideType>("RideType")
                .HasValue<Ride>(RideType.Base) 
                .HasValue<PickupDropRide>(RideType.PickupDrop)
                .HasValue<RentalsRide>(RideType.Rental);
            modelBuilder.Entity<User>().HasData(
    new User { Id = 1, Email = "Ameena@admin.com", Password = "admin123", Role = "Admin" },
    new User { Id = 2, Email = "Salwa@admin.com", Password = "admin456", Role = "Admin" },
    new User { Id = 3, Email = "rajeev@ride1.com", Password = "raid123", Role = "Customer" },
    new User { Id = 4, Email = "chinnu@ride2.com", Password = "raid456", Role = "Customer" },
    new User { Id = 5, Email = "harshi@ride3.com", Password = "raid789", Role = "Customer" }
);

        }


    }
}


using RideAggregatorApi.Models;
using System.Collections.Generic;
using System.Reflection.Emit;
using Microsoft.EntityFrameworkCore;
namespace RideAggregatorApi.Data
{
    public class RideDbContext : DbContext
    {
        public RideDbContext(DbContextOptions<RideDbContext> options) : base(options) { }

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
        }

    }
}


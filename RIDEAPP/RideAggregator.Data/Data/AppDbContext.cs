using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RideAggregator.core.Entities;

namespace RideAggregator.Data.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<User> Users { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<PickupDropRide> PickupDropRides { get; set; }
        public DbSet<RentalRide> RentalRides { get;set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("Users");
            modelBuilder.Entity<Customer>().ToTable("Customers");
            modelBuilder.Entity<Driver>().ToTable("Drivers");
            modelBuilder.Entity<Location>().ToTable("Locations");
            modelBuilder.Entity<PickupDropRide>().ToTable("PickupDropRides");
            modelBuilder.Entity<RentalRide>().ToTable("RentalRides");
        }
    }
}

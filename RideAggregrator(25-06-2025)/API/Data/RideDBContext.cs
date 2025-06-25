using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace RideAggregatorAPI.Data
{
    public class RideDBContext : DbContext
    {
        public DbSet<UserData> UserDatas { get; set; }
        public DbSet<DriverData> DriverDatas { get; set; }
        public DbSet<CustomerData> CustomerDatas { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<PickupRide> PickupRides { get; set; }
        public DbSet<RentalRide> RentalRides { get; set; }

        public RideDBContext(DbContextOptions opts) : base(opts)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Location>().HasIndex(p => p.LocationName).IsUnique(true);


        }
    }
}
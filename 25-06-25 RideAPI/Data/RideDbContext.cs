using Microsoft.EntityFrameworkCore;
using RideAggregator.Data;
using RideAggregatorAPI.Data;

namespace RideAggregator.Data
{
    
        public class RideDbContext : DbContext
        {
            public DbSet<AppUser> UserDatas { get; set; }
            public DbSet<Driver> DriverDatas { get; set; }
            public DbSet<Customer> CustomerDatas { get; set; }
            public DbSet<Location> Locations { get; set; }
            public DbSet<PickupDropRide> PickupRides { get; set; }
            public DbSet<RentalRide> RentalRides { get; set; }

            public RideDbContext(DbContextOptions opts) : base(opts)
            {

            }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                modelBuilder.Entity<Location>().HasIndex(p => p.LocationName).IsUnique(true);


            }


        }
}
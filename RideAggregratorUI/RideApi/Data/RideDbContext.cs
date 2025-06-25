using Microsoft.EntityFrameworkCore;

namespace RideApi.Data
{
    public class RideDbContext : DbContext
    {
        public DbSet<UserData> UserDatas { get; set; }
        public DbSet<DriverData> DriverDatas { get; set; }
        public DbSet<CustomerData> CustomerDatas { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<PickupRide> PickupRides { get; set; }
        public DbSet<RentalRides> RentalRides { get; set; }

        public RideDbContext(DbContextOptions opts) : base(opts)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Location>().HasIndex(p => p.LocationName).IsUnique(true);


        }

    }
}

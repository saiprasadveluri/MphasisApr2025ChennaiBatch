using Microsoft.EntityFrameworkCore;
using RideAggregatorAPI.Data;

namespace RideAggregatorAPI.Data.DBContext
{
    public class RideDBContext:DbContext
    {
        public DbSet<UserInfo> UserDatas { get; set; }
       
        public DbSet<DriverInfo> DriverDatas { get; set; }
        public DbSet<CustomerInfo> CustomerDatas { get; set; }
        public DbSet<LocationDTO> Locations { get; set; }
        public DbSet<PickupRide> PickupRides { get; set; }
        public DbSet<RentalRide> RentalRides { get; set; }

        public RideDBContext(DbContextOptions options)
    : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LocationDTO>().HasIndex(p => p.LocationName).IsUnique(true);


        }
    }
}

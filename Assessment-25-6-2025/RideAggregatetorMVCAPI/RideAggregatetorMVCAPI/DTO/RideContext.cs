using Microsoft.EntityFrameworkCore;

namespace RideAggregatetorMVCAPI.DTO
{
    public class RideContext:DbContext
    {
        public DbSet<UserInfo> UserInfos { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<RentalRide> rentalRides { get; set; }
        public DbSet<PickUpDropRide> pickUpDropRides { get; set; }
        public RideContext(DbContextOptions optionsBuilder) : base(optionsBuilder)
        {

        }
    }
}

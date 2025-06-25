using Microsoft.EntityFrameworkCore;

namespace RideAPI.Data
{
    public class RideDbContext:DbContext
    {
        public DbSet<Customer> customersList { get; set; }
        public DbSet<Driver> driverList { get; set; }
        public DbSet<Location> locationList { get; set; }
        public DbSet<PickupRide> pickupRideList { get;set; }
        public DbSet<RentalRide> rentalRideList { get; set;}
        public DbSet<UserData> userDataList { get; set; }
        public RideDbContext(DbContextOptions dbContextOptions):base(dbContextOptions)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Location>().HasIndex(l=>l.LocationName).IsUnique(true);
        }
    }
}

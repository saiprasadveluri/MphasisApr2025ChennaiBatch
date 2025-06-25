using Microsoft.EntityFrameworkCore;

namespace RideAggregatorAPI.Data
{
    public class RideDbContext:DbContext
    {
        internal object userdataList;

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<PickupRide> PickupRides { get; set; }
        public DbSet<RentalRide> Rentalrides { get; set; }
        public DbSet<User> User { get; set; }
        public RideDbContext(DbContextOptions dbContextOptions):base(dbContextOptions)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Location>().HasIndex(l => l.LocName).IsUnique(true);
        }



    }
}

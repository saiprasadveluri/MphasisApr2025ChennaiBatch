using Microsoft.EntityFrameworkCore;

namespace RideAggrigationAPI.Data
{
    public class RideAggrigateDbContext:DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Customer> Customers { get; set; }

        public DbSet<Location> Locations { get; set; }

        public DbSet<Rental> Rentals { get; set; }

        public DbSet<PicupDrop> PicupDrop { get; set; }

        public RideAggrigateDbContext(DbContextOptions<RideAggrigateDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Location>().HasIndex(p => p.LocationName).IsUnique(true);


        }
    }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using RideAggregatorWEBAPI.Data;


namespace RideAggregatorWEBAPI
{
    public class RideDbContext:DbContext
    {
        public RideDbContext(DbContextOptions<RideDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Location>()
           .HasIndex(l => l.LocationName)
           .IsUnique();

            // Disable cascade delete for SourceLocation
            modelBuilder.Entity<PickupDropRide>()
           .HasOne(p => p.SourceLocation)
           .WithMany()
           .HasForeignKey(p => p.SourceLocationId)
           .OnDelete(DeleteBehavior.Restrict);  // DeleteBehavior.NoAction

           // Disable cascade delete for DestinationLocation
           modelBuilder.Entity<PickupDropRide>()
          .HasOne(p => p.DestinationLocation)
          .WithMany()
          .HasForeignKey(p => p.DestinationLocationId)
          .OnDelete(DeleteBehavior.Restrict);

            base.OnModelCreating(modelBuilder);
        }
        public DbSet<UserInfo> Users { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<PickupDropRide> PickupDropRides { get; set; }
        public DbSet<RentalRide> RentalRides { get; set; }


    }
}

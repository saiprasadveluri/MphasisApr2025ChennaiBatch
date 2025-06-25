using Microsoft.EntityFrameworkCore;
using RideAggregatorCore.Models;


namespace RideAggregator.API.Data
{
    public class RideDbContext : DbContext
    {
        public RideDbContext(DbContextOptions<RideDbContext> options) : base(options) { }

        public DbSet<Location> Locations { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<PickupDropRide> PickupDropRides { get; set; }
        public DbSet<RentalsRide> RentalsRides { get; set; }
        public DbSet<UserAccount> UserAccounts { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<PickupDropRide>()
                .HasOne(p => p.SourceLocation)
                .WithMany()
                .HasForeignKey(p => p.SourceLocationId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<PickupDropRide>()
                .HasOne(p => p.DestinationLocation)
                .WithMany()
                .HasForeignKey(p => p.DestinationLocationId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
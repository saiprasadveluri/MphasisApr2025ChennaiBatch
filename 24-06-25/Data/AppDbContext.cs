using Microsoft.EntityFrameworkCore;
using RiderApp.Models;

namespace RiderApp.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<PicknDrop> PickupAndDrop { get; set; }
        public DbSet<Rental> rentals { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            // Customer
            modelBuilder.Entity<Customer>()
                .HasMany(c => c.PicknDrops)
                .WithOne(r => r.Customer)
                .HasForeignKey(r => r.CustomerId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Customer>()
                .HasMany(c => c.Rentals)
                .WithOne(r => r.Customer)
                .HasForeignKey(r => r.CustomerId)
                .OnDelete(DeleteBehavior.Cascade);

            // Driver
            modelBuilder.Entity<Driver>()
                .HasMany(d => d.PicknDrops)
                .WithOne(r => r.Driver)
                .HasForeignKey(r => r.DriverId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Driver>()
                .HasMany(d => d.Rentals)
                .WithOne(r => r.Driver)
                .HasForeignKey(r => r.DriverId)
                .OnDelete(DeleteBehavior.Cascade);

            // Location (dual relationship)
            modelBuilder.Entity<PicknDrop>()
                .HasOne(r => r.PickupLocation)
                .WithMany(l => l.PickupLocationRides)
                .HasForeignKey(r => r.PickupLocationId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<PicknDrop>()
                .HasOne(r => r.DropLocation)
                .WithMany(l => l.DropLocationRides)
                .HasForeignKey(r => r.DropLocationId)
                .OnDelete(DeleteBehavior.Restrict);

        }

    }
}

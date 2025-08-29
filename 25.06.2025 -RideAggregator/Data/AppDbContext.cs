using Microsoft.EntityFrameworkCore;
using RideAggregatorApp.Model;
namespace RideAggregatorApp.Data
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }   
        public DbSet<Customer>Customers { get; set; }
        public DbSet<Driver> Drivers { get; set; }  
        public DbSet<Location> Locations { get; set; }  
        public DbSet<PicknDrop>PickupAndDrop { get; set; } 
        public DbSet<Rental>rentals { get; set; }  
        public DbSet<Account> accounts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
                .HasMany(c => c.PicknDrops)
                .WithOne(d => d.Customer)
                .HasForeignKey(d => d.CustomerId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Customer>()
                .HasMany(c => c.Rentals)
             .WithOne(d => d.Customer)
             .HasForeignKey(d => d.CustomerId)
             .OnDelete(DeleteBehavior.Cascade);


            modelBuilder.Entity<Driver>()
                .HasMany(c => c.Pickdrops)
              .WithOne(d => d.Driver)
              .HasForeignKey(d => d.DriveId)
              .OnDelete(DeleteBehavior.Cascade);


            modelBuilder.Entity<Driver>()
                .HasMany(c => c.Rentals)
             .WithOne(d => d.Driver)
             .HasForeignKey(d => d.DriveId)
             .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<PicknDrop>()
                .HasOne(r => r.PickupLocation)
                .WithMany(l => l.PickupLocationRides)
                .HasForeignKey(d => d.PickupLocationId)
                         .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<PicknDrop>()
                .HasOne(c => c.PickupLocation)
                .WithMany(l=>l.PickupLocationRides)
                .HasForeignKey(d => d.PickupLocationId)
                         .OnDelete(DeleteBehavior.Restrict);
        }

    }
}
                                                                         
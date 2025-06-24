using Microsoft.EntityFrameworkCore;
namespace RideAppApi
{
    public class RideDbContext : DbContext
    {
        public RideDbContext(DbContextOptions options) : base(options) { 
        }

        public DbSet<Ride> Rides { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Location> locations { get; set; }
        public DbSet<PickUpDrop> pickups { get; set; }

        //    protected override void OnModelCreating(ModelBuilder modelBuilder)
        //    {

        //        modelBuilder.Entity<PickUpDrop>()
        //.HasOne(p => p.Driver)
        //.WithMany(d => d.pickDs) 
        //.HasForeignKey(p => p.DriverId)
        //.OnDelete(DeleteBehavior.NoAction);

        //        modelBuilder.Entity<Location>()
        //            .HasMany<PickUpDrop>(l => l.PickLoc)
        //            .WithOne()
        //            .HasForeignKey(p => p.PickLocId); 

        //        modelBuilder.Entity<Location>()
        //            .HasMany<PickUpDrop>(l => l.DropLoc)
        //            .WithOne() 
        //            .HasForeignKey(p => p.DropLocId);
        //        //base.OnModelCreating(modelBuilder);

        //        modelBuilder.Entity<PickUpDrop>()
        //.HasOne(p => p.PickLocation)
        //.WithMany(l => l.PickLoc)
        //.HasForeignKey(p => p.PickLocId)
        //.OnDelete(DeleteBehavior.NoAction); 
        //    }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    //base.OnModelCreating(modelBuilder);
        //    modelBuilder.Entity<Driver>().HasIndex(d => d.UserId).IsUnique(false);
        //}
    }
}

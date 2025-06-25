using Microsoft.EntityFrameworkCore;

namespace RideAppAgg
{
    public class RideAppDBContext : DbContext
    {
        public RideAppDBContext(DbContextOptions<RideAppDBContext> options)
            : base(options)
        {
        }

        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Ride> Rides { get; set; }
        public DbSet<PickupDrop> PickupDrops { get; set; }
        public DbSet<User> Users { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{

        //    modelBuilder.Entity<Ride>()
        //    .HasOne(r => r.PickupDrop)
        //    .WithOne(pd => pd.Ride)
        //    .HasForeignKey<PickupDrop>(pd => pd.RId);

        //    modelBuilder.Entity<PickupDrop>()
        //        .HasOne(p => p.Driver)
        //        .WithMany(d => d.PickD)
        //        .HasForeignKey(p => p.DriverId)
        //        .OnDelete(DeleteBehavior.NoAction);

        //    modelBuilder.Entity<Location>()
        //        .HasMany<PickupDrop>(l => l.PickupLocation)
        //        .WithOne()
        //        .HasForeignKey(p => p.PickupLocationId);

        //    modelBuilder.Entity<Location>()
        //        .HasMany<PickupDrop>(l => l.DropLocationId)
        //        .WithOne()
        //        .HasForeignKey(p => p.DropLocationId);
        //    //base.OnModelCreating(modelBuilder);

        //    modelBuilder.Entity<PickupDrop>()
        //    .HasOne(p => p.PickupLocation)
        //    .WithMany(l => l.PickupLocation)
        //    .HasForeignKey(p => p.PickLocId)
        //    .OnDelete(DeleteBehavior.NoAction);
        //}

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    // Ride to PickupDrop (One-to-One)
        //    //modelBuilder.Entity<Ride>()
        //    //    .HasOne(r => r.PickupDrop)
        //    //    .WithOne(pd => pd.Ride);
        //        //.HasForeignKey<Ride>(r => r.PId); // Ride should own the foreign key

        //    // PickupDrop to Driver (Many-to-One)
        //    modelBuilder.Entity<PickupDrop>()
        //        .HasOne(pd => pd.Driver)
        //        .WithMany(d => d.pickDs)
        //        .HasForeignKey(pd => pd.DId)
        //        .OnDelete(DeleteBehavior.NoAction);

        //    // PickupDrop to Customer (Many-to-One)
        //    modelBuilder.Entity<PickupDrop>()
        //        .HasOne(pd => pd.Customer)
        //        .WithMany()
        //        .HasForeignKey(pd => pd.CId)
        //        .OnDelete(DeleteBehavior.NoAction);

            //// Location as PickupLocation (One-to-Many)
            //modelBuilder.Entity<PickupDrop>()
            //    .HasOne(pd => pd.PickupLocation)
            //    .WithMany()
            //    .HasForeignKey(pd => pd.PickupLocation)
            //    .OnDelete(DeleteBehavior.NoAction);

            ////// Location as DropLocation (One-to-Many)
            //modelBuilder.Entity<PickupDrop>()
            //    .HasOne(pd => pd.DropLocation)
            //    .WithMany()
            //    .HasForeignKey(pd => pd.DropLocation)
            //    .OnDelete(DeleteBehavior.NoAction);


            
            // 1) PickupLocation relationship
            //modelBuilder.Entity<PickupDrop>()
            //  .HasOne(pd => pd.PickupLocation)       // nav on PickupDrop
            //  .WithMany()                            // no CLR collection on Location
            //  .HasForeignKey(pd => pd.PickupLocationId)
            //  .OnDelete(DeleteBehavior.Restrict);

            //// 2) DropLocation relationship
            //modelBuilder.Entity<PickupDrop>()
            //  .HasOne(pd => pd.DropLocation)         // second nav on PickupDrop
            //  .WithMany()                            // another “anonymous” collection
            //  .HasForeignKey(pd => pd.DropLocationId)
    
            //  .OnDelete(DeleteBehavior.Restrict);

            // …and your other mappings…
        


        // Driver to User (One-to-One or Many-to-One, depending on your logic)
        //modelBuilder.Entity<Driver>()
        //         .HasOne(d => d.User)
        //         .WithOne()
        //         .HasForeignKey<Driver>(d => d.UId)
        //         .OnDelete(DeleteBehavior.NoAction);

        //}

    }
}

   
   


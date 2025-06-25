//using System.Data.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using RideAggregatorAPI.Data;


namespace RideAggregatorAPI.Data
{
    public class RADBContext : DbContext
    {
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    //base.OnConfiguring(optionsBuilder);
        //    var configBuilder = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
        //    var configSection = configBuilder.GetSection("ConnectionStrings");
        //    var connectionString = configSection["SQLServerConnection"] ?? null;

        //    optionsBuilder.UseSqlServer(connectionString);

        //}
        public RADBContext(DbContextOptions opts) : base(opts)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LocationInfo>().HasIndex(p => p.LocationName).IsUnique(true);


        }
        public DbSet<LocationInfo> LocationInfos { get; set; }
        public DbSet<CustomerInfo> CustomerInfos { get; set; }
        public DbSet<DriverInfo> DriverInfos { get; set; } 
        public DbSet<UserInfo> UserInfos { get; set; }
        public DbSet<PickUpDropRide> pickUpDropRides { get; set; }
        public DbSet<RentalRides> RentalRides { get; set; }

    }
}

using Microsoft.EntityFrameworkCore;
using RideAggregateAPI.DTO;
namespace RideAggregateAPI.Data
{
    public class RADBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var configBuilder = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            var configSection = configBuilder.GetSection("ConnectionString");
            var connectionString = configSection["SqlServerConnection"] ?? null;
            optionsBuilder.UseSqlServer(connectionString);
        }
        public DbSet<CustomerInfo> CustomerInfo { get; set; }
        public DbSet<DriverInfo> DriverInfo { get; set; }
        public DbSet<Location> Location { get; set; }
        public DbSet<UserInfo> UserInfo { get; set; }
        public DbSet<PickUpDropLocation> PickUpDropLocation { get; set; }

        public RADBContext(DbContextOptions opts) : base(opts)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Location>().HasIndex(p => p.LocName).IsUnique(true);


        }

    }
}

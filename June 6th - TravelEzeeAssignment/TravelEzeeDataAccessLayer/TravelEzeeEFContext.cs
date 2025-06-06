using Microsoft.EntityFrameworkCore;
using TravelEzeeDataAccessLayer;




public class TravelEzeeEFContext : DbContext
{
    string ConString = "Data Source=.;Initial Catalog=TravelEzeeApp;Integrated Security=True;Trust Server Certificate=True";
    public DbSet<Location> locations{ get; set; }
    public DbSet<ServiceType> ServiceTypes { get; set; }
    public DbSet<Service> services{ get; set; }
    public DbSet<Booking> bookings{ get; set; }

    public TravelEzeeEFContext()
    {

    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Service>()
        .HasOne(srv => srv.Source).
        WithMany(loc => loc.SourceServiceList)
        .HasForeignKey(srv => srv.SourceLocationId)
        .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<Service>().HasOne(srv => srv.Destination)
        .WithMany(loc => loc.DestServiceList)
        .HasForeignKey(srv => srv.DestinationLocationId)
        .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<ServiceType>().HasIndex(st => st.ServiceTypeText).IsUnique();

        modelBuilder.Entity<Location>().HasData(
            new Location() { LocationId = 1, LocationName = "HYD" },
            new Location() { LocationId = 2, LocationName = "CHN" },
            new Location() { LocationId = 3, LocationName = "Mumbai" }
        );

        //modelBuilder.Entity<ServiceType>().HasData(
        //    new ServiceType() { ServiceTypeId = 1, ServiceTypeText = "Express",PricePerKm=12.50},
        //     new ServiceType() { ServiceTypeId = 2, ServiceTypeText = "Luxary",PricePerKm=18.50}            
        //);


        modelBuilder.Entity<ServiceType>().ToTable("ServiceType");


    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(ConString);
    }
}
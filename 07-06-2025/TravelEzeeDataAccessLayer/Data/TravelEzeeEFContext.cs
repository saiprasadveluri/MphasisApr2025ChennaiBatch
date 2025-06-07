using Microsoft.EntityFrameworkCore;
public class TravelEzeeEFContext : DbContext
{
    string ConString = "Data Source=.;Initial Catalog=Travel;Integrated Security=True;Trust Server Certificate=True";
    public DbSet<Location> locations { get; set; }
    public DbSet<ServiceType> ServiceTypes { get; set; }
    public DbSet<Service> Services { get; set; }
    public DbSet<Booking> bookings { get; set; }

    public TravelEzeeEFContext()
    {

    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Service>()
        .HasOne(srv => srv.Source)
        .WithMany(loc => loc.ServiceList)
        .HasForeignKey(srv => srv.SourceLocId)
        .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Service>()
        .HasOne(srv => srv.Destination)
        .WithMany(des => des.ServiceLister)
        .HasForeignKey(srv => srv.DestLocId)
        .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<ServiceType>().HasIndex(st => st.ServiceTypeName).IsUnique();

        modelBuilder.Entity<Location>().HasData(
            new Location() { LocationId = 1, LocationName = "HYD" },
            new Location() { LocationId = 2, LocationName = "CHN" },
            new Location() { LocationId = 3, LocationName = "Mumbai" }
        );

        modelBuilder.Entity<ServiceType>().HasData(
            new ServiceType() { STypeId = 1, ServiceTypeName = "Trishopp", PricePerKm = 24.00 },
             new ServiceType() { STypeId = 2, ServiceTypeName = "Varsitystore", PricePerKm = 25.50 }
        );

    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(ConString);
    }
}
using Microsoft.EntityFrameworkCore;

public class TravelEzeeEFContext:DbContext
{
    string ConString="Data Source=WKSCHE03TRNG023;Initial Catalog=TravelEzeeEF;Integrated Security=True;Trust Server Certificate=True";
    
    public DbSet<Location> Locations {get;set;}
    public DbSet<Service> Services {get;set;}
    public DbSet<ServiceType> ServiceTypes {get;set;}
    public DbSet<Booking> booking {get;set;}

    public TravelEzeeEFContext()
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Service>()
        .HasOne(srv=>srv.Source).
        WithMany(loc=>loc.SourceServiceList)
        .HasForeignKey(srv=>srv.SourceLocId)
        .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<Service>()
        .HasOne(srv=>srv.Destination).
        WithMany(loc=>loc.DestinationServiceList)
        .HasForeignKey(srv=>srv.DestLocId)
        .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<ServiceType>().HasIndex(st=>st.ServiceTypeName).IsUnique();

        modelBuilder.Entity<Location>().HasData(
            new Location() {LocationId=1,LocationName="HYD"},
            new Location() {LocationId=2,LocationName="CHN"},
            new Location() {LocationId=3,LocationName="Mumbai"}
        );


        modelBuilder.Entity<ServiceType>().HasData(
            new ServiceType() {STypeId=1,ServiceTypeName="Express",PricePerKm=12.50},
            new ServiceType() {STypeId=2,ServiceTypeName="Luxury",PricePerKm=18.50}
            
        );


    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
    {
        optionBuilder.UseSqlServer(ConString);
    }
}
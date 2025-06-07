using Microsoft.EntityFrameworkCore;

public class TravelEzeeEFContext :DbContext
{
    string ConString ="Data Source=WKSCHE03TRNG042;Initial Catalog=TravelEzeeEF;Integrated Security=True;Trust Server Certificate=True";
    
    public DbSet<Location> Locations {get; set;}

       public DbSet<ServiceType> Servicetypes {get; set;}

     public DbSet<Service> Services {get; set;}

     public DbSet<Booking> Bookings {get; set;}
    
    
    
    
    public TravelEzeeEFContext()
    {

    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
     modelBuilder.Entity<Service>().HasOne(srv => srv.Source).WithMany(loc => loc.ServiceList).HasForeignKey(srv => srv.SourceLocId
     ).OnDelete(DeleteBehavior.NoAction);

     modelBuilder.Entity<Service>().HasOne(srv => srv.Destination).WithMany(loc => loc.DestServiceList).HasForeignKey(srv => srv.DestLocId).OnDelete(DeleteBehavior.NoAction);
    

    modelBuilder.Entity<ServiceType>().HasIndex(st => st.ServiceTypeName).IsUnique();

    modelBuilder.Entity<Location>().HasData(
      new Location() {LocationId = 1, LocationName = "HYD"},
        new Location() {LocationId = 2, LocationName = "MLG"},
          new Location() {LocationId = 3, LocationName = "SRPT"}


    );

    modelBuilder.Entity<ServiceType>().HasData(
        new ServiceType() {STypeId =1,ServiceTypeName ="Express",PricePerKm=12.50},
        new ServiceType() {STypeId =2,ServiceTypeName ="Luxury",PricePerKm=12.90}
    );
    
    
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(ConString);
    }
}
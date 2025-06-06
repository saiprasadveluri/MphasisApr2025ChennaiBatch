using Microsoft.EntityFrameworkCore;

public class TravelEzeeEFContext : DbContext{
    string Constring="Data Source=.;Initial Catalog=TravelEzeeEF1UI;Integrated Security=True;Trust Server Certificate=True";
    public DbSet<Location> locations { get; set;}
    public DbSet<ServiceType> ServiceType { get; set;}
    public DbSet<Services>  Services { get; set;}
    public DbSet<Booking>  bookings { get; set;} 
    public TravelEzeeEFContext(){

    }
    protected override void OnModelCreating(ModelBuilder modelBuilder){
        modelBuilder.Entity<Services>().HasOne(srv=>srv.Source).WithMany(loc=>loc.SourceServiceList)
        .HasForeignKey(srv=>srv.SourceLocId).OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<Services>().HasOne(srv=>srv.Destination).WithMany(loc=>loc.DestServiceList)
        .HasForeignKey(srv=>srv.DestLocId).OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<ServiceType>().HasIndex(st=>st.ServiceTypeName).IsUnique();

        modelBuilder.Entity<Location>().HasData(
            new Location() {LocationId=1, LocationName="HYD"},
            new Location() {LocationId=2, LocationName="CHN"},
            new Location() {LocationId=3, LocationName="BLR"}
        ) ; 
        modelBuilder.Entity<ServiceType>().HasData(
            new ServiceType() {STypeId=1, ServiceTypeName="Express", PricePerKm=12.50},
            new ServiceType() {STypeId=2, ServiceTypeName="Luxury", PricePerKm=18.50}
           
        ) ;
      
    }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
        optionsBuilder.UseSqlServer(Constring);
    }
}
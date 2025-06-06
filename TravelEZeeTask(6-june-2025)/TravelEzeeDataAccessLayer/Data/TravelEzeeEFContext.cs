using Microsoft.EntityFrameworkCore;
public class TravelezeeEfContext : DbContext
{
    string ConString = "Data Source=;Initial Catalog=TravelEzEF;Integrated Security=True;Trust Server Certificate=True";
    public DbSet<Location> Loactions {get;set;}
    public DbSet<ServiceType> ServiceTypes {get;set;}
    public DbSet<Service> Services {get;set;}
    public DbSet<Booking> Bookings {get;set;}

public TravelezeeEfContext()
{

}
protected override void OnModelCreating(ModelBuilder modelBuilder)
{
     modelBuilder.Entity<Service>().HasOne(srv=>srv.Source).WithMany(loc=>loc.ServiceList).HasForeignKey(srv=>srv.SourceLocId).OnDelete(DeleteBehavior.NoAction);
     modelBuilder.Entity<Service>().HasOne(srv=>srv.Destination).WithMany(loc=>loc.DestServiceList).HasForeignKey(srv=>srv.DestLocId).OnDelete(DeleteBehavior.NoAction);
     modelBuilder.Entity<ServiceType>().HasIndex(st=>st.ServiceTypeName).IsUnique();
     modelBuilder.Entity<Location>().HasData(
         
            new Location(){LocationId =1,LocationName="HYD"},
             new Location(){LocationId =2,LocationName="CHENN"},
              new Location(){LocationId =3,LocationName="BANG"}
     );
        
         modelBuilder.Entity<ServiceType>().HasData(
         
            new ServiceType(){StypeId =1,ServiceTypeName="Express",PricePerKm=12.50},
             new ServiceType(){StypeId =2,ServiceTypeName="Luxary",PricePerKm=11.50}
         
         );

        

     
}
protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
{
    optionBuilder.UseSqlServer(ConString);
}
}
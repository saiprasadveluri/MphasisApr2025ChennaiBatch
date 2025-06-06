
using Microsoft.EntityFrameworkCore;

public class TravelForms:DbContext
{
    string constring="Data Source=WKSCHE03TRNG078\\SQLEXPRESS;Initial Catalog=TravelezeeEFForms;Integrated Security=True;Trust Server Certificate=True";
    
    public DbSet<Location> locations{get;set;}
    public DbSet<Service> services{get;set;}
    public DbSet<ServiceType> servicetypes{get;set;}
    public DbSet<Booking> bookings{get;set;}

    public TravelForms(){

    }
    protected override void OnModelCreating(ModelBuilder modelBuilder){
        modelBuilder.Entity<Service>().HasOne(srv=>srv.Source).
        WithMany(loc=>loc.SourceList).HasForeignKey(srv=>srv.SourceLocId).
        OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Service>().HasOne(srv=>srv.Destination).
        WithMany(loc=>loc.DestinationList).HasForeignKey(srv=>srv.DestLocId).
        OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<ServiceType>().HasIndex(p=>p.ServiceTypeName).IsUnique(); 

        modelBuilder.Entity<Location>().HasData(
                new Location() {LocationId=1,LocationName="chennai"},
                new Location() {LocationId=2,LocationName="hyd"},
                new Location() {LocationId=3,LocationName="kurnool"}
        );
         modelBuilder.Entity<ServiceType>().HasData(
            new ServiceType(){STypeId=101,ServiceTypeName="Express",PricePerKm=23.2},
            new ServiceType(){STypeId=102,ServiceTypeName="Ordinary",PricePerKm=10.2}
         );


    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
        optionsBuilder.UseSqlServer(constring);
    }
}
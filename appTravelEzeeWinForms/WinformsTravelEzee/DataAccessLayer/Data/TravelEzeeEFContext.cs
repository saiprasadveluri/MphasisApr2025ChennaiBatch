using Microsoft.EntityFrameworkCore;
public class TravelEzeeEFContext: DbContext
{
    string ConString="Data Source=WKSCHE03TRNG031;Initial Catalog=TravelEzeeEF;Integrated Security=True;Trust Server Certificate=True";

    public DbSet<Location> locations{get;set;}

    public DbSet<Service> services{get;set;}

    public DbSet<ServiceType> servicetype{get;set;}

    public DbSet<Booking> booking {get;set;}
    public TravelEzeeEFContext()
    {

    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Service>().HasOne(srv=> srv.Source).WithMany(loc =>loc.SourceServiceList).HasForeignKey(srv=>srv.SourceLocId).
        OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Service>().HasOne(srv=> srv.Destination).WithMany(loc =>loc.DestinationServiceList).HasForeignKey(srv=>srv.DestLocId).
        OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<ServiceType>().HasIndex(st=>st.ServiceTypeName).IsUnique();

        modelBuilder.Entity<Location>().HasData(
            new Location() {LocationId=1,LocationName="Hyd"},
            new Location() {LocationId=2,LocationName="Chn"},
            new Location() {LocationId=3,LocationName="Bglr"}

        );
         modelBuilder.Entity<ServiceType>().HasData(
            new ServiceType() {STypeId=1,ServiceTypeName="Express",PricePerKm=12.50},
            new ServiceType() {STypeId=2,ServiceTypeName="Luxury",PricePerKm=18.50}
         );



        //   modelBuilder.Entity<Service>().HasData(
        //     new Service() {STypeId=1,ServiceTypeName="Express",PricePerKm=12.50},
        //     new Service() {STypeId=2,ServiceTypeName="Luxury",PricePerKm=18.50}
        //  );



    }
      protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
      {
        optionsBuilder.UseSqlServer(ConString);
      }

}
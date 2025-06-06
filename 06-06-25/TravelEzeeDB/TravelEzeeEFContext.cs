using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace TravelEasyDB
{
    public class TravelEzeeEFContext : DbContext
    {
        public DbSet<Location> Locations { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<ServiceType> ServiceTypes { get; set; }
        public DbSet<Booking> Bookings { get; set; }

        public TravelEzeeEFContext()
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Location>().HasMany(loc => loc.SServiceList).WithOne(srv => srv.Source).HasForeignKey(srv => srv.SLocationId).OnDelete(DeleteBehavior.Cascade);
           // modelBuilder.Entity<Location>().HasMany(ld => ld.DServiceList).WithOne(srv => srv.Destination).HasForeignKey(srv => srv.DLocationId).OnDelete(DeleteBehavior.Cascade);
            //modelBuilder.Entity<Service>()
            //    .HasOne(s => s.Source)
            //    .WithMany(l => l.SServiceList)
            //    .HasForeignKey(s => s.SLocationId)
            //    .OnDelete(DeleteBehavior.NoAction);

            //modelBuilder.Entity<Service>()
            //    .HasOne(s => s.Destination)
            //    .WithMany(l => l.DServiceList) 
            //    .HasForeignKey(s => s.DLocationId)
            //    .OnDelete(DeleteBehavior.NoAction);

            //modelBuilder.Entity<Location>().HasData(
            //    new Location() { LocationName = "Delhi", LocationId = 1, LocationDescription = "Capital of India" },
            //    new Location() { LocationName = "Mumbai", LocationId = 2, LocationDescription = "Financial Capital of India" },
            //    new Location() { LocationName = "Bangalore", LocationId = 3, LocationDescription = "Silicon Valley of India" },
            //    new Location() { LocationName = "Chennai", LocationId = 4, LocationDescription = "Gateway to South India" },
            //    new Location() { LocationName = "Kolkata", LocationId = 5, LocationDescription = "Cultural Capital of India" }
            //    );

            //modelBuilder.Entity<ServiceType>().HasData(
            //    new ServiceType() { ServiceTypeId = 1, ServiceTypeName = "Taxi",PricePerkm = 20.7 },
            //    new ServiceType() { ServiceTypeId = 2, ServiceTypeName = "Bus", PricePerkm = 10.23 },
            //    new ServiceType() { ServiceTypeId = 3, ServiceTypeName = "Train", PricePerkm = 17.89 },
            //    new ServiceType() { ServiceTypeId = 4, ServiceTypeName = "Flight", PricePerkm=50.44 }
            //    );

            //modelBuilder.Entity<Service>().HasData(
            //    new Service() { ServiceId = 101, ServiceTypeId = 1, SLocationId = 1, DLocationId = 2, Distance = 20.51 },
            //    new Service() { ServiceId = 102, ServiceTypeId = 2, SLocationId = 2, DLocationId = 3, Distance = 30.021 },
            //    new Service() { ServiceId = 103, ServiceTypeId = 3, SLocationId = 3, DLocationId = 4, Distance = 40.555 },
            //    new Service() { ServiceId = 104, ServiceTypeId = 4, SLocationId = 4, DLocationId = 5, Distance = 35.093 },
            //    new Service() { ServiceId = 105, ServiceTypeId = 1, SLocationId = 5, DLocationId = 1, Distance = 55.090 },
            //    new Service() { ServiceId = 106, ServiceTypeId = 2, SLocationId = 1, DLocationId = 3, Distance = 70.991 }
            //    );

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog = TravelEasy;Integrated Security=SSPI;Trust Server Certificate = True;");
            optionsBuilder.ConfigureWarnings(warnings => warnings.Ignore(RelationalEventId.PendingModelChangesWarning));
        }
    }
}

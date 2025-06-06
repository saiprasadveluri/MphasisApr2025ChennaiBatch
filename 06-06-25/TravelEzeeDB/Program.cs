//See https://aka.ms/new-console-template for more information

//Console.WriteLine("Hello, World!");
using System;
using Microsoft.EntityFrameworkCore;

namespace TravelEasyDB
{
    public class Program
    {
        TravelEzeeEFContext context { get; set; }
        public static void Main(string[] args)
        {
            using (var context = new TravelEzeeEFContext())
            {
                //context.Database.EnsureCreated();
                Console.WriteLine("Database created successfully!");
            }

            DataAccess da = new DataAccess();
            var locations = da.GetLocations();
            var serviceTypes = da.GetServiceTypes();
            var services = da.GetServices();
            //da.AddLocation(LocId: 7, LocName: "Hyderabad", Locdes: "City of Nizams");

            Console.WriteLine("Locations:");
            foreach (var location in locations)
            {
                Console.WriteLine($"ID: {location.LocationId}, Name: {location.LocationName}, Description: {location.LocationDescription}");
            }

            Console.WriteLine("\nService Types:");
            foreach (var serviceType in serviceTypes)
            {
                Console.WriteLine($"ID: {serviceType.ServiceTypeId}, Name: {serviceType.ServiceTypeName}, Price per km: {serviceType.PricePerkm}");
            }

        }
    }
}
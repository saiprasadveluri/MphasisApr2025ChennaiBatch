using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TravelEasyDB
{
    public class DataAccess
    {
        TravelEzeeEFContext dbContext;
        public DataAccess()
        {
            dbContext = new TravelEzeeEFContext();
        }

        public List<Location> GetLocations()
        {
            return dbContext.Locations.ToList();
        }

        public List<ServiceType> GetServiceTypes()
        {
            return dbContext.ServiceTypes.ToList();
        }

        public List<Service> GetServices()
        {
            return dbContext.Services.ToList();
        }
        public List<Booking> GetBookings()
        {
            return dbContext.Bookings.ToList();
        }

        public void AddLocation(long LocId, string LocName, string Locdes)
        {
            var location = new Location
            {
                LocationId = LocId,
                LocationName = LocName,
                LocationDescription = Locdes
            };
            dbContext.Locations.Add(location);
            dbContext.SaveChanges();
        }

        public void AddServiceType(string ServiceTypeName, double PricePerkm)
        {
            var serviceType = new ServiceType
            {
                //ServiceTypeId = ServiceTypeId,
                ServiceTypeName = ServiceTypeName,
                PricePerkm = PricePerkm
            };
            dbContext.ServiceTypes.Add(serviceType);
            dbContext.SaveChanges();
        }

        public void AddService(long ServiceId, long ServiceTypeId, long SLocationId, long DLocationId, double Distance)
        {
            var service = new Service
            {
                ServiceId = ServiceId,
                ServiceTypeId = ServiceTypeId,
                SLocationId = SLocationId,
                DLocationId = DLocationId,
                Distance = Distance
            };
            dbContext.Services.Add(service);
            dbContext.SaveChanges();
        }

        public void AddBooking(long BookingId, long ServiceId, DateTime BookingDate,int SeatCount,string booked)
        {
            var booking = new Booking
            {
                BookingIds = BookingId,
                ServiceId = ServiceId,
                TravelDate = BookingDate,
                SeatCount = SeatCount,
                BookedBy = booked
            };
            dbContext.Bookings.Add(booking);
            dbContext.SaveChanges();
        }

        public void DeleteLocation(long locId)
        {
            var location = dbContext.Locations.Include(l => l.SServiceList).Include(l => l.DServiceList).FirstOrDefault(l => l.LocationId == locId);

            if (location != null)
            {
                dbContext.Services.RemoveRange(location.SServiceList);
                dbContext.Services.RemoveRange(location.DServiceList);
                dbContext.Locations.Remove(location);
                dbContext.SaveChanges();
            }
        }
        public void DeleteServiceType(long ServiceTypeId)
        {
            var service = dbContext.Services.Find(ServiceTypeId);
            if (service != null)
            {
                dbContext.Services.Remove(service);
                dbContext.SaveChanges();
            }
        }
        public void DeleteService(long ServiceId)
        {
            var service = dbContext.Services.Find(ServiceId);
            if (service != null)
            {
                dbContext.Services.Remove(service);
                dbContext.SaveChanges();
            }
        }

        public void DeleteBooking(long BookingId)
        {
            var booking = dbContext.Bookings.Find(BookingId);
            if (booking != null)
            {
                dbContext.Bookings.Remove(booking);
                dbContext.SaveChanges();
            }
        }

        public void UpdateLocation(long locId, string locName, string locDes)
        {
            var location = dbContext.Locations.Find(locId);
            if (location != null)
            {
                location.LocationName = locName;
                location.LocationDescription = locDes;
                dbContext.SaveChanges();
            }
        }

        public void UpdateServiceType(long ServiceTypeId, string ServiceTypeName, double PricePerkm)
        {
            var serviceType = dbContext.ServiceTypes.Find(ServiceTypeId);
            if (serviceType != null)
            {
                serviceType.ServiceTypeName = ServiceTypeName;
                serviceType.PricePerkm = PricePerkm;
                dbContext.SaveChanges();
            }
        }

        public void UpdateService(long ServiceId, long ServiceTypeId, long SLocationId, long DLocationId, double Distance)
        {
            var service = dbContext.Services.Find(ServiceId);
            if (service != null)
            {
                service.ServiceTypeId = ServiceTypeId;
                service.SLocationId = SLocationId;
                service.DLocationId = DLocationId;
                service.Distance = Distance;
                dbContext.SaveChanges();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using TravelEezeDataAccessLayer;
using TravelEezeDataAccessLayer.Data.DTO;

public class DataAccess
{
    TravelEzeeEFContext context;
    public DataAccess()
    {
        context = new TravelEzeeEFContext();
    }

    public List<Location> GetAllLocations()
    {
        return context.locations.ToList();
    }

    public List<ServiceType> GetAllServiceTypes()
    {
        return context.ServiceType.ToList();
    }

    public List<Service> GetAllServices()
    {
        return context.services.ToList();
    }

    public List<Service> GetServicesBasedonLocation(long SrcLoc, long destLoc)
    {
        return context.services.
        Where(srv => srv.SourceLocId == SrcLoc && srv.DestLocId == destLoc).ToList();

    }

    public List<ServiceEntry> GetAllServicesView()
    {
        var Res = (from sobj in context.services
                   join srcLocObj in context.locations on sobj.SourceLocId equals srcLocObj.LocationId
                   join destLocObj in context.locations on sobj.DestLocId equals destLocObj.LocationId
                   join stypeObj in context.ServiceType on sobj.SerTypeId equals stypeObj.STypeId
                   select new ServiceEntry()
                   {
                       ServiceId = sobj.ServiceId,
                       Source = srcLocObj.LocationName,
                       Destination = destLocObj.LocationName,
                       ServiceTypeName = stypeObj.ServiceTypeName,
                       Distance = sobj.Distance
                   }).ToList();
        return Res;
    }

    //insert data into tables
    public bool AddLocation(long LocId, string LocName,string locDescr)
    {
        Location loc = new Location()
        {
            LocationId = LocId,
            LocationName = LocName,
            LocationDescription = locDescr
        };
        context.locations.Add(loc);
        int Res = context.SaveChanges();
        return Res > 0;
    }
    public bool RemoveLocation(long LocId)
    {
        Location loc = new Location()
        {
            LocationId= LocId
        };
        context.locations.Remove(loc);
        int Res = context.SaveChanges();
        return Res > 0;
    } 
    public bool AddService(long SerTypId, long SrcLocId, long DesLocId, double Dist)
    {
        Service srv = new Service()
        {
            SerTypeId = SerTypId,
            SourceLocId = SrcLocId,
            DestLocId = DesLocId,
            Distance = Dist,
        };
        context.services.Add(srv);
        int Res = context.SaveChanges();
        return Res > 0;
    }
    //public bool AddServiceType(long STypId, string ServTypeName, double pricePerKm)
    //{
    //    ServiceType srvType = new ServiceType()
    //    {
    //        STypeId = STypId,
    //        ServiceTypeName = ServTypeName,
    //        PricePerKm = pricePerKm
    //    };
    //    context.ServiceType.Add(srvType);
    //    int Res = context.SaveChanges();
    //    return Res > 0;
    //}
    public bool AddServiceType(string Name, double price)
    {
        var typeList = context.ServiceType.ToList();
        long NextAvailId = 1;
        if(typeList.Count > 0)
        {
            NextAvailId = typeList.Max(t => t.STypeId) + 1;
        }
        ServiceType srvType = new ServiceType()
        {
            STypeId=NextAvailId,
            ServiceTypeName = Name,
            PricePerKm= price
        };
        context.ServiceType.Add(srvType);
        int Res = context.SaveChanges();
        if(Res > 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public bool AddBooking(long ServId, DateTime TravDate, int SCount, string BBy)
    {
        Booking books = new Booking()
        {
            ServiceId = ServId,
            TravelDate = TravDate,
            SeatCount = SCount,
            BookBy = BBy,
        };
        context.bookings.Add(books);
        int Res = context.SaveChanges();
        return Res > 0;
    }
    public bool AddNewService(long SrcId, long DestId, long SrvTypeId, double Distance)
    {
        Service service = new Service()
        {
            DestLocId = DestId,
            SourceLocId = SrcId,
            Distance = Distance,
            SerTypeId = SrvTypeId
        };
        context.services.Add(service);
        int Res = context.SaveChanges();
        return Res > 0;
    }
}

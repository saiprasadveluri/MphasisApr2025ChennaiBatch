using System.Runtime.ConstrainedExecution;
using Microsoft.Extensions.DependencyInjection;

public class DataAccess
{
    TravelEzeeEFContext context;

    public DataAccess()
    {
        context = new TravelEzeeEFContext();

    }
    public List<Location> GetAllLocations()
    {
        return context.Locations.ToList();
    }

    public List<Service> GetAllServices()
    {
        return context.Services.ToList();
    }
    public List<ServiceType> GetAllServiceTypes()
    {
        return context.ServiceTypes.ToList();
    }
    public List<Booking> GetAllBookings()
    {
        return context.booking.ToList();
    }

    public List<Service> GetServicesBasedonLocation(long SrcLoc, long destLoc)
    {
        return context.Services.
        Where(srv => srv.SourceLocId == SrcLoc && srv.DestLocId == destLoc).ToList();
    }

    //CRUD On entities

    public bool AddLocation(long Id, string Name, string? Descr)
    {
        Location loc = new Location()
        {
            LocationId = Id,
            LocationDescription = Descr,
            LocationName = Name

        };
        context.Locations.Add(loc);
        int RecCount = context.SaveChanges();
        return RecCount > 0;
    }
    public bool DeleteLocation(long LocId)
    {
        var serlist = context.Services.Where(l => l.SourceLocId == LocId || l.DestLocId == LocId);
        context.Services.RemoveRange(serlist);
        var LocList=context.Locations.FirstOrDefault(loc=>loc.LocationId==LocId);
        context.Locations.Remove(LocList);
        int del=context.SaveChanges();
        return del > 0;

    }


    public bool AddServiceType(string Name, double price)
    {
        var typeList = context.ServiceTypes.ToList();
        long NextAvailId = 1;
        if (typeList.Count > 0)
        {
            NextAvailId = typeList.Max(t => t.STypeId) + 1;

        }
        ServiceType srvType = new ServiceType()
        {
            STypeId = NextAvailId,
            ServiceTypeName = Name,
            PricePerKm = price,
        };
        context.ServiceTypes.Add(srvType);
        int RecEffected = context.SaveChanges();
        if (RecEffected > 0)
        {
            return true;
        }
        else
        {
            return false;
        }

    }
    public List<ServiceEntry> GetAllServicesView()
    {
        var Res = (from sobj in context.Services
                   join srcLocObj in context.Locations on sobj.SourceLocId equals srcLocObj.LocationId
                   join destLocObj in context.Locations on sobj.DestLocId equals destLocObj.LocationId
                   join stypeObj in context.ServiceTypes on sobj.SerTypeId equals stypeObj.STypeId
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

    public bool AddService(long serTypId, long SouID, long DesId, double Dis)
    {
        Service ser = new Service()
        {
            SerTypeId = serTypId,
            SourceLocId = SouID,
            DestLocId = DesId,
            Distance = Dis
        };
        context.Services.Add(ser);
        int SerCount = context.SaveChanges();
        return SerCount > 0;
    }


    public bool AddNewService(long SrcId, long DestId, long SrvTypeId, double Dist)
    {
        Service service = new Service()
        {
            DestLocId = DestId,
            SourceLocId = SrcId,
            Distance = Dist,
            SerTypeId = SrvTypeId
        };
        context.Services.Add(service);
        int Rec = context.SaveChanges();
        return Rec > 0;

    }
  
    public bool AddBooking(long SerId, DateTime TrDate, int seCount, string bookby)
    {
        Booking book = new Booking()
        {
            ServiceId = SerId,
            TravelDate = TrDate,
            SeatCount = seCount,
            BookBy = bookby
        };
        context.booking.Add(book);
        int bookCount = context.SaveChanges();
        return bookCount > 0;
    }

   
}
   


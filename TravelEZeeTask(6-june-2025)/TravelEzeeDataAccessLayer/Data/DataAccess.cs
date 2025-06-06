using System.ComponentModel.Design;
using Microsoft.Extensions.DependencyInjection;
public class DataAccess
{
    TravelezeeEfContext context;
    public DataAccess()
    {
        context = new TravelezeeEfContext();
    }
    public List<Location> GetAllLocations()
    {
        return context.Loactions.ToList();
    }
    public List<ServiceType> GetAllServiceTypes()
    {
        return context.ServiceTypes.ToList();
    }
    public List<Service> GetAllServices()
    {
        return context.Services.ToList();
    }
    public List<Booking> GetAllBookings()
    {
        return context.Bookings.ToList();
    }
   


    public List<Service> GetServicesBasedOnLoaction(long SrcLoc,long destLoc)
    {
        return context.Services.Where(srv=>srv.SourceLocId== SrcLoc && srv.DestLocId==destLoc).ToList();
    }
    public bool AddLocation(long Id,string Name,string Descr)
    {
        Location loc = new Location()
        {
        LocationId =Id,
        LoactionDescription= Descr,
        LocationName= Name
    };
    context.Loactions.Add(loc);
    int ReCount = context.SaveChanges();
    return ReCount>0;
    }
    public bool DeleteLocation(long LocId)
    {
        //var ServicesList = context.Services.Where(loc => loc.SourceLocId == LocId || loc.DestLocId == LocId).ToList();
        //context.Services.RemoveRange(ServicesList);
        var LocList = context.Loactions.FirstOrDefault(loc=>loc.LocationId== LocId);
        context.Loactions.Remove(LocList);
        int del = context.SaveChanges();
        return del > 0;
    }
    public List<ServiceEntry> GetAllServicesView()
    {
        var Res = (from sobj in context.Services
                   join srcLocObj in context.Loactions on sobj.SourceLocId equals srcLocObj.LocationId
                   join DestLocObj in context.Loactions on sobj.DestLocId equals DestLocObj.LocationId
                   join stypeObj in context.ServiceTypes on sobj.ServiceTypeId equals stypeObj.StypeId
                   select new ServiceEntry()
                   {
                       ServiceId = sobj.ServiceId,
                       Source = srcLocObj.LocationName,
                       Destination = DestLocObj.LocationName,
                       ServicetypeName = stypeObj.ServiceTypeName,
                       Distance = sobj.Distance
                   }).ToList();
        return Res;
    }
    //public List<Service> GetServicesBySrcAndDest(int src,int dest)
    //{
    //    var list = context.Services.Where(srv => srv.SourceLocId == src && srv.DestLocId == dest).ToList();

    //}

    public bool AddServiceType(string Name,double Price)
    {
        var typeList = context.ServiceTypes.ToList();
        long NextAvailId = 1;
        if (typeList.Count > 0)
        {
            NextAvailId = typeList.Max(t => t.StypeId) + 1;
        }
        ServiceType srvType = new ServiceType()
        {
            StypeId = NextAvailId,
            ServiceTypeName = Name,
            PricePerKm = Price,
        };
             context.ServiceTypes.Add(srvType);
            int RecEffected= context.SaveChanges();
            if(RecEffected>0)
        
             return true;
                else
                return false;
        }
    public bool AddService(long serTypId,long SouID,long DesId,double Dis)
    {
        Service ser = new Service()
        {
        
        
        
        ServiceTypeId= serTypId,
        SourceLocId= SouID,
        DestLocId=DesId,
        Distance=Dis
    };
    context.Services.Add(ser);
    int SerCount = context.SaveChanges();
    return SerCount>0;
    }
    public bool AddBooking(long SerId,DateTime TrDate,int seCount,string bookby)
    {
        Booking book = new Booking()
        {
        
        
        
        ServiceId= SerId,
        TravelDate= TrDate,
        SeatCount=seCount,
        BookBy=bookby
    };
    context.Bookings.Add(book);
    int bookCount = context.SaveChanges();
    return bookCount>0;
    }
    public bool AddNewService(long SrcId,long DestId, long SrvTypeId,double Distance)
    {
        Service service = new Service()
        {
            DestLocId = DestId,
            SourceLocId = SrcId,
            Distance = Distance,
            ServiceTypeId = SrvTypeId
        };
        context.Services.Add(service);
        int Rec=context.SaveChanges();
        return Rec>0;
    }
    





}
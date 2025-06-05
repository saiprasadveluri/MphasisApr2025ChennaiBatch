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
    public List<ServiceType> GetAllServiceTypes()
    {
        return context.Servicetypes.ToList();
    }
     public List<Service> GetAllServices()
    {
        return context.Services.ToList();
    }

    public List<Service> GetServicesBasedonLocation(long SrcLoc, long destLoc)
    {
        return context.Services.Where(srv=>srv.SourceLocId==SrcLoc && srv.DestLocId==destLoc).ToList();
    }

    public bool AddLocation(long Id, string Name, string? Descr)
    {
        Location loc = new Location()
        {
            LocationId =Id,
            LocationDescription = Descr,
            LocationName= Name
        };
        context.Locations.Add(loc);
        int RecCount = context.SaveChanges();
        return RecCount > 0;
    }

    // public List<ServiceEntry> GetAllServicesView()
    // {
    //     var Res=(from sobj in context.Services
    //        join srcLocObj in  context .Locations on sobj.SourceLocId equals srcLocObj.LocationId
    //        join DestLocObj in context.Locations on sobj.DestLocId equals DestLocObj.LocationId
    //           join stypeObj in context.Servicetypes on sobj.ServiceTypeId equals stypeObj.STypeId
    //           select new ServiceEntry()
    //           {
    //             ServiceId = sobj.ServiceId,
    //             Source = srcLocObj.LocationName,
    //             Destination = DestLocObj.LocationName,
    //             ServiceTypeName=stypeObj.ServiceTypeName,
    //             Distance =sobj.Distance
    //           }).ToList();
    //           return Res;

    // }
     public bool AddService(long SerTypId,long SrcLocId,long DesLocId,double Dist)
    {
        Service srv=new Service()
        {
            SerTypeId=SerTypId,
            SourceLocId=SrcLocId,
            DestLocId=DesLocId,
            Distance=Dist,
        };
        context.Services.Add(srv);
        int Res=context.SaveChanges();
        return Res>0;
    }
    public bool AddServiceType(long STypId,string ServTypeName,double pricePerKm)
    {
        ServiceType srvType=new ServiceType()
        {
            STypeId=STypId,
            ServiceTypeName=ServTypeName,
            PricePerKm=pricePerKm
        };
        context.ServiceType.Add(srvType);
        int Res=context.SaveChanges();
        return Res>0;
    }
    public bool AddBooking(long ServId,DateTime TravDate,int SCount,string BBy)
    {
        Booking books=new Booking()
        {
            ServiceId=ServId,
            TravelDate=TravDate,
            SeatCount=SCount,
            BookBy=BBy,
        };
        context.bookings.Add(books);
        int Res=context.SaveChanges();
        return Res>0;
    }
}


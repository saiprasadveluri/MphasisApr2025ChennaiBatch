using Microsoft.Extensions.DependencyInjection;

public class DataAccess
{
    TravelEFManagementContext context;
    public DataAccess()
    {
        context = new TravelEFManagementContext();
    }

    //view data from tables
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

    public List<Booking> GetAllBookings()
    {
        return context.bookings.ToList();
    }

    //getting data based on specifications
    public List<Service> GetServicesBasedonLocation(long SrcLoc, long destLoc)
    {
        return context.services.Where(srv => srv.SourceLocId == SrcLoc && srv.DestLocId == destLoc).ToList();
    }

    public bool DeleteLocation(long Locid)
    {
        var servList = context.services.Where(loc => loc.SourceLocId == Locid || loc.DestLocId == Locid).ToList();
        context.services.RemoveRange(servList);
        var LocList = context.locations.FirstOrDefault(loc => loc.LocationId == Locid);
        context.locations.Remove(LocList);
        int del = context.SaveChanges();
        return del > 0;
    }

    public List<ServiceEntry> GetAllServicesView()
    {
        var Res = (from sObj in context.services
                   join srcLocObj in context.locations on sObj.SourceLocId equals srcLocObj.LocationId
                   join destLocObj in context.locations on sObj.DestLocId equals destLocObj.LocationId
                   join stypeLocObj in context.ServiceType on sObj.SerTypeId equals stypeLocObj.STypeId
                   select new ServiceEntry()
                   {
                       SrcLocId = srcLocObj.LocationName,
                       DestLocId = destLocObj.LocationName,
                       ServiceTypeName = stypeLocObj.ServiceTypeName,
                       Distance = sObj.Distance
                   }).ToList();
                   return Res;
    }
    
    //insert data into tables
    public bool AddLocation(long LocId,string LocName,string? Desc)
    {
        Location loc=new Location()
        {
            LocationId=LocId,
            LocationName=LocName,
            LocationDescription=Desc
        };
        context.locations.Add(loc);
        int Res=context.SaveChanges();
        return Res>0;
    }
    public bool AddService(long SerTypId,long SrcLocId,long DesLocId,double Dist)
    {
        Service srv=new Service()
        {
            SerTypeId=SerTypId,
            SourceLocId=SrcLocId,
            DestLocId=DesLocId,
            Distance=Dist,
        };
        context.services.Add(srv);
        int Res=context.SaveChanges();
        return Res>0;
    }
    public bool AddServiceType(string ServTypeName,double pricePerKm)
    {
        long nextSrvId = 1;
        var typeList = context.ServiceType.ToList();
        if (typeList.Count > 0)
        {
            nextSrvId = typeList.Max(l => l.STypeId) + 1;
        }
        ServiceType srvType=new ServiceType()
        {
            STypeId= nextSrvId,
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
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
     public List<Booking> GetAllBookings()
    {
        return context.Bookings.ToList();
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
     public bool DeleteLocation(long LocId)
     {
        //var servicesList = context.Services.Where(loc => loc.SourceLocId == LocId ||loc.DestLocId == LocId).ToList();
        //context.Services.RemoveRange(servicesList);
         var LocList = context.Locations.FirstOrDefault(loc=>loc.LocationId==LocId);
         context.Locations.Remove(LocList);
         int del = context.SaveChanges();
         return del > 0;
     }

    public bool DeleteService(long Serid)
    {
        var Serlist = context.Services.FirstOrDefault(ser => ser.ServiceId == Serid);   
        context.Services.Remove(Serlist);
        int del = context.SaveChanges();
        return del > 0;
    }
    public bool DeleteServiceType(long SerStypeId)
    {
        var ServicesList = context.Services.Where(loc => loc.SourceLocId == SerStypeId || loc.DestLocId == SerStypeId).ToList();
        context.Services.RemoveRange(ServicesList);
        var serTypeList = context.Servicetypes.FirstOrDefault(st => st.STypeId == SerStypeId);
        context.Servicetypes.Remove(serTypeList);
        int del = context.SaveChanges();
        return del > 0;
    }


    public List<ServiceEntry> GetAllServicesView()
    {
        var Res = (from sobj in context.Services
                   join srcLocObj in context.Locations on sobj.SourceLocId equals srcLocObj.LocationId
                   join DestLocObj in context.Locations on sobj.DestLocId equals DestLocObj.LocationId
                   join stypeObj in context.Servicetypes on sobj.ServiceTypeId equals stypeObj.STypeId
                   select new ServiceEntry()
                   {
                       ServiceId = sobj.ServiceId,
                       Source = srcLocObj.LocationName,
                       Destination = DestLocObj.LocationName,
                       ServiceTypeName = stypeObj.ServiceTypeName,
                       Distance = sobj.Distance
                   }).ToList();
        return Res;

    }
    public bool AddService(long SerTypId,long SrcLocId,long DesLocId,double Dist)
    {
        Service srv=new Service()
        { 
            ServiceTypeId=SerTypId,
            SourceLocId=SrcLocId,
            DestLocId=DesLocId,
            Distance=Dist,
        };
        context.Services.Add(srv);
        int Res=context.SaveChanges();
        return Res>0;
    }
    public bool AddServiceType(string Name, double price)
    {
        var typeList = context.Servicetypes.ToList();
        long NextAvailId = 1;
        if (typeList.Count > 0)
        {
            NextAvailId = typeList.Max(t => t.STypeId) + 1;
        }
        ServiceType srvType = new ServiceType()
        {
            STypeId=NextAvailId,
            ServiceTypeName = Name,
            PricePerKm = price,
        };
        context.Servicetypes.Add(srvType);
        int RecEffected = context.SaveChanges();
        if (RecEffected > 0)
            return true;
        else
            return false;
    }
           /* public bool AddServiceType(long STypId, string ServTypeName, double pricePerKm)
            {
                ServiceType srvType = new ServiceType()
                {
                    STypeId = STypId,
                    ServiceTypeName = ServTypeName,
                    PricePerKm = pricePerKm
                };
                context.Servicetypes.Add(srvType);
                int Res = context.SaveChanges();
                return Res > 0;
            }*/
    public bool AddBooking(long ServId,DateTime TravDate,int SCount,string BBy)
    {
        Booking books=new Booking()
        {
            ServiceId=ServId,
            TravelDate=TravDate,
            SeatCount=SCount,
            BookBy=BBy,
        };
        context.Bookings.Add(books);
        int Res=context.SaveChanges();
        return Res>0;
    }
    public bool AddNewService(long SrcId, long DestId, long SrvTypeId, double Distance)
    {
        Service service = new Service()
        {
            DestLocId = DestId,
            SourceLocId = SrcId,
            Distance = Distance,
            ServiceTypeId = SrvTypeId
        };
        context.Services.Add(service);
        int Rec= context.SaveChanges();
        return Rec > 0;

    }
}


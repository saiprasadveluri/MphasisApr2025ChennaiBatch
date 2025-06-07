using Microsoft.Extensions.DependencyInjection;
using TravelEzeeDataAccessLayer;
using TravelEzeeDataAccessLayer.Data;

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
        return context.ServiceTypes.ToList();
    }
    public List<ServiceEntry> GetAllServicesView()
    {
        var Res = (from sobj in context.Services
                   join srcLocObj in context.locations on sobj.SourceLocId equals srcLocObj.LocationId
                   join destLocObj in context.locations on sobj.DestLocId equals destLocObj.LocationId
                   join stypeObj in context.ServiceTypes on sobj.SerTypeId equals stypeObj.STypeId
                   select new ServiceEntry()
                   {
                       ServiceId = sobj.ServiceId,
                       ServiceTypeName = stypeObj.ServiceTypeName,
                       Source = srcLocObj.LocationName,
                       Destination = destLocObj.LocationName,
                       Distance = sobj.Distance
                   }).ToList();
        return Res;
    }
    public List<Service> GetAllServices()
    {
        return context.Services.ToList();
    }

    public List<Service> GetServicesBasedonLocation(long SrcLoc, long destLoc)
    {
        return context.Services.
        Where(srv => srv.SourceLocId == SrcLoc && srv.DestLocId == destLoc).ToList();

    }
     public bool AddLocation(long LocId, string LocName,string? desrpt)
        {
    
            Location loc = new Location()
    
            {
    
                LocationId = LocId,
                LocationName = LocName,
                LocationDescription=desrpt

            };
            context.locations.Add(loc);
            int Res = context.SaveChanges();
            return Res > 0;
        }
        public bool AddServiceType(long TypeId, string sertypename, double priceperkm)
        {
        var typelist = context.ServiceTypes.ToList();
        long NextAvailableId = 1;
        if (typelist.Count > 0)
        {
            NextAvailableId = typelist.Max(t => t.STypeId) + 1;
        }
            ServiceType ser = new ServiceType()
            {
                STypeId = TypeId,
                ServiceTypeName = sertypename,
                PricePerKm = priceperkm
            };
            context.ServiceTypes.Add(ser);
            int res = context.SaveChanges();
            if (res > 0)
            {
                return true;
            }
            return res > 0;
        }
        public bool RemoveLocation(long LocId, string Locname)
        {
            Location loc = new Location()
            {
                LocationId = LocId,
                LocationName = Locname
            };
            context.locations.Remove(loc);
            int Res = context.SaveChanges();
            return Res > 0;
        }
        public bool AddService(long sTypeId, long src, long dest, double distance)
        {
            Service srv = new Service()
            {
                SerTypeId = sTypeId,
                SourceLocId = src,
                DestLocId = dest,
                Distance = distance
            };
            context.Services.Add(srv);
            int res = context.SaveChanges();
            return res > 0;
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
            context.Services.Add(service);
            int Res = context.SaveChanges();
            return Res > 0;
        }
}
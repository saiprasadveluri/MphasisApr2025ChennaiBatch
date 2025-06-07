using Microsoft.Extensions.DependencyInjection;
public class DataAccess
{
    TravelEezzEFContext context;
    public DataAccess()
    {
        context = new TravelEezzEFContext();

    }
    public List<Location> GetAllLocations()
    {
        return context.Locations.ToList();
    }
    public List<ServiceType> GetAllServiceTypes()
    {
        return context.ServiceTypes.ToList();
    }
    public List<Service> GetAllServices()
    {
        return context.Services.ToList();
    }
    public List<Service> GetServicesBasedOnLocation(long SrcLoc, long destLoc)
    {
        return context.Services.Where(srv => srv.SourceLocId == SrcLoc && srv.DestLocId == destLoc).ToList();
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
    
    public bool AddLocation(long LocId, string LocName, string? Descr)
    {
        Location loc = new Location()
        {
            LocationId = LocId,
            LocationName = LocName,
            LocationDescription = Descr

        };
        context.Locations.Add(loc);
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
        context.Services.Add(srv);
        int Res = context.SaveChanges();
        return Res > 0;
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
            PricePerKm = price
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
    public bool DeleteLocation(long LocationId)
    {
        var ServiceList = context.Services.Where(location => location.SourceLocId == LocationId ||location.DestLocId == LocationId);
        context.Services.RemoveRange(ServiceList);
        var LocList=context.Locations.FirstOrDefault(loc=>loc.LocationId == LocationId);
        context.Locations.Remove(LocList);
        int delete=context.SaveChanges();
        return delete > 0;
    }
    public bool DeleteService(long serviceId)
    {
        
        var SrvList = context.Services.FirstOrDefault(srv => srv.ServiceId==serviceId);
        context.Services.Remove(SrvList);
        int delete = context.SaveChanges();
        return delete > 0;

    }
    public bool DeleteServiceType(long ServiceTypeId)
    {
        var SrvTypeList = context.ServiceTypes.FirstOrDefault(serTypeId => serTypeId.STypeId == ServiceTypeId);
        context.ServiceTypes.Remove(SrvTypeList);
        int delete = context.SaveChanges();
        return delete > 0;
    }
    public bool EditLocation(long LocationId,string LocationName)
    {
        Location curLoc=context.Locations.FirstOrDefault(location=>location.LocationId == LocationId);
        if(curLoc!=null)
        {
            curLoc.LocationName=LocationName;

        }
        int Result=context.SaveChanges();
        return Result > 0;
    }



}

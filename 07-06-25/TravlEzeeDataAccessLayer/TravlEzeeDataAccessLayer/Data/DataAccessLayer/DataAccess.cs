using Microsoft.Extensions.DependencyInjection;

public class DataAccess

{

    TravelForms context;

    public DataAccess()

    {

        context = new TravelForms();

    }

    public List<Location> GetAllLocations()

    {

        return context.locations.ToList();

    }

    public List<ServiceType> GetAllServiceTypes()

    {

        return context.servicetypes.ToList();

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

    public bool AddLocation(long LocId, string LocName)

    {

        Location loc = new Location()

        {

            LocationId = LocId,

            LocationName = LocName

        };

        context.locations.Add(loc);

        int Res = context.SaveChanges();

        return Res > 0;

    }

    public bool AddServiceType(long TypeId, string sertypename, double priceperkm)

    {

        ServiceType ser = new ServiceType()

        {

            STypeId = TypeId,

            ServiceTypeName = sertypename,

            PricePerKm = priceperkm

        };

        context.servicetypes.Add(ser);

        int res = context.SaveChanges();

        return res > 0;

    }

    public bool AddService(long sTypeId, long src, long dest, double distance)

    {

        Service srv = new Service()

        {

            ServiceId = sTypeId,

            SourceLocId = src,

            DestLocId = dest,

            Distance = distance

        };

        context.services.Add(srv);

        int res = context.SaveChanges();

        return res > 0;

    }

}

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
}
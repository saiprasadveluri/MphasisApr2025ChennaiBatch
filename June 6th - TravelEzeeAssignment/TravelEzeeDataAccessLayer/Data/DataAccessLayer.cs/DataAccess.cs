using Microsoft.Extensions.DependencyInjection;

public class DataAccess
{
    TravelEzeeEFContext context;

    public object MessageBox { get; private set; }
    public object MessageBoxButtons { get; private set; }
    public object MessageBoxIcon { get; private set; }

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

    public List<Service> GetAllServices()
    {
        return context.services.ToList();
    }

    public List<Service> GetServicesBasedonLocation(long SrcLoc, long destLoc)
    {
        return context.services.
        Where(srv => srv.SourceLocationId == SrcLoc && srv.DestinationLocationId == destLoc).ToList();

    }

    public bool AddServiceType(int TypeId, string sertypename, float priceperkm)
    {
        ServiceType ser = new ServiceType()
        {
            ServiceTypeId = TypeId,
            ServiceTypeText = sertypename,
            PricePerKm = priceperkm

        };
        context.ServiceTypes.Add(ser);
        int res = context.SaveChanges();
        return res > 0;

    }
    public bool AddService(int sTypeId, int src, int dest, double distance)
    {
        Service srv = new Service()
        {
            ServiceTypeId = sTypeId,
            SourceLocationId = src,
            DestinationLocationId = dest,
            DistanceKm = (float)distance
        };
        context.services.Add(srv);
        int res = context.SaveChanges();
        return res > 0;
    }

    public bool AddLocation(int nextLocationId, string locName, string locDescr)
    {
        try
        {
            var loc = new Location
            {
                LocationId = nextLocationId,
                LocationName = locName,
                LocationDescription = locDescr,
                SourceServiceList = new List<Service>(),
                DestServiceList = new List<Service>()
            };

            context.locations.Add(loc);
            int res = context.SaveChanges();
            return res > 0;
        }
        catch (Exception ex)
        {
            //MessageBox.Show($"Error adding location:\n{ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
    }




    internal void AddLocation(int v1, string v2)
    {
        throw new NotImplementedException();
    }
}
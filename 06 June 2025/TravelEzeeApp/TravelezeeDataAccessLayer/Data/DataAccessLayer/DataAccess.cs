

public class DataAccess{
    public TravelForms context;
    public DataAccess(){
        context=new TravelForms();
    }

    public List<Location> GetAllLocations(){
        return context.locations.ToList();
    }
    public List<ServiceType> GetAllServiceTypes(){
        return context.servicetypes.ToList();
    }
    public List<Service> GetAllServices(){
        return context.services.ToList();
    }
    public List<Booking> GetAllBookings(){
        return context.bookings.ToList();
    }

    public List<Service> GetServicesBasedOnLocation(long SrcLoc,long DestLoc){
        return context.services.
        Where(srv=>srv.SourceLocId==SrcLoc && srv.DestLocId==DestLoc).ToList();
    }
     public bool AddLocation(long LocId, string LocName,string des)
    {

        Location loc = new Location()

        {

            LocationId = LocId,

            LocationName = LocName,
            LocationDescription = des

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
    public List<ServiceEntry> GetAllServicesView()
    {
        var Res = (from sobj in context.services
            join srcLocObj in context.locations on sobj.SourceLocId equals srcLocObj.LocationId
                    join destLocObj in context.locations on sobj.DestLocId equals destLocObj.LocationId
                    join stypeLocObj in context.servicetypes on sobj.ServiceTypeId equals stypeLocObj.STypeId
                    select new ServiceEntry(){
                        ServiceId = sobj.ServiceId,
                        SourceLocId = srcLocObj.LocationName,
                        DestLocId = destLocObj.LocationName,
                        ServiceTypeName = stypeLocObj.ServiceTypeName,
                        Distance = sobj.Distance
                    }).ToList();
            return Res;
    }
public bool AddService(long sTypeId, long src, long dest, double distance)
    {
        Service srv = new Service()
        {
            ServiceTypeId = sTypeId,
            SourceLocId = src,
            DestLocId = dest,
            Distance = distance
        };
        context.services.Add(srv);
        int res = context.SaveChanges();
        return res > 0;
    }
    public bool DeleteLocation(long locationId)
    {
      //var res=context.services.Where(l=>(l.SourceLocId == locationId|| l.DestLocId==locationId)).ToList();
        //context.RemoveRange(res);
        var r=context.locations.FirstOrDefault(l=>l.LocationId == locationId);
        context.locations.Remove(r);
        int d=context.SaveChanges(); 
        return d > 0;
    }

}
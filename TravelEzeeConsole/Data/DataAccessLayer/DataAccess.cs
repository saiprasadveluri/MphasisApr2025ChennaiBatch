using Microsoft.Extensions.DependencyInjection;
public class DataAccess
{
    TravelEzeeEFContext context;
    public DataAccess()
    {
        context=new TravelEzeeEFContext();
    }
    public List<Location> getAllLocations()
    {
        return context.locations.ToList();
    }

     public List<ServiceType> getAllServiceTypes()
    {
        return context.servicetype.ToList();
    }

    
     public List<Service> getAllServices()
    {
        return context.services.ToList();
    }

    public List<Service> GetServicesBasedLocation(long SrcLoc,long destLoc)
    {
        return context.services.Where(srv=>srv.SourceLocId==SrcLoc && srv.DestLocId==destLoc).ToList();
    }
     
    //crud on entities
    public bool AddLocation(long Id,string Name,string? Descr)
    {
        Location loc=new Location()
        {
        LocationId=Id,
        LocationDescription=Descr,
        LocationName=Name
        };
    context.locations.Add(loc);
    int RecCount=context.SaveChanges();
    return RecCount>0;
    }

    public List<ServiceEntry> GetAllServicesView()
    {
        var Res=(from sobj in context.services
            join srcLocObj in context.locations on sobj.SourceLocId equals srcLocObj.LocationId
            join destLocObj in context.locations on sobj.DestLocId equals destLocObj.LocationId
            join stypeObj in context.servicetype on sobj.SerTypeId equals stypeObj.STypeId
            select new ServiceEntry()
            {
                ServiceId=sobj.ServiceId,
                Source=srcLocObj.LocationName,
                Destination=destLocObj.LocationName,
                ServiceTypeName=stypeObj.ServiceTypeName,
                Distance=sobj.Distance
            }).ToList();
        return Res;
    }
    public bool AddService(long serTypId,long SouID,long DesId,double Dis)
    {
        Service ser = new Service()
        {
        
        
        
        SerTypeId= serTypId,
        SourceLocId= SouID,
        DestLocId=DesId,
        Distance=Dis
    };
    context.services.Add(ser);
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
    context.bookings.Add(book);
    int bookCount = context.SaveChanges();
    return bookCount>0;
    }
   

}
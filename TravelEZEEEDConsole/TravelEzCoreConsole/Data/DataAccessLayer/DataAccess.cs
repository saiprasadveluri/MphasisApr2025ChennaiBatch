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
        return context.ServiceTypes.ToList();
    }

    public List<Service> GetAllServices()
    {
        return context.services.ToList();
    }
    public List<Booking> GetAllBookings()
    {
        return context.bookings.ToList();
    }


    public List<Service> GetServicesBasedonLocation(long SrcLoc, long destLoc)
    {
        return context.services.
        Where(srv => srv.SourceLocId == SrcLoc && srv.DestLocId == destLoc).ToList();

    }
     public bool AddLocation(long Id,string Name,string Descr)
    {
        Location loc = new Location()
        {
        
        
        LocationId =Id,
        LocationDescription= Descr,
        LocationName= Name
    };
    context.locations.Add(loc);
    int ReCount = context.SaveChanges();
    return ReCount>0;
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
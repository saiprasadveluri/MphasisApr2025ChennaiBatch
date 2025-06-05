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
    
    //insert data into tables
    public bool AddLocation(long LocId,string LocName)
    {
        Location loc=new Location()
        {
            LocationId=LocId,
            LocationName=LocName
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
    public bool AddServiceType(long STypId,string ServTypeName,double pricePerKm)
    {
        ServiceType srvType=new ServiceType()
        {
            STypeId=STypId,
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
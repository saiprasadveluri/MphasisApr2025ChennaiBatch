

using Microsoft.EntityFrameworkCore;

public class DataAccess
{
    TravelEzeeEFContext context;
    public DataAccess()
    {
        context=new TravelEzeeEFContext();
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

    public List<TravelEzeeWinUIConsole.Booking> GetBookings()
    {
        return context.bookings.ToList();
    }
    public List<Service> GetServicesBasedonLocatiom(long SrcLoc, long destLoc)
    {
        return context.services.Where(srv=>srv.SourceLocId==SrcLoc && srv.DestLocId==destLoc).ToList();
    }
    //CRUD OPERATIONS ON ENTITIES
    public bool AddLocation(long Id, string Name,string? Descr)
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
    public bool AddServiceType(string Name, double price)
    {
        var typeList = context.ServiceType.ToList();
        long NextAvailId = 1;
        if (typeList.Count > 0)
        {
            NextAvailId = typeList.Max(t=>t.STypeId)+ 1;
        }
        ServiceType srvType = new ServiceType()
        {   
            STypeId=NextAvailId,
            ServiceTypeName = Name,
            PricePerKm = price,
        };
        context.ServiceType.Add(srvType);
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
        public List<ServiceEntry>GetAllServiceView()
         {
        var Res=(from sobj in context.services
                join srcLocObj in context.locations on sobj.SourceLocId equals srcLocObj.LocationId
                join destLocObj in context.locations on sobj.DestLocId equals destLocObj.LocationId
                 join stypeObj in context.ServiceType on sobj.SerTypeId equals stypeObj.STypeId
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
    public bool AddNewService(long SrcId, long DestId,long SrvTypeId,double Distance)
    {
        Service service = new Service()
        {
            DestLocId=DestId,
            SourceLocId=SrcId,
            SerTypeId=SrvTypeId,
            Distance=Distance,
        };
        context.services.Add(service);
        int Rec=context.SaveChanges();
        return Rec> 0;
 
    }
    public void AddBooking(long BookingId, long ServiceId, DateTime BookingDate, int SeatCount, string booked)
    {
        var booking = new TravelEzeeWinUIConsole.Booking
        {
            BookId = BookingId,
            ServiceId = ServiceId,
            TravelDate = BookingDate,
            SeatCount = SeatCount,
            BookBy = booked
        };
        context.bookings.Add(booking);
        context.SaveChanges();
    }

}
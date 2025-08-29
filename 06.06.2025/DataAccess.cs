using Microsoft.EntityFrameworkCore;Add commentMore actions
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class DataAccess
{
    TravelEzeeEFContext context;

    public DataAccess(){
        context = new TravelEzeeEFContext();
    }
    public List<Location> GetAllLocations(){
        return context.locations.ToList();
    }
    public List<ServiceType> GetAllServiceType(){
        return context.ServiceType.ToList();
    }
    public List<Services> GetAllServices(){
        return context.Services.ToList();
    }
      public List<Booking> GetAllBookings()
    {
        return context.bookings.ToList();
    }
    public List<Services> GetServicesBasedLocation(long SrcLoc, long DestLoc){
        return context.Services.Where(srv=>srv.SourceLocId==SrcLoc && srv.DestLocId==DestLoc).ToList();
    }

    //CRUD Operations in entities

    public bool AddLocation(long Id, string Name, string? Descr)
    {
        Location loc=new Location(){
            LocationId= Id,
            LocationDescription= Descr,
            LocationName=Name
        };
        context.locations.Add(loc);
        int RecCount= context.SaveChanges();
        return RecCount>0;
    }

    public bool AddService(long SerTypeId,long SrcLocId,long DesLocId,double Dist)
    {
        Services srv=new Services()
        {
            SerTypeId=SerTypeId,
            SourceLocId=SrcLocId,
            DestLocId=DesLocId,
            Distance=Dist,
        };
        context.Services.Add(srv);
        int Res=context.SaveChanges();
        return Res>0;
    }
    
    public bool AddServiceType(string ServTypeName,double pricePerKm)
    {
        var typeList=context.ServiceType.ToList();
        long NextAvailId = 1;
        if (typeList.Count > 0) {
            NextAvailId = typeList.Max(t => t.STypeId)+1;
        }
        ServiceType srvType = new ServiceType()
        {
            STypeId=NextAvailId,
            ServiceTypeName = ServTypeName,
            PricePerKm = pricePerKm
        };
        context.ServiceType.Add(srvType);
        int RecEffected = context.SaveChanges();
        if (RecEffected > 0) {
            return true;
        }
        else { return false; }
    }
    public void AddBooking( long BookingId, long ServiceId, DateTime BookingDate, int SeatCount, string booked)
    {
        var booking = new Booking
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

    public List<ServiceEntry> GetAllServicesView()
    {
        var Res=(from sobj in context.Services
                join SrcLocObj in context.locations on sobj.SourceLocId equals SrcLocObj.LocationId
                join DestLocObj in context.locations on sobj.DestLocId equals DestLocObj.LocationId
                join STypeObj in context.ServiceType on sobj.SerTypeId equals STypeObj.STypeId
                select new ServiceEntry(){
                    ServiceId= sobj.ServiceId,
                    Source = SrcLocObj.LocationName,
                    Destination= DestLocObj.LocationName,
                    ServiceTypeName=STypeObj.ServiceTypeName,
                    Distance = sobj.Distance
                }).ToList();
                return Res;
    }
}
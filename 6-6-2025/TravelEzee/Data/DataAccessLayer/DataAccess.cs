using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TravelEzeeEFCoreConsole;
using TravelEzeeEFCoreConsole.Data.DTO;
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
    public List<Service> GetAllServices(){
        return context.services.ToList();
    }
      public List<Booking> GetAllBookings()
    {
        return context.bookings.ToList();
    }
    public List<Service> GetServicesBasedLocation(long SrcLoc, long DestLoc){
        return context.services.Where(srv=>srv.SourceLocId==SrcLoc && srv.DestLocId==DestLoc).ToList();
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
    public List<ServiceEntry> GetAllServiceView()
    {
        var Res=(from sobj in context.services
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
    public bool AddNewService(long SrcId, long DestId, long SrvTypeId, double Distance)
    {
        Service service = new Service()
        {
            DestLocId = DestId,
            SourceLocId = SrcId,
            SerTypeId = SrvTypeId,
            Distance = Distance
        };
        context.services.Add(service);
        int Rec=context.SaveChanges();
        return Rec>0; 

    }

    
}
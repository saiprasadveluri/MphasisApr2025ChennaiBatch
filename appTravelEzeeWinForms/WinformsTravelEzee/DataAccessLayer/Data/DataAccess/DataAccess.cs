using Microsoft.Data.SqlClient;
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
       public List<Booking> GetAllBookings()
    {
        return context.booking.ToList();
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
    public bool AddServiceType(string Name,double Price)
    {
        var typelist = context.servicetype.ToList();
        long NextAvailId = 1;
        if(typelist.Count>0)
        {
            NextAvailId = typelist.Max(t => t.STypeId) + 1;

        }
        ServiceType srvType =new ServiceType()
        {
            STypeId=NextAvailId,
            ServiceTypeName = Name,
            PricePerKm=Price,

            
        };
        context.servicetype.Add(srvType);
        int RecEffected=context.SaveChanges();
        if (RecEffected > 0)
            return true;
        else return false;
        
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

    public bool AddNewService(long SrcId,long DestId,long SrvTypeId,double Dist)
    {
        Service service = new Service()
        {
            DestLocId=DestId,
            SourceLocId=SrcId,
            Distance=Dist,
            SerTypeId=SrvTypeId,

        };
        context.services.Add(service);
        int Rec=context.SaveChanges();
        return Rec > 0;

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
    context.booking.Add(book);
    int bookCount = context.SaveChanges();
    return bookCount>0;
    }

    public bool DeleteLocation(long id)
    {
        //var serviceslist = context.services.Where(loc => loc.SourceLocId == id || loc.DestLocId == id);
        //context.services.RemoveRange(serviceslist);
        var Loclist = context.locations.FirstOrDefault(loc => loc.LocationId == id);
        context.locations.Remove(Loclist);
        int del=context.SaveChanges();
        return del>0;
    }

    public bool DeleteService(long Serid)
    {
        
        var Serlist = context.services.FirstOrDefault(ser => ser.ServiceId == Serid);
        context.services.Remove(Serlist);
        int del = context.SaveChanges();
        return del > 0;
    }
   
    public bool DeleteServiceType(long Sertypeid)
    {
        var serviceslist = context.services.Where(loc => loc.SourceLocId == Sertypeid || loc.DestLocId == Sertypeid);
        context.services.RemoveRange(serviceslist);
        var Sertypelist = context.servicetype.FirstOrDefault(ser => ser.STypeId == Sertypeid);
        context.servicetype.Remove(Sertypelist);
        int del = context.SaveChanges();
        return del > 0;
    }


    public bool EditLocations(long locid,string locname)
    {
        Location loct = context.locations.FirstOrDefault(loc => loc.LocationId == locid);
        if(loct!=null)
        {
            loct.LocationName = locname;
        }
        int Res=context.SaveChanges();
        return Res > 0;
    }


}
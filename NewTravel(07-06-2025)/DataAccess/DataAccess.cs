public class DataAccess
{
    public TravelEzeeEFContext tContext;
    public DataAccess()
    {
        tContext=new TravelEzeeEFContext();
    }
    public List<Location> GetAllLocations()
    {
        return tContext.Locations.ToList();
    }
    public List<ServiceType> GetAllServiceTypes()
    {
        return tContext.ServiceTypes.ToList();
    }
    public List<Service> GetAllServices()
    {
        return tContext.Services.ToList();
    }
    public List<Booking> GetAllBookings()
    {
        return tContext.Bookings.ToList();
    }
    public List<Service> GetServicesBasedOnLocation(long SrcLoc,long destLoc)
    {
        return tContext.Services.Where(srv=>srv.SourceLocId==SrcLoc && srv.DestLocId==destLoc).ToList();
    }

    //update operations
    //public bool UpdateServiceType(long locid, string locname)
    //{
    //    Location curLoc = tContext.Locations.FirstOrDefault(l => l.LocationId == locid);
    //    if (curLoc != null)
    //    {
    //        curLoc.LocationName = locname;
    //    }
    //    int Res = tContext.SaveChanges();
    //    return Res > 0;
    //}
    public bool UpdateLocation(long locid,string locname)
    {
        Location curLoc=tContext.Locations.FirstOrDefault(l=>l.LocationId==locid);
        if (curLoc != null)
        {
            curLoc.LocationName=locname;
        }
        int Res = tContext.SaveChanges();
        return Res > 0;
    }

    //Delete operations
    public bool DeleteServices(long srvid)
    {
        var servicesList = tContext.Services.FirstOrDefault(s => s.ServId == srvid);
        tContext.Services.Remove(servicesList);
        int del = tContext.SaveChanges();
        return del > 0;
    }
    public bool DeleteServicesType(long srvTypeid)
    {
        var servicesList = tContext.Services.FirstOrDefault(s => s.ServTypeId == srvTypeid);
        tContext.Services.Remove(servicesList);
        var srvTypeList = tContext.ServiceTypes.FirstOrDefault(srv => srv.ServTypeId == srvTypeid);
        tContext.ServiceTypes.Remove(srvTypeList);
        int del = tContext.SaveChanges();
        return del > 0;
    }
    public bool DeleteLocation(long Locid)
    {
        //var  servicesList= tContext.Services.Where(loc => loc.SourceLocId == Locid || loc.DestLocId==Locid).ToList();
        //tContext.Services.RemoveRange(servicesList);
        var locList = tContext.Locations.FirstOrDefault(loc => loc.LocationId == Locid);
        tContext.Locations.Remove(locList);
        int del=tContext.SaveChanges();
        return del>0;
    }
    //getting data based on specifications
    public List<Service> GetServicesBasedonLocation(long SrcLoc, long destLoc)
    {
        return tContext.Services.Where(srv => srv.SourceLocId == SrcLoc && srv.DestLocId == destLoc).ToList();
    }
    public List<ServiceEntry> GetServicesBasedonLocationView(long SrcLoc, long destLoc)
    {
        var res = (from sobj in tContext.Services
                   join stypeLocObj in tContext.ServiceTypes on sobj.ServTypeId equals stypeLocObj.ServTypeId
                   where sobj.SourceLocId == SrcLoc && sobj.DestLocId==destLoc
                   select new ServiceEntry()
                   {
                       ServId = sobj.ServId,
                       ServiceTypeName = stypeLocObj.ServiceTypeName,
                       Distance = sobj.Distance
                   }).ToList();
        return res;
    }

    public List<ServiceEntry> GetAllServicesView()
    {
        var Res = (from sobj in tContext.Services
                    join srcLocObj in tContext.Locations on sobj.SourceLocId equals srcLocObj.LocationId
                    join destLocObj in tContext.Locations on sobj.DestLocId equals destLocObj.LocationId
                    join stypeLocObj in tContext.ServiceTypes on sobj.ServTypeId equals stypeLocObj.ServTypeId
                   select new ServiceEntry()
                    {
                        ServId = sobj.ServId,
                        SourceLocName = srcLocObj.LocationName,
                        DestLocName = destLocObj.LocationName,
                        ServiceTypeName = stypeLocObj.ServiceTypeName,
                        Distance = sobj.Distance
                    }).ToList();
                    return Res;
    }
//insert data into tables
public bool AddLocation(long LocId,string LocName,string? Desc)
    {
        Location loc=new Location()
        {
            LocationId=LocId,
            LocationName=LocName,
            LocationDescription=Desc
        };
        tContext.Locations.Add(loc);
        int Res=tContext.SaveChanges();
        return Res>0;
    }
    public bool AddService(long SerTypId,long SrcLocId,long DesLocId,double Dist)
    {
        Service srv=new Service()
        {
            ServTypeId=SerTypId,
            SourceLocId=SrcLocId,
            DestLocId=DesLocId,
            Distance=Dist,
        };
        tContext.Services.Add(srv);
        int Res=tContext.SaveChanges();
        return Res>0;
    }
    public bool AddServiceType(string ServTypeName,double pricePerKm)
    {
        long nextSrvId = 1;
        var typeList = tContext.ServiceTypes.ToList();
        if (typeList.Count > 0)
        {
            nextSrvId = typeList.Max(l => l.ServTypeId)+1;
        }
        ServiceType srvType=new ServiceType()
        {
            ServTypeId= nextSrvId,
            ServiceTypeName=ServTypeName,
            PricePerKm=pricePerKm
        };
        tContext.ServiceTypes.Add(srvType);
        int Res=tContext.SaveChanges();
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
        tContext.Bookings.Add(books);
        int Res=tContext.SaveChanges();
        return Res>0;
    }
}
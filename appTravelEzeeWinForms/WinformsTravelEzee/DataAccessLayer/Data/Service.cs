using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

public class Service
{
    [Key]
    
    public long ServiceId{get;set;}
    [ForeignKey(nameof(ServiceType))]

    public long SerTypeId{get;set;}

    [ForeignKey(nameof(Source))]

    public long SourceLocId{get;set;}
    [ForeignKey(nameof(Destination))]

    public long DestLocId{get;set;}
    [DefaultValue(10)]

    public double Distance{get;set;}

    public Location Source {get;set;}

    public Location Destination{get;set;}

    public ServiceType ServiceType{get;set;}

   public List<Booking> CurBookings{get;set;}

}
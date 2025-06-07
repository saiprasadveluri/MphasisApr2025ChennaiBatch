using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Service
{
    [Key ]
    public long ServiceId { get; set; }
    [ForeignKey(nameof(SericeType))]
    public long SerTypeId { get; set; }

    // [ForeignKey(nameof(Source))]
    public long SourceLocId { get; set; }

    //[ForeignKey(nameof(Destination))]
    public long DestLocId { get; set; }

    [DefaultValue(10)]
    public double Distance { get; set; }
    //Navigation Props
    public Location Source { get; set; }    
    public Location Destination { get; set; }
    public ServiceType SericeType { get; set; }
    public List<Booking> CurBookings{ get; set; }
}
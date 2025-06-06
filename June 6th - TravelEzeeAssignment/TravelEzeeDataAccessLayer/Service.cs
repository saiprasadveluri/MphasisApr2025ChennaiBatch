using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Service
{
    [Key]
    public long ServiceId { get; set; }
    [ForeignKey(nameof(ServiceType))]
    public int ServiceTypeId { get; set; }

    // [ForeignKey(nameof(Source))]
    public int SourceLocationId { get; set; }

    //[ForeignKey(nameof(Destination))]
    public int DestinationLocationId { get; set; }

    [DefaultValue(10)]
    public float DistanceKm { get; set; }
    //Navigation Props
    public Location? Source { get; set; }    
    public Location? Destination { get; set; }
    public ServiceType? ServiceType { get; set; }
    public List<Booking>? CurBookings { get; set; }
}
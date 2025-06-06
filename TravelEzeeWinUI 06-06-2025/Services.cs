using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
public class Services{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    public long ServiceId { get; set;}
    //[ForeignKey(nameof(ServiceType))]
    public long SerTypeId { get; set;}
    //[ForeignKey(nameof(Source))]
    public long SourceLocId { get; set;}
    public long DestLocId { get; set;}
    [DefaultValue(10)]
    public double Distance { get; set;}
    public Location Source { get; set;}
    public Location Destination { get; set;}
    [ForeignKey(nameof(SerTypeId))]
    public ServiceType ServiceType { get; set;}

    //Navigations props
   public List<Booking> CurrBookings { get; set;}
}
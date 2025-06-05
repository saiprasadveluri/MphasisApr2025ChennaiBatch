using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Location
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    public long LocationId { get; set; }
    
    [StringLength(20)]
    public string LocationName { get; set; }
    public string? LocationDescription { get; set; }
    //Navigation Props
    public List<Service> SourceServiceList { get; set; }
    public List<Service> DestServiceList { get; set; }
}
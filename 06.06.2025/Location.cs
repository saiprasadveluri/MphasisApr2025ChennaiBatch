using System.ComponentModel.DataAnnotations;Add commentMore actions
using System.ComponentModel.DataAnnotations.Schema;
public class Location{

    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    public long LocationId { get; set;}
    [StringLength(20)]
    public string LocationName { get; set;}
    
    public string? LocationDescription { get; set;}

    //NAvigation Props
    public List<Services> SourceServiceList { get; set;}
    public List<Services> DestServiceList { get; set;}
}
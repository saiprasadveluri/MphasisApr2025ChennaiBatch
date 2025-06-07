using TravlEzeeDataAccessLayer.Models;
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


    public List<Service> ServiceList { get; set; }
    public List<Service> DestServiceList { get; set; }

}
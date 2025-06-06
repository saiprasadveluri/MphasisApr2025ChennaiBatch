using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TravelEezeDataAccessLayer;

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

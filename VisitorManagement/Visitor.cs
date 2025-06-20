using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VisitorManagement
{
    public class Visitor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int VisitorId {get;set;}
        //[ForeignKey(nameof(Host.HostId))]
        public int HostId {get;set;}
        [Required]
        public string? VisitorName {get;set;}
        //[ForeignKey(nameof(Location.LocationId))]
        public int LocationId {get;set;}
        [Required]
        public string? Company {get;set;}
        public string? Purpose { get;set;}
        [Required]
        public string? Phone {get;set;}
        [ForeignKey("HostId")]
        public Host? Hosts {get;set;}
        [ForeignKey("LocationId")]
        public Location? Locations {get;set;}
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using TravelEasyDB;
using System.Text;
using System.Threading.Tasks;

namespace TravelEasyDB
{
    public class Location
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long LocationId { get; set; }
        [StringLength(20)]
        public required string LocationName { get; set; }
        public string? LocationDescription { get; set; }

        [InverseProperty("Source")]
        public List<Service> SServiceList { get; set; } = new List<Service>();
        [InverseProperty("Destination")]
        public List<Service> DServiceList { get; set; } = new List<Service>();


    }
}

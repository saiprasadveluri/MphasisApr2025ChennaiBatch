using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelEasyDB
{
    public class Service
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ServiceId { get; set; }
        [ForeignKey(nameof(ServiceType))]
        public long ServiceTypeId { get; set; }
        /// <summary>
        [ForeignKey(nameof(Source))]
        /// </summary>
        public long SLocationId { get; set; }
        [ForeignKey (nameof(Destination))]
        public long DLocationId { get; set; }
        public double Distance { get; set; }

       
        public Location Source { get; set; } = null!;
        
        public Location Destination { get; set; } = null!;
        public ServiceType? ServiceType { get; set; }

        public List<Booking> BookingList { get; set; } = new List<Booking>();
    }
}

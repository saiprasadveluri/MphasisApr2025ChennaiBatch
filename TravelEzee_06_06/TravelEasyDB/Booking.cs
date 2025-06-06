using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelEasyDB;

namespace TravelEasyDB
{
    public class Booking
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long BookingIds { get; set; }
        [ForeignKey(nameof(TravelService))]
        public long ServiceId { get; set; }
        public DateTime TravelDate { get; set; }
        public int SeatCount { get; set; }
        public string BookedBy { get; set; } = string.Empty;
        public Service? TravelService { get; set; }
    }
}

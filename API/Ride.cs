using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RideAppApi
{
    public class Ride
    {
        [Key]
        public int RideId { get; set; }
        public int PId { get; set; }
        [ForeignKey(nameof(PId))]
        public PickUpDrop? PickUpDrop { get; set; }
        public double Distance { get; set; }
        public double CostPerKm { get; set; }
    }
}

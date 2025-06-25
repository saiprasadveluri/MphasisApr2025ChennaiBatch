using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace RideAppAgg
{
    public class Ride
    {


        [Key]
        public int RId { get; set; } // Unique identifier for the ride
        public int PId { get; set; } // Foreign key to the PickupDrop table
        //[ForeignKey(nameof(PId))]
        //public PickupDrop? PickupDrop{get; set; } // Navigation property to PickupDrop 

        public double Distance { get; set; }
        public double CostPerKm { get; set; }

      
    }

}

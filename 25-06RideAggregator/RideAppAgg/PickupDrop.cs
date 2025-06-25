using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace RideAppAgg
{
    public class PickupDrop
    {

        [Key]
        public int PId { get; set; } // Unique identifier for the pickup/drop record
        public int DId { get; set; } // Foreign key to the Driver
        //[ForeignKey(nameof(DId))]
        //public Driver? Driver { get; set; }
        public int CId { get; set; } // Foreign key to the Customer
        //[ForeignKey(nameof(CId))]
        //public Customer? Customer { get; set; }

        public int PickupLocationId { get; set; } // Foreign key to the Pickup Location
        //[ForeignKey(nameof(PickupLocationId))]
        //public Location? PickupLocation { get; set; }

        public int DropLocationId { get; set; } // Foreign key to the Drop Location
        //[ForeignKey(nameof(DropLocationId))]
        //public Location? DropLocation { get; set; }


        public DateTime PickupTime { get; set; } // Time of pickup
        public DateTime DropTime { get; set; } // Time of drop-off

        


       
     
       

        
       
    }
}


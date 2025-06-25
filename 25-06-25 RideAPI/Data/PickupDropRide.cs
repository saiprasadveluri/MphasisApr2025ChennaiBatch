using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RideAggregatorAPI.Data
{
    public class PickupDropRide
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PickupDropRideId { get; set; }

        public int CustomerId { get; set; }
        public int DriverId { get; set; }
        public int SourceLocationId { get; set; }
        public int DestinationLocationId { get; set; }

       
        public double Distance { get; set; }


        public Customer Customer { get; set; }
        public Driver Driver { get; set; }
        public Location SourceLocation { get; set; }
        public Location DestinationLocation { get; set; }
    }
}

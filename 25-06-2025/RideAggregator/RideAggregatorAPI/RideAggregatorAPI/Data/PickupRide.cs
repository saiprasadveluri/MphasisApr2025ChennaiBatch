using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RideAggregatorAPI.Data
{
    public class PickupRide
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid PickupRideId { get; set; }
        
        [Required]
        [ForeignKey("SrcLocationdata")]
        public Guid SourceLocation { get; set; }

        [Required]
        [ForeignKey("DestLocationdata")]
        public Guid DestinationLocation { get; set; }

        [Required]
        [ForeignKey("Customerdata")]
        public Guid CustomerId { get; set; }

        [Required]
        [ForeignKey("Driverdata")]
        public Guid DriverId { get; set; }

        //Navigation Property
        public Customer Customerdata { get; set; }
        public Driver Driverdata { get; set; }
        public Location SrcLocationdata { get; set; }
        public Location DestLocationdata { get; set; }


    }
}

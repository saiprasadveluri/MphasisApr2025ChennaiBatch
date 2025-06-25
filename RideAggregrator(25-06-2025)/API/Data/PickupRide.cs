using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RideAggregatorAPI.Data
{
    public class PickupRide
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid PickupId { get; set; }
        [Required]
        [ForeignKey(nameof(Customer))]
        public Guid CustomerId { get; set; }
        [Required]
        [ForeignKey(nameof(Driver))]
        public Guid DriverId { get; set; }
        [Required]
        [ForeignKey(nameof(SrcLocation))]
        public Guid SourceId { get; set; }
        [Required]
        [ForeignKey(nameof(DestLocation))]
        public Guid DestinationId { get; set; }
        [Required]
        public double Distance { get; set; }

        //Navigation
        public CustomerData Customer { get; set; }
        public DriverData Driver { get; set; }
        public Location SrcLocation { get; set; }
        public Location DestLocation { get; set; }
    }
}
using RideAggregateAPI.DTO;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RideAggregateAPI.Data
{
    public class PickUpDropRide
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long pickUpId { get; set; }
        [Required]
        [ForeignKey(nameof(Customer))]
        public Guid custId { get; set; }
        [Required]
        [ForeignKey(nameof(Driver))]
        public Guid driverId { get; set; }
        [Required]
        [ForeignKey(nameof(SrcLocation))]
        public Guid sourceId { get; set; }
        [Required]
        [ForeignKey(nameof(DestLocation))]
        public Guid destinationId { get; set; }
        [Required]
        public double distance { get; set; }


        //Navigation
        public CustomerInfo Customer { get; set; }
        public DriverInfo Driver { get; set; }
        public Location SrcLocation { get; set; }
        public Location DestLocation { get; set; }

    }
}

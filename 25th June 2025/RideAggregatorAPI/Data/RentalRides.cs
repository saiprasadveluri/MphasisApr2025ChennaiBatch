using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RideAggregatorAPI.Data
{
    public class RentalRides
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid RetalRideId { get; set; }
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
        public double Distance { get; set; }
        [Required]
        public int HiredDays { get; set; }

        public CustomerInfo Customer { get; set; }
        public DriverInfo Driver { get; set; }
        public LocationInfo SrcLocation { get; set; }

    }
}

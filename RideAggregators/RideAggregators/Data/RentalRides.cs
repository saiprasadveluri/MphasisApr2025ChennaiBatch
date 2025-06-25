using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RideAggregators.Data
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
        //Navigation
        public CustomerData Customer { get; set; }
        public DriverData Driver { get; set; }
        public Location SrcLocation { get; set; }
    }
}

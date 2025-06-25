using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RideAggregatetorMVCAPI.DTO
{
    public class RentalRide
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid RentalRideId { get; set; }
        public int HiredDays {  get; set; }
        public double Distance {  get; set; }
        [Required]
        public double PricePerKm {  get; set; }
        
        [Required]
        [ForeignKey("DidRide")]
        public Guid DriverId { get; set; }
       
        [Required]
        [ForeignKey("CRide")]
        public Guid CustomerId { get; set; }
       
        public Customer Cidide {  get; set;}
        public Driver DidRide { get; set; }


    }
}

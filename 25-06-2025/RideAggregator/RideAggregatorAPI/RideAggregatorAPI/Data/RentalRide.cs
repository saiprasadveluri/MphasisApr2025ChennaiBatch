using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RideAggregatorAPI.Data
{
    public class RentalRide
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid RentalId { get; set; }

        [Required]
        public double Distance{ get; set; }
         
        [Required]
        public int HiredDays { get; set; }

        [Required]
        [ForeignKey("Customerdata")]
        public Guid CustomerId { get; set; }

        [Required]
        [ForeignKey("Driverdata")]
        public Guid DriverId { get; set; }
        
        //Navigation Property
        public Customer Customerdata { get; set; }
        public  Driver Driverdata { get; set; }


    }
}

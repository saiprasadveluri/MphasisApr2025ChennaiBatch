using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RideAggregatorAPI.Data
{
    public class Customer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid CustomerId { get; set; }
        
        [Required]
        [ForeignKey("Userdata")]
        public Guid UserId { get; set; }
        public string CustomerName { get; set; }
       
        [Required]
        public string CustomerPhone { get; set; }
       
        
        public User userdata { get; set; }//Navigation Property
        public List<RentalRide> RentalRides { get; set; }
        public List<PickupRide> PickpRides { get; set; }




    }
}

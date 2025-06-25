using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RideAggregatetorMVCAPI.DTO
{
    public class Customer
    {
       
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid CustomerId { get; set; }
        [Required]

        [ForeignKey("CustId")]
        public Guid UserId { get; set; }
        public string CustomerName { get; set; }
        [Required]
       
        public UserInfo CustId { get; set; }
        public List<PickUpDropRide> PCRides { get; set; }
        public List<RentalRide> RCRides { get; set; }
    }
}

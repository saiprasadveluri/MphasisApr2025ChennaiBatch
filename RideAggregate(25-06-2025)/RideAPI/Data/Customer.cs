using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RideAPI.Data
{
    public class Customer
    {
        [Key]
        public Guid CustId { get; set; }
        [Required]
        [ForeignKey("userData")]
        public Guid UserId { get; set; }
        [Required]
        public string CustName { get; set; }
        public string CustPhnno {  get; set; }

        //navigation property
        public UserData userData { get; set; }
        public List<RentalRide> rentalRides { get; set; }
        public List<PickupRide> pickupRides { get;set; }
    }
}

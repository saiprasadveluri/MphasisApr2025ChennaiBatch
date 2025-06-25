using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RideAPI.Data
{
    public class Driver
    {
        [Key]
        public Guid DriverId { get; set; }

        [Required]
        [ForeignKey("userData")]
        public Guid UserId { get; set; }

        public string DriverName { get; set; }
        public double DriverRating {  get; set; }

        //navigation property
        public UserData userData { get; set; }
        public List<RentalRide> rentalRides { get; set; }
        public List<PickupRide> pickupRides { get; set; }

    }
}

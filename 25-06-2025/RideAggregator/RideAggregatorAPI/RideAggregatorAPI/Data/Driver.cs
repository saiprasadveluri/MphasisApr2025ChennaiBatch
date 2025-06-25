using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RideAggregatorAPI.Data
{
    public class Driver
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid DriverId { get; set; }
        [Required]
        [ForeignKey("Userdata")]
        public Guid UserId { get; set; }
        public string DriverName { get; set; }
        public string DriverRating { get; set; }
        public  User userdata { get; set; }
        public List<RentalRide> RentalRides { get; set; }
        public List<PickupRide> PickpRides { get; set; }

    }
}

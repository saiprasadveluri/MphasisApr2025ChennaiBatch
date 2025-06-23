using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RideAggregatorAPI.Data
{
    public class DriverData
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid DriverId { get; set; }
        [Required]
        [ForeignKey(nameof(LoginInfo))]
        public Guid LoginId { get; set; }
        [Required]
        [StringLength(10)]
        public string PhoneNumber { get; set; }
        [Required]
        [StringLength(30)]
        public string DriverName { get; set; }
        //Navigation
        public UserData LoginInfo { get; set; }
        public List<PickupRide> PickupRides { get; set; }
        public List<RentalRide> RentalRides { get; set; }
    }
}

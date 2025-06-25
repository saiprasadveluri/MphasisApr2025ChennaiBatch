using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RideAggregators.Data
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
        public List<RentalRides> RentalRides { get; set; }
    }
}


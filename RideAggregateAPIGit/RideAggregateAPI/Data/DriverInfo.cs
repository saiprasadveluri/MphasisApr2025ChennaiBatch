using RideAggregateAPI.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RideAggregateAPI.DTO
{
    public class DriverInfo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid DriverId { get; set; }
        [Required]
        [ForeignKey(nameof(userInfo))]
        public Guid LoginId { get; set; }
        [Required]
        [StringLength(10)]
        public string PhoneNumber { get; set; }
        [Required]
        [StringLength(30)]
        public string DriverName { get; set; }
        public string VehicleName { get; set; }
        public string VehicleNo { get; set; }
        public UserInfo userInfo { get; set; }
        public List<PickUpDropRide> PickupRides { get; set; }
        public List<RentalRide> RentalRides { get; set; }

    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RideAggregatorAPI.Data
{
    public class DriverInfo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid DriverId { get; set; }
        [Required]
        [ForeignKey(nameof(UserInfo))]
        public Guid LoginId { get; set; }
        [Required]
        [StringLength(30)]
        public string DriverName { get; set; }
        [Required]
        [StringLength(10)]
        public string ContactNo { get; set; }
        
        public UserInfo UserInfo { get; set; }
        public List<PickUpDropRide> pickUpDropRides { get; set; }
        public List<RentalRides> RentalRides { get; set; }
        
    }
}

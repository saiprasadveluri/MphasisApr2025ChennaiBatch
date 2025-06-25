using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RideAggregatetorMVCAPI.DTO
{
    public class Driver
    {
        
        [Required]
        [ForeignKey("DriveId")]
        public Guid UserId { get; set; }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid DriverId { get; set; }
        [Required]
        public string DriverName { get; set; }
        [Required]
        
        public UserInfo DriveId { get; set; }
        public List<PickUpDropRide> PDRides { get; set; } 
        public List<RentalRide> RDRides { get; set; }


    }
}

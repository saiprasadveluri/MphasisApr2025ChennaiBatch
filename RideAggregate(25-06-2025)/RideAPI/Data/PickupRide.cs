using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RideAPI.Data
{
    public class PickupRide
    {
        [Key]
        public Guid PickId { get; set; }

        [Required]
        [ForeignKey("srcLocationData")]
        public Guid SourceLoc {  get; set; }

        [Required]
        [ForeignKey("destLocationData")]
        public Guid DestinationLoc { get; set; }

        [Required]
        [ForeignKey("custData")]
        public Guid CustId { get; set; }

        [Required]
        [ForeignKey("driveData")]
        public Guid DriverId {  get; set; }

        //Navigation property
        public Customer custData { get; set; }

        public Driver driveData {  get; set; }
        public Location srcLocationData { get; set; }
        public Location destLocationData { get; set; }

    }
}

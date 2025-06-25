using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RideAggregatetorMVCAPI.DTO
{
    public class PickUpDropRide
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid PickUpRideId { get; set; }
        public int Price {  get; set; }
        [Required]
        [ForeignKey("SrcLocation")]
        public Guid SourceLoc {  get; set; }
        [Required]
        [ForeignKey("DestLocation")]
        public Guid DestinationLoc { get; set; }
        [Required]
        [ForeignKey("DriId")]
        public Guid DriverId { get; set; }
        
        [Required]
        [ForeignKey("CustId")]
        public Guid CustomerId { get; set; }
       

        public Location SrcLocation { get; set; }
        public Location DestLocation { get; set; }
        public Customer CustId { get; set; }
        public Driver DriId { get; set; }
    }
}

using RideAggregateAPI.DTO;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RideAggregateAPI.Data
{
    public class PickUpDropLocation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long PickUpId { get; set; }
        [Required]
        [ForeignKey(nameof(CustomerInfo))]
        public Guid CustId { get; set; }
        [Required]
        [ForeignKey(nameof(DriverInfo))]
        public Guid DriverId { get; set; }
        [Required]
        [ForeignKey(nameof(SrcLocation))]
        public Guid SourceId { get; set; }
        [Required]
        [ForeignKey(nameof(DestLocation))]
        public Guid DestinationId { get; set; }
        [Required]
        public double Distance { get; set; }


        //Navigation
        public CustomerInfo Customer { get; set; }
        public DriverInfo Driver { get; set; }
        public Location SrcLocation { get; set; }
        public Location DestLocation { get; set; }

    }
}

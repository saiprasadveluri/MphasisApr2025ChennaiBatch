using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RideAggrigationAPI.Data
{
    public class Rental
    {
        [Key]
        [Required]
        public Guid RentalId { get; set; }

        
        [ForeignKey("Customer")]
        public Guid CustomerId { get; set; }
        public Customer Customer { get; set; }

        
        [ForeignKey("Driver")]
        public Guid DriverId { get; set; }
        public Driver Driver { get; set; }

        
        [ForeignKey("SourceLocation")]
        public Guid SourceLocationid { get; set; }
        public Location SourceLocation { get; set; }

 
        [ForeignKey("DestinationLocation")]
        public Guid DistinationLocationid { get; set; }
        public Location DestinationLocation { get; set; }

    }
}

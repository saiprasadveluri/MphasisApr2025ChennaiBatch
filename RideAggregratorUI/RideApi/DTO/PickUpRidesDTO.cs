using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RideApi.DTO
{
    public class PickUpRidesDTO
    {
        public Guid PickupId { get; set; }
        
        public Guid CustomerId { get; set; }
       
        public Guid DriverId { get; set; }
       
        public Guid SourceId { get; set; }
        
        public Guid DestinationId { get; set; }
      
        public double Distance { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
    }
}

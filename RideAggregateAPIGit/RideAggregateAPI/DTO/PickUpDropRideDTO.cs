using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RideAggregateAPI.DTO
{
    public class PickUpDropRideDTO
    {
        public long pickUpId { get; set; }
        public Guid custId { get; set; }
        public Guid driverId { get; set; }
        public Guid sourceId { get; set; }
        public Guid destinationId { get; set; }
        public double distance { get; set; }
    }
}

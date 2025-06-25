using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RideAggregators.DTO
{
    public class RentalRidesDTO
    {
        public Guid RetalRideId { get; set; }
       
        public Guid CustomerId { get; set; }
       
        public Guid DriverId { get; set; }
       
        public Guid SourceId { get; set; }
       
        public double Distance { get; set; }
       
        public int HiredDays { get; set; }
    }
}

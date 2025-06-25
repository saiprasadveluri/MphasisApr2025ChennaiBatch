using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RideAggregatorAPI.Data
{
    public class RentalRide
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RentalRideId { get; set; }
        public int CustomerId { get; set; }
        public int DriverId { get; set; }
        public Driver Driver { get; set; }
        public Customer Customer { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public double Distance { get; set; }
    }
}

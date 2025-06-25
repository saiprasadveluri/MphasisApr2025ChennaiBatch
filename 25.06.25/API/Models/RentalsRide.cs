using System.ComponentModel.DataAnnotations.Schema;

namespace RideAggregatorApi.Models
{
    [Table("Rides")]
    public class RentalsRide:Ride
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int DriverId { get; set; }
        public DateTime CreatedAt { get; set; }
        public decimal MinimumFare { get; set; }
        public double TollFees { get; set; }
        public decimal BillAmount { get; set; }
        public bool IsCompleted { get; set; }

        public string PaymentMethod { get; set; } = string.Empty;
        public int Rating { get; set; }
        public bool IsAccepted { get; set; } = false;
        public DateTime? AcceptedAt { get; set; }
        public DateTime? CompletedAt { get; set; }

        public string EstimatedDistance { get; set; } = string.Empty;
        public string EstimatedTime { get; set; } = string.Empty;
        public string VehicleType { get; set; }

    }

}

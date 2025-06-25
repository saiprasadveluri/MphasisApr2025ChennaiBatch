using System.ComponentModel.DataAnnotations;

namespace RideAggregatorWEBAPI.Data
{
    public class PickupDropRide
    {
        public int Id { get; set; }

        [Required]
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        [Required]
        public int DriverId { get; set; }
        public Driver Driver { get; set; }

        [Required]
        public int SourceLocationId { get; set; }
        public Location SourceLocation { get; set; }

        [Required]
        public int DestinationLocationId { get; set; }
        public Location DestinationLocation { get; set; }

        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        public double DistanceTravelled { get; set; }

        public string Status { get; set; } // Pending, Ongoing, Completed
    }
}


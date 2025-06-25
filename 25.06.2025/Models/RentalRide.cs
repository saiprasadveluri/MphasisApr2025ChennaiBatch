using System.ComponentModel.DataAnnotations;

namespace RideAggregatorWEBAPI.Data
{
    public class RentalRide
    {
        public int Id { get; set; }

        [Required]
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        [Required]
        public int DriverId { get; set; }
        public Driver Driver { get; set; }

        public DateTime StartDate { get; set; }

        public int HiredDays { get; set; }

        public double TravelDistance { get; set; }

        public decimal TollFees { get; set; }

        public string Status { get; set; } // Pending, Ongoing, Completed
    }
}

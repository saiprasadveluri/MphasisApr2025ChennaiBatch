using System.ComponentModel.DataAnnotations;

namespace RiderApp.Models
{
    public class Rental
    {
        [Key]
        public Guid RentalId { get; set; }

        [Required]
        public DateTime StartTime { get; set; }

        [Required]
        public DateTime EndTime { get; set; }

        [Required]
        public decimal TotalFare { get; set; }

        [Required]
        public Guid CustomerId { get; set; }

        [Required]
        public Guid DriverId { get; set; }

        // Navigation
        public Customer Customer { get; set; }
        public Driver Driver { get; set; }

    }
}

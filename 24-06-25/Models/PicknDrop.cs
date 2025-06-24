using System.ComponentModel.DataAnnotations;

namespace RiderApp.Models
{
    public class PicknDrop
    {
        [Key]
        public Guid RideId { get; set; }

        [Required]
        public DateTime RideTime { get; set; }

        [Required]
        public decimal Fare { get; set; }

        [Required]
        public Guid CustomerId { get; set; }

        [Required]
        public Guid DriverId { get; set; }

        [Required]
        public Guid PickupLocationId { get; set; }

        [Required]
        public Guid DropLocationId { get; set; }

        // Navigation
        public Customer Customer { get; set; }
        public Driver Driver { get; set; }
        public Location PickupLocation { get; set; }
        public Location DropLocation { get; set; }
    }

}


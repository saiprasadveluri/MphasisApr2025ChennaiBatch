using System.ComponentModel.DataAnnotations;

namespace RiderApp.Models
{
    public class Driver
    {
        [Key]
        public Guid DriverId { get; set; }

        [Required]
        [MaxLength(100)]
        public string DriverName { get; set; }

        [Required]
        [Phone]
        public string PhoneNumber { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string LicenseNumber { get; set; }


        public ICollection<PicknDrop> PicknDrops { get; set; }
        public ICollection<Rental> Rentals { get; set; }

    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Book.Data
{
    public class Seat
    {
        [Key]
        public int SeatId { get; set; }

        [Required]
        public int SeatNumber { get; set; } // e.g., 5

        [Required]
        [StringLength(10)] // e.g., "A", "B", "C"
        public int Row { get; set; }

        [Required]
        [StringLength(50)] // e.g., "Standard", "Premium", "VIP"
        public string Type { get; set; }

        [Required]
        [StringLength(20)] // e.g., "Available", "Booked", "Reserved", "Maintenance"
        public string Status { get; set; }

        // Foreign Key to Theatre
        [Required]
        public int TheatreId { get; set; }
        [Required]
        public virtual Theatre TheatreData { get; set; } // Navigation property to Theatre

        public virtual ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();
    }
}

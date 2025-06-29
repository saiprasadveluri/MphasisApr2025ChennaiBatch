using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Book.Data;

public class Booking
{
    [Key]
    public int BookingId { get; set; }

    [Required]
    [DataType(DataType.Date)]
    public DateTime BookingDate { get; set; }

    [Required]
    public int NumberOfTickets { get; set; }

    [Required]
    [StringLength(20)]
    public string Status { get; set; } // e.g., "Confirmed", "Pending", "Cancelled"

    [Required]
    public long TotalAmount { get; set; }

    // Foreign Key to User
    [Required]
    public int UserId { get; set; }
    [Required]
    public virtual User UserData { get; set; } // Navigation property to User

    // Foreign Key to MovieShow (the specific movie playing at a specific time in a specific theatre)
    [Required]
    public int MovieShowId { get; set; }
    [Required]
    public virtual MovieShow MovieShowData { get; set; } // Navigation property to MovieShow

    // One-to-Many relationship with Ticket
    // A Booking can have multiple Tickets
    public virtual ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();

    // Removed: MovieId, ShowId, TheatreId (direct FKs) as they are now via MovieShowData
    // Removed: TicketId and TicketData (inverted relationship)

}

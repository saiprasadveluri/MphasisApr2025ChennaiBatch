using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Book.Data
{
    public class Ticket
    {
        [Key]
        public int TicketId { get; set; }

        // Foreign Key to Booking
        [Required]
        public int BookingId { get; set; }
        [Required]
        public virtual Booking BookingData { get; set; } // Navigation property to Booking

        // Foreign Key to Seat (this is crucial, identifies the specific seat for THIS ticket)
        [Required]
        public int SeatId { get; set; }
        [Required]
        public virtual Seat SeatData { get; set; } // Navigation property to Seat

        // Removed: UserId, MovieId, TheaterId, ShowId, TicketDate
        // These are now accessible via Ticket -> Booking -> MovieShow -> (Movie/Show/Theatre) and Ticket -> Booking -> User
        // TicketDate is redundant with Booking.BookingDate or Show.ShowDate
    }
}

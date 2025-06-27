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

        public int UserId { get; set; }
        public User UserData { get; set; }

        public int MovieId { get; set; }
        public Movie MovieData { get; set; }

        public int TheaterId { get; set; }
        public Theatre TheatreData { get; set; }

        public int SeatNumbers { get; set; }
        public Seat SeatData { get; set; }

        public int ShowId { get; set; }
        public Show ShowData { get; set; }

        [DataType(DataType.Date)]
        public DateTime TicketDate { get; set; }

        [InverseProperty("TicketData")]
        public virtual ICollection<Booking> Bookings { get; set; } = new List<Booking>();
    }
}

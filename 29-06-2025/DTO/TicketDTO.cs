using Book.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Book.DTO
{
    public class TicketDTO
    {
        public int TicketId { get; set; }

        public int BookingId { get; set; }
        public int SeatId { get; set; }

    }
}

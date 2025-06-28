using Book.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Book.DTO
{
    public class TicketDTO
    {
        public int Ticketid { get; set; }
        public int UserId { get; set; }
        public int MovieId { get; set; }
        public int TheaterId { get; set; }
        public int SeatNumbers { get; set; }
        public int ShowId { get; set; }

        [DataType(DataType.Date)]
        public DateTime TicketDate { get; set; }
        public List<int> SeatIds { get; set; } = new List<int>();
    }
}

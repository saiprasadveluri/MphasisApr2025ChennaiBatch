using Book.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Book.DTO
{
    public class BookingDTO
    {
        public int BookingId { get; set; }
        public DateTime BookingDate { get; set; }
        public TimeOnly ShowTime { get; set; }
        public int MovieId { get; set; }
        public Movie MovieData { get; set; }
        public int NumberOfTickets { get; set; }
        public string Status { get; set; }
        public long TotalAmount { get; set; }
        public int UserId { get; set; }
        public int ShowId { get; set; }
        public int TheaterId { get; set; }

    }
}



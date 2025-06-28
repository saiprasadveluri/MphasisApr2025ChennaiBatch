using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Book.DTO
{
    public class SeatDTO
    {
        public int SeatId { get; set; }
        public int SeatNumber { get; set; }
        public int Row { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }
        public int TheatreId { get; set; }

    }
}

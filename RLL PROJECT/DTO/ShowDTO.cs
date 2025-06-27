using Book.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Book.DTO
{
    public class ShowDTO
    {
        public int ShowId { get; set; }
        [DataType(DataType.Date)]
        public DateTime ShowDate { get; set; }
        public TimeOnly ShowTime { get; set; }
        public int AvailableSeates { get; set; }
        public long Price { get; set; }
        public int MovieId { get; set; }
        public int TheatreId { get; set; }

    }
}

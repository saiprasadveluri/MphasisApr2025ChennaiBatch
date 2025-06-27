using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Book.Data
{
    public class Seat
    {
        [Key] 
        public int SeatId { get; set; }
        [Required]
        public int SeatNumber { get; set; }
        [Required]
        public int Row {  get; set; }
        [Required]
        public string Type {  get; set; }
        [Required]
        public string Status { get; set; }

        [ForeignKey("TheaterData")]
        public int TheatreId { get; set; }

        public Theatre TheatreData {  get; set; }
    }
}

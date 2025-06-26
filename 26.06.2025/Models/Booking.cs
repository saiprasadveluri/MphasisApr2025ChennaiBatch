using System.ComponentModel.DataAnnotations;

namespace BookMyShowApp.Models
{
    public class Booking
    {
        public int Id { get; set; }

        public int UserId { get; set; }
        public int MovieId { get; set; }
        public int TheatreId { get; set; }

        public DateTime ShowTime { get; set; }
        public string Status { get; set; }

        public User User { get; set; }
        public Movie Movie { get; set; }
        public Theatre Theatre { get; set; }
    }
}

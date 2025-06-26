using System.ComponentModel.DataAnnotations;

namespace BookMyShowApp.Models
{
    public class Rating
    {
        public int Id { get; set; }

        public int UserId { get; set; }
        public int MovieId { get; set; }

        public int Stars { get; set; } // 1–5 star rating

        public User User { get; set; }
        public Movie Movie { get; set; }
    }
}

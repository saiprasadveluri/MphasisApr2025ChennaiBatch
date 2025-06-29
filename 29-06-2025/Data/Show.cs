using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Book.Data
{
    public class Show
    {

        [Key]
        public int ShowId { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime ShowDate { get; set; } // Specific date of the show instance

        [Required]
        public TimeOnly ShowTime { get; set; } // Specific time of the show instance

        [Required]
        public int AvailableSeates { get; set; } // Number of seats available for this specific show

        [Required]
        public long Price { get; set; } // Base price per ticket for this show

        // Foreign Key to Theatre
        [Required]
        public int TheatreId { get; set; }
        [Required]
        public virtual Theatre TheatreData { get; set; } // Navigation property to Theatre

        // One-to-Many relationship with MovieShow
        // A Show time slot can be used for different movies over time via MovieShow
        public virtual ICollection<MovieShow> MovieShows { get; set; } = new List<MovieShow>();

        // Removed: MovieData (moved to MovieShow)

    }
}

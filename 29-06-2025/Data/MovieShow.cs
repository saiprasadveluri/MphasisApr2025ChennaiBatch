using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Book.Data
{
    public class MovieShow
    {
        [Key]
        public int MovieShowId { get; set; }

        // Foreign Key to Movie
        [Required]
        public int MovieId { get; set; }
        [Required]
        public virtual Movie Movie { get; set; } // Navigation property to Movie

        // Foreign Key to Show (the general time slot)
        [Required]
        public int ShowId { get; set; }
        [Required]
        public virtual Show Show { get; set; } // Navigation property to Show

        // Foreign Key to Theatre (where the show is playing)
        [Required]
        public int TheatreId { get; set; }
        [Required]
        public virtual Theatre Theatre { get; set; } // Navigation property to Theatre

        // One-to-Many relationship with Booking
        // A MovieShow can have multiple Bookings
        public virtual ICollection<Booking> Bookings { get; set; } = new List<Booking>();

    }
}

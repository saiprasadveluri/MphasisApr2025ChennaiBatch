using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Book.Data
{
    public class Movie
    {

        [Key]
        public int MovieId { get; set; }

        [Required]
        [StringLength(255)] // Increased length for movie titles
        public string Title { get; set; }

        [Required]
        [StringLength(1000)] // Increased length for description
        public string Description { get; set; }

        // Foreign Key to Genre
        [Required]
        public int GenreId { get; set; }
        [Required]
        public virtual Genre GenreData { get; set; } // Navigation property to Genre

        [Required]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        [StringLength(500)] // Added URL length
        public string? PosterUrl { get; set; } // Optional: URL to movie poster

        [StringLength(500)] // Added URL length
        public string? TrailerUrl { get; set; } // Optional: URL to movie trailer

        [Required]
        public int DurationMinutes { get; set; } // Added movie duration

        // One-to-Many relationship with MovieShow
        // A Movie can have many MovieShows (different showtimes)
        public virtual ICollection<MovieShow> MovieShows { get; set; } = new List<MovieShow>();

        // One-to-Many relationship with Review
        // A Movie can have many Reviews
        public virtual ICollection<Review> Reviews { get; set; } = new List<Review>();

        // Many-to-Many relationship with Language via MovieLanguage
        // A Movie can be available in multiple Languages
        public virtual ICollection<MovieLanguage> MovieLanguages { get; set; } = new List<MovieLanguage>();


    }
}

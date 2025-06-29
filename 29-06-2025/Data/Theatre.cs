using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Book.Data
{
    public class Theatre
    {
        [Key]
        public int TheatreId { get; set; }

        [Required]
        [StringLength(255)] // Added length constraint
        public string TheatreName { get; set; }

        [Required]
        [StringLength(255)] // Added length constraint
        public string Location { get; set; } // E.g., "Phoenix Marketcity"

        [Required]
        [StringLength(500)] // Added length constraint
        public string Address { get; set; }

        // Foreign Key to City
        [Required]
        public int CityId { get; set; }
        [Required]
        public virtual City CityData { get; set; } // Navigation property to City

        [Required]
        public int Capacity { get; set; } // Total seating capacity

        [Required]
        public int ScreenCount { get; set; } // Number of screens in the theatre

        // One-to-Many relationship with Show
        // A Theatre can host many general Show time slots
        [InverseProperty("TheatreData")] // Explicit InverseProperty as Show has TheatreData
        public virtual ICollection<Show> Shows { get; set; } = new List<Show>(); // Renamed from ShowTimes

        // One-to-Many relationship with Seat
        // A Theatre has many Seats
        [InverseProperty("TheatreData")] // Explicit InverseProperty as Seat has TheatreData
        public virtual ICollection<Seat> Seats { get; set; } = new List<Seat>();

        // One-to-Many relationship with MovieShow
        // A Theatre can have many MovieShows (specific movie showings)
        [InverseProperty("Theatre")] // Explicit InverseProperty as MovieShow has Theatre
        public virtual ICollection<MovieShow> MovieShows { get; set; } = new List<MovieShow>();

        // Removed: Bookings (moved to MovieShow)

    }
}

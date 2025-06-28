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
        [StringLength(100)] 
        public string Title { get; set; }

        [Required]
        [StringLength(300)]
        public string Description { get; set; }

        [Required]
        public int GenreId { get; set; }

        public Genre GenreData { get; set; }
        //[ForeignKey("TheatreData")]
        public int TheatreId {  get; set; } 
        public Theatre TheatreData { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        public ICollection<Booking> Bookings { get; set; } = new List<Booking>();
        public ICollection<Review> Reviews { get; set; } = new List<Review>();
    }
}

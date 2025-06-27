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
        public string TheatreName { get; set; }

        [Required]
        public string Location { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        [ForeignKey("CityData")]
        public int CityId { get; set; }

        public City CityData { get; set; }

        [Required]
        public int Capacity { get; set; }

        [Required]
        public int ScreenCount { get; set; }

        [InverseProperty("TheatreData")] 
        public virtual ICollection<Booking> Bookings { get; set; } = new List<Booking>();

        [InverseProperty("TheatreData")]
        public virtual ICollection<Show> ShowTimes { get; set; } = new List<Show>();

        public virtual ICollection<Movie> Movies { get; set; } = new List<Movie>();
    }
}

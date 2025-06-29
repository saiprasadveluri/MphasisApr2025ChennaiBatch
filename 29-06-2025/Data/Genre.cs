using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Book.Data
{
    public class Genre
    {
        [Key]
        public int GenreId { get; set; }

        [Required]
        [StringLength(50)]
        public string GenreName { get; set; }

        // One-to-Many relationship with Movie
        // A Genre can have multiple Movies
        public virtual ICollection<Movie> Movies { get; set; } = new List<Movie>();
    }
}

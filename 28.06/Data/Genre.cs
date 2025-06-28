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

        public ICollection<Movie> Movies { get; set; } = new List<Movie>();
    }
}

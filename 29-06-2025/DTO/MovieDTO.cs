using Book.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Book.DTO
{
    public class MovieDTO
    {
        public int MovieId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int GenreId { get; set; }
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

    }
}



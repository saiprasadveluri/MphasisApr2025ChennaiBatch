using Book.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Book.DTO
{
    public class GenreDTO
    {
        public int GenreId { get; set; }
        public string GenreName { get; set; }
    }
}

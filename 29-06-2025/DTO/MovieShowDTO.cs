using Book.Data;
using System.ComponentModel.DataAnnotations;

namespace Book.DTO
{
    public class MovieShowDTO
    {          
            public int MovieShowId { get; set; }
            public int MovieId { get; set; }
            public int ShowId { get; set; }
            public int TheatreId { get; set; }


        }
    }



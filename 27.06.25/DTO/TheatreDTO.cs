using Book.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Book.DTO
{
    public class TheatreDTO
    {
        public int TheatreId { get; set; }
        public string TheatreName { get; set; }
        public string Location { get; set; }
        public string Address { get; set; }
        public int CityId { get; set; }
        public int Capacity { get; set; }
        public int ScreenCount { get; set; }

    }
}

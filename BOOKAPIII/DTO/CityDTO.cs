using System.ComponentModel.DataAnnotations;

namespace Book.DTO
{
    public class CityDTO
    {
        public int CityId { get; set; }
        public string CityName { get; set; }
        public string State { get; set; }
        public string Country { get; set; }

    }
}


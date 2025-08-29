using System.Text.Json.Serialization;

namespace RideAPPMVC.Models
{
    public class GetAllLocation
    {
        [JsonPropertyName("data")]
        public List<LocationDTO> Locations { get; set; } = new List<LocationDTO>();
    }
    public class LocationDTO
    {
        //[JsonPropertyName("locationId")]
        public int locationId { get; set; }

        //[JsonPropertyName("locationName")]
        public string? locationName { get; set; }
    }
}

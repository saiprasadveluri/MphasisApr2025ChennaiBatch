namespace RideAppAggMVC.Models
{
    public class GetAllLocations
    {
        public List<LocationDTO> data { get; set; } // List of LocationDTO objects representing all locations
    }
    public class LocationDTO
    {
        public int lId { get; set; }
        public string? lName { get; set; }
    }
}

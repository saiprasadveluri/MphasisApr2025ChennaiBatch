namespace RideAggregatorMVC.DTO
{
    public class LocationDTO
    {
        public Guid id { get; set; }
        public string name { get; set; }
    }
    public class GetAllLocations()
    {
        public List<LocationDTO> data { get; set; } = new List<LocationDTO>();
    }
}

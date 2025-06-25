namespace RideAggregrator.DTO
{
    public class GetLocations
    {
        public List<LocationDTO> data { get; set; }
    }
    public class LocationDTO
    {
        public Guid id { get; set; }
        public string name { get; set; }
    }
}

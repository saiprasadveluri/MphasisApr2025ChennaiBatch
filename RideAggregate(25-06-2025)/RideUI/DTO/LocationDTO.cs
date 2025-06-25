namespace RideUI.DTO
{
    public class GetLocation
    {
        public List<LocationDTO> data { get; set; }=new List<LocationDTO>();
    }
    public class LocationDTO
    {
        public Guid locationId { get; set; }
        public string locationName { get; set; }
    }
}

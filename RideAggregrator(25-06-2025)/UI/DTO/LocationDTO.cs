namespace RideAggeratorUI.DTO
{
    public class GetLocation
    {
        public List<LocationDTO> data { get; set; } = new List<LocationDTO>();

    }
    public class LocationDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}

namespace RideAggregatorUI.DTO
{ 
    public class GetLocation
    {
        public List<LocationDTO> data { get; set; } = new List<LocationDTO>();
       
    }
    public class LocationDTO
    {
        public Guid LocId { get; set; }

        public string LocName { get; set; }
    }
}

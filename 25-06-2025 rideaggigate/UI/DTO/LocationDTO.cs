namespace RideAggrigateUI.DTO
{

    public class GetAllLocationDataModel
    {
        public List<LocationDTO> Data { get; set; }  
    }

    public class LocationDTO
    {
        public Guid locationId { get; set; }
        public string locationName { get; set; }
    }
}

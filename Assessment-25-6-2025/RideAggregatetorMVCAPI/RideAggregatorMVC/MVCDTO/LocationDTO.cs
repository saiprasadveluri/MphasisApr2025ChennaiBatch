namespace RideAggregatorMVC.MVCDTO
{
    public class GetAllLocs
    {
        public List<LocationDTO> data { get; set; }
    }
    public class LocationDTO
    {
        public Guid locId { get; set; }
        public string locName { get; set; }
    }
}

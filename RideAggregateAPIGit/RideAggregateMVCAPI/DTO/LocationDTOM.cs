namespace RideAggregateMVCAPI.DTO
{
    public class LocationDTOM
    {
        public Guid id { get; set; }
        public string name { get; set; }
    }
    public class GetAllLocations()
    {
        public List<LocationDTOM> data { get; set; } = new List<LocationDTOM>();
    }
}

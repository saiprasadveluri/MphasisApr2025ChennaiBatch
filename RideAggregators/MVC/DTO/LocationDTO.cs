namespace MVC.DTO
{
    public class GetLocations
    {
        public List<LocationDTO> data {  get; set; }=new List<LocationDTO>();

    }
    public class LocationDTO
    {
        public Guid locationid{ get; set; }

        public string locationname { get; set; }
    }
}

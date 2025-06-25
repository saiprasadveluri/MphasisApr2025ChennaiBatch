namespace RideAPPMVC.Models
{
    public class GetAllRides
    {
        public List<RideDTO> data { get; set; } = new List<RideDTO>();
    }
    public class RideDTO
    {
        public int rideId { get; set; }
        public int pId { get; set; }

        public double distance { get; set; }
        public double costPerKm { get; set; }
    }
}

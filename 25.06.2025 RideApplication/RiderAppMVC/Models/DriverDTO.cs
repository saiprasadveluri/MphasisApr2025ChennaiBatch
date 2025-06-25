namespace RideAPPMVC.Models
{
    public class GetAllDriver
    {
        public List<DriverDTO>? data { get; set; }
    }
    public class DriverDTO
    {
        public int driverId { get; set; }
        public int userId { get; set; }
        public string? driverName { get; set; }
        public string address { get; set; } = string.Empty;
        public string phone { get; set; } = string.Empty;
        public int rating { get; set; }
        public int noOfRides { get; set; }
    }
}

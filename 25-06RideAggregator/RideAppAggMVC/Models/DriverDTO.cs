namespace RideAppAggMVC.Models
{

    public class GetAllDrivers
    {
        public List<DriverDTO> data { get; set; } // List of DriverDTO objects representing all drivers
    }   
    public class DriverDTO
    {
        public int dId { get; set; }
        public int uId { get; set; } 
        public string? dName { get; set; }
        public string? address { get; set; }
        public string? phone { get; set; }
        public int rating { get; set; }
        public int noOfRides { get; set; }

    }
}

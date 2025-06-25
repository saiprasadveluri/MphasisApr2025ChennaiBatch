namespace RideAggregatorMVC.Models
{
    public class Driver
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string LicenseNumber { get; set; } = string.Empty;
        public string VehicleDetails { get; set; } = string.Empty;
        public string VehicleType { get; set; }
    }
}

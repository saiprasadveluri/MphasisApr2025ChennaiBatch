namespace RideAggregatorApi.Models
{
    public class Driver
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string LicenseNumber { get; set; }
        public string VehicleDetails { get; set; }
        public string VehicleType { get; set; } = string.Empty;
        

        public string Email { get; set; }       
        public string Password { get; set; } = string.Empty;
        public ICollection<Ride> Rides { get; set; } = new List<Ride>();
    }
}

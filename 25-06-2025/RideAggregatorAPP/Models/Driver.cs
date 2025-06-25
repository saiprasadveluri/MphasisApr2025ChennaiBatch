namespace RideAggregatorAPP.Models
{
    public class Driver
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string LicenseNumber { get; set; }
        public string VehicleDetails { get; set; }
        public ICollection<Ride> Rides { get; set; } = new List<Ride>();
    }
}

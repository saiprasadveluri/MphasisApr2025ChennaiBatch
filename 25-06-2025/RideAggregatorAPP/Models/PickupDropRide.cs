namespace RideAggregatorAPP.Models
{
    public class PickupDropRide:Ride
    {
        public string Source { get; set; } = string.Empty;
        public string Destination { get; set; } = string.Empty;
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public double DistanceKm { get; set; }
        public decimal RatePerKm { get; set; }
        public ICollection<Ride> Rides { get; set; } = new List<Ride>();
    }
}

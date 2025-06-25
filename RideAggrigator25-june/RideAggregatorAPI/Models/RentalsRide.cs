namespace RideAggregatorApi.Models
{
    public class RentalsRide : Ride
    {
        public DateTime StartDate { get; set; }
        public int HiredDays { get; set; }
        public double Distance { get; set; }
        public decimal TollFees { get; set; }
        public decimal MinimumFare { get; set; }
        public ICollection<Ride> Rides { get; set; } = new List<Ride>();
    }
}
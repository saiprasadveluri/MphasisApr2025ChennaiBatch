namespace RideAggregatorApi.Models
{
    //public enum RideType { PickupDrop, Rental }
    public class Ride
    {
        public int Id { get; set; }
        public RideType Type { get; set; }
        public int CustomerId { get; set; }
        public int DriverId { get; set; }
        public bool IsCompleted { get; set; }
        public decimal BillAmount { get; set; }
        public DateTime CreatedAt { get; set; }

        public Customer Customer { get; set; } = null!;
        public Driver Driver { get; set; } = null!;
        public ICollection<Ride> Rides { get; set; } = new List<Ride>();
    }
}

namespace RideAggregatorMVC.Models
{
    public class Ride
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int DriverId { get; set; }
        public double DistanceInKm { get; set; }
        public DateTime RideDate { get; set; }
        public string PickupLocation { get; set; }
        public string DropLocation { get; set; }
        public string VehicleType { get; set; }
        public string PaymentMethod { get; set; }
        public bool IsCompleted { get; set; }


    }

}
namespace RideAggregatetorMVCAPI.DataDTO
{
    public class RentalRideDTO
    {
        public Guid rentalRideId { get; set; }
        public Guid customerId { get; set; }
        public Guid driverId { get; set; }
        public int hiredDays { get; set; }
        public double distance { get; set; }
        public double pricePerKm { get; set; }
    }
}

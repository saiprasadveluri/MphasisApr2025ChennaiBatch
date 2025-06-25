namespace RiderApp.DTO
{
    public class RentalDTO
    {
        public Guid RentalId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime {  get; set; }
        public decimal TotalFare { get; set; }
        public Guid CustomerId {  get; set; }
        public Guid DriverId { get; set; }
    }
}

namespace RideAggregatorMVC.DTO
{
    public class PickUpDTO
    {
        public Guid PickUpId { get; set; }
        public Guid CustId { get; set; }
        public Guid DriverId { get; set; }
        public Guid SrcId { get; set; }
        public Guid DestId { get; set; }
        public double Dist { get; set; }

    }
}

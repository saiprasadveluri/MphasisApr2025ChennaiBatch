namespace RideAggregateMVCAPI.DTO
{
    public class CustomerDTOM
    {
        public Guid custId { get; set; }

        public Guid loginId { get; set; }

        public string phoneNumber { get; set; }

        public string customerName { get; set; }
    }
    public class GetAllCustomers()
    {
        public List<CustomerDTOM> data { get; set; } = new List<CustomerDTOM>();
    }
}

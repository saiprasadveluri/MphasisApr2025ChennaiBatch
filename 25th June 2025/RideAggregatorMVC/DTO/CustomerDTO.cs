namespace RideAggregatorMVC.DTO
{
    public class CustomerDTO
    {
        public Guid cusId { get; set; }
        public Guid loginID { get; set; }
        public string cusName { get; set; }
        public string contactNo { get; set; }

    }
    public class GetAllCustomers()
    {
        public List<CustomerDTO> data { get; set; } = new List<CustomerDTO>();
    }
}

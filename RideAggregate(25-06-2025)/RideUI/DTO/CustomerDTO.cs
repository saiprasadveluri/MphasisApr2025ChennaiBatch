namespace RideUI.DTO
{
    public class GetCustomer
    {
        public List<CustomerDTO> result { get; set; }=new List<CustomerDTO>();
    }
    public class CustomerDTO
    {
        public Guid custId { get; set; }
        public Guid userId { get; set; }
        public string custName { get; set; }
        public string custPhnno { get; set; }
    }
}

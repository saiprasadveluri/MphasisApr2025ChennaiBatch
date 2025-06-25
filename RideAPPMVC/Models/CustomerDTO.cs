namespace RideAPPMVC.Models
{
    public class GetAllCustomer
    {
        public List<CustomerDTO> data { get; set; } = new List<CustomerDTO>();
    }
    public class CustomerDTO
    {
        public int cust_Id { get; set; }
        public int userId { get; set; }
        public string name { get; set; } = string.Empty;
        public string address { get; set; } = string.Empty;
        public long phone { get; set; }
    }
}

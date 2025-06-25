namespace RideAppAggMVC.Models
{
    public class GetAllCustomers
    {
        public List<CustomerDTO> Customers { get; set; } = new List<CustomerDTO>();
    }
    public class CustomerDTO
    {
        public int cId { get; set; }
        public int uId { get; set; } 
        public string? cName { get; set; }
        public string? phone { get; set; }
        public string? address { get; set; }
    }
}

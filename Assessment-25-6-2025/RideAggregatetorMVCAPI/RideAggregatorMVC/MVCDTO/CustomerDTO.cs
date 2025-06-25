namespace RideAggregatorMVC.MVCDTO
{
    public class CustomersDTO
    {
        public Guid customerId { get; set; }
      
        public string customerName { get; set; }
    }
    public class GetCustomers
    {
       public  List<CustomersDTO> data {  get; set; }
    }
}

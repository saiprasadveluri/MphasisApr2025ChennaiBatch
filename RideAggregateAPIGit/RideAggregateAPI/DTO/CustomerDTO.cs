using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RideAggregateAPI.DTO
{
    public class CustomerDTO
    {
        
        public Guid CustId { get; set; }
        
        public Guid LoginId { get; set; }
       
        public string PhoneNumber { get; set; }
        
        public string CustomerName { get; set; }
      
    }
}

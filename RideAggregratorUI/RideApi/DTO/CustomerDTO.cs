using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RideApi.DTO
{
    public class CustomerDTO
    {
        public Guid CustId { get; set; }
        
        public Guid LoginId { get; set; }
        
        public string PhoneNumber { get; set; }
       
        public string CustomerName { get; set; }
    }
}

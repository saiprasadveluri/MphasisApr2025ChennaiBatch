using System.ComponentModel.DataAnnotations;

namespace RideAggregatorAPI.DTO
{
    public class CustomerDTO
    {
        public Guid Id { get; set; }
        public Guid LoginId { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        public string CustomerName { get; set; }
      
       
        
    }
}

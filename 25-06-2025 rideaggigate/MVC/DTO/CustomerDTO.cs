using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RideAggrigationAPI.DTO
{
    public class CustomerDTO
    {
        public Guid CustomerId { get; set; }
        
        public string CustomerName { get; set; }

        public long CustomerPhone { get; set; }
        public Guid UserId { get; set; }


    }
    public class CustomerAddDTO
    {
        public Guid CustomerId { get; set; }

        public string CustomerName { get; set; }

        public long CustomerPhone { get; set; }
        public Guid UserId { get; set; }


    }


}

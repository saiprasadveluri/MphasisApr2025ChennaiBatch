using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RideAPI.DTO
{
    public class CustomerDTO
    {
        public Guid CustId { get; set; }
        public Guid UserId { get; set; }
        public string CustName { get; set; }
        public string CustPhnno { get; set; }

    }
}

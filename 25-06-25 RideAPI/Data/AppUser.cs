using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RideAggregatorAPI.Data
{
    public class AppUser
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AppUserId { get; set; }
        
        public string Password { get; set; }
        public string Email { get; set; }
        public Customer Customer { get; set; }
        public Driver Driver { get; set; }
    }
}

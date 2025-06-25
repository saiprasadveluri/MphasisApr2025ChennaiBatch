using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RideAggregatorAPI.Data
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid UserId { get; set; }
       
        [Required]
        public string Name { get; set; }
        
        [Required]
        [StringLength(20)]
        public string Email { get; set; }
        
        [Required]
        [StringLength(10)]
        public string Password { get; set; }
        public string UserRole { get; set; }
  
    }
}

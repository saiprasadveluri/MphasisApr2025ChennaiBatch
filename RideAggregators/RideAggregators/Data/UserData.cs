using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RideAggregators.Data
{
    public class UserData
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid UserId { get; set; }
        [Required]
        [StringLength(30)]
        public string Email { get; set; }
        [Required]
        [StringLength(10)]
        public string Password { get; set; }
        public string UserRole { get; set; }
    }
}

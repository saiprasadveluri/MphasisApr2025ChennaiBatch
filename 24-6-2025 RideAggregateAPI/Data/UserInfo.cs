using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RideAggregateAPI.DTO
{
    public class UserInfo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid UserId { get; set; }
        [Required]
        [StringLength(30)]
        public string UserEmail { get; set; }
        [Required]
        [StringLength(10)]
        public string Password { get; set; }
        public string UserRole { get; set; }

    }
}

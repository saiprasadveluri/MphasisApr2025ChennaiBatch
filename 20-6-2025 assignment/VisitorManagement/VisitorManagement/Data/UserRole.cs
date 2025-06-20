using System.ComponentModel.DataAnnotations;

namespace VisitorManagement.Data
{
    public class UserRole
    {
        [Required]
        [Key]
       public Guid UserId {  get; set; }
        [Required]
        [StringLength(50)]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        [StringLength(10)]
        public string Password { get; set; }
        [Required]
        [StringLength(50)]
        public string Role { get; set; }
    }
}

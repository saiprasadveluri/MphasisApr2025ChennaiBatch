using System.ComponentModel.DataAnnotations;

namespace OnlineQuizApp.Models
{
    public class Account
    {
        [Key]
        public Guid AccountId { get; set; }
        [DataType(DataType.EmailAddress)]
        [Required]
        [StringLength(20)]
        public string Email { get; set; }
        [Required]
        [MinLength(8)]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        public string Role { get; set; }
    }
}

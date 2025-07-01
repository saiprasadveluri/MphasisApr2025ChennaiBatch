using System.ComponentModel.DataAnnotations;

namespace OnlineQuizWepAPI.Data
{
    public class Account
    {
        [Key]
        public Guid AccountId { get; set; }
        [Required]
        [StringLength(50)]
        public string Email { get; set; }
        [Required]
        [StringLength(50)]
        public string Password { get; set; }
        [Required]
        public string Role { get; set; }//Check Constraints
    }
}

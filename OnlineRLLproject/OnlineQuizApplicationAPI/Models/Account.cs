
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineQuizApplicationAPI.Models
{
    public class Account
    {
        [Key]
        public Guid AccountId {  get; set; }
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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSearchAPI.DataDTO
{
    public class UserDTO
    {
        [Key]
        public Guid UserId { get; set; }
        [Required]
        [StringLength(12,MinimumLength =5,ErrorMessage ="Username should be in between 5 to 12 characters")]
        public string UserName { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string? PhoneNumber { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateOnly RegistrationDate { get; set; }
        public bool IsActive { get; set; }
        [Required]
        public string UserRole { get; set; }

    }
}

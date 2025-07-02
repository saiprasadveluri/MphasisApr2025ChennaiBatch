using System.ComponentModel.DataAnnotations;

namespace JobSearchDatabase.Data
{
    public class LoginView
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        public string CaptchaCode { get; set; }
    }
}

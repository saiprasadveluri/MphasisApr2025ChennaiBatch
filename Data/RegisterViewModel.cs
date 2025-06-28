using System.ComponentModel.DataAnnotations;

namespace OnlineQuizApp.Data
{
    public class RegisterViewModel
    {
        [Key]
        [Required]
        public Guid RegisterId { get; set; }
        [Required(ErrorMessage = "UserEmail is required")]
        [EmailAddress(ErrorMessage = "Invalid Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]//(ErrorMessage = "Captcha is required")
        public string CaptchaInput { get; set; }
    }
}
    

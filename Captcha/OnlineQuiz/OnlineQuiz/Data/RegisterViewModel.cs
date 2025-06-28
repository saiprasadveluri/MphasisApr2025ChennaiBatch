using System.ComponentModel.DataAnnotations;

namespace OnlineQuiz.Data
{
    public class RegisterViewModel
    {
        [Key]
        [Required]
        public Guid RegisterId { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Captcha is required")]
        public string CaptchaInput { get; set; }
    }
}

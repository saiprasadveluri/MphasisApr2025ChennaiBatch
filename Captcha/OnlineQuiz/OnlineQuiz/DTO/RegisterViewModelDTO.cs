using System.ComponentModel.DataAnnotations;

namespace OnlineQuiz.DTO
{
    public class RegisterViewModelDTO
    {
        public Guid RegisterId { get; set; }
        public string Email { get; set; }

        public string Password { get; set; }

        [Required(ErrorMessage = "Captcha is required")]
        public string CaptchaInput { get; set; }
    
    }
}

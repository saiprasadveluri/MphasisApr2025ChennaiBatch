using System.ComponentModel.DataAnnotations;

namespace OnlineQuizApp.DTO
{
    public class RegisterViewModeldto
    {
        public Guid RegisterId { get; set; }
        public string Email { get; set; }

        public string Password { get; set; }

        [Required]//(ErrorMessage = "Captcha is required")
        public string CaptchaInput { get; set; }
        public string CaptchaOutput { get; set; }

    }
}

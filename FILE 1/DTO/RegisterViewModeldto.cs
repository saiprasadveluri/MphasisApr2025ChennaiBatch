using System.ComponentModel.DataAnnotations;

namespace OnlineQuizApp.DTO
{
    public class RegisterViewModeldto
    {
        public Guid RegisterId { get; set; }
        public string Email {  get; set; } = string.Empty;
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Captcha is required")]
        public string CaptchaInput { get; set; }=string.Empty;//USERVALUE
        public string? CaptchaOutput { get; set; }//auto-genearted captcha code
        //[Required(ErrorMessage ="Please confirm you are not a robot")]
        [Range(typeof(bool), "true", "true", ErrorMessage = "Please confirm you are not a robot")]
        public bool NotRobot { get; set; }

    }
}

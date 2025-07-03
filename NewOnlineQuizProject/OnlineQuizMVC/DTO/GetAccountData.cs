using System.ComponentModel.DataAnnotations;

namespace OnlineQuizMVC.DTO
{
    public class GetAccountData
    {
        public List<AccountInfoDTO> data { get; set; } = new List<AccountInfoDTO>();
    }
    public class AccountInfoDTO
    {
        public Guid accountId { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string role { get; set; }
    }
    public class LoginUser
    {
        [Required(ErrorMessage = "Email is required")]
        public string email { get; set; }
        [Required(ErrorMessage = "Password is required")]
        public string password { get; set; }
        [Required(ErrorMessage = "Captcha is required")]
        public string CaptchaInput { get; set; } = string.Empty;
        public string? CaptchaOutput { get; set; } // Auto-generated

        [Range(typeof(bool), "true", "true", ErrorMessage = "Please confirm you are not a robot")]
        public bool NotRobot { get; set; }
    }
}

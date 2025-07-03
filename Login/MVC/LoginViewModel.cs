using System.ComponentModel.DataAnnotations;

namespace OnlinePharmacyAppMVC.DTO
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Captcha is required")]
        public string CaptchaCode { get; set; }
    }
}

//namespace OnlinePharmacyAppMVC.DTO
//{
//    public class LoginViewModel
//    {
//        public string Email { get; set; }
//        public string Password { get; set; }
//    }

//}
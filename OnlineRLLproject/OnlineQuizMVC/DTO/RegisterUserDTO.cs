using System.ComponentModel.DataAnnotations;

namespace OnlineQuizMVC.DTO
{
    public class RegisterUserDTO
    {
        // User Info Table Fields
        [Required(ErrorMessage = "User name is required")]
        public string userName { get; set; }

        [Required(ErrorMessage = "Contact number is required")]
        public string contactNo { get; set; }

        //Account Table Fields
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email format")]
        public string email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        public string password { get; set; }

        public string role { get; set; } = "User"; // Optional default role

        //Captcha & Verification
        [Required(ErrorMessage = "Captcha is required")]
        public string CaptchaInput { get; set; } = string.Empty;

        public string? CaptchaOutput { get; set; } // Auto-generated

        [Range(typeof(bool), "true", "true", ErrorMessage = "Please confirm you are not a robot")]
        public bool NotRobot { get; set; }
    }

}

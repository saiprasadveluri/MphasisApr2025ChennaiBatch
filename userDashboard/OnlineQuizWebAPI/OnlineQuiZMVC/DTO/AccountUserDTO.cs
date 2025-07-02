using System.ComponentModel.DataAnnotations;

namespace OnlineQuiZMVC.DTO
{
    public class AccountUserDTO
    {
        [Required(ErrorMessage = "Name is required")]
        public string UserName { get; set; }


        [Required(ErrorMessage = "Contact Number is required")]
        [StringLength(10, ErrorMessage = "Contact Number should not exceed 10 digits")]
        [Phone(ErrorMessage = "Invalid contact number")]
        public string ContactNo { get; set; }


        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string Email { get; set; }


        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]//(ErrorMessage = "Captcha is required")
        public string CaptchaInput { get; set; } = string.Empty;//USERVALUE
        public string? CaptchaOutput { get; set; }//auto-genearted captcha code
        //[Required(ErrorMessage ="Please confirm you are not a robot")]
        [Range(typeof(bool), "true", "true", ErrorMessage = "Please confirm you are not a robot")]
        public bool NotRobot { get; set; }

    }
}


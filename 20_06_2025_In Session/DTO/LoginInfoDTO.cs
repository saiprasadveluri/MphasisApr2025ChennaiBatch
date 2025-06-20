using System.ComponentModel.DataAnnotations;

namespace RoomManagerMVCApp.DTO
{
    public class LoginInfoDTO
    {
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password {  get; set; }
    }
}

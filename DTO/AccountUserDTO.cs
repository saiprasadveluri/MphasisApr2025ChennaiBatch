using System.ComponentModel.DataAnnotations;

namespace OnlineQuizApplicationAPI.DTO
{
    public class AccountUserDTO
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string UserName { get; set; }
        public string ContactNo { get; set; }
    }
}

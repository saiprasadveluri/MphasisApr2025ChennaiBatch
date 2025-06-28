using System.ComponentModel.DataAnnotations;

namespace OnlineQuizApplicationAPI.DTO
{
    public class AccountDTO
    {

        public Guid AccountId { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
    }
}

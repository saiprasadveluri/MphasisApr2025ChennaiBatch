using OnlineQuizApplicationAPI.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineQuizApplicationAPI.DTO
{
    public class UserInfoDTO
    {
        public Guid UserId { get; set; }
        
        public string UserName { get; set; }
        
        public Guid AccountId { get; set; }
        public string ContactNo { get; set; }

    }
}

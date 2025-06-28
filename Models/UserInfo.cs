using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineQuizApplicationAPI.Models
{
    public class UserInfo
    {
        [Key]
        public Guid UserId { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        [ForeignKey(nameof(accountData))]
        public Guid AccountId { get; set; }
        public string ContactNo { get; set; }

        //Navigation Property
        public Account accountData { get; set; }
        public ICollection<Quiz> quizzes { get; set; }
    }
}

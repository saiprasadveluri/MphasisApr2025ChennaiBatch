using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineQuizApplicationAPI.Models
{
    public class QuizAttempt
    {
        [Key]
        public Guid AttemptId { get; set; }

        [Required]
        [ForeignKey(nameof(UserInfo))]
        public Guid UserId { get; set; }

        [Required]
        [ForeignKey(nameof(Quiz))]
        public Guid QuizId { get; set; }
        public DateTime AttemptTime { get; set; }

        public int? Score { get; set; }

        public string Status { get; set; }//Check Contraints

        // Navigation
        public UserInfo UserInfo { get; set; }
        public Quiz Quiz { get; set; }
    }

}

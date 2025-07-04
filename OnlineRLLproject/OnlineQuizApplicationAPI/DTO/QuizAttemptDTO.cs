using OnlineQuizApplicationAPI.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineQuizApplicationAPI.DTO
{
    public class QuizAttemptDTO
    {
        public Guid UserId { get; set; }
        public Guid QuizId { get; set; }
        public DateTime AttemptTime { get; set; }

        public int? Score { get; set; }

        public string Status { get; set; }

    }
    public class GetQuizAttemptDTO
    {
        public Guid AttemptId { get; set; }
        public Guid UserId { get; set; }
        public Guid QuizId { get; set; }
        public DateTime AttemptTime { get; set; }

        public int? Score { get; set; }

        public string Status { get; set; }
    }
    
}

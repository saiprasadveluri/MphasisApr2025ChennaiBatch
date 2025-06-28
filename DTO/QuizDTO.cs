using System.ComponentModel.DataAnnotations;

namespace OnlineQuizApplicationAPI.DTO
{
    public class QuizDTO
    {
        public Guid QuizId { get; set; }
        public string QuizTitle { get; set; }
        public Guid CategoryId { get; set; }
    }
}

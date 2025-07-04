using System.ComponentModel.DataAnnotations;

namespace OnlineQuizApplicationAPI.DTO
{
    public class QuestionsDTO
    {
        public Guid QuestionId { get; set; }
        public string QuestionText { get; set; }
        public Guid TopicId { get; set; }
    }
    public class GetQustionsDTO
    {
        public Guid QuestionId { get; set; }
        public string QuestionText { get; set; }
        public Guid TopicId { get; set; }
    }
}

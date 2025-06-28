using System.ComponentModel.DataAnnotations;

namespace OnlineQuizApplicationAPI.DTO
{
    public class QuestionsDTO
    {
        public Guid QuestionId { get; set; }
        public string QuestionText { get; set; }
        public Guid TechnologyID { get; set; }
    }
}

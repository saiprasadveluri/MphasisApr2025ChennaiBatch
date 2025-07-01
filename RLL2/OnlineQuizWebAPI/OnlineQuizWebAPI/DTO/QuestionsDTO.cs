namespace OnlineQuizWepAPI.DTO
{
    public class QuestionsDTO
    {
        public Guid QuestionId { get; set; }
        public string QuestionText { get; set; }
        public Guid TechnologyID { get; set; }
    }
}

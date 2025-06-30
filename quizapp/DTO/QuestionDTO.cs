namespace QuizAPI.DTO
{
    public class QuestionsDTO
    {
        public Guid QuestionId { get; set; }
        public string QuestionText { get; set; }
        public Guid TopicId { get; set; }
    }
}

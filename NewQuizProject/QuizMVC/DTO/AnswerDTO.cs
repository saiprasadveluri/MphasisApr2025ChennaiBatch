namespace QuizMVC.DTO
{
    public class AnswerDTO
    {
        public Guid questionId { get; set; }
        public Guid selectedOptionId { get; set; }
    }
}

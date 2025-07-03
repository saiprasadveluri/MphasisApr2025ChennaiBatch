namespace QuizMVC.DTO
{
    public class CorrectAnswerDTO
    {
        public Guid questionId { get; set; }
        public Guid optionId { get; set; } // The correct OptionId
    }

}

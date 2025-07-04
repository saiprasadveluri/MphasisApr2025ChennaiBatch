namespace OnlineQuizMVC.DTO
{
    public class QuizSessionViewModel
    {
        public Guid QuizId { get; set; }
        public List<GetQuestionWithOptionsDTO> Questions { get; set; }
        public int CurrentIndex { get; set; }
        public Dictionary<Guid, Guid> SelectedAnswers { get; set; } // questionId -> selectedOptionIndex
    }
}

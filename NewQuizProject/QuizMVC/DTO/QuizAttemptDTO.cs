namespace QuizMVC.DTO
{
    public class QuizAttemptDTO
    {
        public Guid attemptId { get; set; }
        public Guid userId { get; set; }
        public Guid quizId { get; set; }
        public DateTime attemptTime { get; set; }

        public int? score { get; set; }

        public string status { get; set; }
    }
}

namespace OnlineQuizMVC.DTO
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
        public Guid attemptId { get; set; }
        public Guid userId { get; set; }
        public Guid quizId { get; set; }
        public DateTime attemptTime { get; set; }

        public int? score { get; set; }

        public string status { get; set; }
    }
    public class GetQuizAttemptDTOres
    {
        public List<GetQuizAttemptDTO> res { get; set; }
    }
}

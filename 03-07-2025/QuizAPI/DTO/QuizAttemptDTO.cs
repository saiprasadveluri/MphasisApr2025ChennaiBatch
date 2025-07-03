namespace QuizAPI.DTO
{
    public class QuizAttemptDTO
    {
        public Guid AttemptId { get; set; }
        public Guid UserId { get; set; }
        public Guid QuizId { get; set; }
        public DateTime AttemptTime { get; set; }

        public int? Score { get; set; }

        public string Status { get; set; }

    }
}

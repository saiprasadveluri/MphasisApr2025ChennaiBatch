namespace OnlineQuizWepAPI.DTO
{
    public class QuizDTO
    {
        public Guid QuizId { get; set; }
        public string QuizTitle { get; set; }
        public string CategoryName { get; set; }
        public int Duration { get; set; }
        public DateTime? ScheduleTime { get; set; }
    }
}

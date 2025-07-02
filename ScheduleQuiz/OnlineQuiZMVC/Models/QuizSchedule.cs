namespace OnlineQuiZMVC.Models
{
    public class QuizSchedule
    {
        public Guid QuizId { get; set; }
        public string Title { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Category { get; set; }
        public string Topic { get; set; }
    }
}

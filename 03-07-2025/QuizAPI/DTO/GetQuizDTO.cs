using QuizAPI.Models;

namespace QuizAPI.DTO
{
    public class QuizDTO
    {

        public string QuizTitle { get; set; }
        public string CategoryName { get; set; }//Check Constraints


        public int Duration { get; set; }
        public DateTime? ScheduleTime { get; set; }
    }
    public class GetQuizDTO
    {
        public Guid quizId { get; set; }
        public string quizTitle { get; set; }
        public string categoryName { get; set; }//Check Constraints

        public int duration { get; set; }
        public DateTime? scheduleTime { get; set; }
        public ICollection<Questions> Questions { get; set; }
    }
}

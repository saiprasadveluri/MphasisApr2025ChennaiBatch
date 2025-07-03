using OnlineQuizApplicationAPI.Models;
using System.ComponentModel.DataAnnotations;

namespace OnlineQuizApplicationAPI.DTO
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
        public Guid QuizId { get; set; }
        public string QuizTitle { get; set; }
        public string CategoryName { get; set; }//Check Constraints


        public int Duration { get; set; }
        public DateTime? ScheduleTime { get; set; }
        public ICollection<Questions> Questions { get; set; }
    }
}

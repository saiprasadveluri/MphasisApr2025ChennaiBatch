using System.ComponentModel.DataAnnotations;

namespace OnlineQuizMVC.DTO
{
    public class QuizQuestionsDTO
    {
        public string quizTitle { get; set; }
        public string categoryName { get; set; }//Check Constraints
        public int duration { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime? scheduleTime { get; set; }
    }
    public class GetQuizQuestionsDTO
    {
        public Guid QuizId { get; set; }
        public string QuizTitle { get; set; }
        public string CategoryName { get; set; }//Check Constraints
        public int Duration { get; set; }
        public DateTime? ScheduleTime { get; set; }
        public List<GetQuestionWithOptionsDTO> MCQs { get; set; }


    }
}

using QuizAPI.DTO;

namespace QuizAPI.Models
{
    public class QuizQuestionsDTO

    {

        public string QuizTitle { get; set; }

        public string CategoryName { get; set; }//Check Constraints

        public int Duration { get; set; }

        public DateTime? ScheduleTime { get; set; }

        //public List<GetQuestionWithOptionsDTO> MCQs { get; set; }

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

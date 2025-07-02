using OnlineQuiZMVC.DTO;

namespace OnlineQuiZMVC.Models
{
    public class QuizSessionViewModel
    {
        public List<Question> Questions { get; set; }
        public int CurrentIndex { get; set; }
        public Dictionary<int, int> SelectedAnswers { get; set; } // questionId -> selectedOptionIndex
    }
}

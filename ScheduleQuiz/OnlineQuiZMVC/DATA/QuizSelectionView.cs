using Microsoft.AspNetCore.Mvc.Rendering;
using OnlineQuiZMVC.Models;

namespace OnlineQuiZMVC.DATA
{
    public class QuizSelectionView
    {
        public Guid QuizId { get; set; }
        public string QuizTitle { get; set; }
        public string CategoryName { get; set; }
        public string SelectedTopic { get; set; }
        public DateTime? ScheduleTime { get; set; }
        public List<Category> Categories { get; set; }
        public List<Category> Topics { get; set; }
    }
}

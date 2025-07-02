using Microsoft.AspNetCore.Mvc.Rendering;
using OnlineQuiZMVC.Models;

namespace OnlineQuiZMVC.DTO
{
    public class QuizSelectionViewDTO
    {
        public Guid QuizId { get; set; }
        public string QuizTitle { get; set; }
        public string SelectedCategory { get; set; }
        public string SelectedTopic { get; set; }
        public DateTime? ScheduleTime { get; set; }

        public List<SelectListItem> CategoryOptions { get; set; }
        public List<SelectListItem> TopicOptions { get; set; }
    }
}

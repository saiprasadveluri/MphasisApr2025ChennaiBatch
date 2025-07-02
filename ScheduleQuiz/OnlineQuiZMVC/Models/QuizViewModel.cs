namespace OnlineQuiZMVC.Models
{
    public class QuizViewModel
    {
        public int SelectedCategoryId { get; set; }
        public int SelectedTopicId { get; set; }

        public List<Category> Categories { get; set; }
        public List<Topic> Topics { get; set; }
    }
}

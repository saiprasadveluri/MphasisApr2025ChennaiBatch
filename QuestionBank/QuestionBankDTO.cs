namespace OnlineQuizApp.DTO
{
    public class QuestionBankDTO
    {
        public List<CategoryDTO> Categories { get; set; }
        public List<TopicsDTO> Topics { get; set; }
        public List<QuestionsDTO> Questions { get; set; }

        public Guid SelectedCategoryId { get; set; }
        public Guid SelectedTopicId { get; set; }
    }
}

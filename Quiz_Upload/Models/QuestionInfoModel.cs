namespace QuestionQuiz.Models
{
    public class QuestionInfoModel
    {
        public int QId { get; set; }
        public string QText { get; set; }
        public List<QuestionOptions> Options { get; set; }
        public int UserAnswer {  get; set; }

    }
    public class QuestionOptions
    {
        public int OptId { get; set; }
        public string OptionText { get; set; }
    }
}

namespace QuizMVC.DTO
{
    public class QuestionOptionsDTO
    {
        public string QuestionText { get; set; }
        public Guid TopicId { get; set; }
        public List<OptionsDTO> Options { get; set; }
    }
    public class GetQuestionWithOptionsDTO
    {
        public Guid questionId { get; set; }
        public string questionText { get; set; }
        public Guid topicId { get; set; }
        public List<GetOptionsDTO> options { get; set; }
    }
    public class GetQuetionWithOptionsDTOData
    {
        public List<GetQuestionWithOptionsDTO> data { get; set; }
    }
}

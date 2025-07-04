namespace OnlineQuizApplicationAPI.DTO
{
    public class QuestionOptionsDTO
    {
        public string QuestionText { get; set; }
        public Guid TopicId { get; set; }
        public List<OptionsDTO> Options { get; set; }
    }
    public class GetQuestionWithOptionsDTO
    {
        public Guid QuestionId { get; set; }
        public string QuestionText { get; set; }
        public Guid TopicId { get; set; }
        public List<GetOptionsDTO> Options { get; set; }
    }
}

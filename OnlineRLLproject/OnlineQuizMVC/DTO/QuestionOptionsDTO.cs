namespace OnlineQuizMVC.DTO
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

        public Guid quizId { get; set; } // ✅ Add this

        public List<GetOptionsDTO> options { get; set; }
    }

    public class GetQuetionWithOptionsDTOData
    {
        public List<GetQuestionWithOptionsDTO> data { get; set; }
        public int currentIndex { get; set; }
    }

}

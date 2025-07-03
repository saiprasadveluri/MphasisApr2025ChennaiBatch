namespace OnlineQuizMVC.DTO
{
    public class OptionsDTO
    {
        public string OptionText { get; set; }
        public short Answer { get; set; }
    }
    public class GetOptionsDTO
    {
        public Guid optionId { get; set; }
        public string optionText { get; set; }
        public short answer { get; set; }
    }
}

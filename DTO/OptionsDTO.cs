using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineQuizApplicationAPI.DTO
{
    public class OptionsDTO
    {
        public Guid OptionId { get; set; }
        public Guid QuestionId { get; set; }
        public string OptionText { get; set; }
        public short Answer { get; set; }
    }
}

using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineQuizApplicationAPI.DTO
{
    public class OptionsDTO
    {
        public string OptionText { get; set; }
        public short Answer { get; set; }
    }
    public class GetOptionsDTO
    {
        public Guid OptionId { get; set; }
        public string OptionText { get; set; }
        public short Answer { get; set; }
    }
}

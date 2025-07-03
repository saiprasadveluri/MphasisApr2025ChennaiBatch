using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuizAPI.Models
{
    public class Options
    {
        [Key]
        public Guid OptionId { get; set; }
        [ForeignKey(nameof(QuestionData))]
        public Guid QuestionId { get; set; }
        public string OptionText { get; set; }
        public short Answer { get; set; }//flags should be raised based on this property

        //Navigation
        public Questions QuestionData { get; set; }
    }
}

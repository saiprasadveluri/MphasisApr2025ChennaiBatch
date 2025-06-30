using Microsoft.Extensions.Options;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuizAPI.Models
{
    public class Questions
    {
        [Key]
        public Guid QuestionId { get; set; }
        [Required]
        [StringLength(500)]
        public string QuestionText { get; set; }
        [Required]
        [ForeignKey(nameof(Topics))]
        public Guid TopicId { get; set; }



        //Navigation
        public Topics Topics { get; set; }
        public ICollection<Options> Options { get; set; }
        public ICollection<Quiz> Quizzes { get; set; }
    }
}

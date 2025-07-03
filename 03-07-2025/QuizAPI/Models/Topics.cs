using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuizAPI.Models
{
    public class Topics
    {
        [Key]
        public Guid TopicId { get; set; }
        [Required]
        [StringLength(30)]
        public string TopicName { get; set; }
        [Required]
        [ForeignKey(nameof(Category))]
        public Guid? CategoryId { get; set; }


        //Navigation
        public Category Category { get; set; }
    }
}

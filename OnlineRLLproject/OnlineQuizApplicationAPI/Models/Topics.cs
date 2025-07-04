using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineQuizApplicationAPI.Models
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
        public ICollection<Questions> Questions { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace QuizAPI.Models
{
    public class Category
    {
        [Key]
        public Guid CategoryId { get; set; }
        [Required]
        [StringLength(30)]
        public string CategoryName { get; set; }

        //Navigation
        public ICollection<Topics> technologies { get; set; }
        //public ICollection<Quiz> quizzes { get; set; }
    }
}

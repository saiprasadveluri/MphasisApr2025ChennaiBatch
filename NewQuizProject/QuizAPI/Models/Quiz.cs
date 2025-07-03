using OnlineQuizApp.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuizAPI.Models
{
    public class Quiz
    {
        [Key]
        public Guid QuizId { get; set; }

        [Required]
        [StringLength(50)]
        public string QuizTitle { get; set; }
        public string CategoryName { get; set; }//Check Constraints

        [Required]
        public int Duration { get; set; }
        public DateTime? ScheduleTime { get; set; }

        // Navigation properties

        public ICollection<Questions> Questions { get; set; }
        //public ICollection<UserInfo> UserInfo { get; set; } // Many-to-many or joint table
    }
}

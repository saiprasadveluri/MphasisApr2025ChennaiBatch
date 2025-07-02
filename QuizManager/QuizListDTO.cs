using System.ComponentModel.DataAnnotations;

namespace OnlineQuizApp.DTO
{
    public class QuizListDTO
    {
            public Guid QuizId { get; set; }
            public string QuizTitle { get; set; }
            public string Category { get; set; }
            public int Duration { get; set; }
            public bool IsScheduled { get; set; }

            [DataType(DataType.DateTime)]
            public DateTime? ScheduledTime { get; set; }
            
        }
    }


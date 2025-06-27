using Book.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Book.DTO
{
    public class ReviewDTO
    {
        public int CommentId { get; set; }
        public long Rating { get; set; }
        public string CommentText { get; set; }
        public DateTime DatePosted { get; set; }
        public int UserId { get; set; }     
        public int MovieId { get; set; }  
        public TimeOnly Timings { get; set; }

    }
}

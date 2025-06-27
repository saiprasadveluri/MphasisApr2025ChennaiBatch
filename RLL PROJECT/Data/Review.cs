using Book.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Book.Data
{
    public class Review
    {
        [Key] 
        public int CommentId { get; set; }
        [Required]
        public long Rating {  get; set; }
        [Required]
        public string CommentText{ get; set; }
        [Required]
        public DateTime DatePosted { get; set; }

        [ForeignKey("UserData")]
        public int UserId {  get; set; }
        public User UserData {  get; set; }

        [ForeignKey("MovieData")]
        public int MovieId {  get; set; }
        public Movie MovieData {  get; set; }

        public TimeOnly Timings { get; set; }



    }
}

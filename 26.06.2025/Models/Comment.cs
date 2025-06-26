using System.ComponentModel.DataAnnotations;

namespace BookMyShowApp.Models
{
    public class Comment
    {
        public int Id { get; set; }

        public int UserId { get; set; }
        public int MovieId { get; set; }

        public string CommentText { get; set; }

        public User User { get; set; }
        public Movie Movie { get; set; }
    }
}

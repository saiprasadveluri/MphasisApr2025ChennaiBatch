using Book.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Book.Data
{
    public class Review
    {
        [Key]
        public int CommentId { get; set; } // Keeping name as CommentId as per your original model

        [Required]
        [Range(1, 5)] // Assuming rating is 1-5 stars
        public int Rating { get; set; }

        [Required]
        [StringLength(1000)] // Allowing for longer comments
        public string CommentText { get; set; }

        [Required]
        public DateTime DatePosted { get; set; }

        // Foreign Key to User
        [Required]
        public int UserId { get; set; }
        [Required]
        public virtual User UserData { get; set; } // Navigation property to User

        // Foreign Key to Movie
        [Required]
        public int MovieId { get; set; }
        [Required]
        public virtual Movie MovieData { get; set; } // Navigation property to Movie

        public TimeOnly Timings { get; set; }


    }
}


using System.ComponentModel.DataAnnotations;

namespace Book.Data
{
    public class MovieLanguage
    {
        [Key]
        public int MovieLanguageId { get; set; } // Primary key for the join table

        // Foreign Key to Movie
        [Required]
        public int MovieId { get; set; }
        [Required]
        public virtual Movie MovieData { get; set; } // Navigation property to Movie

        // Foreign Key to Language
        [Required]
        public int LanguageId { get; set; }
        [Required]
        public virtual Language Language { get; set; } // Navigation property to Language


    }
}

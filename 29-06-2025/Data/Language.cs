using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Book.Data
{
    public class Language
    {
        [Key]
        public int LanguageId { get; set; }

        [Required]
        [StringLength(50)]
        public string LanguageName { get; set; }

        // Many-to-Many relationship with Movie via MovieLanguage
        // A Language can be associated with multiple Movies
        public virtual ICollection<MovieLanguage> MovieLanguages { get; set; } = new List<MovieLanguage>();
    }
}



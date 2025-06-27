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

        // This assumes you have a MovieLanguage entity
        public virtual ICollection<MovieLanguage> MovieLanguages { get; set; } = new List<MovieLanguage>();
    }
}


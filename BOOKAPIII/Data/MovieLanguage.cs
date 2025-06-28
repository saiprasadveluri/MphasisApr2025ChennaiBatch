using System.ComponentModel.DataAnnotations;

namespace Book.Data
{
    public class MovieLanguage
    {
        [Key]
        public int MovieLanguageId { get; set; }
        public int MovieId { get; set; }
        public Movie MovieData { get; set; }


        public int LanguageId { get; set; }
        public Language Language { get; set; }
     
    }
}

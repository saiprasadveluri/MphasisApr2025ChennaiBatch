using Book.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Book.DTO
{
    public class LanguageDTO
    {
        public int LanguageId { get; set; }
        public string LanguageName { get; set; }

    }
}

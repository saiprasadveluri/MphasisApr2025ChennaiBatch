using Book.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Book.Data
{
    public class City
    {
        [Key] 
        public int CityId { get; set; }
        [Required]
        public string CityName { get; set; }
        [Required]
        public string State {  get; set; }
        [Required]
        public string Country { get; set; }


    }
}



//[InverseProperty("City")]
//public virtual ICollection<TheaterName> TheaterNames { get; set; } = new List<TheaterName>();

//[InverseProperty("City")]
//public virtual ICollection<Theater> Theaters { get; set; } = new List<Theater>();
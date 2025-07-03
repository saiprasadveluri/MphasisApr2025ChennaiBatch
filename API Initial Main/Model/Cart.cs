using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace OnlinePharmacyAppAPI.Model
{
    public class Cart
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CartId { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }

        [ForeignKey("Medicine")]
        public int MedicineId { get; set; }

        public string MedName { get; set; }
        public decimal Price { get; set; }
        public int StockQty { get; set; }
        public decimal Amount { get; set; }

        // Navigation properties
        public User User { get; set; }
        public Medicine Medicine { get; set; }
    }

}

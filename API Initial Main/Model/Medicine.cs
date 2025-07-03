using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlinePharmacyAppAPI.Model
{
    public class Medicine
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MedicineId { get; set; }
        [Required]
        [StringLength(100)]
        public string MedName { get; set; }
        [Required]
        [StringLength(100)]
        public string Composition { get; set; }
        [Required]
        [StringLength(200)]
        public string Description { get; set; }
        [StringLength(100)]
        public string Manufacturing { get; set; }
        [Required]
        public DateOnly ExpDate { get; set; }
        [Required]
        [Range(0.01, double.MaxValue)]
        public decimal Price { get; set; }
        [Required]
        [Range(0, int.MaxValue)]
        public int StockQty { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; }

        public ICollection<Cart> Carts { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlinePharmacyAppAPI.Model
{
    public class OrderItem
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderItemId { get; set; }
        [Required]
        [ForeignKey(nameof(Order))]
        public int OrderId { get; set; }
        [Required]
        [ForeignKey(nameof(Medicine))]
        public int MedicineId { get; set; }
        [Required]
        [Range(1,int.MaxValue)]
        public int Quantity { get; set; }
        [Required]
        [Range(0.01,double.MaxValue)]
        public decimal UnitPrice { get; set; }

        //Navigations
        public Order Order { get; set; }
        public Medicine Medicine { get; set; }
    }
}

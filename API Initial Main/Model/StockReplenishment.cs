using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlinePharmacyAppAPI.Model
{
    public class StockReplenishment
    {
        [Key]
        public int ReplenishmentId { get; set; }

        [ForeignKey(nameof(Medicine))]
        public int MedicineId { get; set; }

        [Required]
        public int QuantityAdded { get; set; }

        [Required]
        public DateTime ReplenishmentDate { get; set; } = DateTime.UtcNow;

        [ForeignKey(nameof(AdminUser))]
        public int AdminUserId { get; set; }

        // Navigation
        public virtual Medicine Medicine { get; set; }
        public virtual User AdminUser { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlinePharmacyApp.DTO
{
    public class GetStockReplenishment
    {
        public List<StockReplenishmentDTO> data { get; set; }

    }
    public class StockReplenishment
    {
        [Key]
        public int replenishmentId { get; set; }

        [ForeignKey(nameof(Medicine))]
        public int medicineId { get; set; }

        [Required]
        public int quantityAdded { get; set; }

        [Required]
        public DateTime replenishmentDate { get; set; } = DateTime.UtcNow;

        [ForeignKey(nameof(AdminUser))]
        public int adminUserId { get; set; }

        // Navigation
        public virtual Medicine Medicine { get; set; }
        public virtual User AdminUser { get; set; }
    }
}

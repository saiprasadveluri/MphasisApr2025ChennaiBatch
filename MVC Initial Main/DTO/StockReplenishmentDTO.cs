using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlinePharmacyAppMVC.DTO
{
    public class StockReplenishmentDTO
    {
        public int replenishmentId { get; set; }
        public int medicineId { get; set; }
        public int quantityAdded { get; set; }
        public DateTime replenishmentDate { get; set; } = DateTime.UtcNow;
        public int adminUserId { get; set; }
    }
    public class GetStockReplenishment
    {
        public List<StockReplenishmentDTO> data { get; set; }

    }
}

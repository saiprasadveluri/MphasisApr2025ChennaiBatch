using OnlinePharmacyAppAPI.Model;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlinePharmacyAppAPI.DTO
{
    public class StockReplenishmentDTO
    {
        public int ReplenishmentId { get; set; }
        public int MedicineId { get; set; }
        public int QuantityAdded { get; set; }
        public DateTime ReplenishmentDate { get; set; } = DateTime.UtcNow;
        public int AdminUserId { get; set; }
    }
}

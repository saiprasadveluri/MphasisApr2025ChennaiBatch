using System.ComponentModel.DataAnnotations;

namespace OnlinePharmacyAppAPI.DTO
{
    public class MedicineDTO
    {
        public int MedicineId { get; set; }
        public string MedName { get; set; }
        public string Composition { get; set; }
        public string Description { get; set; }
        public string Manufacturing { get; set; }
        public DateOnly ExpDate { get; set; }
        public decimal Price { get; set; }
        public int StockQty { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace OnlinePharmacyAppMVC.DTO
{
    public class UpdateStockDTO:MedicineDTO
    {
        public int MedicineId { get; set; }
        public string MedName { get; set; }
        public int StockQty { get; set; }
        //[Required]
        //[Range(1, int.MaxValue, ErrorMessage = "Please enter a positive number")]
        //public int AddedQty { get; set; } 
    }
}

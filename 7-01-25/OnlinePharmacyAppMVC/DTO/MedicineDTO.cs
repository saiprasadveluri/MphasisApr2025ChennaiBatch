namespace OnlinePharmacyAppMVC.DTO
{
    public class MedicineDTO
    {
        public int medicineId { get; set; }
        public string medName { get; set; }
        public string composition { get; set; }
        public string description { get; set; }
        public string manufacturing { get; set; }
        public DateOnly expDate { get; set; }
        public decimal price { get; set; }
        public int stockQty { get; set; }
    }
    public class GetMedicine
    {
        public List<MedicineDTO> data { get; set; }

    }
}

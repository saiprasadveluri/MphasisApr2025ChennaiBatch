using OnlinePharmacyAppAPI.DTO;
using OnlinePharmacyAppAPI.Model;

namespace OnlinePharmacyAppAPI.Services
{
    public class MedicineService
    {
        private OPADBContext _context;
        public MedicineService(OPADBContext context)
        {
            _context = context;
        }
        public List<MedicineDTO> GetAllMedicines()
        {
            List<MedicineDTO> meds = (from obj in _context.Medicines
                                   select new MedicineDTO
                                   {
                                       MedicineId=obj.MedicineId,
                                       MedName=obj.MedName,
                                       Composition=obj.Composition,
                                       Description=obj.Description,
                                       Manufacturing=obj.Manufacturing,
                                       ExpDate=obj.ExpDate,
                                       Price=obj.Price,
                                       StockQty=obj.StockQty
                                   }).ToList();
            return meds;
        }
        public bool AddNewMedicine(MedicineDTO m)
        {
            Medicine med = new Medicine();
            med.MedName = m.MedName;
            med.Composition = m.Composition;
            med.Description = m.Description;
            med.Manufacturing = m.Manufacturing;
            med.ExpDate = m.ExpDate;
            med.Price = m.Price;
            med.StockQty = m.StockQty;
            _context.Medicines.Add(med);
            _context.SaveChanges();
            return true;
        }
        public MedicineDTO GetMedicineById(int id)
        {
            var medicine = (from obj in _context.Medicines
                            where obj.MedicineId == id
                            select new MedicineDTO
                            {
                                MedicineId = obj.MedicineId,
                                MedName = obj.MedName,
                                Composition = obj.Composition,
                                Description = obj.Description,
                                Manufacturing = obj.Manufacturing,
                                ExpDate = obj.ExpDate,
                                Price = obj.Price,
                                StockQty = obj.StockQty
                            }).FirstOrDefault();

            return medicine;
        }

        public bool UpdateMedicine(MedicineDTO m)
        {
            var med = _context.Medicines.Find(m.MedicineId);
            if (med == null) return false;

            med.MedName = m.MedName;
            med.Composition = m.Composition;
            med.Description = m.Description;
            med.Manufacturing = m.Manufacturing;
            med.ExpDate = m.ExpDate;
            med.Price = m.Price;
            med.StockQty = m.StockQty;

            _context.SaveChanges();
            return true;
        }
        public bool DeleteMedicine(int medid)
        {
            var meds = _context.Medicines.Find(medid);
            if (meds == null) return false;

            _context.Medicines.Remove(meds);
            _context.SaveChanges();
            return true;
        }
    }
}

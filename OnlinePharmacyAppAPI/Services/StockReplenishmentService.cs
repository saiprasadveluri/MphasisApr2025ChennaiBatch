using OnlinePharmacyAppAPI.DTO;
using OnlinePharmacyAppAPI.Model;

namespace OnlinePharmacyAppAPI.Services
{
    public class StockReplenishmentService
    {
        private OPADBContext _context;
        public StockReplenishmentService(OPADBContext context)
        {
            _context = context;
        }
        public List<StockReplenishmentDTO> GetAll()
        {
            List<StockReplenishmentDTO> stock = (from obj in _context.stocks
                                        select new StockReplenishmentDTO
                                        {
                                            ReplenishmentId=obj.ReplenishmentId,
                                            MedicineId=obj.MedicineId,
                                            QuantityAdded=obj.QuantityAdded,
                                            ReplenishmentDate=obj.ReplenishmentDate,
                                            AdminUserId=obj.AdminUserId

                                        }).ToList();
            return stock;
        }
        public bool AddNewStock(StockReplenishmentDTO p)
        {
            StockReplenishment stock = new StockReplenishment();
            stock.MedicineId = p.MedicineId;
            stock.QuantityAdded = p.QuantityAdded;
            stock.ReplenishmentDate = p.ReplenishmentDate;
            stock.AdminUserId = p.AdminUserId;
            _context.SaveChanges();
            return true;
        }
        public bool UpdateStock(StockReplenishmentDTO p)
        {
            var existingstock = _context.stocks.Find(p.ReplenishmentId);
            if (existingstock == null)
                return false;
            existingstock.MedicineId = p.MedicineId;
            existingstock.QuantityAdded = p.QuantityAdded;
            existingstock.ReplenishmentDate = p.ReplenishmentDate;
            _context.SaveChanges();
            return true;
        }
        public bool DeleteStock(int stockid)
        {
            var stock = _context.stocks.Find(stockid);
            if (stock == null) return false;

            _context.stocks.Remove(stock);
            _context.SaveChanges();
            return true;
        }
    }
}

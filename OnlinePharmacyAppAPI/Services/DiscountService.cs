using OnlinePharmacyAppAPI.DTO;
using OnlinePharmacyAppAPI.Model;

namespace OnlinePharmacyAppAPI.Services
{
    public class DiscountService
    {
        private OPADBContext _context;
        public DiscountService(OPADBContext context)
        {
            _context = context;
        }
        public List<DiscountDTO> GetAllDiscounts()
        {
            List<DiscountDTO> meds = (from obj in _context.Discounts
                                      select new DiscountDTO
                                      {
                                          DiscountId = obj.DiscountId,
                                          DiscountCode = obj.DiscountCode,
                                          DiscountType = obj.DiscountType,
                                          Value = obj.Value,
                                          IsPercentage= obj.IsPercentage,
                                          StartDate = obj.StartDate,
                                          EndDate = obj.EndDate
                                      }).ToList();
            return meds;
        }
        public bool AddDiscount(DiscountDTO m)
        {
            Discount dis = new Discount();
            dis.DiscountId = m.DiscountId;
            dis.DiscountCode = m.DiscountCode;
            dis.DiscountType = m.DiscountType;
            dis.Value = m.Value;
            dis.IsPercentage = m.IsPercentage;
            dis.StartDate = m.StartDate;
            dis.EndDate = m.EndDate;
            _context.Discounts.Add(dis);
            _context.SaveChanges();
            return true;
        }
        public bool UpdateDiscount(DiscountDTO m)
        {
            var dis = _context.Discounts.Find(m.DiscountId);
            if (dis == null) return false;

            dis.DiscountCode = m.DiscountCode;
            dis.DiscountType = m.DiscountType;
            dis.Value = m.Value;
            dis.IsPercentage = m.IsPercentage;
            dis.StartDate = m.StartDate;
            dis.EndDate = m.EndDate;

            _context.SaveChanges();
            return true;
        }
    }
}

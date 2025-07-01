using OnlinePharmacyAppAPI.DTO;
using OnlinePharmacyAppAPI.Model;

namespace OnlinePharmacyAppAPI.Services
{
    public class OrderService
    {
        private OPADBContext _context;
        public OrderService(OPADBContext context)
        {
            _context = context;
        }
        public List<OrderDTO> GetAllOrders()
        {
            List<OrderDTO> order= (from obj in _context.Orders
                                   select new OrderDTO
                                   {
                                     OrderId = obj.OrderId,
                                     UserId=obj.UserId,
                                     OrderDate=obj.OrderDate,
                                     TotalAmount=obj.TotalAmount,
                                     IsFirstOrder=obj.IsFirstOrder,
                                     DiscountApplied=obj.DiscountApplied,
                                     DiscountId=obj.DiscountId,
                                     Status=obj.Status

                                   }).ToList();
            return order;
        }
        public bool AddNewOrder(OrderDTO o)
        {
            Order order= new Order();
            order.UserId= o.UserId;
            order.TotalAmount= o.TotalAmount;
            order.IsFirstOrder= o.IsFirstOrder;
            order.DiscountApplied= o.DiscountApplied;
            order.DiscountId= o.DiscountId;
            order.Status= o.Status;
            _context.Orders.Add(order);
            _context.SaveChanges();
            return true;
        }
        public bool UpdateOrder(OrderDTO o)
        {
            var existingOrder = _context.Orders.Find(o.OrderId);
            if (existingOrder == null)
                return false;

            existingOrder.UserId = o.UserId;
            existingOrder.TotalAmount = o.TotalAmount;
            existingOrder.IsFirstOrder = o.IsFirstOrder;
            existingOrder.DiscountApplied = o.DiscountApplied;
            existingOrder.Status = o.Status;

            _context.SaveChanges();
            return true;
        }
        public bool DeleteOrder(int orderId)
        {
            var order = _context.Orders.Find(orderId);
            if (order == null) return false;

            _context.Orders.Remove(order);
            _context.SaveChanges();
            return true;
        }
    }
}

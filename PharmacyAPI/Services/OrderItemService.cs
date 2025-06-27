using OnlinePharmacyAppAPI.DTO;
using OnlinePharmacyAppAPI.Model;

namespace OnlinePharmacyAppAPI.Services
{
    public class OrderItemService
    {
        private OPADBContext _context;
        public OrderItemService(OPADBContext context)
        {
            _context = context;
        }
        public List<OrderItemDTO> GetAllOrderItems()
        {
            List<OrderItemDTO> order = (from obj in _context.OrderItems
                                    select new OrderItemDTO
                                    {
                                        OrderItemId = obj.OrderItemId,
                                        OrderId=obj.OrderId,
                                        MedicineId=obj.MedicineId,  
                                        Quantity=obj.Quantity,  
                                        UnitPrice=obj.UnitPrice

                                    }).ToList();
            return order;
        }
        public bool AddNewOrderItem(OrderItemDTO o)
        {
            OrderItem order = new OrderItem();
            order.OrderId = o.OrderId;
            order.MedicineId = o.MedicineId;
            order.Quantity = o.Quantity;
            order.UnitPrice = o.UnitPrice;

            _context.OrderItems.Add(order);
            _context.SaveChanges();
            return true;
        }
        public bool UpdateOrderItem(OrderItemDTO o)
        {
            var existingItem = _context.OrderItems.Find(o.OrderItemId);
            if (existingItem == null)
                return false;

            existingItem.OrderId = o.OrderId;
            existingItem.MedicineId = o.MedicineId;
            existingItem.Quantity = o.Quantity;
            existingItem.UnitPrice = o.UnitPrice;

            _context.SaveChanges();
            return true;
        }
        public bool DeleteOrderItem(int orderItemId)
        {
            var orderItem = _context.OrderItems.Find(orderItemId);
            if (orderItem == null) return false;

            _context.OrderItems.Remove(orderItem);
            _context.SaveChanges();
            return true;
        }
    }
}

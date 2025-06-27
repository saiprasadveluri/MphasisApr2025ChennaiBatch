using OnlinePharmacyAppAPI.Model;

namespace OnlinePharmacyAppAPI.Services
{
    public class Unity
    {
        OPADBContext _context;
        public Unity(OPADBContext context)
        {
            _context = context;
        }
        private UserService _userService;
        public UserService UserService
        {
            get
            {
                if (_userService == null)
                {
                    _userService = new UserService(_context);
                }
                return _userService;
            }
        }
        private MedicineService _medicineService;
        public MedicineService MedicineService
        {
            get
            {
                if (_medicineService == null)
                {
                    _medicineService = new MedicineService(_context);
                }
                return _medicineService;
            }
        }
        private OrderService _orderService;
        public OrderService OrderService
        {
            get
            {
                if (_orderService == null)
                {
                    _orderService = new OrderService(_context);
                }
                return _orderService;
            }
        }
        private OrderItemService _orderItemService;
        public OrderItemService OrderItemService
        {
            get
            {
                if (_orderItemService == null)
                {
                    _orderItemService = new OrderItemService(_context);
                }
                return _orderItemService;
            }

        }
        private MedicineService _updateMedicine;
        public MedicineService UpdateMedicine
        {
            get
            {
                if (_updateMedicine == null)
                {
                    _updateMedicine = new MedicineService(_context);
                }
                return _updateMedicine;
            }
        }
        private OrderService _updateOrder;
        public OrderService UpdateOrder
        {
            get
            {
                if (_updateOrder == null)
                {
                    _updateOrder = new OrderService(_context);
                }
                return _updateOrder;
            }
        }
        private OrderItemService _updateOrderItem;
        public OrderItemService UpdateOrderItem
        {
            get
            {
                if (_updateOrderItem == null)
                {
                    _updateOrderItem = new OrderItemService(_context);
                }
                return _updateOrderItem;
            }
        }
        private UserService _updateUser;
        public UserService UpdateUser
        {
            get
            {
                if (_updateUser == null)
                {
                    _updateUser = new UserService(_context);
                }
                return _updateUser;
            }
        }
        private UserService _deleteUserService;
        public UserService DeleteUserService
        {
            get
            {
                if (_deleteUserService == null)
                {
                    _deleteUserService = new UserService(_context);
                }
                return _deleteUserService;
            }
        }
        private MedicineService _deleteMedicineService;
        public MedicineService DeleteMedicineService
        {
            get
            {
                if (_deleteUserService == null)
                {
                    _deleteMedicineService = new MedicineService(_context);
                }
                return _deleteMedicineService;
            }
        }
        private OrderService _deleteOrderService;
        public OrderService DeleteOrderService
        {
            get
            {
                if (_deleteOrderService == null)
                {
                    _deleteOrderService = new OrderService(_context);
                }
                return _deleteOrderService;
            }
        }
        private OrderItemService _deleteOrderItemService;
        public OrderItemService DeleteOrderItemService
        {
            get
            {
                if (_deleteOrderItemService == null)
                {
                    _deleteOrderItemService = new OrderItemService(_context);
                }
                return _deleteOrderItemService;
            }
        }

    }
}

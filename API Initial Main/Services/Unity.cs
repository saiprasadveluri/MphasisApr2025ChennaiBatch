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
        private DiscountService _discountService;
        public DiscountService DiscountService
        {
            get
            {
                if (_discountService == null)
                {
                    _discountService = new DiscountService(_context);
                }
                return _discountService;
            }
        }
       
        private ProfileService _profileService;
        public ProfileService ProfileService
        {
            get
            {
                if (_profileService == null)
                {
                    _profileService = new ProfileService(_context);
                }
                return _profileService;
            }
        }
        private StockReplenishmentService _stockReplenishmentService;
        public StockReplenishmentService StockReplenishmentService
        {
            get
            {
                if (_stockReplenishmentService == null)
                {
                    _stockReplenishmentService = new StockReplenishmentService(_context);
                }
                return _stockReplenishmentService;
            }
        }
        private CartService _cartService;
        public CartService CartService
        {
            get
            {
                if (_cartService == null)
                    _cartService = new CartService(_context);
                return _cartService;
            }
        }
    }
}

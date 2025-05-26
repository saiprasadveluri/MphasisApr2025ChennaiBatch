using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyRestaurantApp.Core.Models;
using MyRestaurantApp.Core.Interfaces.Services;
using MyRestaurantApp.Core;
using MyRestaurantApp.DataAccess.Repositories;
using MyRestaurantApp.DataAccess;
using MyRestaurantApp.Services;



namespace Food_Del_Apps
{
    internal static class Program
    {
        public static IAuthService AuthService { get; private set; }
        public static IRestaurantService RestaurantService { get; private set; }
        public static IMenuService MenuService { get; private set; }
        public static IOrderService OrderService { get; private set; }
        public static ICouponService CouponService { get; private set; }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // --- Manual Dependency Injection Setup ---
            // Repositories
            var userRepository = new UserRepository();
            var restaurantRepository = new RestaurantRepository();
            var menuItemRepository = new MenuItemRepository();
            var orderRepository = new OrderRepository();
            var orderLineItemRepository = new OrderLineItemRepository();
            var couponInfoRepository = new CouponInfoRepository();

            // Services
            AuthService = new AuthService(userRepository);
            RestaurantService = new RestaurantService(restaurantRepository, userRepository);
            MenuService = new MenuService(menuItemRepository, restaurantRepository);
            OrderService = new OrderService(orderRepository, orderLineItemRepository, menuItemRepository, restaurantRepository, userRepository, couponInfoRepository);
            CouponService = new CouponService(couponInfoRepository);

            // Start the application with the Login Form
            Application.Run(new LoginForms());
        }
    }
}

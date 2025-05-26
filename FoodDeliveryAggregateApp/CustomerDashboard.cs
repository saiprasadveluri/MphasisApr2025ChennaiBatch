using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodDeliveryAggregateApp
{
    public partial class CustomerDashboard : Form
    {
        private DataProviders dataProviders;
        private User currentUser;
        public CustomerDashboard(User user)
        {
            InitializeComponent();
            dataProviders = DataProviders.Instance;
            currentUser = user;

            LoadOrders();
        }

        private void LoadOrders()
        {
            var customerOrders = dataProviders.GetOrdersByUser(currentUser);
            CustomerOrderGrid.DataSource = null;
            CustomerOrderGrid.DataSource = customerOrders;
            CustomerOrderGrid.Refresh();
        }

        private void OrdersGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (CustomerOrderGrid.SelectedRows.Count > 0)
            {
                Order selectedOrder = CustomerOrderGrid.SelectedRows[0].DataBoundItem as Order;
                if (selectedOrder != null)
                {
                    ShowOrderDetails(selectedOrder);
                }
            }
        }

        private void ShowOrderDetails(Order order)
        {
            CustomerOrderGrid.DataSource = null;
            CustomerOrderGrid.DataSource = order.Items;
            CustomerOrderGrid.Refresh();


        }
    }
}
 

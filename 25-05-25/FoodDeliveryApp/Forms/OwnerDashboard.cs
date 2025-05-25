using System;
using System.Windows.Forms;

namespace FoodDeliveryApp.Forms
{
    public partial class OwnerDashboard : Form
    {
        public OwnerDashboard()
        {
            InitializeComponent();
        }

        private void btnAddMenuItem_Click(object sender, EventArgs e)
        {
            new AddMenuItemForm().ShowDialog();
        }

        private void btnViewOrders_Click(object sender, EventArgs e)
        {
            MessageBox.Show("List of orders would be displayed here", "Orders", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
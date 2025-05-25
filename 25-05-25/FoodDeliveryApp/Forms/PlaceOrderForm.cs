using System;
using System.Windows.Forms;

namespace FoodDeliveryApp.Forms
{
    public partial class PlaceOrderForm : Form
    {
        public PlaceOrderForm()
        {
            InitializeComponent();
        }

        private void btnConfirmOrder_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Order placed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}

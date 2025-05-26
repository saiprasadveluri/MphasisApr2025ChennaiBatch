using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Food_App.Entity;
using Food_App.Data;

namespace Food_App
{
    public partial class Card_Summary : Form
    {
        private readonly List<OrderLineItem> _cartItems;
        public Card_Summary(List<OrderLineItem> Items)
        {
            InitializeComponent();
            _cartItems = Items;
            dgvCartItems.DataSource = Items;
            lblGrandTotal.Text = $"Grand Total: {_cartItems.Sum(i => i.Item.UnitPrice * i.Quantity):C}";
        }

        private void btnApplyCoupon_Click(object sender, EventArgs e)
        {

        }

        private void btnConfirmOrder_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}

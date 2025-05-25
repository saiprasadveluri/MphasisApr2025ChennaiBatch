using System;
using System.Windows.Forms;
using FoodDeliveryApp.Models;

namespace FoodDeliveryApp.Forms
{
    public partial class AddMenuItemForm : Form
    {
        public AddMenuItemForm()
        {
            InitializeComponent();
            cmbDishType.DataSource = Enum.GetValues(typeof(DishType));
            cmbUnit.DataSource = Enum.GetValues(typeof(UnitType));
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("Menu item added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}

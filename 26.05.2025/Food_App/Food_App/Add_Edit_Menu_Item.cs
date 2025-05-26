using Food_App;
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

namespace Food_App.Entity
{
    public partial class Add_Edit_Menu_Item : Form
    {
        private readonly Restaurant _restaurant;
        public MenuItem NewMenuItem { get; private set; }
        public Add_Edit_Menu_Item(Restaurant restaurant)
        {
            InitializeComponent();
            _restaurant = restaurant;
            cmbDishType.DataSource = new List<string> { "Veg", "Non-Veg", "Jain" };
            cmbUnits.DataSource = new List<string> { "Grams", "Milliliters", "Pieces" };
        }

        private void Add_Edit_Menu_Item_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtPrice.Text, out decimal price) ||
           !int.TryParse(txtQuantity.Text, out int quantity))
            {
                MessageBox.Show("Invalid numeric values!");
                return;
            }

            MenuItem item = new MenuItem
            {
                //MId = DataStorage.MenuItems.Count + 1,
                DishName = txtDishNames.Text,
                DishType = cmbDishType.SelectedItem.ToString(),
                UnitPrice = price,
                AvailableQuantity = quantity,
                Units = cmbUnits.SelectedItem.ToString(),
                Restaurant = _restaurant
            };

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}


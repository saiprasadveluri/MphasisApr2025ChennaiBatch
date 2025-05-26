using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Food_Del_Apps
{
    public partial class AddMenuItemForm : Form
    {
        private Guid _restaurantId;
        public AddMenuItemForm()
        {
            InitializeComponent();
            _restaurantId = restaurantId;
            PopulateDishTypeComboBox();
            SetNumericUpDownDefaults();
        }
        private void PopulateDishTypeComboBox()
        {
            cmbDishType.DataSource = Enum.GetValues(typeof(DishType));
            cmbDishType.SelectedIndex = 0;
        }

        private void SetNumericUpDownDefaults()
        {
            numPrice.Minimum = 0.01M;
            numPrice.DecimalPlaces = 2;
            numPrice.Value = 100.00M; 

            numValueForUnit.Minimum = 1;
            numValueForUnit.Value = 1; 

            numAvailableQuantity.Minimum = 0;
            numAvailableQuantity.Value = 10; 
        }


        private void AddMenuItemForm_Load(object sender, EventArgs e)
        {

        }

        private async void btnAddItem_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "";
            string dishName = txtDishName.Text.Trim();
            DishType dishType = (DishType)cmbDishType.SelectedItem;
            decimal price = numPrice.Value;
            decimal valueForUnit = numValueForUnit.Value;
            string units = txtUnits.Text.Trim();
            int availableQuantity = (int)numAvailableQuantity.Value;

            if (string.IsNullOrWhiteSpace(dishName) || string.IsNullOrWhiteSpace(units))
            {
                lblMessage.Text = "Dish Name and Units are required.";
                return;
            }

            try
            {
                await Program.MenuService.AddMenuItemAsync(_restaurantId, dishName, dishType, price, valueForUnit, units, availableQuantity);
                lblMessage.Text = $"Menu item '{dishName}' added successfully!";
              
                txtDishName.Clear();
                numPrice.Value = numPrice.Minimum;
                numValueForUnit.Value = numValueForUnit.Minimum;
                txtUnits.Clear();
                numAvailableQuantity.Value = numAvailableQuantity.Minimum;
                cmbDishType.SelectedIndex = 0;
            }
            catch (ArgumentException ex)
            {
                lblMessage.Text = $"Input Error: {ex.Message}";
            }
            catch (Exception ex)
            {
                lblMessage.Text = $"An unexpected error occurred: {ex.Message}";
            }
        }
    }
}

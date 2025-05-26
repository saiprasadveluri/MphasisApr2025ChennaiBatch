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

namespace Food_App
{
    public partial class OwnerDashboard : Form
    {
        private readonly User _owner;

        public OwnerDashboard(User owner)
        {
            InitializeComponent();
            _owner = owner;
           lblOwnerName.Text = $"Welcome, {_owner.Name}";
            LoadRestaurants();
        }
        private void LoadRestaurants()
        {
            dgvRestaurants.DataSource = DataStorage.Restaurants
                .Where(r => r.Owner.UId == _owner.UId)
                .ToList();
        }

        private void btnAddMenuItems_Click(object sender, EventArgs e)
        {
            if (dgvRestaurants.SelectedRows.Count > 0)
            {
                var restaurant = (Restaurant)dgvRestaurants.SelectedRows[0].DataBoundItem;
                var form = new Add_Edit_Menu_Item((Restaurant)dgvRestaurants.SelectedRows[0].DataBoundItem) ;
                if (form.ShowDialog() == DialogResult.OK)
                {
                    DataStorage.MenuItems.Add(form.NewMenuItem);
                    LoadMenuItems(restaurant);
                }
            }

        }
        private void LoadMenuItems(Entity.Restaurant restaurant)
        {
            dgvMenuItems.DataSource = DataStorage.MenuItems
    .Where(m => m.Restaurant.RId == restaurant.RId)
                .ToList();
        }
    }
}

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
    public partial class AdminDashboard : Form
    {
        private BindingList<Entity.Restaurant> _restaurantsBinding;
        public AdminDashboard()
        {
            InitializeComponent();
            InitializeDataBinding();
            RefreshRestaurants();
            ConfigureGridView();
            LoadRestaurants();
        }
        private void InitializeDataBinding()
        {

            _restaurantsBinding = new BindingList<Entity.Restaurant>(DataStorage.Restaurants);
            dgvRestaurants.DataSource = _restaurantsBinding;
            dgvRestaurants.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRestaurants.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void ConfigureGridView()
        {

            dgvRestaurants.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            foreach (DataGridViewColumn column in dgvRestaurants.Columns) { 
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            dgvRestaurants.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRestaurants.MultiSelect = false;
            dgvRestaurants.ReadOnly=true;
        }
        private void LoadRestaurants()
        {
            // Initialize BindingList with DataStorage data
            _restaurantsBinding = new BindingList<Entity.Restaurant>(DataStorage.Restaurants);
            dgvRestaurants.DataSource = _restaurantsBinding;
        }
        private void RefreshRestaurants()
        {
            dgvRestaurants.DataSource = null;
            dgvRestaurants.DataSource = DataStorage.Restaurants;
        }



        private void btnDeleteRestaurant_Click(object sender, EventArgs e)
        {
            //if (dgvRestaurants.SelectedRows.Count > 0)
            //    if (dgvRestaurants.SelectedRows.Count > 0)
            //    {
            //        var restaurant = (Restaurant)dgvRestaurants.SelectedRows[0].DataBoundItem;
            //        DataStorage.Restaurants.Remove(restaurant);
            //        RefreshRestaurants();

            //    }
            try
            {
                if (dgvRestaurants.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a restaurant to delete!", "Warning",
                                                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var restaurant = (Restaurant)dgvRestaurants.SelectedRows[0].DataBoundItem;

                if (MessageBox.Show($"Delete {restaurant.Name}?", "Confirm Delete",
                                              MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {

                    DataStorage.MenuItems.RemoveAll(m => m.Restaurant?.RId == restaurant.RId);


                    _restaurantsBinding.Remove(restaurant);

                    MessageBox.Show("Restaurant deleted successfully!", "Success",
                                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Delete failed: {ex.Message}", "Error",
                                          MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnAddRestaurant_Click(object sender, EventArgs e)
        {
            try
            {
                using (var addForm = new Add_Edit_Restaurant())
                {
                    if (addForm.ShowDialog() == DialogResult.OK)
                    {
                        _restaurantsBinding.Add(addForm.NewRestaurant);
                        dgvRestaurants.Refresh();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding restaurant: {ex.Message}", "Error",
                                          MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //    {
        //        if (!ValidateSelection()) return;

        //        var restaurant = GetSelectedRestaurant();
        //        if (restaurant == null) return;

        //        if (ConfirmDelete(restaurant))
        //        {
        //            DeleteRestaurant(restaurant);
        //            MessageBox.Show("Restaurant deleted successfully!");
        //        }
        //    }

        //    private bool ValidateSelection()
        //    {
        //        if (dgvRestaurants.SelectedRows.Count == 0 ||
        //            dgvRestaurants.CurrentRow == null ||
        //            dgvRestaurants.CurrentRow.Index < 0)
        //        {
        //            MessageBox.Show("Please select a restaurant first!");
        //            return false;
        //        }
        //        return true;
        //    }

        //    private Entity.Restaurant GetSelectedRestaurant()
        //    {
        //        return dgvRestaurants.CurrentRow?.DataBoundItem as Entity.Restaurant;
        //    }

        //    private bool ConfirmDelete(Entity.Restaurant restaurant)
        //    {
        //        return MessageBox.Show(
        //        $"Delete {restaurant.Name}? This cannot be undone!",
        //                    "Confirm Delete",
        //                    MessageBoxButtons.YesNo,
        //                    MessageBoxIcon.Warning
        //                ) == DialogResult.Yes;
        //    }

        //    private void DeleteRestaurant(Entity.Restaurant restaurant)
        //    {
        //        try
        //        {

        //            DataStorage.MenuItems.RemoveAll(m => m.Restaurant?.RId == restaurant.RId);


        //            _restaurantsBinding.Remove(restaurant);


        //            dgvRestaurants.ClearSelection();
        //            dgvRestaurants.Refresh();
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show($"Error deleting restaurant: {ex.Message}");
        //        }
        //    }
        //}
    }
}
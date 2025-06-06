using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelEzeeWinUI2
{
    public partial class Booking : Form
    {
        DataAccess da = new DataAccess();
        public Booking()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Booking_Load(object sender, EventArgs e)
        {
            List<Services> services = da.GetAllServices();
            comboBox2.DataSource = services;
            comboBox2.ValueMember = "ServiceId";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                da.AddBooking(
                Convert.ToInt64(textBox1.Text),
                Convert.ToInt64(comboBox2.SelectedValue),
                dateTimePicker1.Value,
                Convert.ToInt32(numericUpDown2.Value),
                textBox2.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding booking: " + ex.Message);
            }
            finally
            {
                MessageBox.Show("Booking added successfully!");
                this.Close();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

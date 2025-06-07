using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewTravelEF
{
    public partial class Booking : Form
    {
        DataAccess dataAccess;
        public Booking(DataAccess _dataAccess)
        {
            InitializeComponent();
            dataAccess = _dataAccess;
        }

        private void AddBookingButton_Click(object sender, EventArgs e)
        {

        }
    }
}

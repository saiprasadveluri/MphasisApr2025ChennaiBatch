using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms1
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void lblWelcome_Click(object sender, EventArgs e)
        {

        }

        private void addNewRestaurentToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void addNewRestaurentToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            AddNewRest anr= new AddNewRest();
            DialogResult = anr.ShowDialog();
            

        }
    }
}

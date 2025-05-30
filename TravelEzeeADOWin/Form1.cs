namespace TravelEzeeADOWin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void manageLocationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LocationMnager locationMnager = new LocationMnager();
            locationMnager.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void addServiceTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}

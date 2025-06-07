namespace TravelEfForm
{
    public partial class Form1 : Form
    {
        DataAccess dataAccess = new DataAccess();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridLocation.DataSource = dataAccess.GetAllLocations();
        }

        private void dataGridLocation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

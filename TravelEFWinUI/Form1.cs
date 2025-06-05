namespace TravelEFWin1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataAccess dataAccess = new DataAccess();
            List<Location> Locations = dataAccess.GetAllLocations();
            LocGrid.DataSource = Locations;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace TravelFormsEF
{
    public partial class ServiceTypeForm : Form
    {
        private readonly DataAccess _dataAccess;

        public ServiceTypeForm()
        {
            InitializeComponent();
            _dataAccess = new DataAccess();
        }

        private void AddServiceType_Click(object sender, EventArgs e)
        {
            try
            {
                var serviceTypeName = txtSerTypeName.Text.Trim();
                if (string.IsNullOrWhiteSpace(serviceTypeName))
                {
                    MessageBox.Show("Please enter a valid service type name.");
                    return;
                }

                long newServiceTypeId = GenerateNextServiceTypeId();
                double ratePerKm = (double)PricePerKm.Value;

                bool isSaved = _dataAccess.AddServiceType(newServiceTypeId, serviceTypeName, ratePerKm);

                MessageBox.Show(isSaved
                    ? "Service type added successfully."
                    : "Failed to add the service type.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private long GenerateNextServiceTypeId()
        {
            var serviceTypes = _dataAccess.GetAllServiceTypes();
            return serviceTypes.Any()
                ? serviceTypes.Max(s => s.STypeId) + 1
                : 1;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess;

namespace SilverOaksHotel
{
    public partial class Reporting : Form
    {
        public Reporting()
        {
            InitializeComponent();
        }

        private void btnReportingReturnHome_Click(object sender, EventArgs e)
        {
            var frmAdmin = new AdministratorHome();
            frmAdmin.Show();
            this.Close();
        }

        private void btnExporttoCSV_Click(object sender, EventArgs e)
        {
            var frmExportToCSV = new ExportToCSV();
            frmExportToCSV.Show();
            this.Close();
        }

        private void rdoBookingsPerTimePeriod_CheckedChanged(object sender, EventArgs e)
        {
            if(rdoBookingsPerTimePeriod.Checked)
            {
                lstReport.Items.Clear();
                List<String> reportBooking = new List<string>();
                reportBooking = AllMethods.BookingReportTimePeriod(dtpStart.Value, dtpEnd.Value);
                for(int i = 0; i < reportBooking.Count; i++)
                {
                    lstReport.Items.Add(reportBooking[i]);
                }
            }
        }

        private void rdoPopularPackages_CheckedChanged(object sender, EventArgs e)
        {
            if(rdoPopularPackages.Checked)
            {
                lstReport.Items.Clear();
                List<String> reportPackages = new List<string>();
                reportPackages = AllMethods.PackageReportTimePeriod(dtpStart.Value, dtpEnd.Value);
                for(int i = 0; i < reportPackages.Count; i++)
                {
                    lstReport.Items.Add(reportPackages[i]);
                }
            }
        }
    }
}

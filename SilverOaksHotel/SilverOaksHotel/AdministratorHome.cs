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
    public partial class AdministratorHome : Form
    {
        public AdministratorHome()
        {
            InitializeComponent();
        }

        private void btnALogOut_Click(object sender, EventArgs e)
        {
            var frmLogin = new Login();
            frmLogin.Show();
            this.Close();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            var frmMaintainEmployees = new MaintainEmployees();
            frmMaintainEmployees.Show();
            this.Close();
        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            var frmMaintainClients = new MaintainClients();
            frmMaintainClients.Show();
            this.Close();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            var frmReporting = new Reporting();
            frmReporting.Show();
            this.Close();
        }

        private void btnPackages_Click(object sender, EventArgs e)
        {
            var frmMaintainPackages = new MaintainPackages();
            frmMaintainPackages.Show();
            this.Close();
        }

        private void btnMaintainRooms_Click(object sender, EventArgs e)
        {
            var frmMaintainRoom = new MaintainRooms();
            frmMaintainRoom.Show();
            this.Close();

        }

        private void btnExporttoCSV_Click(object sender, EventArgs e)
        {
            var frmExport = new ExportToCSV();
            frmExport.Show();
            this.Close();
        }
    }
}

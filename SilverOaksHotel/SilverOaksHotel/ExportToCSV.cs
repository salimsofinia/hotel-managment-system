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
    public partial class ExportToCSV : Form
    {
        public ExportToCSV()
        {
            InitializeComponent();
        }

        private void btnCSVReturnHome_Click(object sender, EventArgs e)
        {
            var adminForm = new AdministratorHome();
            adminForm.Show();
            this.Close();
        }

        private void ExportToCSV_Load(object sender, EventArgs e)
        {
            AllMethods.PopulateTableNameComboBox(cboTableName);
        }

        private void btnSeeRequestedTable_Click(object sender, EventArgs e)
        {
            AllMethods.CrudOperations('R',$"SELECT * FROM {cboTableName.Text}",dgvRequestedTableData);
        }

        private void btnExportTableToCSV_Click(object sender, EventArgs e)
        {
            AllMethods.ExportToCSV(cboTableName.Text);
        }
    }
}

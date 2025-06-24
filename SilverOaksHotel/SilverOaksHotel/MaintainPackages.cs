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
    public partial class MaintainPackages : Form
    {
        private string packageName;
        private decimal packagePrice;

        public string PackageName
        {
            get { return packageName; }
            set { packageName = value; }
        }
        public decimal PackagePrice
        {
            get { return packagePrice; }
            set { packagePrice = value; }
        }

        public MaintainPackages()
        {
            InitializeComponent();
        }

        private void btnPackageReturnHome_Click(object sender, EventArgs e)
        {
            AdministratorHome frmAdmin = new AdministratorHome();
            frmAdmin.Show();
            this.Close();
        }

        private void txtPackageNameSearch_TextChanged(object sender, EventArgs e)
        {
            AllMethods.CrudOperations('R', $"SELECT * FROM Package WHERE Package_Name Like '%{txtPackageNameSearch.Text}%'", dgvAllPackages);
        }

        private void tbpViewPackages_Enter(object sender, EventArgs e)
        {
            txtPackageNameSearch.Clear();
            txtPackageNameSearch.Focus();
            AllMethods.CrudOperations('R', $"SELECT * FROM Package WHERE Package_Name Like '%{txtPackageNameSearch.Text}%'", dgvAllPackages);
        }

        private void btnClearPackageContent_Click(object sender, EventArgs e)
        {
            txtCreatePName.Focus();
            txtCreatePName.Clear();
            txtCreatePPrice.Clear();
        }

        private void btnCreatePackage_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtCreatePPrice.Text))
            {
                PackageName = txtCreatePName.Text;
                errorProvider1.Clear();
                if (!String.IsNullOrWhiteSpace(txtCreatePPrice.Text) && (decimal.TryParse(txtCreatePPrice.Text, out packagePrice)))
                {
                    PackagePrice = Convert.ToDecimal(txtCreatePPrice.Text);
                    errorProvider1.Clear();
                    AllMethods.CrudOperations('C', $"INSERT INTO Package (Package_Name, Package_Price) VALUES ('{PackageName}',{PackagePrice})", dgvAllPackages);
                    MessageBox.Show("Package Name " + txtCreatePName.Text + " has been successfully updated.", "Update Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnClearPackageContent_Click(sender, e);
                }
                else
                {
                    errorProvider1.SetError(txtCreatePPrice, "This field is required.\nMust be monetary value.");
                    txtCreatePPrice.Focus();
                }
            }
            else
            {
                errorProvider1.SetError(txtCreatePName, "This field is required.");
                txtCreatePName.Focus();
            }
        }

        private void tbpUpdatePackages_Enter(object sender, EventArgs e)
        {
            txtUpdatePackSearch.Clear();
            txtUpdatePackSearch.Focus();
            AllMethods.CrudOperations('R', $"SELECT * FROM Package WHERE Package_Name Like '%{txtUpdatePackSearch.Text}%'", dgvUpdatePackage);
        }

        private void btnSelectPackageName_Click(object sender, EventArgs e)
        {
            AllMethods.FillPackage(txtUpdatePackName, txtUpdatePackPrice, txtUpdatePackSearch.Text);
        }

        private void btnUpdatePack_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtUpdatePackName.Text))
            {
                PackageName = txtUpdatePackName.Text;
                errorProvider1.Clear();
                if (!String.IsNullOrWhiteSpace(txtUpdatePackPrice.Text) && (decimal.TryParse(txtUpdatePackPrice.Text, out packagePrice)))
                {
                    PackagePrice = Convert.ToDecimal(txtUpdatePackPrice.Text);
                    errorProvider1.Clear();
                    AllMethods.CrudOperations('U',$"UPDATE Package SET Package_Name = '{txtUpdatePackName.Text}', Package_Price = {Convert.ToDouble(txtUpdatePackPrice.Text)} WHERE Package_Name = '{txtUpdatePackSearch.Text}'",dgvUpdatePackage);
                    AllMethods.CrudOperations('R',"SELECT * FROM Package",dgvUpdatePackage);
                    MessageBox.Show("Package Name " + txtUpdatePackSearch.Text + " has been successfully updated.", "Update Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnClearPackageContent_Click(sender, e);
                }
                else
                {
                    errorProvider1.SetError(txtUpdatePackPrice, "This field is required.\nMust be monetary value.");
                    txtUpdatePackPrice.Focus();
                }
            }
            else
            {
                errorProvider1.SetError(txtUpdatePackName, "This field is required.");
                txtUpdatePackName.Focus();
            }
        }

        private void btnUpdateClearContent_Click(object sender, EventArgs e)
        {
            txtUpdatePackSearch.Focus();
            txtUpdatePackSearch.Clear();
            txtUpdatePackName.Clear();
            txtUpdatePackPrice.Clear();
        }

        private void txtDeletePackName_TextChanged(object sender, EventArgs e)
        {
            AllMethods.CrudOperations('R', $"SELECT * FROM Package WHERE Package_Name Like '%{txtDeletePackName.Text}%'", dgvDeletePackage);
        }

        private void txtUpdatePackSearch_TextChanged(object sender, EventArgs e)
        {
            AllMethods.CrudOperations('R', $"SELECT * FROM Package WHERE Package_Name Like '%{txtUpdatePackSearch.Text}%'", dgvUpdatePackage);
        }

        private void tbpDeletePackages_Enter(object sender, EventArgs e)
        {
            txtDeletePackName.Clear();
            txtDeletePackName.Focus();
            AllMethods.CrudOperations('R', $"SELECT * FROM Package", dgvDeletePackage);
        }

        private void btnDeletePackage_Click(object sender, EventArgs e)
        {
            AllMethods.CrudOperations('D', $"DELETE FROM Package WHERE Package_Name = '{txtDeletePackName.Text}'", dgvDeletePackage);
            MessageBox.Show("Package " + txtDeletePackName.Text + " has been deleted successfully.");
            AllMethods.CrudOperations('R', "SELECT * FROM Package", dgvDeletePackage);
            txtDeletePackName.Clear();
        }
    }
}

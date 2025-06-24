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
    public partial class MaintainClients : Form
    {
        private string clientLastName;
        private string clientFirstName;
        private string clientEmailAddress;
        private string clientPhoneNumber;

        public string ClientLastName
        {
            get { return clientLastName; }
            set { clientLastName = value; }
        }
        public string ClientFirstName
        {
            get { return clientFirstName; }
            set { clientFirstName = value; }
        }
        public string ClientEmailAddress
        {
            get { return clientEmailAddress; }
            set { clientEmailAddress = value; }
        }
        public string ClientPhoneNumber
        {
            get { return clientPhoneNumber; }
            set { clientPhoneNumber = value; }
        }

        public MaintainClients()
        {
            InitializeComponent();
        }

        private void btnClientReturnHome_Click(object sender, EventArgs e)
        {
            var frmAdmin = new AdministratorHome();
            frmAdmin.Show();
            this.Close();
        }

        private void tbpViewAllClients_Enter(object sender, EventArgs e)
        {
            AllMethods.CrudOperations('R', "SELECT * FROM Client", dgvViewClients);
        }

        private void tbpUpdateClients_Enter(object sender, EventArgs e)
        {
            AllMethods.CrudOperations('R', "SELECT * FROM Client", dgvUpdateClient);
        }

        private void txtSearchCName_TextChanged(object sender, EventArgs e)
        {
            AllMethods.CrudOperations('R', $"SELECT * FROM Client WHERE CAST(Client_ID AS VARCHAR) LIKE '%{txtSearchCName.Text}%'", dgvUpdateClient);
        }

        private void btnUpdateClient_Click(object sender, EventArgs e)
        {
            //
            errorProvider1.Clear();
            if(!String.IsNullOrWhiteSpace(txtUpdateClientName.Text))
            {
                if (!String.IsNullOrWhiteSpace(txtUpdateClientSName.Text))
                {
                    if (!String.IsNullOrWhiteSpace(txtUpdateClientNumber.Text) && txtUpdateClientNumber.Text.Length == 10)
                    {
                        if (!String.IsNullOrWhiteSpace(txtUpdateClientEmail.Text))
                        {
                            AllMethods.CrudOperations('U', $"UPDATE Client SET Client_Last_Name = '{txtUpdateClientSName.Text}', Client_First_Name = '{txtUpdateClientName.Text}', Client_Email_Address = '{txtUpdateClientEmail.Text}', Client_Phone_Number = '{txtUpdateClientNumber.Text}' WHERE Client_ID = {Convert.ToInt32(txtSearchCName.Text)}", dgvUpdateClient);
                            tbpUpdateClients_Enter(sender, e);
                            button1_Click(sender, e);
                        }
                        else
                        {
                            errorProvider1.SetError(txtUpdateClientEmail,"Invalid email");
                            txtUpdateClientEmail.Focus();
                        }
                    }
                    else
                    {
                        errorProvider1.SetError(txtUpdateClientNumber, "Invalid phone number");
                        txtUpdateClientNumber.Focus();
                    }
                }
                else
                {
                    errorProvider1.SetError(txtUpdateClientSName, "Invalid surname");
                    txtUpdateClientSName.Focus();
                }
            }
            else
            {
                errorProvider1.SetError(txtUpdateClientName, "Invalid name");
                txtUpdateClientName.Focus();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtUpdateClientName.Clear();
            txtUpdateClientSName.Clear();
            txtUpdateClientNumber.Clear();
            txtUpdateClientEmail.Clear();
            txtSearchCName.Clear();
        }

        private void tbpDeleteClient_Enter(object sender, EventArgs e)
        {
            AllMethods.CrudOperations('R', $"SELECT * FROM Client",dgvDeleteClient) ;
        }

        private void txtSearchDeleteClientName_TextChanged(object sender, EventArgs e)
        {
            AllMethods.CrudOperations('R', $"SELECT * FROM Client WHERE CAST(Client_ID AS VARCHAR) LIKE '%{txtSearchDeleteClientName.Text}%'", dgvDeleteClient);
        }

        private void btnDeleteClient_Click(object sender, EventArgs e)
        {
            AllMethods.CrudOperations('D',$"DELETE FROM Client WHERE Client_ID = {txtSearchDeleteClientName.Text}",dgvDeleteClient);
            tbpDeleteClient_Enter(sender, e);
            txtSearchDeleteClientName.Clear();
        }

        private void txtSearchClientName_TextChanged_1(object sender, EventArgs e)
        {
            AllMethods.CrudOperations('R', $"SELECT * FROM Client WHERE Client_Last_Name LIKE '%{txtSearchClientName.Text}%' OR Client_First_Name LIKE '%{txtSearchClientName.Text}%' OR Client_Email_Address LIKE '%{txtSearchClientName.Text}%' OR Client_Phone_Number LIKE '%{txtSearchClientName.Text}%'", dgvViewClients);
        }

        private void btnSelectClientId_Click(object sender, EventArgs e)
        {
            AllMethods.FillClients(Convert.ToInt32(txtSearchCName.Text), txtUpdateClientName, txtUpdateClientSName, txtUpdateClientNumber, txtUpdateClientEmail);

        }
    }
}

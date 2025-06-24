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
    public partial class MaintainEmployees : Form
    {
        private string employeeLastName;
        private string employeeFirstName;
        private string employeeIDNumber;
        private string employeePhoneNumber;
        private string employeeEmailAddress;
        private string employeeAuthorisationRole;
        private string employeeUsername;
        private string employeePassword;

        public string EmployeeLastName
        {
            get { return employeeLastName; }
            set { employeeLastName = value; }
        }
        public string EmployeeFirstName
        {
            get { return employeeFirstName; }
            set { employeeFirstName = value; }
        }
        public string EmployeeIDNumber
        {
            get { return employeeIDNumber; }
            set { employeeIDNumber = value; }
        }
        public string EmployeePhoneNumber
        {
            get { return employeePhoneNumber; }
            set { employeePhoneNumber = value; }
        }
        public string EmployeeEmailAddress
        {
            get { return employeeEmailAddress; }
            set { employeeEmailAddress = value; }
        }
        public string EmployeeAuthorisationRole
        {
            get { return employeeAuthorisationRole; }
            set { employeeAuthorisationRole = value; }
        }
        public string EmployeeUsername
        {
            get { return employeeUsername; }
            set { employeeUsername = value; }
        }
        public string EmployeePassword
        {
            get { return employeePassword; }
            set { employeePassword = value; }
        }

        public MaintainEmployees()
        {
            InitializeComponent();
        }

        private void btnEReturnHome_Click(object sender, EventArgs e)
        {
            var adminForm = new AdministratorHome();
            adminForm.Show();
            this.Close();
        }

        private void tbpViewEmployees_Enter(object sender, EventArgs e)
        {
            txtSearchEID.Clear();
            AllMethods.CrudOperations('R', "SELECT * FROM Employee", dgvAllEmployee);
        }

        private void txtSearchEID_TextChanged(object sender, EventArgs e)
        {
            AllMethods.CrudOperations('R', $"SELECT * FROM Employee WHERE CAST(Employee_ID AS VARCHAR) LIKE '%{txtSearchEID.Text}%'", dgvAllEmployee);
        }

        private void btnViewAdmin_Click(object sender, EventArgs e)
        {
            AllMethods.CrudOperations('R', $"SELECT * FROM Employee WHERE Employee_Authorisation_Role = 'Administrator'", dgvAllEmployee);
        }

        private void btnViewReceptionist_Click(object sender, EventArgs e)
        {
            AllMethods.CrudOperations('R', $"SELECT * FROM Employee WHERE Employee_Authorisation_Role = 'Receptionist'", dgvAllEmployee);
        }

        private void btnCreateNewEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrWhiteSpace(txtNewEName.Text))
                {
                    EmployeeFirstName = txtNewEName.Text;
                    errorProvider1.Clear();
                    if (!String.IsNullOrWhiteSpace(txtNewESName.Text))
                    {
                        EmployeeLastName = txtNewESName.Text;
                        errorProvider1.Clear();
                        if ((!String.IsNullOrWhiteSpace(txtNewEIDNumber.Text)) && (txtNewEIDNumber.Text.Length == 13))
                        {
                            EmployeeIDNumber = txtNewEIDNumber.Text;
                            errorProvider1.Clear();
                            if (!String.IsNullOrWhiteSpace(txtNewENumber.Text) && (txtNewENumber.Text.Length == 10))
                            {
                                EmployeePhoneNumber = txtNewENumber.Text;
                                errorProvider1.Clear();
                                if (!String.IsNullOrWhiteSpace(txtNewEEmail.Text))
                                {
                                    EmployeeEmailAddress = txtNewEEmail.Text;
                                    errorProvider1.Clear();
                                    if (!String.IsNullOrWhiteSpace(txtCreateEUsername.Text))
                                    {
                                        EmployeeUsername = txtCreateEUsername.Text;
                                        errorProvider1.Clear();
                                        if (!String.IsNullOrWhiteSpace(txtCreateEPassword.Text))
                                        {
                                            EmployeePassword = txtCreateEPassword.Text;
                                            errorProvider1.Clear();
                                            if (rdbAdmin.Checked || rdbReceptionist.Checked)
                                            {
                                                if (rdbAdmin.Checked)
                                                {
                                                    EmployeeAuthorisationRole = "Administrator";
                                                }
                                                if (rdbReceptionist.Checked)
                                                {
                                                    EmployeeAuthorisationRole = "Receptionist";
                                                }
                                                AllMethods.CrudOperations('C', $"INSERT INTO Employee (Employee_Last_Name,Employee_First_Name,Employee_ID_Number,Employee_Phone_Number,Employee_Email_Address,Employee_Authorisation_Role,Username,Password) VALUES ('{EmployeeLastName}','{EmployeeFirstName}','{EmployeeIDNumber}','{EmployeePhoneNumber}','{employeeEmailAddress}','{employeeAuthorisationRole}','{EmployeeUsername}','{EmployeePassword}')", dgvAllEmployee);
                                                MessageBox.Show("Employee " + employeeFirstName + " " + employeeLastName + " has been added successfully.");
                                            }
                                            else
                                            {
                                                errorProvider1.SetError(rdbAdmin, "This field is required.");
                                            }
                                        }
                                        else
                                        {
                                            errorProvider1.SetError(txtCreateEPassword, "This field is required.");
                                            txtCreateEPassword.Focus();
                                        }
                                    }
                                    else
                                    {
                                        errorProvider1.SetError(txtCreateEUsername, "This field is required.");
                                        txtCreateEUsername.Focus();
                                    }
                                }
                                else
                                {
                                    errorProvider1.SetError(txtNewEEmail, "This field is required.");
                                    txtNewEEmail.Focus();
                                }
                            }
                            else
                            {
                                errorProvider1.SetError(txtNewENumber, "This field is required.\nMust be a valid phone number.");
                                txtNewENumber.Focus();
                            }
                        }
                        else
                        {
                            errorProvider1.SetError(txtNewEIDNumber, "This field is required.\nMust be a valid ID number.");
                            txtNewEIDNumber.Focus();
                        }
                    }
                    else
                    {
                        errorProvider1.SetError(txtNewESName, "This field is required.");
                        txtNewESName.Focus();
                    }
                }
                else
                {
                    errorProvider1.SetError(txtNewEName, "This field is required.");
                    txtNewEName.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please contact your software solutions provider.\n" + ex.Message, "Developer Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClearNewDetails_Click(object sender, EventArgs e)
        {
            txtNewEName.Clear();
            txtNewESName.Clear();
            txtNewEIDNumber.Clear();
            txtNewENumber.Clear();
            txtNewEEmail.Clear();
            txtCreateEUsername.Clear();
            txtCreateEPassword.Clear();
            rdbReceptionist.Checked = false;
            rdbAdmin.Checked = false;
            txtNewEName.Focus();
        }

        private void tbpUpdateEmployee_Enter(object sender, EventArgs e)
        {
            AllMethods.CrudOperations('R', "SELECT * FROM Employee", dgvUpdateEmployee);
        }

        private void btnSelectID_Click(object sender, EventArgs e)
        {
            AllMethods.CrudOperations('R', $"SELECT * FROM Employee WHERE CAST(Employee_ID AS VARCHAR) LIKE '%{txtUpdatesearchEmployeeID.Text}%'", dgvUpdateEmployee);
            AllMethods.FillEmployees(Convert.ToInt32(txtUpdatesearchEmployeeID.Text), txtUpdateEName, txtUpdateESName, txtUpdateEIDNumber, txtUpdateENumber, txtUpdateEEmail, txtUpdateEUsername, txtUpdateEPassword, rdbUpdateReceptionist, rdbUpdateAdmin);
        }

        private void btnResetActiveEmployees_Click(object sender, EventArgs e)
        {
            tbpViewEmployees_Enter(sender, e);
        }

        private void btnUdateEDetails_Click(object sender, EventArgs e)
        {

            if (!String.IsNullOrWhiteSpace(txtUpdateEName.Text))
            {
                EmployeeFirstName = txtUpdateEName.Text;
                errorProvider1.Clear();
                if (!String.IsNullOrWhiteSpace(txtUpdateESName.Text))
                {
                    EmployeeLastName = txtUpdateESName.Text;
                    errorProvider1.Clear();
                    if ((!String.IsNullOrWhiteSpace(txtUpdateEIDNumber.Text)) && (txtUpdateEIDNumber.Text.Length == 13))
                    {
                        EmployeeIDNumber = txtUpdateEIDNumber.Text;
                        errorProvider1.Clear();
                        if (!String.IsNullOrWhiteSpace(txtUpdateENumber.Text) && (txtUpdateENumber.Text.Length == 10))
                        {
                            EmployeePhoneNumber = txtUpdateENumber.Text;
                            errorProvider1.Clear();
                            if (!String.IsNullOrWhiteSpace(txtUpdateEEmail.Text))
                            {
                                EmployeeEmailAddress = txtUpdateEEmail.Text;
                                errorProvider1.Clear();
                                if (!String.IsNullOrWhiteSpace(txtUpdateEUsername.Text))
                                {
                                    EmployeeUsername = txtUpdateEUsername.Text;
                                    errorProvider1.Clear();
                                    if (!String.IsNullOrWhiteSpace(txtUpdateEPassword.Text))
                                    {
                                        EmployeePassword = txtUpdateEPassword.Text;
                                        errorProvider1.Clear();
                                        if (rdbUpdateAdmin.Checked || rdbUpdateReceptionist.Checked)
                                        {
                                            if (rdbUpdateAdmin.Checked)
                                            {
                                                EmployeeAuthorisationRole = "Administrator";
                                            }
                                            if (rdbUpdateReceptionist.Checked)
                                            {
                                                EmployeeAuthorisationRole = "Receptionist";
                                            }
                                            AllMethods.CrudOperations('U', $"UPDATE Employee SET Employee_Last_Name = '{EmployeeLastName}',Employee_First_Name = '{EmployeeFirstName}',Employee_ID_Number = '{EmployeeIDNumber}',Employee_Phone_Number = '{EmployeePhoneNumber}',Employee_Email_Address = '{employeeEmailAddress}',Employee_Authorisation_Role = '{employeeAuthorisationRole}',Username = '{EmployeeUsername}',Password = '{EmployeePassword}' WHERE Employee_ID = {Convert.ToInt32(txtUpdatesearchEmployeeID.Text)}", dgvAllEmployee);
                                            AllMethods.CrudOperations('R',"SELECT * FROM Employee",dgvUpdateEmployee);
                                            MessageBox.Show(employeeFirstName + " " + EmployeeLastName + "'s information has been updated.");
                                            btnClearNewDetails_Click(sender, e);
                                        }
                                        else
                                        {
                                            errorProvider1.SetError(rdbUpdateAdmin, "This field is required.");
                                        }
                                    }
                                    else
                                    {
                                        errorProvider1.SetError(txtUpdateEPassword, "This field is required.");
                                        txtUpdateEPassword.Focus();
                                    }
                                }
                                else
                                {
                                    errorProvider1.SetError(txtUpdateEUsername, "This field is required.");
                                    txtUpdateEUsername.Focus();
                                }
                            }
                            else
                            {
                                errorProvider1.SetError(txtUpdateEEmail, "This field is required.");
                                txtUpdateEEmail.Focus();
                            }
                        }
                        else
                        {
                            errorProvider1.SetError(txtUpdateENumber, "This field is required.\nMust be a valid phone number.");
                            txtUpdateENumber.Focus();
                        }
                    }
                    else
                    {
                        errorProvider1.SetError(txtUpdateEIDNumber, "This field is required.\nMust be a valid ID number.");
                        txtUpdateEIDNumber.Focus();
                    }
                }
                else
                {
                    errorProvider1.SetError(txtUpdateESName, "This field is required.");
                    txtUpdateESName.Focus();
                }
            }
            else
            {
                errorProvider1.SetError(txtUpdateEName, "This field is required.");
                txtUpdateEName.Focus();
            }

        }

        private void btnClearUEDetails_Click(object sender, EventArgs e)
        {
            txtUpdateESName.Clear();
            txtUpdateEName.Clear();
            txtUpdateENumber.Clear();
            txtUpdateEEmail.Clear();
            txtUpdateEUsername.Clear();
            txtUpdateEPassword.Clear();
            txtUpdateEIDNumber.Clear();
            rdbUpdateAdmin.Checked = false;
            rdbUpdateReceptionist.Checked = false;
            txtUpdateEName.Focus();
        }

        private void tbpDeleteEmployee_Enter(object sender, EventArgs e)
        {
            AllMethods.CrudOperations('R',"SELECT * FROM Employee",dgvDeleteEmployee);
        }

        private void txtDeleteEID_TextChanged(object sender, EventArgs e)
        {
            AllMethods.CrudOperations('R', $"SELECT * FROM Employee WHERE CAST(Employee_ID AS VARCHAR) LIKE '%{txtDeleteEID.Text}%'", dgvDeleteEmployee);
        }

        private void btnDeleteSelectedID_Click(object sender, EventArgs e)
        {
            AllMethods.CrudOperations('D',$"DELETE FROM Employee WHERE Employee_ID = {Convert.ToInt32(txtDeleteEID.Text)}",dgvDeleteEmployee);
            MessageBox.Show("Employee ID " + txtDeleteEID.Text + " has been deleted successfully.");
            AllMethods.CrudOperations('R',"SELECT * FROM Employee",dgvDeleteEmployee);
            txtDeleteEID.Clear();
        }

        private void txtUpdatesearchEmployeeID_TextChanged(object sender, EventArgs e)
        {
            AllMethods.CrudOperations('R', $"SELECT * FROM Employee WHERE CAST(Employee_ID AS VARCHAR) LIKE '%{txtUpdatesearchEmployeeID.Text}%'", dgvUpdateEmployee);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (AllMethods.LoginValidation(txtUsername.Text, txtPassword.Text))
            {
                MessageBox.Show("Welcome " + AllMethods.UserFullName + "!", "Login Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (AllMethods.IsAdmin())
                {
                    var frmAdminstatorHome = new AdministratorHome();
                    frmAdminstatorHome.Show();
                }
                else
                {
                    var frmBooking = new MaintainBookings();
                    frmBooking.Show();
                }
                this.Close();
            }
            else
            {
                if ((String.IsNullOrWhiteSpace(txtUsername.Text)) && (String.IsNullOrWhiteSpace(txtPassword.Text)))
                {
                    MessageBox.Show("Please fill in all required fields.\nThis field is required.\nUsername\nPassword", "User Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtUsername.Focus();
                }
                else if (String.IsNullOrWhiteSpace(txtUsername.Text))
                {
                    MessageBox.Show("Please fill in all required fields.\nThis field is required.\nUsername", "User Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtUsername.Focus();
                }
                else if (String.IsNullOrWhiteSpace(txtPassword.Text))
                {
                    MessageBox.Show("Please fill in all required fields.\nThis field is required.\nPassword", "User Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPassword.Focus();
                }
                else
                {
                    MessageBox.Show("Invalid login details. Please try again.", "Login Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnClear_Click(sender, e);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtUsername.Focus();
        }
    }
}

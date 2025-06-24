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
    public partial class MaintainBookings : Form
    {
        private int numberAdults;
        private int numberChild;
        private decimal bookingTotal;
        private DateTime checkInDate;
        private DateTime checkOutDate;
        private bool bookingActive;
        private bool bookingPaid;
        private int clientID;
        private int roomID;
        private int packageID;
        private int employeeID;

        public int NumberAdults
        {
            get { return numberAdults; }
            set { numberAdults = value; }
        }
        public int NumberChild
        {
            get { return numberChild; }
            set { numberChild = value; }
        }
        public decimal BookingTotal
        {
            get { return bookingTotal; }
            set { bookingTotal = value; }
        }
        public DateTime CheckInDate
        {
            get { return checkInDate; }
            set { checkInDate = value; }
        }
        public DateTime CheckOutDate
        {
            get { return checkOutDate; }
            set { checkOutDate = value; }
        }
        public bool BookingActive
        {
            get { return bookingActive; }
            set { bookingActive = value; }
        }
        public bool BookingPaid
        {
            get { return bookingPaid; }
            set { bookingPaid = value; }
        }
        public int ClientID
        {
            get { return clientID; }
            set { clientID = value; }
        }
        public int RoomID
        {
            get { return roomID; }
            set { roomID = value; }
        }
        public int PackageID
        {
            get { return packageID; }
            set { packageID = value; }
        }
        public int EmployeeID
        {
            get { return employeeID; }
            set { employeeID = value; }
        }

        public MaintainBookings()
        {
            InitializeComponent();
        }

        private void lblBookDates_Click(object sender, EventArgs e)
        {

        }

        private void btnPayment_Click(object sender, EventArgs e)
        {

        }

        private void btnRLogOut_Click(object sender, EventArgs e)
        {
            var frmLogin = new Login();
            frmLogin.Show();
            this.Close();
        }

        private void btnClearBooking_Click(object sender, EventArgs e)
        {
            txtBOOKName.Clear();
            txtBOOKName.Focus();
            cbxBookPackage.SelectedIndex = -1;
            numAdults.Value = 0;
            numChildren.Value = 0;
            cbPaid.Checked = false;
        }

        private void tbpCreate_Enter(object sender, EventArgs e)
        {
            btnClearBooking_Click(sender, e);
        }

        private void btnClientCleardetails_Click(object sender, EventArgs e)
        {
            txtCName.Focus();
            txtCName.Clear();
            txtCSname.Clear();
            txtCNumber.Clear();
            txtCEmail.Clear();
        }

        private void btnMakebooking_Click(object sender, EventArgs e)
        {

            errorProvider1.Clear();
            if (!String.IsNullOrWhiteSpace(txtBOOKName.Text))
            {
                if (!String.IsNullOrWhiteSpace(cbxBookPackage.Text))
                {
                    if (numAdults.Value > 0)
                    {
                        if (numChildren.Value >= 0)
                        {
                            if (AllMethods.DoesClientExist(txtBOOKName.Text))
                            {
                                AllMethods.MakeBooking(Convert.ToInt32(numAdults.Value), Convert.ToInt32(numChildren.Value), txtBOOKName.Text, cbxBookPackage.Text, cbPaid.Checked,lblPrice);
                            }
                            else
                            {
                                txtCName.Focus();
                                MessageBox.Show("Client does not exist, create one");
                            }
                        }
                        else
                        {
                            errorProvider1.SetError(numChildren,"Invalid number of children");
                        }
                    }
                    else
                    {
                        errorProvider1.SetError(numAdults,"Invalid Number of Adults");
                    }
                }
                else
                {
                    errorProvider1.SetError(cbxBookPackage, "Invalid Package");
                    cbxBookPackage.Focus();
                }
            }
            else
            {
                errorProvider1.SetError(txtBOOKName, "Invalid Name");
                txtBOOKName.Focus();
            }

        }

        private void MaintainBookings_Load(object sender, EventArgs e)
        {
            AllMethods.PopulatePackagesComboBox(cbxBookPackage);
        }

        private void tbpViewBookings_Enter(object sender, EventArgs e)
        {
            AllMethods.CrudOperations('R',"SELECT * FROM Booking",dgvActiveBookings);
        }

        private void btnCreateClinet_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if(!String.IsNullOrWhiteSpace(txtCName.Text))
            {
                if(!String.IsNullOrWhiteSpace(txtCSname.Text))
                {
                    if(!String.IsNullOrWhiteSpace(txtCNumber.Text) && txtCNumber.Text.Length ==10)
                    {
                        if(!String.IsNullOrWhiteSpace(txtCEmail.Text))
                        {
                            if(!AllMethods.DoesClientExist(txtCName.Text+" "+txtCSname.Text))
                            {
                                AllMethods.CrudOperations('C', $"INSERT INTO Client (Client_Last_Name, Client_First_Name, Client_Email_Address, Client_Phone_Number) VALUES ('{txtCSname.Text}','{txtCName.Text}','{txtCEmail.Text}','{txtCNumber.Text}')", null);
                                MessageBox.Show("Client added");
                            }
                            else
                            {
                                MessageBox.Show("Client already exists");
                            }
                            
                        }
                        else
                        {
                            errorProvider1.SetError(txtCEmail,"Invalid email");
                            txtCEmail.Focus();
                        }
                    }
                    else
                    {
                        errorProvider1.SetError(txtCNumber,"Invalid phone number");
                        txtCNumber.Focus();
                    }
                }
                else
                {
                    errorProvider1.SetError(txtCSname,"Invalid surname");
                    txtCSname.Focus();
                }
            }
            else
            {
                errorProvider1.SetError(txtCName,"Invalid name");
                txtCName.Focus();
            }
        }

        private void txtUBookingID_TextChanged(object sender, EventArgs e)
        {
            AllMethods.AutoFillPackage(Convert.ToInt32(txtUBookingID.Text), lblCurrentPackage);
        }

        private void tbpUpdate_Enter(object sender, EventArgs e)
        {
            AllMethods.PopulatePackagesComboBox(cbxUpdatePackage);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int packageID = 0;
            packageID = AllMethods.GetPackageID(cbxUpdatePackage.Text);
            AllMethods.CrudOperations('U',$"UPDATE Booking SET Package_ID = {Convert.ToInt32(packageID)}, Booking_Total = {AllMethods.GetBookingPrice(cbxUpdatePackage.Text, Convert.ToInt32(txtUBookingID.Text))}  WHERE Booking_ID = {Convert.ToInt32(txtUBookingID.Text)}",null);
            MessageBox.Show("Package Updated");
        }

        private void tbpDelete_Enter(object sender, EventArgs e)
        {
            AllMethods.CrudOperations('R',"SELECT * FROM Booking",dgvDeleteBooking);
        }

        private void btnDeleteClient_Click(object sender, EventArgs e)
        {
            AllMethods.CrudOperations('D',$"DELETE FROM Booking WHERE Booking_ID = {Convert.ToInt32(txtDBookingID.Text)}",dgvDeleteBooking);
            AllMethods.CrudOperations('R',"SELECT * FROM Booking",dgvDeleteBooking);
            MessageBox.Show("Booking Deleted");
        }

        private void txtSearchBookingID_TextChanged(object sender, EventArgs e)
        {
            AllMethods.CrudOperations('R',$"SELECT * FROM Booking WHERE CAST(Booking_ID AS VARCHAR) LIKE '%{txtSearchBookingID.Text}%' AND Booking_Active = 'True'",dgvActiveBookings);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            AllMethods.CrudOperations('R', $"SELECT * FROM Booking WHERE CAST(Client_ID AS VARCHAR) LIKE '%{textBox1.Text}%' AND Booking_ACtive = 'True'", dgvActiveBookings);
        }

        private void tbpCheckOut_Enter(object sender, EventArgs e)
        {
            AllMethods.CrudOperations('R',"SELECT * FROM Booking WHERE Booking_Active = 'True'",dataGridView2);
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            AllMethods.CrudOperations('U',$"UPDATE Booking SET Booking_Active = 'False', Check_OutDate = '{AllMethods.GetDateTime()}'",dataGridView2);
            AllMethods.CrudOperations('R',"SELECT * FROM Booking WHERE Booking_Active = 'True'",dataGridView2);
            MessageBox.Show("Booking checked out successfully");
        }


    }
}

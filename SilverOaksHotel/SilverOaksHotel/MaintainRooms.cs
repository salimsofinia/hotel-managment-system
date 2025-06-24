using DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SilverOaksHotel
{
    public partial class MaintainRooms : Form
    {
        private int roomNumber;
        private bool roomAvailable;
        private int roomSize;

        public int RoomNumber
        {
            get { return roomNumber; }
            set { roomNumber = value; }
        }
        public bool RoomAvailable
        {
            get { return roomAvailable; }
            set { roomAvailable = value; }
        }
        public int RoomSize
        {
            get { return roomSize; }
            set { roomSize = value; }
        }

        public MaintainRooms()
        {
            InitializeComponent();
        }

        private void tbpViewRooms_Enter(object sender, EventArgs e)
        {
            txtSearchRoomNr.Clear();
            txtSearchRoomNr.Focus();
            AllMethods.CrudOperations('R', "SELECT * FROM Room", dgvViewAllRooms);
        }

        private void txtSearchRoomNr_TextChanged(object sender, EventArgs e)
        {
            AllMethods.CrudOperations('R', $"SELECT * FROM Room WHERE CAST(Room_Number AS VARCHAR) LIKE '%{txtSearchRoomNr.Text}%'", dgvViewAllRooms);
        }

        private void btnGoToRoomSize_Click(object sender, EventArgs e)
        {
            var frmMaintainRoomSize = new MaintainRoomSize();
            frmMaintainRoomSize.Show();
            this.Close();
        }

        private void btnRoomReturnHome_Click(object sender, EventArgs e)
        {
            var frmAdmin = new AdministratorHome();
            frmAdmin.Show();
            this.Close();
        }

        private void txtSearchUpdateRoomNr_TextChanged(object sender, EventArgs e)
        {
            AllMethods.CrudOperations('R', $"SELECT * FROM Room WHERE CAST(Room_Number AS VARCHAR) LIKE '%{txtSearchUpdateRoomNr.Text}%'", dgvUpdateRoom);
        }

        private void tbpUpdateRooms_Enter(object sender, EventArgs e)
        {
            txtSearchUpdateRoomNr.Clear();
            AllMethods.CrudOperations('R', "SELECT * FROM Room", dgvUpdateRoom);
        }

        private void btnSelectClientId_Click(object sender, EventArgs e)
        {
            AllMethods.CrudOperations('R', $"SELECT * FROM Room WHERE CAST(Room_Number AS VARCHAR) LIKE '%{txtSearchUpdateRoomNr.Text}%'", dgvUpdateRoom);
            AllMethods.FillRoom(Convert.ToInt32(txtSearchUpdateRoomNr.Text), txtUpdateRoomNumber, rdoYes, rdoNo);
        }

        private void btnUpdateRoom_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtUpdateRoomNumber.Text))
            {
                errorProvider1.Clear();
                if (int.TryParse(txtUpdateRoomNumber.Text, out roomNumber))
                {
                    errorProvider1.Clear();
                    RoomNumber = roomNumber;
                    if (rdoYes.Checked || rdoNo.Checked)
                    {
                        errorProvider1.Clear();
                        if (rdoYes.Checked)
                        {
                            RoomAvailable = true;
                        }
                        if (rdoNo.Checked)
                        {
                            RoomAvailable = false;
                        }
                       
                        AllMethods.CrudOperations('U', $"UPDATE Room SET Room_Number = {RoomNumber}, Room_Available = '{RoomAvailable.ToString()}' WHERE Room_Number = {Convert.ToInt32(txtSearchUpdateRoomNr.Text)}", dgvUpdateRoom);
                        AllMethods.CrudOperations('R', "SELECT * FROM Room", dgvUpdateRoom);
                        MessageBox.Show("Room's details have been updated.");
                        txtSearchUpdateRoomNr.Clear();
                        txtUpdateRoomNumber.Clear();
                        rdoYes.Checked = false;
                        rdoNo.Checked = false;
                    }
                    else
                    {
                        errorProvider1.SetError(rdoYes, "This field is required.");
                    }
                }
                else
                {
                    txtUpdateRoomNumber.Focus();
                    errorProvider1.SetError(txtUpdateRoomNumber, "This field is required.\nMust be type integer.");
                }
            }
            else
            {
                txtUpdateRoomNumber.Focus();
                errorProvider1.SetError(txtUpdateRoomNumber, "This field is required.");
            }
        }

        private void btnSelectRoomNumber_Click(object sender, EventArgs e)
        {
            AllMethods.CrudOperations('R', $"SELECT * FROM Room WHERE CAST(Room_Number AS VARCHAR) LIKE '%{txtSearchUpdateRoomNr.Text}%'", dgvUpdateRoom);
            AllMethods.FillRoom(Convert.ToInt32(txtSearchUpdateRoomNr.Text), txtUpdateRoomNumber, rdoYes, rdoNo);
        }
    }
}

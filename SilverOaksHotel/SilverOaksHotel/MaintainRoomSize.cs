using DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SilverOaksHotel
{
    public partial class MaintainRoomSize : Form
    {
        private string roomDescription;
        private decimal roomPrice;

        public string RoomDescription
        {
            get { return roomDescription; }
            set { roomDescription = value; }
        }
        public decimal RoomPrice
        {
            get { return roomPrice; }
            set { roomPrice = value; }
        }

        public MaintainRoomSize()
        {
            InitializeComponent();
        }

        private void btnRoomSizeReturnRoom_Click(object sender, EventArgs e)
        {
            var frmMaintainRoom = new MaintainRooms();
            frmMaintainRoom.Show();
            this.Close();
        }

        private void txtRoomSizeIdSearch_TextChanged(object sender, EventArgs e)
        {
            AllMethods.CrudOperations('R', $"SELECT * FROM Room_Size WHERE CAST(Size_ID AS VARCHAR) LIKE '%{txtRoomSizeIdSearch.Text}%'", dgvRoomSizeView);
        }

        private void tbpViewRoomSize_Enter(object sender, EventArgs e)
        {
            txtRoomSizeIdSearch.Clear();
            txtRoomSizeIdSearch.Focus();
            AllMethods.CrudOperations('R', "SELECT * FROM Room_Size", dgvRoomSizeView);
        }

        private void txtSearchUpdateRoomId_TextChanged(object sender, EventArgs e)
        {
            AllMethods.CrudOperations('R', $"SELECT * FROM Room_Size WHERE CAST(Size_ID AS VARCHAR) LIKE '%{txtSearchUpdateRoomId.Text}%'", dgvUpdateRoomSize);
        }

        private void tbpUpdateRoomSize_Enter(object sender, EventArgs e)
        {
            txtSearchUpdateRoomId.Clear();
            txtSearchUpdateRoomId.Focus();
            AllMethods.CrudOperations('R', "SELECT * FROM Room_Size", dgvUpdateRoomSize);
        }

        private void btnSelectSizeId_Click(object sender, EventArgs e)
        {
            AllMethods.FillSize(Convert.ToInt32(txtSearchUpdateRoomId.Text), txtRoomSizeDescriptioin, txtRoomSizePrice);
        }

        private void btnUpdateRoomSize_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtRoomSizeDescriptioin.Text))
            {
                errorProvider1.Clear();
                RoomDescription = txtRoomSizeDescriptioin.Text;
                if (!String.IsNullOrWhiteSpace(txtRoomSizePrice.Text) && (decimal.TryParse(txtRoomSizePrice.Text, out roomPrice)))
                {
                    errorProvider1.Clear();
                    RoomPrice = Convert.ToDecimal(txtRoomSizePrice.Text);

                    AllMethods.CrudOperations('U', $"UPDATE Room_Size SET Size_Description = '{RoomDescription}', Size_Price = {RoomPrice} WHERE Size_ID = {Convert.ToInt32(txtSearchUpdateRoomId.Text)}", dgvUpdateRoomSize);
                    AllMethods.CrudOperations('R', $"SELECT * FROM Room_Size", dgvUpdateRoomSize);
                    MessageBox.Show("Room ID " + txtSearchUpdateRoomId.Text + "'s information has been updated.");
                    txtRoomSizeDescriptioin.Clear();
                    txtRoomSizePrice.Clear();
                    txtRoomSizeIdSearch.Clear();
                    txtRoomSizeIdSearch.Focus();
                }
                else
                {
                    errorProvider1.SetError(txtRoomSizePrice, "This field is required.\nMust be monetary value.");
                    txtRoomSizePrice.Focus();
                }
            }
            else
            {
                errorProvider1.SetError(txtRoomSizeDescriptioin, "This field is required.");
                txtRoomSizeDescriptioin.Focus();
            }
        }
    }
}

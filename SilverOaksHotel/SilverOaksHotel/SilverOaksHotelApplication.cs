using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SilverOaksHotel
{
    public partial class SilverOaksHotelApplication : Form
    {
        public SilverOaksHotelApplication()
        {
            InitializeComponent();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmLogin = new Login();
            frmLogin.MdiParent = this;
            frmLogin.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void startApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}

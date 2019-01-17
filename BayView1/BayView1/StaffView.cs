using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace BayView1
{
    public partial class StaffView : Form
    {
        public StaffView()
        {
            InitializeComponent();
            //Start in the center of the screen.
            this.StartPosition = FormStartPosition.CenterScreen;

            label1.Text = "Welcome, " + GlobalData.GDUserName + " !";
            this.SysTimeLbl.Text = DateTime.Now.ToString();
            this.BJTimeLbl.Text = DateTimeOffset.UtcNow.UtcDateTime.ToString();
        }
        
        private void btnCustomer_Click(object sender, EventArgs e)
        {
            OldCustomer frmCustomer = new OldCustomer();
            frmCustomer.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to quit?", "Exit",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Back?");
            }
        }

        private void btnMark_Click(object sender, EventArgs e)
        {
            Customers frmCustomer2 = new Customers();
            frmCustomer2.ShowDialog();
        }

        private void btnBookings_Click(object sender, EventArgs e)
        {
            Bookings frmBookings = new Bookings();
            frmBookings.ShowDialog();
        }
    }
}

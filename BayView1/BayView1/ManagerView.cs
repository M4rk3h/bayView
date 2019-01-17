using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BayView1
{
    public partial class ManagerView : Form
    {
        public ManagerView()
        {
            InitializeComponent();
            //Start in center position
            this.StartPosition = FormStartPosition.CenterScreen;
            //This changes the Welcome at the top left, to Welcome Manager
            lblWelcome.Text = "Welcome, " + GlobalData.GDUserName + " !";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Create a pop up, asking if they want to quit.
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

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            //Open the Customers Form which was already created.
            Customers frmCustomer2 = new Customers();
            frmCustomer2.ShowDialog();
        }

        private void btnAnalytics_Click(object sender, EventArgs e)
        {
            //Open the Analytics Form.
            Analytics frmAnalytics = new Analytics();
            frmAnalytics.ShowDialog();
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            Staff frmStaff = new Staff();
            frmStaff.ShowDialog();
        }
    }
}

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
    public partial class Analytics : Form
    {
        public Analytics()
        {
            InitializeComponent();
            //Start in center position
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to quit?", "Exit",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Back?");
            }
        }
    }
}

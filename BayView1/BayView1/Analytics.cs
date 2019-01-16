using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

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

        private void Analytics_Load(object sender, EventArgs e)
        {
            staffChart.Titles.Clear();
            staffChart.Titles.Add("Total Staff Members");
            staffChart.ChartAreas[0].AxisX.IsMarginVisible = false;
            staffChart.ChartAreas[0].AxisX.Maximum = 10;
            staffChart.ChartAreas[0].AxisX.Minimum = 1;
            staffChart.ChartAreas[0].AxisX.Title="Staff";
        }
    }
}

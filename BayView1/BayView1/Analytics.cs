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
using System.Data.SQLite;

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

        //Details of the database
        string dbDetails = dbConnection.dbsource;
        //Details for Datatable (display) & DataAdapter (Pull+Push)
        SQLiteConnection dbCon;
        //Declare Series
        Series rooms;
        private string sql1;

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
            //Set properties for the Chart.
            Chart1.Titles.Clear();
            Chart1.Titles.Add("Total Staff Members");
            Chart1.ChartAreas[0].AxisX.IsMarginVisible = false;
            Chart1.ChartAreas[0].AxisX.Maximum = 10;
            Chart1.ChartAreas[0].AxisX.Minimum = 1;
            Chart1.ChartAreas[0].AxisX.Title = "Staff";

        }

        private void rbStaff_CheckedChanged(object sender, EventArgs e)
        {
            //Clear the chart.
            Chart1.Series.Clear();
            //Add a new series
            rooms = Chart1.Series.Add("Singles");
            rooms.Color = Color.DarkBlue;
            //Declare SQL
            sql1 = @"Select * From Staff;";
            
            //Try to connect.
            //try
            //{
            //    using (SQLiteCommand cmd = new SQLiteCommand(sql1, dbCon))
            //    {
            //        dbCon.Open();
            //        using 
            //        {
            //            int element = 0;
            //            while (dr.Read())
            //            {
            //                rooms.Points.AddXY(element, Convert.ToInt32(dr[0]));
            //                Chart1.Series[0].Points[element].AxisLabel = dr[1].ToString();
            //                Chart1.ResetAutoValues();
            //                Chart1.Update();
            //                element++;
            //            }
            //        }
            //        dbCon.Close();

            //    }
            //}

            //catch
            //{
            //    MessageBox.Show("Error on Radio Button");
            //}
        }
    }
}

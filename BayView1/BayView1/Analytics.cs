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
        Series staff;
        
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
            Chart1.Titles.Add("BayView Analytics");
            Chart1.ChartAreas[0].AxisX.IsMarginVisible = false;
            Chart1.ChartAreas[0].AxisX.Maximum = 10;
            Chart1.ChartAreas[0].AxisX.Minimum = 0;
            Chart1.ChartAreas[0].AxisX.Title = "Staff";

        }

        private void rbStaff_CheckedChanged(object sender, EventArgs e)
        {
            //Clear the chart.
            Chart1.Series.Clear();
            //Add a new series
            staff = Chart1.Series.Add("Staff");
            staff.Color = Color.DarkBlue;
            //Declare SQL
            string sql1 = @"Select * From Staff;";
            
            //Try to connect.
            try
            {
                //Use the SQLiteCommand cmd to create a new command, using SQL1 string and db connection.
                using (SQLiteCommand cmd = new SQLiteCommand(sql1, dbCon))
                {
                    //Open the connection and create a new SQLDataReader called DR.
                    dbCon.Open();
                    using (SQLiteDataReader dr = cmd.ExecuteReader())
                    {
                        int element = 0;
                        while (dr.Read())
                        {
                            staff.Points.AddXY(element, Convert.ToInt32(dr[0]));
                            Chart1.Series[0].Points[element].AxisLabel = dr[1].ToString();
                            Chart1.ResetAutoValues();
                            Chart1.Update();
                            element++;
                        }
                    }
                    dbCon.Close();
                }
            }
            catch
            {
                MessageBox.Show("Error on Radio Button Staff");
            }
        }
    }
}

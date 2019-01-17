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
using System.IO;


namespace BayView1
{
    public partial class Homeform : Form
    {
        public Homeform()
        {
            InitializeComponent();
        }

        //create a connection object
        SQLiteConnection conn = new SQLiteConnection();

        //used to hold the database file details
        string conString;

        private void Search_Click(object sender, EventArgs e)
        {
            //this code is for enabling the search function to work
            openFileDialog1.Title = "Select an SQLite database file:";
            openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            openFileDialog1.Filter = "Database files (*.db)|*.db";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.FileName = "";

            if (openFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
                conString = @"Data Source =" + openFileDialog1.FileName;
                //this code for disabling the help and edit functions until the database file is connected
                // conString = @"Data Source =" + openFileDialog1.FileName;

                testcon.Enabled = true;
                Booking.Enabled = false;
                bookingOrders.Enabled = false;
                UpdateBooking.Enabled = false;
                cancelation.Enabled = false;
                tssImage.Text = "Set to: " + openFileDialog1.FileName;
            }
        }

        private void testcon_Click(object sender, EventArgs e)
        {
            try
            {
                timer1.Start();
                testcon.Enabled = false;
                ConnectQ.Enabled = false;
                conn.ConnectionString = conString;
                conn.Open();


                if (conn.State == System.Data.ConnectionState.Open)
                    tssImage.Text = "## testing connection ##";
            }
            catch (Exception ex)
            {
                if (conn.State == System.Data.ConnectionState.Open)
                    conn.Close();
                tssImage.Text = "Set to: " + openFileDialog1.FileName;
                Booking.Enabled = false;
                bookingOrders.Enabled = false;
                UpdateBooking.Enabled = false;
                cancelation.Enabled = false;
                MessageBox.Show(ex.Message);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            if (conn.State == System.Data.ConnectionState.Open)
            {
                tssImage.Text = openFileDialog1.FileName;
                tssImage.Text = "Using: " + Path.GetFileName(openFileDialog1.FileName);


                Booking.Enabled = true;
                bookingOrders.Enabled = true;
                UpdateBooking.Enabled = true;
                cancelation.Enabled = true;
                conn.Close();
            }
        }

        private void Booking_Click(object sender, EventArgs e)
        {
            Bookings frmbookings = new Bookings(conString);
            frmbookings.ShowDialog();
        }

        private void UpdateBooking_Click(object sender, EventArgs e)
        {
            Update_Bookings frmUpdate_Bookings = new Update_Bookings(conString);
            frmUpdate_Bookings.ShowDialog();
        }

        private void bookingOrders_Click(object sender, EventArgs e)
        {
            Booking_Orders frmbooking_orders = new Booking_Orders(conString);
            frmbooking_orders.ShowDialog();
        }

        private void ConnectQ_Click(object sender, EventArgs e)
        {
            testcon_Click(sender, e);
        }

        private void cancelation_Click(object sender, EventArgs e)
        {
            Cancellation frmCancellation = new Cancellation(conString);
            frmCancellation.ShowDialog();
        }
    }
}

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
    public partial class Booking_Orders : Form
    {
        public Booking_Orders(string inString)
        {
            InitializeComponent();

            conString = inString;
        }

        string conString;


        SQLiteConnection dbconn = new SQLiteConnection();

        SQLiteDataAdapter dabooking;
        SQLiteDataAdapter dabookingorder;



        DataTable dtbooking = new DataTable();
        DataTable dtbookingorder = new DataTable();


        string sql1 = @"Select BookingNo, DateDue, DateOut From NewBookings";
        string sql2 = @"Select * From BookingOrders";

        DataTable dtSelect = new DataTable();

        private void Booking_Orders_Load(object sender, EventArgs e)
        {

            try
            {
                //assign the connection string to the SQLiteConnection
                dbconn.ConnectionString = conString;

                //code to set up the DataAdapters
                dabooking = new SQLiteDataAdapter(sql1, dbconn);
                dabookingorder = new SQLiteDataAdapter(sql2, dbconn);


                //Fill the DataTables
                dabooking.Fill(dtbooking);
                dabookingorder.Fill(dtbookingorder);




                //Bind datatable dtbooking to the booking ComboBox
                cbbookingNo.DataSource = dtbooking;
                cbbookingNo.DisplayMember = "BookingNo";
                cbbookingNo.ValueMember = "BookingNo";
                cbbookingNo.SelectedIndex = -1;



                //Bind datatable dtbookingorder to the bookingno1 ComboBox for deleting ID's
                cbbookingNo1.DataSource = dtbookingorder;
                cbbookingNo1.DisplayMember = "BookingNo";
                cbbookingNo1.ValueMember = "OrderNo";
                cbbookingNo1.SelectedIndex = -1;

                //Bind datatable dtbookingorder to the totalpaid ComboBox
                cbtotalpaid.DataSource = dtbookingorder;
                 cbtotalpaid.DisplayMember = "TotalPaid";
                 cbtotalpaid.ValueMember = "OrderNo";
                 cbtotalpaid.SelectedIndex = -1;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //insert a new sales record
            //set up a SQLiteCommand object to use with the connection
            using (SQLiteCommand dbcmd = dbconn.CreateCommand())
            {
                try
                {
                    dbcmd.CommandText =
                      @"Insert Into BookingOrders (BookingNo, TotalPaid)"
                    + @" Values( @book, @totp)";

                    dbcmd.Parameters.AddWithValue("book", cbbookingNo.SelectedValue);
                    dbcmd.Parameters.AddWithValue("totp", txttotalpaid.Text);


                    //update the database with new booking order details
                    dbconn.Open();
                    int changed = dbcmd.ExecuteNonQuery();
                    if (changed == 1)
                        MessageBox.Show("Booking Order is Complete.");
                    dbconn.Close();
                    // btnCancel_Click(null, null);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }

            }


        }


        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                using (SQLiteConnection dbconn = new SQLiteConnection(conString))
                {
                    using (SQLiteCommand dbcmd = dbconn.CreateCommand())
                    {
                        //delete the booking no from the table
                        dbcmd.CommandText = @"Delete From BookingOrders Where BookingNo = @id";
                        dbcmd.Parameters.AddWithValue("id", Convert.ToInt32(cbbookingNo1.Text));
                        dbconn.Open();
                        int recordsChanged = dbcmd.ExecuteNonQuery();
                        MessageBox.Show(recordsChanged.ToString() + " Records Deleted");
                        dbconn.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

      

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {

                using (SQLiteConnection dbconn = new SQLiteConnection(conString))
                {
                    using (SQLiteCommand dbcmd = dbconn.CreateCommand())
                    {

                        dbcmd.CommandText = @"Update BookingOrders Set TotalPaid = @totp" + " Where BookingNo = @id";
                        dbcmd.Parameters.AddWithValue("totp", txttotalpaid.Text);
                        dbcmd.Parameters.AddWithValue("id", Convert.ToInt32(cbbookingNo.Text));


                        ////this code is to update the database with new status details
                        dbconn.Open();
                        int changed = dbcmd.ExecuteNonQuery();
                        if (changed == 1)
                               MessageBox.Show("Update Complete.");
                            dbconn.Close();
                        //btncancel_Click(null, null);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {

            cbbookingNo.SelectedIndex = -1;
            cbbookingNo1.SelectedIndex = -1;
            cbtotalpaid.SelectedIndex = -1;
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkStatus()
        {
            //only when all fields have been filled, activte the submit button
            if (cbbookingNo.SelectedIndex != -1
                && cbbookingNo1.SelectedIndex != -1
                && cbtotalpaid.SelectedIndex != -1)
            {
                btnUpdate.Enabled = true;
                btnSubmit.Enabled = true;
                btndelete.Enabled = true;
                btncancel.Enabled = true;
            }
            else
            {
                btnUpdate.Enabled = false;
                btnSubmit.Enabled = false;
                btndelete.Enabled = false;
                btncancel.Enabled = false;
            }
        }

        private void cbbookingNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkStatus();
        }


        private void cbbookingNo1_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkStatus();
        }

        private void cbtotalpaid_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkStatus();
        }
    }
}


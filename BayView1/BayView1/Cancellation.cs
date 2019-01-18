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
    public partial class Cancellation : Form
    {
        public Cancellation(string inString)
        {
            InitializeComponent();
            conString = inString;
            //Start in the center of the screen.
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        string conString;


        SQLiteConnection dbconn = new SQLiteConnection();

        SQLiteDataAdapter dabookingorder;
        SQLiteDataAdapter dacustomer;
        SQLiteDataAdapter dastaff;
        SQLiteDataAdapter dacancel;



        DataTable dtbookingorder = new DataTable();
        DataTable dtcustomer = new DataTable();
        DataTable dtstaff = new DataTable();
        DataTable dtcancel = new DataTable();


        string sql1 = @"Select * From BookingOrders";
        string sql2 = @"Select CustomerNo From Customers";
        string sql3 = @"Select StaffNo From Staff";
        string sql4 = @"Select * From Cancelation";

        DataTable dtSelect = new DataTable();

        private void Cancellation_Load(object sender, EventArgs e)
        {
            try
            {
                //assign the connection string to the SQLiteConnection
                dbconn.ConnectionString = conString;

                //code to set up the DataAdapters
                dabookingorder = new SQLiteDataAdapter(sql1, dbconn);
                dacustomer = new SQLiteDataAdapter(sql2, dbconn);
                dastaff = new SQLiteDataAdapter(sql3, dbconn);
                dacancel = new SQLiteDataAdapter(sql4, dbconn);

                //Fill the DataTables
                dabookingorder.Fill(dtbookingorder);
                dacustomer.Fill(dtcustomer);
                dastaff.Fill(dtstaff);
                dacancel.Fill(dtcancel);




                //Bind datatable dtbookingorder to the order ComboBox
                cborderno.DataSource = dtbookingorder;
                cborderno.DisplayMember = "OrderNo";
                cborderno.ValueMember = "OrderNo";
                cborderno.SelectedIndex = -1;


                //Bind datatable dtcustomer to the customerno ComboBox
                cbcustomerNo.DataSource = dtcustomer;
                cbcustomerNo.DisplayMember = "CustomerNo";
                cbcustomerNo.ValueMember = "CustomerNo";
                cbcustomerNo.SelectedIndex = -1;


                //Bind datatable dtstaff to the StaffNo ComboBox
                cbstaffNo.DataSource = dtstaff;
                cbstaffNo.DisplayMember = "StaffNo";
                cbstaffNo.ValueMember = "StaffNo";
                cbstaffNo.SelectedIndex = -1;

                //Bind datatable dtcancel to the cancel ComboBox
                cbcancelno.DataSource = dtcancel;
                cbcancelno.DisplayMember = "CancelNo";
                cbcancelno.ValueMember = "CancelNo";
                cbcancelno.SelectedIndex = -1;

                //Bind datatable dtcancel to the order ComboBox
                cborderno1.DataSource = dtcancel;
                cborderno1.DisplayMember = "OrderNo";
                cborderno1.ValueMember = "OrderNo";
                cborderno1.SelectedIndex = -1;


                //Bind datatable dtcancel to the customer ComboBox
                cbcustomerno1.DataSource = dtcancel;
                cbcustomerno1.DisplayMember = "CustomerNo";
                cbcustomerno1.ValueMember = "CustomerNo";
                cbcustomerno1.SelectedIndex = -1;


                //Bind datatable dtcancel to the StaffNo ComboBox
                cbstaffno1.DataSource = dtcancel;
                cbstaffno1.DisplayMember = "StaffNo";
                cbstaffno1.ValueMember = "StaffNo";
                cbstaffno1.SelectedIndex = -1;

                //Bind datatable dtcancel to the cancalation ComboBox
                cbcancelation.DataSource = dtcancel;
                cbcancelation.DisplayMember = "CancelationDate";
                cbcancelation.ValueMember = "CancelNo";
                cbcancelation.SelectedIndex = -1;


                //Bind datatable dtcancel to the cancel ComboBox for deleting ID's
                cbcancelno1.DataSource = dtcancel;
                cbcancelno1.DisplayMember = "CancelNo";
                cbcancelno1.ValueMember = "CancelNo";
                cbcancelno1.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            using (SQLiteCommand dbcmd = dbconn.CreateCommand())
            {
                try
                {
                    dbcmd.CommandText =
                      @"Insert Into Cancelation (OrderNo, CustomerNo, StaffNo, CancelationDate)"
                    + @" Values( @ordn, @cust, @staf, @cdte)";

                    dbcmd.Parameters.AddWithValue("ordn", cborderno.SelectedValue);
                    dbcmd.Parameters.AddWithValue("cust", cbcustomerNo.SelectedValue);
                    dbcmd.Parameters.AddWithValue("staf", cbstaffNo.SelectedValue);
                    dbcmd.Parameters.AddWithValue("cdte", txtcanceldate.Text);



                    //update the database with new booking order details
                    dbconn.Open();
                    int changed = dbcmd.ExecuteNonQuery();
                    if (changed == 1)
                        MessageBox.Show("Cancelation Form Complete.");
                    dbconn.Close();
                    // btnCancel_Click(null, null);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }

            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            cborderno.SelectedIndex = -1;
            cbcustomerNo.SelectedIndex = -1;
            cbstaffNo.SelectedIndex = -1;
        }



        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {

                using (SQLiteConnection dbconn = new SQLiteConnection(conString))
                {
                    using (SQLiteCommand dbcmd = dbconn.CreateCommand())
                    {

                        dbcmd.CommandText = @"Update Cancelation Set OrderNo = @ordn" + " Where CancelNo = @id";


                        dbcmd.Parameters.AddWithValue("ordn", cborderno1.SelectedValue);
                        dbcmd.Parameters.AddWithValue("id", Convert.ToInt32(cbcancelno.Text));


                        ////this code is to update the database with new status details
                        dbconn.Open();
                        int changed = dbcmd.ExecuteNonQuery();
                        if (changed == 1)
                            dbconn.Close();
                        btncancel_Click(null, null);
                    }

                    using (SQLiteCommand dbcmd = dbconn.CreateCommand())
                    {

                        dbcmd.CommandText = @"Update Cancelation Set CustomerNo = @cust" + " Where CancelNo = @id";
                        dbcmd.Parameters.AddWithValue("cust", cbcustomerno1.SelectedValue);
                        dbcmd.Parameters.AddWithValue("id", Convert.ToInt32(cbcancelno.Text));

                        dbconn.Open();
                        int changed = dbcmd.ExecuteNonQuery();
                        if (changed == 1)
                            dbconn.Close();
                        btncancel_Click(null, null);
                    }

                    using (SQLiteCommand dbcmd = dbconn.CreateCommand())
                    {
                        dbcmd.CommandText = @"Update Cancelation Set StaffNo = @staf" + " Where CancelNo = @id";
                        dbcmd.Parameters.AddWithValue("staf", cbstaffno1.SelectedValue);
                        dbcmd.Parameters.AddWithValue("id", Convert.ToInt32(cbcancelno.Text));

                        dbconn.Open();
                        int changed = dbcmd.ExecuteNonQuery();
                        if (changed == 1)
                            dbconn.Close();
                        btncancel_Click(null, null);
                    }


                    using (SQLiteCommand dbcmd = dbconn.CreateCommand())
                    {

                        dbcmd.CommandText = @"Update Cancelation Set CancelationDate = @cdt" + " Where CancelNo = @id";
                        dbcmd.Parameters.AddWithValue("cdt", cbcancelation.SelectedValue);
                        dbcmd.Parameters.AddWithValue("id", Convert.ToInt32(cbcancelno.Text));

                        dbconn.Open();
                        int changed = dbcmd.ExecuteNonQuery();
                        if (changed == 1)
                            dbconn.Close();
                        btncancel_Click(null, null);
                    }

                    using (SQLiteCommand dbcmd = dbconn.CreateCommand())
                    {

                        dbcmd.CommandText = @"Update Cancelation Set CancelationDate = @cdt" + " Where CancelNo = @id";
                        dbcmd.Parameters.AddWithValue("cdt", txtcancelation.Text);
                        dbcmd.Parameters.AddWithValue("id", Convert.ToInt32(cbcancelno.Text));


                        dbconn.Open();
                        int changed = dbcmd.ExecuteNonQuery();
                        if (changed == 1)
                            dbconn.Close();
                        MessageBox.Show("Cancelation Update Complete.");
                        btncancel_Click(null, null);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
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
                        dbcmd.CommandText = @"Delete From Cancelation Where CancelNo = @id";
                        dbcmd.Parameters.AddWithValue("id", Convert.ToInt32(cbcancelno1.Text));
                        dbconn.Open();
                        int recordsChanged = dbcmd.ExecuteNonQuery();
                        MessageBox.Show(recordsChanged.ToString() + " Cancel Record Deleted");
                        dbconn.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }


        }
        private void checkStatus()
        {
            //only when all fields have been filled, activte the submit button
            if (cbcancelno.SelectedIndex != -1
                && cbcancelno1.SelectedIndex != -1
                && cbcustomerNo.SelectedIndex != -1
                && cbcustomerno1.SelectedIndex != -1
                 && cbstaffNo.SelectedIndex != -1
                && cbstaffno1.SelectedIndex != -1
                 && cbcancelation.SelectedIndex != -1)


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

        private void cbcancelno_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkStatus();
        }

        private void cborderno_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkStatus();
        }

        private void cbcustomerNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkStatus();
        }

        private void cbstaffNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkStatus();
        }

        private void cborderno1_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkStatus();
        }

        private void cbcustomerno1_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkStatus();
        }

        private void cbstaffno1_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkStatus();
        }

        private void cbcancelation_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkStatus();
        }

        private void cbcancelno1_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkStatus();
        }

        private void btnclose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

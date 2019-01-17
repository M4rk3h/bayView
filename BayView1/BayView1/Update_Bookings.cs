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
    public partial class Update_Bookings : Form
    {
        public Update_Bookings (string inString)
        {
            InitializeComponent();

        conString = inString;
        }

    string conString;

        SQLiteConnection dbconn = new SQLiteConnection();

        SQLiteDataAdapter dastaff;
        SQLiteDataAdapter dabooking;
        SQLiteDataAdapter dacustomer;
        SQLiteDataAdapter daroom;



        DataTable dtstaff = new DataTable();
        DataTable dtbooking = new DataTable();
        DataTable dtcustomer = new DataTable();
        DataTable dtroom = new DataTable();


        string sql1 = @"Select StaffNo, Manager From staff";
        string sql2 = @"Select * From NewBookings";
        string sql3 = @"Select CustomerNo, FirstName, LastName From Customers";
        string sql4 = @"Select RoomNo, RoomNumber, RoomType From Rooms";

        DataTable dtSelect = new DataTable();

        private void Update_Bookings_Load(object sender, EventArgs e)
        {
            try
            {
                //assign the connection string to the SQLiteConnection
                dbconn.ConnectionString = conString;

                //code to set up the DataAdapters
                dastaff = new SQLiteDataAdapter(sql1, dbconn);
                dabooking = new SQLiteDataAdapter(sql2, dbconn);
                dacustomer = new SQLiteDataAdapter(sql3, dbconn);
                daroom = new SQLiteDataAdapter(sql4, dbconn);


                //Fill the DataTables
                dastaff.Fill(dtstaff);
                dabooking.Fill(dtbooking);
                dacustomer.Fill(dtcustomer);
                daroom.Fill(dtroom);


                //Bind datatable dtbooking to the bookingno ComboBox
                cbbookingNo.DataSource = dtbooking;
                cbbookingNo.DisplayMember = "BookingNo";
                cbbookingNo.ValueMember = "BookingNo";
                cbbookingNo.SelectedIndex = -1;


                //Bind datatable for stbooking to the datedue combobox 
                cbdatedue.DataSource = dtbooking;
                cbdatedue.DisplayMember = "DateDue";
                cbdatedue.ValueMember = "BookingNo";
                cbdatedue.SelectedIndex = -1;



                //Bind datatable dtbooking to the dateout ComboBox
                cbdateout.DataSource = dtbooking;
                cbdateout.DisplayMember = "DateOut";
                cbdateout.ValueMember = "BookingNo";
                cbdateout.SelectedIndex = -1;

                //Bind datatable dtbooking to the duration ComboBox
                cbduration.DataSource = dtbooking;
                cbduration.DisplayMember = "Duration";
                cbduration.ValueMember = "BookingNo";
                cbduration.SelectedIndex = -1;

                //Bind datatable dtbooking to the bookingno1 ComboBox for deleting ID's
                cbbookingNo1.DataSource = dtbooking;
                cbbookingNo1.DisplayMember = "BookingNo";
                cbbookingNo1.ValueMember = "BookingNo";
                cbbookingNo1.SelectedIndex = -1;



                //Bind datatable dtstaff to the StaffNo ComboBox
                cbstaffNo.DataSource = dtstaff;
                cbstaffNo.DisplayMember = "StaffNo";
                cbstaffNo.ValueMember = "StaffNo";
                cbstaffNo.SelectedIndex = -1;
                // gbmanager.Enabled = true;


                //Bind datatable dtstaff to the manager ComboBox
                cbmanager.DataSource = dtstaff;
                cbmanager.DisplayMember = "Manager";
                cbmanager.ValueMember = "StaffNo";
                cbmanager.SelectedIndex = -1;



                //Bind datatable dtcustomer to the customerno ComboBox
                cbcustomerNo.DataSource = dtcustomer;
                cbcustomerNo.DisplayMember = "CustomerNo";
                cbcustomerNo.ValueMember = "CustomerNo";
                cbcustomerNo.SelectedIndex = -1;


                //Bind datatable dtcustomer to the firstname ComboBox
                cbfirstname.DataSource = dtcustomer;
                cbfirstname.DisplayMember = "FirstName";
                cbfirstname.ValueMember = "CustomerNo";
                cblastname.SelectedIndex = -1;

                //Bind datatable dtcustomer to the lastname ComboBox
                cblastname.DataSource = dtcustomer;
                cblastname.DisplayMember = "LastName";
                cblastname.ValueMember = "CustomerNo";
                cblastname.SelectedIndex = -1;

                //Bind datatable dtroom to the roomno ComboBox
                cbroomNo.DataSource = dtroom;
                cbroomNo.DisplayMember = "RoomNo";
                cbroomNo.ValueMember = "RoomNo";
                cbroomNo.SelectedIndex = -1;

                //Bind datatable dtroom to the roomnumber ComboBox
                cbroomnumber.DataSource = dtroom;
                cbroomnumber.DisplayMember = "RoomNumber";
                cbroomnumber.ValueMember = "RoomNo";
                cbroomnumber.SelectedIndex = -1;


                //Bind datatable dtroom to the roomtype ComboBox
                cbroomtype.DataSource = dtroom;
                cbroomtype.DisplayMember = "RoomType";
                cbroomtype.ValueMember = "RoomNo";
                cbroomtype.SelectedIndex = -1;


                //Bind datatable dtbooking to the totalpayment ComboBox
                cbtotalpayment.DataSource = dtbooking;
                cbtotalpayment.DisplayMember = "TotalPayment";
                cbtotalpayment.ValueMember = "BookingNo";
                cbtotalpayment.SelectedIndex = -1;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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

                        dbcmd.CommandText = @"Update NewBookings Set StaffNo = @stfno" + " Where BookingNo = @id";


                        dbcmd.Parameters.AddWithValue("stfno", cbstaffNo.SelectedValue);
                        dbcmd.Parameters.AddWithValue("id", Convert.ToInt32(cbbookingNo.Text));


                     
                        dbconn.Open();
                        int changed = dbcmd.ExecuteNonQuery();
                        if (changed == 1)
                            dbconn.Close();
                          btncancel_Click(null, null);
                    }

                    using (SQLiteCommand dbcmd = dbconn.CreateCommand())
                    {
                        dbcmd.CommandText = @"Update NewBookings Set CustomerNo = @custno" + " Where BookingNo = @id";
                        dbcmd.Parameters.AddWithValue("custno", cbcustomerNo.SelectedValue);
                        dbcmd.Parameters.AddWithValue("id", Convert.ToInt32(cbbookingNo.Text));

                        dbconn.Open();
                        int changed = dbcmd.ExecuteNonQuery();
                        if (changed == 1)
                            dbconn.Close();
                        btncancel_Click(null, null);
                    }

                    using (SQLiteCommand dbcmd = dbconn.CreateCommand())
                    {
                        dbcmd.CommandText = @"Update NewBookings Set RoomNo = @romno " + " Where BookingNo = @id";
                        dbcmd.Parameters.AddWithValue("romno", cbroomNo.SelectedValue);
                        dbcmd.Parameters.AddWithValue("id", Convert.ToInt32(cbbookingNo.Text));

                        dbconn.Open();
                        int changed = dbcmd.ExecuteNonQuery();
                        if (changed == 1)
                            dbconn.Close();
                      btncancel_Click(null, null);
                    }


                    using (SQLiteCommand dbcmd = dbconn.CreateCommand())
                    {

                        dbcmd.CommandText = @"Update NewBookings Set Duration = @dur" + " Where BookingNo = @id";
                        dbcmd.Parameters.AddWithValue("dur", numericUpDown.Value);
                        dbcmd.Parameters.AddWithValue("id", Convert.ToInt32(cbbookingNo.Text));

                        dbconn.Open();
                        int changed = dbcmd.ExecuteNonQuery();
                        if (changed == 1)
                            MessageBox.Show("Record Update Complete.");
                        dbconn.Close();
                       btncancel_Click(null, null);
                    }

                    using (SQLiteCommand dbcmd = dbconn.CreateCommand())
                    {

                        dbcmd.CommandText = @"Update NewBookings Set DateDue = @dtdue" + " Where BookingNo = @id";
                        dbcmd.Parameters.AddWithValue("dtdue",txtdatedue.Text);
                        dbcmd.Parameters.AddWithValue("id", Convert.ToInt32(cbbookingNo.Text));

                     

                        dbconn.Open();
                        int changed = dbcmd.ExecuteNonQuery();
                        if (changed == 1)
                            dbconn.Close();
                         btncancel_Click(null, null);
                    }

                    using (SQLiteCommand dbcmd = dbconn.CreateCommand())
                    {

                        dbcmd.CommandText = @"Update NewBookings Set DateOut = @dtout" + " Where BookingNo = @id";
                        dbcmd.Parameters.AddWithValue("dtout", txtdateout.Text);
                        dbcmd.Parameters.AddWithValue("id", Convert.ToInt32(cbbookingNo.Text));


                        dbconn.Open();
                        int changed = dbcmd.ExecuteNonQuery();
                        if (changed == 1)
                            dbconn.Close();
                          btncancel_Click(null, null);
                    }

                    using (SQLiteCommand dbcmd = dbconn.CreateCommand())
                    {
                        dbcmd.CommandText = @"Update NewBookings Set TotalPayment = @totp" + " Where BookingNo = @id";
                        dbcmd.Parameters.AddWithValue("totp", txttotalpayment.Text);
                        dbcmd.Parameters.AddWithValue("id", Convert.ToInt32(cbbookingNo.Text));

                    
                        dbconn.Open();
                        int changed = dbcmd.ExecuteNonQuery();
                        if (changed == 1)
                            MessageBox.Show("Record Update Complete.");
                        dbconn.Close();
                          btncancel_Click(null, null);

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
            cbdatedue.SelectedIndex = -1;
            cbdateout.SelectedIndex = -1;
            cbduration.SelectedIndex = -1;
            numericUpDown.Value = 0;
            cbcustomerNo.SelectedIndex = -1;
            cbfirstname.SelectedIndex = -1;
            cblastname.SelectedIndex = -1;
            cbtotalpayment.SelectedIndex = -1;
            cbstaffNo.SelectedIndex = -1;
            cbmanager.SelectedIndex = -1;
            cbroomNo.SelectedIndex = -1;
            cbroomtype.SelectedIndex = -1;
            cbroomNo.SelectedIndex = -1;

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                using (SQLiteConnection dbconn = new SQLiteConnection(conString))
                {
                    using (SQLiteCommand dbcmd = dbconn.CreateCommand())
                    {
                        dbcmd.CommandText = @"Delete From NewBookings Where BookingNo = @id";
                        dbcmd.Parameters.AddWithValue("id", Convert.ToInt32(cbbookingNo1.Text));
                        dbconn.Open();
                        int recordsChanged = dbcmd.ExecuteNonQuery();
                        MessageBox.Show(recordsChanged.ToString() + " Booking Record Deleted");
                        dbconn.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            //before closing form, use ADO.NET to update database with changes to DataTable
            using (SQLiteCommandBuilder cbroom = new SQLiteCommandBuilder(daroom))
            {
                daroom.Update(dtroom);
            }
            this.Close();
        }

        private void checkStatus()
        {
            //only when all fields have been filled, activte the submi, delete and cancel buttons
            if (cbbookingNo.SelectedIndex != -1
                &&cbbookingNo1.SelectedIndex != -1
                && cbdatedue.SelectedIndex != -1
                && cbdateout.SelectedIndex != -1
                && numericUpDown.Value > 0
                 && cbduration.SelectedIndex != -1
                && cbcustomerNo.SelectedIndex != -1
                 && cbfirstname.SelectedIndex != -1
                && cblastname.SelectedIndex != -1
                 && cbtotalpayment.SelectedIndex != -1
                && cbstaffNo.SelectedIndex != -1
                 && cbmanager.SelectedIndex != -1
                && cbroomNo.SelectedIndex != -1
                  && cbroomnumber.SelectedIndex != -1
                && cbroomtype.SelectedIndex != -1)
            {
                btnUpdate.Enabled = true;
                btndelete.Enabled = true;
                btncancel.Enabled = true;
            }
            else
            {
                btnUpdate.Enabled = false;
                btndelete.Enabled = false;
                btncancel.Enabled = false;
            }
        }

        private void cbbookingNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkStatus();

        }

        private void cbdatedue_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkStatus();
        }

        private void cbdateout_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkStatus();
        }

        private void cbduration_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkStatus();
        }

        private void cbbookingNo1_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkStatus();
        }

        private void cbcustomerNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkStatus();
        }

        private void cbfirstname_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkStatus();
        }

        private void cblastname_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkStatus();
        }

        private void cbtotalpayment_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkStatus();
        }

        private void cbstaffNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkStatus();
        }

        private void cbmanager_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkStatus();
        }

        private void cbroomNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkStatus();
        }

        private void cbroomnumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkStatus();
        }

        private void cbroomtype_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkStatus();
        }

        private void numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            checkStatus();
        }
    }

}


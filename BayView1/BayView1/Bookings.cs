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
    public partial class Bookings : Form
    {
        public Bookings(string inString)
        {
            InitializeComponent();
            conString = inString;
            //Start in the center of the screen.
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        string conString;


         //Define ADD.NET objects
        int rowAt;

        SQLiteConnection dbconn = new SQLiteConnection();

        SQLiteDataAdapter dastaff;
        SQLiteDataAdapter dacustomer;
        SQLiteDataAdapter daroom;
        SQLiteDataAdapter dabookings;
        SQLiteDataAdapter dacancel;


        DataTable dtstaff = new DataTable();
        DataTable dtcustomer = new DataTable();
        DataTable dtroom = new DataTable();
        DataTable dtbookings = new DataTable();
        DataTable dtcancel = new DataTable();




        string sql1 = @"Select StaffNo, FirstName From Staff";
        string sql2 = @"Select CustomerNo, FirstName, LastName From Customers";
        string sql3 = @"Select * From Rooms";
        string sql4 = @"Select * From NewBookings";
        string sql5 = @"Select * From Cancelation";

        DataTable dtSelect = new DataTable();



        private void Bookings_Load(object sender, EventArgs e)
        {
            try
            {
                //assign the connection string to the SQLiteConnection
                dbconn.ConnectionString = conString;

                //code to set up the DataAdapters
                dastaff = new SQLiteDataAdapter(sql1, dbconn);
                dacustomer = new SQLiteDataAdapter(sql2, dbconn);
                daroom = new SQLiteDataAdapter(sql3, dbconn);
                dabookings = new SQLiteDataAdapter(sql4, dbconn);
                dacancel = new SQLiteDataAdapter(sql5, dbconn);


                //Fill the DataTables
                dastaff.Fill(dtstaff);
                dacustomer.Fill(dtcustomer);
                daroom.Fill(dtroom);
                dabookings.Fill(dtbookings);

                //Bind datatable dtstaff to the StaffNo ComboBox
                cbstaffNo.DataSource = dtstaff;
                cbstaffNo.DisplayMember = "StaffNo";
                cbstaffNo.ValueMember = "StaffNo";
                cbstaffNo.SelectedIndex = -1;

                //Bind datatable dtstaff to the Staffname ComboBox
                cbstaffname.DataSource = dtstaff;
                cbstaffname.DisplayMember = "FirstName";
                cbstaffname.ValueMember = "StaffNo";
                cbstaffname.SelectedIndex = -1;


                //Bind datatable dtcustomer to the customerno ComboBox
                cbcustomerNo.DataSource = dtcustomer;
                cbcustomerNo.DisplayMember = "CustomerNo";
                cbcustomerNo.ValueMember = "CustomerNo";
                cbcustomerNo.SelectedIndex = -1;

                //Bind datatable dtcustomer to the firstname ComboBox
                cbfirstname.DataSource = dtcustomer;
                cbfirstname.DisplayMember = "FirstName";
                cbfirstname.ValueMember = "CustomerNo";
                cbfirstname.SelectedIndex = -1;

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


                //Bind datatable dtroom to the disability ComboBox
                cbdisability.DataSource = dtroom;
                cbdisability.DisplayMember = "Disabiltiy";
                cbdisability.ValueMember = "RoomNo";
                cbdisability.SelectedIndex = -1;



                //Bind datatable dtroom to the room availability ComboBox
                cbavailability.DataSource = dtroom;
                cbavailability.DisplayMember = "Room_Availabiltiy";
                cbavailability.ValueMember = "RoomNo";
                cbavailability.SelectedIndex = -1;


                //Bind datatable dtroom to the expected availability ComboBox
                cbavailabilitycheck.DataSource = dtroom;
                cbavailabilitycheck.DisplayMember = "Expected_Availability";
                cbavailabilitycheck.ValueMember = "RoomNo";
                cbavailabilitycheck.SelectedIndex = -1;


                //Bind datatable dtroom to the with breakfast ComboBox
                cbbreakfast.DataSource = dtroom;
                cbbreakfast.DisplayMember = "WithBreakfast";
                cbbreakfast.ValueMember = "RoomNo";
                cbbreakfast.SelectedIndex = -1;



                //Bind datatable dtroom to the total price ComboBox
                cbtotalprice.DataSource = dtroom;
                cbtotalprice.DisplayMember = "Total_Price";
                cbtotalprice.ValueMember = "RoomNo";
                cbtotalprice.SelectedIndex = -1;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //

            try
            {
                //create connections and set up SQL to pull data from db
                dbconn = new SQLiteConnection(conString);
                string sqlcommand = @"Select * From Rooms";
                //create DataAdapter and use to fill DataTable
                daroom = new SQLiteDataAdapter(sqlcommand, dbconn);
                daroom.Fill(dtroom);
                //display first row of DataTable information
                rowAt = 0;
                showrecord();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void showrecord()
        {
            //Display data in row "rowAT" of the DataTable
            DataRow row = dtroom.Rows[rowAt];

           
            lblroomnumber1.Text = "Room Number : " + row["RoomNumber"].ToString();
            lblroomtype1.Text = "Room Type : " + row["RoomType"].ToString();
            pictureBox1.Image = Image.FromFile(row["Display"].ToString());
        }


        private void btnNext_Click(object sender, EventArgs e)
        {
            //if not at the end of table advance to next row, or loop back to start
            if (rowAt < dtroom.Rows.Count - 1)
            {
                rowAt++;
            }
            else
            {
                rowAt = 0;
            }
            showrecord();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            //if not at the first row set to the previous row, or loop to the end of the DataTable
            if (rowAt > 0)
            {
                rowAt--;
            }
            else
            {
                rowAt = dtroom.Rows.Count - 1;
            }
            showrecord();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //insert a new booking record
            //set up a SQLiteCommand object to use with the connection
            using (SQLiteCommand dbcmd = dbconn.CreateCommand())
            {
                try
                {
                    dbcmd.CommandText =
                    @"Insert Into NewBookings (DateDue, DateOut, CustomerNo, StaffNo, RoomNo, Duration, TotalPayment)"
                  + @" Values ( @dtdue, @dtout, @cust, @staf, @room, @dur, @totp)";

                    dbcmd.Parameters.AddWithValue("dtdue", txtdatedue.Text);
                    dbcmd.Parameters.AddWithValue("dtout", txtdateout.Text);
                    dbcmd.Parameters.AddWithValue("cust", cbcustomerNo.SelectedValue);
                    dbcmd.Parameters.AddWithValue("staf", cbstaffNo.SelectedValue);
                    dbcmd.Parameters.AddWithValue("room", cbroomNo.SelectedValue);
                    dbcmd.Parameters.AddWithValue("dur", numericUpDown.Value);

                   

                    // calculate  booking cost:
                    //  first get the Total price of the selected room
                    DataRow[] foundRow = dtroom.Select("RoomNo = " + cbroomNo.SelectedValue.ToString());
                    float unitPrice = Convert.ToSingle(foundRow[0]["Total_Price"]);


                    float totPrice = unitPrice * Convert.ToSingle(numericUpDown.Value);
                    //  add this total cost to DB update instruction
                    dbcmd.Parameters.AddWithValue("totp", totPrice);

                    //update the database with new order details
                    dbconn.Open();
                    int changed = dbcmd.ExecuteNonQuery();
                    if (changed == 1)
                        MessageBox.Show("Order Was Placed Successfully");
                    dbconn.Close();
                    // btnCancel_Click(null, null);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void cbroomNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            { //display the image when on roomno combobox
                DataRow[] foundRow = dtroom.Select("RoomNo = " + cbroomNo.SelectedValue.ToString());
                string getimg = foundRow[0]["Display"].ToString();
                pictureBox1.Image = Image.FromFile(getimg);
                numericUpDown.Value = 0;
            }
            catch
            {
                pictureBox1.Image = null;
            }
            checkStatus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            cbstaffNo.SelectedIndex = -1;
            cbstaffname.SelectedIndex = -1;
            cbcustomerNo.SelectedIndex = -1;
            cbfirstname.SelectedIndex = -1;
            cblastname.SelectedIndex = -1;
            cbroomNo.SelectedIndex = -1;
            cbroomnumber.SelectedIndex = -1;
            cbroomtype.SelectedIndex = -1;
            cbdisability.SelectedIndex = -1;
            cbavailability.SelectedIndex = -1;
            cbavailabilitycheck.SelectedIndex = -1;
            cbbreakfast.SelectedIndex = -1;
            cbtotalprice.SelectedIndex = -1;


            //when canceling form, use ADO.NET to update database in the cancel form 
            using (SQLiteCommandBuilder cbcancel = new SQLiteCommandBuilder(dacancel))
            {
                dacancel.Update(dtcancel);
            }
            checkStatus();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkStatus()
        {
            //only when all fields have been filled, activte the submit button
            if (cbstaffNo.SelectedIndex != -1
                 && cbstaffname.SelectedIndex != -1
                 && cbcustomerNo.SelectedIndex != -1
                 && cbfirstname.SelectedIndex != -1
                 && cblastname.SelectedIndex != -1
                 && cbroomNo.SelectedIndex != -1
                 && cbroomnumber.SelectedIndex != -1
                 && cbroomtype.SelectedIndex != -1
                 && cbdisability.SelectedIndex != -1
                 && cbavailability.SelectedIndex != -1
                 && cbavailabilitycheck.SelectedIndex != -1
                 && cbbreakfast.SelectedIndex != -1
                 && numericUpDown.Value > 0
                 && cbtotalprice.SelectedIndex != -11)
            {
                btnSubmit.Enabled = true;
                btnCancel.Enabled = true;
            }
            else
            {
                btnSubmit.Enabled = false;
                btnCancel.Enabled = false;
            }
        }

        private void cbstaffNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkStatus();
        }

        private void cbstaffname_SelectedIndexChanged(object sender, EventArgs e)
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

        private void cbdisability_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkStatus();
        }

        private void cbavailability_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkStatus();
        }

        private void cbavailabilitycheck_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkStatus();
        }

        private void cbbreakfast_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkStatus();
        }

        private void cbtotalprice_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkStatus();
        }

        private void numericUpDown_ValueChanged(object sender, EventArgs e)
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
    }

}

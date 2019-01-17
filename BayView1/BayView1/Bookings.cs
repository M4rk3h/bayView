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
        public Bookings()
        {
            InitializeComponent();
            //Start in Center of screen.
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        //create a connection object
        SQLiteConnection conn = new SQLiteConnection();

        //used to hold the database file details
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
                //code to set up the DataAdapters
                dastaff = new SQLiteDataAdapter(sql1, dbconn);
                dacustomer = new SQLiteDataAdapter(sql2, dbconn);
                daroom = new SQLiteDataAdapter(sql3, dbconn);
                dabookings = new SQLiteDataAdapter(sql4, dbconn);


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
                dbconn = new SQLiteConnection(dbconn);
                string sqlcommand = @"Select * From Rooms";
                //create DataAdapter and use to fill DataTable
                daroom = new SQLiteDataAdapter(sqlcommand, dbconn);
                daroom.Fill(dtroom);
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

        private void btnTest_Click(object sender, EventArgs e)
        {
            try
            {
                conn.ConnectionString = conString;
                conn.Open();

                if (conn.State == System.Data.ConnectionState.Open)

                    MessageBox.Show("Yay");
            }
            catch (Exception)
            {
                if (conn.State == System.Data.ConnectionState.Open)
                    conn.Close();

                MessageBox.Show("Nay");
            }
        }
    }


}


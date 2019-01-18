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
    public partial class Customers : Form
    {
        public Customers()
        {
            InitializeComponent();
            //Start in the center of the screen.
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        //Declare Variables to use later!

        //Details of the database
        string dbDetails = dbConnection.dbsource;
        //Details for Datatable (display) & DataAdapter (Pull+Push)
        SQLiteConnection dbCon;
        SQLiteDataAdapter daCustomer;
        DataTable dtCustomer = new DataTable();

        //SQLite Command called myCmd
        SQLiteCommand myCmd;
        //Set the binding source globally
        BindingSource bS = new BindingSource();

        //Declare what row DataRow starts at
        int rowAt = 0;

        private void Customer2_Load(object sender, EventArgs e)
        {
            try
            {
                //Set details for dbCon
                dbCon = new SQLiteConnection(dbDetails);
                //Add required SQL
                //daCustomer = new SQLiteDataAdapter("Select * From Customers Where Active = 1", dbCon);
                daCustomer = new SQLiteDataAdapter("Select * From Customers ", dbCon);
                //Fill DataAdapter with data pulled from DataTable
                daCustomer.Fill(dtCustomer);
                //Set the Command Builder within the load.
                SQLiteCommandBuilder cB = new SQLiteCommandBuilder(daCustomer);

                bS.DataSource = dtCustomer;
                bindingNavigator1.BindingSource = bS;

                txtTitle.DataBindings.Add("Text", bS, "Title");
                txtFirstName.DataBindings.Add("Text", bS, "FirstName");
                txtLastName.DataBindings.Add("Text", bS, "LastName");
                txtPhone.DataBindings.Add("Text", bS, "PhoneNo");
                txtPostCode.DataBindings.Add("Text", bS, "PostCode");
                txtEmail.DataBindings.Add("Text", bS, "Email");
                txtActive.DataBindings.Add("Text", bS, "Active");
            }
            catch
            {
                MessageBox.Show("Error on customer 2 Load");
            }
        }

        public void enableTextFields()
        {
            txtTitle.Enabled = true;
            txtFirstName.Enabled = true;
            txtLastName.Enabled = true;
            txtPhone.Enabled = true;
            txtEmail.Enabled = true;
            txtPostCode.Enabled = true;
            txtActive.Enabled = true;
        }

        public void clearAllText()
        {
            txtTitle.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtPhone.Text = "";
            txtEmail.Text = "";
            txtPostCode.Text = "";
        }

        public void enableMain()
        {
            btnSearch.Enabled = true;
            cbFind.Enabled = true;
            btnEdit.Enabled = true;
            btnSubmit.Enabled = true;
            btnCancel.Enabled = true;
            btnDel.Enabled = true;
            bnAdd.Enabled = true;
        }

        public void disableAll()
        {
            txtTitle.Enabled = false;
            txtFirstName.Enabled = false;
            txtLastName.Enabled = false;
            txtPhone.Enabled = false;
            txtPostCode.Enabled = false;
            txtEmail.Enabled = false;
            btnDel.Enabled = false;

        }

        public void showRecord()
        {
            /*  Tried to copy something from my old work (Mark)
             *  Seems to work, hopefully doesn't clash with
             *  BindingSource & BindingNavigator
             */
            
            DataRow row = dtCustomer.Rows[rowAt];
            //Fill text fields with data from each row.
            txtTitle.Text = row[1].ToString();
            txtFirstName.Text = row[2].ToString();
            txtLastName.Text = row[3].ToString();
            txtEmail.Text = row[4].ToString();
            txtPhone.Text = row[5].ToString();
            txtPostCode.Text = row[6].ToString();
            txtActive.Text = row[7].ToString();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                using (SQLiteCommandBuilder cb = new SQLiteCommandBuilder(daCustomer))
                {
                    daCustomer.Update(dtCustomer);
                }

                MessageBox.Show("Record Updated.", "Update Records");
            }
            catch
            {
                MessageBox.Show("Error Updating Customer Records.");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            enableTextFields();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to quit?", "Exit",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question) == DialogResult.OK)
            {
                using (SQLiteCommandBuilder cb = new SQLiteCommandBuilder(daCustomer))
                {
                    daCustomer.Update(dtCustomer);
                }

                showRecord();

                dbCon.Close();
                this.Close();
            }
            else
            {
                MessageBox.Show("Back?");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                SQLiteDataAdapter daSearch;
                DataTable dtSearch = new DataTable();

                string sql = @"Select * From Customers Where Active = 1 AND LastName LIKE @lookfor Order By LastName ";
                daSearch = new SQLiteDataAdapter(sql, dbCon);
                daSearch.SelectCommand.Parameters.AddWithValue("@lookfor", "%" + cbFind.Text + "%");
                dtSearch.Clear();
                daSearch.Fill(dtSearch);

                //Bind the search results to the ComboBox
                cbFind.DataSource = dtSearch;
                //Show the LastName
                cbFind.DisplayMember = "LastName";

                //Any customers found?
                if (cbFind.Items.Count >= 0)
                {
                    //Yes, display the first record and enable edit
                    cbFind.SelectedIndex = 0;
                    btnEdit.Enabled = true;

                    //Declare int as Picked
                    int Picked = cbFind.SelectedIndex;

                    //Fill text fields with data from each row.
                    txtTitle.Text = dtSearch.Rows[Picked][1].ToString();
                    txtFirstName.Text = dtSearch.Rows[Picked][2].ToString();
                    txtLastName.Text = dtSearch.Rows[Picked][3].ToString();
                    txtEmail.Text = dtSearch.Rows[Picked][4].ToString();
                    txtPhone.Text = dtSearch.Rows[Picked][5].ToString();
                    txtPostCode.Text = dtSearch.Rows[Picked][6].ToString();
                    txtActive.Text = dtSearch.Rows[Picked][7].ToString();

                }
                else
                {
                    //No, reset UI 
                    cbFind.SelectedIndex = -1;
                    //Clear all Text
                    clearAllText();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error! " + ex.Message);
            }
        }

        private void lblTest_Click(object sender, EventArgs e)
        {
            try
            {
                //Convert the DBCon to a string called Details.
                dbCon.ConnectionString = dbDetails;
                //Create a Command called MyCmd
                myCmd = dbCon.CreateCommand();
                //Open the Database Connection
                dbCon.Open();
                //Change text at bottom to show testing
                toolDB.Text = "## Testing Connection ##";

                showRecord();

                timer1.Start();
            }
            catch
            {
                MessageBox.Show("Failed testing Database, Please start over.");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                //Enable all button after testing connection
                enableMain();
                //Stop the timer
                timer1.Stop();
                //Change image and text of the status bar.
                toolDB.Image = Properties.Resources.green;
                toolDB.Text = "## Testing Complete ##";
                //Disable the Test Connection Button
                btnTest.Enabled = false;
            }
            catch
            {
                MessageBox.Show("Error with Timer1 ");
            }
        }

        private void btnAddCust_Click(object sender, EventArgs e)
        {
            enableTextFields();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            disableAll();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow row = dtCustomer.Rows[rowAt];
                row["Active"] = "0";

                using (SQLiteCommandBuilder dbCustomer = new SQLiteCommandBuilder(daCustomer))
                {
                    daCustomer.Update(dtCustomer);
                }
                MessageBox.Show("One Recorded Deleted Successfully.");
            }
            catch
            {
                MessageBox.Show("Error with Delete Button");
            }
        }

        private void cbAct_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}

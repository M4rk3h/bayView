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
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();

        }

        //Details of the database
        string dbDetails = dbConnection.dbsource;
        
        //Connection to Database
        SQLiteConnection dbcon = new SQLiteConnection(dbConnection.dbsource);
        //Connection for Update??
        SQLiteConnection addNewCon = new SQLiteConnection(dbConnection.dbsource);
        
        //SQLite Command called myCmd
        SQLiteCommand myCmd;
        //My SQL DataAdapter
        SQLiteDataAdapter daCustomer;
        //My DataTable
        DataTable dtCustomer = new DataTable();
        
        //Declare what Row to start at
        int rowAt = 0;



        public void clearAllText()
        {
            txtTitle.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtAge.Text = "";
            cBoxDisability.Text = "";
            txtPhone.Text = "";
            txtEmail.Text = "";
            txtPostCode.Text = "";
            txtAdd1.Text = "";
            txtAdd2.Text = "";
            txtAdd3.Text = "";
        }

        public void enableMain()
        {            
            btnSearch.Enabled = true;
            cbFind.Enabled = true;
            btnAddCust.Enabled = true;
            btnEdit.Enabled = true;
            btnSubmit.Enabled = true;
        }

        public void enableTextFields()
        {
            txtTitle.Enabled = true;
            txtFirstName.Enabled = true;
            txtLastName.Enabled = true;
            txtAge.Enabled = true;
            cBoxDisability.Enabled = true;
            txtPhone.Enabled = true;
            txtEmail.Enabled = true;
            txtPostCode.Enabled = true;
            //Unsure if this is Needed?
            txtAdd1.Enabled = true;
            txtAdd2.Enabled = true;
            txtAdd3.Enabled = true;
        }

        

        private void showrecord()
        {
            DataRow row = dtCustomer.Rows[rowAt];
            //Display Title
            txtTitle.Text = row["Title"].ToString();
            //Display FirstName
            txtFirstName.Text = row["FirstName"].ToString();
            //Display LastName
            txtLastName.Text = row["LastName"].ToString();
            //Display Email
            txtEmail.Text = row["Email"].ToString();
            //Display PhoneNo
            txtPhone.Text = row["PhoneNo"].ToString();
            //Display PostCode
            txtPostCode.Text = row["PostCode"].ToString();
        }


        private void lblTest_Click(object sender, EventArgs e)
        {
            try
            {
                //Convert the DBCon to a string called Details.
                dbcon.ConnectionString = dbDetails;
                //Create a Command called MyCmd
                myCmd = dbcon.CreateCommand();
                //Open the Database Connection
                dbcon.Open();
                //Change text at bottom to show testing
                toolDB.Text = "## Testing Connection ##";
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
                dbcon = new SQLiteConnection(dbDetails);
                string sqlcommand = @"Select * From Customers";

                daCustomer = new SQLiteDataAdapter(sqlcommand, dbcon);
                daCustomer.Fill(dtCustomer);

                rowAt = 0;
                showrecord();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

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
                lblTest.Enabled = false;
                


            }
            catch
            {
                MessageBox.Show("Error with Timer1 ");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to quit?", "Exit",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question) == DialogResult.OK)
            {
                dbcon.Close();
                this.Close();
            }
            else
            {
                MessageBox.Show("Back?");
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (rowAt < dtCustomer.Rows.Count - 1)
            {
                rowAt++;
            }
            else
            {
                rowAt = 0;
            }
            showrecord();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (rowAt > 0)
            {
                rowAt--;
            }
            else
            {
                rowAt = dtCustomer.Rows.Count - 1;
            }
            showrecord();
        }

        private void btnAddCust_Click(object sender, EventArgs e)
        {
            try
            {
                clearAllText();
                enableTextFields();
            }
            catch
            {
                MessageBox.Show("Failed to Clear Text");
            }


        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow row = dtCustomer.Rows[rowAt];

                //DataRow newCust = dtCustomer.;
                row["Title"] = txtTitle.Text;
                row["FirstName"] = txtFirstName.Text;
                row["LastName"] = txtLastName.Text;
                row["Email"] = txtEmail.Text;
                row["PhoneNo"] = txtPhone.Text;
                row["PostCode"] = txtPostCode.Text;

                using (SQLiteCommandBuilder dbCustomer = new SQLiteCommandBuilder(daCustomer))

                {
                    //Update the DataAdapter for the Database.
                    daCustomer.Update(dtCustomer);
                }
                //Clear all fields
                clearAllText();
                //Close connection
                dbcon.Close();
                //Display some sort of Feedback.
                MessageBox.Show("Customer Edited Successfully!");
            }
            catch
            {
                MessageBox.Show("Failed to update Records.", "Error");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            enableTextFields();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {

                SQLiteDataAdapter daSearch;
                DataTable dtSearch = new DataTable();

                string sql = @"Select * From Customers Where LastName LIKE @lookfor Order By LastName";
                daSearch = new SQLiteDataAdapter(sql, dbcon);
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
    }
        
 }


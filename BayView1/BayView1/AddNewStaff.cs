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
using System.Security.Cryptography;

namespace BayView1
{
    public partial class AddNewStaff : Form
    {
        public AddNewStaff()
        {
            InitializeComponent();
            //Start in the center of the screen.
            this.StartPosition = FormStartPosition.CenterScreen;
            
        }

        string dbDetails = dbConnection.dbsource;
        //Details for Datatable (display) & DataAdapter (Pull+Push)
        SQLiteConnection dbCon;
        SQLiteDataAdapter daStaff;
        DataTable dtStaff = new DataTable();

        //SQLite Command called myCmd
        //SQLiteCommand myCmd;
        //Set the binding source globally
        BindingSource bS = new BindingSource();

       
            
        //try to read the text in textbox/checkbox and use sql script to add
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (tbTitle.Text == "" || tbFN.Text == "" || tbLN.Text == "" || tbPhoneNo.Text == "" || tbEmail.Text == "" || tbUsername.Text == "" || tbCPW.Text == "" || tbPW.Text == "")
            { 
                lblError.Text = "Please fill the blanks and submit again!";        
            }
            else if(this.tbPW.Text != this.tbCPW.Text)
            {
                lblError.Text = "Passwords don't match! Please check the password and try again!";
            }
            else
            {
                string Title = this.tbTitle.Text;
                string FirstName = this.tbFN.Text;
                string LastName = this.tbLN.Text;
            
                string Email = this.tbEmail.Text;
                string PhoneNumber = this.tbPhoneNo.Text;
                string Username = this.tbUsername.Text;
                
                //string Password = this.tbPW.Text;
                //create new instance of sha1
                SHA1 sha1 = SHA1.Create();
                //convert string to an array of bytes
                byte[] hashData = sha1.ComputeHash(Encoding.Default.GetBytes(tbPW.Text));
                //use a StringBuilder to save hash value
                StringBuilder hashValue = new StringBuilder();
                // for each byte, add to the StringBuilder
                for (int i = 0; i < hashData.Length; i++)
                    hashValue.Append(hashData[i].ToString());
                // return sha1 hash value
                string Password = hashValue.ToString();

                try
                {
                    using (SQLiteConnection cb = new SQLiteConnection())
                    {
                        cb.ConnectionString = dbConnection.dbsource;

                        string sqlAdd = "INSERT INTO Staff([Title],[FirstName],[LastName],[Password],[Email],[PhoneNo],[Manager],[Username],[Active]) VALUES('" + Title + "','" + FirstName + "','" + LastName + "','" + Password + "','" + Email + "','" + PhoneNumber + "','" + CBManager.CheckState + "','" + Username + "','" + CBActive.CheckState + "')";
                        SQLiteCommand cmdAdd = new SQLiteCommand(sqlAdd, cb);

                        using (SQLiteCommand myCmd = new SQLiteCommand(sqlAdd, cb))
                        {
                            cb.Open();
                            myCmd.ExecuteNonQuery();
                            cb.Close();
                        } 
                    }

                    MessageBox.Show("Staff Added.", "Add Staff");
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("Error Adding Staff Records.");
                }
                    
            }

        }

        private void AddNewStaff_Load(object sender, EventArgs e)
        {
            try
            {
                //Set details for dbCon
                dbCon = new SQLiteConnection(dbDetails);
                //Add required SQL
                //daCustomer = new SQLiteDataAdapter("Select * From Customers Where Active = 1", dbCon);
                daStaff = new SQLiteDataAdapter("Select * From Customers ", dbCon);
                //Fill DataAdapter with data pulled from DataTable
                daStaff.Fill(dtStaff);
                //Set the Command Builder within the load.
                SQLiteCommandBuilder cB = new SQLiteCommandBuilder(daStaff);

                //bS.DataSource = dtStaff;
                //bindingNavigator1.BindingSource = bS;

                //txtTitle.DataBindings.Add("Text", bS, "Title");
                //txtFirstName.DataBindings.Add("Text", bS, "FirstName");
                //txtLastName.DataBindings.Add("Text", bS, "LastName");
                //txtPhone.DataBindings.Add("Text", bS, "PhoneNo");
                //txtPostCode.DataBindings.Add("Text", bS, "PostCode");
                //txtEmail.DataBindings.Add("Text", bS, "Email");
                //txtActive.DataBindings.Add("Text", bS, "Active");
            }
            catch
            {
                MessageBox.Show("Error on customer 2 Load");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            dbCon.Close();
            this.Close();
        }
    }
}

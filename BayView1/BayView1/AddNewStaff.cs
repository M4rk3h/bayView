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
        SQLiteCommand myCmd;
        //Set the binding source globally
        BindingSource bS = new BindingSource();

       
            
        //try to read the text in textbox/checkbox and use sql script to add
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (this.tbPW == this.tbCPW)
            {
                string Title = this.tbTitle.Text;
                string FirstName = this.tbFN.Text;
                string LastName = this.tbLN.Text;
            
                string Email = this.tbPhoneNo.Text;
                string PhoneNumber = this.tbPhoneNo.Text;
                string Username = this.tbUsername.Text;
                //string Password = this.tbPW.Text;
           

                if(this.CBManager.Checked)
                {
                    bool Manager = true;
                }
                else
                {
                    bool Manager = false;
                }

                if(this.CBActive.Checked)
                {
                    bool Active = true;
                }
                else
                {
                    bool Active = false;
                }

                try
                {
                    using (SQLiteCommandBuilder cb = new SQLiteCommandBuilder(daStaff))
                    {
                        daStaff.Update(dtStaff);
                        string sql = string.Format("insert into Staff values('"+"','"+Title+"','"+FirstName + "','" + LastName + "','" + Email + "','" + PhoneNumber + "','" + "1" + "','" + Username + "','" + "1" + "')" );
                    }

                    MessageBox.Show("Record Updated.", "Update Records");
                }
                catch
                {
                    MessageBox.Show("Error Updating Staff Records.");
                }
                    string Password = this.tbPW.Text;
                    lblError.Text = "Password matches!";
            }

            else
            {
                lblError.Text = "Passwords don't match!";
            }

        }

        private void AddNewStaff_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //dbCon.Close();
            this.Close();
        }

        private void CBManager_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CBActive_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

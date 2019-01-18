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
    public partial class ChangePW : Form
    {
        public ChangePW()
        {
            InitializeComponent();
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

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (tbPW.Text == "" || tbCPW.Text == "" )
            {
                lblError.Text = "Please enter new password!";
            }
            else if (this.tbPW.Text != this.tbCPW.Text)
            {
                lblError.Text = "Passwords don't match!";
            }
            else
            {
                
                
                try
                {
                    using (SQLiteConnection dbcon = new SQLiteConnection())
                    {
                        dbcon.ConnectionString = dbConnection.dbsource;
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

                        string sqlCP = "UPDATE Staff SET Password = "+Password+" WHERE Username = '"+GlobalData.GDUserName+"'";
                        //MessageBox.Show(sqlCP);
                        SQLiteCommand cmdCP = new SQLiteCommand(sqlCP, dbCon);

                        using (SQLiteCommand myCmd = new SQLiteCommand(sqlCP, dbCon))
                        {
                            dbCon.Open();
                            myCmd.ExecuteNonQuery();
                            dbCon.Close();
                        }
                    }

                    MessageBox.Show("Password Changed.", "Change Password");
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("Error Changing Password.");
                }

            }
        }

        private void ChangePW_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }


}

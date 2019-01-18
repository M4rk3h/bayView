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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Start in the center of the screen.
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        SQLiteConnection dbcon = 
            new SQLiteConnection(dbConnection.dbsource);

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                using (SQLiteConnection dbcon = new SQLiteConnection())
                {
                    //Use the dbConnection as the data source
                    dbcon.ConnectionString = dbConnection.dbsource;
                    //using SHA1 hash password
                    //create new instance of sha1
                    SHA1 sha1 = SHA1.Create();
                    //convert string to an array of bytes
                    byte[] hashData = sha1.ComputeHash(Encoding.Default.GetBytes(textBoxPassword.Text));
                    //use a StringBuilder to save hash value
                    StringBuilder hashValue = new StringBuilder();
                    // for each byte, add to the StringBuilder
                    for (int i = 0; i < hashData.Length; i++)
                        hashValue.Append(hashData[i].ToString());
                    // return sha1 hash value
                    string hashresult = hashValue.ToString();
                    //MessageBox.Show(hashresult); //Check the result
                    //SQL as a String
                    string sql = "SELECT Password,StaffNo,Manager FROM Staff WHERE Username=@name";
                    using (SQLiteCommand cmd = new SQLiteCommand(sql,dbcon))
                    {
                        cmd.Parameters.AddWithValue("name",textBoxUsername.Text);
                        dbcon.Open();
                        using(SQLiteDataReader dr = cmd.ExecuteReader())
                        {
                            if (!dr.HasRows)
                                throw new Exception();
                            dr.Read();
                            if (hashresult != dr[0].ToString())
                                throw new Exception();
                            //stfid = Convert.ToInt32(dr[1]);

                            int IDSM;  //use IDSM to check if the one login is a staff or a manager
                            IDSM = Convert.ToInt32(dr[2]); //convert "manager" column to int
                            GlobalData.GDUserName = textBoxUsername.Text;

                            dbcon.Close();
                            //Close connection to Database
                            tsText.Image = Properties.Resources.green;
                            //Display a Green Tick on the Syayus Bar
                            tsText.Text = "Welcome, " + textBoxUsername.Text + " ! Have a nice day!";
                            //Change the text on the status bus with username entered.
                            MessageBox.Show("Login Successful. " + "Welcome, " + textBoxUsername.Text + "! Have a nice day!", "Login");
                            //Display a message box with username entered.
                            

                            StaffView staffView = new StaffView();
                            ManagerView managerView = new ManagerView();
                            //using IDSM to decide which interface to show and hide login interface
                            if (IDSM == 0)
                            {
                                this.Hide();
                                staffView.Show();
                            }
                            else if (IDSM ==1)
                            {
                                this.Hide();
                                managerView.Show();
                            }
                        }
                    }
                }
            }

            //finally { };
            catch (Exception)
            {
                timer1.Start();
            }
        }

        //whether the password could be seen
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
                textBoxPassword.PasswordChar = '*';
            else
                textBoxPassword.PasswordChar = '\0';
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            //Change text of the status bar
            
            tsText.Image = Properties.Resources.red;
            tsText.Text = "Login Failed, Please Try Again.";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //Create a pop up, asking if they want to quit.
            if (MessageBox.Show("Are you sure you want to quit?", "Exit",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Back?");
            }
        }
    }
}

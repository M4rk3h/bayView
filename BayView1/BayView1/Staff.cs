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
    public partial class Staff : Form
    {
        public Staff()
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

        //Set the binding source globally
        BindingSource bS = new BindingSource();


        private void Staff_Load(object sender, EventArgs e)
        {
            try
            {
                //Set details for dbCon
                dbCon = new SQLiteConnection(dbDetails);
                //Add required SQL
                //daCustomer = new SQLiteDataAdapter("Select * From Customers Where Active = 1", dbCon);
//<<<<<<< HEAD
                daStaff = new SQLiteDataAdapter("Select StaffNo,FirstName,LastName,Email,PhoneNo,Username,Manager,Active From Staff ", dbCon);
//=======
                //daStaff = new SQLiteDataAdapter("Select * From Staff ", dbCon);
//>>>>>>> 0db8301301fafc25daee307595b4555fb6661ff2
                //Fill DataAdapter with data pulled from DataTable
                daStaff.Fill(dtStaff);
                //Set the Command Builder within the load.
                SQLiteCommandBuilder cB = new SQLiteCommandBuilder(daStaff);

                bS.DataSource = dtStaff;
                //dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);

                dataGridView1.DataSource = dtStaff;
            }
            catch
            {
                MessageBox.Show("Error on Staff 2 Load");
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                using (SQLiteCommandBuilder cb = new SQLiteCommandBuilder(daStaff))
                {
                    daStaff.Update(dtStaff);
                }

                MessageBox.Show("Record Updated.", "Update Records");
            }
            catch
            {
                MessageBox.Show("Error Updating Staff Records.");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to quit?", "Exit",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question) == DialogResult.OK)
            {
                dbCon.Close();
                this.Close();
            }
            else
            {
                MessageBox.Show("Back?");
            }
        }

        private void btnNewStaff_Click(object sender, EventArgs e)
        {
            AddNewStaff frmaddNewStaff = new AddNewStaff();
            frmaddNewStaff.ShowDialog();
        }
    }
}

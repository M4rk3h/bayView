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


        private void Staff_Load(object sender, EventArgs e)
        {
            try
            {
                //Set details for dbCon
                dbCon = new SQLiteConnection(dbDetails);
                //Add required SQL
                //daCustomer = new SQLiteDataAdapter("Select * From Customers Where Active = 1", dbCon);
                daStaff = new SQLiteDataAdapter("Select StaffNo,FirstName,LastName,Email,PhoneNo,Username,Manager From Staff ", dbCon);
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
    }
}

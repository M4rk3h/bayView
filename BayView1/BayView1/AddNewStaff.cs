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
    public partial class AddNewStaff : Form
    {
        public AddNewStaff()
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

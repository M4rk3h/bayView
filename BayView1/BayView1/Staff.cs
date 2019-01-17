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
        SQLiteDataAdapter daCustomer;
        DataTable dtCustomer = new DataTable();

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
                daCustomer = new SQLiteDataAdapter("Select * From Customers ", dbCon);
                //Fill DataAdapter with data pulled from DataTable
                daCustomer.Fill(dtCustomer);
                //Set the Command Builder within the load.
                SQLiteCommandBuilder cB = new SQLiteCommandBuilder(daCustomer);

                bS.DataSource = dtCustomer;
                dataGridView1.AutoResizeColumns(
                DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
            }
            catch
            {
                MessageBox.Show("Error on customer 2 Load");
            }
        }
    }
}

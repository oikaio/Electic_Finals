using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace New_POS_Application
{
    public partial class Finals_Activity7: Form
    {
        private payrol_dbconnection payrol_db_connect;
        public Finals_Activity7()
        {
            InitializeComponent();
            payrol_db_connect = new payrol_dbconnection();
            payrol_db_connect.payrol_connString();
        }

        private void Finals_Activity7cs_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            LoadPayrollData();
        }
        private void LoadPayrollData()
        {
            try
            {
                payrol_db_connect.payrol_sql = "SELECT emp_id, emp_fname, emp_surname, position, emp_department FROM pos_empRegTbl";
                payrol_db_connect.payrol_cmd();
                payrol_db_connect.payrol_sqladapterSelect();
                payrol_db_connect.payrol_sqldatasetSELECT();

                dataGridViewPayroll.DataSource = payrol_db_connect.payrol_sql_dataset.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load payroll data: " + ex.Message);
            }
        }

        private void Searchbttn_Click(object sender, EventArgs e)
        {
            string searchValue = txtSearch.Text.Trim(); // <-- use TextBox, not Button

            if (string.IsNullOrEmpty(searchValue))
            {
                MessageBox.Show("Please enter Employee ID to search.");
                return;
            }

            try
            {
                payrol_db_connect.payrol_sql = $"SELECT emp_id, emp_fname, emp_surname, position, emp_department  FROM pos_empRegTbl WHERE emp_id = '{searchValue}'";
                payrol_db_connect.payrol_cmd();
                payrol_db_connect.payrol_sqladapterSelect();
                payrol_db_connect.payrol_sqldatasetSELECT();

                if (payrol_db_connect.payrol_sql_dataset.Tables[0].Rows.Count > 0)
                {
                    dataGridViewPayroll.DataSource = payrol_db_connect.payrol_sql_dataset.Tables[0];
                }
                else
                {
                    MessageBox.Show("No matching record found.");
                    LoadPayrollData(); // reload all data
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Search failed: " + ex.Message);
            }
        }
        

        private void Backbttn_Click(object sender, EventArgs e)
        {
            LoadPayrollData();
            txtSearch.Clear();
            txtSearch.Focus();
        }
    }
    
}

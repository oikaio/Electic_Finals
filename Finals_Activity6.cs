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
    public partial class Finals_Activity6: Form

    {
        private payrol_dbconnection payrol_db_connect;
        public Finals_Activity6()
        {
            InitializeComponent();
            payrol_db_connect = new payrol_dbconnection(); // <-- assign to the field, no type declaration here
            payrol_db_connect.payrol_connString();
        }

        private void Finals_Activity6_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            payrol_db_connect.payrol_sql = "SELECT * FROM pos_empRegTbl";
            payrol_select();

        }
        private void payrol_select()
        {
            payrol_db_connect.payrol_cmd();
            payrol_db_connect.payrol_sqladapterSelect();
            payrol_db_connect.payrol_sqldatasetSELECT();
            dataGridView1.DataSource = payrol_db_connect.payrol_sql_dataset.Tables[0];
        }
        private void cleartextboxes()
        {
            optionCombo.Text = "";
            optionInputTxtbox.Clear();
            optionCombo.Focus();
        }
        private void cleartextboxes1()
        {
            optionInputTxtbox.Clear();
            optionInputTxtbox.Focus();
        }
        private void employee_reports_Load(object sender, EventArgs e)
        {
            payrol_db_connect.payrol_sql = "SELECT * FROM pos_empRegTbl";
            payrol_select();
        }

        private void Searchbttn_Click(object sender, EventArgs e)
        {
            if (optionCombo.Text == "employee_number")
            {
                payrol_db_connect.payrol_sql = "SELECT * FROM pos_empRegTbl WHERE emp_id = '" + optionInputTxtbox.Text + "'";
                payrol_select();
                cleartextboxes1();
            }
            else if (optionCombo.Text == "surname")
            {
                payrol_db_connect.payrol_sql = "SELECT * FROM pos_empRegTbl WHERE emp_surname = '" + optionInputTxtbox.Text + "'";
                payrol_select();
                cleartextboxes1();
            }
            else if (optionCombo.Text == "firstname")
            {
                payrol_db_connect.payrol_sql = "SELECT * FROM pos_empRegTbl WHERE emp_fname = '" + optionInputTxtbox.Text + "'";
                payrol_select();
                cleartextboxes1();
            }
            else if (optionCombo.Text == "department")
            {
                payrol_db_connect.payrol_sql = "SELECT * FROM pos_empRegTbl WHERE emp_department = '" + optionInputTxtbox.Text + "'";
                payrol_select();
                cleartextboxes1();
            }
            else if (optionCombo.Text == "designation")
            {
                payrol_db_connect.payrol_sql = "SELECT * FROM pos_empRegTbl WHERE position = '" + optionInputTxtbox.Text + "'";
                payrol_select();
                cleartextboxes1();
            }
            else if (optionCombo.Text == "zipcode")
            {
                payrol_db_connect.payrol_sql = "SELECT * FROM pos_empRegTbl WHERE add_zipcode = '" + optionInputTxtbox.Text + "'";
                payrol_select();
                cleartextboxes1();
            }
            else if (optionCombo.Text == "province")
            {
                payrol_db_connect.payrol_sql = "SELECT * FROM pos_empRegTbl WHERE add_state_province = '" + optionInputTxtbox.Text + "'";
                payrol_select();
                cleartextboxes1();
            }
            else if (optionCombo.Text == "city")
            {
                payrol_db_connect.payrol_sql = "SELECT * FROM pos_empRegTbl WHERE add_city = '" + optionInputTxtbox.Text + "'";
                payrol_select();
                cleartextboxes1();
            }
            else
            {
                MessageBox.Show("No Available Record Found!");
            }
        

        }

        private void Backbttn_Click(object sender, EventArgs e)
        {
            try
            {
                payrol_db_connect.payrol_sql = "SELECT * FROM pos_empRegTbl";
                payrol_select();
                cleartextboxes();
            }
            catch (Exception)
            {
                MessageBox.Show("Error occurs in this area. Please contact your  administrator!"); 
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Finals_Activity3
{
    public partial class Finals_Activity9 : Form
    {
        useraccount_db_connection useraccount_db_connect = new useraccount_db_connection();

        public Finals_Activity9()
        {
            useraccount_db_connect.useraccount_connString();
            InitializeComponent();
        }
        private void cleartextboxes()
        {
            emp_idTxtbox.Clear();
            userIDTxtbox.Clear();
            firstnameTxtbox.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                firstnameTxtbox.Enabled = false;
                middlenameTxtbox.Enabled = false;
                surnameTxtbox.Enabled = false;
                designationTxtbox.Enabled = false;
                picpathTxtbox.Enabled = false;
                picpathTxtbox.Hide();
                useraccount_db_connect.Useraccount_sql = "SELECT pos_empRegTbl.emp_id, emp_fname, emp_mname, emp_surname, position, user_id, username, password, user_status, account_type FROM pos_empRegTbl INNER JOIN useraccountTbl ON pos_RegTbl.emp_id = useraccountTbl.emp_id";
                useraccount_db_connect.useraccount_cmd();
                useraccount_db_connect.useraccount_sqladapterSelect();
                useraccount_db_connect.useraccount_sqldatasetSELECT();
                dataGridView1.DataSource = useraccount_db_connect.useraccount_sql_dataset.Tables[0];
            }
            catch
            {
                MessageBox.Show("There is an error in this area. Please contact your administrator!");
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchbutton_Click(object sender, EventArgs e)
        {
            try
            {
                useraccount_db_connect.useraccount_sql = "SELECT emp_id, emp_fname, emp_mname, emp_surname, position, picpath FROM pos_empRegTbl WHERE emp_id = '" + emp_idTxtbox.Text + "'";
                useraccount_db_connect.useraccount_cmd();
                useraccount_db_connect.useraccount_sqladapterSelect();
                useraccount_db_connect.useraccount_sqldatasetSELECT();
                firstnameTxtbox.Text = useraccount_db_connect.useraccount_sql_dataset.Tables[0].Rows[0][1].ToString();
                middlenameTxtbox.Text = useraccount_db_connect.useraccount_sql_dataset.Tables[0].Rows[0][2].ToString();
                surnameTxtbox.Text = useraccount_db_connect.useraccount_sql_dataset.Tables[0].Rows[0][3].ToString();
                designationTxtbox.Text = useraccount_db_connect.useraccount_sql_dataset.Tables[0].Rows[0][4].ToString();
                picpathTxtbox.Text = useraccount_db_connect.useraccount_sql_dataset.Tables[0].Rows[0][5].ToString();
                pictureBox1.Image = Image.FromFile(picpathTxtbox.Text);
            }
            catch
            {
                MessageBox.Show("There is an error in this area. Please contact your administrator!");
            }
        }

        private void searchforupdatebutton_Click(object sender, EventArgs e)
        {
            try
            {
                useraccount_db_connect.useraccount_sql = "SELECT pos_empRegTbl.emp_id, emp_fname, emp_mname, emp_surname, position, picpath, user_id, username, password, user_status, account_type FROM pos_empRegTbl INNER JOIN useraccountTbl ON pos_empRegTbl.emp_id = useraccountTbl.emp_id WHERE user_id = '" + userIDTxtbox.Text + "'";
                useraccount_db_connect.useraccount_cmd();
                useraccount_db_connect.useraccount_sqladapterSelect();
                useraccount_db_connect.useraccount_sqldatasetSELECT();
                dataGridView1.DataSource = useraccount_db_connect.useraccount_sql_dataset.Tables[0];
                firstnameTxtbox.Text = useraccount_db_connect.useraccount_sql_dataset.Tables[0].Rows[0][1].ToString();
                middlenameTxtbox.Text = useraccount_db_connect.useraccount_sql_dataset.Tables[0].Rows[0][2].ToString();
                surnameTxtbox.Text = useraccount_db_connect.useraccount_sql_dataset.Tables[0].Rows[0][3].ToString();
                designationTxtbox.Text = useraccount_db_connect.useraccount_sql_dataset.Tables[0].Rows[0][4].ToString();
                picpathTxtbox.Text = useraccount_db_connect.useraccount_sql_dataset.Tables[0].Rows[0][5].ToString();
                pictureBox1.Image = Image.FromFile(picpathTxtbox.Text);
                usernameTxtbox.Text = useraccount_db_connect.useraccount_sql_dataset.Tables[0].Rows[0][7].ToString();
                passwordTxtbox.Text = useraccount_db_connect.useraccount_sql_dataset.Tables[0].Rows[0][8].ToString();
                account_statusComboBox.Text = useraccount_db_connect.useraccount_sql_dataset.Tables[0].Rows[0][9].ToString();
                accountTypeComboBox.Text = useraccount_db_connect.useraccount_sql_dataset.Tables[0].Rows[0][10].ToString();
            }
            catch
            {
                MessageBox.Show("There is an error in this area. Please contact your administrator!");
            }
        }

        private void updatebutton_Click(object sender, EventArgs e)
        {
            try
            {
                useraccount_db_connect.useraccount_sql = "UPDATE useraccountTbl SET account_type = '" + accountTypeComboBox.Text + "', username = '" + usernameTxtbox.Text + "', password = '" + passwordTxtbox.Text + "', confirm_password = '" + confirmPasswordTxtbox.Text + "', user_status = '" + account_statusComboBox.Text + "' WHERE user_id = '" + userIDTxtbox.Text + "'";
                useraccount_db_connect.useraccount_cmd();
                useraccount_db_connect.useraccount_sqladapterDelete();
                useraccount_db_connect.useraccount_sql = "SELECT pos_empregTbl.emp_id, emp_fname, emp_mname, emp_surname, position, user_id, username, password, user_status, account_type, FROM pos_empRegTbl INNER JOIN useraccountTbl ON pos_empRegTbl.emp_id = useraccountTbl.emp_id";
                useraccount_db_connect.useraccount_cmd();
                useraccount_db_connect.useraccount_sqladapterSelect();
                useraccount_db_connect.useraccount_sqldatasetSELECT();
                dataGridView1.DataSource = useraccount_db_connect.useraccount_sql_daatset.Tables[0];

            }
            catch
            {
                MessageBox.Show("There is an error in this area. Please contact your administrator!");
            }
        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            try
            {
                useraccount_db_connect.useraccount_sql = "DELETE FROM useraccountTbl WHERE user_id = '" + userIDTxtbox.Text + "'";
                useraccount_db_connect.useraccount_cmd();
                useraccount_db_connect.useraccount_sqladapterDelete();
                useraccount_db_connect.useraccount_sql = "SELECT pos_empRegTbll.emp_id, emp_fname, emp_mname, emp_surname, position, picpath, user_id, username, password, user_status, account_type FROM pos_empRegTbl INNER JOIN  useraccountTbl ON pos_empRegTbl.emp_id = useraccountTbl.emp_id";
                useraccount_db_connect.useraccount_cmd();
                useraccount_db_connect.useraccount_sqladapterSelect();
                useraccount_db_connect.useraccount_sqldatasetSELECT();
                dataGridView1.DataSource = useraccount_db_connect.useraccount_sql_dataset.Tables[0];
            }
            catch
            {
                MessageBox.Show("There is an error in this area. Please contact your administrator!");
            }
        }

        private void submitbutton_Click(object sender, EventArgs e)
        {
            try
            {
                useraccount_db_connect.useraccount_sql = "INSERT INTO useraccountTbl (user_id, account_type, username, password, confirm_password, user_status, emp_id) VALUES ('" + userIDTxtbox.Text + "', '" + accountTypeComboBox.Text + "', '" + usernameTxtbox.Text + "', '" + passwordTxtbox.Text + "', '" + confirmPasswordTxtbox.Text + "', '" + account_statusComboBox.Text + "', '" + emp_idTxtbox.Text + "')";
                useraccount_db_connect.useraccount_cmd();
                useraccount_db_connect.useraccount_sqladapterInsert();
                useraccount_db_connect.useraccount_sql = "SELECT pos_empRegTbl.emp_id, emp_fname, emp_mname, emp_surname, position, picpath, user_id, username, password, user_status, account_type FROM pos_empRegTbl INNER JOIN useraccountTbl ON pos_empRegTbl.emp_id = useraccountTbl.emp_id";
                useraccount_db_connect.useraccount_cmd();
                useraccount_db_connect.useraccount_sqladapterSelect();
                useraccount_db_connect.useraccount_sqldatasetSELECT();
                dataGridView1.DataSource = useraccount_db_connect.useraccount_sql_dataset.Tables[0];
            }
            catch
            {
                MessageBox.Show("There is an error in this area. Please contact your administrator!");
            }
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cancelbutton_Click(object sender, EventArgs e)
        {
            emp_idTxtbox.Clear();
            userIDTxtbox.Clear();
            firstnameTxtbox.Clear();
            middlenameTxtbox.Clear();
            surnameTxtbox.Clear();
            designationTxtbox.Clear();
            usernameTxtbox.Clear();
            passwordTxtbox.Clear();
            confirmPasswordTxtbox.Clear();
            account_statusComboBox.Items.Clear();
            accountTypeComboBox.Items.Clear();
        }
    }
}

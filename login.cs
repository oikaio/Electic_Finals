using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Net.Mime.MediaTypeNames;

namespace New_POS_Application
{
    public partial class login: Form
    {
        String connectionString = null;
        SqlConnection connection;
        SqlCommand command;
        DataSet dset;
        SqlDataAdapter adaptersql;
        string sql = null;

        public login()
        {

            InitializeComponent();
            connectionString = "Data Source = LAPTOP-FODOSL9R\\SQLEXPRESS02; Initial Catalog = LogForm; Trusted_Connection = True";
            connection = new SqlConnection(connectionString);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userId = textBox1.Text.Trim();
            string userPassword = textBox2.Text.Trim();

            if (string.IsNullOrEmpty(userId) || string.IsNullOrEmpty(userPassword))
            {
                MessageBox.Show("Please enter both User ID and Password.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                connection.Open();

                string sql = "SELECT COUNT(*) FROM UserTab WHERE UserId = @UserId AND UserPassword = @UserPassword";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@UserId", userId);
                command.Parameters.AddWithValue("@UserPassword", userPassword);

                int count = Convert.ToInt32(command.ExecuteScalar());

                if (count == 1)
                {
                    MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    menustrip menu = new menustrip();
                    menu.Show();
                    
                }
                else
                {
                    MessageBox.Show("Incorrect User ID or Password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void login_Load(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
            connection.Open();

            sql = "SELECT * FROM UserTab";
            command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.Text;

            adaptersql = new SqlDataAdapter(command);
            dset = new DataSet();
            adaptersql.Fill(dset, "UserTab");



            connection.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }
    }
}

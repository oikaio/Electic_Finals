using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms.DataVisualization.Charting;
//using static System.Net.Mime.MediaTypeNames;

namespace New_POS_Application
{
    public partial class Sampledb: Form
    {
        String picpath;
        String connectionString = null;
        SqlConnection connection;
        SqlCommand command;
        DataSet dset;
        SqlDataAdapter adaptersql;
        string sql = null;
        OpenFileDialog openFileDialog1 = new OpenFileDialog();
        pos_dbconnection posdb_connect = new pos_dbconnection();
        Price_Item_Value price_item_value = new Price_Item_Value();
        Variables variables = new Variables();


        public Sampledb()
        {
            InitializeComponent();
            connectionString = "Data Source = LAPTOP-FODOSL9R\\SQLEXPRESS02; Initial Catalog = SampleDatabseDb; Trusted_Connection = True";

            connection = new SqlConnection(connectionString);
        }

        private void Sampledb_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            
            
                connection.Open();

                sql = "SELECT * FROM studentlbl";
                command = new SqlCommand(sql, connection);
                command.CommandType = CommandType.Text;

                adaptersql = new SqlDataAdapter(command);
                dset = new DataSet();
                adaptersql.Fill(dset, "studentlbl");

                griddisplay.DataSource = dset.Tables["studentlbl"];
            
           
                connection.Close();
            
        }

        private void Savebttn_Click(object sender, EventArgs e)
        {
            connection.Open();
            sql = "INSERT INTO studentlbl (student_id, student_name, department, picpath) VALUES ('" + studNumTxtbox.Text + "', '" + studNameTxtBox.Text + "', '" + departmentTxtBox.Text + "', '" + picpathTxtBox.Text + "') ";
            command = new SqlCommand(sql,connection);
            command.CommandType = CommandType.Text;
            adaptersql = new SqlDataAdapter();
            adaptersql.InsertCommand = command;
            command.ExecuteNonQuery();

            sql = "SELECT * FROM studentlbl ";
            command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.Text;

            adaptersql = new SqlDataAdapter();
            adaptersql.SelectCommand = command;
            command.ExecuteNonQuery();

            dset = new DataSet();
            adaptersql.Fill(dset, "studentlbl");

            griddisplay.DataSource = dset.Tables[0];

            pictureBox1.Image = Image.FromFile("C:\\Users\\Kaiser\\Downloads\\useeerr.png");
            departmentTxtBox.Clear();
            picpathTxtBox.Clear();

            connection.Close();
        }

        private void Searchbttn_Click(object sender, EventArgs e)
        {
            connection.Open();
            sql = "SELECT *FROM studentlbl WHERE student_id = '" + studNumTxtbox.Text + "'";
            command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.Text;

            adaptersql = new SqlDataAdapter();
            adaptersql.SelectCommand = command;
            command.ExecuteNonQuery();

            dset = new DataSet();
            adaptersql.Fill(dset, "studentlbl");

            griddisplay.DataSource = dset.Tables[0];
            studNameTxtBox.Text = dset.Tables[0].Rows[0][1].ToString();

            departmentTxtBox.Text = dset.Tables[0].Rows[0][2].ToString();
            picpathTxtBox.Text = dset.Tables[0].Rows[0][3].ToString();
            pictureBox1.Image= Image.FromFile(picpathTxtBox.Text);
            connection.Close(); 
        }

        private void Deletebttn_Click(object sender, EventArgs e)
        {
            connection.Open();
            sql = "DELETE FROM studentlbl WHERE student_id ='" + studNumTxtbox.Text + "'";
            command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.Text;

            //codes for mediating the language or world of C# and MSSQL
            adaptersql = new SqlDataAdapter();
            adaptersql.DeleteCommand = command;
            command.ExecuteNonQuery();

            //mssql query to display the contents of student table located inside the database
             sql = "SELECT * FROM studentlbl ";
            command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.Text;

            //codes for mediating the language or world of C# and MSSQL
            adaptersql = new SqlDataAdapter();
            adaptersql.SelectCommand = command;
            command.ExecuteNonQuery();
            //codes for mirroring the contents of the database inside the MSSQL going to  C# or Visual Studio
            dset = new DataSet();
            adaptersql.Fill(dset, "studentlbl");
            //codes for displaying the contents of student table to the inside of data grid view
            griddisplay.DataSource = dset.Tables[0];
            pictureBox1.Image = Image.FromFile("C:\\Users\\Kaiser\\Downloads\\def.jpg");
            connection.Close();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            connection.Open();
            //mssql query to modify the contents of student table located inside thedatabase
             sql = "UPDATE studentlbl SET student_name = '" + studNameTxtBox.Text + "',department = '" + departmentTxtBox.Text + "', picpath = '" +picpathTxtBox.Text + "' WHERE student_id = '" +studNumTxtbox.Text + "' ";
            command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.Text;
            //codes for mediating the language or world of C# and MSSQL
            adaptersql = new SqlDataAdapter();
            adaptersql.UpdateCommand = command;
            command.ExecuteNonQuery();
            //mssql query to display the contents of student table located inside the database
             sql = "SELECT * FROM studentlbl ";
            command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.Text;
            //codes for mediating the language or world of C# and MSSQL
            adaptersql = new SqlDataAdapter();
            adaptersql.SelectCommand = command;
            command.ExecuteNonQuery();
            //codes for mirroring the contents of the database inside the MSSQL going to C# or Visual Studio
            dset = new DataSet();
            adaptersql.Fill(dset, "studentlbl");
            //codes for displaying the contents of student table to the inside of data grid view
            griddisplay.DataSource = dset.Tables[0];
            pictureBox1.Image = Image.FromFile("C:\\Users\\Kaiser\\Downloads\\def.jpg");

            studNumTxtbox.Clear();
            studNameTxtBox.Clear();
            departmentTxtBox.Clear();
            picpathTxtBox.Clear();
            connection.Close();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("C:\\Users\\Kaiser\\Downloads\\def.jpg");
            studNumTxtbox.Clear();
            studNameTxtBox.Clear();
            departmentTxtBox.Clear();
            picpathTxtBox.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("C:\\Users\\Kaiser\\Downloads\\def.jpg");
            studNumTxtbox.Clear();
            studNameTxtBox.Clear();
            departmentTxtBox.Clear();
            picpathTxtBox.Clear();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            //codes for inserting picture from the local file to the picturebox
            openFileDialog1.Filter = "Image File | *.gif; *.jpg; *.png; *.bmp";
            //filtering of image display using specific file extension
            openFileDialog1.ShowDialog();//displaying the file dialogbox where the Posible image located
            pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);//inserting of selected image to the picturebox shwon in the GUI 
            picpath = openFileDialog1.FileName;//storing the file location of the selected image inserted in picturebox to a variable
            picpathTxtBox.Text = picpath;//displaying the file location of the image stored in a variable to the textbox
            
        }

        private void picpathTxtBox_TextChanged(object sender, EventArgs e)
        {
            picpathTxtBox.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}

﻿using System;
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
namespace New_POS_Application
{
    public partial class Finals_Activity2: Form
    {
        pos_dbconnection posdb_connect = new pos_dbconnection();
        Price_Item_Value price_item_value = new Price_Item_Value();
        Variables variables = new Variables();
        private string picpath;

        public Finals_Activity2()
        {
            posdb_connect.pos_connString();

            InitializeComponent();
        }

        private void Finals_Activity2_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            picpathTxtbox1.Hide(); picpathTxtbox2.Hide(); picpathTxtbox3.Hide();
            picpathTxtbox4.Hide(); picpathTxtbox5.Hide(); picpathTxtbox6.Hide();
            picpathTxtbox7.Hide(); picpathTxtbox8.Hide(); picpathTxtbox9.Hide();
            picpathTxtbox10.Hide(); picpathTxtbox11.Hide();
            picpathTxtbox12.Hide(); picpathTxtbox13.Hide();
            picpathTxtbox14.Hide(); picpathTxtbox15.Hide();
            picpathTxtbox16.Hide(); picpathTxtbox17.Hide();
            picpathTxtbox18.Hide(); picpathTxtbox19.Hide();
            picpathTxtbox20.Hide();

            posdb_connect.pos_select_cashier();
            posdb_connect.pos_cmd();
            posdb_connect.pos_sqladapterSelect();
            posdb_connect.pos_sqldatasetSELECT();


            // Name labels
            name1lbl.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][2].ToString();
            name2lbl.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][3].ToString();
            name3lbl.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][4].ToString();
            name4lbl.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][5].ToString();
            name5lbl.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][6].ToString();
            name10lbl.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][7].ToString();
            name9lbl.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][8].ToString();
            name8lbl.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][9].ToString();
            name7lbl.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][10].ToString();
            name6lbl.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][11].ToString();
            name15lbl.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][12].ToString();
            name14lbl.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][13].ToString();
            name13lbl.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][14].ToString();
            name12lbl.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][15].ToString();
            name11lbl.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][16].ToString();
            name20lbl.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][17].ToString();
            name19lbl.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][18].ToString();
            name18lbl.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][19].ToString();
            name17lbl.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][20].ToString();
            name16lbl.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][21].ToString();

            // Picture paths and image loading
            picpathTxtbox1.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][24].ToString();
            pictureBox1.Image = Image.FromFile(picpathTxtbox1.Text);

            picpathTxtbox2.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][25].ToString();
            pictureBox2.Image = Image.FromFile(picpathTxtbox2.Text);

            picpathTxtbox3.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][26].ToString();
            pictureBox3.Image = Image.FromFile(picpathTxtbox3.Text);

            picpathTxtbox4.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][27].ToString();
            pictureBox4.Image = Image.FromFile(picpathTxtbox4.Text);

            picpathTxtbox5.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][28].ToString();
            pictureBox5.Image = Image.FromFile(picpathTxtbox5.Text);

            picpathTxtbox6.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][29].ToString();
            pictureBox6.Image = Image.FromFile(picpathTxtbox6.Text);

            picpathTxtbox7.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][30].ToString();
            pictureBox7.Image = Image.FromFile(picpathTxtbox7.Text);

            picpathTxtbox8.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][31].ToString();
            pictureBox8.Image = Image.FromFile(picpathTxtbox8.Text);

            picpathTxtbox9.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][32].ToString();
            pictureBox9.Image = Image.FromFile(picpathTxtbox9.Text);

            picpathTxtbox10.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][33].ToString();
            pictureBox10.Image = Image.FromFile(picpathTxtbox10.Text);

            picpathTxtbox11.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][34].ToString();
            pictureBox11.Image = Image.FromFile(picpathTxtbox11.Text);

            picpathTxtbox12.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][35].ToString();
            pictureBox12.Image = Image.FromFile(picpathTxtbox12.Text);

            picpathTxtbox13.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][36].ToString();
            pictureBox13.Image = Image.FromFile(picpathTxtbox13.Text);

            picpathTxtbox14.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][37].ToString();
            pictureBox14.Image = Image.FromFile(picpathTxtbox14.Text);

            picpathTxtbox15.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][38].ToString();
            pictureBox15.Image = Image.FromFile(picpathTxtbox15.Text);

            picpathTxtbox16.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][39].ToString();
            pictureBox16.Image = Image.FromFile(picpathTxtbox16.Text);

            picpathTxtbox17.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][40].ToString();
            pictureBox17.Image = Image.FromFile(picpathTxtbox17.Text);

            picpathTxtbox18.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][41].ToString();
            pictureBox18.Image = Image.FromFile(picpathTxtbox18.Text);

            picpathTxtbox19.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][42].ToString();
            pictureBox19.Image = Image.FromFile(picpathTxtbox19.Text);

            picpathTxtbox20.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][43].ToString();
            pictureBox20.Image = Image.FromFile(picpathTxtbox20.Text);

            // Price labels
            
            pricelbl1.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][46].ToString();
            pricelbl2.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][47].ToString();
            pricelbl3.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][48].ToString();
            pricelbl4.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][49].ToString();
            pricelbl5.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][50].ToString();
            pricelbl6.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][51].ToString();
            pricelbl7.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][52].ToString();
            pricelbl8.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][53].ToString();
            pricelbl9.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][54].ToString();
            pricelbl10.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][55].ToString();
            pricelbl11.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][56].ToString();
            pricelbl12.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][57].ToString();
            pricelbl13.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][58].ToString();
            pricelbl14.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][59].ToString();
            pricelbl15.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][60].ToString();
            pricelbl16.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][61].ToString();
            pricelbl17.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][62].ToString();
            pictureBox18.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][63].ToString();
            pricelbl19.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][64].ToString();
            pricelbl20.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][65].ToString();
            
            posdb_connect.pos_connString(); // 1. Open SQL connection
            posdb_connect.pos_select();     // 2. Set the SQL query
            posdb_connect.pos_cmd();        // 3. Create SqlCommand with SQL + connection
            posdb_connect.pos_sqladapterSelect(); // 4. Assign command to adapter
            posdb_connect.pos_sqldatasetSELECT();
        }
        private void quantityTxtbox()
        {
            quantitytxtbox.Clear();
            quantitytxtbox.Focus();
        }
        private void quantity_price_Convert()
        {
            variables.quantity = Convert.ToInt32(quantitytxtbox.Text);
            variables.price = Convert.ToDouble(pricetextbox.Text);
        }
        private void computation_Formula_and_DisplayData()
        {
            variables.discounted_amt = (variables.quantity * variables.price) -
            variables.discount_amt;
            discounttxtbox.Text = variables.discount_amt.ToString("n");
            discountedtxtbox.Text = variables.discounted_amt.ToString("n");
        }
        public void GetPriceItemValue()
        {
            itemnametxtbox.Text = (price_item_value.GetItemName());
            pricetextbox.Text = (price_item_value.GetPrice());
        }
        private void cleartextboxes()
        {
            itemnametxtbox.Clear();
            pricetextbox.Clear();
            quantitytxtbox.Clear();
            discountedtxtbox.Clear();
            discounttxtbox.Clear();
            changetxtbox.Clear();
            cashre_renderedtxtbox.Clear();
        }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (radioButton1.Checked == true)
                {
                    posdb_connect.pos_sql = "INSERT INTO salesTbl (product_name,  product_quantity_per_transaction, product_price, discount_option, discount_amount_per_transaction, discounted_amount_per_transaction, summary_total_quantity, summary_total_disc_given, summary_total_discounted_amount, terminal_no, time_date, emp_id)  VALUES('" + itemnametxtbox.Text + "', '" + quantitytxtbox.Text +  "', '" + pricetextbox.Text + "', '" + radioButton1.Text + "', '" + discounttxtbox.Text + "', '" + discountedtxtbox.Text + "', '" + qty_totaltxtbox.Text + "', '" + discount_totaltxtbox.Text + "', '" + disconted_totaltxtbox.Text + "', '" + terminal_noLbl.Text + "', '" + time_dateLbl.Text + "', '" + emp_idLbl.Text + "')";
                    posdb_connect.pos_cmd();
                    posdb_connect.pos_sqladapterInsert();
                    cleartextboxes();
                }
                else if (regularRbtn.Checked == true)
                {
                    posdb_connect.pos_sql = "INSERT INTO salesTbl (product_name, product_quantity_per_transaction, product_price, discount_option,  discount_amount_per_transaction, discounted_amount_per_transaction,  summary_total_quantity, summary_total_disc_given,  summary_total_discounted_amount, terminal_no, time_date, emp_id)  VALUES('" + itemnametxtbox.Text + "', '" + quantitytxtbox.Text +  "', '" + pricetextbox.Text + "', '" + regularRbtn.Text + "', '" + discounttxtbox.Text + "', '" + discountedtxtbox.Text + "', '" + qty_totaltxtbox.Text + "', '" + discount_totaltxtbox.Text + "', '" + disconted_totaltxtbox.Text + "', '" + terminal_noLbl.Text + "', '" + time_dateLbl.Text + "', '" + emp_idLbl.Text + "')";
                    posdb_connect.pos_cmd();
                    posdb_connect.pos_sqladapterInsert();
                    cleartextboxes();
                }
                else if (EmployeeRdbtn.Checked == true)
                {
                    posdb_connect.pos_sql = "INSERT INTO salesTbl (product_name,   product_quantity_per_transaction, product_price, discount_option,  discount_amount_per_transaction, discounted_amount_per_transaction,  summary_total_quantity, summary_total_disc_given,  summary_total_discounted_amount, terminal_no, time_date, emp_id)  VALUES('" + itemnametxtbox.Text + "', '" + quantitytxtbox.Text +  "', '" + pricetextbox.Text + "', '" + EmployeeRdbtn.Text + "', '" + discounttxtbox.Text + "', '" + discountedtxtbox.Text + "', '" + qty_totaltxtbox.Text + "', '" + discount_totaltxtbox.Text + "', '" + disconted_totaltxtbox.Text + "', '" + terminal_noLbl.Text + "', '" + time_dateLbl.Text + "', '" + emp_idLbl.Text + "')";
                    posdb_connect.pos_cmd();
                    posdb_connect.pos_sqladapterInsert();
                    cleartextboxes();
                }
                else if (noTaxRdbtn.Checked == true)
                {
                    posdb_connect.pos_sql = "INSERT INTO salesTbl (product_name,   product_quantity_per_transaction, product_price, discount_option,  discount_amount_per_transaction, discounted_amount_per_transaction,  summary_total_quantity, summary_total_disc_given,  summary_total_discounted_amount, terminal_no, time_date, emp_id) VALUES('" + itemnametxtbox.Text + "', '" + quantitytxtbox.Text +  "', '" + pricetextbox.Text + "', '" + noTaxRdbtn.Text + "', '" + discounttxtbox.Text + "', '" + discountedtxtbox.Text + "', '" + qty_totaltxtbox.Text + "', '" + discount_totaltxtbox.Text + "', '" +disconted_totaltxtbox.Text + "', '" + terminal_noLbl.Text + "', '" +time_dateLbl.Text + "', '" + emp_idLbl.Text + "')";
                    posdb_connect.pos_cmd();
                    posdb_connect.pos_sqladapterInsert();
                    cleartextboxes();
                }
                else
                    MessageBox.Show("No selected discount option");
            }
            catch (Exception)
            {
                MessageBox.Show("Error occurs in this area. Please contact your  administrator for this matter!!!"); 
}
        }
    }
}

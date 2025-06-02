using New_POS_Application;
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
    public partial class Finals_Activity3 : Form
    {
        double price, cash_given, change, total_amountPaid, discounted_amount, discount_amount, total_qty, totaldiscount_amt, totaldiscounted_amt, lahat;
        decimal remainingCash = 0;
        int qty;

        public Finals_Activity3()
        {
            InitializeComponent();
        }

        private void Finals_Activity3_Load(object sender, EventArgs e)
        {
            pricetxtbox.Enabled = false;
            discountamounttxtbox.Enabled = false;
            discountedamounttxtbox.Enabled = false;
            totalbillstxtbox.Enabled = false;
            totalquantitytxtbox.Enabled = false;
            changetxtbox.Enabled = false;

            A_checkbox1.Enabled = false;
            A_checkbox2.Enabled = false;
            A_checkbox3.Enabled = false;
            A_checkbox4.Enabled = false;
            A_checkbox5.Enabled = false;
            B_checkbox1.Enabled = false;
            B_checkbox2.Enabled = false;
            B_checkbox3.Enabled = false;
            B_checkbox4.Enabled = false;
            B_checkbox5.Enabled = false;

            picpathtxtbox1.Hide();
            picpathtxtbox2.Hide();
            picpathtxtbox3.Hide();
            picpathtxtbox4.Hide();
            picpathtxtbox5.Hide();
            picpathtxtbox6.Hide();
            picpathtxtbox7.Hide();
            picpathtxtbox8.Hide();
            picpathtxtbox9.Hide();
            picpathtxtbox10.Hide();
            picpathtxtbox11.Hide();
            picpathtxtbox12.Hide();
            picpathtxtbox13.Hide();
            picpathtxtbox14.Hide();
            picpathtxtbox15.Hide();
            picpathtxtbox16.Hide();
            picpathtxtbox17.Hide();
            picpathtxtbox18.Hide();
            picpathtxtbox19.Hide();
            picpathtxtbox20.Hide();

            foodba.Checked = false;
            foodbb.Checked = false;
        }//this one okeokeokee

        private void newbutton_Click(object sender, EventArgs e)
        {
            pricetxtbox.Clear();
            quantitytxtbox.Clear();
            discountamounttxtbox.Clear();
            discountedamounttxtbox.Clear();
            totalbillstxtbox.Clear();
            totalquantitytxtbox.Clear();
            cashgiventxtbox.Clear();
            changetxtbox.Clear();
            displaylistbox.Items.Clear();

            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            checkBox8.Checked = false;
            checkBox9.Checked = false;
            checkBox10.Checked = false;
            checkBox11.Checked = false;
            checkBox12.Checked = false;
            checkBox13.Checked = false;
            checkBox14.Checked = false;
            checkBox15.Checked = false;
            checkBox16.Checked = false;
            checkBox17.Checked = false;
            checkBox18.Checked = false;
            checkBox19.Checked = false;
            checkBox20.Checked = false;

            A_checkbox1.Enabled = false;
            A_checkbox2.Enabled = false;
            A_checkbox3.Enabled = false;
            A_checkbox4.Enabled = false;
            A_checkbox5.Enabled = false;
            B_checkbox1.Enabled = false;
            B_checkbox2.Enabled = false;
            B_checkbox3.Enabled = false;
            B_checkbox4.Enabled = false;
            B_checkbox5.Enabled = false;
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void removeorder_Click(object sender, EventArgs e)
        {
            try
            {
                displaylistbox.Items.RemoveAt(displaylistbox.SelectedIndex);
            }
            catch
            {
                MessageBox.Show("Click an order to Remove", "Warning");
            }
        }

        private void quantitytxtbox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (quantitytxtbox.Text != "")
                {
                    qty = Convert.ToInt32(quantitytxtbox.Text);


                }
                else
                {
                    qty = 0;
                }

                total_qty += qty;
                totalquantitytxtbox.Text = Convert.ToString(total_qty);

                discountamounttxtbox.Text = Convert.ToString(totaldiscount_amt);
                totalbillstxtbox.Text = Convert.ToString(totaldiscounted_amt);

                displaylistbox.Items.Add(totalbillstxtbox.Text);
            }

            catch
            {
                MessageBox.Show("Invalid Input: Please enter the correct Quantity", "Message");
            }
        }

        private void foodbb_CheckedChanged(object sender, EventArgs e)
        {
            foodba.Checked = false;
            A_checkbox1.Enabled = false;
            A_checkbox2.Enabled = false;
            A_checkbox3.Enabled = false;
            A_checkbox4.Enabled = false;
            A_checkbox5.Enabled = false;

            B_checkbox1.Enabled = true;
            B_checkbox2.Enabled = true;
            B_checkbox3.Enabled = true;
            B_checkbox4.Enabled = true;
            B_checkbox5.Enabled = true;


            pricetxtbox.Text = "1,299.00";
            discountamounttxtbox.Text = "(15% of the price)194.85";

            price = Convert.ToDouble(pricetxtbox.Text);
            displaylistbox.Items.Add(foodbb.Text);
        }

        private void foodba_CheckedChanged(object sender, EventArgs e)
        {
            foodbb.Checked = false;
            A_checkbox1.Enabled = true;
            A_checkbox2.Enabled = true;
            A_checkbox3.Enabled = true;
            A_checkbox4.Enabled = true;
            A_checkbox5.Enabled = true;

            B_checkbox1.Enabled = false;
            B_checkbox2.Enabled = false;
            B_checkbox3.Enabled = false;
            B_checkbox4.Enabled = false;
            B_checkbox5.Enabled = false;


            pricetxtbox.Text = "1,000.00";
            discountamounttxtbox.Text = "200.00";
            discountedamounttxtbox.Text = "800";
            totalbillstxtbox.Text = "800";

            // aling design ba un
            // anong act??? 3?? finals_activity3

            discount_amount = Convert.ToDouble(discountamounttxtbox.Text);
            discounted_amount = Convert.ToDouble(discountedamounttxtbox.Text);
            totalbillstxtbox.Text = Convert.ToString(totalbillstxtbox.Text);
            price = Convert.ToDouble(pricetxtbox.Text);
            displaylistbox.Items.Add(foodba.Text);
            displaylistbox.Items.Add("     Discount Amount: " + " " + totalbillstxtbox.Text);
            quantitytxtbox.Text = "0";
            quantitytxtbox.Focus();
        }

        private void calculatebills_Click(object sender, EventArgs e)
        {
            try
            {
                if (cash_given == 0)
                {
                    cash_given = Convert.ToDouble(cashgiventxtbox.Text);
                }

                // Calculate remaining cash after order
                double remainingCash = cash_given - totaldiscounted_amt;

                if (remainingCash >= 0) // If user has enough money
                {
                    cash_given = remainingCash; // Update cash for next order
                    changetxtbox.Text = "₱" + cash_given.ToString("N2"); // Show remaining cash

                    // Display order details
                    displaylistbox.Items.Add("Total Bills: ₱" + totaldiscounted_amt.ToString("N2"));
                    displaylistbox.Items.Add("Cash Before Order: ₱" + (cash_given + totaldiscounted_amt).ToString("N2"));
                    displaylistbox.Items.Add("Remaining Cash: " + changetxtbox.Text);
                    displaylistbox.Items.Add("Total No. of Items: " + total_qty);

                    // Set remaining cash as new money for the next order
                    cashgiventxtbox.Text = cash_given.ToString();
                }
                else
                {
                    MessageBox.Show("Insufficient funds! Order cannot be processed.");
                }

                // Stop ordering if no money left
                if (cash_given <= 0)
                {
                    MessageBox.Show("You have no more money left to order.");
                }
            }
            catch
            {
                MessageBox.Show("Invalid Input: Please enter the correct Amount", "Message");
            }
        }

        private void printtransaction_Click(object sender, EventArgs e)
        {
            Finals_Activity3_PrintFrm print = new Finals_Activity3_PrintFrm();
            print.printlistbox.Items.AddRange(this.displaylistbox.Items);
            print.Show();
        }
    }
}

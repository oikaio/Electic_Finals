using Activityt3;
using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace New_POS_Application
{
    public partial class SSS : Form
    {
        //declaration of global variables 
        private string picpath;
        private Double basic_netincome = 0.00,
                   basic_numhrs = 0.00,
                   basic_rate = 0.00,
                   hono_netincome = 0.00,
                   hono_numhrs = 0.00,
                   hono_rate = 0.00,
                   other_netincome = 0.00,
                   other_numhrs = 0.00,
                   other_rate = 0.00;
        private Double netincome = 0.00,
                   grossincome = 0.00,
                   sss_contrib = 0.00,
                   pagibig_contrib = 0.00,
                   philhealth_contrib = 0.00,
                   tax_contrib = 0.00;

        private Double sss_loan = 0.00,
                    pagibig_loan = 0.00,
                    salary_loan = 0.00,
                    salary_savings = 0.00,
                    faculty_sav_loan = 0.00,
                    other_deduction = 0.00,
                    total_deduction = 0.00,
                    total_contrib = 0.00,
                    total_loan = 0.00;






        double SemiMonthlyIncome, TaxDeduction;
        //codes for disabling  
        public SSS()
        {
            InitializeComponent();

            //codes for disabling the textboxes 

            basic_netincomeTxtbox.Enabled = false;
            hono_netincomeTxtbox.Enabled = false;
            other_netincomeTxtbox.Enabled = false;
            net_incomeTxtbox.Enabled = false;
            gross_incomeTxtbox.Enabled = false;
            total_deducTxtbox.Enabled = false;
            sss_contribTxtbox.Enabled = false;
            philhealth_contribTxtbox.Enabled = false;
            pagibig_contribTxtbox.Enabled = false;
            tax_contribTxtbox.Enabled = false;
            //codes for disabling the buttons 


            sss_contribTxtbox.Text = "0.00";
            pagibig_contribTxtbox.Text = "0.00";
            philhealth_contribTxtbox.Text = "0.00";
            tax_contribTxtbox.Text = "0.00";
            sss_loanTxtbox.Text = "0.00";
            pagibig_loanTxtbox.Text = "0.00";
            FSD_depositTxtbox.Text = "0.00";
            FS_loanTxtbox.Text = "0.00";
            sal_loanTxtbox.Text = "0.00";
            picpathTxtbox.Hide();
            otherloan.Text = "0.00";
            otherloan.Text = "Select other deduction";
            otherloan.Items.Add("Other 1");
            otherloan.Items.Add("Other 2");
            otherloan.Items.Add("Other 3");
            otherloan.Items.Add("Other 4");
            picpathTxtbox.Hide();
        }




        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click_1(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label36_Click(object sender, EventArgs e)
        {

        }

        private void label38_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            emp_nuTxtbox.Clear();
            firstnameTxtbox.Clear();
            MNameTxtbox.Clear();
            surTxtbox.Clear();
            CStatusTxbox.Clear();
            desigTxtbox.Clear();
            numDependentTxtbox.Clear();
            empStatusTxtbox.Clear();
            DeptNameTxtbox.Clear();
            basic_netincomeTxtbox.Clear();
            basic_numhrsTxtbox.Clear();
            basic_rateTxtbox.Clear();
            hono_netincomeTxtbox.Clear();
            hono_numhrsTxtbox.Clear();
            hono_rateTxtbox.Clear();
            other_netincomeTxtbox.Clear();
            other_numhrsTxtbox.Clear();
            other_rateTxtbox.Clear();
            net_incomeTxtbox.Clear();
            gross_incomeTxtbox.Clear();
            sss_contribTxtbox.Clear();
            pagibig_contribTxtbox.Clear();
            philhealth_contribTxtbox.Clear();
            tax_contribTxtbox.Clear();
            sss_loanTxtbox.Clear();
            pagibig_loanTxtbox.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            emp_nuTxtbox.Clear();
            firstnameTxtbox.Clear();
            MNameTxtbox.Clear();
            surTxtbox.Clear();
            CStatusTxbox.Clear();
            desigTxtbox.Clear();
            numDependentTxtbox.Clear();
            empStatusTxtbox.Clear();
            DeptNameTxtbox.Clear();
            basic_netincomeTxtbox.Clear();
            basic_numhrsTxtbox.Clear();
            basic_rateTxtbox.Clear();
            hono_netincomeTxtbox.Clear();
            hono_numhrsTxtbox.Clear();
            hono_rateTxtbox.Clear();
            other_netincomeTxtbox.Clear();
            other_numhrsTxtbox.Clear();
            other_rateTxtbox.Clear();
            net_incomeTxtbox.Clear();
            gross_incomeTxtbox.Clear();
            sss_contribTxtbox.Clear();
            pagibig_contribTxtbox.Clear();
            philhealth_contribTxtbox.Clear();
            tax_contribTxtbox.Clear();
            sss_loanTxtbox.Clear();
            pagibig_loanTxtbox.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox33_TextChanged(object sender, EventArgs e)
        {

        }

        private void basic_numhrsTxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void DeptNameTxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox31_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void browsebutton_Click_1(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
                }
            }
        }

        private void SSS_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void basic_rateTxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void hono_numhrsTxtbox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                hono_numhrs = Convert.ToDouble(hono_numhrsTxtbox.Text);
                hono_rate = Convert.ToDouble(hono_rateTxtbox.Text);
                hono_netincome = hono_numhrs * hono_rate;
                hono_netincomeTxtbox.Text = hono_netincome.ToString("n");
            }
            catch
            {
                MessageBox.Show("Invalid Input: Please enter the correct input", "Message");
                hono_rateTxtbox.Clear();
                hono_numhrsTxtbox.Clear();
            }
        }

        private void calcbutton_Click_1(object sender, EventArgs e)
        {
            try
            {
                sss_contrib = Convert.ToDouble(sss_contribTxtbox.Text);
                pagibig_contrib = Convert.ToDouble(pagibig_contribTxtbox.Text);
                philhealth_contrib = Convert.ToDouble(philhealth_contribTxtbox.Text);
                tax_contrib = Convert.ToDouble(tax_contribTxtbox.Text);
                sss_loan = Convert.ToDouble(sss_loanTxtbox.Text);
                pagibig_loan = Convert.ToDouble(pagibig_loanTxtbox.Text);
                salary_loan = Convert.ToDouble(sal_loanTxtbox.Text);
                faculty_sav_loan = Convert.ToDouble(FS_loanTxtbox.Text);
                salary_savings = Convert.ToDouble(sal_loanTxtbox.Text);
                other_numhrs = Convert.ToDouble(others_loanTxtbox.Text);
                faculty_sav_loan = Convert.ToDouble(FSD_depositTxtbox.Text);




                //Computation 
                total_contrib = netincome + faculty_sav_loan + salary_loan + pagibig_loan + sss_loan + other_numhrs + faculty_sav_loan;
                total_deducTxtbox.Text = total_contrib.ToString("n");

            }
            catch
            {
                MessageBox.Show("Invalid Input", "Message");
            }
        }

        private void printpayslipbutton_Click_1(object sender, EventArgs e)
        {

            //codes for calling the other form connected to the current form 
            sssdisplay print1 = new sssdisplay();
            //codes for displaying the contents of the listbox from other form to the current form. 
            print1.priDisplayListbox.Items.AddRange(this.payslip_viewListBox.Items);
            //code for displaying the other form 
            print1.Show();
        }

        private void basic_numhrsTxtbox_TextChanged_2(object sender, EventArgs e)
        {
            try
            {
                basic_numhrs = Double.Parse(basic_numhrsTxtbox.Text);
                basic_rate = Convert.ToDouble(basic_rateTxtbox.Text);
                basic_netincome = basic_numhrs * basic_rate;
                basic_netincomeTxtbox.Text = basic_netincome.ToString("n");
            }
            catch
            {
                MessageBox.Show("Invalid Input: Please enter the correct input", "Message");
                basic_rateTxtbox.Clear();
                basic_numhrsTxtbox.Clear();
            }
        }

        private void other_numhrsTxtbox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double a;
                other_numhrs = Convert.ToDouble(other_numhrsTxtbox.Text);
                other_rate = Convert.ToDouble(other_rateTxtbox.Text);
                other_netincome = other_numhrs * other_rate;
                grossincome = basic_netincome + hono_netincome + other_netincome;
                netincome = grossincome - (sss_contrib + philhealth_contrib + pagibig_contrib + tax_contrib);



                net_incomeTxtbox.Text = netincome.ToString("n");
                //total_deducTxtbox.Text = total_deduction.ToString("n");
                gross_incomeTxtbox.Text = grossincome.ToString("n");
                other_netincomeTxtbox.Text = other_netincome.ToString("n");
            }
            catch
            {
                MessageBox.Show("Invalid Input: Please enter the correct input", "Message");
                other_rateTxtbox.Clear();
                other_numhrsTxtbox.Clear();

            }
        }

        private void gross_incomeTxtbox_TextChanged_1(object sender, EventArgs e)
        {
            double grossincome = Convert.ToDouble(gross_incomeTxtbox.Text);
            double SemiMonthlyIncome = grossincome / 2;
            double TaxDeduction = 0;

            // Tax Deduction Calculation
            double[] taxBrackets = { 10417, 16666, 33332, 83332, 333332 };
            double[] taxRates = { 0.15, 0.20, 0.25, 0.30, 0.35 };
            double[] taxBaseAmounts = { 0, 937.50, 4270.70, 16770.70, 91770.70 };

            for (int i = 0; i < taxBrackets.Length; i++)
            {
                if (SemiMonthlyIncome > taxBrackets[i])
                {
                    if (i == taxBrackets.Length - 1 || SemiMonthlyIncome <= taxBrackets[i + 1])
                    {
                        TaxDeduction = (SemiMonthlyIncome - taxBrackets[i]) * taxRates[i] + taxBaseAmounts[i];
                        break;
                    }
                }
                else
                {
                    TaxDeduction = 0;
                    break;
                }
            }
            total_deducTxtbox.Text = TaxDeduction.ToString("n");

            // PhilHealth Contribution Calculation
            double philhealth_contrib;
            if (grossincome <= 10000)
            {
                philhealth_contrib = 500.00;
            }
            else if (grossincome >= 10000.01 && grossincome <= 99999.99)
            {
                philhealth_contrib = grossincome * 0.05;
            }
            else
            {
                philhealth_contrib = 5000.00;
            }
            philhealth_contribTxtbox.Text = philhealth_contrib.ToString("n");

            // PagIbig Contribution Calculation
            double pagibig_contrib = grossincome > 1500 ? 200.00 : grossincome * 0.01;
            pagibig_contribTxtbox.Text = pagibig_contrib.ToString("n");

            // SSS Contribution Calculation
            double[] sssBrackets = { 5249.99, 5749.99, 6249.99, 6749.99, 7249.99, 7749.99, 8249.99, 8749.99, 9249.99, 9749.99,
                         10249.99, 10749.99, 11249.99, 11749.99, 12249.99, 12749.99, 13249.99, 13749.99, 14249.99, 14749.99,
                         15249.99, 15749.99, 16249.99, 16749.99, 17249.99, 17749.99, 18249.99, 18749.99, 19249.99, 19749.99,
                         20249.99, 20749.99, 21249.99, 21749.99, 22249.99, 22749.99, 23249.99, 23749.99, 24249.99, 24749.99,
                         25249.99, 25749.99, 26249.99, 26749.99, 27249.99, 27749.99, 28249.99, 28749.99, 29249.99, 29749.99,
                         30249.99, 30749.99, 31249.99, 31749.99, 32249.99, 32749.99, 33249.99, 33749.99, 34249.99, 34749.99 };

            double[] sssContributions = { 250, 275, 300, 325, 350, 375, 400, 425, 450, 475, 500, 525, 550, 575, 600, 625, 650, 675, 700,
                              725, 750, 775, 800, 825, 850, 875, 900, 925, 950, 975, 1000, 1025, 1050, 1075, 1100, 1125,
                              1150, 1175, 1200, 1225, 1250, 1275, 1300, 1325, 1350, 1375, 1400, 1425, 1450, 1475, 1500,
                              1525, 1550, 1575, 1600, 1625, 1650, 1675, 1700, 1725, 1750 };

            double sss_contrib = 1750.00; // Default value

            for (int i = 0; i < sssBrackets.Length; i++)
            {
                if (grossincome <= sssBrackets[i])
                {
                    sss_contrib = sssContributions[i];
                    break;
                }
            }
            sss_contribTxtbox.Text = sss_contrib.ToString("n");
        }

        private void previewpayslipbutton_Click(object sender, EventArgs e)
        {
            //codes for calling the other form connected to the current form 
            sssdisplay print1 = new sssdisplay();
            //codes for displaying the contents of the listbox from other form to the current form. 
            print1.priDisplayListbox.Items.AddRange(this.payslip_viewListBox.Items);
            //code for displaying the other form 
            print1.Show();
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {

        }

        private void sss_contribTxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void philhealth_contribTxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void pagibig_contribTxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void tax_contribTxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void emp_nuTxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void numDependentTxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void firstnameTxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void MNameTxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void basic_netincomeTxtbox_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void net_incomeTxtbox_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void sss_loanTxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void pagibig_loanTxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void FSD_depositTxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void FS_loanTxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void sal_loanTxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void otherloan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void others_loanTxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void total_deducTxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            payslip_viewListBox.Items.Add("Employee Number:  " + " " + emp_nuTxtbox.Text);
            payslip_viewListBox.Items.Add("Firstname:  " + "" + firstnameTxtbox.Text);
            payslip_viewListBox.Items.Add("Middlename:  " + "" + MNameTxtbox.Text);
            payslip_viewListBox.Items.Add("Surname:  " + " " + surTxtbox.Text);
            payslip_viewListBox.Items.Add("Designation:  " + "" + desigTxtbox.Text);
            payslip_viewListBox.Items.Add("Employee Status:  " + "" + empStatusTxtbox.Text);
            payslip_viewListBox.Items.Add("Department:  " + "" + DeptNameTxtbox.Text);
            payslip_viewListBox.Items.Add("Pay Date:  " + "" + dateTimePicker1.Text);
            payslip_viewListBox.Items.Add("---------------------------------------------------------------------------------------");
            payslip_viewListBox.Items.Add("BP Num. of Hrs.:  " + "P" + basic_numhrsTxtbox.Text);

            payslip_viewListBox.Items.Add("BP Rate / Hr.:  " + "P" + basic_rateTxtbox.Text);

            payslip_viewListBox.Items.Add("Baisc Pay Income  " + "P" + basic_netincomeTxtbox.Text);

            payslip_viewListBox.Items.Add("");
            payslip_viewListBox.Items.Add("HI Num. of Hrs.:  " + "P" + hono_netincomeTxtbox.Text);

            payslip_viewListBox.Items.Add("HI Rate / Hr.:  " + "P" + hono_netincomeTxtbox.Text);

            payslip_viewListBox.Items.Add("Honorarium Income  " + "P" + hono_netincomeTxtbox.Text);

            //payslip_viewListBox.Items.Add("");
            // payslip_viewListBox.Items.Add("OTI Num. of Hrs.:  " + "P" + aaaa.Text);

            payslip_viewListBox.Items.Add("OTI Rate / Hr.:  " + "P" + other_numhrsTxtbox.Text);

            payslip_viewListBox.Items.Add("Other Income  " + "P" + other_netincomeTxtbox.Text);

            payslip_viewListBox.Items.Add("----------------------------------------- ----------------------------------------------");
            payslip_viewListBox.Items.Add("SSS Contribution:  " + "P" + sss_contribTxtbox.Text);

            payslip_viewListBox.Items.Add("PhilHealth Contribution  " + "P" + philhealth_contribTxtbox.Text);

            payslip_viewListBox.Items.Add("Pagibig Contribution:  " + "P" + pagibig_contribTxtbox.Text);

            payslip_viewListBox.Items.Add("Tax Contribution:  " + "P" + tax_contribTxtbox.Text);

            payslip_viewListBox.Items.Add("SSS Loan:  " + "P" + sss_loanTxtbox.Text);

            payslip_viewListBox.Items.Add("Pagibig Loan:  " + "P" + pagibig_loanTxtbox.Text);

            payslip_viewListBox.Items.Add("Faculty Savings Deposit:  " + "P" + FSD_depositTxtbox.Text);

            payslip_viewListBox.Items.Add("Faculty Savings Loan:  " + "P" + FS_loanTxtbox.Text);

            payslip_viewListBox.Items.Add("Salary Loan:  " + "P" + sal_loanTxtbox.Text);

            payslip_viewListBox.Items.Add("Other Loan:  " + "P" + otherloan.Text);

            payslip_viewListBox.Items.Add("---------------------------------------------------------------------------------------");

            payslip_viewListBox.Items.Add("Total Deduction:  " + "P" + total_deducTxtbox.Text);

            payslip_viewListBox.Items.Add("Gross Income:  " + "P" + gross_incomeTxtbox.Text);

            payslip_viewListBox.Items.Add("Net Income:  " + "  P" + net_incomeTxtbox.Text);
        }


        private void MN_TextChanged(object sender, EventArgs e)
        {

        }

        private void payslip_viewListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void sss_loan_TextChanged(object sender, EventArgs e)
        {

        }

        private void basic_netincomeTxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }

        private void calcbutton_Click(object sender, EventArgs e)
        {
            try
            {
                sss_contrib = Convert.ToDouble(sss_contribTxtbox.Text);
                pagibig_contrib = Convert.ToDouble(pagibig_contribTxtbox.Text);
                philhealth_contrib = Convert.ToDouble(philhealth_contribTxtbox.Text);
                tax_contrib = Convert.ToDouble(tax_contribTxtbox.Text);
                sss_loan = Convert.ToDouble(sss_loanTxtbox.Text);
                pagibig_loan = Convert.ToDouble(pagibig_loanTxtbox.Text);
                salary_loan = Convert.ToDouble(sal_loanTxtbox.Text);
                faculty_sav_loan = Convert.ToDouble(FS_loanTxtbox.Text);
                salary_savings = Convert.ToDouble(sal_loanTxtbox.Text);
                other_numhrs = Convert.ToDouble(others_loanTxtbox.Text);
                faculty_sav_loan = Convert.ToDouble(FSD_depositTxtbox.Text);




                //Computation 
                total_contrib = netincome + faculty_sav_loan + salary_loan + pagibig_loan + sss_loan + other_numhrs + faculty_sav_loan;
                //codes for converting numeric data to string and displayed it inside the textboxes
                total_deducTxtbox.Text = total_contrib.ToString("n");
                //netincome = grossincome - total_deduction;
                //net_incomeTxtbox = netincome.ToString("n");
            }
            catch 
            {
                MessageBox.Show("Invalid Input", "Message");
            }

        }

        public void printpayslipbutton_Click(object sender, EventArgs e)
        {
            //codes for calling the other form connected to the current form 
            sssdisplay print1 = new sssdisplay();
            //codes for displaying the contents of the listbox from other form to the current form. 
            print1.priDisplayListbox.Items.AddRange(this.payslip_viewListBox.Items);
            //code for displaying the other form 
            print1.Show();
        }

        private void browsebutton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image File | * .gif; * .jpg; * .png; * .bmp";
            openFileDialog.Title = " Select Employee Picture";
            openFileDialog.ShowDialog();
            picpath = openFileDialog.FileName;
            picpathTxtbox.Text = picpath;
            pictureBox2.Image = Image.FromFile(openFileDialog.FileName);

        }

        private void basic_numhrsTxtbox_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                basic_numhrs = Double.Parse(basic_numhrsTxtbox.Text);
                basic_rate = Convert.ToDouble(basic_rateTxtbox.Text);
                basic_netincome = basic_numhrs * basic_rate;
                basic_netincomeTxtbox.Text = basic_netincome.ToString("n");
            }
            catch 
            {
                MessageBox.Show("Invalid Input: Please enter the correct input", "Message");
                basic_rateTxtbox.Clear();
                basic_numhrsTxtbox.Clear();
            }
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            try
            {
                hono_numhrs = Convert.ToDouble(hono_numhrsTxtbox.Text);
                hono_rate = Convert.ToDouble(hono_rateTxtbox.Text);
                hono_netincome = hono_numhrs * hono_rate;
                hono_netincomeTxtbox.Text = hono_netincome.ToString("n");
            }
            catch 
            {
                MessageBox.Show("Invalid Input: Please enter the correct input", "Message");
                hono_rateTxtbox.Clear();
                hono_numhrsTxtbox.Clear();
            }
        }

        private void other_rateTxtbox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double a;
                other_numhrs = Convert.ToDouble(other_numhrsTxtbox.Text);
                other_rate = Convert.ToDouble(other_rateTxtbox.Text);
                other_netincome = other_numhrs * other_rate;
                grossincome = basic_netincome + hono_netincome + other_netincome;
                netincome = grossincome - (sss_contrib + philhealth_contrib + pagibig_contrib + tax_contrib);



                net_incomeTxtbox.Text = netincome.ToString("n");
                //total_deducTxtbox.Text = total_deduction.ToString("n");
                gross_incomeTxtbox.Text = grossincome.ToString("n");
                other_netincomeTxtbox.Text = other_netincome.ToString("n");
            }
            catch 
            {
                MessageBox.Show("Invalid Input: Please enter the correct input", "Message");
                other_rateTxtbox.Clear();
                other_numhrsTxtbox.Clear();

            }
        }

        private void aaaa_TextChanged(object sender, EventArgs e)
        {

        }

        private void others_loanTxtbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void gross_incomeTxtbox_TextChanged(object sender, EventArgs e)
        {
            double grossincome = Convert.ToDouble(gross_incomeTxtbox.Text);
            double SemiMonthlyIncome = grossincome / 2;
            double TaxDeduction = 0;

            // Tax Deduction Calculation
            double[] taxBrackets = { 10417, 16666, 33332, 83332, 333332 };
            double[] taxRates = { 0.15, 0.20, 0.25, 0.30, 0.35 };
            double[] taxBaseAmounts = { 0, 937.50, 4270.70, 16770.70, 91770.70 };

            for (int i = 0; i < taxBrackets.Length; i++)
            {
                if (SemiMonthlyIncome > taxBrackets[i])
                {
                    if (i == taxBrackets.Length - 1 || SemiMonthlyIncome <= taxBrackets[i + 1])
                    {
                        TaxDeduction = (SemiMonthlyIncome - taxBrackets[i]) * taxRates[i] + taxBaseAmounts[i];
                        break;
                    }
                }
                else
                {
                    TaxDeduction = 0;
                    break;
                }
            }
            total_deducTxtbox.Text = TaxDeduction.ToString("n");

            // PhilHealth Contribution Calculation
            double philhealth_contrib;
            if (grossincome <= 10000)
            {
                philhealth_contrib = 500.00;
            }
            else if (grossincome >= 10000.01 && grossincome <= 99999.99)
            {
                philhealth_contrib = grossincome * 0.05;
            }
            else
            {
                philhealth_contrib = 5000.00;
            }
            philhealth_contribTxtbox.Text = philhealth_contrib.ToString("n");

            // PagIbig Contribution Calculation
            double pagibig_contrib = grossincome > 1500 ? 200.00 : grossincome * 0.01;
            pagibig_contribTxtbox.Text = pagibig_contrib.ToString("n");

            // SSS Contribution Calculation
            double[] sssBrackets = { 5249.99, 5749.99, 6249.99, 6749.99, 7249.99, 7749.99, 8249.99, 8749.99, 9249.99, 9749.99,
                         10249.99, 10749.99, 11249.99, 11749.99, 12249.99, 12749.99, 13249.99, 13749.99, 14249.99, 14749.99,
                         15249.99, 15749.99, 16249.99, 16749.99, 17249.99, 17749.99, 18249.99, 18749.99, 19249.99, 19749.99,
                         20249.99, 20749.99, 21249.99, 21749.99, 22249.99, 22749.99, 23249.99, 23749.99, 24249.99, 24749.99,
                         25249.99, 25749.99, 26249.99, 26749.99, 27249.99, 27749.99, 28249.99, 28749.99, 29249.99, 29749.99,
                         30249.99, 30749.99, 31249.99, 31749.99, 32249.99, 32749.99, 33249.99, 33749.99, 34249.99, 34749.99 };

            double[] sssContributions = { 250, 275, 300, 325, 350, 375, 400, 425, 450, 475, 500, 525, 550, 575, 600, 625, 650, 675, 700,
                              725, 750, 775, 800, 825, 850, 875, 900, 925, 950, 975, 1000, 1025, 1050, 1075, 1100, 1125,
                              1150, 1175, 1200, 1225, 1250, 1275, 1300, 1325, 1350, 1375, 1400, 1425, 1450, 1475, 1500,
                              1525, 1550, 1575, 1600, 1625, 1650, 1675, 1700, 1725, 1750 };

            double sss_contrib = 1750.00; // Default value

            for (int i = 0; i < sssBrackets.Length; i++)
            {
                if (grossincome <= sssBrackets[i])
                {
                    sss_contrib = sssContributions[i];
                    break;
                }
            }
            sss_contribTxtbox.Text = sss_contrib.ToString("n");

        }

        private void label39_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void net_incomeTxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void other_netincomeTxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void hono_netincomeTxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

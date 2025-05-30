using Activityt3;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace New_POS_Application
{
    public partial class MidtermSSS : Form
    {
        // Declare global variables
        private PayrollCalculator calculator;
        private double basicPay, honorariumPay, otherPay;
        private double totalDeductions, netIncome;
        private double sss_contrib, pagibig_contrib, philhealth_contrib, tax_contrib, sss_loan, pagibig_loan, salary_loan;
        private double faculty_sav_loan, salary_savings, other_deduction, total_contrib, total_loan, total_deduction, netincome, grossincome;

        private void CalculateBtn_Click(object sender, EventArgs e)
        {
            // Convertion ToDouble
            sss_contrib = Convert.ToDouble(ContributionTxtbox.Text);
            pagibig_contrib = Convert.ToDouble(PContributionTxtbox.Text);
            philhealth_contrib = Convert.ToDouble(PhilHealthTxtbox.Text);
            tax_contrib = Convert.ToDouble(TaxtTxtbox.Text);
            try
            {
                sss_loan = Convert.ToDouble(LoanTxtbox.Text);
                pagibig_loan = Convert.ToDouble(PLoanTxtbox.Text);
                salary_loan = Convert.ToDouble(SalaryLoanTxtbox.Text);
                faculty_sav_loan = Convert.ToDouble(FSLoanTxtbox.Text);
                salary_savings = Convert.ToDouble(FSDepositetxtbox.Text);
                other_deduction = Convert.ToDouble(OthersTxtbox.Text);
            }
            catch
            {
                MessageBox.Show("Please enter valid other pay information.");
            }

            //Computation 
            total_contrib = sss_contrib + pagibig_contrib + philhealth_contrib + tax_contrib;
            total_loan = sss_loan + pagibig_loan + salary_loan + faculty_sav_loan + salary_savings + other_deduction;
            total_deduction = total_contrib + total_loan;
            //codes for converting numeric data to string and displayed it inside the textboxes
            TotalDeductionTxtbox.Text = total_deduction.ToString("n");
            netincome = grossincome - total_deduction;
            NetIncomeTxtbox.Text = netincome.ToString("n");
        }

        private void PrintPayslipBnt_Click(object sender, EventArgs e)
        {
            //codes for calling the other form connected to the current form 
            sssdisplay print1 = new sssdisplay();
            //codes for displaying the contents of the listbox from other form to the current form. 
            print1.priDisplayListbox.Items.AddRange(this.PayslipListbox.Items);
            //code for displaying the other form 
            print1.Show();
        }

        private void ExitBtn_Click_1(object sender, EventArgs e)
        {
            this.Close();
            menustrip menu = new menustrip();
            menu.Show();
        }

        private void Cancel_Click_1(object sender, EventArgs e)
        {
            EmployeeNumberTxtbox.Clear();
            FirstnameTxtbox.Clear();
            MiddlenameTxtbox.Clear();
            SurnameTxtbox.Clear();
            StatusTxtbox.Clear();
            DesignationTxtbox.Clear();
            DependentTxtbox.Clear();
            EmployeeStatusTxtbox.Clear();
            DepartmentTxtbox.Clear();
            IncomeTxtbox.Clear();
            BPNoHoursTxtbox.Text = 0.ToString("d");
            BPRateHourTxtbox.Text = 0.ToString("d");
            TotalHonorariumTxtbox.Clear();
            HNoHoursTxtBox.Text = 0.ToString("d");
            HRateHourTxtbox.Text = 0.ToString("d");
            TotalOtherIncomeTxtbox.Clear();
            ONoHours.Text = 0.ToString("d");
            ORateHourTxtbox.Text = 0.ToString("d");
            NetIncomeTxtbox.Clear();
            GrossIncomeTxtbox.Text = 0.ToString("d");
            ContributionTxtbox.Text = 0.ToString("n");
            PContributionTxtbox.Text = 0.ToString("n");
            PhilHealthTxtbox.Text = 0.ToString("n");
            TaxtTxtbox.Text = 0.ToString("n");
            LoanTxtbox.Text = 0.ToString("n");
            PLoanTxtbox.Text = 0.ToString("n");
            pictureBox1.Image = null;
            PayslipListbox.Items.Clear();
        }

        private void BPNoHoursTxtbox_TextChanged(object sender, EventArgs e)
        {
            CalculateBasicPay();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Image File | * .gif; * .jpg; * .png; * .bmp";
                openFileDialog.Title = " Select Employee Picture";
                openFileDialog.ShowDialog();
                picpath = openFileDialog.FileName;
                picpathTxtbox.Text = picpath;
                pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
            }
            catch
            {
                MessageBox.Show("Error ","PLEASE TRY AGAIN");
            }

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ONoHours_TextChanged(object sender, EventArgs e)
        {
            CalculateOtherPay();
        }

        private void NewBtn_Click_1(object sender, EventArgs e)
        {
                        EmployeeNumberTxtbox.Clear();
            FirstnameTxtbox.Clear();
            MiddlenameTxtbox.Clear();
            SurnameTxtbox.Clear();
            StatusTxtbox.Clear();
            DesignationTxtbox.Clear();
            DependentTxtbox.Clear();
            EmployeeStatusTxtbox.Clear();
            DepartmentTxtbox.Clear();
            IncomeTxtbox.Clear();
            BPNoHoursTxtbox.Text = 0.ToString("d");
            BPRateHourTxtbox.Text = 0.ToString("d");
            TotalHonorariumTxtbox.Clear();
            HNoHoursTxtBox.Text = 0.ToString("d");
            HRateHourTxtbox.Text = 0.ToString("d");
            TotalOtherIncomeTxtbox.Clear();
            ONoHours.Text = 0.ToString("d");
            ORateHourTxtbox.Text = 0.ToString("d");
            NetIncomeTxtbox.Clear();
            GrossIncomeTxtbox.Text = 0.ToString("d");
            ContributionTxtbox.Text = 0.ToString("n");
            PContributionTxtbox.Text = 0.ToString("n");
            PhilHealthTxtbox.Text = 0.ToString("n");
            TaxtTxtbox.Text = 0.ToString("n");
            LoanTxtbox.Text = 0.ToString("n");
            PLoanTxtbox.Text = 0.ToString("n");
            pictureBox1.Image = null;
            PayslipListbox.Items.Clear();
        }

        private void HNoHoursTxtBox_TextChanged_1(object sender, EventArgs e)
        {
            CalculateHonorariumPay();
        }

        private void PreviewBtn_Click(object sender, EventArgs e)
        {
            PayslipListbox.Items.Clear();
            //Payslip_viewListBox.Items.Add(""); 
            PayslipListbox.Items.Add("Employee Number:  " + "\t" + "\t" + EmployeeNumberTxtbox.Text);
            PayslipListbox.Items.Add("Firstname:  " + "\t" + "\t" + "\t" + FirstnameTxtbox.Text);
            PayslipListbox.Items.Add("Middlename:  " + "\t" + "\t" + "\t" + MiddlenameTxtbox.Text);
            PayslipListbox.Items.Add("Surname:  " + "\t" + "\t" + "\t" + SurnameTxtbox.Text);
            PayslipListbox.Items.Add("Designation:  " + "\t" + "\t" + "\t" + DesignationTxtbox.Text);
            PayslipListbox.Items.Add("Employee Status:  " + "\t" + "\t" + "\t" + StatusTxtbox.Text);
            PayslipListbox.Items.Add("Department:  " + "\t" + "\t" + "\t" + DepartmentTxtbox.Text);
            PayslipListbox.Items.Add("Pay Date:  " + "\t" + "\t" + "\t" + PaydateTxtbox.Text);
            PayslipListbox.Items.Add("---------------------------------------------------------------------------------------------------------");
            PayslipListbox.Items.Add("BP Num. of Hrs.:  " + "\t" + "\t" + "\t" + "P" + BPRateHourTxtbox.Text);
            PayslipListbox.Items.Add("BP Rate / Hr.:  " + "\t" + "\t" + "\t" + "P" + BPNoHoursTxtbox.Text);
            PayslipListbox.Items.Add("Baisc Pay Income  " + "\t" + "\t" + "\t" + "P" + IncomeTxtbox.Text);
            PayslipListbox.Items.Add("");
            PayslipListbox.Items.Add("HI Num. of Hrs.:  " + "\t" + "\t" + "\t" + "P" + HRateHourTxtbox.Text);
            PayslipListbox.Items.Add("HI Rate / Hr.:  " + "\t" + "\t" + "\t" + "P" + HNoHoursTxtBox.Text);
            PayslipListbox.Items.Add("Honorarium Income  " + "\t" + "\t" + "P" + TotalHonorariumTxtbox.Text);
            PayslipListbox.Items.Add("");
            PayslipListbox.Items.Add("OTI Num. of Hrs.:  " + "\t" + "\t" + "\t" + "P" + ORateHourTxtbox.Text);
            PayslipListbox.Items.Add("OTI Rate / Hr.:  " + "\t" + "\t" + "\t" + "P" + ONoHours.Text);
            PayslipListbox.Items.Add("Other Income  " + "\t" + "\t" + "\t" + "P" + TotalOtherIncomeTxtbox.Text);
            PayslipListbox.Items.Add("---------------------------------------------------------------------------------------------------------");
            PayslipListbox.Items.Add("SSS Contribution:  " + "\t" + "\t" + "\t" + "P" + ContributionTxtbox.Text);
            PayslipListbox.Items.Add("PhilHealth Contribution  " + "\t" + "\t" + "P" + PhilHealthTxtbox.Text);
            PayslipListbox.Items.Add("Pagibig Contribution:  " + "\t" + "\t" + "P" + PContributionTxtbox.Text);
            PayslipListbox.Items.Add("Tax Contribution:  " + "\t" + "\t" + "\t" + "P" + TaxtTxtbox.Text);
            PayslipListbox.Items.Add("SSS Loan:  " + "\t" + "\t" + "\t" + "P" + LoanTxtbox.Text);
            PayslipListbox.Items.Add("Pagibig Loan:  " + "\t" + "\t" + "\t" + "P" + PLoanTxtbox.Text);
            PayslipListbox.Items.Add("Faculty Savings Deposit:  " + "\t" + "\t" + "P" + FSDepositetxtbox.Text);
            PayslipListbox.Items.Add("Faculty Savings Loan:  " + "\t" + "\t" + "P" + FSLoanTxtbox.Text);
            PayslipListbox.Items.Add("Salary Loan:  " + "\t" + "\t" + "\t" + "P" + SalaryLoanTxtbox.Text);
            PayslipListbox.Items.Add("Other Loan:  " + "\t" + "\t" + "\t" + "P" + OtherLoanCombobox.Text);
            PayslipListbox.Items.Add("---------------------------------------------------------------------------------------------------------");
            PayslipListbox.Items.Add("Total Deduction:  " + "\t" + "\t" + "\t" + "P" + TotalDeductionTxtbox.Text);
            PayslipListbox.Items.Add("Gross Income:  " + "\t" + "\t" + "\t" + "P" + GrossIncomeTxtbox.Text);
            PayslipListbox.Items.Add("Net Income:  " + "\t" + "\t" + "\t" + "P" + NetIncomeTxtbox.Text);
        }
        

        private string picpath;
        public MidtermSSS()
        {
            InitializeComponent();
            calculator = new PayrollCalculator();
            SetupInitialFormState();
        }

        private void MidtermSSS_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            calculator = new PayrollCalculator();
            SetupInitialFormState();
        }
        private void SetupInitialFormState()
        {
            // Disable text boxes
            IncomeTxtbox.Enabled = false;
            TotalHonorariumTxtbox.Enabled = false;
            TotalOtherIncomeTxtbox.Enabled = false;
            GrossIncomeTxtbox.Enabled = false;
            NetIncomeTxtbox.Enabled = false;
            TotalDeductionTxtbox.Enabled = false;
            PhilHealthTxtbox.Enabled = false;
            PContributionTxtbox.Enabled = false;
            TaxtTxtbox.Enabled = false;
            ContributionTxtbox.Enabled = false;

            // Set initial values
            ContributionTxtbox.Text = "0.00";
            PhilHealthTxtbox.Text = "0.00";
            PContributionTxtbox.Text = "0.00";
            TaxtTxtbox.Text = "0.00";
        }
        private void CalculateBasicPay()
        {
            try
            {
                // Calculate basic pay
                double hours = Convert.ToDouble(BPNoHoursTxtbox.Text);
                double rate = Convert.ToDouble(BPRateHourTxtbox.Text);
                basicPay = hours * rate;
                IncomeTxtbox.Text = basicPay.ToString("N2");
            }
            catch
            {
                MessageBox.Show("Please enter valid basic pay information.");
            }
        }
        private void CalculateHonorariumPay()
        {
            try
            {
                // Calculate honorarium pay
                double hours = Convert.ToDouble(HNoHoursTxtBox.Text);
                double rate = Convert.ToDouble(HRateHourTxtbox.Text);
                honorariumPay = hours * rate;
                TotalHonorariumTxtbox.Text = honorariumPay.ToString("N2");
            }
            catch
            {
                MessageBox.Show("Please enter valid honorarium pay information.");
            }
        }
        private void CalculateOtherPay()
        {
            try
            {
                // Calculate other pay
                double hours = Convert.ToDouble(ONoHours.Text);
                double rate = Convert.ToDouble(ORateHourTxtbox.Text);
                otherPay = hours * rate;
                TotalOtherIncomeTxtbox.Text = otherPay.ToString("N2");

                // Calculate gross income
                double grossIncome = basicPay + honorariumPay + otherPay;
                GrossIncomeTxtbox.Text = grossIncome.ToString("N2");

                // Calculate contributions and deductions
                double tax = calculator.CalculateTax(grossIncome);
                double philHealth = calculator.CalculatePhilHealth(grossIncome);
                double pagibig = calculator.CalculatePagibig(grossIncome);
                double sss = calculator.CalculateSSS(grossIncome);

                // Update contribution textboxes
                TaxtTxtbox.Text = tax.ToString("N2");
                PhilHealthTxtbox.Text = philHealth.ToString("N2");
                PContributionTxtbox.Text = pagibig.ToString("N2");
                ContributionTxtbox.Text = sss.ToString("N2");

                // Calculate total deductions
                totalDeductions = tax + philHealth + pagibig + sss;
                TotalDeductionTxtbox.Text = totalDeductions.ToString("N2");

                // Calculate net income
                netIncome = grossIncome - totalDeductions;
                NetIncomeTxtbox.Text = netIncome.ToString("N2");
            }
            catch
            {
                MessageBox.Show("Please enter valid other pay information.");
            }
        }    
        private void NewBtn_Click(object sender, EventArgs e)
        {
            EmployeeNumberTxtbox.Clear();
            FirstnameTxtbox.Clear();
            MiddlenameTxtbox.Clear();
            SurnameTxtbox.Clear();
            SurnameTxtbox.Clear();
            StatusTxtbox.Clear();
            DepartmentTxtbox.Clear();
            EmployeeStatusTxtbox.Clear();
            DepartmentTxtbox.Clear();
            IncomeTxtbox.Clear();
            BPNoHoursTxtbox.Text = 0.ToString("d");
            BPRateHourTxtbox.Text = 0.ToString("d");
            TotalHonorariumTxtbox.Clear();
            HNoHoursTxtBox.Text = 0.ToString("d");
            HRateHourTxtbox.Text = 0.ToString("d");
            TotalOtherIncomeTxtbox.Clear();
            ONoHours.Text = 0.ToString("d");
            ORateHourTxtbox.Text = 0.ToString("d");
            NetIncomeTxtbox.Clear();
            GrossIncomeTxtbox.Text = 0.ToString("d");
            ContributionTxtbox.Text = 0.ToString("n");
            PContributionTxtbox.Text = 0.ToString("n");
            PhilHealthTxtbox.Text = 0.ToString("n");
            TaxtTxtbox.Text = 0.ToString("n");
            LoanTxtbox.Text = 0.ToString("n");
            PLoanTxtbox.Text = 0.ToString("n");
            pictureBox1.Image = null;
            PayslipListbox.Items.Clear();
        }
        private void Cancel_Click(object sender, EventArgs e)
        {
            EmployeeNumberTxtbox.Clear();
            FirstnameTxtbox.Clear();
            MiddlenameTxtbox.Clear();
            SurnameTxtbox.Clear();
            StatusTxtbox.Clear();
            DesignationTxtbox.Clear();
            ONoHours.Clear();
            EmployeeStatusTxtbox.Clear();
            DepartmentTxtbox.Clear();
            IncomeTxtbox.Clear();
            BPNoHoursTxtbox.Text = 0.ToString("d");
            BPRateHourTxtbox.Text = 0.ToString("d");
            TotalHonorariumTxtbox.Clear();
            HNoHoursTxtBox.Text = 0.ToString("d");
            HRateHourTxtbox.Text = 0.ToString("d");
            TotalOtherIncomeTxtbox.Clear();
            ONoHours.Text = 0.ToString("d");
            ORateHourTxtbox.Text = 0.ToString("d");
            NetIncomeTxtbox.Clear();
            GrossIncomeTxtbox.Text = 0.ToString("d");
            ContributionTxtbox.Text = 0.ToString("n");
            PContributionTxtbox.Text = 0.ToString("n");
            PhilHealthTxtbox.Text = 0.ToString("n");
            TaxtTxtbox.Text = 0.ToString("n");
            LoanTxtbox.Text = 0.ToString("n");
            PLoanTxtbox.Text = 0.ToString("n");
            pictureBox1.Image = null;
            PayslipListbox.Items.Clear();
        }
        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BrowseBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image File | * .gif; * .jpg; * .png; * .bmp";
            openFileDialog.Title = " Select Employee Picture";
            openFileDialog.ShowDialog();
            picpath = openFileDialog.FileName;
            picpathTxtbox.Text = picpath;
            pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
        }


        public class PayrollCalculator //function
        {
            // Simple methods for calculating contributions and deductions
            public double CalculateTax(double income)
            {
                double taxableIncome = income / 2; // Semi-monthly income

                if (taxableIncome <= 10416.99)
                    return 0;
                else if (taxableIncome <= 16665.99)
                    return (taxableIncome - 10417) * 0.15;
                else if (taxableIncome <= 33331.99)
                    return ((taxableIncome - 16666) * 0.20) + 937.50;
                else if (taxableIncome <= 83331.99)
                    return ((taxableIncome - 33332) * 0.25) + 4270.70;
                else if (taxableIncome <= 333331.99)
                    return ((taxableIncome - 83332) * 0.30) + 16770.70;
                else
                    return ((taxableIncome - 333332) * 0.35) + 91770.70;
            }
            public double CalculatePagibig(double income)
            {
                return income > 1500 ? 200 : income * 0.01;
            }

            public double CalculateSSS(double income)
            {
                if (income <= 5249.99)
                    return 250;

                double[] sssRates = { 275, 300, 325, 350, 375, 400, 425, 450, 475, 500,
                                   525, 550, 575, 600, 625, 650, 675, 700, 725, 750,
                                   775, 800, 825, 850, 875, 900, 925, 950, 975, 1000 };

                for (int i = 0; i < sssRates.Length; i++)
                {
                    if (income <= 5250 + (i * 500))
                        return sssRates[i];
                }

                return 1750; // Maximum contribution
          
            }
            public double CalculatePhilHealth(double income)
            {
                if (income < 10000)
                    return 500;
                else if (income >= 100000)
                    return 5000;
                else
                    return 500 + ((income - 10000) / 1000 * 50);
            }
        }
    }
}


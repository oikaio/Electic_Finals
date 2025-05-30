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
    public partial class Prelim_Exam : Form
    {
        double basic=0, envi, totalcurrent , govermenttax , totaldue , paymentduedate , servicecharge ,consumption,discount = 0.2, a= 23.53, consump, maintenance = 1.53;
        double govtax = 0.25,totalamountdue;

                public Prelim_Exam()
        {
            InitializeComponent();
            



        }

        private void Prelim_Exam_Load(object sender, EventArgs e)
        {
            envirochargetxtbox.Enabled = false;
            basicchargetxtbox.Enabled = false;
            totalamountduetxtbox.Enabled = false;
            govermentchargetxtbox.Enabled = false;
            listBox1.Enabled = false;

            paymentduetxtbox.Text = " M/D/Y ";
            readingdatetxtbox.Text = " M/D/Y ";
            this.WindowState = FormWindowState.Maximized;


        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void printbut_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
            listBox1.Items.Add("                                                                               RECIEPT                                                                                                            " );
            listBox1.Items.Add(" ");
            listBox1.Items.Add(" ");
            listBox1.Items.Add(" ");
            listBox1.Items.Add(" ");
            listBox1.Items.Add("Contract account number: " + contractacctxtbox.Text);
            listBox1.Items.Add("Account name: " + acctxtbox.Text);
            listBox1.Items.Add("service address: " + servicetxtbox.Text);
            listBox1.Items.Add("TIN: " + tintxtbox.Text);
            listBox1.Items.Add("Rate class: " + rateclasstxtbox.Text);
            listBox1.Items.Add("Business area: " + busaretxtbox.Text);
            listBox1.Items.Add(" ");
            listBox1.Items.Add(" ");

            listBox1.Items.Add("------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
            listBox1.Items.Add(" ");
            listBox1.Items.Add("                                       Meter no: " + metertxtbox.Text + "                    " + " MRU no: " + mrutxtbox.Text + "                    " + "seq no: " + seqtxtbox.Text);
            listBox1.Items.Add(" ");
            listBox1.Items.Add("Reading date: " + readingdatetxtbox.Text);
            listBox1.Items.Add("Present reading: " + presentreadingtxtbox.Text);
            listBox1.Items.Add("Previous reading: " + previousreadingtxtbox.Text);
            listBox1.Items.Add("Consumption (cu.m) : " + consumptiontxtbox.Text);
            listBox1.Items.Add(" ");
            listBox1.Items.Add(" ");
            listBox1.Items.Add("------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
            listBox1.Items.Add("Billing Period:   " + presentdate.Text + " TO "+ enddate.Text);
            listBox1.Items.Add("Current change: " + currentchangetxtbox.Text);
            listBox1.Items.Add("basic charger: " + basicchargetxtbox.Text);
            listBox1.Items.Add("Environtmental Charges (20% of basic charge): " + envirochargetxtbox.Text);
            listBox1.Items.Add("maintenance service:  1.53");
            listBox1.Items.Add("Total Current Charge Before taxes:  " + totalcurrenttxtbox.Text);
            listBox1.Items.Add("Government taxes : " + govermentchargetxtbox.Text);
            listBox1.Items.Add(" ");
            listBox1.Items.Add("------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");

            listBox1.Items.Add("Total amount due : " + totalamountduetxtbox.Text);
            listBox1.Items.Add("total amount date: " + paymentduetxtbox.Text);
            listBox1.Items.Add("------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
            listBox1.Items.Add(" ");
            listBox1.Items.Add(" ");

            Display_prelim print1 = new Display_prelim();
            print1.priDisplayListbox.Items.AddRange(this.listBox1.Items);
            
            print1.Show();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label35_Click(object sender, EventArgs e)
        {

        }

        private void basicchargetxtbox_TextChanged(object sender, EventArgs e)
        {
            basic = Convert.ToDouble(basicchargetxtbox.Text);
            envi = basic * discount;
            envirochargetxtbox.Text = Convert.ToString(envi);
            totalcurrent = basic + envi + maintenance;
            totalcurrenttxtbox.Text = Convert.ToString(totalcurrent);
            govermenttax = totalcurrent * govtax;
            govermentchargetxtbox.Text= Convert.ToString(govermenttax);
            totalamountdue = govermenttax + totalcurrent;
            totalamountduetxtbox.Text = Convert.ToString(totalamountdue);
            currentchangetxtbox.Text = Convert.ToString(totalamountdue);
        }
            

        private void envirochargetxtbox_TextChanged(object sender, EventArgs e)
        {

            envi = Convert.ToDouble(envirochargetxtbox.Text);



        }

        private void button1_Click(object sender, EventArgs e)
        {


            

            //totalcurrent = basic + envi + maintenance;
            totaldue = totalcurrent + govermenttax;
            govermenttax = totalcurrent * 0.025;

            
            
            totalcurrenttxtbox.Text = Convert.ToString(totalcurrent);
            envirochargetxtbox.Text = Convert.ToString(envi);




        }

        private void consumptiontxtbox_TextChanged(object sender, EventArgs e)
        {
            consumption = Convert.ToDouble(consumptiontxtbox.Text);
            consump = 23.52 * consumption;
            basicchargetxtbox.Text = Convert.ToString(consump);

        }

        private void maintenanceservicechargetxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void paymentduetxtbox_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void totalamountduetxtbox_TextChanged(object sender, EventArgs e)
        {
            totaldue = Convert.ToDouble(totalamountduetxtbox.Text);

        }

        private void govermentchargetxtbox_TextChanged(object sender, EventArgs e)
        {
            
            govermenttax = Convert.ToDouble(govermentchargetxtbox.Text);
            

        }

        private void label36_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void totalcurrenttxtbox_TextChanged(object sender, EventArgs e)
        {
            

        }
    }
}

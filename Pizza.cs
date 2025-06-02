using AForge.Video.DirectShow;
using AForge.Video;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace New_POS_Application
{
    public partial class f2: Form
    {
        double price, cash_given, change, total_amountPaid, discounted_amount, discount_amount, total_qty, totaldiscount_amt, totaldiscounted_amt,lahat;
        decimal remainingCash = 0;
        int qty;

        private FilterInfoCollection filterInfoCollection;
        private VideoCaptureDevice captureDevice;
        public f2()
        {
            InitializeComponent();
        }

        private void f2_Load(object sender, EventArgs e)
        {

            //disable the textboxs
            this.WindowState = FormWindowState.Maximized;
            priceTxtBox.Enabled = false;
            discountAmountTxtBox.Enabled = false;
            changeTxtBox.Enabled = false;
            totalBillsTxtBox.Enabled = false;
            discountedAmountTxtBox.Enabled = false;
            totalQtyTxtBox.Enabled = false;
            discountedAmountTxtBox.Enabled= false;
            discountAmountTxtBox.Enabled = false;
            discount_totaltxtbox.Enabled = false;
            qtyTextbox.Enabled = false ;

            checkBox3.Text = "Pizzueea";
            checkBox4.Text = "Margherita Pizza";
            checkBox5.Text = "Pepperoni Pizza";
            checkBox6.Text = "BBQ Chicken Pizza";
            checkBox7.Text = "Hawaiian Pizza";
            checkBox8.Text = "Four Cheese Pizza";
            checkBox9.Text = "Veggie Supreme Pizza";
            checkBox10.Text = "Meat Lover's Pizza";
            checkBox11.Text = "Buffalo Chicken Pizza";
            checkBox12.Text = "Truffle Mushroom Pizza";
            checkBox13.Text = "Seafood Pizza";
            checkBox14.Text = "White Garlic Pizza";
            checkBox15.Text = "Taco Pizza";
            checkBox16.Text = "Stuffed Crust Pizza";
            checkBox17.Text = "Neapolitan Pizza";
            checkBox18.Text = "Chicago Deep Dish Pizza";
            checkBox19.Text = "Detroit-Style Pizza";
            checkBox20.Text = "Sicilian Pizza";
            checkBox21.Text = "Calzone Pizza";
            checkBox22.Text = "Breakfast Pizza";

            //disabling check box
            A_CokeCheckBox.Enabled = false;
            A_FriedChickencheckBox.Enabled = false;
            A_FriescheckBox.Enabled = false;
            A_sideDishCheckBox.Enabled = false;
            A_SpecialPizaChechBox.Enabled = false;
            B_carbonarachechBox.Enabled = false;
            B_ChickencheckBox.Enabled = false;
            B_FriescheckBox.Enabled = false;
            B_halohalocheckbox.Enabled = false;
            B_HawaiianchechBox.Enabled = false;

            pictureBox1.Image = Image.FromFile("C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\images\\pizza\\za.jfif");
            pictureBox2.Image = Image.FromFile("C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\images\\pizza\\zazzaza.jfif");
            pictureBox3.Image = Image.FromFile("C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\images\\pizza\\is.jfif");
            pictureBox4.Image = Image.FromFile("C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\images\\pizza\\qq.jfif");
            pictureBox5.Image = Image.FromFile("C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\images\\pizza\\bb.jfif");
            pictureBox6.Image = Image.FromFile("C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\images\\pizza\\vv.jfif");
            pictureBox7.Image = Image.FromFile("C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\images\\pizza\\xx.jfif");
            pictureBox8.Image = Image.FromFile("C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\images\\pizza\\sx.jfif");
            pictureBox9.Image = Image.FromFile("C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\images\\pizza\\awa.jfif");
            pictureBox10.Image = Image.FromFile("C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\images\\pizza\\da.jfif");
            pictureBox11.Image = Image.FromFile("C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\images\\pizza\\ww.jfif");
            pictureBox12.Image = Image.FromFile("C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\images\\pizza\\za.jfif");
            pictureBox13.Image = Image.FromFile("C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\images\\pizza\\zazzaza.jfif");
            pictureBox14.Image = Image.FromFile("C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\images\\pizza\\is.jfif");
            pictureBox15.Image = Image.FromFile("C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\images\\pizza\\qq.jfif");
            pictureBox16.Image = Image.FromFile("C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\images\\pizza\\bb.jfif");
            pictureBox17.Image = Image.FromFile("C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\images\\pizza\\vv.jfif");
            pictureBox18.Image = Image.FromFile("C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\images\\pizza\\xx.jfif");
            pictureBox19.Image = Image.FromFile("C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\images\\pizza\\sx.jfif");
            pictureBox20.Image = Image.FromFile("C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\images\\pizza\\ww.jfif");


            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filter in filterInfoCollection)
            comboBox1.Items.Add(filter.Name);
            comboBox1.SelectedIndex = 0;
            captureDevice = new VideoCaptureDevice();

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {

        }

        private void changetxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void quantitytxtbox_TextChanged(object sender, EventArgs e)
        {


            try
            {
                if (qtyTextbox.Text != "")
                {
                    qty = Convert.ToInt32(qtyTextbox.Text);


                }
                else
                {
                    qty = 0;
                }

                Discountbtn.Checked = false;
                Nodiscountbtn.Checked = false;

                total_qty += qty;
                totalQtyTxtBox.Text = Convert.ToString(total_qty);

                discount_totaltxtbox.Text = Convert.ToString(totaldiscount_amt);
                totalBillsTxtBox.Text = Convert.ToString(totaldiscounted_amt);

                displayListbox.Items.Add(totalBillsTxtBox.Text);
               

            }
            catch 
            {
                MessageBox.Show("Invalid Input: Please enter the correct Quantity", "Message");
            }


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void name1lbl_Click(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            priceTxtBox.Text = "550.00"; ;
            price = Convert.ToDouble(priceTxtBox.Text);
            displayListbox.Items.Add(checkBox4.Text);
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox19_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            priceTxtBox.Text = "500.99";
            price = Convert.ToDouble(priceTxtBox.Text);
            displayListbox.Items.Add(checkBox3.Text);
        }

        private void pricetextbox_TextChanged(object sender, EventArgs e)
        {
            //price = Convert.ToDouble(priceTxtBox.Text);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void changeTxtBox_TextChanged_1(object sender, EventArgs e)
        {

        }

        public void button5_Click(object sender, EventArgs e)
        {
            Activity4_PrintFrm print = new Activity4_PrintFrm();
            print.printDisplayListbox.Items.AddRange(this.displayListbox.Items);
            print.Show();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

           //discountAmountTxtBox.Text = "0.00";
            priceTxtBox.Text = "500.99";
            price = Convert.ToDouble(priceTxtBox.Text);
            displayListbox.Items.Add(checkBox3.Text);
            //qtyTextbox.Text = "0";
            //qtyTextbox.Focus();
          
            qtyTextbox.Clear();
            discountAmountTxtBox.Clear();
            discountedAmountTxtBox.Clear();
            totalBillsTxtBox.Clear();
            discount_totaltxtbox.Clear();
            qtyTextbox.Enabled = false;

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //discountAmountTxtBox.Text = "0.00";
            priceTxtBox.Text = "550.00"; ;
            price = Convert.ToDouble(priceTxtBox.Text);
            displayListbox.Items.Add(checkBox4.Text );
           /// qtyTextbox.Text = "0";
            //qtyTextbox.Focus();
            
            qtyTextbox.Clear();
            discountAmountTxtBox.Clear();
            discountedAmountTxtBox.Clear();
            totalBillsTxtBox.Clear();
            discount_totaltxtbox.Clear();
            qtyTextbox.Enabled = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //discountAmountTxtBox.Text = "0.00";
            priceTxtBox.Text = "600.99";
            price = Convert.ToDouble(priceTxtBox.Text);
            displayListbox.Items.Add(checkBox5.Text);
            //qtyTextbox.Text = "0";
            //qtyTextbox.Focus();
       
            qtyTextbox.Clear();
            discountAmountTxtBox.Clear();
            discountedAmountTxtBox.Clear();
            totalBillsTxtBox.Clear();
            discount_totaltxtbox.Clear();
            qtyTextbox.Enabled = false;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            //discountAmountTxtBox.Text = "60 .00";
            priceTxtBox.Text = "700.99";
            price = Convert.ToDouble(priceTxtBox.Text);
            //displayListbox.Items.Add(checkBox6.Text + "" + priceTxtBox.Text);
            //qtyTextbox.Text = "0";
            //qtyTextbox.Focus();
          
            qtyTextbox.Clear();
            discountAmountTxtBox.Clear();
            discountedAmountTxtBox.Clear();
            totalBillsTxtBox.Clear();
            discount_totaltxtbox.Clear();
            qtyTextbox.Enabled = false;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            //discountAmountTxtBox.Text = "0.00";
            priceTxtBox.Text = "500.99";
            price = Convert.ToDouble(priceTxtBox.Text);
            displayListbox.Items.Add(checkBox7.Text);
            // qtyTextbox.Text = "0";
            //qtyTextbox.Focus();
        
            qtyTextbox.Clear();
            discountAmountTxtBox.Clear();
            discountedAmountTxtBox.Clear();
            totalBillsTxtBox.Clear();
            discount_totaltxtbox.Clear();
            qtyTextbox.Enabled = false;
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
           // discountAmountTxtBox.Text = "0.00";
            priceTxtBox.Text = "550.99";
            price = Convert.ToDouble(priceTxtBox.Text);
            //displayListbox.Items.Add(checkBox8.Text + "" + priceTxtBox.Text);
            //qtyTextbox.Text = "0";
            //qtyTextbox.Focus();
      
            qtyTextbox.Clear();
            discountAmountTxtBox.Clear();
            discountedAmountTxtBox.Clear();
            totalBillsTxtBox.Clear();
            discount_totaltxtbox.Clear();
            qtyTextbox.Enabled = false;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            //discountAmountTxtBox.Text = "0.00";
            priceTxtBox.Text = "400.99";
            price = Convert.ToDouble(priceTxtBox.Text);
            //  displayListbox.Items.Add(checkBox9.Text + "" + priceTxtBox.Text);
            //  qtyTextbox.Text = "0";
            // qtyTextbox.Focus();
       
            qtyTextbox.Clear();
            discountAmountTxtBox.Clear();
            discountedAmountTxtBox.Clear();
            totalBillsTxtBox.Clear();
            discount_totaltxtbox.Clear();
            qtyTextbox.Enabled = false;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
           // discountAmountTxtBox.Text = "0.00";
            priceTxtBox.Text = "200.99";
            price = Convert.ToDouble(priceTxtBox.Text);
            displayListbox.Items.Add(checkBox10.Text );
            //qtyTextbox.Text = "0";
            //qtyTextbox.Focus();

            qtyTextbox.Clear();
            discountAmountTxtBox.Clear();
            discountedAmountTxtBox.Clear();
            totalBillsTxtBox.Clear();
            discount_totaltxtbox.Clear();
            qtyTextbox.Enabled = false;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
           // discountAmountTxtBox.Text = "0.00";
            priceTxtBox.Text = "300.99";
            price = Convert.ToDouble(priceTxtBox.Text);
            displayListbox.Items.Add(checkBox11.Text );
            //qtyTextbox.Text = "0";
            //qtyTextbox.Focus();

            qtyTextbox.Clear();
            discountAmountTxtBox.Clear();
            discountedAmountTxtBox.Clear();
            totalBillsTxtBox.Clear();
            discount_totaltxtbox.Clear();
            qtyTextbox.Enabled = false;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
         
               // discountAmountTxtBox.Text = "0.00";
                priceTxtBox.Text = "350.99";
                price = Convert.ToDouble(priceTxtBox.Text);
            displayListbox.Items.Add(checkBox12.Text);
            // qtyTextbox.Text = "0";
            // qtyTextbox.Focus();
   
            qtyTextbox.Clear();
            discountAmountTxtBox.Clear();
            discountedAmountTxtBox.Clear();
            totalBillsTxtBox.Clear();
            discount_totaltxtbox.Clear();
            qtyTextbox.Enabled = false;

        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            //discountAmountTxtBox.Text = "0.00";
            priceTxtBox.Text = "550.99";
            price = Convert.ToDouble(priceTxtBox.Text);
            displayListbox.Items.Add(checkBox13.Text );
            // qtyTextbox.Text = "0";
            // qtyTextbox.Focus();
 
            qtyTextbox.Clear();
            discountAmountTxtBox.Clear();
            discountedAmountTxtBox.Clear();
            totalBillsTxtBox.Clear();
            discount_totaltxtbox.Clear();
            qtyTextbox.Enabled = false;
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
           // discountAmountTxtBox.Text = "0.00";
            priceTxtBox.Text = "505.99";
            price = Convert.ToDouble(priceTxtBox.Text);
            displayListbox.Items.Add(checkBox14.Text);
            // qtyTextbox.Text = "0";
            // qtyTextbox.Focus();
         
            qtyTextbox.Clear();
            discountAmountTxtBox.Clear();
            discountedAmountTxtBox.Clear();
            totalBillsTxtBox.Clear();
            discount_totaltxtbox.Clear();
            qtyTextbox.Enabled = false;
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
           // discountAmountTxtBox.Text = "0.00";
            priceTxtBox.Text = "150.99";
            price = Convert.ToDouble(priceTxtBox.Text);
             displayListbox.Items.Add(checkBox15.Text );
            // qtyTextbox.Text = "0";
            //qtyTextbox.Focus();
         
            qtyTextbox.Clear();
            discountAmountTxtBox.Clear();
            discountedAmountTxtBox.Clear();
            totalBillsTxtBox.Clear();
            discount_totaltxtbox.Clear();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            //discountAmountTxtBox.Text = "0.00";
            priceTxtBox.Text = "250.99";
            price = Convert.ToDouble(priceTxtBox.Text);
            displayListbox.Items.Add(checkBox16.Text  );
            // qtyTextbox.Text = "0";
            //  qtyTextbox.Focus();
           
            qtyTextbox.Clear();
            discountAmountTxtBox.Clear();
            discountedAmountTxtBox.Clear();
            totalBillsTxtBox.Clear();
            discount_totaltxtbox.Clear();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
          //  discountAmountTxtBox.Text = "0.00";
            priceTxtBox.Text = "440.99";
            price = Convert.ToDouble(priceTxtBox.Text);
            displayListbox.Items.Add(checkBox17.Text );
            //qtyTextbox.Text = "0";
            // qtyTextbox.Focus();
            
            qtyTextbox.Clear();
            discountAmountTxtBox.Clear();
            discountedAmountTxtBox.Clear();
            totalBillsTxtBox.Clear();
            discount_totaltxtbox.Clear();
            qtyTextbox.Enabled = false;
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            //  discountAmountTxtBox.Text = "0.00";
            priceTxtBox.Text = "344";
            price = Convert.ToDouble(priceTxtBox.Text);
             displayListbox.Items.Add(checkBox18.Text );
            //  qtyTextbox.Text = "0";
            //qtyTextbox.Focus();
            priceTxtBox.Clear();
            qtyTextbox.Clear();
            discountAmountTxtBox.Clear();
            discountedAmountTxtBox.Clear();
            totalBillsTxtBox.Clear();
            discount_totaltxtbox.Clear();
            qtyTextbox.Enabled = false;
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
           // discountAmountTxtBox.Text = "0.00";
            priceTxtBox.Text = "330.99";
            price = Convert.ToDouble(priceTxtBox.Text);
            // displayListbox.Items.Add(checkBox19.Text + "" + priceTxtBox.Text);
            // qtyTextbox.Text = "0";
            // qtyTextbox.Focus();

            qtyTextbox.Clear();
            discountAmountTxtBox.Clear();
            discountedAmountTxtBox.Clear();
            totalBillsTxtBox.Clear();
            discount_totaltxtbox.Clear();
            qtyTextbox.Enabled = false;
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            //discountAmountTxtBox.Text = "0.00";
            priceTxtBox.Text = "510.99";
            price = Convert.ToDouble(priceTxtBox.Text);
            displayListbox.Items.Add(checkBox21.Text );
            //qtyTextbox.Text = "0";
            //qtyTextbox.Focus();
           
            qtyTextbox.Clear();
            discountAmountTxtBox.Clear();
            discountedAmountTxtBox.Clear();
            totalBillsTxtBox.Clear();
            discount_totaltxtbox.Clear();
            qtyTextbox.Enabled = false;
        }

        private void pictureBox16_Click_1(object sender, EventArgs e)
        {
            discountAmountTxtBox.Text = "0.00";
            priceTxtBox.Text = "210.99";
            price = Convert.ToDouble(priceTxtBox.Text);

            
            qtyTextbox.Clear();
            discountAmountTxtBox.Clear();
            discountedAmountTxtBox.Clear();
            totalBillsTxtBox.Clear();
            discount_totaltxtbox.Clear();
            qtyTextbox.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (cash_given == 0)
                {
                    cash_given = Convert.ToDouble(cashGivenTxtBox.Text);
                }

                // Calculate remaining cash after order
                double remainingCash = cash_given - totaldiscounted_amt;

                if (remainingCash >= 0) // If user has enough money
                {
                    cash_given = remainingCash; // Update cash for next order
                    changeTxtBox.Text = "₱" + cash_given.ToString("N2"); // Show remaining cash

                    // Display order details
                    displayListbox.Items.Add("Total Bills: ₱" + totaldiscounted_amt.ToString("N2"));
                    displayListbox.Items.Add("Cash Before Order: ₱" + (cash_given + totaldiscounted_amt).ToString("N2"));
                    displayListbox.Items.Add("Remaining Cash: " + changeTxtBox.Text);
                    displayListbox.Items.Add("Total No. of Items: " + total_qty);

                    // Set remaining cash as new money for the next order
                    cashGivenTxtBox.Text = cash_given.ToString();
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

        private void cashGivenTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void totalBillsTxtBox_TextChanged(object sender, EventArgs e)
        {
            //displayListbox.Items.Add(totalBillsTxtBox.Text);


        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void displayListbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox27_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox23_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox30_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox24_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void discountAmountTxtBox_TextChanged(object sender, EventArgs e)
        {

  
        }

        private void totalQtyTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Discount_CheckedChanged(object sender, EventArgs e)
        {
            
            if (Discountbtn.Enabled)
            {
                discount_amount = (price * 0.15);
                discounted_amount = price-discount_amount;
                totaldiscount_amt = discount_amount * qty;
                totaldiscounted_amt = (price*qty) - totaldiscount_amt;

                discountAmountTxtBox.Text = Convert.ToString(discount_amount);
                discountedAmountTxtBox.Text = Convert.ToString(discounted_amount);

                Nodiscountbtn.Checked = false;
            }
            qtyTextbox.Enabled = true;

         

        }

        private void Nodiscountbtn_CheckedChanged(object sender, EventArgs e)
        {
            if (Nodiscountbtn.Enabled)
            {
                discount_amount = 0;
                discounted_amount = 0;
                totaldiscounted_amt = price * qty;
                totaldiscount_amt = 0;
              
                discountAmountTxtBox.Text = Convert.ToString(discount_amount);
                discountedAmountTxtBox.Text = Convert.ToString(discounted_amount);




            }
            qtyTextbox.Enabled = true;

        }


        private void discountedAmountTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void discount_totaltxtbox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox29_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void CaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap frame = (Bitmap)eventArgs.Frame.Clone();
            pictureBox21.Image = frame;
        }
        private void captureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox21.Image = (Bitmap)eventArgs.Frame.Clone();

        }
        private void button6_Click(object sender, EventArgs e)
        {
            captureDevice.NewFrame += CaptureDevice_NewFrame;
            captureDevice = new VideoCaptureDevice(filterInfoCollection[comboBox1.SelectedIndex].MonikerString);
            captureDevice.NewFrame += new NewFrameEventHandler(captureDevice_NewFrame);
            captureDevice.Start();
            scantimer.Start();



            if (pictureBox21.Image == null)
            {
                
                return;
            }

            Bitmap bitmap = new Bitmap(pictureBox21.Image);
            BarcodeReader reader = new BarcodeReader();
            Result result = reader.Decode(bitmap);

        }

        private void scantimer_Tick(object sender, EventArgs e)
        {
            try
            {


                if (pictureBox21.Image != null)
                {


                    BarcodeReader reader = new BarcodeReader();
                    Result result = reader.Decode((Bitmap)pictureBox21.Image);

                    if (result != null)
                    {
                        cashGivenTxtBox.Text = result.Text;
                       // MessageBox.Show("QR Code Decoded: " + result.Text, "Success");
                        scantimer.Stop();
                        if (captureDevice.IsRunning)
                            captureDevice.Stop();

                    }


                }

            }
            catch
            {
                MessageBox.Show("Can not scan", "Warning!");
            }

        }

        private void f2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (captureDevice != null && captureDevice.IsRunning)
                captureDevice.Stop();
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            priceTxtBox.Text = "600.99";
            price = Convert.ToDouble(priceTxtBox.Text);
            displayListbox.Items.Add(checkBox5.Text);
        }

        private void checkBox28_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.BlueViolet;
            foodBRdbtn.Checked = false;
            pictureBox21.Image = Image.FromFile("C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\images\\pizza\\arr.jfif");
            A_FriedChickencheckBox.Enabled = true;
            A_FriescheckBox.Enabled = true;
            A_sideDishCheckBox.Enabled = true;
            A_SpecialPizaChechBox.Enabled = true;
            A_CokeCheckBox.Enabled = true;

            B_carbonarachechBox.Enabled = false;
            B_ChickencheckBox.Enabled = false;
            B_FriescheckBox.Enabled = false;
            B_halohalocheckbox.Enabled = false;
            B_HawaiianchechBox.Enabled = false;


            priceTxtBox.Text = "1,000.00";
            discountAmountTxtBox.Text = "200.00";
            discountedAmountTxtBox.Text = "800";
            discount_totaltxtbox.Text = "200.00";
            totalBillsTxtBox.Text = "800";


            discount_amount = Convert.ToDouble(discountAmountTxtBox.Text);
            discounted_amount = Convert.ToDouble(discountedAmountTxtBox.Text);
            totaldiscounted_amt = Convert.ToDouble(discount_totaltxtbox.Text);
            totalBillsTxtBox.Text = Convert.ToString(totalBillsTxtBox.Text);
            price = Convert.ToDouble(priceTxtBox.Text);
            displayListbox.Items.Add(foodARdbtn.Text);
            displayListbox.Items.Add("     Discount Amount: " + " " + totalBillsTxtBox.Text);
            qtyTextbox.Text = "0";
            qtyTextbox.Focus();

        }

        private void foodBRdbtn_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Maroon;
            foodARdbtn.Checked = false;
            pictureBox21.Image = Image.FromFile("C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\images\\pizza\\brr.jfif");

            A_CokeCheckBox.Enabled = false;
            A_FriedChickencheckBox.Enabled = false;
            A_FriescheckBox.Enabled = false;
            A_sideDishCheckBox.Enabled = false;
            A_SpecialPizaChechBox.Enabled = false;

            B_carbonarachechBox.Enabled = true;
            B_ChickencheckBox.Enabled = true;
            B_FriescheckBox.Enabled = true;
            B_halohalocheckbox.Enabled = true;
            B_HawaiianchechBox.Enabled = true;


            priceTxtBox.Text = "1,299.00";
            discountAmountTxtBox.Text = "(15% of the price)194.85";
            
            price = Convert.ToDouble(priceTxtBox.Text);
            displayListbox.Items.Add(foodBRdbtn.Text);

        }



     


        



        private void name9lbl_Click(object sender, EventArgs e)
        {

        }

        private void name7lbl_Click(object sender, EventArgs e)
        {
            discountAmountTxtBox.Text = "0.00";
            priceTxtBox.Text = "520.99";
            price = Convert.ToDouble(priceTxtBox.Text);
            displayListbox.Items.Add(checkBox20.Text);
            qtyTextbox.Text = "0";
            qtyTextbox.Focus();
          
            qtyTextbox.Clear();
            discountAmountTxtBox.Clear();
            discountedAmountTxtBox.Clear();
            totalBillsTxtBox.Clear();
            discount_totaltxtbox.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                displayListbox.Items.RemoveAt(displayListbox.SelectedIndex);
            }
            catch
            {
                MessageBox.Show("Click an order to Remove","Warning");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // wait alin dito yon yowyoywy owyung nasa pinaka left na 
            //code for inserting default image inside the picturebox
           //pictureBox21.Image = Image.FromFile("C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\images\\pizza\\pza.jfif");

            A_CokeCheckBox.Checked = false;
            A_FriedChickencheckBox.Checked = false;
            A_FriescheckBox.Checked = false;
            A_sideDishCheckBox.Checked = false;
            A_SpecialPizaChechBox.Checked = false;
            B_carbonarachechBox.Checked = false;
            B_ChickencheckBox.Checked = false;
            B_FriescheckBox.Checked = false;
            B_halohalocheckbox.Checked = false;
            B_HawaiianchechBox.Checked = false;
            //codes for clearing the textboxes
            priceTxtBox.Clear();
            qtyTextbox.Clear();
            cashGivenTxtBox.Clear();
            cashGivenTxtBox.Clear();
            totalBillsTxtBox.Clear();
            totalQtyTxtBox.Clear();
            discountedAmountTxtBox.Clear();
            changeTxtBox.Clear();
            discountedAmountTxtBox.Clear();
            totalQtyTxtBox.Clear();
            discount_totaltxtbox.Clear();
            Discountbtn.Checked = false;
            Nodiscountbtn.Checked = false;

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
            checkBox21.Checked = false;
            checkBox22.Checked = false;
            //removing the contents of a listbox
            displayListbox.Items.Clear();
        }
        mali to i transfered this one to the left one
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter_1(object sender, EventArgs e)
        {

        }
    }
}

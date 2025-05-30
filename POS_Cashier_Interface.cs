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
using AForge.Video.DirectShow;
using AForge.Video;
namespace New_POS_Application
{

    public partial class POS_Cashier_Interface : Form
    {

        string q, w, ee, r, t, y, u, i, o, p, a, s, d, f, g, h, j, k, l, z;

        int qty = 1, totalqty, price;

        double senior = 0.15, pwd = 0.10, emp = 0.08;
        double discountammount ;
        double discountedammount ;
        double totaldiscountgiven ;
        double totaldiscountedgiven;
        double cash, change,totalprice;

        private FilterInfoCollection filterInfoCollection;
        private VideoCaptureDevice captureDevice;
        private Timer scanTimer;



        private void CaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap frame = (Bitmap)eventArgs.Frame.Clone();
            cameraBox.Image = frame;
        }
        private void itemnametxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

            itemnametxtbox.Text = name2lbl.Text;
            pricetextbox.Text = w;

        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            pricetextbox.Text = ee;
            itemnametxtbox.Text = name3lbl.Text;


        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            pricetextbox.Text = r;
            itemnametxtbox.Text = name4lbl.Text;


        }

        private void pictureBox5_Click_1(object sender, EventArgs e)
        {
            pricetextbox.Text = t;
            itemnametxtbox.Text = name5lbl.Text;

        }


        private void pictureBox6_Click(object sender, EventArgs e)
        {
            pricetextbox.Text = y;
            itemnametxtbox.Text = name6lbl.Text;

        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            pricetextbox.Text = a;
            itemnametxtbox.Text = name15lbl.Text;

        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            pricetextbox.Text = s;
            itemnametxtbox.Text = name14lbl.Text;

        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            pricetextbox.Text = d;
            itemnametxtbox.Text = name13lbl.Text;

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            pricetextbox.Text = f;
            itemnametxtbox.Text = name12lbl.Text;

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            pricetextbox.Text = g;
            itemnametxtbox.Text = name11lbl.Text;

        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            pricetextbox.Text = h;
            itemnametxtbox.Text = name20lbl.Text;
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            pricetextbox.Text = j;
            itemnametxtbox.Text = name19lbl.Text;

        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            pricetextbox.Text = k;
            itemnametxtbox.Text = name18lbl.Text;

        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            pricetextbox.Text = l;
            itemnametxtbox.Text = name17lbl.Text;

        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            pricetextbox.Text = z;
            itemnametxtbox.Text = name16lbl.Text;

        }

        private void pricetextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void qty_totaltxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click_1(object sender, EventArgs e)
        {
            pricetextbox.Text = u;
            itemnametxtbox.Text = name7lbl.Text;
        }

        private void cashre_renderedtxtbox_TextChanged(object sender, EventArgs e)
        {

        }

 
        private void discounttxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {

        }

        private void quantitytxtbox_TextChanged(object sender, EventArgs e)
        {

        }



        private void discount_totaltxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void disconted_totaltxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void calcbtn_Click_1(object sender, EventArgs e)
        {
            try
            {
                cash = Convert.ToDouble(cashre_renderedtxtbox.Text);
                if (cash > totaldiscountedgiven)
                {
                    change = cash - totaldiscountedgiven;
                    totalqty += qty;
                    MessageBox.Show("Transaction Completed");


                    cashre_renderedtxtbox.Text = change.ToString();

                    changetxtbox.Text = change.ToString();
                    qty_totaltxtbox.Text = totalqty.ToString();


                    disconted_totaltxtbox.ResetText();
                    discount_totaltxtbox.ResetText();
                    discounttxtbox.ResetText();
                    discountedtxtbox.ResetText();

                    radioButton1.Checked = false;
                    regularRbtn.Checked = false;
                    EmployeeRdbtn.Checked = false;
                    noTaxRdbtn.Checked = false;
                }
                else
                {
                    MessageBox.Show("Insufficient Cash");


                    cashre_renderedtxtbox.Clear();

                    disconted_totaltxtbox.ResetText();
                    discount_totaltxtbox.ResetText();
                    discounttxtbox.ResetText();
                }
            }
            catch
            {
                MessageBox.Show("Invalid Input: Please enter the correct Amount","Message");
            }



        }

        private void qty_totaltxtbox_TextChanged_1(object sender, EventArgs e)
        {
            if (quantitytxtbox.Text != "")
            {
                qty = Convert.ToInt32(quantitytxtbox.Text);
            }
            else
            {
                qty = 0;
            }
        }

        private void pictureBox2_Click_2(object sender, EventArgs e)
        {
            itemnametxtbox.Text = name2lbl.Text;
            pricetextbox.Text = w;
        }

        private void pictureBox3_Click_2(object sender, EventArgs e)
        {
            itemnametxtbox.Text = name3lbl.Text;
            pricetextbox.Text = ee;
        }

        private void pictureBox4_Click_2(object sender, EventArgs e)
        {
            itemnametxtbox.Text = name4lbl.Text;
            pricetextbox.Text = r;
        }

        private void pictureBox5_Click_2(object sender, EventArgs e)
        {
            itemnametxtbox.Text = name5lbl.Text;
            pricetextbox.Text = t;
        }

        private void pictureBox10_Click_1(object sender, EventArgs e)
        {
            itemnametxtbox.Text = name6lbl.Text;
            pricetextbox.Text = y;
        }

        private void pictureBox9_Click_1(object sender, EventArgs e)
        {
            itemnametxtbox.Text = name7lbl.Text;
            pricetextbox.Text = u;
        }

        private void pictureBox8_Click_1(object sender, EventArgs e)
        {
            itemnametxtbox.Text = name8lbl.Text;
            pricetextbox.Text = i;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = name9lbl.Text;
            pricetextbox.Text = o;
        }

        private void pictureBox6_Click_1(object sender, EventArgs e)
        {
            itemnametxtbox.Text = name10lbl.Text;
            pricetextbox.Text = p;
        }

        private void pictureBox15_Click_1(object sender, EventArgs e)
        {
            itemnametxtbox.Text = name11lbl.Text;
            pricetextbox.Text = a;
        }

        private void pictureBox14_Click_1(object sender, EventArgs e)
        {
            itemnametxtbox.Text = name12lbl.Text;
            pricetextbox.Text = s;
        }

        private void pictureBox13_Click_1(object sender, EventArgs e)
        {
            itemnametxtbox.Text = name13lbl.Text;
            pricetextbox.Text = d;
        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                discountammount = (price * senior);  
                totaldiscountgiven = discountammount * qty;  
                totaldiscountedgiven = (qty * price) - totaldiscountgiven;
                discountedammount = price - discountammount;

                EmployeeRdbtn.Checked = false;
                regularRbtn.Checked = false;
                noTaxRdbtn.Checked = false;

                discounttxtbox.Text = Convert.ToString(discountammount);
                discountedtxtbox.Text = Convert.ToString(discountedammount);
                disconted_totaltxtbox.Text = Convert.ToString(totaldiscountedgiven);
                discount_totaltxtbox.Text = Convert.ToString(totaldiscountgiven);
                
            }

        }

        private void noTaxRdbtn_CheckedChanged_1(object sender, EventArgs e)
        {
            if (noTaxRdbtn.Checked)
            {
                discountammount = (price * senior);
                totaldiscountgiven = discountammount * qty;
                totaldiscountedgiven = (qty * price) - totaldiscountgiven;
                discountedammount = price - discountammount;


                radioButton1.Checked = false;
                regularRbtn.Checked = false;
                EmployeeRdbtn.Checked = false;

                discounttxtbox.Text = Convert.ToString(discountammount);
                discountedtxtbox.Text = Convert.ToString(discountedammount);
                disconted_totaltxtbox.Text = Convert.ToString(totaldiscountedgiven);
                discount_totaltxtbox.Text = Convert.ToString(totaldiscountgiven);
             
            }


        }

        private void EmployeeRdbtn_CheckedChanged(object sender, EventArgs e)
        {
            if (EmployeeRdbtn.Checked)
            {
                discountammount = (price * senior);
                totaldiscountgiven = discountammount * qty;
                totaldiscountedgiven = (qty * price) - totaldiscountgiven;
                discountedammount = price - discountammount;

                radioButton1.Checked = false;
                regularRbtn.Checked = false;
                noTaxRdbtn.Checked = false;

                discounttxtbox.Text = Convert.ToString(discountammount);
                discountedtxtbox.Text = Convert.ToString(discountedammount);
                disconted_totaltxtbox.Text = Convert.ToString(totaldiscountedgiven);
                discount_totaltxtbox.Text = Convert.ToString(totaldiscountgiven);

            }


        }

        private void regularRbtn_CheckedChanged(object sender, EventArgs e)
        {
            if (regularRbtn.Checked)
            {
                discountammount = (price * senior);
                totaldiscountgiven = discountammount * qty;
                totaldiscountedgiven = (qty * price) - totaldiscountgiven;
                discountedammount = price - discountammount;


                radioButton1.Checked = false;
                EmployeeRdbtn.Checked = false;
                noTaxRdbtn.Checked = false;

                discounttxtbox.Text = Convert.ToString(discountammount);
                discountedtxtbox.Text = Convert.ToString(discountedammount);
                disconted_totaltxtbox.Text = Convert.ToString(totaldiscountedgiven);
                discount_totaltxtbox.Text = Convert.ToString(totaldiscountgiven);
              
            }
            

        }

        private void newbtn_Click_1(object sender, EventArgs e)
        {
            itemnametxtbox.Clear();
            pricetextbox.Clear();
            discounttxtbox.Clear(); 
            discountedtxtbox.Clear();
            quantitytxtbox.Clear();
            qty_totaltxtbox.Clear();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void changetxtbox_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void pricetextbox_TextChanged_1(object sender, EventArgs e)
        {
            if (pricetextbox.Text != "")
            {
                price = Convert.ToInt32(pricetextbox.Text);
            }
            else
            { 
                price = 0;
            }
            
        }

        private void discount_totaltxtbox_TextChanged_1(object sender, EventArgs e)
        {
          
        }

        private void exitbtn_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cam_Click(object sender, EventArgs e)
        {
            captureDevice.NewFrame += CaptureDevice_NewFrame;
            captureDevice = new VideoCaptureDevice(filterInfoCollection[cameraCombo.SelectedIndex].MonikerString);
            captureDevice.NewFrame += new NewFrameEventHandler(captureDevice_NewFrame);
            captureDevice.Start();
            ScanTimer_Tick.Start();



            if (cameraBox.Image == null)
            {
               
                return;
           }

            Bitmap bitmap = new Bitmap(cameraBox.Image);
            BarcodeReader reader = new BarcodeReader();
            Result result = reader.Decode(bitmap);


        }
        private void captureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            cameraBox.Image = (Bitmap)eventArgs.Frame.Clone();

        }

        private void ScanTimer_Tick_Tick(object sender, EventArgs e)
        {
            try
            {


                if (cameraBox.Image != null)
                {


                    BarcodeReader reader = new BarcodeReader();
                    Result result = reader.Decode((Bitmap)cameraBox.Image);

                    if (result != null)
                    {
                        cashre_renderedtxtbox.Text = result.Text;
                
                        ScanTimer_Tick.Stop();
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

        private void POS_Cashier_Interface_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (captureDevice != null && captureDevice.IsRunning)
                captureDevice.Stop();
            /*if (captureDevice.IsRunning == true)
                captureDevice.Stop();

            if (cameraCombo.SelectedItem != null)
            {
                // Start camera
                captureDevice = new VideoCaptureDevice(filterInfoCollection[cameraCombo.SelectedIndex].MonikerString);
                captureDevice.NewFrame += CaptureDevice_NewFrame;
                captureDevice.Start();
            }
            */
        }

        private void cameraBox_Click(object sender, EventArgs e)
        {

        }

        private void cameraCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void itemnametxtbox_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void quantitytxtbox_TextChanged_1(object sender, EventArgs e)
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
                quantitytxtbox.Text = Convert.ToString(qty);
                EmployeeRdbtn.Enabled = true;
                regularRbtn.Enabled = true;
                noTaxRdbtn.Enabled = true;
                radioButton1.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Invalid Input: Please enter a valid quantity","Message");
            }
        }

        private void cashre_renderedtxtbox_TextChanged_1(object sender, EventArgs e)
        {
            calcbtn.Enabled = true;
        }

        private void disconted_totaltxtbox_TextChanged_1(object sender, EventArgs e)
        {
           
        }

        private void cancelbtn_Click_1(object sender, EventArgs e)
        {
            discounttxtbox.Clear();
            discountedtxtbox.Clear();
            pricetextbox.Clear();
            itemnametxtbox.Clear();
            cashre_renderedtxtbox.Clear();
            changetxtbox.Clear();

            quantitytxtbox.Clear();
            discount_totaltxtbox.Clear();
            disconted_totaltxtbox.Clear();
            qty_totaltxtbox.Clear();
            
        }

        private void pictureBox12_Click_1(object sender, EventArgs e)
        {
            itemnametxtbox.Text = name14lbl.Text;
            pricetextbox.Text = f;
        }

        private void pictureBox11_Click_1(object sender, EventArgs e)
        {
            itemnametxtbox.Text = name15lbl.Text;
            pricetextbox.Text = g;
        }

        private void pictureBox20_Click_1(object sender, EventArgs e)
        {
            itemnametxtbox.Text = name16lbl.Text;
            pricetextbox.Text = h;
        }

        private void pictureBox19_Click_1(object sender, EventArgs e)
        {
            itemnametxtbox.Text = name17lbl.Text;
            pricetextbox.Text = j;
        }

        private void pictureBox18_Click_1(object sender, EventArgs e)
        {
            itemnametxtbox.Text = name18lbl.Text;
            pricetextbox.Text = k;
        }

        private void pictureBox17_Click_1(object sender, EventArgs e)
        {
            itemnametxtbox.Text = name19lbl.Text;
            pricetextbox.Text = l;
        }

        private void pictureBox16_Click_1(object sender, EventArgs e)
        {
            itemnametxtbox.Text = name20lbl.Text;
            pricetextbox.Text = z;
        }

        private void coffeeBtn_Click_1(object sender, EventArgs e)
        {

            name1lbl.Text = "Espresso";
            name2lbl.Text = "Doppio";
            name3lbl.Text = "Ristretto";
            name4lbl.Text = "Americano";
            name5lbl.Text = "Long Black";
            name6lbl.Text = "Macchiato";
            name7lbl.Text = "Cortado";
            name8lbl.Text = "Flat White";
            name9lbl.Text = "Cappuccino";
            name10lbl.Text = "Latte";
            name11lbl.Text = "Mocha";
            name12lbl.Text = "Affogato";
            name13lbl.Text = "Drip Coffee";
            name14lbl.Text = "French Press";
            name15lbl.Text = "Cold Brew";
            name16lbl.Text = "Iced Coffee";
            name17lbl.Text = "Turkish Coffee";
            name18lbl.Text = "Vietnamese Coffee";
            name19lbl.Text = "Irish Coffee";
            name20lbl.Text = "Bulletproof Coffee";
            pictureBox1.Image = Image.FromFile("C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\images\\coffee\\c1.jfif");
            pictureBox2.Image = Image.FromFile("C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\images\\coffee\\c2.jfif");
            pictureBox3.Image = Image.FromFile("C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\images\\coffee\\c3.jfif");
            pictureBox4.Image = Image.FromFile("C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\images\\coffee\\c4.jfif");
            pictureBox5.Image = Image.FromFile("C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\images\\coffee\\c5.jfif");
            pictureBox6.Image = Image.FromFile("C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\images\\coffee\\c6.jfif");
            pictureBox7.Image = Image.FromFile("C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\images\\coffee\\c7.jfif");
            pictureBox8.Image = Image.FromFile("C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\images\\coffee\\c8.jfif");
            pictureBox9.Image = Image.FromFile("C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\images\\coffee\\c9.jfif");
            pictureBox10.Image = Image.FromFile("C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\images\\coffee\\c10.jfif");
            pictureBox11.Image = Image.FromFile("C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\images\\coffee\\c11.jfif");
            pictureBox12.Image = Image.FromFile("C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\images\\coffee\\c12.jfif");
            pictureBox13.Image = Image.FromFile("C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\images\\coffee\\c13.jfif");
            pictureBox14.Image = Image.FromFile("C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\images\\coffee\\c14.jfif");
            pictureBox15.Image = Image.FromFile("C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\images\\coffee\\c15.jfif");
            pictureBox16.Image = Image.FromFile("C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\images\\coffee\\c16.jfif");
            pictureBox17.Image = Image.FromFile("C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\images\\coffee\\c17.jfif");
            pictureBox18.Image = Image.FromFile("C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\images\\coffee\\c18.jfif");
            pictureBox19.Image = Image.FromFile("C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\images\\coffee\\c19.jfif");
            pictureBox20.Image = Image.FromFile("C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\images\\coffee\\c20.jfif");

            pricetextbox.Text = q = "100";
            pricetextbox.Text = w = "120";
            pricetextbox.Text = ee = "130";
            pricetextbox.Text = r = "132";
            pricetextbox.Text = t = "140";
            pricetextbox.Text = y = "200";
            pricetextbox.Text = u = "50";
            pricetextbox.Text = i = "109";
            pricetextbox.Text = o = "45";
            pricetextbox.Text = p = "90";
            pricetextbox.Text = a = "111";
            pricetextbox.Text = s = "122";
            pricetextbox.Text = d = "900";
            pricetextbox.Text = f = "567";
            pricetextbox.Text = g = "89";
            pricetextbox.Text = h = "90";
            pricetextbox.Text = j = "124";
            pricetextbox.Text = k = "1223";
            pricetextbox.Text = l = "321";
            pricetextbox.Text = z = "1123";
        }

        private void beveragesBtn_Click_1(object sender, EventArgs e)
        {

            name1lbl.Text = "Heineken";
            name2lbl.Text = "Budweiser";
            name3lbl.Text = "Guinness";
            name4lbl.Text = "Corona";
            name5lbl.Text = "Stella Artois";
            name6lbl.Text = "Orange Juice";
            name7lbl.Text = "Apple Juice";
            name8lbl.Text = "Grape Juice";
            name9lbl.Text = "Cranberry Juice";
            name10lbl.Text = "Coca-Cola";
            name11lbl.Text = "Pepsi";
            name12lbl.Text = "Mountain Dew";
            name13lbl.Text = "Sprite";
            name14lbl.Text = "Fanta";
            name15lbl.Text = "Dr Pepper";
            name16lbl.Text = "Ginger Ale";
            name17lbl.Text = "Root Beer";
            name18lbl.Text = "Lemonade";
            name19lbl.Text = "Iced Tea";
            name20lbl.Text = "Energy Drink";
            pictureBox1.Image = Image.FromFile("C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\images\\beverages\\beer1.jfif");
            pictureBox2.Image = Image.FromFile("C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\images\\beverages\\beer2.jfif");
            //pictureBox3.Image = Image.FromFile("C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\images\\beverages\\beer3.jfif");
            pictureBox4.Image = Image.FromFile("C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\images\\beverages\\beer4.jfif");
            pictureBox5.Image = Image.FromFile("C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\images\\beverages\\beer5.jfif");
            pictureBox6.Image = Image.FromFile("C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\images\\beverages\\juice1.jfif");
            pictureBox7.Image = Image.FromFile("C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\images\\beverages\\juice2.jfif");
            pictureBox8.Image = Image.FromFile("C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\images\\beverages\\juice3.jfif");
            pictureBox9.Image = Image.FromFile("C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\images\\beverages\\juice4.jfif");
            pictureBox10.Image = Image.FromFile("C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\images\\beverages\\juice5.jfif");
            pictureBox11.Image = Image.FromFile("C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\images\\beverages\\soda1.jfif");
            pictureBox12.Image = Image.FromFile("C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\images\\beverages\\soda2.jfif");
            pictureBox13.Image = Image.FromFile("C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\images\\beverages\\soda3.jfif");
            pictureBox14.Image = Image.FromFile("C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\images\\beverages\\soda4.jfif");
            pictureBox15.Image = Image.FromFile("C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\images\\beverages\\tea1.jfif");
            pictureBox16.Image = Image.FromFile("C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\images\\beverages\\tea2.jfif");
            pictureBox17.Image = Image.FromFile("C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\images\\beverages\\tea3.jfif");
            pictureBox18.Image = Image.FromFile("C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\images\\beverages\\tea5.jfif");
            pictureBox19.Image = Image.FromFile("C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\images\\beverages\\tea6.jfif");
            pictureBox20.Image = Image.FromFile("C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\images\\beverages\\tea7.jfif");

            pricetextbox.Text = q = "100";
            pricetextbox.Text = w = "120";
            pricetextbox.Text = ee = "130";
            pricetextbox.Text = r = "132";
            pricetextbox.Text = t = "140";
            pricetextbox.Text = y = "200";
            pricetextbox.Text = u = "50";
            pricetextbox.Text = i = "109";
            pricetextbox.Text = o = "45";
            pricetextbox.Text = p = "90";
            pricetextbox.Text = a = "111";
            pricetextbox.Text = s = "122";
            pricetextbox.Text = d = "900";
            pricetextbox.Text = f = "567";
            pricetextbox.Text = g = "89";
            pricetextbox.Text = h = "90";
            pricetextbox.Text = j = "124";
            pricetextbox.Text = k = "1223";
            pricetextbox.Text = l = "321";
            pricetextbox.Text = z = "1123";

        }

        private void breakfastBrn_Click_1(object sender, EventArgs e)
        {
            name1lbl.Text = "Pancakes";
            name2lbl.Text = "Waffles";
            name3lbl.Text = "French Toast";
            name4lbl.Text = "Omelette";
            name5lbl.Text = "Scrambled Eggs";
            name6lbl.Text = "Bacon and Eggs";
            name7lbl.Text = "Sausage and Eggs";
            name8lbl.Text = "Breakfast Burrito";
            name9lbl.Text = "Bagel with Cream Cheese";
            name10lbl.Text = "Avocado Toast";
            name11lbl.Text = "Granola with Yogurt";
            name12lbl.Text = "Cereal with Milk";
            name13lbl.Text = "Smoothie Bowl";
            name14lbl.Text = "Oatmeal";
            name15lbl.Text = "Hash Browns";
            name16lbl.Text = "Biscuits and Gravy";
            name17lbl.Text = "Eggs Benedict";
            name18lbl.Text = "Breakfast Sandwich";
            name19lbl.Text = "Crepes";
            name20lbl.Text = "Full English Breakfast";
            pictureBox1.Image = Image.FromFile("C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\images\\breakfast\\b1.jfif");
            pictureBox2.Image = Image.FromFile("C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\images\\breakfast\\b2.jfif");
            pictureBox3.Image = Image.FromFile("C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\images\\breakfast\\b3.jfif");
            pictureBox4.Image = Image.FromFile("C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\images\\breakfast\\b4.jfif");
            pictureBox5.Image = Image.FromFile("C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\images\\breakfast\\b5.jfif");
            pictureBox6.Image = Image.FromFile("C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\images\\breakfast\\b6.jfif");
            pictureBox7.Image = Image.FromFile("C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\images\\breakfast\\b7.jfif");
            pictureBox8.Image = Image.FromFile("C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\images\\breakfast\\b8.jfif");
            pictureBox9.Image = Image.FromFile("C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\images\\breakfast\\b9.jfif");
            pictureBox10.Image = Image.FromFile("C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\images\\breakfast\\b10.jfif");
            pictureBox11.Image = Image.FromFile("C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\images\\breakfast\\b11.jfif");
            pictureBox12.Image = Image.FromFile("C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\images\\breakfast\\b12.jfif");
            pictureBox13.Image = Image.FromFile("C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\images\\breakfast\\b13.jfif");
            pictureBox14.Image = Image.FromFile("C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\images\\breakfast\\b14.jfif");
            pictureBox15.Image = Image.FromFile("C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\images\\breakfast\\b15.jfif");
            pictureBox16.Image = Image.FromFile("C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\images\\breakfast\\b16.jfif");
            pictureBox17.Image = Image.FromFile("C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\images\\breakfast\\b17.jfif");
            pictureBox18.Image = Image.FromFile("C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\images\\breakfast\\b18.jfif");
            pictureBox19.Image = Image.FromFile("C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\images\\breakfast\\b19.jfif");
            pictureBox20.Image = Image.FromFile("C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\images\\breakfast\\b20.jfif");


        }

        private void dessertsBtn_Click_1(object sender, EventArgs e)
        {
            name1lbl.Text = "Chocolate Cake";
            name2lbl.Text = "Cheesecake";
            name3lbl.Text = "Brownies";
            name4lbl.Text = "Ice Cream";
            name5lbl.Text = "Apple Pie";
            name6lbl.Text = "Tiramisu";
            name7lbl.Text = "Cupcakes";
            name8lbl.Text = "Donuts";
            name9lbl.Text = "Pudding";
            name10lbl.Text = "Macarons";
            name11lbl.Text = "Creme Brulee";
            name12lbl.Text = "Churros";
            name13lbl.Text = "Fruit Tart";
            name14lbl.Text = "Banoffee Pie";
            name15lbl.Text = "Mochi";
            name16lbl.Text = "Red Velvet Cake";
            name17lbl.Text = "Cinnamon Rolls";
            name18lbl.Text = "Trifle";
            name19lbl.Text = "Pavlova";
            name20lbl.Text = "Baklava";
            pictureBox1.Image = Image.FromFile("C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\images\\dessert\\s1.jfif");
            pictureBox2.Image = Image.FromFile("C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\images\\dessert\\s2.jfif");
            pictureBox3.Image = Image.FromFile("C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\images\\dessert\\s3.jfif");
            pictureBox4.Image = Image.FromFile("C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\images\\dessert\\s4.jfif");
            pictureBox5.Image = Image.FromFile("C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\images\\dessert\\s5.jfif");
            pictureBox6.Image = Image.FromFile("C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\images\\dessert\\s6.jfif");
            pictureBox7.Image = Image.FromFile("C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\images\\dessert\\s7.jfif");
            pictureBox8.Image = Image.FromFile("C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\images\\dessert\\s8.jfif");
            pictureBox9.Image = Image.FromFile("C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\images\\dessert\\s9.jfif");
            pictureBox10.Image = Image.FromFile("C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\images\\dessert\\s10.jfif");
            pictureBox11.Image = Image.FromFile("C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\images\\dessert\\s11.jfif");
            pictureBox12.Image = Image.FromFile("C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\images\\dessert\\s12.jfif");
            pictureBox13.Image = Image.FromFile("C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\images\\dessert\\s13.jfif");
            pictureBox14.Image = Image.FromFile("C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\images\\dessert\\s14.jfif");
            pictureBox15.Image = Image.FromFile("C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\images\\dessert\\s15.jfif");
            pictureBox16.Image = Image.FromFile("C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\images\\dessert\\s16.jfif");
            pictureBox17.Image = Image.FromFile("C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\images\\dessert\\s17.jfif");
            pictureBox18.Image = Image.FromFile("C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\images\\dessert\\s18.jfif");
            pictureBox19.Image = Image.FromFile("C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\images\\dessert\\s19.jfif");
            pictureBox20.Image = Image.FromFile("C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\images\\dessert\\s20.jfif");
        }

        private void lunchBtn_Click_1(object sender, EventArgs e)
        {

            name1lbl.Text = "Grilled Chicken Salad";

            name2lbl.Text = "Club Sandwich";
            name3lbl.Text = "Caesar Salad";
            name4lbl.Text = "Burger and Fries";
            name5lbl.Text = "Spaghetti Bolognese";
            name6lbl.Text = "Sushi";
            name7lbl.Text = "Chicken Alfredo";
            name8lbl.Text = "Steak with Mashed Potatoes";
            name9lbl.Text = "Fish and Chips";
            name10lbl.Text = "Vegetable Stir-Fry";
            name11lbl.Text = "Tuna Melt Sandwich";
            name12lbl.Text = "BLT Sandwich";
            name13lbl.Text = "Fried Rice with Egg";
            name14lbl.Text = "Chicken Teriyaki";
            name15lbl.Text = "Taco Bowl";
            name16lbl.Text = "Shrimp Scampi";
            name17lbl.Text = "BBQ Ribs with Cornbread";
            name18lbl.Text = "Beef Burrito";
            name19lbl.Text = "Mushroom Risotto";
            name20lbl.Text = "Grilled Cheese with Tomato Soup";
            pictureBox1.Image = Image.FromFile("C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\images\\lunch\\l1.jfif");
            pictureBox2.Image = Image.FromFile("C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\images\\lunch\\l2.jfif");
            pictureBox3.Image = Image.FromFile("C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\images\\lunch\\l3.jfif");
            pictureBox4.Image = Image.FromFile("C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\images\\lunch\\l4.jfif");
            pictureBox5.Image = Image.FromFile("C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\images\\lunch\\l5.jfif");
            pictureBox6.Image = Image.FromFile("C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\images\\lunch\\l6.jfif");
            pictureBox7.Image = Image.FromFile("C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\images\\lunch\\l7.jfif");
            pictureBox8.Image = Image.FromFile("C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\images\\lunch\\l8.jfif");
            pictureBox9.Image = Image.FromFile("C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\images\\lunch\\l9.jfif");
            pictureBox10.Image = Image.FromFile("C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\images\\lunch\\l10.jfif");
            pictureBox11.Image = Image.FromFile("C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\images\\lunch\\l11.jfif");
            pictureBox12.Image = Image.FromFile("C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\images\\lunch\\l12.jfif");
            pictureBox13.Image = Image.FromFile("C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\images\\lunch\\l13.jfif");
            pictureBox14.Image = Image.FromFile("C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\images\\lunch\\l14.jfif");
            pictureBox15.Image = Image.FromFile("C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\images\\lunch\\l15.jfif");
            pictureBox15.Image = Image.FromFile("C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\images\\lunch\\l17.jfif");
            pictureBox17.Image = Image.FromFile("C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\images\\lunch\\l18.jfif");
            pictureBox18.Image = Image.FromFile("C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\images\\lunch\\l19.jfif");
            pictureBox19.Image = Image.FromFile("C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\images\\lunch\\l10.jfif");
            pictureBox20.Image = Image.FromFile("C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\images\\lunch\\l21.jfif");

            pricetextbox.Text = q = "103";
            pricetextbox.Text = w = "121";
            pricetextbox.Text = ee = "120";
            pricetextbox.Text = r = "112";
            pricetextbox.Text = t = "110";
            pricetextbox.Text = y = "230";
            pricetextbox.Text = u = "501";
            pricetextbox.Text = i = "139";
            pricetextbox.Text = o = "145";
            pricetextbox.Text = p = "900";
            pricetextbox.Text = a = "211";
            pricetextbox.Text = s = "822";
            pricetextbox.Text = d = "910";
            pricetextbox.Text = f = "517";
            pricetextbox.Text = g = "819";
            pricetextbox.Text = h = "190";
            pricetextbox.Text = j = "224";
            pricetextbox.Text = k = "223";
            pricetextbox.Text = l = "121";
            pricetextbox.Text = z = "13";
        }

        private void changetxtbox_TextChanged(object sender, EventArgs e)
        {
        }



  



        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        public POS_Cashier_Interface()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            this.WindowState = FormWindowState.Maximized;
            this.BackColor = Color.DarkOliveGreen;
            this.Text = "Point of Sale Interface";
            itemnametxtbox.Enabled = false;
            pricetextbox.Enabled = false;
            discountedtxtbox.Enabled = false;
            qty_totaltxtbox.Enabled = false;
            discount_totaltxtbox.Enabled = false;
            disconted_totaltxtbox.Enabled = false;
            calcbtn.Enabled = false;
            discounttxtbox.Enabled = false;
            changetxtbox.Enabled = false;
            radioButton1.Enabled = false;
            regularRbtn.Enabled = false;
            noTaxRdbtn.Enabled = false;
            EmployeeRdbtn.Enabled = false;


            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filter in filterInfoCollection)
            cameraCombo.Items.Add(filter.Name);
            cameraCombo.SelectedIndex = 0;
            captureDevice = new VideoCaptureDevice();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void dinnerBtn_Click(object sender, EventArgs e)
        {
            


                name1lbl.Text = ("Grilled Salmon");
                name2lbl.Text = "Beef Steak";
                name3lbl.Text = "Roast Chicken";
                name4lbl.Text = "Pasta Carbonara";
                name5lbl.Text = "Shrimp Scampi";
                name6lbl.Text = "Chicken Parmesan";
                name7lbl.Text = "Vegetable Stir-Fry";
                name8lbl.Text = "BBQ Ribs";
                name9lbl.Text = "Lasagna";
                name10lbl.Text = "Lamb Chops";
                name11lbl.Text = "Sushi Platter";
                name12lbl.Text = "Clam Chowder";
                name13lbl.Text = "Tacos al Pastor";
                name14lbl.Text = "Stuffed Bell Peppers";
                name15lbl.Text = "Baked Ziti";
                name16lbl.Text = "Shepherd’s Pie";
                name17lbl.Text = "Teriyaki Chicken";
                name18lbl.Text = "Miso Soup with Tofu";
                name19lbl.Text = "Grilled Lobster";
                name20lbl.Text = "Beef Stroganoff";







                pictureBox1.Image = Image.FromFile("C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\images\\dinner\\d1.jfif");
                pictureBox2.Image = Image.FromFile("C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\images\\dinner\\d2.jfif");
                pictureBox3.Image = Image.FromFile("C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\images\\dinner\\d3.jfif");
                pictureBox4.Image = Image.FromFile("C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\images\\dinner\\d4.jfif");
                pictureBox5.Image = Image.FromFile("C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\images\\dinner\\d5.jfif");
                pictureBox6.Image = Image.FromFile("C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\images\\dinner\\d6.jfif");
                pictureBox7.Image = Image.FromFile("C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\images\\dinner\\d7.jfif");
                pictureBox8.Image = Image.FromFile("C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\images\\dinner\\d8.jfif");
                pictureBox9.Image = Image.FromFile("C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\images\\dinner\\d9.jfif");
                pictureBox10.Image = Image.FromFile("C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\images\\dinner\\d10.jfif");
                pictureBox11.Image = Image.FromFile("C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\images\\dinner\\d11.jfif");
                pictureBox12.Image = Image.FromFile("C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\images\\dinner\\d12.jfif");
                pictureBox13.Image = Image.FromFile("C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\images\\dinner\\d13.jfif");
                pictureBox14.Image = Image.FromFile("C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\images\\dinner\\d14.jfif");
                pictureBox15.Image = Image.FromFile("C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\images\\dinner\\d15.jfif");
                pictureBox16.Image = Image.FromFile("C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\images\\dinner\\d16.jfif");
                pictureBox17.Image = Image.FromFile("C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\images\\dinner\\d17.jfif");
                pictureBox18.Image = Image.FromFile("C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\images\\dinner\\d18.jfif");
                pictureBox19.Image = Image.FromFile("C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\images\\dinner\\d19.jfif");
                pictureBox20.Image = Image.FromFile("C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\images\\dinner\\d20.jfif");


                pricetextbox.Text = q = "100";
                pricetextbox.Text = w = "120";
                pricetextbox.Text = ee = "130";
                pricetextbox.Text = r = "132";
                pricetextbox.Text = t = "140";
                pricetextbox.Text = y = "200";
                pricetextbox.Text = u = "50";
                pricetextbox.Text = i = "109";
                pricetextbox.Text = o = "45";
                pricetextbox.Text = p = "90";
                pricetextbox.Text = a = "111";
                pricetextbox.Text = s = "122";
                pricetextbox.Text = d = "900";
                pricetextbox.Text = f = "567";
                pricetextbox.Text = g = "89";
                pricetextbox.Text = h = "90";
                pricetextbox.Text = j = "124";
                pricetextbox.Text = k = "1223";
                pricetextbox.Text = l = "321";
                pricetextbox.Text = z = "1123";
            

        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = name1lbl.Text;
            pricetextbox.Text = q;
;


        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {

            itemnametxtbox.Text = name2lbl.Text;
            pricetextbox.Text = w;

        }

    }
}

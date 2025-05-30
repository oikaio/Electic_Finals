using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using ZXing;
using AForge.Video.DirectShow;
using AForge.Video;

namespace New_POS_Application
{
    public partial class midtermPOSH : Form
    {
        private List<MenuItem> menuItems; // List of menu items from MenuData
        private List<Calculation> calculations;
        private PictureBox[] pictureBoxes; // Array of PictureBox controls
        private Label[] namelabels;
        int pprice,qty;
        private FilterInfoCollection filterInfoCollection;
        private VideoCaptureDevice captureDevice;
        private Timer scanTimer;

        public midtermPOSH()
        {
            InitializeComponent();
            //assigning breakfastItems sa load
            menuItems = MenuData.BreakfastItem; 
            // array for picturebox
            pictureBoxes = new PictureBox[]
            {
                pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5,
                pictureBox6, pictureBox7, pictureBox8, pictureBox9, pictureBox10,
                pictureBox11, pictureBox12, pictureBox13, pictureBox14, pictureBox15,
                pictureBox16, pictureBox17, pictureBox18, pictureBox19, pictureBox20
            };
            //array for name label
            namelabels = new Label[]
            {
                name1lbl, name2lbl, name3lbl, name4lbl, name5lbl,
                name6lbl, name7lbl, name8lbl, name9lbl, name10lbl,
                name11lbl, name12lbl, name13lbl, name14lbl, name15lbl,
                name16lbl, name17lbl, name18lbl, name19lbl, name20lbl
            };
        }
        private void midtermPOSH_Load(object sender, EventArgs e)
        {
            // Form settings
            this.WindowState = FormWindowState.Maximized;
            this.BackColor = Color.SlateGray;
            this.Text = "Point of Sale";

            // Load images into PictureBoxes and assign click events.
            LoadImages();
            AssignClickEvents();
            //for qr
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filter in filterInfoCollection)
            cameraCombo.Items.Add(filter.Name);
            cameraCombo.SelectedIndex = 0;
            captureDevice = new VideoCaptureDevice();
        }
        private void LoadImages()  // Loads images into PictureBoxes based on the MenuData image paths.
        {
            for (int i = 0; i < 20; i++)
            {
                if (i < menuItems.Count)
                {
                    //classs called          
                    string name = menuItems[i].Name;
                    string imagePath = menuItems[i].ImagePath;
                    //calling the names of the product
                    namelabels[i].Text = name;
                    if (File.Exists(imagePath))
                    {
                         pictureBoxes[i].Image = Image.FromFile(imagePath);
                    }
                    else
                    {
                        MessageBox.Show("File not found: ","Missing Image");
                        pictureBoxes[i].Image = null;
                    }
                }
                else
                {
                    pictureBoxes[i].Image = null;
                }
            }
        }
        // Assign click events to each PictureBox.
        private void AssignClickEvents()
        {
            for (int i = 0; i < 20; i++) // pwede ding for(int i = 0 ; i<pictureBoxes.Length;i++)
            {
                int index = i; // Capture the current index for the lambda.
                pictureBoxes[i].Click += (sender, e) => SelectMenuItem(index);

            }
        }

        // When a PictureBox is clicked, update the textboxes with the corresponding menu item data.
        private void SelectMenuItem(int index)
        {
            if (index >= 0 && index < menuItems.Count)
            {
                MenuItem selectedItem = menuItems[index];
                itemnametxtbox.Text = selectedItem.Name;
                pricetextbox.Text = selectedItem.Price.ToString(); // Ensure correct string conversion
            }
            else
            {
                // Handle case where index is out of range (optional)
                MessageBox.Show("Invalid menu item selection.");
            }
            quantitytxtbox.Clear();
            quantitytxtbox.Focus(); // Fixed misplaced '/' 
        }

        // If you have a breakfast button that reloads images, you can call LoadImages.
        private void breakfastBrn_Click(object sender, EventArgs e)
        {
            menuItems = MenuData.BreakfastItem;
            LoadImages();
        }

        private void dinnerBtn_Click(object sender, EventArgs e)
        {
            menuItems = MenuData.DinnerItems;//calling the class data
            LoadImages();// Reload images in the PictureBoxes
        }

        private void lunchBtn_Click(object sender, EventArgs e)
        {
            menuItems = MenuData.LunchItems;
            LoadImages();

        }

        private void beveragesBtn_Click(object sender, EventArgs e)
        {
            menuItems = MenuData.BeverageItems;
            LoadImages();
        }

        private void dessertsBtn_Click(object sender, EventArgs e)
        {
            menuItems = MenuData.DessertItem;
            LoadImages();
        }

        private void coffeeBtn_Click(object sender, EventArgs e)
        {
            menuItems = MenuData.CoffeeItems;
            LoadImages();
        }

        private void pricetextbox_TextChanged(object sender, EventArgs e)   
        {
        }

        private void qty_totaltxtbox_TextChanged(object sender, EventArgs e)
        { 
        }
        private void captureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            cameraBox.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void CaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs) // for qr cam
        {
            Bitmap frame = (Bitmap)eventArgs.Frame.Clone();
            cameraBox.Image = frame;
        }
        private void cam_Click(object sender, EventArgs e) // for qr camera start
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

        private void ScanTimer_Tick_Tick(object sender, EventArgs e) //qr cam timer
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
                
            }
        }

        private void midtermPOSH_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (captureDevice != null && captureDevice.IsRunning) //for qr closing
                captureDevice.Stop();
        }

        private void calcbtn_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Get the inputs from textboxes.
                double price = Convert.ToDouble(pricetextbox.Text);
                double qty = Convert.ToDouble(quantitytxtbox.Text);
                double cash = Convert.ToDouble(cashre_renderedtxtbox.Text);

                // 2. Determine the discount rate from radio buttons.
                double discountRate = 0.0;
                if (radioButton1.Checked)
                {
                    discountRate = 0.20;  // Senior discount: 20%
                }
                else if (regularRbtn.Checked)
                {
                    discountRate = 0.17;  // Student discount: 17%
                }
                else if (EmployeeRdbtn.Checked)
                {
                    discountRate = 0.10;  // Employee discount: 10%
                }
                else if (noTaxRdbtn.Checked)
                {
                    discountRate = 0.0;   // No discount
                }

                // 3. Create a Calculation object and perform calculations.
                Calculation transaction = new Calculation(0, price, cash, 0, 0);
                transaction.qty = qty;
                transaction.CalculateDiscount(discountRate);
                // Track cumulative totals.
                Calculation.DiscountList.Add(transaction);

                double totalQty = Calculation.DiscountList.Sum(t => t.qty);
                double totalDiscountGiven = Calculation.DiscountList.Sum(t => t.discount_totalgiven);
                double totalDiscountedTotal = Calculation.DiscountList.Sum(t => t.discounted_total);
                // 4. Update the form's textboxes with the results using Convert.To
                qty_totaltxtbox.Text = Convert.ToString(totalQty);
                discounttxtbox.Text = Convert.ToString(transaction.discount_amt.ToString("F2"));
                discountedtxtbox.Text = Convert.ToString(transaction.discounted_amt.ToString("F2"));
                discount_totaltxtbox.Text = Convert.ToString(totalDiscountGiven.ToString("F2"));
                disconted_totaltxtbox.Text = Convert.ToString(totalDiscountedTotal.ToString("F2"));

                // Calculate remaining cash after each order
                transaction.change = cash - totalDiscountedTotal;
                //cashre_renderedtxtbox.Text = Convert.ToString(transaction.change.ToString("F2")); // Set remaining cash as new cash
                changetxtbox.Text = Convert.ToString(transaction.change.ToString("F2"));

                // 5. Validate if the cash rendered is enough.
                if (transaction.change < 0)
                {
                    MessageBox.Show("Not enough cash rendered!", "Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Calculation Error");
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void newbtn_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Clear();
            quantitytxtbox.Clear();
            pricetextbox.Clear();
            discounttxtbox.Clear();
            discountedtxtbox.Clear();
            changetxtbox.Clear();
            quantitytxtbox.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            menustrip MENU = new menustrip();
            MENU.Show();
            this.Close();
        }

        private void quantitytxtbox_TextChanged(object sender, EventArgs e)
        {
            if (quantitytxtbox.Text.Length != 0)
            {
                try
                {


                    qty = Convert.ToInt32(quantitytxtbox.Text);


                    quantitytxtbox.Text = Convert.ToString(qty);
                    EmployeeRdbtn.Enabled = true;
                    regularRbtn.Enabled = true;
                    noTaxRdbtn.Enabled = true;
                    radioButton1.Enabled = true;
                }
                catch
                {

                    quantitytxtbox.Clear();
                    quantitytxtbox.Focus();

                    MessageBox.Show("Invalid Input: Please enter a valid quantity", "Message");


                }
            }
        }
    } 
}

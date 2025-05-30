using AForge.Video.DirectShow;
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
using System.IO;
using System.Reflection;
using System.Diagnostics;

namespace New_POS_Application
{
    public partial class Midterm_Example3 : Form
    {
        int qty, pricee, totalprice;
        private FilterInfoCollection filterInfoCollection;
        private VideoCaptureDevice captureDevice;
        private Timer scanTimer;
        private CheckBox[] checkBoxes;
        private PictureBox[] pictureBoxes;
        private List<MenuItem> menuItems; // List of menu items from MenuData
        private List<Calculation> calculations;
        public Midterm_Example3()

        {
            InitializeComponent();
            menuItems = MenuData.PizzaItems;
            checkBoxes = new CheckBox[]
           {
                checkBox3, checkBox4,  checkBox5, checkBox6, checkBox7, checkBox8, checkBox9, checkBox10, checkBox11, checkBox12, checkBox13, checkBox14, checkBox15, checkBox16,checkBox17, checkBox18, checkBox19, checkBox20,checkBox21, checkBox22

           };
            pictureBoxes = new PictureBox[]
            {
                pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7, pictureBox8, pictureBox9, pictureBox10, pictureBox11, pictureBox12, pictureBox13, pictureBox14, pictureBox15, pictureBox16, pictureBox17, pictureBox18, pictureBox19, pictureBox20

            };

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
                    checkBoxes[i].Text = name;
                    if (File.Exists(imagePath))
                    {
                        pictureBoxes[i].Image = Image.FromFile(imagePath);
                    }
                    else
                    {
                        MessageBox.Show("File not found: ", "Missing Image");
                        pictureBoxes[i].Image = null;
                    }
                }
                else
                {
                    pictureBoxes[i].Image = null;
                }
                B_carbonarachechBox.Enabled = false;
                B_ChickencheckBox.Enabled = false;
                B_FriescheckBox.Enabled = false;
                B_halohalocheckbox.Enabled = false;
                B_HawaiianchechBox.Enabled = false;
                A_CokeCheckBox.Enabled = false;
                A_FriedChickencheckBox.Enabled = false;
                A_FriescheckBox.Enabled = false;
                A_sideDishCheckBox.Enabled = false;
                A_SpecialPizaChechBox.Enabled = false;

            }
        }
        public void AssignClickEvents()
        {
            for (int i = 0; i < 20; i++) // pwede ding for(int i = 0 ; i<pictureBoxes.Length;i++)
            {
                int index = i; // Capture the current index for the lambda.
                checkBoxes[i].Click += (sender, e) => SelectMenuItem(index);
            }
        }
        private void SelectMenuItem(int index)
        {
            if (index >= 0 && index < menuItems.Count)
            {
                MenuItem selectedItem = menuItems[index];
                CheckBox checkBox = checkBoxes[index];

                // Ensure price is properly set
                priceTxtBox.Text = selectedItem.Price.ToString();

                if (checkBox.Checked)
                {
                    qtyTextbox.Focus(); // Move focus to qtyTextbox when a checkbox is checked
                    qtyTextbox.Clear();
                }
                else
                {
                    // Remove item from listbox if unchecked
                    foreach (var item in displayListbox.Items.Cast<string>().ToList())
                    {
                        if (item.StartsWith(selectedItem.Name))
                        {
                            displayListbox.Items.Remove(item);
                            break;
                        }
                    }
                }
            }
        }


        private void Midterm_Example3_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            //for qr
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filter in filterInfoCollection)
            cameraCombo.Items.Add(filter.Name);
            cameraCombo.SelectedIndex = 0;
            captureDevice = new VideoCaptureDevice();
            LoadImages();
            AssignClickEvents();
            totalQtyTxtBox.Enabled = false;
            totalBillsTxtBox.Enabled = false;
            discount_totaltxtbox.Enabled = false;
            displayListbox.Items.Add("--------------------------------------------------- ORDERS --------------------------------------------------------");
            displayListbox.Items.Add("");
        }
        private void CaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs) // for qr cam
        {
            Bitmap frame = (Bitmap)eventArgs.Frame.Clone();
            cameraBox.Image = frame;
        }
        private void captureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            cameraBox.Image = (Bitmap)eventArgs.Frame.Clone();
        }
        private void priceTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Scan_Click(object sender, EventArgs e)
        {
            captureDevice.NewFrame += CaptureDevice_NewFrame;
            captureDevice = new VideoCaptureDevice(filterInfoCollection[cameraCombo.SelectedIndex].MonikerString);
            captureDevice.NewFrame += new NewFrameEventHandler(captureDevice_NewFrame);
            captureDevice.Start();
            scantimer.Start();

            if (cameraBox.Image == null)
            {
                return;
            }

            Bitmap bitmap = new Bitmap(cameraBox.Image);
            BarcodeReader reader = new BarcodeReader();
            Result result = reader.Decode(bitmap);
        }

        private void scantimer_Tick(object sender, EventArgs e)
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

                        scantimer.Stop();
                        if (captureDevice.IsRunning)
                            captureDevice.Stop();
                    }
                }
            }
            catch
            {

            }
        }

        private void Midterm_Example3_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (captureDevice != null && captureDevice.IsRunning) //for qr closing
                captureDevice.Stop();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Get the inputs from textboxes.
                double price = Convert.ToDouble(priceTxtBox.Text);
                double qty = Convert.ToDouble(qtyTextbox.Text);
                double cash = Convert.ToDouble(cashre_renderedtxtbox.Text);
                double totalAmountPaid = Convert.ToDouble(totalBillsTxtBox.Text); // Fixed this line

                // 3. Create a Calculation object and perform calculations.
                Calculation transaction = new Calculation(0, price, cash, 0, 0);
                transaction.qty = qty;
                transaction.CalculateDiscount(0); // Fixed 0 discount

                // Track cumulative totals.
                Calculation.DiscountList.Add(transaction);

                // Adding total discount and quantity
                double totalQty = Calculation.DiscountList.Sum(t => t.qty);
                double discountTotal = Calculation.DiscountList.Sum(t => t.discount_totalgiven);
                double total = Calculation.DiscountList.Sum(t => t.discounted_total); // Use the correct field for total

                // Display results in textboxes
                totalQtyTxtBox.Text = totalQty.ToString();
                // No discount applied, so this remains zero
                discountAmountTxtBox.Text = "0.00";
                // Calculate change (Cash Rendered - Total Bill)
                double change = cash - totalAmountPaid;
                changeTxtBox.Text = change.ToString("F2"); // Display change
                // Ensure cash rendered textbox does not get overwritten
                cashre_renderedtxtbox.Text = cash.ToString("F2");
                // **Add total price and change to displayListbox**
                displayListbox.Items.Add($"Total Price: ₱{total:F2}");
                displayListbox.Items.Add($"Change: ₱{change:F2}");
            }
            catch
            {
                MessageBox.Show("Error: Please check your inputs.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                displayListbox.Items.RemoveAt(displayListbox.SelectedIndex);
            }
            catch
            {
                MessageBox.Show("Click an order to Remove", "Warning");
            }
        }

        private void foodARdbtn_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.LightPink;
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

            displayListbox.Items.Add(foodARdbtn.Text);
            displayListbox.Items.Add("     Discount Amount: " + " " + totalBillsTxtBox.Text);
            qtyTextbox.Text = "0";
            qtyTextbox.Focus();
        }

        private void foodBRdbtn_CheckedChanged(object sender, EventArgs e)
        {

            this.BackColor = Color.Magenta;
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
            qtyTextbox.Text = "0";
            qtyTextbox.Focus();
            displayListbox.Items.Add(foodBRdbtn.Text);
            displayListbox.Items.Add("     Discount Amount: 15% of the price)194.85" + " " + totalBillsTxtBox.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Activity4_PrintFrm print = new Activity4_PrintFrm();
            print.printDisplayListbox.Items.AddRange(this.displayListbox.Items);
            print.Show();

        }

        private void displayListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            menustrip MENU = new menustrip();
            MENU.Show();
            this.Close();
        }

        private void cashre_renderedtxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            displayListbox.Items.Clear();
            foreach (CheckBox checkBox in checkBoxes)
            {
                checkBox.Checked = false;
            }
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
            qtyTextbox.Clear();
            priceTxtBox.Clear();
            discountAmountTxtBox.Clear();
            discountedAmountTxtBox.Clear();
            changeTxtBox.Clear();
            qtyTextbox.Focus();

        }

        private void qtyTextbox_TextChanged(object sender, EventArgs e)
        {
            
            {
                int index = Array.FindIndex(checkBoxes, cb => cb.Checked);

                if (index == -1) return; // No checkbox is selected

                MenuItem selectedItem = menuItems[index];
                    if (double.TryParse(qtyTextbox.Text, out double qty) && double.TryParse(priceTxtBox.Text, out double price))
                    {
                        double total = qty * price;
                        discountedAmountTxtBox.Text = total.ToString("F2"); // Show item total

                        // Add the new item to the ListBox
                        string itemInfo = $"{selectedItem.Name} - ₱{selectedItem.Price:F2} x {qty} = ₱{total:F2}";
                        displayListbox.Items.Add(itemInfo);

                        // Calculate the new grand total by summing all items in displayListbox
                        double grandTotal = 0;
                        foreach (var item in displayListbox.Items)
                        {
                            string[] parts = item.ToString().Split('=');
                            if (parts.Length == 2)
                            {
                                string pricePart = parts[1].Replace("₱", "").Trim();
                                if (double.TryParse(pricePart, out double itemTotal))
                                {
                                    grandTotal += itemTotal;
                                }
                            }
                        }

                        // Update totalBillsTxtBox
                        totalBillsTxtBox.Text = grandTotal.ToString("F2");

                        // Calculate change (Cash Rendered - Total Bill)
                        if (double.TryParse(cashre_renderedtxtbox.Text, out double cash))
                        {
                            double change = cash - grandTotal;
                            changeTxtBox.Text = change.ToString("F2");
                        }
                    }
                    else
                    {
                        discountedAmountTxtBox.Text = "0.00";
                        totalBillsTxtBox.Text = "0.00";
                        changeTxtBox.Text = "0.00";
                    }
                    // Accumulate total quantity from all items in the displayListbox
                    double totalQty = 0;
                    foreach (var item in displayListbox.Items)
                    {
                        string[] parts = item.ToString().Split('x'); // Extract quantity from string
                        if (parts.Length == 2)
                        {
                            string qtyPart = parts[1].Split('=')[0].Trim(); // Get the qty part
                            if (double.TryParse(qtyPart, out double itemQty))
                            {
                                totalQty += itemQty; // Add quantity to totalQty
                            }
                        }
                    }

                    totalQtyTxtBox.Text = totalQty.ToString(); // Update total quantity textbox
                    discountAmountTxtBox.Text = "0.00"; // No discount applied
            }
              
         }
            
 
    }
}

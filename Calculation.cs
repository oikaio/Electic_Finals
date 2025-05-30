using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace New_POS_Application
{
    class Calculation
    {
        public double amount_paid;
        public double price;
        public double cash_given;
        public double change;
        public double qty_total = 0;
        public double discount_totalgiven = 0;
        public double discounted_total = 0;
        public double discount_amt;
        public double discounted_amt;
        public double total_amountPaid;
        public double qty;

        public PictureBox[] pictureBoxes;
        public CheckBox[] checkBoxes;



        public Calculation(double amount_paid, double price, double cash_given, double change, double qty_total, double discount_totalgiven = 0, double discounted_total = 0, double discount_amt = 0, double discounted_amt = 0, double total_amountPaid = 0, double qty = 0)
        {
            this.amount_paid = amount_paid;
            this.price = price;
            this.cash_given = cash_given;
            this.change = change;
            this.qty_total = qty_total;
            this.discount_totalgiven = discount_totalgiven;
            this.discounted_total = discounted_total;
            this.discount_amt = discount_amt;
            this.discounted_amt = discounted_amt;
            this.total_amountPaid = total_amountPaid;
            this.qty = qty;

            pictureBoxes = new PictureBox[]
            {
                new PictureBox(), new PictureBox(), new PictureBox(), new PictureBox(), new PictureBox(),
                new PictureBox(), new PictureBox(), new PictureBox(), new PictureBox(), new PictureBox(),
                new PictureBox(), new PictureBox(), new PictureBox(), new PictureBox(), new PictureBox(),
                new PictureBox(), new PictureBox(), new PictureBox(), new PictureBox(), new PictureBox()
            };
            checkBoxes = new CheckBox[]
{
                new CheckBox(), new CheckBox(), new CheckBox(), new CheckBox(), new CheckBox(),
                new CheckBox(), new CheckBox(), new CheckBox(), new CheckBox(), new CheckBox(),
                new CheckBox(), new CheckBox(), new CheckBox(), new CheckBox(), new CheckBox(),
                new CheckBox(), new CheckBox(), new CheckBox(), new CheckBox(), new CheckBox()
};
        }
        public static List<Calculation> DiscountList = new List<Calculation>();
        public void CalculateDiscount(double discountRate)
        {
            discount_amt = price * discountRate;
            discounted_amt = price - discount_amt;
            discount_totalgiven = discount_amt * qty;
            discounted_total = (qty * price) - discount_totalgiven;
            
        }

        // Added Methods
        public double CalculateTotalAmount()
        {
            total_amountPaid = qty * discounted_amt;
            return total_amountPaid;
        }

        public double CalculateChange()
        {
            change = cash_given - total_amountPaid;
            return change;
        }

        public void ResetValues()
        {
            amount_paid = 0;
            price = 0;
            cash_given = 0;
            change = 0;
            qty_total = 0;
            discount_totalgiven = 0;
            discounted_total = 0;
            discount_amt = 0;
            discounted_amt = 0;
            total_amountPaid = 0;
            qty = 0;
        }
        
    }
}

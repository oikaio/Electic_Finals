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
    public partial class menustrip: Form
    {
        public menustrip()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void menustrip_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

        }
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void mIDTERMACTIVITYToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mIDTERMPOSHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            midtermPOSH midposh = new midtermPOSH();
            midposh.MdiParent = this;
            midposh.Show();
        }

        private void mIDTERMPIZZAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Midterm_Example3 pizza = new Midterm_Example3();
            pizza.MdiParent = this;
            pizza.Show();
        }

        private void mIDTERMSSSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MidtermSSS sss = new MidtermSSS();
            sss.MdiParent = this;
            sss.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            login log = new login();
            this.Show();
            this.Close();
        }

        private void electiveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void lbl1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void wINDOWSToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void tileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void tileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);

        }

        private void sAMPLEDBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sampledb sampledb = new Sampledb();
            sampledb.MdiParent = this;
            sampledb.Show();
        }

        private void fINALACT1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Finals_Activity1 finalsActivity1 = new Finals_Activity1();
            finalsActivity1.MdiParent = this;
            finalsActivity1.Show();
        }

        private void pRELIMEXAMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Prelim_Exam prelimExam = new Prelim_Exam();
            prelimExam.MdiParent = this;
            prelimExam.Show();
        }
    }
}

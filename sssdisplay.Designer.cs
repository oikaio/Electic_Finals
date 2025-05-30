using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.PropertyGridInternal;

namespace Activityt3
{
    partial class sssdisplay
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.priDisplayListbox = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // priDisplayListbox
            // 
            this.priDisplayListbox.BackColor = System.Drawing.Color.LightGray;
            this.priDisplayListbox.FormattingEnabled = true;
            this.priDisplayListbox.ItemHeight = 16;
            this.priDisplayListbox.Location = new System.Drawing.Point(84, 55);
            this.priDisplayListbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.priDisplayListbox.Name = "priDisplayListbox";
            this.priDisplayListbox.Size = new System.Drawing.Size(1195, 740);
            this.priDisplayListbox.TabIndex = 0;
            this.priDisplayListbox.SelectedIndexChanged += new System.EventHandler(this.priDisplayListbox_SelectedIndexChanged_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1625, 844);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // sssdisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1625, 844);
            this.Controls.Add(this.priDisplayListbox);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "sssdisplay";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.sssdisplay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public ListBox priDisplayListbox;
        private PictureBox pictureBox1;
    }
}
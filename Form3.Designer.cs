namespace New_POS_Application
{
    partial class Activity4_PrintFrm
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
            this.printDisplayListbox = new System.Windows.Forms.ListBox();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // printDisplayListbox
            // 
            this.printDisplayListbox.FormattingEnabled = true;
            this.printDisplayListbox.ItemHeight = 16;
            this.printDisplayListbox.Location = new System.Drawing.Point(110, 55);
            this.printDisplayListbox.Name = "printDisplayListbox";
            this.printDisplayListbox.Size = new System.Drawing.Size(389, 420);
            this.printDisplayListbox.TabIndex = 0;
            this.printDisplayListbox.SelectedIndexChanged += new System.EventHandler(this.printDisplayListbox_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Algerian", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(120, 9);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(379, 25);
            this.label11.TabIndex = 142;
            this.label11.Text = "4JEE FOODS INC. POINT OF SALE";
            // 
            // Activity4_PrintFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 519);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.printDisplayListbox);
            this.Name = "Activity4_PrintFrm";
            this.Text = "Example3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ListBox printDisplayListbox;
        private System.Windows.Forms.Label label11;
    }
}
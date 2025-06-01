namespace New_POS_Application
{
    partial class Finals_Activity6
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
            this.optionInputTxtbox = new System.Windows.Forms.TextBox();
            this.optionCombo = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Searchbttn = new System.Windows.Forms.Button();
            this.Backbttn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // optionInputTxtbox
            // 
            this.optionInputTxtbox.Location = new System.Drawing.Point(858, 55);
            this.optionInputTxtbox.Name = "optionInputTxtbox";
            this.optionInputTxtbox.Size = new System.Drawing.Size(279, 22);
            this.optionInputTxtbox.TabIndex = 0;
            // 
            // optionCombo
            // 
            this.optionCombo.FormattingEnabled = true;
            this.optionCombo.Location = new System.Drawing.Point(484, 53);
            this.optionCombo.Name = "optionCombo";
            this.optionCombo.Size = new System.Drawing.Size(325, 24);
            this.optionCombo.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(95, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1774, 662);
            this.dataGridView1.TabIndex = 2;
            // 
            // Searchbttn
            // 
            this.Searchbttn.Location = new System.Drawing.Point(1213, 48);
            this.Searchbttn.Name = "Searchbttn";
            this.Searchbttn.Size = new System.Drawing.Size(128, 35);
            this.Searchbttn.TabIndex = 3;
            this.Searchbttn.Text = "SEARCH";
            this.Searchbttn.UseVisualStyleBackColor = true;
            this.Searchbttn.Click += new System.EventHandler(this.Searchbttn_Click);
            // 
            // Backbttn
            // 
            this.Backbttn.Location = new System.Drawing.Point(1347, 49);
            this.Backbttn.Name = "Backbttn";
            this.Backbttn.Size = new System.Drawing.Size(130, 34);
            this.Backbttn.TabIndex = 4;
            this.Backbttn.Text = "BACK";
            this.Backbttn.UseVisualStyleBackColor = true;
            this.Backbttn.Click += new System.EventHandler(this.Backbttn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Location = new System.Drawing.Point(417, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1138, 79);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(47, 126);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1947, 821);
            this.panel2.TabIndex = 6;
            // 
            // Finals_Activity6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.Backbttn);
            this.Controls.Add(this.Searchbttn);
            this.Controls.Add(this.optionCombo);
            this.Controls.Add(this.optionInputTxtbox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Finals_Activity6";
            this.Text = "Finals_Activity6";
            this.Load += new System.EventHandler(this.Finals_Activity6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox optionInputTxtbox;
        private System.Windows.Forms.ComboBox optionCombo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Searchbttn;
        private System.Windows.Forms.Button Backbttn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}
namespace New_POS_Application
{
    partial class Finals_Activity7
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
            this.dataGridViewPayroll = new System.Windows.Forms.DataGridView();
            this.Backbttn = new System.Windows.Forms.Button();
            this.Searchbttn = new System.Windows.Forms.Button();
            this.optionCombo = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPayroll)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewPayroll
            // 
            this.dataGridViewPayroll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPayroll.Location = new System.Drawing.Point(95, 77);
            this.dataGridViewPayroll.Name = "dataGridViewPayroll";
            this.dataGridViewPayroll.RowHeadersWidth = 51;
            this.dataGridViewPayroll.RowTemplate.Height = 24;
            this.dataGridViewPayroll.Size = new System.Drawing.Size(1774, 662);
            this.dataGridViewPayroll.TabIndex = 2;
            // 
            // Backbttn
            // 
            this.Backbttn.Location = new System.Drawing.Point(1289, 89);
            this.Backbttn.Name = "Backbttn";
            this.Backbttn.Size = new System.Drawing.Size(130, 34);
            this.Backbttn.TabIndex = 10;
            this.Backbttn.Text = "BACK";
            this.Backbttn.UseVisualStyleBackColor = true;
            this.Backbttn.Click += new System.EventHandler(this.Backbttn_Click);
            // 
            // Searchbttn
            // 
            this.Searchbttn.Location = new System.Drawing.Point(1155, 88);
            this.Searchbttn.Name = "Searchbttn";
            this.Searchbttn.Size = new System.Drawing.Size(128, 35);
            this.Searchbttn.TabIndex = 9;
            this.Searchbttn.Text = "SEARCH";
            this.Searchbttn.UseVisualStyleBackColor = true;
            this.Searchbttn.Click += new System.EventHandler(this.Searchbttn_Click);
            // 
            // optionCombo
            // 
            this.optionCombo.FormattingEnabled = true;
            this.optionCombo.Location = new System.Drawing.Point(426, 93);
            this.optionCombo.Name = "optionCombo";
            this.optionCombo.Size = new System.Drawing.Size(325, 24);
            this.optionCombo.TabIndex = 8;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(800, 95);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(279, 22);
            this.txtSearch.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Location = new System.Drawing.Point(359, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1138, 79);
            this.panel1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.Controls.Add(this.dataGridViewPayroll);
            this.panel2.Location = new System.Drawing.Point(-11, 166);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1947, 821);
            this.panel2.TabIndex = 12;
            // 
            // Finals_Activity7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.Backbttn);
            this.Controls.Add(this.Searchbttn);
            this.Controls.Add(this.optionCombo);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Finals_Activity7";
            this.Text = "Finals_Activity7cs";
            this.Load += new System.EventHandler(this.Finals_Activity7cs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPayroll)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPayroll;
        private System.Windows.Forms.Button Backbttn;
        private System.Windows.Forms.Button Searchbttn;
        private System.Windows.Forms.ComboBox optionCombo;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}
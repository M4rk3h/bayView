namespace BayView1
{
    partial class ManagerView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerView));
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnLog = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnStaff = new System.Windows.Forms.Button();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.btnAnalytics = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Arial", 10F);
            this.lblWelcome.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblWelcome.Location = new System.Drawing.Point(25, 20);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(116, 19);
            this.lblWelcome.TabIndex = 6;
            this.lblWelcome.Text = "Welcome label";
            // 
            // btnLog
            // 
            this.btnLog.Enabled = false;
            this.btnLog.Font = new System.Drawing.Font("Arial", 10F);
            this.btnLog.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnLog.Image = global::BayView1.Properties.Resources.Graphicloads_100_Flat_Phonebook;
            this.btnLog.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLog.Location = new System.Drawing.Point(260, 195);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(149, 80);
            this.btnLog.TabIndex = 3;
            this.btnLog.Text = "Logs";
            this.btnLog.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLog.UseVisualStyleBackColor = true;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Arial", 10F);
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(323, 317);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 32);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnStaff
            // 
            this.btnStaff.Font = new System.Drawing.Font("Arial", 10F);
            this.btnStaff.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnStaff.Image = global::BayView1.Properties.Resources.Graphicloads_100_Flat_Warning;
            this.btnStaff.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnStaff.Location = new System.Drawing.Point(13, 195);
            this.btnStaff.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.Size = new System.Drawing.Size(149, 80);
            this.btnStaff.TabIndex = 2;
            this.btnStaff.Text = "Staff";
            this.btnStaff.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnStaff.UseVisualStyleBackColor = true;
            this.btnStaff.Click += new System.EventHandler(this.btnStaff_Click);
            // 
            // btnCustomers
            // 
            this.btnCustomers.Font = new System.Drawing.Font("Arial", 10F);
            this.btnCustomers.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnCustomers.Image = global::BayView1.Properties.Resources.Graphicloads_100_Flat_Contact;
            this.btnCustomers.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCustomers.Location = new System.Drawing.Point(15, 57);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(149, 80);
            this.btnCustomers.TabIndex = 0;
            this.btnCustomers.Text = "Customers";
            this.btnCustomers.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCustomers.UseVisualStyleBackColor = true;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // btnAnalytics
            // 
            this.btnAnalytics.Enabled = false;
            this.btnAnalytics.Font = new System.Drawing.Font("Arial", 10F);
            this.btnAnalytics.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnAnalytics.Image = global::BayView1.Properties.Resources.Graphicloads_100_Flat_Analytics;
            this.btnAnalytics.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAnalytics.Location = new System.Drawing.Point(260, 57);
            this.btnAnalytics.Name = "btnAnalytics";
            this.btnAnalytics.Size = new System.Drawing.Size(149, 80);
            this.btnAnalytics.TabIndex = 1;
            this.btnAnalytics.Text = "Analytics";
            this.btnAnalytics.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAnalytics.UseVisualStyleBackColor = true;
            this.btnAnalytics.Click += new System.EventHandler(this.btnAnalytics_Click);
            // 
            // ManagerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 369);
            this.Controls.Add(this.btnStaff);
            this.Controls.Add(this.btnLog);
            this.Controls.Add(this.btnCustomers);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAnalytics);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManagerView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManagerView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnAnalytics;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnStaff;
    }
}
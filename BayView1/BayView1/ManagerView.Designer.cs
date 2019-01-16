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
            this.btnAnalytics = new System.Windows.Forms.Button();
            this.btnLog = new System.Windows.Forms.Button();
            this.btnMisc = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Arial", 10F);
            this.lblWelcome.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblWelcome.Location = new System.Drawing.Point(24, 21);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(116, 19);
            this.lblWelcome.TabIndex = 6;
            this.lblWelcome.Text = "Welcome label";
            // 
            // btnAnalytics
            // 
            this.btnAnalytics.Font = new System.Drawing.Font("Arial", 10F);
            this.btnAnalytics.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnAnalytics.Image = global::BayView1.Properties.Resources.Graphicloads_100_Flat_Analytics;
            this.btnAnalytics.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAnalytics.Location = new System.Drawing.Point(222, 57);
            this.btnAnalytics.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAnalytics.Name = "btnAnalytics";
            this.btnAnalytics.Size = new System.Drawing.Size(150, 80);
            this.btnAnalytics.TabIndex = 1;
            this.btnAnalytics.Text = "Analytics";
            this.btnAnalytics.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAnalytics.UseVisualStyleBackColor = true;
            this.btnAnalytics.Click += new System.EventHandler(this.btnAnalytics_Click);
            // 
            // btnLog
            // 
            this.btnLog.Font = new System.Drawing.Font("Arial", 10F);
            this.btnLog.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnLog.Image = global::BayView1.Properties.Resources.Graphicloads_100_Flat_Attach_2;
            this.btnLog.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLog.Location = new System.Drawing.Point(12, 186);
            this.btnLog.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(150, 80);
            this.btnLog.TabIndex = 2;
            this.btnLog.Text = "Logs";
            this.btnLog.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLog.UseVisualStyleBackColor = true;
            // 
            // btnMisc
            // 
            this.btnMisc.Enabled = false;
            this.btnMisc.Font = new System.Drawing.Font("Arial", 10F);
            this.btnMisc.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnMisc.Image = global::BayView1.Properties.Resources.Graphicloads_100_Flat_Info;
            this.btnMisc.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMisc.Location = new System.Drawing.Point(222, 186);
            this.btnMisc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMisc.Name = "btnMisc";
            this.btnMisc.Size = new System.Drawing.Size(150, 80);
            this.btnMisc.TabIndex = 3;
            this.btnMisc.Text = "Misc";
            this.btnMisc.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMisc.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Arial", 10F);
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(297, 308);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 32);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Close";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCustomers
            // 
            this.btnCustomers.Font = new System.Drawing.Font("Arial", 10F);
            this.btnCustomers.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnCustomers.Image = global::BayView1.Properties.Resources.Graphicloads_100_Flat_Contact;
            this.btnCustomers.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCustomers.Location = new System.Drawing.Point(12, 57);
            this.btnCustomers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(150, 80);
            this.btnCustomers.TabIndex = 0;
            this.btnCustomers.Text = "Customers";
            this.btnCustomers.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCustomers.UseVisualStyleBackColor = true;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // ManagerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 351);
            this.Controls.Add(this.btnLog);
            this.Controls.Add(this.btnCustomers);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnMisc);
            this.Controls.Add(this.btnAnalytics);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ManagerView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManagerView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnAnalytics;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.Button btnMisc;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCustomers;
    }
}
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
            this.btnCustomers = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnAnalytics = new System.Windows.Forms.Button();
            this.btnLog = new System.Windows.Forms.Button();
            this.btnMisc = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCustomers
            // 
            this.btnCustomers.Location = new System.Drawing.Point(15, 57);
            this.btnCustomers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(130, 90);
            this.btnCustomers.TabIndex = 0;
            this.btnCustomers.Text = "Customers";
            this.btnCustomers.UseVisualStyleBackColor = true;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Location = new System.Drawing.Point(12, 9);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(100, 17);
            this.lblWelcome.TabIndex = 6;
            this.lblWelcome.Text = "Welcome label";
            // 
            // btnAnalytics
            // 
            this.btnAnalytics.Location = new System.Drawing.Point(260, 57);
            this.btnAnalytics.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAnalytics.Name = "btnAnalytics";
            this.btnAnalytics.Size = new System.Drawing.Size(130, 90);
            this.btnAnalytics.TabIndex = 1;
            this.btnAnalytics.Text = "Analytics";
            this.btnAnalytics.UseVisualStyleBackColor = true;
            this.btnAnalytics.Click += new System.EventHandler(this.btnAnalytics_Click);
            // 
            // btnLog
            // 
            this.btnLog.Location = new System.Drawing.Point(12, 186);
            this.btnLog.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(130, 90);
            this.btnLog.TabIndex = 2;
            this.btnLog.Text = "Logs";
            this.btnLog.UseVisualStyleBackColor = true;
            // 
            // btnMisc
            // 
            this.btnMisc.Enabled = false;
            this.btnMisc.Location = new System.Drawing.Point(260, 186);
            this.btnMisc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMisc.Name = "btnMisc";
            this.btnMisc.Size = new System.Drawing.Size(130, 90);
            this.btnMisc.TabIndex = 3;
            this.btnMisc.Text = "Misc";
            this.btnMisc.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(260, 320);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(130, 29);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // ManagerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 351);
            this.Controls.Add(this.btnLog);
            this.Controls.Add(this.btnCustomers);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnMisc);
            this.Controls.Add(this.btnAnalytics);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.Button btnMisc;
        private System.Windows.Forms.Button btnExit;
    }
}
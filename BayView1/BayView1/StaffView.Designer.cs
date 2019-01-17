namespace BayView1
{
    partial class StaffView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffView));
            this.btnCustomerOld = new System.Windows.Forms.Button();
            this.btnBookings = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SysTimeLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BJTimeLbl = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCustomerOld
            // 
            this.btnCustomerOld.Font = new System.Drawing.Font("Arial", 10F);
            this.btnCustomerOld.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnCustomerOld.Location = new System.Drawing.Point(158, 158);
            this.btnCustomerOld.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCustomerOld.Name = "btnCustomerOld";
            this.btnCustomerOld.Size = new System.Drawing.Size(112, 65);
            this.btnCustomerOld.TabIndex = 3;
            this.btnCustomerOld.Text = "Customers OLD";
            this.btnCustomerOld.UseVisualStyleBackColor = true;
            this.btnCustomerOld.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // btnBookings
            // 
            this.btnBookings.Font = new System.Drawing.Font("Arial", 10F);
            this.btnBookings.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnBookings.Image = global::BayView1.Properties.Resources.Graphicloads_100_Flat_Phonebook;
            this.btnBookings.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBookings.Location = new System.Drawing.Point(158, 58);
            this.btnBookings.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBookings.Name = "btnBookings";
            this.btnBookings.Size = new System.Drawing.Size(112, 65);
            this.btnBookings.TabIndex = 1;
            this.btnBookings.Text = "Bookings";
            this.btnBookings.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBookings.UseVisualStyleBackColor = true;
            this.btnBookings.Click += new System.EventHandler(this.btnBookings_Click);
            // 
            // btnChange
            // 
            this.btnChange.Font = new System.Drawing.Font("Arial", 10F);
            this.btnChange.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnChange.Location = new System.Drawing.Point(12, 158);
            this.btnChange.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(112, 65);
            this.btnChange.TabIndex = 2;
            this.btnChange.Text = "Change Password";
            this.btnChange.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F);
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "welcome label";
            // 
            // SysTimeLbl
            // 
            this.SysTimeLbl.AutoSize = true;
            this.SysTimeLbl.Font = new System.Drawing.Font("Arial", 10F);
            this.SysTimeLbl.ForeColor = System.Drawing.SystemColors.Highlight;
            this.SysTimeLbl.Location = new System.Drawing.Point(94, 253);
            this.SysTimeLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SysTimeLbl.Name = "SysTimeLbl";
            this.SysTimeLbl.Size = new System.Drawing.Size(46, 16);
            this.SysTimeLbl.TabIndex = 6;
            this.SysTimeLbl.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10F);
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(9, 253);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Local Time:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10F);
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(9, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Beijing Time:";
            // 
            // BJTimeLbl
            // 
            this.BJTimeLbl.AutoSize = true;
            this.BJTimeLbl.Font = new System.Drawing.Font("Arial", 10F);
            this.BJTimeLbl.ForeColor = System.Drawing.SystemColors.Highlight;
            this.BJTimeLbl.Location = new System.Drawing.Point(94, 280);
            this.BJTimeLbl.Name = "BJTimeLbl";
            this.BJTimeLbl.Size = new System.Drawing.Size(46, 16);
            this.BJTimeLbl.TabIndex = 8;
            this.BJTimeLbl.Text = "label4";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Arial", 10F);
            this.btnExit.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnExit.Location = new System.Drawing.Point(208, 362);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(56, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCustomers
            // 
            this.btnCustomers.Font = new System.Drawing.Font("Arial", 10F);
            this.btnCustomers.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnCustomers.Image = global::BayView1.Properties.Resources.Graphicloads_100_Flat_Contact;
            this.btnCustomers.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCustomers.Location = new System.Drawing.Point(12, 58);
            this.btnCustomers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(112, 65);
            this.btnCustomers.TabIndex = 0;
            this.btnCustomers.Text = "Customers";
            this.btnCustomers.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCustomers.UseVisualStyleBackColor = true;
            this.btnCustomers.Click += new System.EventHandler(this.btnMark_Click);
            // 
            // StaffView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 394);
            this.Controls.Add(this.btnCustomers);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.BJTimeLbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SysTimeLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.btnBookings);
            this.Controls.Add(this.btnCustomerOld);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "StaffView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StaffView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCustomerOld;
        private System.Windows.Forms.Button btnBookings;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label SysTimeLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label BJTimeLbl;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCustomers;
    }
}
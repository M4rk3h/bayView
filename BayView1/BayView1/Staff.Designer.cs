namespace BayView1
{
    partial class Staff
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
            this.btnNewStaff = new System.Windows.Forms.Button();
            this.btnStaffData = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNewStaff
            // 
            this.btnNewStaff.Location = new System.Drawing.Point(25, 21);
            this.btnNewStaff.Name = "btnNewStaff";
            this.btnNewStaff.Size = new System.Drawing.Size(120, 23);
            this.btnNewStaff.TabIndex = 0;
            this.btnNewStaff.Text = "Add a New Staff";
            this.btnNewStaff.UseVisualStyleBackColor = true;
            // 
            // btnStaffData
            // 
            this.btnStaffData.Location = new System.Drawing.Point(183, 21);
            this.btnStaffData.Name = "btnStaffData";
            this.btnStaffData.Size = new System.Drawing.Size(75, 23);
            this.btnStaffData.TabIndex = 1;
            this.btnStaffData.Text = "Staff info";
            this.btnStaffData.UseVisualStyleBackColor = true;
            // 
            // Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 549);
            this.Controls.Add(this.btnStaffData);
            this.Controls.Add(this.btnNewStaff);
            this.Name = "Staff";
            this.Text = "Staff";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNewStaff;
        private System.Windows.Forms.Button btnStaffData;
    }
}
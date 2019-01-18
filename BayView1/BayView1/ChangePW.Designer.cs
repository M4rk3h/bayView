namespace BayView1
{
    partial class ChangePW
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
            this.btnConfirm = new System.Windows.Forms.Button();
            this.lblPW = new System.Windows.Forms.Label();
            this.lblCPW = new System.Windows.Forms.Label();
            this.tbPW = new System.Windows.Forms.TextBox();
            this.tbCPW = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(88, 165);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 0;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // lblPW
            // 
            this.lblPW.AutoSize = true;
            this.lblPW.Location = new System.Drawing.Point(69, 48);
            this.lblPW.Name = "lblPW";
            this.lblPW.Size = new System.Drawing.Size(83, 12);
            this.lblPW.TabIndex = 1;
            this.lblPW.Text = "New Password:";
            // 
            // lblCPW
            // 
            this.lblCPW.AutoSize = true;
            this.lblCPW.Location = new System.Drawing.Point(69, 102);
            this.lblCPW.Name = "lblCPW";
            this.lblCPW.Size = new System.Drawing.Size(107, 12);
            this.lblCPW.TabIndex = 2;
            this.lblCPW.Text = "Confirm Password:";
            // 
            // tbPW
            // 
            this.tbPW.Location = new System.Drawing.Point(182, 45);
            this.tbPW.Name = "tbPW";
            this.tbPW.PasswordChar = '*';
            this.tbPW.Size = new System.Drawing.Size(100, 21);
            this.tbPW.TabIndex = 3;
            // 
            // tbCPW
            // 
            this.tbCPW.Location = new System.Drawing.Point(182, 99);
            this.tbCPW.Name = "tbCPW";
            this.tbCPW.PasswordChar = '*';
            this.tbCPW.Size = new System.Drawing.Size(100, 21);
            this.tbCPW.TabIndex = 4;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(196, 165);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(32, 142);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 12);
            this.lblError.TabIndex = 6;
            // 
            // ChangePW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 211);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.tbCPW);
            this.Controls.Add(this.tbPW);
            this.Controls.Add(this.lblCPW);
            this.Controls.Add(this.lblPW);
            this.Controls.Add(this.btnConfirm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChangePW";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangePW";
            this.Load += new System.EventHandler(this.ChangePW_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label lblPW;
        private System.Windows.Forms.Label lblCPW;
        private System.Windows.Forms.TextBox tbPW;
        private System.Windows.Forms.TextBox tbCPW;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblError;
    }
}
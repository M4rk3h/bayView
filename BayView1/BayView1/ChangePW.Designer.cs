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
            this.btnConfirm.Font = new System.Drawing.Font("Arial", 10F);
            this.btnConfirm.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnConfirm.Location = new System.Drawing.Point(117, 220);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(100, 31);
            this.btnConfirm.TabIndex = 2;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // lblPW
            // 
            this.lblPW.AutoSize = true;
            this.lblPW.Font = new System.Drawing.Font("Arial", 10F);
            this.lblPW.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblPW.Location = new System.Drawing.Point(92, 64);
            this.lblPW.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPW.Name = "lblPW";
            this.lblPW.Size = new System.Drawing.Size(121, 19);
            this.lblPW.TabIndex = 4;
            this.lblPW.Text = "New Password:";
            // 
            // lblCPW
            // 
            this.lblCPW.AutoSize = true;
            this.lblCPW.Font = new System.Drawing.Font("Arial", 10F);
            this.lblCPW.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblCPW.Location = new System.Drawing.Point(69, 135);
            this.lblCPW.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCPW.Name = "lblCPW";
            this.lblCPW.Size = new System.Drawing.Size(148, 19);
            this.lblCPW.TabIndex = 5;
            this.lblCPW.Text = "Confirm Password:";
            // 
            // tbPW
            // 
            this.tbPW.Font = new System.Drawing.Font("Arial", 10F);
            this.tbPW.ForeColor = System.Drawing.SystemColors.Highlight;
            this.tbPW.Location = new System.Drawing.Point(252, 61);
            this.tbPW.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbPW.Name = "tbPW";
            this.tbPW.PasswordChar = '*';
            this.tbPW.Size = new System.Drawing.Size(132, 27);
            this.tbPW.TabIndex = 0;
            // 
            // tbCPW
            // 
            this.tbCPW.Font = new System.Drawing.Font("Arial", 10F);
            this.tbCPW.ForeColor = System.Drawing.SystemColors.Highlight;
            this.tbCPW.Location = new System.Drawing.Point(252, 132);
            this.tbCPW.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbCPW.Name = "tbCPW";
            this.tbCPW.PasswordChar = '*';
            this.tbCPW.Size = new System.Drawing.Size(132, 27);
            this.tbCPW.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Arial", 10F);
            this.btnCancel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnCancel.Location = new System.Drawing.Point(261, 220);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 31);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(43, 189);
            this.lblError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 17);
            this.lblError.TabIndex = 6;
            // 
            // ChangePW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 281);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.tbCPW);
            this.Controls.Add(this.tbPW);
            this.Controls.Add(this.lblCPW);
            this.Controls.Add(this.lblPW);
            this.Controls.Add(this.btnConfirm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
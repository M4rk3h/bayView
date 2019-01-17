namespace BayView1
{
    partial class Booking_Orders
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
            this.lblBookingNo = new System.Windows.Forms.Label();
            this.cbbookingNo1 = new System.Windows.Forms.ComboBox();
            this.lbltotalpaid = new System.Windows.Forms.Label();
            this.lblbookingno1 = new System.Windows.Forms.Label();
            this.cbbookingNo = new System.Windows.Forms.ComboBox();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txttotalpaid = new System.Windows.Forms.TextBox();
            this.txttotalpaid1 = new System.Windows.Forms.TextBox();
            this.lbltotalpaid2 = new System.Windows.Forms.Label();
            this.lbltotalpaid1 = new System.Windows.Forms.Label();
            this.cbtotalpaid = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBookingNo
            // 
            this.lblBookingNo.AutoSize = true;
            this.lblBookingNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookingNo.Location = new System.Drawing.Point(433, 44);
            this.lblBookingNo.Name = "lblBookingNo";
            this.lblBookingNo.Size = new System.Drawing.Size(60, 13);
            this.lblBookingNo.TabIndex = 111;
            this.lblBookingNo.Text = "BookingNo";
            // 
            // cbbookingNo1
            // 
            this.cbbookingNo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbookingNo1.FormattingEnabled = true;
            this.cbbookingNo1.Location = new System.Drawing.Point(510, 41);
            this.cbbookingNo1.Name = "cbbookingNo1";
            this.cbbookingNo1.Size = new System.Drawing.Size(193, 21);
            this.cbbookingNo1.TabIndex = 110;
            this.cbbookingNo1.SelectedIndexChanged += new System.EventHandler(this.cbbookingNo1_SelectedIndexChanged);
            // 
            // lbltotalpaid
            // 
            this.lbltotalpaid.AutoSize = true;
            this.lbltotalpaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalpaid.Location = new System.Drawing.Point(21, 173);
            this.lbltotalpaid.Name = "lbltotalpaid";
            this.lbltotalpaid.Size = new System.Drawing.Size(55, 13);
            this.lbltotalpaid.TabIndex = 105;
            this.lbltotalpaid.Text = "Total Paid";
            // 
            // lblbookingno1
            // 
            this.lblbookingno1.AutoSize = true;
            this.lblbookingno1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbookingno1.Location = new System.Drawing.Point(25, 95);
            this.lblbookingno1.Name = "lblbookingno1";
            this.lblbookingno1.Size = new System.Drawing.Size(60, 13);
            this.lblbookingno1.TabIndex = 100;
            this.lblbookingno1.Text = "BookingNo";
            // 
            // cbbookingNo
            // 
            this.cbbookingNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbookingNo.FormattingEnabled = true;
            this.cbbookingNo.Location = new System.Drawing.Point(108, 96);
            this.cbbookingNo.Name = "cbbookingNo";
            this.cbbookingNo.Size = new System.Drawing.Size(193, 21);
            this.cbbookingNo.TabIndex = 97;
            this.cbbookingNo.SelectedIndexChanged += new System.EventHandler(this.cbbookingNo_SelectedIndexChanged);
            // 
            // btndelete
            // 
            this.btndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.Location = new System.Drawing.Point(737, 18);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(122, 62);
            this.btndelete.TabIndex = 95;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnclose
            // 
            this.btnclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.Location = new System.Drawing.Point(469, 284);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(122, 50);
            this.btnclose.TabIndex = 94;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // btncancel
            // 
            this.btncancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancel.Location = new System.Drawing.Point(243, 284);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(133, 50);
            this.btncancel.TabIndex = 93;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(28, 221);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(137, 50);
            this.btnSubmit.TabIndex = 92;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txttotalpaid
            // 
            this.txttotalpaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotalpaid.Location = new System.Drawing.Point(82, 165);
            this.txttotalpaid.Name = "txttotalpaid";
            this.txttotalpaid.Size = new System.Drawing.Size(232, 26);
            this.txttotalpaid.TabIndex = 124;
            // 
            // txttotalpaid1
            // 
            this.txttotalpaid1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotalpaid1.Location = new System.Drawing.Point(491, 165);
            this.txttotalpaid1.Name = "txttotalpaid1";
            this.txttotalpaid1.Size = new System.Drawing.Size(232, 26);
            this.txttotalpaid1.TabIndex = 132;
            // 
            // lbltotalpaid2
            // 
            this.lbltotalpaid2.AutoSize = true;
            this.lbltotalpaid2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalpaid2.Location = new System.Drawing.Point(430, 173);
            this.lbltotalpaid2.Name = "lbltotalpaid2";
            this.lbltotalpaid2.Size = new System.Drawing.Size(55, 13);
            this.lbltotalpaid2.TabIndex = 127;
            this.lbltotalpaid2.Text = "Total Paid";
            // 
            // lbltotalpaid1
            // 
            this.lbltotalpaid1.AutoSize = true;
            this.lbltotalpaid1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalpaid1.Location = new System.Drawing.Point(427, 123);
            this.lbltotalpaid1.Name = "lbltotalpaid1";
            this.lbltotalpaid1.Size = new System.Drawing.Size(55, 13);
            this.lbltotalpaid1.TabIndex = 126;
            this.lbltotalpaid1.Text = "Total Paid";
            // 
            // cbtotalpaid
            // 
            this.cbtotalpaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbtotalpaid.FormattingEnabled = true;
            this.cbtotalpaid.Location = new System.Drawing.Point(510, 124);
            this.cbtotalpaid.Name = "cbtotalpaid";
            this.cbtotalpaid.Size = new System.Drawing.Size(193, 21);
            this.cbtotalpaid.TabIndex = 125;
            this.cbtotalpaid.SelectedIndexChanged += new System.EventHandler(this.cbtotalpaid_SelectedIndexChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(771, 153);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(123, 50);
            this.btnUpdate.TabIndex = 135;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // Booking_Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 381);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txttotalpaid1);
            this.Controls.Add(this.lbltotalpaid2);
            this.Controls.Add(this.lbltotalpaid1);
            this.Controls.Add(this.cbtotalpaid);
            this.Controls.Add(this.txttotalpaid);
            this.Controls.Add(this.lblBookingNo);
            this.Controls.Add(this.cbbookingNo1);
            this.Controls.Add(this.lbltotalpaid);
            this.Controls.Add(this.lblbookingno1);
            this.Controls.Add(this.cbbookingNo);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnSubmit);
            this.Name = "Booking_Orders";
            this.Text = "Booking_Orders";
            this.Load += new System.EventHandler(this.Booking_Orders_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblBookingNo;
        private System.Windows.Forms.ComboBox cbbookingNo1;
        private System.Windows.Forms.Label lbltotalpaid;
        private System.Windows.Forms.Label lblbookingno1;
        private System.Windows.Forms.ComboBox cbbookingNo;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txttotalpaid;
        private System.Windows.Forms.TextBox txttotalpaid1;
        private System.Windows.Forms.Label lbltotalpaid2;
        private System.Windows.Forms.Label lbltotalpaid1;
        private System.Windows.Forms.ComboBox cbtotalpaid;
        private System.Windows.Forms.Button btnUpdate;
    }
}
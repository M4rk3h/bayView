namespace bookings
{
    partial class Homeform
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.connectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Search = new System.Windows.Forms.ToolStripMenuItem();
            this.testcon = new System.Windows.Forms.ToolStripMenuItem();
            this.Booking = new System.Windows.Forms.ToolStripMenuItem();
            this.UpdateBooking = new System.Windows.Forms.ToolStripMenuItem();
            this.bookingOrders = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelation = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tssImage = new System.Windows.Forms.ToolStripStatusLabel();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ConnectQ = new System.Windows.Forms.ToolStripLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectionToolStripMenuItem,
            this.Booking,
            this.UpdateBooking,
            this.bookingOrders,
            this.cancelation});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // connectionToolStripMenuItem
            // 
            this.connectionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Search,
            this.testcon});
            this.connectionToolStripMenuItem.Name = "connectionToolStripMenuItem";
            this.connectionToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.connectionToolStripMenuItem.Text = "Connection";
            // 
            // Search
            // 
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(180, 22);
            this.Search.Text = "Select Database";
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // testcon
            // 
            this.testcon.Name = "testcon";
            this.testcon.Size = new System.Drawing.Size(180, 22);
            this.testcon.Text = "Test connection";
            this.testcon.Click += new System.EventHandler(this.testcon_Click);
            // 
            // Booking
            // 
            this.Booking.Name = "Booking";
            this.Booking.Size = new System.Drawing.Size(90, 20);
            this.Booking.Text = "New Booking";
            this.Booking.Click += new System.EventHandler(this.Booking_Click);
            // 
            // UpdateBooking
            // 
            this.UpdateBooking.Name = "UpdateBooking";
            this.UpdateBooking.Size = new System.Drawing.Size(104, 20);
            this.UpdateBooking.Text = "Update Booking";
            this.UpdateBooking.Click += new System.EventHandler(this.UpdateBooking_Click);
            // 
            // bookingOrders
            // 
            this.bookingOrders.Name = "bookingOrders";
            this.bookingOrders.Size = new System.Drawing.Size(101, 20);
            this.bookingOrders.Text = "Booking Orders";
            this.bookingOrders.Click += new System.EventHandler(this.bookingOrders_Click);
            // 
            // cancelation
            // 
            this.cancelation.Name = "cancelation";
            this.cancelation.Size = new System.Drawing.Size(113, 20);
            this.cancelation.Text = "Cancelation Form";
            this.cancelation.Click += new System.EventHandler(this.cancelation_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssImage});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "No Database";
            // 
            // tssImage
            // 
            this.tssImage.Name = "tssImage";
            this.tssImage.Size = new System.Drawing.Size(90, 17);
            this.tssImage.Text = "No Database";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ConnectQ});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // ConnectQ
            // 
            this.ConnectQ.Name = "ConnectQ";
            this.ConnectQ.Size = new System.Drawing.Size(86, 22);
            this.ConnectQ.Text = "Connect Quick";
            this.ConnectQ.Click += new System.EventHandler(this.ConnectQ_Click);
            // 
            // Homeform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Homeform";
            this.Text = "Homeform";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem connectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Search;
        private System.Windows.Forms.ToolStripMenuItem testcon;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel ConnectQ;
        private System.Windows.Forms.ToolStripMenuItem Booking;
        private System.Windows.Forms.ToolStripMenuItem UpdateBooking;
        private System.Windows.Forms.ToolStripMenuItem bookingOrders;
        private System.Windows.Forms.ToolStripStatusLabel tssImage;
        private System.Windows.Forms.ToolStripMenuItem cancelation;
    }
}
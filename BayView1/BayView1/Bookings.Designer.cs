namespace BayView1
{
    partial class Bookings
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
            this.lblbreakfast = new System.Windows.Forms.Label();
            this.cbbreakfast = new System.Windows.Forms.ComboBox();
            this.numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.lblduration = new System.Windows.Forms.Label();
            this.lbldateout = new System.Windows.Forms.Label();
            this.lbldatedue = new System.Windows.Forms.Label();
            this.lblavailable = new System.Windows.Forms.Label();
            this.cbavailability = new System.Windows.Forms.ComboBox();
            this.lbldisability1 = new System.Windows.Forms.Label();
            this.cbdisability = new System.Windows.Forms.ComboBox();
            this.lbllastname = new System.Windows.Forms.Label();
            this.cblastname = new System.Windows.Forms.ComboBox();
            this.lblfirstname = new System.Windows.Forms.Label();
            this.cbfirstname = new System.Windows.Forms.ComboBox();
            this.lblstaffname = new System.Windows.Forms.Label();
            this.cbstaffname = new System.Windows.Forms.ComboBox();
            this.lblroomno1 = new System.Windows.Forms.Label();
            this.lblcustomerno = new System.Windows.Forms.Label();
            this.lblstaffno = new System.Windows.Forms.Label();
            this.cbroomNo = new System.Windows.Forms.ComboBox();
            this.cbcustomerNo = new System.Windows.Forms.ComboBox();
            this.cbstaffNo = new System.Windows.Forms.ComboBox();
            this.lblavailabilitycheck = new System.Windows.Forms.Label();
            this.cbavailabilitycheck = new System.Windows.Forms.ComboBox();
            this.lblroomnumber = new System.Windows.Forms.Label();
            this.cbroomnumber = new System.Windows.Forms.ComboBox();
            this.lblroomtype = new System.Windows.Forms.Label();
            this.cbroomtype = new System.Windows.Forms.ComboBox();
            this.lbltotalprice = new System.Windows.Forms.Label();
            this.cbtotalprice = new System.Windows.Forms.ComboBox();
            this.txtdatedue = new System.Windows.Forms.TextBox();
            this.txtdateout = new System.Windows.Forms.TextBox();
            this.lblroomtype1 = new System.Windows.Forms.Label();
            this.lblroomnumber1 = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblbreakfast
            // 
            this.lblbreakfast.AutoSize = true;
            this.lblbreakfast.Font = new System.Drawing.Font("Arial", 10F);
            this.lblbreakfast.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblbreakfast.Location = new System.Drawing.Point(10, 380);
            this.lblbreakfast.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblbreakfast.Name = "lblbreakfast";
            this.lblbreakfast.Size = new System.Drawing.Size(78, 19);
            this.lblbreakfast.TabIndex = 117;
            this.lblbreakfast.Text = "Breakfast";
            // 
            // cbbreakfast
            // 
            this.cbbreakfast.Font = new System.Drawing.Font("Arial", 10F);
            this.cbbreakfast.ForeColor = System.Drawing.SystemColors.Highlight;
            this.cbbreakfast.FormattingEnabled = true;
            this.cbbreakfast.Location = new System.Drawing.Point(165, 380);
            this.cbbreakfast.Margin = new System.Windows.Forms.Padding(4);
            this.cbbreakfast.Name = "cbbreakfast";
            this.cbbreakfast.Size = new System.Drawing.Size(250, 27);
            this.cbbreakfast.TabIndex = 116;
            this.cbbreakfast.SelectedIndexChanged += new System.EventHandler(this.cbbreakfast_SelectedIndexChanged);
            // 
            // numericUpDown
            // 
            this.numericUpDown.Font = new System.Drawing.Font("Arial", 10F);
            this.numericUpDown.ForeColor = System.Drawing.SystemColors.Highlight;
            this.numericUpDown.Location = new System.Drawing.Point(163, 490);
            this.numericUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDown.Name = "numericUpDown";
            this.numericUpDown.Size = new System.Drawing.Size(250, 27);
            this.numericUpDown.TabIndex = 115;
            this.numericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            // 
            // lblduration
            // 
            this.lblduration.AutoSize = true;
            this.lblduration.Font = new System.Drawing.Font("Arial", 10F);
            this.lblduration.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblduration.Location = new System.Drawing.Point(10, 490);
            this.lblduration.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblduration.Name = "lblduration";
            this.lblduration.Size = new System.Drawing.Size(71, 19);
            this.lblduration.TabIndex = 114;
            this.lblduration.Text = "Duration";
            // 
            // lbldateout
            // 
            this.lbldateout.AutoSize = true;
            this.lbldateout.Font = new System.Drawing.Font("Arial", 10F);
            this.lbldateout.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbldateout.Location = new System.Drawing.Point(830, 50);
            this.lbldateout.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbldateout.Name = "lbldateout";
            this.lbldateout.Size = new System.Drawing.Size(73, 19);
            this.lbldateout.TabIndex = 113;
            this.lbldateout.Text = "Date Out";
            // 
            // lbldatedue
            // 
            this.lbldatedue.AutoSize = true;
            this.lbldatedue.Font = new System.Drawing.Font("Arial", 10F);
            this.lbldatedue.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbldatedue.Location = new System.Drawing.Point(830, 10);
            this.lbldatedue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbldatedue.Name = "lbldatedue";
            this.lbldatedue.Size = new System.Drawing.Size(78, 19);
            this.lbldatedue.TabIndex = 109;
            this.lbldatedue.Text = "Date Due";
            // 
            // lblavailable
            // 
            this.lblavailable.AutoSize = true;
            this.lblavailable.Font = new System.Drawing.Font("Arial", 10F);
            this.lblavailable.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblavailable.Location = new System.Drawing.Point(10, 300);
            this.lblavailable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblavailable.Name = "lblavailable";
            this.lblavailable.Size = new System.Drawing.Size(133, 19);
            this.lblavailable.TabIndex = 107;
            this.lblavailable.Text = "Availabilty Check";
            // 
            // cbavailability
            // 
            this.cbavailability.Font = new System.Drawing.Font("Arial", 10F);
            this.cbavailability.ForeColor = System.Drawing.SystemColors.Highlight;
            this.cbavailability.FormattingEnabled = true;
            this.cbavailability.Location = new System.Drawing.Point(165, 300);
            this.cbavailability.Margin = new System.Windows.Forms.Padding(4);
            this.cbavailability.Name = "cbavailability";
            this.cbavailability.Size = new System.Drawing.Size(250, 27);
            this.cbavailability.TabIndex = 106;
            this.cbavailability.SelectedIndexChanged += new System.EventHandler(this.cbavailability_SelectedIndexChanged);
            // 
            // lbldisability1
            // 
            this.lbldisability1.AutoSize = true;
            this.lbldisability1.Font = new System.Drawing.Font("Arial", 10F);
            this.lbldisability1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbldisability1.Location = new System.Drawing.Point(10, 260);
            this.lbldisability1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbldisability1.Name = "lbldisability1";
            this.lbldisability1.Size = new System.Drawing.Size(127, 19);
            this.lbldisability1.TabIndex = 105;
            this.lbldisability1.Text = "Disability Check";
            // 
            // cbdisability
            // 
            this.cbdisability.Font = new System.Drawing.Font("Arial", 10F);
            this.cbdisability.ForeColor = System.Drawing.SystemColors.Highlight;
            this.cbdisability.FormattingEnabled = true;
            this.cbdisability.Location = new System.Drawing.Point(165, 260);
            this.cbdisability.Margin = new System.Windows.Forms.Padding(4);
            this.cbdisability.Name = "cbdisability";
            this.cbdisability.Size = new System.Drawing.Size(250, 27);
            this.cbdisability.TabIndex = 104;
            this.cbdisability.SelectedIndexChanged += new System.EventHandler(this.cbdisability_SelectedIndexChanged);
            // 
            // lbllastname
            // 
            this.lbllastname.AutoSize = true;
            this.lbllastname.Font = new System.Drawing.Font("Arial", 10F);
            this.lbllastname.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbllastname.Location = new System.Drawing.Point(440, 90);
            this.lbllastname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbllastname.Name = "lbllastname";
            this.lbllastname.Size = new System.Drawing.Size(86, 19);
            this.lbllastname.TabIndex = 103;
            this.lbllastname.Text = "Last Name";
            // 
            // cblastname
            // 
            this.cblastname.Font = new System.Drawing.Font("Arial", 10F);
            this.cblastname.ForeColor = System.Drawing.SystemColors.Highlight;
            this.cblastname.FormattingEnabled = true;
            this.cblastname.Location = new System.Drawing.Point(560, 90);
            this.cblastname.Margin = new System.Windows.Forms.Padding(4);
            this.cblastname.Name = "cblastname";
            this.cblastname.Size = new System.Drawing.Size(250, 27);
            this.cblastname.TabIndex = 102;
            this.cblastname.SelectedIndexChanged += new System.EventHandler(this.cblastname_SelectedIndexChanged);
            // 
            // lblfirstname
            // 
            this.lblfirstname.AutoSize = true;
            this.lblfirstname.Font = new System.Drawing.Font("Arial", 10F);
            this.lblfirstname.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblfirstname.Location = new System.Drawing.Point(440, 50);
            this.lblfirstname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblfirstname.Name = "lblfirstname";
            this.lblfirstname.Size = new System.Drawing.Size(88, 19);
            this.lblfirstname.TabIndex = 101;
            this.lblfirstname.Text = "First Name";
            // 
            // cbfirstname
            // 
            this.cbfirstname.Font = new System.Drawing.Font("Arial", 10F);
            this.cbfirstname.ForeColor = System.Drawing.SystemColors.Highlight;
            this.cbfirstname.FormattingEnabled = true;
            this.cbfirstname.Location = new System.Drawing.Point(560, 50);
            this.cbfirstname.Margin = new System.Windows.Forms.Padding(4);
            this.cbfirstname.Name = "cbfirstname";
            this.cbfirstname.Size = new System.Drawing.Size(250, 27);
            this.cbfirstname.TabIndex = 100;
            this.cbfirstname.SelectedIndexChanged += new System.EventHandler(this.cbfirstname_SelectedIndexChanged);
            // 
            // lblstaffname
            // 
            this.lblstaffname.AutoSize = true;
            this.lblstaffname.Font = new System.Drawing.Font("Arial", 10F);
            this.lblstaffname.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblstaffname.Location = new System.Drawing.Point(10, 50);
            this.lblstaffname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblstaffname.Name = "lblstaffname";
            this.lblstaffname.Size = new System.Drawing.Size(90, 19);
            this.lblstaffname.TabIndex = 99;
            this.lblstaffname.Text = "Staff Name";
            // 
            // cbstaffname
            // 
            this.cbstaffname.Font = new System.Drawing.Font("Arial", 10F);
            this.cbstaffname.ForeColor = System.Drawing.SystemColors.Highlight;
            this.cbstaffname.FormattingEnabled = true;
            this.cbstaffname.Location = new System.Drawing.Point(165, 50);
            this.cbstaffname.Margin = new System.Windows.Forms.Padding(4);
            this.cbstaffname.Name = "cbstaffname";
            this.cbstaffname.Size = new System.Drawing.Size(250, 27);
            this.cbstaffname.TabIndex = 98;
            this.cbstaffname.SelectedIndexChanged += new System.EventHandler(this.cbstaffname_SelectedIndexChanged);
            // 
            // lblroomno1
            // 
            this.lblroomno1.AutoSize = true;
            this.lblroomno1.Font = new System.Drawing.Font("Arial", 10F);
            this.lblroomno1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblroomno1.Location = new System.Drawing.Point(10, 90);
            this.lblroomno1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblroomno1.Name = "lblroomno1";
            this.lblroomno1.Size = new System.Drawing.Size(76, 19);
            this.lblroomno1.TabIndex = 97;
            this.lblroomno1.Text = "Room No";
            // 
            // lblcustomerno
            // 
            this.lblcustomerno.AutoSize = true;
            this.lblcustomerno.Font = new System.Drawing.Font("Arial", 10F);
            this.lblcustomerno.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblcustomerno.Location = new System.Drawing.Point(440, 10);
            this.lblcustomerno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcustomerno.Name = "lblcustomerno";
            this.lblcustomerno.Size = new System.Drawing.Size(104, 19);
            this.lblcustomerno.TabIndex = 96;
            this.lblcustomerno.Text = "Customer No";
            // 
            // lblstaffno
            // 
            this.lblstaffno.AutoSize = true;
            this.lblstaffno.Font = new System.Drawing.Font("Arial", 10F);
            this.lblstaffno.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblstaffno.Location = new System.Drawing.Point(10, 10);
            this.lblstaffno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblstaffno.Name = "lblstaffno";
            this.lblstaffno.Size = new System.Drawing.Size(68, 19);
            this.lblstaffno.TabIndex = 95;
            this.lblstaffno.Text = "Staff No";
            // 
            // cbroomNo
            // 
            this.cbroomNo.Font = new System.Drawing.Font("Arial", 10F);
            this.cbroomNo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.cbroomNo.FormattingEnabled = true;
            this.cbroomNo.Location = new System.Drawing.Point(165, 90);
            this.cbroomNo.Margin = new System.Windows.Forms.Padding(4);
            this.cbroomNo.Name = "cbroomNo";
            this.cbroomNo.Size = new System.Drawing.Size(250, 27);
            this.cbroomNo.TabIndex = 94;
            this.cbroomNo.SelectedIndexChanged += new System.EventHandler(this.cbroomNo_SelectedIndexChanged);
            // 
            // cbcustomerNo
            // 
            this.cbcustomerNo.Font = new System.Drawing.Font("Arial", 10F);
            this.cbcustomerNo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.cbcustomerNo.FormattingEnabled = true;
            this.cbcustomerNo.Location = new System.Drawing.Point(560, 10);
            this.cbcustomerNo.Margin = new System.Windows.Forms.Padding(4);
            this.cbcustomerNo.Name = "cbcustomerNo";
            this.cbcustomerNo.Size = new System.Drawing.Size(250, 27);
            this.cbcustomerNo.TabIndex = 93;
            this.cbcustomerNo.SelectedIndexChanged += new System.EventHandler(this.cbcustomerNo_SelectedIndexChanged);
            // 
            // cbstaffNo
            // 
            this.cbstaffNo.Font = new System.Drawing.Font("Arial", 10F);
            this.cbstaffNo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.cbstaffNo.FormattingEnabled = true;
            this.cbstaffNo.Location = new System.Drawing.Point(165, 10);
            this.cbstaffNo.Margin = new System.Windows.Forms.Padding(4);
            this.cbstaffNo.Name = "cbstaffNo";
            this.cbstaffNo.Size = new System.Drawing.Size(250, 27);
            this.cbstaffNo.TabIndex = 92;
            this.cbstaffNo.SelectedIndexChanged += new System.EventHandler(this.cbstaffNo_SelectedIndexChanged);
            // 
            // lblavailabilitycheck
            // 
            this.lblavailabilitycheck.AutoSize = true;
            this.lblavailabilitycheck.Font = new System.Drawing.Font("Arial", 10F);
            this.lblavailabilitycheck.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblavailabilitycheck.Location = new System.Drawing.Point(10, 340);
            this.lblavailabilitycheck.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblavailabilitycheck.Name = "lblavailabilitycheck";
            this.lblavailabilitycheck.Size = new System.Drawing.Size(157, 19);
            this.lblavailabilitycheck.TabIndex = 119;
            this.lblavailabilitycheck.Text = "Expected Availabilty ";
            // 
            // cbavailabilitycheck
            // 
            this.cbavailabilitycheck.Font = new System.Drawing.Font("Arial", 10F);
            this.cbavailabilitycheck.ForeColor = System.Drawing.SystemColors.Highlight;
            this.cbavailabilitycheck.FormattingEnabled = true;
            this.cbavailabilitycheck.Location = new System.Drawing.Point(165, 340);
            this.cbavailabilitycheck.Margin = new System.Windows.Forms.Padding(4);
            this.cbavailabilitycheck.Name = "cbavailabilitycheck";
            this.cbavailabilitycheck.Size = new System.Drawing.Size(250, 27);
            this.cbavailabilitycheck.TabIndex = 118;
            this.cbavailabilitycheck.SelectedIndexChanged += new System.EventHandler(this.cbavailabilitycheck_SelectedIndexChanged);
            // 
            // lblroomnumber
            // 
            this.lblroomnumber.AutoSize = true;
            this.lblroomnumber.Font = new System.Drawing.Font("Arial", 10F);
            this.lblroomnumber.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblroomnumber.Location = new System.Drawing.Point(10, 130);
            this.lblroomnumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblroomnumber.Name = "lblroomnumber";
            this.lblroomnumber.Size = new System.Drawing.Size(113, 19);
            this.lblroomnumber.TabIndex = 121;
            this.lblroomnumber.Text = "Room Number";
            // 
            // cbroomnumber
            // 
            this.cbroomnumber.Font = new System.Drawing.Font("Arial", 10F);
            this.cbroomnumber.ForeColor = System.Drawing.SystemColors.Highlight;
            this.cbroomnumber.FormattingEnabled = true;
            this.cbroomnumber.Location = new System.Drawing.Point(165, 130);
            this.cbroomnumber.Margin = new System.Windows.Forms.Padding(4);
            this.cbroomnumber.Name = "cbroomnumber";
            this.cbroomnumber.Size = new System.Drawing.Size(250, 27);
            this.cbroomnumber.TabIndex = 120;
            this.cbroomnumber.SelectedIndexChanged += new System.EventHandler(this.cbroomnumber_SelectedIndexChanged);
            // 
            // lblroomtype
            // 
            this.lblroomtype.AutoSize = true;
            this.lblroomtype.Font = new System.Drawing.Font("Arial", 10F);
            this.lblroomtype.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblroomtype.Location = new System.Drawing.Point(10, 170);
            this.lblroomtype.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblroomtype.Name = "lblroomtype";
            this.lblroomtype.Size = new System.Drawing.Size(91, 19);
            this.lblroomtype.TabIndex = 123;
            this.lblroomtype.Text = "Room Type";
            // 
            // cbroomtype
            // 
            this.cbroomtype.Font = new System.Drawing.Font("Arial", 10F);
            this.cbroomtype.ForeColor = System.Drawing.SystemColors.Highlight;
            this.cbroomtype.FormattingEnabled = true;
            this.cbroomtype.Location = new System.Drawing.Point(165, 170);
            this.cbroomtype.Margin = new System.Windows.Forms.Padding(4);
            this.cbroomtype.Name = "cbroomtype";
            this.cbroomtype.Size = new System.Drawing.Size(250, 27);
            this.cbroomtype.TabIndex = 122;
            this.cbroomtype.SelectedIndexChanged += new System.EventHandler(this.cbroomtype_SelectedIndexChanged);
            // 
            // lbltotalprice
            // 
            this.lbltotalprice.AutoSize = true;
            this.lbltotalprice.Font = new System.Drawing.Font("Arial", 10F);
            this.lbltotalprice.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbltotalprice.Location = new System.Drawing.Point(10, 450);
            this.lbltotalprice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltotalprice.Name = "lbltotalprice";
            this.lbltotalprice.Size = new System.Drawing.Size(85, 19);
            this.lbltotalprice.TabIndex = 125;
            this.lbltotalprice.Text = "Total Price";
            // 
            // cbtotalprice
            // 
            this.cbtotalprice.Font = new System.Drawing.Font("Arial", 10F);
            this.cbtotalprice.ForeColor = System.Drawing.SystemColors.Highlight;
            this.cbtotalprice.FormattingEnabled = true;
            this.cbtotalprice.Location = new System.Drawing.Point(163, 450);
            this.cbtotalprice.Margin = new System.Windows.Forms.Padding(4);
            this.cbtotalprice.Name = "cbtotalprice";
            this.cbtotalprice.Size = new System.Drawing.Size(250, 27);
            this.cbtotalprice.TabIndex = 124;
            this.cbtotalprice.SelectedIndexChanged += new System.EventHandler(this.cbtotalprice_SelectedIndexChanged);
            // 
            // txtdatedue
            // 
            this.txtdatedue.Font = new System.Drawing.Font("Arial", 10F);
            this.txtdatedue.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtdatedue.Location = new System.Drawing.Point(916, 10);
            this.txtdatedue.Margin = new System.Windows.Forms.Padding(4);
            this.txtdatedue.Name = "txtdatedue";
            this.txtdatedue.Size = new System.Drawing.Size(250, 27);
            this.txtdatedue.TabIndex = 126;
            // 
            // txtdateout
            // 
            this.txtdateout.Font = new System.Drawing.Font("Arial", 10F);
            this.txtdateout.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtdateout.Location = new System.Drawing.Point(916, 50);
            this.txtdateout.Margin = new System.Windows.Forms.Padding(4);
            this.txtdateout.Name = "txtdateout";
            this.txtdateout.Size = new System.Drawing.Size(250, 27);
            this.txtdateout.TabIndex = 127;
            // 
            // lblroomtype1
            // 
            this.lblroomtype1.AutoSize = true;
            this.lblroomtype1.Font = new System.Drawing.Font("Arial", 10F);
            this.lblroomtype1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblroomtype1.Location = new System.Drawing.Point(760, 648);
            this.lblroomtype1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblroomtype1.Name = "lblroomtype1";
            this.lblroomtype1.Size = new System.Drawing.Size(188, 19);
            this.lblroomtype1.TabIndex = 132;
            this.lblroomtype1.Text = "Room Type: SingleRoom";
            // 
            // lblroomnumber1
            // 
            this.lblroomnumber1.AutoSize = true;
            this.lblroomnumber1.Font = new System.Drawing.Font("Arial", 10F);
            this.lblroomnumber1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblroomnumber1.Location = new System.Drawing.Point(577, 648);
            this.lblroomnumber1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblroomnumber1.Name = "lblroomnumber1";
            this.lblroomnumber1.Size = new System.Drawing.Size(154, 19);
            this.lblroomnumber1.TabIndex = 131;
            this.lblroomnumber1.Text = "Room Number: SR1";
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Arial", 10F);
            this.btnNext.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnNext.Image = global::BayView1.Properties.Resources.Custom_Icon_Design_Pretty_Office_8_Fast_forward;
            this.btnNext.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNext.Location = new System.Drawing.Point(832, 686);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(150, 80);
            this.btnNext.TabIndex = 133;
            this.btnNext.Text = "Next";
            this.btnNext.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnclose
            // 
            this.btnclose.Font = new System.Drawing.Font("Arial", 10F);
            this.btnclose.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnclose.Image = global::BayView1.Properties.Resources.Graphicloads_100_Flat_Close;
            this.btnclose.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnclose.Location = new System.Drawing.Point(1081, 686);
            this.btnclose.Margin = new System.Windows.Forms.Padding(4);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(150, 80);
            this.btnclose.TabIndex = 135;
            this.btnclose.Text = "Close";
            this.btnclose.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Font = new System.Drawing.Font("Arial", 10F);
            this.btnPrev.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnPrev.Image = global::BayView1.Properties.Resources.Custom_Icon_Design_Pretty_Office_8_Fast_backward;
            this.btnPrev.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPrev.Location = new System.Drawing.Point(581, 686);
            this.btnPrev.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(150, 80);
            this.btnPrev.TabIndex = 134;
            this.btnPrev.Text = "Back";
            this.btnPrev.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(444, 125);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(787, 508);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 130;
            this.pictureBox1.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Arial", 10F);
            this.btnCancel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnCancel.Image = global::BayView1.Properties.Resources.Graphicloads_100_Flat_Warning;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancel.Location = new System.Drawing.Point(263, 550);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(150, 80);
            this.btnCancel.TabIndex = 129;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Arial", 10F);
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnSubmit.Image = global::BayView1.Properties.Resources.Graphicloads_100_Flat_Like;
            this.btnSubmit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSubmit.Location = new System.Drawing.Point(10, 550);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(150, 80);
            this.btnSubmit.TabIndex = 128;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // Bookings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 780);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lblroomtype1);
            this.Controls.Add(this.lblroomnumber1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtdateout);
            this.Controls.Add(this.txtdatedue);
            this.Controls.Add(this.lbltotalprice);
            this.Controls.Add(this.cbtotalprice);
            this.Controls.Add(this.lblroomtype);
            this.Controls.Add(this.cbroomtype);
            this.Controls.Add(this.lblroomnumber);
            this.Controls.Add(this.cbroomnumber);
            this.Controls.Add(this.lblavailabilitycheck);
            this.Controls.Add(this.cbavailabilitycheck);
            this.Controls.Add(this.lblbreakfast);
            this.Controls.Add(this.cbbreakfast);
            this.Controls.Add(this.numericUpDown);
            this.Controls.Add(this.lblduration);
            this.Controls.Add(this.lbldateout);
            this.Controls.Add(this.lbldatedue);
            this.Controls.Add(this.lblavailable);
            this.Controls.Add(this.cbavailability);
            this.Controls.Add(this.lbldisability1);
            this.Controls.Add(this.cbdisability);
            this.Controls.Add(this.lbllastname);
            this.Controls.Add(this.cblastname);
            this.Controls.Add(this.lblfirstname);
            this.Controls.Add(this.cbfirstname);
            this.Controls.Add(this.lblstaffname);
            this.Controls.Add(this.cbstaffname);
            this.Controls.Add(this.lblroomno1);
            this.Controls.Add(this.lblcustomerno);
            this.Controls.Add(this.lblstaffno);
            this.Controls.Add(this.cbroomNo);
            this.Controls.Add(this.cbcustomerNo);
            this.Controls.Add(this.cbstaffNo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Bookings";
            this.Text = "Bookings";
            this.Load += new System.EventHandler(this.Bookings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblbreakfast;
        private System.Windows.Forms.ComboBox cbbreakfast;
        private System.Windows.Forms.NumericUpDown numericUpDown;
        private System.Windows.Forms.Label lblduration;
        private System.Windows.Forms.Label lbldateout;
        private System.Windows.Forms.Label lbldatedue;
        private System.Windows.Forms.Label lblavailable;
        private System.Windows.Forms.ComboBox cbavailability;
        private System.Windows.Forms.Label lbldisability1;
        private System.Windows.Forms.ComboBox cbdisability;
        private System.Windows.Forms.Label lbllastname;
        private System.Windows.Forms.ComboBox cblastname;
        private System.Windows.Forms.Label lblfirstname;
        private System.Windows.Forms.ComboBox cbfirstname;
        private System.Windows.Forms.Label lblstaffname;
        private System.Windows.Forms.ComboBox cbstaffname;
        private System.Windows.Forms.Label lblroomno1;
        private System.Windows.Forms.Label lblcustomerno;
        private System.Windows.Forms.Label lblstaffno;
        private System.Windows.Forms.ComboBox cbroomNo;
        private System.Windows.Forms.ComboBox cbcustomerNo;
        private System.Windows.Forms.ComboBox cbstaffNo;
        private System.Windows.Forms.Label lblavailabilitycheck;
        private System.Windows.Forms.ComboBox cbavailabilitycheck;
        private System.Windows.Forms.Label lblroomnumber;
        private System.Windows.Forms.ComboBox cbroomnumber;
        private System.Windows.Forms.Label lblroomtype;
        private System.Windows.Forms.ComboBox cbroomtype;
        private System.Windows.Forms.Label lbltotalprice;
        private System.Windows.Forms.ComboBox cbtotalprice;
        private System.Windows.Forms.TextBox txtdatedue;
        private System.Windows.Forms.TextBox txtdateout;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblroomtype1;
        private System.Windows.Forms.Label lblroomnumber1;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnclose;
    }
}
namespace BayView1
{
    partial class Update_Bookings
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
            this.btnclose = new System.Windows.Forms.Button();
            this.lblroomnumber = new System.Windows.Forms.Label();
            this.cbroomnumber = new System.Windows.Forms.ComboBox();
            this.lbllastname = new System.Windows.Forms.Label();
            this.cblastname = new System.Windows.Forms.ComboBox();
            this.lblfirstname = new System.Windows.Forms.Label();
            this.cbfirstname = new System.Windows.Forms.ComboBox();
            this.lblmanager = new System.Windows.Forms.Label();
            this.cbmanager = new System.Windows.Forms.ComboBox();
            this.lblroomNo = new System.Windows.Forms.Label();
            this.lblcustomerNo = new System.Windows.Forms.Label();
            this.lblstaffNo = new System.Windows.Forms.Label();
            this.cbroomNo = new System.Windows.Forms.ComboBox();
            this.cbcustomerNo = new System.Windows.Forms.ComboBox();
            this.cbstaffNo = new System.Windows.Forms.ComboBox();
            this.cbdateout = new System.Windows.Forms.ComboBox();
            this.cbdatedue = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.cbbookingNo = new System.Windows.Forms.ComboBox();
            this.btncancel = new System.Windows.Forms.Button();
            this.lblbookingNo = new System.Windows.Forms.Label();
            this.lbldatedue1 = new System.Windows.Forms.Label();
            this.lblDateOut = new System.Windows.Forms.Label();
            this.lblroomtype = new System.Windows.Forms.Label();
            this.cbroomtype = new System.Windows.Forms.ComboBox();
            this.numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.lblduration = new System.Windows.Forms.Label();
            this.lblduration1 = new System.Windows.Forms.Label();
            this.cbduration = new System.Windows.Forms.ComboBox();
            this.lbltotalpayment = new System.Windows.Forms.Label();
            this.cbtotalpayment = new System.Windows.Forms.ComboBox();
            this.txttotalpayment = new System.Windows.Forms.TextBox();
            this.lbltotalpayment1 = new System.Windows.Forms.Label();
            this.txtdateout = new System.Windows.Forms.TextBox();
            this.txtdatedue = new System.Windows.Forms.TextBox();
            this.lbldateout1 = new System.Windows.Forms.Label();
            this.lbldatedue = new System.Windows.Forms.Label();
            this.lblbookingno1 = new System.Windows.Forms.Label();
            this.cbbookingNo1 = new System.Windows.Forms.ComboBox();
            this.btndelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // btnclose
            // 
            this.btnclose.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnclose.Image = global::BayView1.Properties.Resources.Graphicloads_100_Flat_Close;
            this.btnclose.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnclose.Location = new System.Drawing.Point(1079, 322);
            this.btnclose.Margin = new System.Windows.Forms.Padding(4);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(150, 80);
            this.btnclose.TabIndex = 152;
            this.btnclose.Text = "Close";
            this.btnclose.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // lblroomnumber
            // 
            this.lblroomnumber.AutoSize = true;
            this.lblroomnumber.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblroomnumber.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblroomnumber.Location = new System.Drawing.Point(840, 226);
            this.lblroomnumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblroomnumber.Name = "lblroomnumber";
            this.lblroomnumber.Size = new System.Drawing.Size(113, 19);
            this.lblroomnumber.TabIndex = 151;
            this.lblroomnumber.Text = "Room Number";
            // 
            // cbroomnumber
            // 
            this.cbroomnumber.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbroomnumber.ForeColor = System.Drawing.SystemColors.Highlight;
            this.cbroomnumber.FormattingEnabled = true;
            this.cbroomnumber.Location = new System.Drawing.Point(979, 226);
            this.cbroomnumber.Margin = new System.Windows.Forms.Padding(4);
            this.cbroomnumber.Name = "cbroomnumber";
            this.cbroomnumber.Size = new System.Drawing.Size(250, 27);
            this.cbroomnumber.TabIndex = 150;
            this.cbroomnumber.SelectedIndexChanged += new System.EventHandler(this.cbroomnumber_SelectedIndexChanged);
            // 
            // lbllastname
            // 
            this.lbllastname.AutoSize = true;
            this.lbllastname.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllastname.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbllastname.Location = new System.Drawing.Point(400, 186);
            this.lbllastname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbllastname.Name = "lbllastname";
            this.lbllastname.Size = new System.Drawing.Size(86, 19);
            this.lbllastname.TabIndex = 149;
            this.lbllastname.Text = "Last Name";
            // 
            // cblastname
            // 
            this.cblastname.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cblastname.ForeColor = System.Drawing.SystemColors.Highlight;
            this.cblastname.FormattingEnabled = true;
            this.cblastname.Location = new System.Drawing.Point(525, 186);
            this.cblastname.Margin = new System.Windows.Forms.Padding(4);
            this.cblastname.Name = "cblastname";
            this.cblastname.Size = new System.Drawing.Size(250, 27);
            this.cblastname.TabIndex = 148;
            this.cblastname.SelectedIndexChanged += new System.EventHandler(this.cblastname_SelectedIndexChanged);
            // 
            // lblfirstname
            // 
            this.lblfirstname.AutoSize = true;
            this.lblfirstname.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfirstname.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblfirstname.Location = new System.Drawing.Point(400, 146);
            this.lblfirstname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblfirstname.Name = "lblfirstname";
            this.lblfirstname.Size = new System.Drawing.Size(88, 19);
            this.lblfirstname.TabIndex = 147;
            this.lblfirstname.Text = "First Name";
            // 
            // cbfirstname
            // 
            this.cbfirstname.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbfirstname.ForeColor = System.Drawing.SystemColors.Highlight;
            this.cbfirstname.FormattingEnabled = true;
            this.cbfirstname.Location = new System.Drawing.Point(523, 146);
            this.cbfirstname.Margin = new System.Windows.Forms.Padding(4);
            this.cbfirstname.Name = "cbfirstname";
            this.cbfirstname.Size = new System.Drawing.Size(250, 27);
            this.cbfirstname.TabIndex = 146;
            this.cbfirstname.SelectedIndexChanged += new System.EventHandler(this.cbfirstname_SelectedIndexChanged);
            // 
            // lblmanager
            // 
            this.lblmanager.AutoSize = true;
            this.lblmanager.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmanager.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblmanager.Location = new System.Drawing.Point(840, 146);
            this.lblmanager.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblmanager.Name = "lblmanager";
            this.lblmanager.Size = new System.Drawing.Size(125, 19);
            this.lblmanager.TabIndex = 145;
            this.lblmanager.Text = "Manager Check";
            // 
            // cbmanager
            // 
            this.cbmanager.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbmanager.ForeColor = System.Drawing.SystemColors.Highlight;
            this.cbmanager.FormattingEnabled = true;
            this.cbmanager.Location = new System.Drawing.Point(979, 146);
            this.cbmanager.Margin = new System.Windows.Forms.Padding(4);
            this.cbmanager.Name = "cbmanager";
            this.cbmanager.Size = new System.Drawing.Size(250, 27);
            this.cbmanager.TabIndex = 144;
            this.cbmanager.SelectedIndexChanged += new System.EventHandler(this.cbmanager_SelectedIndexChanged);
            // 
            // lblroomNo
            // 
            this.lblroomNo.AutoSize = true;
            this.lblroomNo.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblroomNo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblroomNo.Location = new System.Drawing.Point(840, 186);
            this.lblroomNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblroomNo.Name = "lblroomNo";
            this.lblroomNo.Size = new System.Drawing.Size(76, 19);
            this.lblroomNo.TabIndex = 143;
            this.lblroomNo.Text = "Room No";
            // 
            // lblcustomerNo
            // 
            this.lblcustomerNo.AutoSize = true;
            this.lblcustomerNo.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcustomerNo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblcustomerNo.Location = new System.Drawing.Point(400, 96);
            this.lblcustomerNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcustomerNo.Name = "lblcustomerNo";
            this.lblcustomerNo.Size = new System.Drawing.Size(104, 19);
            this.lblcustomerNo.TabIndex = 142;
            this.lblcustomerNo.Text = "Customer No";
            // 
            // lblstaffNo
            // 
            this.lblstaffNo.AutoSize = true;
            this.lblstaffNo.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstaffNo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblstaffNo.Location = new System.Drawing.Point(840, 96);
            this.lblstaffNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblstaffNo.Name = "lblstaffNo";
            this.lblstaffNo.Size = new System.Drawing.Size(68, 19);
            this.lblstaffNo.TabIndex = 141;
            this.lblstaffNo.Text = "Staff No";
            // 
            // cbroomNo
            // 
            this.cbroomNo.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbroomNo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.cbroomNo.FormattingEnabled = true;
            this.cbroomNo.Location = new System.Drawing.Point(979, 186);
            this.cbroomNo.Margin = new System.Windows.Forms.Padding(4);
            this.cbroomNo.Name = "cbroomNo";
            this.cbroomNo.Size = new System.Drawing.Size(250, 27);
            this.cbroomNo.TabIndex = 140;
            this.cbroomNo.SelectedIndexChanged += new System.EventHandler(this.cbroomNo_SelectedIndexChanged);
            // 
            // cbcustomerNo
            // 
            this.cbcustomerNo.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbcustomerNo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.cbcustomerNo.FormattingEnabled = true;
            this.cbcustomerNo.Location = new System.Drawing.Point(521, 96);
            this.cbcustomerNo.Margin = new System.Windows.Forms.Padding(4);
            this.cbcustomerNo.Name = "cbcustomerNo";
            this.cbcustomerNo.Size = new System.Drawing.Size(250, 27);
            this.cbcustomerNo.TabIndex = 139;
            this.cbcustomerNo.SelectedIndexChanged += new System.EventHandler(this.cbcustomerNo_SelectedIndexChanged);
            // 
            // cbstaffNo
            // 
            this.cbstaffNo.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbstaffNo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.cbstaffNo.FormattingEnabled = true;
            this.cbstaffNo.Location = new System.Drawing.Point(979, 96);
            this.cbstaffNo.Margin = new System.Windows.Forms.Padding(4);
            this.cbstaffNo.Name = "cbstaffNo";
            this.cbstaffNo.Size = new System.Drawing.Size(250, 27);
            this.cbstaffNo.TabIndex = 138;
            this.cbstaffNo.SelectedIndexChanged += new System.EventHandler(this.cbstaffNo_SelectedIndexChanged);
            // 
            // cbdateout
            // 
            this.cbdateout.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbdateout.ForeColor = System.Drawing.SystemColors.Highlight;
            this.cbdateout.FormattingEnabled = true;
            this.cbdateout.Location = new System.Drawing.Point(105, 186);
            this.cbdateout.Margin = new System.Windows.Forms.Padding(4);
            this.cbdateout.Name = "cbdateout";
            this.cbdateout.Size = new System.Drawing.Size(250, 27);
            this.cbdateout.TabIndex = 136;
            this.cbdateout.SelectedIndexChanged += new System.EventHandler(this.cbdateout_SelectedIndexChanged);
            // 
            // cbdatedue
            // 
            this.cbdatedue.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbdatedue.ForeColor = System.Drawing.SystemColors.Highlight;
            this.cbdatedue.FormattingEnabled = true;
            this.cbdatedue.Location = new System.Drawing.Point(105, 146);
            this.cbdatedue.Margin = new System.Windows.Forms.Padding(4);
            this.cbdatedue.Name = "cbdatedue";
            this.cbdatedue.Size = new System.Drawing.Size(250, 27);
            this.cbdatedue.TabIndex = 135;
            this.cbdatedue.SelectedIndexChanged += new System.EventHandler(this.cbdatedue_SelectedIndexChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnUpdate.Image = global::BayView1.Properties.Resources.Graphicloads_100_Flat_Next;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUpdate.Location = new System.Drawing.Point(404, 322);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(150, 80);
            this.btnUpdate.TabIndex = 134;
            this.btnUpdate.Text = "Update Booking";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // cbbookingNo
            // 
            this.cbbookingNo.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbookingNo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.cbbookingNo.FormattingEnabled = true;
            this.cbbookingNo.Location = new System.Drawing.Point(105, 96);
            this.cbbookingNo.Margin = new System.Windows.Forms.Padding(4);
            this.cbbookingNo.Name = "cbbookingNo";
            this.cbbookingNo.Size = new System.Drawing.Size(250, 27);
            this.cbbookingNo.TabIndex = 132;
            this.cbbookingNo.SelectedIndexChanged += new System.EventHandler(this.cbbookingNo_SelectedIndexChanged);
            // 
            // btncancel
            // 
            this.btncancel.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btncancel.Image = global::BayView1.Properties.Resources.Graphicloads_100_Flat_Warning;
            this.btncancel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btncancel.Location = new System.Drawing.Point(625, 320);
            this.btncancel.Margin = new System.Windows.Forms.Padding(4);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(150, 80);
            this.btncancel.TabIndex = 153;
            this.btncancel.Text = "Cancel";
            this.btncancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // lblbookingNo
            // 
            this.lblbookingNo.AutoSize = true;
            this.lblbookingNo.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbookingNo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblbookingNo.Location = new System.Drawing.Point(5, 96);
            this.lblbookingNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblbookingNo.Name = "lblbookingNo";
            this.lblbookingNo.Size = new System.Drawing.Size(93, 19);
            this.lblbookingNo.TabIndex = 154;
            this.lblbookingNo.Text = "Booking No";
            // 
            // lbldatedue1
            // 
            this.lbldatedue1.AutoSize = true;
            this.lbldatedue1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldatedue1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbldatedue1.Location = new System.Drawing.Point(5, 146);
            this.lbldatedue1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbldatedue1.Name = "lbldatedue1";
            this.lbldatedue1.Size = new System.Drawing.Size(73, 19);
            this.lbldatedue1.TabIndex = 155;
            this.lbldatedue1.Text = "DateDue";
            // 
            // lblDateOut
            // 
            this.lblDateOut.AutoSize = true;
            this.lblDateOut.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateOut.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblDateOut.Location = new System.Drawing.Point(5, 186);
            this.lblDateOut.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateOut.Name = "lblDateOut";
            this.lblDateOut.Size = new System.Drawing.Size(68, 19);
            this.lblDateOut.TabIndex = 156;
            this.lblDateOut.Text = "DateOut";
            // 
            // lblroomtype
            // 
            this.lblroomtype.AutoSize = true;
            this.lblroomtype.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblroomtype.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblroomtype.Location = new System.Drawing.Point(840, 266);
            this.lblroomtype.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblroomtype.Name = "lblroomtype";
            this.lblroomtype.Size = new System.Drawing.Size(91, 19);
            this.lblroomtype.TabIndex = 158;
            this.lblroomtype.Text = "Room Type";
            // 
            // cbroomtype
            // 
            this.cbroomtype.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbroomtype.ForeColor = System.Drawing.SystemColors.Highlight;
            this.cbroomtype.FormattingEnabled = true;
            this.cbroomtype.Location = new System.Drawing.Point(979, 266);
            this.cbroomtype.Margin = new System.Windows.Forms.Padding(4);
            this.cbroomtype.Name = "cbroomtype";
            this.cbroomtype.Size = new System.Drawing.Size(250, 27);
            this.cbroomtype.TabIndex = 157;
            this.cbroomtype.SelectedIndexChanged += new System.EventHandler(this.cbroomtype_SelectedIndexChanged);
            // 
            // numericUpDown
            // 
            this.numericUpDown.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown.ForeColor = System.Drawing.SystemColors.Highlight;
            this.numericUpDown.Location = new System.Drawing.Point(105, 351);
            this.numericUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDown.Name = "numericUpDown";
            this.numericUpDown.Size = new System.Drawing.Size(204, 27);
            this.numericUpDown.TabIndex = 160;
            this.numericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            // 
            // lblduration
            // 
            this.lblduration.AutoSize = true;
            this.lblduration.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblduration.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblduration.Location = new System.Drawing.Point(5, 351);
            this.lblduration.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblduration.Name = "lblduration";
            this.lblduration.Size = new System.Drawing.Size(71, 19);
            this.lblduration.TabIndex = 159;
            this.lblduration.Text = "Duration";
            // 
            // lblduration1
            // 
            this.lblduration1.AutoSize = true;
            this.lblduration1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblduration1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblduration1.Location = new System.Drawing.Point(5, 226);
            this.lblduration1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblduration1.Name = "lblduration1";
            this.lblduration1.Size = new System.Drawing.Size(71, 19);
            this.lblduration1.TabIndex = 162;
            this.lblduration1.Text = "Duration";
            // 
            // cbduration
            // 
            this.cbduration.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbduration.ForeColor = System.Drawing.SystemColors.Highlight;
            this.cbduration.FormattingEnabled = true;
            this.cbduration.Location = new System.Drawing.Point(105, 226);
            this.cbduration.Margin = new System.Windows.Forms.Padding(4);
            this.cbduration.Name = "cbduration";
            this.cbduration.Size = new System.Drawing.Size(250, 27);
            this.cbduration.TabIndex = 161;
            this.cbduration.SelectedIndexChanged += new System.EventHandler(this.cbduration_SelectedIndexChanged);
            // 
            // lbltotalpayment
            // 
            this.lbltotalpayment.AutoSize = true;
            this.lbltotalpayment.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalpayment.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbltotalpayment.Location = new System.Drawing.Point(400, 226);
            this.lbltotalpayment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltotalpayment.Name = "lbltotalpayment";
            this.lbltotalpayment.Size = new System.Drawing.Size(110, 19);
            this.lbltotalpayment.TabIndex = 164;
            this.lbltotalpayment.Text = "Total Payment";
            // 
            // cbtotalpayment
            // 
            this.cbtotalpayment.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbtotalpayment.ForeColor = System.Drawing.SystemColors.Highlight;
            this.cbtotalpayment.FormattingEnabled = true;
            this.cbtotalpayment.Location = new System.Drawing.Point(525, 226);
            this.cbtotalpayment.Margin = new System.Windows.Forms.Padding(4);
            this.cbtotalpayment.Name = "cbtotalpayment";
            this.cbtotalpayment.Size = new System.Drawing.Size(250, 27);
            this.cbtotalpayment.TabIndex = 163;
            this.cbtotalpayment.SelectedIndexChanged += new System.EventHandler(this.cbtotalpayment_SelectedIndexChanged);
            // 
            // txttotalpayment
            // 
            this.txttotalpayment.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotalpayment.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txttotalpayment.Location = new System.Drawing.Point(525, 266);
            this.txttotalpayment.Margin = new System.Windows.Forms.Padding(4);
            this.txttotalpayment.Name = "txttotalpayment";
            this.txttotalpayment.Size = new System.Drawing.Size(250, 27);
            this.txttotalpayment.TabIndex = 166;
            // 
            // lbltotalpayment1
            // 
            this.lbltotalpayment1.AutoSize = true;
            this.lbltotalpayment1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalpayment1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbltotalpayment1.Location = new System.Drawing.Point(400, 266);
            this.lbltotalpayment1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltotalpayment1.Name = "lbltotalpayment1";
            this.lbltotalpayment1.Size = new System.Drawing.Size(110, 19);
            this.lbltotalpayment1.TabIndex = 165;
            this.lbltotalpayment1.Text = "Total Payment";
            // 
            // txtdateout
            // 
            this.txtdateout.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdateout.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtdateout.Location = new System.Drawing.Point(105, 306);
            this.txtdateout.Margin = new System.Windows.Forms.Padding(4);
            this.txtdateout.Name = "txtdateout";
            this.txtdateout.Size = new System.Drawing.Size(250, 27);
            this.txtdateout.TabIndex = 170;
            // 
            // txtdatedue
            // 
            this.txtdatedue.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdatedue.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtdatedue.Location = new System.Drawing.Point(105, 266);
            this.txtdatedue.Margin = new System.Windows.Forms.Padding(4);
            this.txtdatedue.Name = "txtdatedue";
            this.txtdatedue.Size = new System.Drawing.Size(250, 27);
            this.txtdatedue.TabIndex = 169;
            // 
            // lbldateout1
            // 
            this.lbldateout1.AutoSize = true;
            this.lbldateout1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldateout1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbldateout1.Location = new System.Drawing.Point(5, 306);
            this.lbldateout1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbldateout1.Name = "lbldateout1";
            this.lbldateout1.Size = new System.Drawing.Size(73, 19);
            this.lbldateout1.TabIndex = 168;
            this.lbldateout1.Text = "Date Out";
            // 
            // lbldatedue
            // 
            this.lbldatedue.AutoSize = true;
            this.lbldatedue.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldatedue.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbldatedue.Location = new System.Drawing.Point(5, 266);
            this.lbldatedue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbldatedue.Name = "lbldatedue";
            this.lbldatedue.Size = new System.Drawing.Size(78, 19);
            this.lbldatedue.TabIndex = 167;
            this.lbldatedue.Text = "Date Due";
            // 
            // lblbookingno1
            // 
            this.lblbookingno1.AutoSize = true;
            this.lblbookingno1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbookingno1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblbookingno1.Location = new System.Drawing.Point(5, 30);
            this.lblbookingno1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblbookingno1.Name = "lblbookingno1";
            this.lblbookingno1.Size = new System.Drawing.Size(88, 19);
            this.lblbookingno1.TabIndex = 173;
            this.lblbookingno1.Text = "BookingNo";
            // 
            // cbbookingNo1
            // 
            this.cbbookingNo1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbookingNo1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.cbbookingNo1.FormattingEnabled = true;
            this.cbbookingNo1.Location = new System.Drawing.Point(105, 30);
            this.cbbookingNo1.Margin = new System.Windows.Forms.Padding(4);
            this.cbbookingNo1.Name = "cbbookingNo1";
            this.cbbookingNo1.Size = new System.Drawing.Size(256, 27);
            this.cbbookingNo1.TabIndex = 172;
            this.cbbookingNo1.SelectedIndexChanged += new System.EventHandler(this.cbbookingNo1_SelectedIndexChanged);
            // 
            // btndelete
            // 
            this.btndelete.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btndelete.Image = global::BayView1.Properties.Resources.Graphicloads_100_Flat_Recyclebin;
            this.btndelete.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btndelete.Location = new System.Drawing.Point(844, 320);
            this.btndelete.Margin = new System.Windows.Forms.Padding(4);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(150, 80);
            this.btndelete.TabIndex = 171;
            this.btndelete.Text = "Delete";
            this.btndelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // Update_Bookings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 440);
            this.Controls.Add(this.lblbookingno1);
            this.Controls.Add(this.cbbookingNo1);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.txtdateout);
            this.Controls.Add(this.txtdatedue);
            this.Controls.Add(this.lbldateout1);
            this.Controls.Add(this.lbldatedue);
            this.Controls.Add(this.txttotalpayment);
            this.Controls.Add(this.lbltotalpayment1);
            this.Controls.Add(this.lbltotalpayment);
            this.Controls.Add(this.cbtotalpayment);
            this.Controls.Add(this.lblduration1);
            this.Controls.Add(this.cbduration);
            this.Controls.Add(this.numericUpDown);
            this.Controls.Add(this.lblduration);
            this.Controls.Add(this.lblroomtype);
            this.Controls.Add(this.cbroomtype);
            this.Controls.Add(this.lblDateOut);
            this.Controls.Add(this.lbldatedue1);
            this.Controls.Add(this.lblbookingNo);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.lblroomnumber);
            this.Controls.Add(this.cbroomnumber);
            this.Controls.Add(this.lbllastname);
            this.Controls.Add(this.cblastname);
            this.Controls.Add(this.lblfirstname);
            this.Controls.Add(this.cbfirstname);
            this.Controls.Add(this.lblmanager);
            this.Controls.Add(this.cbmanager);
            this.Controls.Add(this.lblroomNo);
            this.Controls.Add(this.lblcustomerNo);
            this.Controls.Add(this.lblstaffNo);
            this.Controls.Add(this.cbroomNo);
            this.Controls.Add(this.cbcustomerNo);
            this.Controls.Add(this.cbstaffNo);
            this.Controls.Add(this.cbdateout);
            this.Controls.Add(this.cbdatedue);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.cbbookingNo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Update_Bookings";
            this.Text = "Update_Bookings";
            this.Load += new System.EventHandler(this.Update_Bookings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Label lblroomnumber;
        private System.Windows.Forms.ComboBox cbroomnumber;
        private System.Windows.Forms.Label lbllastname;
        private System.Windows.Forms.ComboBox cblastname;
        private System.Windows.Forms.Label lblfirstname;
        private System.Windows.Forms.ComboBox cbfirstname;
        private System.Windows.Forms.Label lblmanager;
        private System.Windows.Forms.ComboBox cbmanager;
        private System.Windows.Forms.Label lblroomNo;
        private System.Windows.Forms.Label lblcustomerNo;
        private System.Windows.Forms.Label lblstaffNo;
        private System.Windows.Forms.ComboBox cbroomNo;
        private System.Windows.Forms.ComboBox cbcustomerNo;
        private System.Windows.Forms.ComboBox cbstaffNo;
        private System.Windows.Forms.ComboBox cbdateout;
        private System.Windows.Forms.ComboBox cbdatedue;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ComboBox cbbookingNo;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Label lblbookingNo;
        private System.Windows.Forms.Label lbldatedue1;
        private System.Windows.Forms.Label lblDateOut;
        private System.Windows.Forms.Label lblroomtype;
        private System.Windows.Forms.ComboBox cbroomtype;
        private System.Windows.Forms.NumericUpDown numericUpDown;
        private System.Windows.Forms.Label lblduration;
        private System.Windows.Forms.Label lblduration1;
        private System.Windows.Forms.ComboBox cbduration;
        private System.Windows.Forms.Label lbltotalpayment;
        private System.Windows.Forms.ComboBox cbtotalpayment;
        private System.Windows.Forms.TextBox txttotalpayment;
        private System.Windows.Forms.Label lbltotalpayment1;
        private System.Windows.Forms.TextBox txtdateout;
        private System.Windows.Forms.TextBox txtdatedue;
        private System.Windows.Forms.Label lbldateout1;
        private System.Windows.Forms.Label lbldatedue;
        private System.Windows.Forms.Label lblbookingno1;
        private System.Windows.Forms.ComboBox cbbookingNo1;
        private System.Windows.Forms.Button btndelete;
    }
}
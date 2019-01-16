namespace BayView1
{
    partial class Analytics
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnClose = new System.Windows.Forms.Button();
            this.rbStaff = new System.Windows.Forms.RadioButton();
            this.rbSales = new System.Windows.Forms.RadioButton();
            this.rbRooms = new System.Windows.Forms.RadioButton();
            this.rbBreakfast = new System.Windows.Forms.RadioButton();
            this.rbDisability = new System.Windows.Forms.RadioButton();
            this.rbMonth = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.Chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // Chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.Chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.Chart1.Legends.Add(legend1);
            this.Chart1.Location = new System.Drawing.Point(12, 12);
            this.Chart1.Name = "Chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.Chart1.Series.Add(series1);
            this.Chart1.Size = new System.Drawing.Size(658, 300);
            this.Chart1.TabIndex = 0;
            this.Chart1.Text = "chart1";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Arial", 10F);
            this.btnClose.ForeColor = System.Drawing.Color.Red;
            this.btnClose.Location = new System.Drawing.Point(540, 363);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(130, 29);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // rbStaff
            // 
            this.rbStaff.AutoSize = true;
            this.rbStaff.Location = new System.Drawing.Point(12, 330);
            this.rbStaff.Name = "rbStaff";
            this.rbStaff.Size = new System.Drawing.Size(58, 21);
            this.rbStaff.TabIndex = 5;
            this.rbStaff.TabStop = true;
            this.rbStaff.Text = "Staff";
            this.rbStaff.UseVisualStyleBackColor = true;
            this.rbStaff.CheckedChanged += new System.EventHandler(this.rbStaff_CheckedChanged);
            // 
            // rbSales
            // 
            this.rbSales.AutoSize = true;
            this.rbSales.Location = new System.Drawing.Point(12, 363);
            this.rbSales.Name = "rbSales";
            this.rbSales.Size = new System.Drawing.Size(64, 21);
            this.rbSales.TabIndex = 5;
            this.rbSales.TabStop = true;
            this.rbSales.Text = "Sales";
            this.rbSales.UseVisualStyleBackColor = true;
            // 
            // rbRooms
            // 
            this.rbRooms.AutoSize = true;
            this.rbRooms.Location = new System.Drawing.Point(94, 330);
            this.rbRooms.Name = "rbRooms";
            this.rbRooms.Size = new System.Drawing.Size(73, 21);
            this.rbRooms.TabIndex = 5;
            this.rbRooms.TabStop = true;
            this.rbRooms.Text = "Rooms";
            this.rbRooms.UseVisualStyleBackColor = true;
            // 
            // rbBreakfast
            // 
            this.rbBreakfast.AutoSize = true;
            this.rbBreakfast.Location = new System.Drawing.Point(94, 363);
            this.rbBreakfast.Name = "rbBreakfast";
            this.rbBreakfast.Size = new System.Drawing.Size(89, 21);
            this.rbBreakfast.TabIndex = 5;
            this.rbBreakfast.TabStop = true;
            this.rbBreakfast.Text = "Breakfast";
            this.rbBreakfast.UseVisualStyleBackColor = true;
            // 
            // rbDisability
            // 
            this.rbDisability.AutoSize = true;
            this.rbDisability.Location = new System.Drawing.Point(200, 330);
            this.rbDisability.Name = "rbDisability";
            this.rbDisability.Size = new System.Drawing.Size(85, 21);
            this.rbDisability.TabIndex = 5;
            this.rbDisability.TabStop = true;
            this.rbDisability.Text = "Disability";
            this.rbDisability.UseVisualStyleBackColor = true;
            // 
            // rbMonth
            // 
            this.rbMonth.AutoSize = true;
            this.rbMonth.Location = new System.Drawing.Point(200, 363);
            this.rbMonth.Name = "rbMonth";
            this.rbMonth.Size = new System.Drawing.Size(78, 21);
            this.rbMonth.TabIndex = 5;
            this.rbMonth.TabStop = true;
            this.rbMonth.Text = "Monthly";
            this.rbMonth.UseVisualStyleBackColor = true;
            // 
            // Analytics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 403);
            this.Controls.Add(this.rbMonth);
            this.Controls.Add(this.rbBreakfast);
            this.Controls.Add(this.rbDisability);
            this.Controls.Add(this.rbRooms);
            this.Controls.Add(this.rbSales);
            this.Controls.Add(this.rbStaff);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.Chart1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Analytics";
            this.Text = "Analytics";
            this.Load += new System.EventHandler(this.Analytics_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart Chart1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.RadioButton rbStaff;
        private System.Windows.Forms.RadioButton rbSales;
        private System.Windows.Forms.RadioButton rbRooms;
        private System.Windows.Forms.RadioButton rbBreakfast;
        private System.Windows.Forms.RadioButton rbDisability;
        private System.Windows.Forms.RadioButton rbMonth;
    }
}
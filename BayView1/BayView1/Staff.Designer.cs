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
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNewStaff
            // 
            this.btnNewStaff.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewStaff.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnNewStaff.Location = new System.Drawing.Point(321, 628);
            this.btnNewStaff.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNewStaff.Name = "btnNewStaff";
            this.btnNewStaff.Size = new System.Drawing.Size(160, 43);
            this.btnNewStaff.TabIndex = 0;
            this.btnNewStaff.Text = "Add a New Staff";
            this.btnNewStaff.UseVisualStyleBackColor = true;
            this.btnNewStaff.Click += new System.EventHandler(this.btnNewStaff_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnSubmit.Location = new System.Drawing.Point(511, 628);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(181, 43);
            this.btnSubmit.TabIndex = 1;
            this.btnSubmit.Text = "Submit Changes";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Red;
            this.btnClose.Location = new System.Drawing.Point(715, 628);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(152, 43);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 16);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
//<<<<<<< HEAD
            //this.dataGridView1.Size = new System.Drawing.Size(821, 447);
//=======
            this.dataGridView1.Size = new System.Drawing.Size(1048, 596);
//>>>>>>> 0db8301301fafc25daee307595b4555fb6661ff2
            this.dataGridView1.TabIndex = 3;
            // 
            // Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
//<<<<<<< HEAD
            //this.ClientSize = new System.Drawing.Size(845, 515);
//=======
            this.ClientSize = new System.Drawing.Size(1080, 687);
//>>>>>>> 0db8301301fafc25daee307595b4555fb6661ff2
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnNewStaff);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Staff";
            this.Text = "Staff";
            this.Load += new System.EventHandler(this.Staff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNewStaff;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
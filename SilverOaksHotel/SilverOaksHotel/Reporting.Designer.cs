namespace SilverOaksHotel
{
    partial class Reporting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reporting));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.grbReportType = new System.Windows.Forms.GroupBox();
            this.rdoPopularPackages = new System.Windows.Forms.RadioButton();
            this.rdoBookingsPerTimePeriod = new System.Windows.Forms.RadioButton();
            this.lstReport = new System.Windows.Forms.ListBox();
            this.lblRequestREport = new System.Windows.Forms.Label();
            this.btnReportingReturnHome = new System.Windows.Forms.Button();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.grbReportType.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(-6, -1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1491, 723);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(15)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(291, 88);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(932, 522);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dtpEnd);
            this.panel2.Controls.Add(this.dtpStart);
            this.panel2.Controls.Add(this.lblEndDate);
            this.panel2.Controls.Add(this.lblStartDate);
            this.panel2.Controls.Add(this.grbReportType);
            this.panel2.Controls.Add(this.lstReport);
            this.panel2.Controls.Add(this.lblRequestREport);
            this.panel2.Location = new System.Drawing.Point(23, 18);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(886, 481);
            this.panel2.TabIndex = 0;
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndDate.Location = new System.Drawing.Point(634, 41);
            this.lblEndDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(83, 20);
            this.lblEndDate.TabIndex = 13;
            this.lblEndDate.Text = "END DATE:";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.Location = new System.Drawing.Point(364, 41);
            this.lblStartDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(96, 20);
            this.lblStartDate.TabIndex = 12;
            this.lblStartDate.Text = "START DATE:";
            // 
            // grbReportType
            // 
            this.grbReportType.Controls.Add(this.rdoPopularPackages);
            this.grbReportType.Controls.Add(this.rdoBookingsPerTimePeriod);
            this.grbReportType.Location = new System.Drawing.Point(16, 61);
            this.grbReportType.Margin = new System.Windows.Forms.Padding(2);
            this.grbReportType.Name = "grbReportType";
            this.grbReportType.Padding = new System.Windows.Forms.Padding(2);
            this.grbReportType.Size = new System.Drawing.Size(314, 168);
            this.grbReportType.TabIndex = 8;
            this.grbReportType.TabStop = false;
            this.grbReportType.Text = "REPORT TYPE";
            // 
            // rdoPopularPackages
            // 
            this.rdoPopularPackages.AutoSize = true;
            this.rdoPopularPackages.Location = new System.Drawing.Point(31, 90);
            this.rdoPopularPackages.Margin = new System.Windows.Forms.Padding(2);
            this.rdoPopularPackages.Name = "rdoPopularPackages";
            this.rdoPopularPackages.Size = new System.Drawing.Size(268, 17);
            this.rdoPopularPackages.TabIndex = 2;
            this.rdoPopularPackages.TabStop = true;
            this.rdoPopularPackages.Text = "MOST POPULAR PACKAGES PER TIME PERIOD";
            this.rdoPopularPackages.UseVisualStyleBackColor = true;
            this.rdoPopularPackages.CheckedChanged += new System.EventHandler(this.rdoPopularPackages_CheckedChanged);
            // 
            // rdoBookingsPerTimePeriod
            // 
            this.rdoBookingsPerTimePeriod.AutoSize = true;
            this.rdoBookingsPerTimePeriod.Location = new System.Drawing.Point(31, 42);
            this.rdoBookingsPerTimePeriod.Margin = new System.Windows.Forms.Padding(2);
            this.rdoBookingsPerTimePeriod.Name = "rdoBookingsPerTimePeriod";
            this.rdoBookingsPerTimePeriod.Size = new System.Drawing.Size(179, 17);
            this.rdoBookingsPerTimePeriod.TabIndex = 1;
            this.rdoBookingsPerTimePeriod.TabStop = true;
            this.rdoBookingsPerTimePeriod.Text = "BOOKINGS PER TIME PERIOD";
            this.rdoBookingsPerTimePeriod.UseVisualStyleBackColor = true;
            this.rdoBookingsPerTimePeriod.CheckedChanged += new System.EventHandler(this.rdoBookingsPerTimePeriod_CheckedChanged);
            // 
            // lstReport
            // 
            this.lstReport.FormattingEnabled = true;
            this.lstReport.Location = new System.Drawing.Point(16, 245);
            this.lstReport.Margin = new System.Windows.Forms.Padding(2);
            this.lstReport.Name = "lstReport";
            this.lstReport.Size = new System.Drawing.Size(849, 212);
            this.lstReport.TabIndex = 5;
            // 
            // lblRequestREport
            // 
            this.lblRequestREport.AutoSize = true;
            this.lblRequestREport.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold);
            this.lblRequestREport.Location = new System.Drawing.Point(315, 11);
            this.lblRequestREport.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRequestREport.Name = "lblRequestREport";
            this.lblRequestREport.Size = new System.Drawing.Size(215, 29);
            this.lblRequestREport.TabIndex = 6;
            this.lblRequestREport.Text = "REQUEST REPORT";
            // 
            // btnReportingReturnHome
            // 
            this.btnReportingReturnHome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnReportingReturnHome.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportingReturnHome.Location = new System.Drawing.Point(11, 675);
            this.btnReportingReturnHome.Margin = new System.Windows.Forms.Padding(2);
            this.btnReportingReturnHome.Name = "btnReportingReturnHome";
            this.btnReportingReturnHome.Size = new System.Drawing.Size(170, 35);
            this.btnReportingReturnHome.TabIndex = 6;
            this.btnReportingReturnHome.Text = "RETURN TO MENU";
            this.btnReportingReturnHome.UseVisualStyleBackColor = true;
            this.btnReportingReturnHome.Click += new System.EventHandler(this.btnReportingReturnHome_Click);
            // 
            // dtpStart
            // 
            this.dtpStart.Location = new System.Drawing.Point(368, 65);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(200, 20);
            this.dtpStart.TabIndex = 15;
            // 
            // dtpEnd
            // 
            this.dtpEnd.Location = new System.Drawing.Point(638, 64);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(200, 20);
            this.dtpEnd.TabIndex = 16;
            // 
            // Reporting
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1484, 721);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnReportingReturnHome);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Reporting";
            this.Text = "REQUEST REPORTS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.grbReportType.ResumeLayout(false);
            this.grbReportType.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox lstReport;
        private System.Windows.Forms.Label lblRequestREport;
        private System.Windows.Forms.GroupBox grbReportType;
        private System.Windows.Forms.RadioButton rdoPopularPackages;
        private System.Windows.Forms.RadioButton rdoBookingsPerTimePeriod;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Button btnReportingReturnHome;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.DateTimePicker dtpStart;
    }
}
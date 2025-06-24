namespace SilverOaksHotel
{
    partial class AdministratorHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdministratorHome));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlSelectService = new System.Windows.Forms.Panel();
            this.pnlDecorative = new System.Windows.Forms.Panel();
            this.btnExporttoCSV = new System.Windows.Forms.Button();
            this.btnMaintainRooms = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnPackages = new System.Windows.Forms.Button();
            this.btnClients = new System.Windows.Forms.Button();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.lbladminheading = new System.Windows.Forms.Label();
            this.btnALogOut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlSelectService.SuspendLayout();
            this.pnlDecorative.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(8, 9);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1010, 534);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pnlSelectService
            // 
            this.pnlSelectService.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlSelectService.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(15)))));
            this.pnlSelectService.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSelectService.Controls.Add(this.pnlDecorative);
            this.pnlSelectService.Location = new System.Drawing.Point(244, 233);
            this.pnlSelectService.Margin = new System.Windows.Forms.Padding(2);
            this.pnlSelectService.Name = "pnlSelectService";
            this.pnlSelectService.Size = new System.Drawing.Size(503, 193);
            this.pnlSelectService.TabIndex = 1;
            // 
            // pnlDecorative
            // 
            this.pnlDecorative.BackColor = System.Drawing.Color.DarkGray;
            this.pnlDecorative.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDecorative.Controls.Add(this.btnExporttoCSV);
            this.pnlDecorative.Controls.Add(this.btnMaintainRooms);
            this.pnlDecorative.Controls.Add(this.btnReports);
            this.pnlDecorative.Controls.Add(this.btnPackages);
            this.pnlDecorative.Controls.Add(this.btnClients);
            this.pnlDecorative.Controls.Add(this.btnEmployee);
            this.pnlDecorative.Controls.Add(this.lbladminheading);
            this.pnlDecorative.Location = new System.Drawing.Point(16, 16);
            this.pnlDecorative.Margin = new System.Windows.Forms.Padding(2);
            this.pnlDecorative.Name = "pnlDecorative";
            this.pnlDecorative.Size = new System.Drawing.Size(468, 161);
            this.pnlDecorative.TabIndex = 2;
            // 
            // btnExporttoCSV
            // 
            this.btnExporttoCSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnExporttoCSV.Location = new System.Drawing.Point(309, 98);
            this.btnExporttoCSV.Margin = new System.Windows.Forms.Padding(2);
            this.btnExporttoCSV.Name = "btnExporttoCSV";
            this.btnExporttoCSV.Size = new System.Drawing.Size(145, 51);
            this.btnExporttoCSV.TabIndex = 8;
            this.btnExporttoCSV.Text = "EXPORT REPORT TO CSV";
            this.btnExporttoCSV.UseVisualStyleBackColor = true;
            this.btnExporttoCSV.Click += new System.EventHandler(this.btnExporttoCSV_Click);
            // 
            // btnMaintainRooms
            // 
            this.btnMaintainRooms.Location = new System.Drawing.Point(309, 52);
            this.btnMaintainRooms.Margin = new System.Windows.Forms.Padding(2);
            this.btnMaintainRooms.Name = "btnMaintainRooms";
            this.btnMaintainRooms.Size = new System.Drawing.Size(145, 42);
            this.btnMaintainRooms.TabIndex = 5;
            this.btnMaintainRooms.Text = "MAINTAIN ROOMS";
            this.btnMaintainRooms.UseVisualStyleBackColor = true;
            this.btnMaintainRooms.Click += new System.EventHandler(this.btnMaintainRooms_Click);
            // 
            // btnReports
            // 
            this.btnReports.Location = new System.Drawing.Point(11, 99);
            this.btnReports.Margin = new System.Windows.Forms.Padding(2);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(145, 50);
            this.btnReports.TabIndex = 3;
            this.btnReports.Text = "REQUEST REPORTS";
            this.btnReports.UseVisualStyleBackColor = true;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnPackages
            // 
            this.btnPackages.Location = new System.Drawing.Point(160, 99);
            this.btnPackages.Margin = new System.Windows.Forms.Padding(2);
            this.btnPackages.Name = "btnPackages";
            this.btnPackages.Size = new System.Drawing.Size(145, 50);
            this.btnPackages.TabIndex = 4;
            this.btnPackages.Text = "MAINTAIN PACKAGES";
            this.btnPackages.UseVisualStyleBackColor = true;
            this.btnPackages.Click += new System.EventHandler(this.btnPackages_Click);
            // 
            // btnClients
            // 
            this.btnClients.Location = new System.Drawing.Point(160, 52);
            this.btnClients.Margin = new System.Windows.Forms.Padding(2);
            this.btnClients.Name = "btnClients";
            this.btnClients.Size = new System.Drawing.Size(145, 42);
            this.btnClients.TabIndex = 2;
            this.btnClients.Text = "MAINTAIN CLIENTS";
            this.btnClients.UseVisualStyleBackColor = true;
            this.btnClients.Click += new System.EventHandler(this.btnClients_Click);
            // 
            // btnEmployee
            // 
            this.btnEmployee.Location = new System.Drawing.Point(11, 52);
            this.btnEmployee.Margin = new System.Windows.Forms.Padding(2);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(145, 42);
            this.btnEmployee.TabIndex = 1;
            this.btnEmployee.Text = "MAINTAIN EMPLOYEES";
            this.btnEmployee.UseVisualStyleBackColor = true;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // lbladminheading
            // 
            this.lbladminheading.AutoSize = true;
            this.lbladminheading.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold);
            this.lbladminheading.Location = new System.Drawing.Point(40, 8);
            this.lbladminheading.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbladminheading.Name = "lbladminheading";
            this.lbladminheading.Size = new System.Drawing.Size(405, 29);
            this.lbladminheading.TabIndex = 2;
            this.lbladminheading.Text = "SELECT ADMINISTRATIVE SERVICE";
            // 
            // btnALogOut
            // 
            this.btnALogOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnALogOut.Location = new System.Drawing.Point(22, 490);
            this.btnALogOut.Margin = new System.Windows.Forms.Padding(2);
            this.btnALogOut.Name = "btnALogOut";
            this.btnALogOut.Size = new System.Drawing.Size(145, 42);
            this.btnALogOut.TabIndex = 5;
            this.btnALogOut.Text = "LOG OUT";
            this.btnALogOut.UseVisualStyleBackColor = true;
            this.btnALogOut.Click += new System.EventHandler(this.btnALogOut_Click);
            // 
            // AdministratorHome
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1027, 552);
            this.Controls.Add(this.btnALogOut);
            this.Controls.Add(this.pnlSelectService);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AdministratorHome";
            this.Text = "ADMINISTRATOR MENU";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlSelectService.ResumeLayout(false);
            this.pnlDecorative.ResumeLayout(false);
            this.pnlDecorative.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlSelectService;
        private System.Windows.Forms.Panel pnlDecorative;
        private System.Windows.Forms.Label lbladminheading;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnPackages;
        private System.Windows.Forms.Button btnClients;
        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.Button btnALogOut;
        private System.Windows.Forms.Button btnMaintainRooms;
        private System.Windows.Forms.Button btnExporttoCSV;
    }
}
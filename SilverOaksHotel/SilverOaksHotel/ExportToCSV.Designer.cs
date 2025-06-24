namespace SilverOaksHotel
{
    partial class ExportToCSV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExportToCSV));
            this.pcbCSV = new System.Windows.Forms.PictureBox();
            this.pnlExporttoCSV1 = new System.Windows.Forms.Panel();
            this.pnlExorttocsv2 = new System.Windows.Forms.Panel();
            this.dgvRequestedTableData = new System.Windows.Forms.DataGridView();
            this.btnCSVReturnHome = new System.Windows.Forms.Button();
            this.btnExportTableToCSV = new System.Windows.Forms.Button();
            this.btnSeeRequestedTable = new System.Windows.Forms.Button();
            this.lblTableName = new System.Windows.Forms.Label();
            this.lblExporttoCSV = new System.Windows.Forms.Label();
            this.cboTableName = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCSV)).BeginInit();
            this.pnlExporttoCSV1.SuspendLayout();
            this.pnlExorttocsv2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequestedTableData)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbCSV
            // 
            this.pcbCSV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pcbCSV.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pcbCSV.BackgroundImage")));
            this.pcbCSV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbCSV.Location = new System.Drawing.Point(-4, -1);
            this.pcbCSV.Margin = new System.Windows.Forms.Padding(2);
            this.pcbCSV.Name = "pcbCSV";
            this.pcbCSV.Size = new System.Drawing.Size(1486, 734);
            this.pcbCSV.TabIndex = 0;
            this.pcbCSV.TabStop = false;
            // 
            // pnlExporttoCSV1
            // 
            this.pnlExporttoCSV1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlExporttoCSV1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(15)))));
            this.pnlExporttoCSV1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlExporttoCSV1.Controls.Add(this.pnlExorttocsv2);
            this.pnlExporttoCSV1.Location = new System.Drawing.Point(356, 152);
            this.pnlExporttoCSV1.Margin = new System.Windows.Forms.Padding(2);
            this.pnlExporttoCSV1.Name = "pnlExporttoCSV1";
            this.pnlExporttoCSV1.Size = new System.Drawing.Size(803, 429);
            this.pnlExporttoCSV1.TabIndex = 2;
            // 
            // pnlExorttocsv2
            // 
            this.pnlExorttocsv2.BackColor = System.Drawing.Color.Silver;
            this.pnlExorttocsv2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlExorttocsv2.Controls.Add(this.cboTableName);
            this.pnlExorttocsv2.Controls.Add(this.dgvRequestedTableData);
            this.pnlExorttocsv2.Controls.Add(this.btnCSVReturnHome);
            this.pnlExorttocsv2.Controls.Add(this.btnExportTableToCSV);
            this.pnlExorttocsv2.Controls.Add(this.btnSeeRequestedTable);
            this.pnlExorttocsv2.Controls.Add(this.lblTableName);
            this.pnlExorttocsv2.Controls.Add(this.lblExporttoCSV);
            this.pnlExorttocsv2.Location = new System.Drawing.Point(20, 19);
            this.pnlExorttocsv2.Margin = new System.Windows.Forms.Padding(2);
            this.pnlExorttocsv2.Name = "pnlExorttocsv2";
            this.pnlExorttocsv2.Size = new System.Drawing.Size(765, 387);
            this.pnlExorttocsv2.TabIndex = 0;
            // 
            // dgvRequestedTableData
            // 
            this.dgvRequestedTableData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRequestedTableData.Location = new System.Drawing.Point(23, 124);
            this.dgvRequestedTableData.Margin = new System.Windows.Forms.Padding(2);
            this.dgvRequestedTableData.Name = "dgvRequestedTableData";
            this.dgvRequestedTableData.RowHeadersWidth = 51;
            this.dgvRequestedTableData.RowTemplate.Height = 24;
            this.dgvRequestedTableData.Size = new System.Drawing.Size(716, 207);
            this.dgvRequestedTableData.TabIndex = 3;
            // 
            // btnCSVReturnHome
            // 
            this.btnCSVReturnHome.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCSVReturnHome.Location = new System.Drawing.Point(23, 340);
            this.btnCSVReturnHome.Margin = new System.Windows.Forms.Padding(2);
            this.btnCSVReturnHome.Name = "btnCSVReturnHome";
            this.btnCSVReturnHome.Size = new System.Drawing.Size(170, 35);
            this.btnCSVReturnHome.TabIndex = 4;
            this.btnCSVReturnHome.Text = "RETURN HOME";
            this.btnCSVReturnHome.UseVisualStyleBackColor = true;
            this.btnCSVReturnHome.Click += new System.EventHandler(this.btnCSVReturnHome_Click);
            // 
            // btnExportTableToCSV
            // 
            this.btnExportTableToCSV.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportTableToCSV.Location = new System.Drawing.Point(571, 340);
            this.btnExportTableToCSV.Margin = new System.Windows.Forms.Padding(2);
            this.btnExportTableToCSV.Name = "btnExportTableToCSV";
            this.btnExportTableToCSV.Size = new System.Drawing.Size(170, 35);
            this.btnExportTableToCSV.TabIndex = 5;
            this.btnExportTableToCSV.Text = "EXPORT TO CSV FILE";
            this.btnExportTableToCSV.UseVisualStyleBackColor = true;
            this.btnExportTableToCSV.Click += new System.EventHandler(this.btnExportTableToCSV_Click);
            // 
            // btnSeeRequestedTable
            // 
            this.btnSeeRequestedTable.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeeRequestedTable.Location = new System.Drawing.Point(571, 84);
            this.btnSeeRequestedTable.Margin = new System.Windows.Forms.Padding(2);
            this.btnSeeRequestedTable.Name = "btnSeeRequestedTable";
            this.btnSeeRequestedTable.Size = new System.Drawing.Size(170, 35);
            this.btnSeeRequestedTable.TabIndex = 2;
            this.btnSeeRequestedTable.Text = "VIEW REQUESTED TABLE";
            this.btnSeeRequestedTable.UseVisualStyleBackColor = true;
            this.btnSeeRequestedTable.Click += new System.EventHandler(this.btnSeeRequestedTable_Click);
            // 
            // lblTableName
            // 
            this.lblTableName.AutoSize = true;
            this.lblTableName.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTableName.Location = new System.Drawing.Point(20, 98);
            this.lblTableName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTableName.Name = "lblTableName";
            this.lblTableName.Size = new System.Drawing.Size(148, 20);
            this.lblTableName.TabIndex = 6;
            this.lblTableName.Text = "ENTER TABLE NAME:";
            // 
            // lblExporttoCSV
            // 
            this.lblExporttoCSV.AutoSize = true;
            this.lblExporttoCSV.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold);
            this.lblExporttoCSV.Location = new System.Drawing.Point(191, 11);
            this.lblExporttoCSV.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblExporttoCSV.Name = "lblExporttoCSV";
            this.lblExporttoCSV.Size = new System.Drawing.Size(394, 29);
            this.lblExporttoCSV.TabIndex = 4;
            this.lblExporttoCSV.Text = "EXPORT TABLE DATA TO CSV FILE";
            // 
            // cboTableName
            // 
            this.cboTableName.FormattingEnabled = true;
            this.cboTableName.Location = new System.Drawing.Point(173, 97);
            this.cboTableName.Name = "cboTableName";
            this.cboTableName.Size = new System.Drawing.Size(169, 21);
            this.cboTableName.TabIndex = 7;
            // 
            // ExportToCSV
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1481, 731);
            this.Controls.Add(this.pnlExporttoCSV1);
            this.Controls.Add(this.pcbCSV);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ExportToCSV";
            this.Text = "EXPORT TO CSV FILE";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ExportToCSV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbCSV)).EndInit();
            this.pnlExporttoCSV1.ResumeLayout(false);
            this.pnlExorttocsv2.ResumeLayout(false);
            this.pnlExorttocsv2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequestedTableData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbCSV;
        private System.Windows.Forms.Panel pnlExporttoCSV1;
        private System.Windows.Forms.Panel pnlExorttocsv2;
        private System.Windows.Forms.Button btnCSVReturnHome;
        private System.Windows.Forms.Button btnExportTableToCSV;
        private System.Windows.Forms.Button btnSeeRequestedTable;
        private System.Windows.Forms.Label lblTableName;
        private System.Windows.Forms.Label lblExporttoCSV;
        private System.Windows.Forms.DataGridView dgvRequestedTableData;
        private System.Windows.Forms.ComboBox cboTableName;
    }
}
namespace SilverOaksHotel
{
    partial class MaintainPackages
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MaintainPackages));
            this.tbcMaintainPackages = new System.Windows.Forms.TabControl();
            this.tbpViewPackages = new System.Windows.Forms.TabPage();
            this.pnlListofPackages = new System.Windows.Forms.Panel();
            this.txtPackageNameSearch = new System.Windows.Forms.TextBox();
            this.lblpackagenamesearch = new System.Windows.Forms.Label();
            this.lblAllpackages = new System.Windows.Forms.Label();
            this.dgvAllPackages = new System.Windows.Forms.DataGridView();
            this.tbpCreatePackages = new System.Windows.Forms.TabPage();
            this.pnlcreateNewpackage = new System.Windows.Forms.Panel();
            this.btnClearPackageContent = new System.Windows.Forms.Button();
            this.btnCreatePackage = new System.Windows.Forms.Button();
            this.grbpackagedetails = new System.Windows.Forms.GroupBox();
            this.txtCreatePPrice = new System.Windows.Forms.TextBox();
            this.txtCreatePName = new System.Windows.Forms.TextBox();
            this.lblCreatePPrice = new System.Windows.Forms.Label();
            this.lblcreatePName = new System.Windows.Forms.Label();
            this.lblCreatePackage = new System.Windows.Forms.Label();
            this.tbpUpdatePackages = new System.Windows.Forms.TabPage();
            this.pnlUpdatePackage = new System.Windows.Forms.Panel();
            this.btnSelectPackageName = new System.Windows.Forms.Button();
            this.txtUpdatePackSearch = new System.Windows.Forms.TextBox();
            this.lblUpdatePackNamesearch = new System.Windows.Forms.Label();
            this.btnUpdateClearContent = new System.Windows.Forms.Button();
            this.btnUpdatePack = new System.Windows.Forms.Button();
            this.grbUpdatePackDetails = new System.Windows.Forms.GroupBox();
            this.txtUpdatePackPrice = new System.Windows.Forms.TextBox();
            this.txtUpdatePackName = new System.Windows.Forms.TextBox();
            this.lblUpdatePackPrice = new System.Windows.Forms.Label();
            this.lblUpdatePackname = new System.Windows.Forms.Label();
            this.dgvUpdatePackage = new System.Windows.Forms.DataGridView();
            this.lblUpdatePackage = new System.Windows.Forms.Label();
            this.tbpDeletePackages = new System.Windows.Forms.TabPage();
            this.pnlDeletePackage = new System.Windows.Forms.Panel();
            this.btnDeletePackage = new System.Windows.Forms.Button();
            this.dgvDeletePackage = new System.Windows.Forms.DataGridView();
            this.txtDeletePackName = new System.Windows.Forms.TextBox();
            this.lblDeletePackName = new System.Windows.Forms.Label();
            this.lblDeletePackage = new System.Windows.Forms.Label();
            this.btnPackageReturnHome = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pcb = new System.Windows.Forms.PictureBox();
            this.tbcMaintainPackages.SuspendLayout();
            this.tbpViewPackages.SuspendLayout();
            this.pnlListofPackages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllPackages)).BeginInit();
            this.tbpCreatePackages.SuspendLayout();
            this.pnlcreateNewpackage.SuspendLayout();
            this.grbpackagedetails.SuspendLayout();
            this.tbpUpdatePackages.SuspendLayout();
            this.pnlUpdatePackage.SuspendLayout();
            this.grbUpdatePackDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUpdatePackage)).BeginInit();
            this.tbpDeletePackages.SuspendLayout();
            this.pnlDeletePackage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeletePackage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb)).BeginInit();
            this.SuspendLayout();
            // 
            // tbcMaintainPackages
            // 
            this.tbcMaintainPackages.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbcMaintainPackages.Controls.Add(this.tbpViewPackages);
            this.tbcMaintainPackages.Controls.Add(this.tbpCreatePackages);
            this.tbcMaintainPackages.Controls.Add(this.tbpUpdatePackages);
            this.tbcMaintainPackages.Controls.Add(this.tbpDeletePackages);
            this.tbcMaintainPackages.Location = new System.Drawing.Point(9, 10);
            this.tbcMaintainPackages.Margin = new System.Windows.Forms.Padding(2);
            this.tbcMaintainPackages.Name = "tbcMaintainPackages";
            this.tbcMaintainPackages.SelectedIndex = 0;
            this.tbcMaintainPackages.Size = new System.Drawing.Size(1058, 595);
            this.tbcMaintainPackages.TabIndex = 0;
            // 
            // tbpViewPackages
            // 
            this.tbpViewPackages.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(15)))));
            this.tbpViewPackages.Controls.Add(this.pnlListofPackages);
            this.tbpViewPackages.Location = new System.Drawing.Point(4, 22);
            this.tbpViewPackages.Margin = new System.Windows.Forms.Padding(2);
            this.tbpViewPackages.Name = "tbpViewPackages";
            this.tbpViewPackages.Padding = new System.Windows.Forms.Padding(2);
            this.tbpViewPackages.Size = new System.Drawing.Size(1050, 569);
            this.tbpViewPackages.TabIndex = 0;
            this.tbpViewPackages.Text = "VIEW ALL PACKAGES";
            this.tbpViewPackages.Enter += new System.EventHandler(this.tbpViewPackages_Enter);
            // 
            // pnlListofPackages
            // 
            this.pnlListofPackages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlListofPackages.BackColor = System.Drawing.Color.Silver;
            this.pnlListofPackages.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlListofPackages.Controls.Add(this.txtPackageNameSearch);
            this.pnlListofPackages.Controls.Add(this.lblpackagenamesearch);
            this.pnlListofPackages.Controls.Add(this.lblAllpackages);
            this.pnlListofPackages.Controls.Add(this.dgvAllPackages);
            this.pnlListofPackages.Location = new System.Drawing.Point(17, 17);
            this.pnlListofPackages.Margin = new System.Windows.Forms.Padding(2);
            this.pnlListofPackages.Name = "pnlListofPackages";
            this.pnlListofPackages.Size = new System.Drawing.Size(1013, 536);
            this.pnlListofPackages.TabIndex = 0;
            // 
            // txtPackageNameSearch
            // 
            this.txtPackageNameSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPackageNameSearch.Location = new System.Drawing.Point(207, 69);
            this.txtPackageNameSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtPackageNameSearch.Name = "txtPackageNameSearch";
            this.txtPackageNameSearch.Size = new System.Drawing.Size(158, 26);
            this.txtPackageNameSearch.TabIndex = 1;
            this.txtPackageNameSearch.TextChanged += new System.EventHandler(this.txtPackageNameSearch_TextChanged);
            // 
            // lblpackagenamesearch
            // 
            this.lblpackagenamesearch.AutoSize = true;
            this.lblpackagenamesearch.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpackagenamesearch.Location = new System.Drawing.Point(22, 73);
            this.lblpackagenamesearch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblpackagenamesearch.Name = "lblpackagenamesearch";
            this.lblpackagenamesearch.Size = new System.Drawing.Size(181, 20);
            this.lblpackagenamesearch.TabIndex = 6;
            this.lblpackagenamesearch.Text = "SEARCH PACKAGE NAME:";
            // 
            // lblAllpackages
            // 
            this.lblAllpackages.AutoSize = true;
            this.lblAllpackages.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold);
            this.lblAllpackages.Location = new System.Drawing.Point(335, 7);
            this.lblAllpackages.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAllpackages.Name = "lblAllpackages";
            this.lblAllpackages.Size = new System.Drawing.Size(275, 29);
            this.lblAllpackages.TabIndex = 5;
            this.lblAllpackages.Text = "LIST OF ALL PACKAGES";
            // 
            // dgvAllPackages
            // 
            this.dgvAllPackages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllPackages.Location = new System.Drawing.Point(25, 106);
            this.dgvAllPackages.Margin = new System.Windows.Forms.Padding(2);
            this.dgvAllPackages.Name = "dgvAllPackages";
            this.dgvAllPackages.RowHeadersWidth = 51;
            this.dgvAllPackages.RowTemplate.Height = 24;
            this.dgvAllPackages.Size = new System.Drawing.Size(965, 313);
            this.dgvAllPackages.TabIndex = 2;
            // 
            // tbpCreatePackages
            // 
            this.tbpCreatePackages.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(15)))));
            this.tbpCreatePackages.Controls.Add(this.pnlcreateNewpackage);
            this.tbpCreatePackages.Location = new System.Drawing.Point(4, 22);
            this.tbpCreatePackages.Margin = new System.Windows.Forms.Padding(2);
            this.tbpCreatePackages.Name = "tbpCreatePackages";
            this.tbpCreatePackages.Padding = new System.Windows.Forms.Padding(2);
            this.tbpCreatePackages.Size = new System.Drawing.Size(1050, 569);
            this.tbpCreatePackages.TabIndex = 1;
            this.tbpCreatePackages.Text = "CREATE NEW PACKAGES";
            // 
            // pnlcreateNewpackage
            // 
            this.pnlcreateNewpackage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlcreateNewpackage.BackColor = System.Drawing.Color.Silver;
            this.pnlcreateNewpackage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlcreateNewpackage.Controls.Add(this.btnClearPackageContent);
            this.pnlcreateNewpackage.Controls.Add(this.btnCreatePackage);
            this.pnlcreateNewpackage.Controls.Add(this.grbpackagedetails);
            this.pnlcreateNewpackage.Controls.Add(this.lblCreatePackage);
            this.pnlcreateNewpackage.Location = new System.Drawing.Point(18, 18);
            this.pnlcreateNewpackage.Margin = new System.Windows.Forms.Padding(2);
            this.pnlcreateNewpackage.Name = "pnlcreateNewpackage";
            this.pnlcreateNewpackage.Size = new System.Drawing.Size(1012, 536);
            this.pnlcreateNewpackage.TabIndex = 1;
            // 
            // btnClearPackageContent
            // 
            this.btnClearPackageContent.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearPackageContent.Location = new System.Drawing.Point(194, 247);
            this.btnClearPackageContent.Margin = new System.Windows.Forms.Padding(2);
            this.btnClearPackageContent.Name = "btnClearPackageContent";
            this.btnClearPackageContent.Size = new System.Drawing.Size(171, 35);
            this.btnClearPackageContent.TabIndex = 5;
            this.btnClearPackageContent.Text = "CLEAR DETAILS";
            this.btnClearPackageContent.UseVisualStyleBackColor = true;
            this.btnClearPackageContent.Click += new System.EventHandler(this.btnClearPackageContent_Click);
            // 
            // btnCreatePackage
            // 
            this.btnCreatePackage.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreatePackage.Location = new System.Drawing.Point(19, 247);
            this.btnCreatePackage.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreatePackage.Name = "btnCreatePackage";
            this.btnCreatePackage.Size = new System.Drawing.Size(171, 35);
            this.btnCreatePackage.TabIndex = 4;
            this.btnCreatePackage.Text = "CREATE NEW PACKAGE";
            this.btnCreatePackage.UseVisualStyleBackColor = true;
            this.btnCreatePackage.Click += new System.EventHandler(this.btnCreatePackage_Click);
            // 
            // grbpackagedetails
            // 
            this.grbpackagedetails.BackColor = System.Drawing.Color.LightGray;
            this.grbpackagedetails.Controls.Add(this.txtCreatePPrice);
            this.grbpackagedetails.Controls.Add(this.txtCreatePName);
            this.grbpackagedetails.Controls.Add(this.lblCreatePPrice);
            this.grbpackagedetails.Controls.Add(this.lblcreatePName);
            this.grbpackagedetails.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbpackagedetails.Location = new System.Drawing.Point(19, 55);
            this.grbpackagedetails.Margin = new System.Windows.Forms.Padding(2);
            this.grbpackagedetails.Name = "grbpackagedetails";
            this.grbpackagedetails.Padding = new System.Windows.Forms.Padding(2);
            this.grbpackagedetails.Size = new System.Drawing.Size(291, 171);
            this.grbpackagedetails.TabIndex = 6;
            this.grbpackagedetails.TabStop = false;
            this.grbpackagedetails.Text = "PACKAGE DETAILS";
            // 
            // txtCreatePPrice
            // 
            this.txtCreatePPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCreatePPrice.Location = new System.Drawing.Point(146, 116);
            this.txtCreatePPrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtCreatePPrice.Name = "txtCreatePPrice";
            this.txtCreatePPrice.Size = new System.Drawing.Size(134, 26);
            this.txtCreatePPrice.TabIndex = 2;
            // 
            // txtCreatePName
            // 
            this.txtCreatePName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCreatePName.Location = new System.Drawing.Point(146, 54);
            this.txtCreatePName.Margin = new System.Windows.Forms.Padding(2);
            this.txtCreatePName.Name = "txtCreatePName";
            this.txtCreatePName.Size = new System.Drawing.Size(134, 26);
            this.txtCreatePName.TabIndex = 1;
            // 
            // lblCreatePPrice
            // 
            this.lblCreatePPrice.AutoSize = true;
            this.lblCreatePPrice.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreatePPrice.Location = new System.Drawing.Point(11, 119);
            this.lblCreatePPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCreatePPrice.Name = "lblCreatePPrice";
            this.lblCreatePPrice.Size = new System.Drawing.Size(118, 20);
            this.lblCreatePPrice.TabIndex = 8;
            this.lblCreatePPrice.Text = "PACKAGE PRICE:";
            // 
            // lblcreatePName
            // 
            this.lblcreatePName.AutoSize = true;
            this.lblcreatePName.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcreatePName.Location = new System.Drawing.Point(11, 58);
            this.lblcreatePName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblcreatePName.Name = "lblcreatePName";
            this.lblcreatePName.Size = new System.Drawing.Size(122, 20);
            this.lblcreatePName.TabIndex = 7;
            this.lblcreatePName.Text = "PACKAGE NAME:";
            // 
            // lblCreatePackage
            // 
            this.lblCreatePackage.AutoSize = true;
            this.lblCreatePackage.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold);
            this.lblCreatePackage.Location = new System.Drawing.Point(167, 8);
            this.lblCreatePackage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCreatePackage.Name = "lblCreatePackage";
            this.lblCreatePackage.Size = new System.Drawing.Size(276, 29);
            this.lblCreatePackage.TabIndex = 5;
            this.lblCreatePackage.Text = "CREATE NEW PACKAGE";
            // 
            // tbpUpdatePackages
            // 
            this.tbpUpdatePackages.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(15)))));
            this.tbpUpdatePackages.Controls.Add(this.pnlUpdatePackage);
            this.tbpUpdatePackages.Location = new System.Drawing.Point(4, 22);
            this.tbpUpdatePackages.Margin = new System.Windows.Forms.Padding(2);
            this.tbpUpdatePackages.Name = "tbpUpdatePackages";
            this.tbpUpdatePackages.Padding = new System.Windows.Forms.Padding(2);
            this.tbpUpdatePackages.Size = new System.Drawing.Size(1050, 569);
            this.tbpUpdatePackages.TabIndex = 2;
            this.tbpUpdatePackages.Text = "UPDATE EXISTING PACKAGES";
            this.tbpUpdatePackages.Enter += new System.EventHandler(this.tbpUpdatePackages_Enter);
            // 
            // pnlUpdatePackage
            // 
            this.pnlUpdatePackage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlUpdatePackage.BackColor = System.Drawing.Color.Silver;
            this.pnlUpdatePackage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlUpdatePackage.Controls.Add(this.btnSelectPackageName);
            this.pnlUpdatePackage.Controls.Add(this.txtUpdatePackSearch);
            this.pnlUpdatePackage.Controls.Add(this.lblUpdatePackNamesearch);
            this.pnlUpdatePackage.Controls.Add(this.btnUpdateClearContent);
            this.pnlUpdatePackage.Controls.Add(this.btnUpdatePack);
            this.pnlUpdatePackage.Controls.Add(this.grbUpdatePackDetails);
            this.pnlUpdatePackage.Controls.Add(this.dgvUpdatePackage);
            this.pnlUpdatePackage.Controls.Add(this.lblUpdatePackage);
            this.pnlUpdatePackage.Location = new System.Drawing.Point(18, 18);
            this.pnlUpdatePackage.Margin = new System.Windows.Forms.Padding(2);
            this.pnlUpdatePackage.Name = "pnlUpdatePackage";
            this.pnlUpdatePackage.Size = new System.Drawing.Size(1010, 529);
            this.pnlUpdatePackage.TabIndex = 1;
            // 
            // btnSelectPackageName
            // 
            this.btnSelectPackageName.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectPackageName.Location = new System.Drawing.Point(416, 67);
            this.btnSelectPackageName.Margin = new System.Windows.Forms.Padding(2);
            this.btnSelectPackageName.Name = "btnSelectPackageName";
            this.btnSelectPackageName.Size = new System.Drawing.Size(170, 35);
            this.btnSelectPackageName.TabIndex = 19;
            this.btnSelectPackageName.Text = "SELECT";
            this.btnSelectPackageName.UseVisualStyleBackColor = true;
            this.btnSelectPackageName.Click += new System.EventHandler(this.btnSelectPackageName_Click);
            // 
            // txtUpdatePackSearch
            // 
            this.txtUpdatePackSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpdatePackSearch.Location = new System.Drawing.Point(222, 72);
            this.txtUpdatePackSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtUpdatePackSearch.Name = "txtUpdatePackSearch";
            this.txtUpdatePackSearch.Size = new System.Drawing.Size(158, 26);
            this.txtUpdatePackSearch.TabIndex = 1;
            this.txtUpdatePackSearch.TextChanged += new System.EventHandler(this.txtUpdatePackSearch_TextChanged);
            // 
            // lblUpdatePackNamesearch
            // 
            this.lblUpdatePackNamesearch.AutoSize = true;
            this.lblUpdatePackNamesearch.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdatePackNamesearch.Location = new System.Drawing.Point(26, 76);
            this.lblUpdatePackNamesearch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUpdatePackNamesearch.Name = "lblUpdatePackNamesearch";
            this.lblUpdatePackNamesearch.Size = new System.Drawing.Size(181, 20);
            this.lblUpdatePackNamesearch.TabIndex = 18;
            this.lblUpdatePackNamesearch.Text = "SEARCH PACKAGE NAME:";
            // 
            // btnUpdateClearContent
            // 
            this.btnUpdateClearContent.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateClearContent.Location = new System.Drawing.Point(353, 476);
            this.btnUpdateClearContent.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateClearContent.Name = "btnUpdateClearContent";
            this.btnUpdateClearContent.Size = new System.Drawing.Size(171, 35);
            this.btnUpdateClearContent.TabIndex = 7;
            this.btnUpdateClearContent.Text = "CLEAR DETAILS";
            this.btnUpdateClearContent.UseVisualStyleBackColor = true;
            this.btnUpdateClearContent.Click += new System.EventHandler(this.btnUpdateClearContent_Click);
            // 
            // btnUpdatePack
            // 
            this.btnUpdatePack.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdatePack.Location = new System.Drawing.Point(353, 414);
            this.btnUpdatePack.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdatePack.Name = "btnUpdatePack";
            this.btnUpdatePack.Size = new System.Drawing.Size(171, 35);
            this.btnUpdatePack.TabIndex = 6;
            this.btnUpdatePack.Text = "UPDATE PACKAGE";
            this.btnUpdatePack.UseVisualStyleBackColor = true;
            this.btnUpdatePack.Click += new System.EventHandler(this.btnUpdatePack_Click);
            // 
            // grbUpdatePackDetails
            // 
            this.grbUpdatePackDetails.BackColor = System.Drawing.Color.LightGray;
            this.grbUpdatePackDetails.Controls.Add(this.txtUpdatePackPrice);
            this.grbUpdatePackDetails.Controls.Add(this.txtUpdatePackName);
            this.grbUpdatePackDetails.Controls.Add(this.lblUpdatePackPrice);
            this.grbUpdatePackDetails.Controls.Add(this.lblUpdatePackname);
            this.grbUpdatePackDetails.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbUpdatePackDetails.Location = new System.Drawing.Point(28, 344);
            this.grbUpdatePackDetails.Margin = new System.Windows.Forms.Padding(2);
            this.grbUpdatePackDetails.Name = "grbUpdatePackDetails";
            this.grbUpdatePackDetails.Padding = new System.Windows.Forms.Padding(2);
            this.grbUpdatePackDetails.Size = new System.Drawing.Size(283, 169);
            this.grbUpdatePackDetails.TabIndex = 7;
            this.grbUpdatePackDetails.TabStop = false;
            this.grbUpdatePackDetails.Text = "PACKAGE DETAILS";
            // 
            // txtUpdatePackPrice
            // 
            this.txtUpdatePackPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpdatePackPrice.Location = new System.Drawing.Point(146, 116);
            this.txtUpdatePackPrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtUpdatePackPrice.Name = "txtUpdatePackPrice";
            this.txtUpdatePackPrice.Size = new System.Drawing.Size(134, 26);
            this.txtUpdatePackPrice.TabIndex = 4;
            // 
            // txtUpdatePackName
            // 
            this.txtUpdatePackName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpdatePackName.Location = new System.Drawing.Point(146, 54);
            this.txtUpdatePackName.Margin = new System.Windows.Forms.Padding(2);
            this.txtUpdatePackName.Name = "txtUpdatePackName";
            this.txtUpdatePackName.Size = new System.Drawing.Size(134, 26);
            this.txtUpdatePackName.TabIndex = 3;
            // 
            // lblUpdatePackPrice
            // 
            this.lblUpdatePackPrice.AutoSize = true;
            this.lblUpdatePackPrice.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdatePackPrice.Location = new System.Drawing.Point(11, 119);
            this.lblUpdatePackPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUpdatePackPrice.Name = "lblUpdatePackPrice";
            this.lblUpdatePackPrice.Size = new System.Drawing.Size(118, 20);
            this.lblUpdatePackPrice.TabIndex = 8;
            this.lblUpdatePackPrice.Text = "PACKAGE PRICE:";
            // 
            // lblUpdatePackname
            // 
            this.lblUpdatePackname.AutoSize = true;
            this.lblUpdatePackname.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdatePackname.Location = new System.Drawing.Point(11, 58);
            this.lblUpdatePackname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUpdatePackname.Name = "lblUpdatePackname";
            this.lblUpdatePackname.Size = new System.Drawing.Size(122, 20);
            this.lblUpdatePackname.TabIndex = 7;
            this.lblUpdatePackname.Text = "PACKAGE NAME:";
            // 
            // dgvUpdatePackage
            // 
            this.dgvUpdatePackage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUpdatePackage.Location = new System.Drawing.Point(28, 106);
            this.dgvUpdatePackage.Margin = new System.Windows.Forms.Padding(2);
            this.dgvUpdatePackage.Name = "dgvUpdatePackage";
            this.dgvUpdatePackage.RowHeadersWidth = 51;
            this.dgvUpdatePackage.RowTemplate.Height = 24;
            this.dgvUpdatePackage.Size = new System.Drawing.Size(961, 219);
            this.dgvUpdatePackage.TabIndex = 2;
            // 
            // lblUpdatePackage
            // 
            this.lblUpdatePackage.AutoSize = true;
            this.lblUpdatePackage.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold);
            this.lblUpdatePackage.Location = new System.Drawing.Point(317, 11);
            this.lblUpdatePackage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUpdatePackage.Name = "lblUpdatePackage";
            this.lblUpdatePackage.Size = new System.Drawing.Size(350, 29);
            this.lblUpdatePackage.TabIndex = 5;
            this.lblUpdatePackage.Text = "UPDATE CURRENT PACKAGES";
            // 
            // tbpDeletePackages
            // 
            this.tbpDeletePackages.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(15)))));
            this.tbpDeletePackages.Controls.Add(this.pnlDeletePackage);
            this.tbpDeletePackages.Location = new System.Drawing.Point(4, 22);
            this.tbpDeletePackages.Margin = new System.Windows.Forms.Padding(2);
            this.tbpDeletePackages.Name = "tbpDeletePackages";
            this.tbpDeletePackages.Padding = new System.Windows.Forms.Padding(2);
            this.tbpDeletePackages.Size = new System.Drawing.Size(1050, 569);
            this.tbpDeletePackages.TabIndex = 3;
            this.tbpDeletePackages.Text = "DELETE EXISTING PACKAGES";
            this.tbpDeletePackages.Enter += new System.EventHandler(this.tbpDeletePackages_Enter);
            // 
            // pnlDeletePackage
            // 
            this.pnlDeletePackage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDeletePackage.BackColor = System.Drawing.Color.Silver;
            this.pnlDeletePackage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDeletePackage.Controls.Add(this.btnDeletePackage);
            this.pnlDeletePackage.Controls.Add(this.dgvDeletePackage);
            this.pnlDeletePackage.Controls.Add(this.txtDeletePackName);
            this.pnlDeletePackage.Controls.Add(this.lblDeletePackName);
            this.pnlDeletePackage.Controls.Add(this.lblDeletePackage);
            this.pnlDeletePackage.Location = new System.Drawing.Point(18, 18);
            this.pnlDeletePackage.Margin = new System.Windows.Forms.Padding(2);
            this.pnlDeletePackage.Name = "pnlDeletePackage";
            this.pnlDeletePackage.Size = new System.Drawing.Size(1011, 526);
            this.pnlDeletePackage.TabIndex = 1;
            // 
            // btnDeletePackage
            // 
            this.btnDeletePackage.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletePackage.Location = new System.Drawing.Point(800, 476);
            this.btnDeletePackage.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeletePackage.Name = "btnDeletePackage";
            this.btnDeletePackage.Size = new System.Drawing.Size(195, 35);
            this.btnDeletePackage.TabIndex = 22;
            this.btnDeletePackage.Text = "DELETE SELECTED PACKAGE";
            this.btnDeletePackage.UseVisualStyleBackColor = true;
            this.btnDeletePackage.Click += new System.EventHandler(this.btnDeletePackage_Click);
            // 
            // dgvDeletePackage
            // 
            this.dgvDeletePackage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeletePackage.Location = new System.Drawing.Point(27, 104);
            this.dgvDeletePackage.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDeletePackage.Name = "dgvDeletePackage";
            this.dgvDeletePackage.RowHeadersWidth = 51;
            this.dgvDeletePackage.RowTemplate.Height = 24;
            this.dgvDeletePackage.Size = new System.Drawing.Size(968, 368);
            this.dgvDeletePackage.TabIndex = 21;
            // 
            // txtDeletePackName
            // 
            this.txtDeletePackName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeletePackName.Location = new System.Drawing.Point(209, 65);
            this.txtDeletePackName.Margin = new System.Windows.Forms.Padding(2);
            this.txtDeletePackName.Name = "txtDeletePackName";
            this.txtDeletePackName.Size = new System.Drawing.Size(158, 26);
            this.txtDeletePackName.TabIndex = 20;
            this.txtDeletePackName.TextChanged += new System.EventHandler(this.txtDeletePackName_TextChanged);
            // 
            // lblDeletePackName
            // 
            this.lblDeletePackName.AutoSize = true;
            this.lblDeletePackName.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeletePackName.Location = new System.Drawing.Point(24, 69);
            this.lblDeletePackName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDeletePackName.Name = "lblDeletePackName";
            this.lblDeletePackName.Size = new System.Drawing.Size(181, 20);
            this.lblDeletePackName.TabIndex = 19;
            this.lblDeletePackName.Text = "SEARCH PACKAGE NAME:";
            // 
            // lblDeletePackage
            // 
            this.lblDeletePackage.AutoSize = true;
            this.lblDeletePackage.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold);
            this.lblDeletePackage.Location = new System.Drawing.Point(316, 12);
            this.lblDeletePackage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDeletePackage.Name = "lblDeletePackage";
            this.lblDeletePackage.Size = new System.Drawing.Size(344, 29);
            this.lblDeletePackage.TabIndex = 5;
            this.lblDeletePackage.Text = "DELETE CURRENT PACKAGES";
            // 
            // btnPackageReturnHome
            // 
            this.btnPackageReturnHome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPackageReturnHome.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPackageReturnHome.Location = new System.Drawing.Point(13, 609);
            this.btnPackageReturnHome.Margin = new System.Windows.Forms.Padding(2);
            this.btnPackageReturnHome.Name = "btnPackageReturnHome";
            this.btnPackageReturnHome.Size = new System.Drawing.Size(170, 35);
            this.btnPackageReturnHome.TabIndex = 3;
            this.btnPackageReturnHome.Text = "RETURN TO MENU";
            this.btnPackageReturnHome.UseVisualStyleBackColor = true;
            this.btnPackageReturnHome.Click += new System.EventHandler(this.btnPackageReturnHome_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // pcb
            // 
            this.pcb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pcb.BackColor = System.Drawing.Color.Transparent;
            this.pcb.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pcb.BackgroundImage")));
            this.pcb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcb.Location = new System.Drawing.Point(1071, -4);
            this.pcb.Margin = new System.Windows.Forms.Padding(2);
            this.pcb.Name = "pcb";
            this.pcb.Size = new System.Drawing.Size(400, 660);
            this.pcb.TabIndex = 12;
            this.pcb.TabStop = false;
            // 
            // MaintainPackages
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1471, 655);
            this.Controls.Add(this.pcb);
            this.Controls.Add(this.btnPackageReturnHome);
            this.Controls.Add(this.tbcMaintainPackages);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MaintainPackages";
            this.Text = "MAINTAIN PACKAGES";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tbcMaintainPackages.ResumeLayout(false);
            this.tbpViewPackages.ResumeLayout(false);
            this.pnlListofPackages.ResumeLayout(false);
            this.pnlListofPackages.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllPackages)).EndInit();
            this.tbpCreatePackages.ResumeLayout(false);
            this.pnlcreateNewpackage.ResumeLayout(false);
            this.pnlcreateNewpackage.PerformLayout();
            this.grbpackagedetails.ResumeLayout(false);
            this.grbpackagedetails.PerformLayout();
            this.tbpUpdatePackages.ResumeLayout(false);
            this.pnlUpdatePackage.ResumeLayout(false);
            this.pnlUpdatePackage.PerformLayout();
            this.grbUpdatePackDetails.ResumeLayout(false);
            this.grbUpdatePackDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUpdatePackage)).EndInit();
            this.tbpDeletePackages.ResumeLayout(false);
            this.pnlDeletePackage.ResumeLayout(false);
            this.pnlDeletePackage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeletePackage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcMaintainPackages;
        private System.Windows.Forms.TabPage tbpViewPackages;
        private System.Windows.Forms.TabPage tbpCreatePackages;
        private System.Windows.Forms.TabPage tbpUpdatePackages;
        private System.Windows.Forms.TabPage tbpDeletePackages;
        private System.Windows.Forms.Panel pnlListofPackages;
        private System.Windows.Forms.Panel pnlcreateNewpackage;
        private System.Windows.Forms.Panel pnlUpdatePackage;
        private System.Windows.Forms.Panel pnlDeletePackage;
        private System.Windows.Forms.DataGridView dgvAllPackages;
        private System.Windows.Forms.Label lblAllpackages;
        private System.Windows.Forms.Label lblCreatePackage;
        private System.Windows.Forms.Label lblUpdatePackage;
        private System.Windows.Forms.Label lblDeletePackage;
        private System.Windows.Forms.Label lblpackagenamesearch;
        private System.Windows.Forms.TextBox txtPackageNameSearch;
        private System.Windows.Forms.Button btnPackageReturnHome;
        private System.Windows.Forms.GroupBox grbpackagedetails;
        private System.Windows.Forms.Label lblCreatePPrice;
        private System.Windows.Forms.Label lblcreatePName;
        private System.Windows.Forms.TextBox txtCreatePPrice;
        private System.Windows.Forms.TextBox txtCreatePName;
        private System.Windows.Forms.Button btnClearPackageContent;
        private System.Windows.Forms.Button btnCreatePackage;
        private System.Windows.Forms.GroupBox grbUpdatePackDetails;
        private System.Windows.Forms.Label lblUpdatePackPrice;
        private System.Windows.Forms.Label lblUpdatePackname;
        private System.Windows.Forms.DataGridView dgvUpdatePackage;
        private System.Windows.Forms.TextBox txtUpdatePackSearch;
        private System.Windows.Forms.Label lblUpdatePackNamesearch;
        private System.Windows.Forms.Button btnUpdateClearContent;
        private System.Windows.Forms.Button btnUpdatePack;
        private System.Windows.Forms.DataGridView dgvDeletePackage;
        private System.Windows.Forms.TextBox txtDeletePackName;
        private System.Windows.Forms.Label lblDeletePackName;
        private System.Windows.Forms.Button btnDeletePackage;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnSelectPackageName;
        private System.Windows.Forms.PictureBox pcb;
        public System.Windows.Forms.TextBox txtUpdatePackPrice;
        public System.Windows.Forms.TextBox txtUpdatePackName;
    }
}
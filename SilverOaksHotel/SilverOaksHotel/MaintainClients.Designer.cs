namespace SilverOaksHotel
{
    partial class MaintainClients
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MaintainClients));
            this.tbcMaintainClients = new System.Windows.Forms.TabControl();
            this.tbpViewAllClients = new System.Windows.Forms.TabPage();
            this.pnlViewActiveClients = new System.Windows.Forms.Panel();
            this.txtSearchClientName = new System.Windows.Forms.TextBox();
            this.lblSearchC = new System.Windows.Forms.Label();
            this.lblAllClients = new System.Windows.Forms.Label();
            this.dgvViewClients = new System.Windows.Forms.DataGridView();
            this.tbpUpdateClients = new System.Windows.Forms.TabPage();
            this.pnlUpdateClients = new System.Windows.Forms.Panel();
            this.btnSelectClientId = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnUpdateClient = new System.Windows.Forms.Button();
            this.gbxClientDetails = new System.Windows.Forms.GroupBox();
            this.txtUpdateClientEmail = new System.Windows.Forms.TextBox();
            this.txtUpdateClientNumber = new System.Windows.Forms.TextBox();
            this.txtUpdateClientSName = new System.Windows.Forms.TextBox();
            this.txtUpdateClientName = new System.Windows.Forms.TextBox();
            this.lblUpdateClientEmail = new System.Windows.Forms.Label();
            this.lblUpdateClientNumber = new System.Windows.Forms.Label();
            this.lblUpdateClientSName = new System.Windows.Forms.Label();
            this.lblUpdateClientName = new System.Windows.Forms.Label();
            this.txtSearchCName = new System.Windows.Forms.TextBox();
            this.lblsearchupdateCId = new System.Windows.Forms.Label();
            this.lblUpdateClient = new System.Windows.Forms.Label();
            this.dgvUpdateClient = new System.Windows.Forms.DataGridView();
            this.tbpDeleteClient = new System.Windows.Forms.TabPage();
            this.pnlDeleteClients = new System.Windows.Forms.Panel();
            this.btnDeleteClient = new System.Windows.Forms.Button();
            this.txtSearchDeleteClientName = new System.Windows.Forms.TextBox();
            this.lblSearchDeleteClientName = new System.Windows.Forms.Label();
            this.lblDeleteClient = new System.Windows.Forms.Label();
            this.dgvDeleteClient = new System.Windows.Forms.DataGridView();
            this.btnClientReturnHome = new System.Windows.Forms.Button();
            this.pcb = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tbcMaintainClients.SuspendLayout();
            this.tbpViewAllClients.SuspendLayout();
            this.pnlViewActiveClients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewClients)).BeginInit();
            this.tbpUpdateClients.SuspendLayout();
            this.pnlUpdateClients.SuspendLayout();
            this.gbxClientDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUpdateClient)).BeginInit();
            this.tbpDeleteClient.SuspendLayout();
            this.pnlDeleteClients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeleteClient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbcMaintainClients
            // 
            this.tbcMaintainClients.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbcMaintainClients.Controls.Add(this.tbpViewAllClients);
            this.tbcMaintainClients.Controls.Add(this.tbpUpdateClients);
            this.tbcMaintainClients.Controls.Add(this.tbpDeleteClient);
            this.tbcMaintainClients.Location = new System.Drawing.Point(9, 10);
            this.tbcMaintainClients.Margin = new System.Windows.Forms.Padding(2);
            this.tbcMaintainClients.Name = "tbcMaintainClients";
            this.tbcMaintainClients.SelectedIndex = 0;
            this.tbcMaintainClients.Size = new System.Drawing.Size(1056, 669);
            this.tbcMaintainClients.TabIndex = 0;
            // 
            // tbpViewAllClients
            // 
            this.tbpViewAllClients.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(15)))));
            this.tbpViewAllClients.Controls.Add(this.pnlViewActiveClients);
            this.tbpViewAllClients.Location = new System.Drawing.Point(4, 22);
            this.tbpViewAllClients.Margin = new System.Windows.Forms.Padding(2);
            this.tbpViewAllClients.Name = "tbpViewAllClients";
            this.tbpViewAllClients.Padding = new System.Windows.Forms.Padding(2);
            this.tbpViewAllClients.Size = new System.Drawing.Size(1048, 643);
            this.tbpViewAllClients.TabIndex = 0;
            this.tbpViewAllClients.Text = "VIEW ACTIVE CLIENTS";
            this.tbpViewAllClients.Enter += new System.EventHandler(this.tbpViewAllClients_Enter);
            // 
            // pnlViewActiveClients
            // 
            this.pnlViewActiveClients.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlViewActiveClients.BackColor = System.Drawing.Color.Silver;
            this.pnlViewActiveClients.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlViewActiveClients.Controls.Add(this.txtSearchClientName);
            this.pnlViewActiveClients.Controls.Add(this.lblSearchC);
            this.pnlViewActiveClients.Controls.Add(this.lblAllClients);
            this.pnlViewActiveClients.Controls.Add(this.dgvViewClients);
            this.pnlViewActiveClients.Location = new System.Drawing.Point(19, 17);
            this.pnlViewActiveClients.Margin = new System.Windows.Forms.Padding(2);
            this.pnlViewActiveClients.Name = "pnlViewActiveClients";
            this.pnlViewActiveClients.Size = new System.Drawing.Size(1007, 601);
            this.pnlViewActiveClients.TabIndex = 0;
            // 
            // txtSearchClientName
            // 
            this.txtSearchClientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchClientName.Location = new System.Drawing.Point(201, 85);
            this.txtSearchClientName.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearchClientName.Name = "txtSearchClientName";
            this.txtSearchClientName.Size = new System.Drawing.Size(158, 26);
            this.txtSearchClientName.TabIndex = 9;
            this.txtSearchClientName.TextChanged += new System.EventHandler(this.txtSearchClientName_TextChanged_1);
            // 
            // lblSearchC
            // 
            this.lblSearchC.AutoSize = true;
            this.lblSearchC.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchC.Location = new System.Drawing.Point(19, 89);
            this.lblSearchC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSearchC.Name = "lblSearchC";
            this.lblSearchC.Size = new System.Drawing.Size(178, 20);
            this.lblSearchC.TabIndex = 5;
            this.lblSearchC.Text = "SEARCH CLIENT DETAILS:";
            // 
            // lblAllClients
            // 
            this.lblAllClients.AutoSize = true;
            this.lblAllClients.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold);
            this.lblAllClients.Location = new System.Drawing.Point(307, 9);
            this.lblAllClients.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAllClients.Name = "lblAllClients";
            this.lblAllClients.Size = new System.Drawing.Size(339, 29);
            this.lblAllClients.TabIndex = 4;
            this.lblAllClients.Text = "LIST OF ALL ACTIVE CLIENTS";
            // 
            // dgvViewClients
            // 
            this.dgvViewClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewClients.Location = new System.Drawing.Point(22, 124);
            this.dgvViewClients.Margin = new System.Windows.Forms.Padding(2);
            this.dgvViewClients.Name = "dgvViewClients";
            this.dgvViewClients.RowHeadersWidth = 51;
            this.dgvViewClients.RowTemplate.Height = 24;
            this.dgvViewClients.Size = new System.Drawing.Size(958, 288);
            this.dgvViewClients.TabIndex = 0;
            // 
            // tbpUpdateClients
            // 
            this.tbpUpdateClients.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(15)))));
            this.tbpUpdateClients.Controls.Add(this.pnlUpdateClients);
            this.tbpUpdateClients.Location = new System.Drawing.Point(4, 22);
            this.tbpUpdateClients.Margin = new System.Windows.Forms.Padding(2);
            this.tbpUpdateClients.Name = "tbpUpdateClients";
            this.tbpUpdateClients.Padding = new System.Windows.Forms.Padding(2);
            this.tbpUpdateClients.Size = new System.Drawing.Size(1048, 643);
            this.tbpUpdateClients.TabIndex = 1;
            this.tbpUpdateClients.Text = "UPDATE ACTIVE CLIENTS";
            this.tbpUpdateClients.Enter += new System.EventHandler(this.tbpUpdateClients_Enter);
            // 
            // pnlUpdateClients
            // 
            this.pnlUpdateClients.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlUpdateClients.BackColor = System.Drawing.Color.Silver;
            this.pnlUpdateClients.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlUpdateClients.Controls.Add(this.btnSelectClientId);
            this.pnlUpdateClients.Controls.Add(this.button1);
            this.pnlUpdateClients.Controls.Add(this.btnUpdateClient);
            this.pnlUpdateClients.Controls.Add(this.gbxClientDetails);
            this.pnlUpdateClients.Controls.Add(this.txtSearchCName);
            this.pnlUpdateClients.Controls.Add(this.lblsearchupdateCId);
            this.pnlUpdateClients.Controls.Add(this.lblUpdateClient);
            this.pnlUpdateClients.Controls.Add(this.dgvUpdateClient);
            this.pnlUpdateClients.Location = new System.Drawing.Point(19, 18);
            this.pnlUpdateClients.Margin = new System.Windows.Forms.Padding(2);
            this.pnlUpdateClients.Name = "pnlUpdateClients";
            this.pnlUpdateClients.Size = new System.Drawing.Size(1009, 601);
            this.pnlUpdateClients.TabIndex = 1;
            // 
            // btnSelectClientId
            // 
            this.btnSelectClientId.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectClientId.Location = new System.Drawing.Point(372, 46);
            this.btnSelectClientId.Margin = new System.Windows.Forms.Padding(2);
            this.btnSelectClientId.Name = "btnSelectClientId";
            this.btnSelectClientId.Size = new System.Drawing.Size(170, 35);
            this.btnSelectClientId.TabIndex = 12;
            this.btnSelectClientId.Text = "SELECT";
            this.btnSelectClientId.UseVisualStyleBackColor = true;
            this.btnSelectClientId.Click += new System.EventHandler(this.btnSelectClientId_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(411, 406);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 35);
            this.button1.TabIndex = 8;
            this.button1.Text = "CLEAR CLIENT DETAILS";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnUpdateClient
            // 
            this.btnUpdateClient.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateClient.Location = new System.Drawing.Point(411, 355);
            this.btnUpdateClient.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateClient.Name = "btnUpdateClient";
            this.btnUpdateClient.Size = new System.Drawing.Size(170, 35);
            this.btnUpdateClient.TabIndex = 7;
            this.btnUpdateClient.Text = "UPDATE CLIENT DETAILS";
            this.btnUpdateClient.UseVisualStyleBackColor = true;
            this.btnUpdateClient.Click += new System.EventHandler(this.btnUpdateClient_Click);
            // 
            // gbxClientDetails
            // 
            this.gbxClientDetails.Controls.Add(this.txtUpdateClientEmail);
            this.gbxClientDetails.Controls.Add(this.txtUpdateClientNumber);
            this.gbxClientDetails.Controls.Add(this.txtUpdateClientSName);
            this.gbxClientDetails.Controls.Add(this.txtUpdateClientName);
            this.gbxClientDetails.Controls.Add(this.lblUpdateClientEmail);
            this.gbxClientDetails.Controls.Add(this.lblUpdateClientNumber);
            this.gbxClientDetails.Controls.Add(this.lblUpdateClientSName);
            this.gbxClientDetails.Controls.Add(this.lblUpdateClientName);
            this.gbxClientDetails.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxClientDetails.Location = new System.Drawing.Point(19, 234);
            this.gbxClientDetails.Margin = new System.Windows.Forms.Padding(2);
            this.gbxClientDetails.Name = "gbxClientDetails";
            this.gbxClientDetails.Padding = new System.Windows.Forms.Padding(2);
            this.gbxClientDetails.Size = new System.Drawing.Size(370, 207);
            this.gbxClientDetails.TabIndex = 11;
            this.gbxClientDetails.TabStop = false;
            this.gbxClientDetails.Text = "PERSONAL DETAILS";
            // 
            // txtUpdateClientEmail
            // 
            this.txtUpdateClientEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpdateClientEmail.Location = new System.Drawing.Point(163, 150);
            this.txtUpdateClientEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtUpdateClientEmail.Name = "txtUpdateClientEmail";
            this.txtUpdateClientEmail.Size = new System.Drawing.Size(158, 26);
            this.txtUpdateClientEmail.TabIndex = 6;
            // 
            // txtUpdateClientNumber
            // 
            this.txtUpdateClientNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpdateClientNumber.Location = new System.Drawing.Point(163, 110);
            this.txtUpdateClientNumber.Margin = new System.Windows.Forms.Padding(2);
            this.txtUpdateClientNumber.Name = "txtUpdateClientNumber";
            this.txtUpdateClientNumber.Size = new System.Drawing.Size(158, 26);
            this.txtUpdateClientNumber.TabIndex = 5;
            // 
            // txtUpdateClientSName
            // 
            this.txtUpdateClientSName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpdateClientSName.Location = new System.Drawing.Point(163, 69);
            this.txtUpdateClientSName.Margin = new System.Windows.Forms.Padding(2);
            this.txtUpdateClientSName.Name = "txtUpdateClientSName";
            this.txtUpdateClientSName.Size = new System.Drawing.Size(158, 26);
            this.txtUpdateClientSName.TabIndex = 4;
            // 
            // txtUpdateClientName
            // 
            this.txtUpdateClientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpdateClientName.Location = new System.Drawing.Point(163, 29);
            this.txtUpdateClientName.Margin = new System.Windows.Forms.Padding(2);
            this.txtUpdateClientName.Name = "txtUpdateClientName";
            this.txtUpdateClientName.Size = new System.Drawing.Size(158, 26);
            this.txtUpdateClientName.TabIndex = 3;
            // 
            // lblUpdateClientEmail
            // 
            this.lblUpdateClientEmail.AutoSize = true;
            this.lblUpdateClientEmail.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateClientEmail.Location = new System.Drawing.Point(23, 153);
            this.lblUpdateClientEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUpdateClientEmail.Name = "lblUpdateClientEmail";
            this.lblUpdateClientEmail.Size = new System.Drawing.Size(129, 20);
            this.lblUpdateClientEmail.TabIndex = 10;
            this.lblUpdateClientEmail.Text = "E-MAIL ADDRESS:";
            // 
            // lblUpdateClientNumber
            // 
            this.lblUpdateClientNumber.AutoSize = true;
            this.lblUpdateClientNumber.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateClientNumber.Location = new System.Drawing.Point(23, 113);
            this.lblUpdateClientNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUpdateClientNumber.Name = "lblUpdateClientNumber";
            this.lblUpdateClientNumber.Size = new System.Drawing.Size(125, 20);
            this.lblUpdateClientNumber.TabIndex = 9;
            this.lblUpdateClientNumber.Text = "PHONE NUMBER:";
            // 
            // lblUpdateClientSName
            // 
            this.lblUpdateClientSName.AutoSize = true;
            this.lblUpdateClientSName.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateClientSName.Location = new System.Drawing.Point(23, 72);
            this.lblUpdateClientSName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUpdateClientSName.Name = "lblUpdateClientSName";
            this.lblUpdateClientSName.Size = new System.Drawing.Size(81, 20);
            this.lblUpdateClientSName.TabIndex = 8;
            this.lblUpdateClientSName.Text = "SURNAME:";
            // 
            // lblUpdateClientName
            // 
            this.lblUpdateClientName.AutoSize = true;
            this.lblUpdateClientName.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateClientName.Location = new System.Drawing.Point(23, 32);
            this.lblUpdateClientName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUpdateClientName.Name = "lblUpdateClientName";
            this.lblUpdateClientName.Size = new System.Drawing.Size(54, 20);
            this.lblUpdateClientName.TabIndex = 7;
            this.lblUpdateClientName.Text = "NAME:";
            // 
            // txtSearchCName
            // 
            this.txtSearchCName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchCName.Location = new System.Drawing.Point(157, 50);
            this.txtSearchCName.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearchCName.Name = "txtSearchCName";
            this.txtSearchCName.Size = new System.Drawing.Size(158, 26);
            this.txtSearchCName.TabIndex = 1;
            this.txtSearchCName.TextChanged += new System.EventHandler(this.txtSearchCName_TextChanged);
            // 
            // lblsearchupdateCId
            // 
            this.lblsearchupdateCId.AutoSize = true;
            this.lblsearchupdateCId.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsearchupdateCId.Location = new System.Drawing.Point(16, 54);
            this.lblsearchupdateCId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblsearchupdateCId.Name = "lblsearchupdateCId";
            this.lblsearchupdateCId.Size = new System.Drawing.Size(137, 20);
            this.lblsearchupdateCId.TabIndex = 6;
            this.lblsearchupdateCId.Text = "SEARCH CLIENT ID:";
            // 
            // lblUpdateClient
            // 
            this.lblUpdateClient.AutoSize = true;
            this.lblUpdateClient.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold);
            this.lblUpdateClient.Location = new System.Drawing.Point(311, 8);
            this.lblUpdateClient.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUpdateClient.Name = "lblUpdateClient";
            this.lblUpdateClient.Size = new System.Drawing.Size(295, 29);
            this.lblUpdateClient.TabIndex = 4;
            this.lblUpdateClient.Text = "UPDATE CLIENT DETAILS";
            // 
            // dgvUpdateClient
            // 
            this.dgvUpdateClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUpdateClient.Location = new System.Drawing.Point(19, 91);
            this.dgvUpdateClient.Margin = new System.Windows.Forms.Padding(2);
            this.dgvUpdateClient.Name = "dgvUpdateClient";
            this.dgvUpdateClient.RowHeadersWidth = 51;
            this.dgvUpdateClient.RowTemplate.Height = 24;
            this.dgvUpdateClient.Size = new System.Drawing.Size(971, 121);
            this.dgvUpdateClient.TabIndex = 2;
            // 
            // tbpDeleteClient
            // 
            this.tbpDeleteClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(15)))));
            this.tbpDeleteClient.Controls.Add(this.pnlDeleteClients);
            this.tbpDeleteClient.Location = new System.Drawing.Point(4, 22);
            this.tbpDeleteClient.Margin = new System.Windows.Forms.Padding(2);
            this.tbpDeleteClient.Name = "tbpDeleteClient";
            this.tbpDeleteClient.Padding = new System.Windows.Forms.Padding(2);
            this.tbpDeleteClient.Size = new System.Drawing.Size(1048, 643);
            this.tbpDeleteClient.TabIndex = 2;
            this.tbpDeleteClient.Text = "DELETE CLIENT";
            this.tbpDeleteClient.Enter += new System.EventHandler(this.tbpDeleteClient_Enter);
            // 
            // pnlDeleteClients
            // 
            this.pnlDeleteClients.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDeleteClients.BackColor = System.Drawing.Color.Silver;
            this.pnlDeleteClients.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDeleteClients.Controls.Add(this.btnDeleteClient);
            this.pnlDeleteClients.Controls.Add(this.txtSearchDeleteClientName);
            this.pnlDeleteClients.Controls.Add(this.lblSearchDeleteClientName);
            this.pnlDeleteClients.Controls.Add(this.lblDeleteClient);
            this.pnlDeleteClients.Controls.Add(this.dgvDeleteClient);
            this.pnlDeleteClients.Location = new System.Drawing.Point(19, 18);
            this.pnlDeleteClients.Margin = new System.Windows.Forms.Padding(2);
            this.pnlDeleteClients.Name = "pnlDeleteClients";
            this.pnlDeleteClients.Size = new System.Drawing.Size(1011, 601);
            this.pnlDeleteClients.TabIndex = 1;
            // 
            // btnDeleteClient
            // 
            this.btnDeleteClient.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteClient.Location = new System.Drawing.Point(821, 394);
            this.btnDeleteClient.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteClient.Name = "btnDeleteClient";
            this.btnDeleteClient.Size = new System.Drawing.Size(170, 61);
            this.btnDeleteClient.TabIndex = 3;
            this.btnDeleteClient.Text = "DELETE SELECTED CLIENT";
            this.btnDeleteClient.UseVisualStyleBackColor = true;
            this.btnDeleteClient.Click += new System.EventHandler(this.btnDeleteClient_Click);
            // 
            // txtSearchDeleteClientName
            // 
            this.txtSearchDeleteClientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchDeleteClientName.Location = new System.Drawing.Point(232, 72);
            this.txtSearchDeleteClientName.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearchDeleteClientName.Name = "txtSearchDeleteClientName";
            this.txtSearchDeleteClientName.Size = new System.Drawing.Size(158, 26);
            this.txtSearchDeleteClientName.TabIndex = 1;
            this.txtSearchDeleteClientName.TextChanged += new System.EventHandler(this.txtSearchDeleteClientName_TextChanged);
            // 
            // lblSearchDeleteClientName
            // 
            this.lblSearchDeleteClientName.AutoSize = true;
            this.lblSearchDeleteClientName.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchDeleteClientName.Location = new System.Drawing.Point(14, 76);
            this.lblSearchDeleteClientName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSearchDeleteClientName.Name = "lblSearchDeleteClientName";
            this.lblSearchDeleteClientName.Size = new System.Drawing.Size(214, 20);
            this.lblSearchDeleteClientName.TabIndex = 7;
            this.lblSearchDeleteClientName.Text = "SEARCH CLIENT ID TO DELETE:";
            // 
            // lblDeleteClient
            // 
            this.lblDeleteClient.AutoSize = true;
            this.lblDeleteClient.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold);
            this.lblDeleteClient.Location = new System.Drawing.Point(332, 8);
            this.lblDeleteClient.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDeleteClient.Name = "lblDeleteClient";
            this.lblDeleteClient.Size = new System.Drawing.Size(304, 29);
            this.lblDeleteClient.TabIndex = 4;
            this.lblDeleteClient.Text = "DELETE CURRENT CLIENT";
            // 
            // dgvDeleteClient
            // 
            this.dgvDeleteClient.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDeleteClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeleteClient.Location = new System.Drawing.Point(17, 108);
            this.dgvDeleteClient.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDeleteClient.Name = "dgvDeleteClient";
            this.dgvDeleteClient.RowHeadersWidth = 51;
            this.dgvDeleteClient.RowTemplate.Height = 24;
            this.dgvDeleteClient.Size = new System.Drawing.Size(974, 282);
            this.dgvDeleteClient.TabIndex = 2;
            // 
            // btnClientReturnHome
            // 
            this.btnClientReturnHome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClientReturnHome.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientReturnHome.Location = new System.Drawing.Point(13, 683);
            this.btnClientReturnHome.Margin = new System.Windows.Forms.Padding(2);
            this.btnClientReturnHome.Name = "btnClientReturnHome";
            this.btnClientReturnHome.Size = new System.Drawing.Size(170, 35);
            this.btnClientReturnHome.TabIndex = 16;
            this.btnClientReturnHome.Text = "RETURN TO MENU";
            this.btnClientReturnHome.UseVisualStyleBackColor = true;
            this.btnClientReturnHome.Click += new System.EventHandler(this.btnClientReturnHome_Click);
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
            this.pcb.Location = new System.Drawing.Point(1069, -1);
            this.pcb.Margin = new System.Windows.Forms.Padding(2);
            this.pcb.Name = "pcb";
            this.pcb.Size = new System.Drawing.Size(417, 731);
            this.pcb.TabIndex = 17;
            this.pcb.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // MaintainClients
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1486, 729);
            this.Controls.Add(this.pcb);
            this.Controls.Add(this.btnClientReturnHome);
            this.Controls.Add(this.tbcMaintainClients);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MaintainClients";
            this.Text = "MAINTAIN CLIENTS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tbcMaintainClients.ResumeLayout(false);
            this.tbpViewAllClients.ResumeLayout(false);
            this.pnlViewActiveClients.ResumeLayout(false);
            this.pnlViewActiveClients.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewClients)).EndInit();
            this.tbpUpdateClients.ResumeLayout(false);
            this.pnlUpdateClients.ResumeLayout(false);
            this.pnlUpdateClients.PerformLayout();
            this.gbxClientDetails.ResumeLayout(false);
            this.gbxClientDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUpdateClient)).EndInit();
            this.tbpDeleteClient.ResumeLayout(false);
            this.pnlDeleteClients.ResumeLayout(false);
            this.pnlDeleteClients.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeleteClient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcMaintainClients;
        private System.Windows.Forms.TabPage tbpViewAllClients;
        private System.Windows.Forms.TabPage tbpUpdateClients;
        private System.Windows.Forms.TabPage tbpDeleteClient;
        private System.Windows.Forms.Panel pnlViewActiveClients;
        private System.Windows.Forms.Panel pnlUpdateClients;
        private System.Windows.Forms.Panel pnlDeleteClients;
        private System.Windows.Forms.Label lblAllClients;
        private System.Windows.Forms.Label lblUpdateClient;
        private System.Windows.Forms.Label lblDeleteClient;
        private System.Windows.Forms.Label lblSearchC;
        private System.Windows.Forms.TextBox txtSearchClientName;
        private System.Windows.Forms.Button btnClientReturnHome;
        private System.Windows.Forms.TextBox txtSearchCName;
        private System.Windows.Forms.Label lblsearchupdateCId;
        private System.Windows.Forms.GroupBox gbxClientDetails;
        private System.Windows.Forms.Label lblUpdateClientEmail;
        private System.Windows.Forms.Label lblUpdateClientNumber;
        private System.Windows.Forms.Label lblUpdateClientSName;
        private System.Windows.Forms.Label lblUpdateClientName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnUpdateClient;
        private System.Windows.Forms.TextBox txtSearchDeleteClientName;
        private System.Windows.Forms.Label lblSearchDeleteClientName;
        private System.Windows.Forms.Button btnDeleteClient;
        public System.Windows.Forms.DataGridView dgvViewClients;
        public System.Windows.Forms.DataGridView dgvUpdateClient;
        public System.Windows.Forms.TextBox txtUpdateClientEmail;
        public System.Windows.Forms.TextBox txtUpdateClientNumber;
        public System.Windows.Forms.TextBox txtUpdateClientSName;
        public System.Windows.Forms.TextBox txtUpdateClientName;
        public System.Windows.Forms.DataGridView dgvDeleteClient;
        private System.Windows.Forms.Button btnSelectClientId;
        private System.Windows.Forms.PictureBox pcb;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
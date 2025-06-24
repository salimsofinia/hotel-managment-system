namespace SilverOaksHotel
{
    partial class MaintainRooms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MaintainRooms));
            this.tbcRooms = new System.Windows.Forms.TabControl();
            this.tbpViewRooms = new System.Windows.Forms.TabPage();
            this.pnlViewRooms = new System.Windows.Forms.Panel();
            this.btnGoToRoomSize = new System.Windows.Forms.Button();
            this.txtSearchRoomNr = new System.Windows.Forms.TextBox();
            this.lblRoomNrSearch = new System.Windows.Forms.Label();
            this.lblAllRooms = new System.Windows.Forms.Label();
            this.dgvViewAllRooms = new System.Windows.Forms.DataGridView();
            this.tbpUpdateRooms = new System.Windows.Forms.TabPage();
            this.pnlUpdateRooms = new System.Windows.Forms.Panel();
            this.rdoNo = new System.Windows.Forms.RadioButton();
            this.rdoYes = new System.Windows.Forms.RadioButton();
            this.btnSelectRoomNumber = new System.Windows.Forms.Button();
            this.btnUpdateRoom = new System.Windows.Forms.Button();
            this.txtUpdateRoomNumber = new System.Windows.Forms.TextBox();
            this.lblUpdateRoomAvailable = new System.Windows.Forms.Label();
            this.lblUpdateRoomNumber = new System.Windows.Forms.Label();
            this.txtSearchUpdateRoomNr = new System.Windows.Forms.TextBox();
            this.lblSearchUpdateRoomNr = new System.Windows.Forms.Label();
            this.lblUpdateRooms = new System.Windows.Forms.Label();
            this.dgvUpdateRoom = new System.Windows.Forms.DataGridView();
            this.btnRoomReturnHome = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pcb = new System.Windows.Forms.PictureBox();
            this.tbcRooms.SuspendLayout();
            this.tbpViewRooms.SuspendLayout();
            this.pnlViewRooms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewAllRooms)).BeginInit();
            this.tbpUpdateRooms.SuspendLayout();
            this.pnlUpdateRooms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUpdateRoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb)).BeginInit();
            this.SuspendLayout();
            // 
            // tbcRooms
            // 
            this.tbcRooms.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbcRooms.Controls.Add(this.tbpViewRooms);
            this.tbcRooms.Controls.Add(this.tbpUpdateRooms);
            this.tbcRooms.Location = new System.Drawing.Point(2, 1);
            this.tbcRooms.Name = "tbcRooms";
            this.tbcRooms.SelectedIndex = 0;
            this.tbcRooms.Size = new System.Drawing.Size(1059, 672);
            this.tbcRooms.TabIndex = 0;
            // 
            // tbpViewRooms
            // 
            this.tbpViewRooms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(15)))));
            this.tbpViewRooms.Controls.Add(this.pnlViewRooms);
            this.tbpViewRooms.Location = new System.Drawing.Point(4, 22);
            this.tbpViewRooms.Name = "tbpViewRooms";
            this.tbpViewRooms.Padding = new System.Windows.Forms.Padding(3);
            this.tbpViewRooms.Size = new System.Drawing.Size(1051, 646);
            this.tbpViewRooms.TabIndex = 0;
            this.tbpViewRooms.Text = "VIEW ROOMS";
            this.tbpViewRooms.Enter += new System.EventHandler(this.tbpViewRooms_Enter);
            // 
            // pnlViewRooms
            // 
            this.pnlViewRooms.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlViewRooms.BackColor = System.Drawing.Color.Silver;
            this.pnlViewRooms.Controls.Add(this.btnGoToRoomSize);
            this.pnlViewRooms.Controls.Add(this.txtSearchRoomNr);
            this.pnlViewRooms.Controls.Add(this.lblRoomNrSearch);
            this.pnlViewRooms.Controls.Add(this.lblAllRooms);
            this.pnlViewRooms.Controls.Add(this.dgvViewAllRooms);
            this.pnlViewRooms.Location = new System.Drawing.Point(25, 23);
            this.pnlViewRooms.Name = "pnlViewRooms";
            this.pnlViewRooms.Size = new System.Drawing.Size(1002, 602);
            this.pnlViewRooms.TabIndex = 1;
            // 
            // btnGoToRoomSize
            // 
            this.btnGoToRoomSize.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoToRoomSize.Location = new System.Drawing.Point(751, 339);
            this.btnGoToRoomSize.Margin = new System.Windows.Forms.Padding(2);
            this.btnGoToRoomSize.Name = "btnGoToRoomSize";
            this.btnGoToRoomSize.Size = new System.Drawing.Size(239, 35);
            this.btnGoToRoomSize.TabIndex = 10;
            this.btnGoToRoomSize.Text = "GO TO MAINTAIN ROOM SIZE";
            this.btnGoToRoomSize.UseVisualStyleBackColor = true;
            this.btnGoToRoomSize.Click += new System.EventHandler(this.btnGoToRoomSize_Click);
            // 
            // txtSearchRoomNr
            // 
            this.txtSearchRoomNr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchRoomNr.Location = new System.Drawing.Point(195, 64);
            this.txtSearchRoomNr.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearchRoomNr.Name = "txtSearchRoomNr";
            this.txtSearchRoomNr.Size = new System.Drawing.Size(158, 26);
            this.txtSearchRoomNr.TabIndex = 8;
            this.txtSearchRoomNr.TextChanged += new System.EventHandler(this.txtSearchRoomNr_TextChanged);
            // 
            // lblRoomNrSearch
            // 
            this.lblRoomNrSearch.AutoSize = true;
            this.lblRoomNrSearch.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomNrSearch.Location = new System.Drawing.Point(12, 68);
            this.lblRoomNrSearch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRoomNrSearch.Name = "lblRoomNrSearch";
            this.lblRoomNrSearch.Size = new System.Drawing.Size(179, 20);
            this.lblRoomNrSearch.TabIndex = 7;
            this.lblRoomNrSearch.Text = "SEARCH ROOM NUMBER:";
            // 
            // lblAllRooms
            // 
            this.lblAllRooms.AutoSize = true;
            this.lblAllRooms.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold);
            this.lblAllRooms.Location = new System.Drawing.Point(226, 10);
            this.lblAllRooms.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAllRooms.Name = "lblAllRooms";
            this.lblAllRooms.Size = new System.Drawing.Size(239, 29);
            this.lblAllRooms.TabIndex = 6;
            this.lblAllRooms.Text = "LIST OF ALL ROOMS";
            // 
            // dgvViewAllRooms
            // 
            this.dgvViewAllRooms.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvViewAllRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewAllRooms.Location = new System.Drawing.Point(16, 95);
            this.dgvViewAllRooms.Name = "dgvViewAllRooms";
            this.dgvViewAllRooms.Size = new System.Drawing.Size(970, 229);
            this.dgvViewAllRooms.TabIndex = 1;
            // 
            // tbpUpdateRooms
            // 
            this.tbpUpdateRooms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(15)))));
            this.tbpUpdateRooms.Controls.Add(this.pnlUpdateRooms);
            this.tbpUpdateRooms.Location = new System.Drawing.Point(4, 22);
            this.tbpUpdateRooms.Name = "tbpUpdateRooms";
            this.tbpUpdateRooms.Padding = new System.Windows.Forms.Padding(3);
            this.tbpUpdateRooms.Size = new System.Drawing.Size(1051, 646);
            this.tbpUpdateRooms.TabIndex = 1;
            this.tbpUpdateRooms.Text = "UPDATE ROOMS";
            this.tbpUpdateRooms.Enter += new System.EventHandler(this.tbpUpdateRooms_Enter);
            // 
            // pnlUpdateRooms
            // 
            this.pnlUpdateRooms.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlUpdateRooms.BackColor = System.Drawing.Color.Silver;
            this.pnlUpdateRooms.Controls.Add(this.rdoNo);
            this.pnlUpdateRooms.Controls.Add(this.rdoYes);
            this.pnlUpdateRooms.Controls.Add(this.btnSelectRoomNumber);
            this.pnlUpdateRooms.Controls.Add(this.btnUpdateRoom);
            this.pnlUpdateRooms.Controls.Add(this.txtUpdateRoomNumber);
            this.pnlUpdateRooms.Controls.Add(this.lblUpdateRoomAvailable);
            this.pnlUpdateRooms.Controls.Add(this.lblUpdateRoomNumber);
            this.pnlUpdateRooms.Controls.Add(this.txtSearchUpdateRoomNr);
            this.pnlUpdateRooms.Controls.Add(this.lblSearchUpdateRoomNr);
            this.pnlUpdateRooms.Controls.Add(this.lblUpdateRooms);
            this.pnlUpdateRooms.Controls.Add(this.dgvUpdateRoom);
            this.pnlUpdateRooms.Location = new System.Drawing.Point(25, 24);
            this.pnlUpdateRooms.Name = "pnlUpdateRooms";
            this.pnlUpdateRooms.Size = new System.Drawing.Size(1002, 599);
            this.pnlUpdateRooms.TabIndex = 0;
            // 
            // rdoNo
            // 
            this.rdoNo.AutoSize = true;
            this.rdoNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoNo.Location = new System.Drawing.Point(268, 320);
            this.rdoNo.Name = "rdoNo";
            this.rdoNo.Size = new System.Drawing.Size(46, 22);
            this.rdoNo.TabIndex = 18;
            this.rdoNo.TabStop = true;
            this.rdoNo.Text = "No";
            this.rdoNo.UseVisualStyleBackColor = true;
            // 
            // rdoYes
            // 
            this.rdoYes.AutoSize = true;
            this.rdoYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoYes.Location = new System.Drawing.Point(194, 320);
            this.rdoYes.Name = "rdoYes";
            this.rdoYes.Size = new System.Drawing.Size(51, 22);
            this.rdoYes.TabIndex = 17;
            this.rdoYes.TabStop = true;
            this.rdoYes.Text = "Yes";
            this.rdoYes.UseVisualStyleBackColor = true;
            // 
            // btnSelectRoomNumber
            // 
            this.btnSelectRoomNumber.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectRoomNumber.Location = new System.Drawing.Point(387, 59);
            this.btnSelectRoomNumber.Margin = new System.Windows.Forms.Padding(2);
            this.btnSelectRoomNumber.Name = "btnSelectRoomNumber";
            this.btnSelectRoomNumber.Size = new System.Drawing.Size(170, 35);
            this.btnSelectRoomNumber.TabIndex = 16;
            this.btnSelectRoomNumber.Text = "SELECT";
            this.btnSelectRoomNumber.UseVisualStyleBackColor = true;
            this.btnSelectRoomNumber.Click += new System.EventHandler(this.btnSelectRoomNumber_Click);
            // 
            // btnUpdateRoom
            // 
            this.btnUpdateRoom.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateRoom.Location = new System.Drawing.Point(387, 314);
            this.btnUpdateRoom.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateRoom.Name = "btnUpdateRoom";
            this.btnUpdateRoom.Size = new System.Drawing.Size(170, 35);
            this.btnUpdateRoom.TabIndex = 15;
            this.btnUpdateRoom.Text = "UPDATE ROOM";
            this.btnUpdateRoom.UseVisualStyleBackColor = true;
            this.btnUpdateRoom.Click += new System.EventHandler(this.btnUpdateRoom_Click);
            // 
            // txtUpdateRoomNumber
            // 
            this.txtUpdateRoomNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpdateRoomNumber.Location = new System.Drawing.Point(194, 277);
            this.txtUpdateRoomNumber.Margin = new System.Windows.Forms.Padding(2);
            this.txtUpdateRoomNumber.Name = "txtUpdateRoomNumber";
            this.txtUpdateRoomNumber.Size = new System.Drawing.Size(158, 26);
            this.txtUpdateRoomNumber.TabIndex = 12;
            // 
            // lblUpdateRoomAvailable
            // 
            this.lblUpdateRoomAvailable.AutoSize = true;
            this.lblUpdateRoomAvailable.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateRoomAvailable.Location = new System.Drawing.Point(11, 322);
            this.lblUpdateRoomAvailable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUpdateRoomAvailable.Name = "lblUpdateRoomAvailable";
            this.lblUpdateRoomAvailable.Size = new System.Drawing.Size(138, 20);
            this.lblUpdateRoomAvailable.TabIndex = 11;
            this.lblUpdateRoomAvailable.Text = "ROOM AVAILABLE?";
            // 
            // lblUpdateRoomNumber
            // 
            this.lblUpdateRoomNumber.AutoSize = true;
            this.lblUpdateRoomNumber.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateRoomNumber.Location = new System.Drawing.Point(11, 283);
            this.lblUpdateRoomNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUpdateRoomNumber.Name = "lblUpdateRoomNumber";
            this.lblUpdateRoomNumber.Size = new System.Drawing.Size(120, 20);
            this.lblUpdateRoomNumber.TabIndex = 10;
            this.lblUpdateRoomNumber.Text = "ROOM NUMBER:";
            // 
            // txtSearchUpdateRoomNr
            // 
            this.txtSearchUpdateRoomNr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchUpdateRoomNr.Location = new System.Drawing.Point(194, 63);
            this.txtSearchUpdateRoomNr.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearchUpdateRoomNr.Name = "txtSearchUpdateRoomNr";
            this.txtSearchUpdateRoomNr.Size = new System.Drawing.Size(158, 26);
            this.txtSearchUpdateRoomNr.TabIndex = 9;
            this.txtSearchUpdateRoomNr.TextChanged += new System.EventHandler(this.txtSearchUpdateRoomNr_TextChanged);
            // 
            // lblSearchUpdateRoomNr
            // 
            this.lblSearchUpdateRoomNr.AutoSize = true;
            this.lblSearchUpdateRoomNr.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchUpdateRoomNr.Location = new System.Drawing.Point(11, 67);
            this.lblSearchUpdateRoomNr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSearchUpdateRoomNr.Name = "lblSearchUpdateRoomNr";
            this.lblSearchUpdateRoomNr.Size = new System.Drawing.Size(179, 20);
            this.lblSearchUpdateRoomNr.TabIndex = 8;
            this.lblSearchUpdateRoomNr.Text = "SEARCH ROOM NUMBER:";
            // 
            // lblUpdateRooms
            // 
            this.lblUpdateRooms.AutoSize = true;
            this.lblUpdateRooms.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold);
            this.lblUpdateRooms.Location = new System.Drawing.Point(263, 10);
            this.lblUpdateRooms.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUpdateRooms.Name = "lblUpdateRooms";
            this.lblUpdateRooms.Size = new System.Drawing.Size(184, 29);
            this.lblUpdateRooms.TabIndex = 7;
            this.lblUpdateRooms.Text = "UPDATE ROOM";
            // 
            // dgvUpdateRoom
            // 
            this.dgvUpdateRoom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUpdateRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUpdateRoom.Location = new System.Drawing.Point(15, 99);
            this.dgvUpdateRoom.Name = "dgvUpdateRoom";
            this.dgvUpdateRoom.Size = new System.Drawing.Size(971, 166);
            this.dgvUpdateRoom.TabIndex = 0;
            // 
            // btnRoomReturnHome
            // 
            this.btnRoomReturnHome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRoomReturnHome.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoomReturnHome.Location = new System.Drawing.Point(6, 678);
            this.btnRoomReturnHome.Margin = new System.Windows.Forms.Padding(2);
            this.btnRoomReturnHome.Name = "btnRoomReturnHome";
            this.btnRoomReturnHome.Size = new System.Drawing.Size(170, 35);
            this.btnRoomReturnHome.TabIndex = 9;
            this.btnRoomReturnHome.Text = "RETURN TO MENU";
            this.btnRoomReturnHome.UseVisualStyleBackColor = true;
            this.btnRoomReturnHome.Click += new System.EventHandler(this.btnRoomReturnHome_Click);
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
            this.pcb.Location = new System.Drawing.Point(1066, -10);
            this.pcb.Margin = new System.Windows.Forms.Padding(2);
            this.pcb.Name = "pcb";
            this.pcb.Size = new System.Drawing.Size(417, 750);
            this.pcb.TabIndex = 10;
            this.pcb.TabStop = false;
            // 
            // MaintainRooms
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1482, 724);
            this.Controls.Add(this.pcb);
            this.Controls.Add(this.tbcRooms);
            this.Controls.Add(this.btnRoomReturnHome);
            this.Name = "MaintainRooms";
            this.Text = "MAINTAIN ROOMS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tbcRooms.ResumeLayout(false);
            this.tbpViewRooms.ResumeLayout(false);
            this.pnlViewRooms.ResumeLayout(false);
            this.pnlViewRooms.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewAllRooms)).EndInit();
            this.tbpUpdateRooms.ResumeLayout(false);
            this.pnlUpdateRooms.ResumeLayout(false);
            this.pnlUpdateRooms.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUpdateRoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcRooms;
        private System.Windows.Forms.TabPage tbpViewRooms;
        private System.Windows.Forms.TabPage tbpUpdateRooms;
        private System.Windows.Forms.Panel pnlUpdateRooms;
        private System.Windows.Forms.Panel pnlViewRooms;
        private System.Windows.Forms.Label lblAllRooms;
        private System.Windows.Forms.Label lblUpdateRooms;
        private System.Windows.Forms.Label lblRoomNrSearch;
        private System.Windows.Forms.TextBox txtSearchUpdateRoomNr;
        private System.Windows.Forms.Label lblSearchUpdateRoomNr;
        private System.Windows.Forms.TextBox txtUpdateRoomNumber;
        private System.Windows.Forms.Label lblUpdateRoomAvailable;
        private System.Windows.Forms.Label lblUpdateRoomNumber;
        private System.Windows.Forms.Button btnUpdateRoom;
        private System.Windows.Forms.Button btnRoomReturnHome;
        private System.Windows.Forms.Button btnGoToRoomSize;
        private System.Windows.Forms.Button btnSelectRoomNumber;
        public System.Windows.Forms.DataGridView dgvViewAllRooms;
        public System.Windows.Forms.DataGridView dgvUpdateRoom;
        private System.Windows.Forms.TextBox txtSearchRoomNr;
        private System.Windows.Forms.RadioButton rdoNo;
        private System.Windows.Forms.RadioButton rdoYes;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.PictureBox pcb;
    }
}
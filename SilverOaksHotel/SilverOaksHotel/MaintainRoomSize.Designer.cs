namespace SilverOaksHotel
{
    partial class MaintainRoomSize
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MaintainRoomSize));
            this.tbcRoomsSize = new System.Windows.Forms.TabControl();
            this.tbpViewRoomSize = new System.Windows.Forms.TabPage();
            this.pnlViewRoomSize = new System.Windows.Forms.Panel();
            this.txtRoomSizeIdSearch = new System.Windows.Forms.TextBox();
            this.lblSizeIdSearch = new System.Windows.Forms.Label();
            this.lblAllRoomSizes = new System.Windows.Forms.Label();
            this.dgvRoomSizeView = new System.Windows.Forms.DataGridView();
            this.tbpUpdateRoomSize = new System.Windows.Forms.TabPage();
            this.pnlUpdateRoomSize = new System.Windows.Forms.Panel();
            this.btnSelectSizeId = new System.Windows.Forms.Button();
            this.btnUpdateRoomSize = new System.Windows.Forms.Button();
            this.txtRoomSizePrice = new System.Windows.Forms.TextBox();
            this.lblRoomSizePriceUpdate = new System.Windows.Forms.Label();
            this.txtRoomSizeDescriptioin = new System.Windows.Forms.TextBox();
            this.lblUpdateRoomDescription = new System.Windows.Forms.Label();
            this.txtSearchUpdateRoomId = new System.Windows.Forms.TextBox();
            this.lblSearchUpdateRoomSizeId = new System.Windows.Forms.Label();
            this.lblUpdateRoomSizes = new System.Windows.Forms.Label();
            this.dgvUpdateRoomSize = new System.Windows.Forms.DataGridView();
            this.btnRoomSizeReturnRoom = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pcb = new System.Windows.Forms.PictureBox();
            this.tbcRoomsSize.SuspendLayout();
            this.tbpViewRoomSize.SuspendLayout();
            this.pnlViewRoomSize.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomSizeView)).BeginInit();
            this.tbpUpdateRoomSize.SuspendLayout();
            this.pnlUpdateRoomSize.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUpdateRoomSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb)).BeginInit();
            this.SuspendLayout();
            // 
            // tbcRoomsSize
            // 
            this.tbcRoomsSize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbcRoomsSize.Controls.Add(this.tbpViewRoomSize);
            this.tbcRoomsSize.Controls.Add(this.tbpUpdateRoomSize);
            this.tbcRoomsSize.Location = new System.Drawing.Point(3, 3);
            this.tbcRoomsSize.Name = "tbcRoomsSize";
            this.tbcRoomsSize.SelectedIndex = 0;
            this.tbcRoomsSize.Size = new System.Drawing.Size(1063, 579);
            this.tbcRoomsSize.TabIndex = 1;
            // 
            // tbpViewRoomSize
            // 
            this.tbpViewRoomSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(15)))));
            this.tbpViewRoomSize.Controls.Add(this.pnlViewRoomSize);
            this.tbpViewRoomSize.Location = new System.Drawing.Point(4, 22);
            this.tbpViewRoomSize.Name = "tbpViewRoomSize";
            this.tbpViewRoomSize.Padding = new System.Windows.Forms.Padding(3);
            this.tbpViewRoomSize.Size = new System.Drawing.Size(1055, 553);
            this.tbpViewRoomSize.TabIndex = 0;
            this.tbpViewRoomSize.Text = "VIEW ROOM SIZE";
            this.tbpViewRoomSize.Enter += new System.EventHandler(this.tbpViewRoomSize_Enter);
            // 
            // pnlViewRoomSize
            // 
            this.pnlViewRoomSize.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlViewRoomSize.BackColor = System.Drawing.Color.Silver;
            this.pnlViewRoomSize.Controls.Add(this.txtRoomSizeIdSearch);
            this.pnlViewRoomSize.Controls.Add(this.lblSizeIdSearch);
            this.pnlViewRoomSize.Controls.Add(this.lblAllRoomSizes);
            this.pnlViewRoomSize.Controls.Add(this.dgvRoomSizeView);
            this.pnlViewRoomSize.Location = new System.Drawing.Point(24, 24);
            this.pnlViewRoomSize.Name = "pnlViewRoomSize";
            this.pnlViewRoomSize.Size = new System.Drawing.Size(1006, 506);
            this.pnlViewRoomSize.TabIndex = 2;
            // 
            // txtRoomSizeIdSearch
            // 
            this.txtRoomSizeIdSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoomSizeIdSearch.Location = new System.Drawing.Point(194, 75);
            this.txtRoomSizeIdSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtRoomSizeIdSearch.Name = "txtRoomSizeIdSearch";
            this.txtRoomSizeIdSearch.Size = new System.Drawing.Size(158, 26);
            this.txtRoomSizeIdSearch.TabIndex = 9;
            this.txtRoomSizeIdSearch.TextChanged += new System.EventHandler(this.txtRoomSizeIdSearch_TextChanged);
            // 
            // lblSizeIdSearch
            // 
            this.lblSizeIdSearch.AutoSize = true;
            this.lblSizeIdSearch.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSizeIdSearch.Location = new System.Drawing.Point(11, 79);
            this.lblSizeIdSearch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSizeIdSearch.Name = "lblSizeIdSearch";
            this.lblSizeIdSearch.Size = new System.Drawing.Size(167, 20);
            this.lblSizeIdSearch.TabIndex = 8;
            this.lblSizeIdSearch.Text = "SEARCH ROOM SIZE ID:";
            // 
            // lblAllRoomSizes
            // 
            this.lblAllRoomSizes.AutoSize = true;
            this.lblAllRoomSizes.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold);
            this.lblAllRoomSizes.Location = new System.Drawing.Point(201, 10);
            this.lblAllRoomSizes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAllRoomSizes.Name = "lblAllRoomSizes";
            this.lblAllRoomSizes.Size = new System.Drawing.Size(294, 29);
            this.lblAllRoomSizes.TabIndex = 7;
            this.lblAllRoomSizes.Text = "LIST OF ALL ROOM SIZES";
            // 
            // dgvRoomSizeView
            // 
            this.dgvRoomSizeView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRoomSizeView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoomSizeView.Location = new System.Drawing.Point(15, 106);
            this.dgvRoomSizeView.Name = "dgvRoomSizeView";
            this.dgvRoomSizeView.Size = new System.Drawing.Size(969, 214);
            this.dgvRoomSizeView.TabIndex = 1;
            // 
            // tbpUpdateRoomSize
            // 
            this.tbpUpdateRoomSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(15)))));
            this.tbpUpdateRoomSize.Controls.Add(this.pnlUpdateRoomSize);
            this.tbpUpdateRoomSize.Location = new System.Drawing.Point(4, 22);
            this.tbpUpdateRoomSize.Name = "tbpUpdateRoomSize";
            this.tbpUpdateRoomSize.Padding = new System.Windows.Forms.Padding(3);
            this.tbpUpdateRoomSize.Size = new System.Drawing.Size(1055, 553);
            this.tbpUpdateRoomSize.TabIndex = 1;
            this.tbpUpdateRoomSize.Text = "UPDATE ROOM SIZE";
            this.tbpUpdateRoomSize.Enter += new System.EventHandler(this.tbpUpdateRoomSize_Enter);
            // 
            // pnlUpdateRoomSize
            // 
            this.pnlUpdateRoomSize.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlUpdateRoomSize.BackColor = System.Drawing.Color.Silver;
            this.pnlUpdateRoomSize.Controls.Add(this.btnSelectSizeId);
            this.pnlUpdateRoomSize.Controls.Add(this.btnUpdateRoomSize);
            this.pnlUpdateRoomSize.Controls.Add(this.txtRoomSizePrice);
            this.pnlUpdateRoomSize.Controls.Add(this.lblRoomSizePriceUpdate);
            this.pnlUpdateRoomSize.Controls.Add(this.txtRoomSizeDescriptioin);
            this.pnlUpdateRoomSize.Controls.Add(this.lblUpdateRoomDescription);
            this.pnlUpdateRoomSize.Controls.Add(this.txtSearchUpdateRoomId);
            this.pnlUpdateRoomSize.Controls.Add(this.lblSearchUpdateRoomSizeId);
            this.pnlUpdateRoomSize.Controls.Add(this.lblUpdateRoomSizes);
            this.pnlUpdateRoomSize.Controls.Add(this.dgvUpdateRoomSize);
            this.pnlUpdateRoomSize.Location = new System.Drawing.Point(24, 24);
            this.pnlUpdateRoomSize.Name = "pnlUpdateRoomSize";
            this.pnlUpdateRoomSize.Size = new System.Drawing.Size(1006, 506);
            this.pnlUpdateRoomSize.TabIndex = 2;
            // 
            // btnSelectSizeId
            // 
            this.btnSelectSizeId.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectSizeId.Location = new System.Drawing.Point(381, 71);
            this.btnSelectSizeId.Margin = new System.Windows.Forms.Padding(2);
            this.btnSelectSizeId.Name = "btnSelectSizeId";
            this.btnSelectSizeId.Size = new System.Drawing.Size(170, 35);
            this.btnSelectSizeId.TabIndex = 17;
            this.btnSelectSizeId.Text = "SELECT";
            this.btnSelectSizeId.UseVisualStyleBackColor = true;
            this.btnSelectSizeId.Click += new System.EventHandler(this.btnSelectSizeId_Click);
            // 
            // btnUpdateRoomSize
            // 
            this.btnUpdateRoomSize.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateRoomSize.Location = new System.Drawing.Point(334, 447);
            this.btnUpdateRoomSize.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateRoomSize.Name = "btnUpdateRoomSize";
            this.btnUpdateRoomSize.Size = new System.Drawing.Size(170, 35);
            this.btnUpdateRoomSize.TabIndex = 16;
            this.btnUpdateRoomSize.Text = "UPDATE ROOM SIZE";
            this.btnUpdateRoomSize.UseVisualStyleBackColor = true;
            this.btnUpdateRoomSize.Click += new System.EventHandler(this.btnUpdateRoomSize_Click);
            // 
            // txtRoomSizePrice
            // 
            this.txtRoomSizePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoomSizePrice.Location = new System.Drawing.Point(199, 398);
            this.txtRoomSizePrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtRoomSizePrice.Name = "txtRoomSizePrice";
            this.txtRoomSizePrice.Size = new System.Drawing.Size(305, 26);
            this.txtRoomSizePrice.TabIndex = 14;
            // 
            // lblRoomSizePriceUpdate
            // 
            this.lblRoomSizePriceUpdate.AutoSize = true;
            this.lblRoomSizePriceUpdate.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomSizePriceUpdate.Location = new System.Drawing.Point(11, 402);
            this.lblRoomSizePriceUpdate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRoomSizePriceUpdate.Name = "lblRoomSizePriceUpdate";
            this.lblRoomSizePriceUpdate.Size = new System.Drawing.Size(131, 20);
            this.lblRoomSizePriceUpdate.TabIndex = 13;
            this.lblRoomSizePriceUpdate.Text = "ROOM SIZE PRICE:";
            // 
            // txtRoomSizeDescriptioin
            // 
            this.txtRoomSizeDescriptioin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoomSizeDescriptioin.Location = new System.Drawing.Point(199, 296);
            this.txtRoomSizeDescriptioin.Margin = new System.Windows.Forms.Padding(2);
            this.txtRoomSizeDescriptioin.Multiline = true;
            this.txtRoomSizeDescriptioin.Name = "txtRoomSizeDescriptioin";
            this.txtRoomSizeDescriptioin.Size = new System.Drawing.Size(305, 81);
            this.txtRoomSizeDescriptioin.TabIndex = 12;
            // 
            // lblUpdateRoomDescription
            // 
            this.lblUpdateRoomDescription.AutoSize = true;
            this.lblUpdateRoomDescription.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateRoomDescription.Location = new System.Drawing.Point(11, 300);
            this.lblUpdateRoomDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUpdateRoomDescription.Name = "lblUpdateRoomDescription";
            this.lblUpdateRoomDescription.Size = new System.Drawing.Size(184, 20);
            this.lblUpdateRoomDescription.TabIndex = 11;
            this.lblUpdateRoomDescription.Text = "ROOM SIZE DESCRIPTION:";
            // 
            // txtSearchUpdateRoomId
            // 
            this.txtSearchUpdateRoomId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchUpdateRoomId.Location = new System.Drawing.Point(194, 75);
            this.txtSearchUpdateRoomId.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearchUpdateRoomId.Name = "txtSearchUpdateRoomId";
            this.txtSearchUpdateRoomId.Size = new System.Drawing.Size(158, 26);
            this.txtSearchUpdateRoomId.TabIndex = 10;
            this.txtSearchUpdateRoomId.TextChanged += new System.EventHandler(this.txtSearchUpdateRoomId_TextChanged);
            // 
            // lblSearchUpdateRoomSizeId
            // 
            this.lblSearchUpdateRoomSizeId.AutoSize = true;
            this.lblSearchUpdateRoomSizeId.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchUpdateRoomSizeId.Location = new System.Drawing.Point(11, 79);
            this.lblSearchUpdateRoomSizeId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSearchUpdateRoomSizeId.Name = "lblSearchUpdateRoomSizeId";
            this.lblSearchUpdateRoomSizeId.Size = new System.Drawing.Size(167, 20);
            this.lblSearchUpdateRoomSizeId.TabIndex = 9;
            this.lblSearchUpdateRoomSizeId.Text = "SEARCH ROOM SIZE ID:";
            // 
            // lblUpdateRoomSizes
            // 
            this.lblUpdateRoomSizes.AutoSize = true;
            this.lblUpdateRoomSizes.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold);
            this.lblUpdateRoomSizes.Location = new System.Drawing.Point(221, 9);
            this.lblUpdateRoomSizes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUpdateRoomSizes.Name = "lblUpdateRoomSizes";
            this.lblUpdateRoomSizes.Size = new System.Drawing.Size(252, 29);
            this.lblUpdateRoomSizes.TabIndex = 7;
            this.lblUpdateRoomSizes.Text = "UPDATE ROOM SIZES";
            // 
            // dgvUpdateRoomSize
            // 
            this.dgvUpdateRoomSize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUpdateRoomSize.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUpdateRoomSize.Location = new System.Drawing.Point(15, 120);
            this.dgvUpdateRoomSize.Name = "dgvUpdateRoomSize";
            this.dgvUpdateRoomSize.Size = new System.Drawing.Size(974, 166);
            this.dgvUpdateRoomSize.TabIndex = 1;
            // 
            // btnRoomSizeReturnRoom
            // 
            this.btnRoomSizeReturnRoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRoomSizeReturnRoom.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoomSizeReturnRoom.Location = new System.Drawing.Point(7, 587);
            this.btnRoomSizeReturnRoom.Margin = new System.Windows.Forms.Padding(2);
            this.btnRoomSizeReturnRoom.Name = "btnRoomSizeReturnRoom";
            this.btnRoomSizeReturnRoom.Size = new System.Drawing.Size(230, 35);
            this.btnRoomSizeReturnRoom.TabIndex = 10;
            this.btnRoomSizeReturnRoom.Text = "RETURN TO MAINTAIN ROOM";
            this.btnRoomSizeReturnRoom.UseVisualStyleBackColor = true;
            this.btnRoomSizeReturnRoom.Click += new System.EventHandler(this.btnRoomSizeReturnRoom_Click);
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
            this.pcb.Location = new System.Drawing.Point(1071, -7);
            this.pcb.Margin = new System.Windows.Forms.Padding(2);
            this.pcb.Name = "pcb";
            this.pcb.Size = new System.Drawing.Size(400, 643);
            this.pcb.TabIndex = 11;
            this.pcb.TabStop = false;
            // 
            // MaintainRoomSize
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1470, 633);
            this.Controls.Add(this.pcb);
            this.Controls.Add(this.btnRoomSizeReturnRoom);
            this.Controls.Add(this.tbcRoomsSize);
            this.Name = "MaintainRoomSize";
            this.Text = "MAINTAIN ROOM SIZE";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tbcRoomsSize.ResumeLayout(false);
            this.tbpViewRoomSize.ResumeLayout(false);
            this.pnlViewRoomSize.ResumeLayout(false);
            this.pnlViewRoomSize.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomSizeView)).EndInit();
            this.tbpUpdateRoomSize.ResumeLayout(false);
            this.pnlUpdateRoomSize.ResumeLayout(false);
            this.pnlUpdateRoomSize.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUpdateRoomSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcRoomsSize;
        private System.Windows.Forms.TabPage tbpViewRoomSize;
        private System.Windows.Forms.TabPage tbpUpdateRoomSize;
        private System.Windows.Forms.Panel pnlViewRoomSize;
        private System.Windows.Forms.Panel pnlUpdateRoomSize;
        private System.Windows.Forms.DataGridView dgvRoomSizeView;
        private System.Windows.Forms.DataGridView dgvUpdateRoomSize;
        private System.Windows.Forms.Label lblAllRoomSizes;
        private System.Windows.Forms.Label lblUpdateRoomSizes;
        private System.Windows.Forms.Label lblSizeIdSearch;
        private System.Windows.Forms.TextBox txtRoomSizeIdSearch;
        private System.Windows.Forms.Label lblSearchUpdateRoomSizeId;
        private System.Windows.Forms.TextBox txtSearchUpdateRoomId;
        private System.Windows.Forms.TextBox txtRoomSizePrice;
        private System.Windows.Forms.Label lblRoomSizePriceUpdate;
        private System.Windows.Forms.TextBox txtRoomSizeDescriptioin;
        private System.Windows.Forms.Label lblUpdateRoomDescription;
        private System.Windows.Forms.Button btnUpdateRoomSize;
        private System.Windows.Forms.Button btnRoomSizeReturnRoom;
        private System.Windows.Forms.Button btnSelectSizeId;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.PictureBox pcb;
    }
}
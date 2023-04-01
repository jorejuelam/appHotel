﻿namespace appHotel
{
    partial class frmIndex
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIndex));
            pnMMenu = new Panel();
            pnDivisorMHosting = new Panel();
            pnDivisorTOHosting = new Panel();
            btnCheckOut = new Button();
            btnManageHosting = new Button();
            pnDivisorMHotel = new Panel();
            btnManageHotel = new Button();
            pnDivisorEHosting = new Panel();
            pnDivisorMRoom = new Panel();
            pnDivisorMGuest = new Panel();
            pbIcon = new PictureBox();
            btnCheckIn = new Button();
            btnManageRoom = new Button();
            btnManageGuest = new Button();
            tcManage = new TabControl();
            tpSeeRooms = new TabPage();
            btnSRShow = new Button();
            dtvSRooms = new DataGridView();
            tpInsertRoom = new TabPage();
            pnIR = new Panel();
            cbIRStatus = new ComboBox();
            txtIRCapacity = new TextBox();
            lbIRCapacity = new Label();
            lbIRCode = new Label();
            lbEPInformation = new Label();
            btnIREnter = new Button();
            txtIRDescription = new TextBox();
            txtIRCode = new TextBox();
            txtIRPrice = new TextBox();
            lbIRDescription = new Label();
            lbRStatus = new Label();
            lbIRPrice = new Label();
            tpAlterRoom = new TabPage();
            pnARI = new Panel();
            pnCInfoARI = new Panel();
            cbARIStatus = new ComboBox();
            lbAPIInformation = new Label();
            btnARIAlter = new Button();
            txtARIDescription = new TextBox();
            txtARIPrice = new TextBox();
            txtARICapacity = new TextBox();
            lbARIDescription = new Label();
            lbARIStatus = new Label();
            lbARIPrice = new Label();
            lbARICapacity = new Label();
            btnARISearch = new Button();
            txtARICode = new TextBox();
            lbARICode = new Label();
            tpDeleteRoom = new TabPage();
            pnDR = new Panel();
            btnDRDelete = new Button();
            cbCRCode = new ComboBox();
            tpSeeHotel = new TabPage();
            tpInsertHotel = new TabPage();
            tpAlterHotel = new TabPage();
            tpDeleteHotel = new TabPage();
            tpAlterGuest = new TabPage();
            tpDeleteGuest = new TabPage();
            tpInsertGuest = new TabPage();
            tpSeeGuest = new TabPage();
            tpCheckIn = new TabPage();
            tpCheckOut = new TabPage();
            tpAlterHosting = new TabPage();
            tpSeeHosting = new TabPage();
            pnMMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbIcon).BeginInit();
            tcManage.SuspendLayout();
            tpSeeRooms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtvSRooms).BeginInit();
            tpInsertRoom.SuspendLayout();
            pnIR.SuspendLayout();
            tpAlterRoom.SuspendLayout();
            pnARI.SuspendLayout();
            pnCInfoARI.SuspendLayout();
            tpDeleteRoom.SuspendLayout();
            pnDR.SuspendLayout();
            SuspendLayout();
            // 
            // pnMMenu
            // 
            pnMMenu.BackColor = Color.Silver;
            pnMMenu.Controls.Add(pnDivisorMHosting);
            pnMMenu.Controls.Add(pnDivisorTOHosting);
            pnMMenu.Controls.Add(btnCheckOut);
            pnMMenu.Controls.Add(btnManageHosting);
            pnMMenu.Controls.Add(pnDivisorMHotel);
            pnMMenu.Controls.Add(btnManageHotel);
            pnMMenu.Controls.Add(pnDivisorEHosting);
            pnMMenu.Controls.Add(pnDivisorMRoom);
            pnMMenu.Controls.Add(pnDivisorMGuest);
            pnMMenu.Controls.Add(pbIcon);
            pnMMenu.Controls.Add(btnCheckIn);
            pnMMenu.Controls.Add(btnManageRoom);
            pnMMenu.Controls.Add(btnManageGuest);
            pnMMenu.Dock = DockStyle.Left;
            pnMMenu.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            pnMMenu.ForeColor = Color.Black;
            pnMMenu.Location = new Point(0, 0);
            pnMMenu.Name = "pnMMenu";
            pnMMenu.Size = new Size(178, 490);
            pnMMenu.TabIndex = 1;
            // 
            // pnDivisorMHosting
            // 
            pnDivisorMHosting.BackColor = Color.Black;
            pnDivisorMHosting.Location = new Point(0, 438);
            pnDivisorMHosting.Name = "pnDivisorMHosting";
            pnDivisorMHosting.Size = new Size(178, 2);
            pnDivisorMHosting.TabIndex = 12;
            // 
            // pnDivisorTOHosting
            // 
            pnDivisorTOHosting.BackColor = Color.Black;
            pnDivisorTOHosting.Location = new Point(0, 289);
            pnDivisorTOHosting.Name = "pnDivisorTOHosting";
            pnDivisorTOHosting.Size = new Size(178, 2);
            pnDivisorTOHosting.TabIndex = 7;
            // 
            // btnCheckOut
            // 
            btnCheckOut.FlatAppearance.BorderSize = 0;
            btnCheckOut.FlatStyle = FlatStyle.Flat;
            btnCheckOut.Location = new Point(0, 248);
            btnCheckOut.Name = "btnCheckOut";
            btnCheckOut.Size = new Size(178, 43);
            btnCheckOut.TabIndex = 4;
            btnCheckOut.Text = "Check Out";
            btnCheckOut.UseVisualStyleBackColor = true;
            btnCheckOut.Click += btnCheckOut_Click;
            // 
            // btnManageHosting
            // 
            btnManageHosting.FlatAppearance.BorderSize = 0;
            btnManageHosting.FlatStyle = FlatStyle.Flat;
            btnManageHosting.Location = new Point(0, 397);
            btnManageHosting.Name = "btnManageHosting";
            btnManageHosting.Size = new Size(178, 43);
            btnManageHosting.TabIndex = 11;
            btnManageHosting.Text = "Manage Hosting";
            btnManageHosting.UseVisualStyleBackColor = true;
            btnManageHosting.Click += btnManageHosting_Click;
            // 
            // pnDivisorMHotel
            // 
            pnDivisorMHotel.BackColor = Color.Black;
            pnDivisorMHotel.Location = new Point(0, 191);
            pnDivisorMHotel.Name = "pnDivisorMHotel";
            pnDivisorMHotel.Size = new Size(178, 2);
            pnDivisorMHotel.TabIndex = 8;
            // 
            // btnManageHotel
            // 
            btnManageHotel.FlatAppearance.BorderSize = 0;
            btnManageHotel.FlatStyle = FlatStyle.Flat;
            btnManageHotel.Location = new Point(0, 150);
            btnManageHotel.Name = "btnManageHotel";
            btnManageHotel.Size = new Size(178, 43);
            btnManageHotel.TabIndex = 10;
            btnManageHotel.Text = "Manage Hotel";
            btnManageHotel.UseVisualStyleBackColor = true;
            btnManageHotel.Click += btnManageHotel_Click;
            // 
            // pnDivisorEHosting
            // 
            pnDivisorEHosting.BackColor = Color.Black;
            pnDivisorEHosting.Location = new Point(0, 240);
            pnDivisorEHosting.Name = "pnDivisorEHosting";
            pnDivisorEHosting.Size = new Size(178, 2);
            pnDivisorEHosting.TabIndex = 8;
            // 
            // pnDivisorMRoom
            // 
            pnDivisorMRoom.BackColor = Color.Black;
            pnDivisorMRoom.Location = new Point(0, 338);
            pnDivisorMRoom.Name = "pnDivisorMRoom";
            pnDivisorMRoom.Size = new Size(178, 2);
            pnDivisorMRoom.TabIndex = 7;
            // 
            // pnDivisorMGuest
            // 
            pnDivisorMGuest.BackColor = Color.Black;
            pnDivisorMGuest.Location = new Point(0, 387);
            pnDivisorMGuest.Name = "pnDivisorMGuest";
            pnDivisorMGuest.Size = new Size(178, 2);
            pnDivisorMGuest.TabIndex = 6;
            // 
            // pbIcon
            // 
            pbIcon.BackgroundImage = Properties.Resources._5900195;
            pbIcon.BackgroundImageLayout = ImageLayout.Zoom;
            pbIcon.Location = new Point(3, 12);
            pbIcon.Name = "pbIcon";
            pbIcon.Size = new Size(172, 121);
            pbIcon.TabIndex = 5;
            pbIcon.TabStop = false;
            // 
            // btnCheckIn
            // 
            btnCheckIn.FlatAppearance.BorderSize = 0;
            btnCheckIn.FlatStyle = FlatStyle.Flat;
            btnCheckIn.Location = new Point(0, 199);
            btnCheckIn.Name = "btnCheckIn";
            btnCheckIn.Size = new Size(178, 43);
            btnCheckIn.TabIndex = 3;
            btnCheckIn.Text = "Check In";
            btnCheckIn.UseVisualStyleBackColor = true;
            btnCheckIn.Click += btnCheckIn_Click;
            // 
            // btnManageRoom
            // 
            btnManageRoom.FlatAppearance.BorderSize = 0;
            btnManageRoom.FlatStyle = FlatStyle.Flat;
            btnManageRoom.Location = new Point(0, 297);
            btnManageRoom.Name = "btnManageRoom";
            btnManageRoom.Size = new Size(178, 43);
            btnManageRoom.TabIndex = 2;
            btnManageRoom.Text = "Manage Room";
            btnManageRoom.UseVisualStyleBackColor = true;
            btnManageRoom.Click += btnManageRoom_Click;
            // 
            // btnManageGuest
            // 
            btnManageGuest.FlatAppearance.BorderSize = 0;
            btnManageGuest.FlatStyle = FlatStyle.Flat;
            btnManageGuest.Location = new Point(0, 346);
            btnManageGuest.Name = "btnManageGuest";
            btnManageGuest.Size = new Size(178, 43);
            btnManageGuest.TabIndex = 1;
            btnManageGuest.Text = "Manage Guest";
            btnManageGuest.UseVisualStyleBackColor = true;
            btnManageGuest.Click += btnManageGuest_Click;
            // 
            // tcManage
            // 
            tcManage.Controls.Add(tpSeeRooms);
            tcManage.Controls.Add(tpInsertRoom);
            tcManage.Controls.Add(tpAlterRoom);
            tcManage.Controls.Add(tpDeleteRoom);
            tcManage.Controls.Add(tpSeeHotel);
            tcManage.Controls.Add(tpInsertHotel);
            tcManage.Controls.Add(tpAlterHotel);
            tcManage.Controls.Add(tpDeleteHotel);
            tcManage.Controls.Add(tpAlterGuest);
            tcManage.Controls.Add(tpDeleteGuest);
            tcManage.Controls.Add(tpInsertGuest);
            tcManage.Controls.Add(tpSeeGuest);
            tcManage.Controls.Add(tpCheckIn);
            tcManage.Controls.Add(tpCheckOut);
            tcManage.Controls.Add(tpAlterHosting);
            tcManage.Controls.Add(tpSeeHosting);
            tcManage.Dock = DockStyle.Right;
            tcManage.Location = new Point(178, 0);
            tcManage.Margin = new Padding(0);
            tcManage.Multiline = true;
            tcManage.Name = "tcManage";
            tcManage.SelectedIndex = 0;
            tcManage.Size = new Size(630, 490);
            tcManage.SizeMode = TabSizeMode.FillToRight;
            tcManage.TabIndex = 2;
            // 
            // tpSeeRooms
            // 
            tpSeeRooms.Controls.Add(btnSRShow);
            tpSeeRooms.Controls.Add(dtvSRooms);
            tpSeeRooms.Location = new Point(4, 64);
            tpSeeRooms.Name = "tpSeeRooms";
            tpSeeRooms.Padding = new Padding(3);
            tpSeeRooms.Size = new Size(622, 422);
            tpSeeRooms.TabIndex = 1;
            tpSeeRooms.Text = "See Rooms";
            tpSeeRooms.UseVisualStyleBackColor = true;
            // 
            // btnSRShow
            // 
            btnSRShow.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSRShow.Location = new Point(245, 31);
            btnSRShow.Name = "btnSRShow";
            btnSRShow.Size = new Size(125, 39);
            btnSRShow.TabIndex = 1;
            btnSRShow.Text = "Show Rooms";
            btnSRShow.UseVisualStyleBackColor = true;
            // 
            // dtvSRooms
            // 
            dtvSRooms.AllowUserToAddRows = false;
            dtvSRooms.AllowUserToDeleteRows = false;
            dtvSRooms.AllowUserToResizeColumns = false;
            dtvSRooms.AllowUserToResizeRows = false;
            dtvSRooms.BackgroundColor = Color.Gainsboro;
            dtvSRooms.BorderStyle = BorderStyle.None;
            dtvSRooms.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtvSRooms.GridColor = Color.Silver;
            dtvSRooms.Location = new Point(27, 102);
            dtvSRooms.Name = "dtvSRooms";
            dtvSRooms.ReadOnly = true;
            dtvSRooms.RowHeadersVisible = false;
            dtvSRooms.RowTemplate.Height = 25;
            dtvSRooms.ShowCellToolTips = false;
            dtvSRooms.Size = new Size(561, 300);
            dtvSRooms.TabIndex = 0;
            // 
            // tpInsertRoom
            // 
            tpInsertRoom.Controls.Add(pnIR);
            tpInsertRoom.Location = new Point(4, 64);
            tpInsertRoom.Name = "tpInsertRoom";
            tpInsertRoom.Size = new Size(622, 422);
            tpInsertRoom.TabIndex = 2;
            tpInsertRoom.Text = "Insert Room";
            tpInsertRoom.UseVisualStyleBackColor = true;
            // 
            // pnIR
            // 
            pnIR.BackColor = Color.WhiteSmoke;
            pnIR.BorderStyle = BorderStyle.FixedSingle;
            pnIR.Controls.Add(cbIRStatus);
            pnIR.Controls.Add(txtIRCapacity);
            pnIR.Controls.Add(lbIRCapacity);
            pnIR.Controls.Add(lbIRCode);
            pnIR.Controls.Add(lbEPInformation);
            pnIR.Controls.Add(btnIREnter);
            pnIR.Controls.Add(txtIRDescription);
            pnIR.Controls.Add(txtIRCode);
            pnIR.Controls.Add(txtIRPrice);
            pnIR.Controls.Add(lbIRDescription);
            pnIR.Controls.Add(lbRStatus);
            pnIR.Controls.Add(lbIRPrice);
            pnIR.Location = new Point(35, 85);
            pnIR.Name = "pnIR";
            pnIR.Size = new Size(545, 264);
            pnIR.TabIndex = 4;
            // 
            // cbIRStatus
            // 
            cbIRStatus.FormattingEnabled = true;
            cbIRStatus.Items.AddRange(new object[] { "Available" });
            cbIRStatus.Location = new Point(359, 67);
            cbIRStatus.Name = "cbIRStatus";
            cbIRStatus.Size = new Size(160, 23);
            cbIRStatus.TabIndex = 14;
            // 
            // txtIRCapacity
            // 
            txtIRCapacity.Location = new Point(359, 21);
            txtIRCapacity.Name = "txtIRCapacity";
            txtIRCapacity.Size = new Size(160, 23);
            txtIRCapacity.TabIndex = 13;
            // 
            // lbIRCapacity
            // 
            lbIRCapacity.AutoSize = true;
            lbIRCapacity.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbIRCapacity.Location = new Point(291, 22);
            lbIRCapacity.Name = "lbIRCapacity";
            lbIRCapacity.Size = new Size(62, 17);
            lbIRCapacity.TabIndex = 12;
            lbIRCapacity.Text = "Capacity:";
            // 
            // lbIRCode
            // 
            lbIRCode.AutoSize = true;
            lbIRCode.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbIRCode.Location = new Point(21, 22);
            lbIRCode.Name = "lbIRCode";
            lbIRCode.Size = new Size(42, 17);
            lbIRCode.TabIndex = 10;
            lbIRCode.Text = "Code:";
            // 
            // lbEPInformation
            // 
            lbEPInformation.AutoSize = true;
            lbEPInformation.Location = new Point(20, 176);
            lbEPInformation.Name = "lbEPInformation";
            lbEPInformation.Size = new Size(0, 15);
            lbEPInformation.TabIndex = 9;
            // 
            // btnIREnter
            // 
            btnIREnter.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnIREnter.Location = new Point(209, 209);
            btnIREnter.Name = "btnIREnter";
            btnIREnter.Size = new Size(125, 34);
            btnIREnter.TabIndex = 8;
            btnIREnter.Text = "Enter";
            btnIREnter.UseVisualStyleBackColor = true;
            // 
            // txtIRDescription
            // 
            txtIRDescription.Location = new Point(164, 137);
            txtIRDescription.Multiline = true;
            txtIRDescription.Name = "txtIRDescription";
            txtIRDescription.Size = new Size(214, 56);
            txtIRDescription.TabIndex = 7;
            // 
            // txtIRCode
            // 
            txtIRCode.Location = new Point(106, 21);
            txtIRCode.Name = "txtIRCode";
            txtIRCode.ReadOnly = true;
            txtIRCode.Size = new Size(160, 23);
            txtIRCode.TabIndex = 5;
            // 
            // txtIRPrice
            // 
            txtIRPrice.Location = new Point(106, 68);
            txtIRPrice.Name = "txtIRPrice";
            txtIRPrice.Size = new Size(160, 23);
            txtIRPrice.TabIndex = 4;
            // 
            // lbIRDescription
            // 
            lbIRDescription.AutoSize = true;
            lbIRDescription.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbIRDescription.Location = new Point(230, 114);
            lbIRDescription.Name = "lbIRDescription";
            lbIRDescription.Size = new Size(83, 17);
            lbIRDescription.TabIndex = 3;
            lbIRDescription.Text = "Description: ";
            // 
            // lbRStatus
            // 
            lbRStatus.AutoSize = true;
            lbRStatus.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbRStatus.Location = new Point(291, 69);
            lbRStatus.Name = "lbRStatus";
            lbRStatus.Size = new Size(49, 17);
            lbRStatus.TabIndex = 1;
            lbRStatus.Text = "Status:";
            // 
            // lbIRPrice
            // 
            lbIRPrice.AutoSize = true;
            lbIRPrice.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbIRPrice.Location = new Point(21, 69);
            lbIRPrice.Name = "lbIRPrice";
            lbIRPrice.Size = new Size(40, 17);
            lbIRPrice.TabIndex = 0;
            lbIRPrice.Text = "Price:";
            // 
            // tpAlterRoom
            // 
            tpAlterRoom.BackColor = Color.White;
            tpAlterRoom.Controls.Add(pnARI);
            tpAlterRoom.Location = new Point(4, 64);
            tpAlterRoom.Name = "tpAlterRoom";
            tpAlterRoom.Padding = new Padding(3);
            tpAlterRoom.Size = new Size(622, 422);
            tpAlterRoom.TabIndex = 0;
            tpAlterRoom.Text = "Alter Room Information";
            // 
            // pnARI
            // 
            pnARI.BackColor = Color.WhiteSmoke;
            pnARI.BorderStyle = BorderStyle.FixedSingle;
            pnARI.Controls.Add(pnCInfoARI);
            pnARI.Controls.Add(btnARISearch);
            pnARI.Controls.Add(txtARICode);
            pnARI.Controls.Add(lbARICode);
            pnARI.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            pnARI.Location = new Point(31, 29);
            pnARI.Name = "pnARI";
            pnARI.Size = new Size(553, 364);
            pnARI.TabIndex = 0;
            // 
            // pnCInfoARI
            // 
            pnCInfoARI.Controls.Add(cbARIStatus);
            pnCInfoARI.Controls.Add(lbAPIInformation);
            pnCInfoARI.Controls.Add(btnARIAlter);
            pnCInfoARI.Controls.Add(txtARIDescription);
            pnCInfoARI.Controls.Add(txtARIPrice);
            pnCInfoARI.Controls.Add(txtARICapacity);
            pnCInfoARI.Controls.Add(lbARIDescription);
            pnCInfoARI.Controls.Add(lbARIStatus);
            pnCInfoARI.Controls.Add(lbARIPrice);
            pnCInfoARI.Controls.Add(lbARICapacity);
            pnCInfoARI.Location = new Point(3, 129);
            pnCInfoARI.Name = "pnCInfoARI";
            pnCInfoARI.Size = new Size(545, 230);
            pnCInfoARI.TabIndex = 3;
            pnCInfoARI.Visible = false;
            // 
            // cbARIStatus
            // 
            cbARIStatus.FormattingEnabled = true;
            cbARIStatus.Location = new Point(364, 88);
            cbARIStatus.Name = "cbARIStatus";
            cbARIStatus.Size = new Size(160, 25);
            cbARIStatus.TabIndex = 10;
            // 
            // lbAPIInformation
            // 
            lbAPIInformation.AutoSize = true;
            lbAPIInformation.Location = new Point(11, 203);
            lbAPIInformation.Name = "lbAPIInformation";
            lbAPIInformation.Size = new Size(0, 17);
            lbAPIInformation.TabIndex = 9;
            // 
            // btnARIAlter
            // 
            btnARIAlter.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnARIAlter.Location = new Point(210, 143);
            btnARIAlter.Name = "btnARIAlter";
            btnARIAlter.Size = new Size(125, 34);
            btnARIAlter.TabIndex = 8;
            btnARIAlter.Text = "Alter";
            btnARIAlter.UseVisualStyleBackColor = true;
            // 
            // txtARIDescription
            // 
            txtARIDescription.Location = new Point(106, 26);
            txtARIDescription.Multiline = true;
            txtARIDescription.Name = "txtARIDescription";
            txtARIDescription.Size = new Size(187, 56);
            txtARIDescription.TabIndex = 7;
            // 
            // txtARIPrice
            // 
            txtARIPrice.Location = new Point(364, 26);
            txtARIPrice.Name = "txtARIPrice";
            txtARIPrice.Size = new Size(160, 25);
            txtARIPrice.TabIndex = 5;
            // 
            // txtARICapacity
            // 
            txtARICapacity.Location = new Point(106, 88);
            txtARICapacity.Name = "txtARICapacity";
            txtARICapacity.Size = new Size(187, 25);
            txtARICapacity.TabIndex = 4;
            // 
            // lbARIDescription
            // 
            lbARIDescription.AutoSize = true;
            lbARIDescription.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbARIDescription.Location = new Point(20, 29);
            lbARIDescription.Name = "lbARIDescription";
            lbARIDescription.Size = new Size(83, 17);
            lbARIDescription.TabIndex = 3;
            lbARIDescription.Text = "Description: ";
            // 
            // lbARIStatus
            // 
            lbARIStatus.AutoSize = true;
            lbARIStatus.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbARIStatus.Location = new Point(299, 91);
            lbARIStatus.Name = "lbARIStatus";
            lbARIStatus.Size = new Size(49, 17);
            lbARIStatus.TabIndex = 2;
            lbARIStatus.Text = "Status:";
            // 
            // lbARIPrice
            // 
            lbARIPrice.AutoSize = true;
            lbARIPrice.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbARIPrice.Location = new Point(299, 29);
            lbARIPrice.Name = "lbARIPrice";
            lbARIPrice.Size = new Size(40, 17);
            lbARIPrice.TabIndex = 1;
            lbARIPrice.Text = "Price:";
            // 
            // lbARICapacity
            // 
            lbARICapacity.AutoSize = true;
            lbARICapacity.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbARICapacity.Location = new Point(20, 91);
            lbARICapacity.Name = "lbARICapacity";
            lbARICapacity.Size = new Size(62, 17);
            lbARICapacity.TabIndex = 0;
            lbARICapacity.Text = "Capacity:";
            // 
            // btnARISearch
            // 
            btnARISearch.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnARISearch.Location = new Point(213, 86);
            btnARISearch.Name = "btnARISearch";
            btnARISearch.Size = new Size(125, 34);
            btnARISearch.TabIndex = 2;
            btnARISearch.Text = "Search";
            btnARISearch.UseVisualStyleBackColor = true;
            // 
            // txtARICode
            // 
            txtARICode.BorderStyle = BorderStyle.FixedSingle;
            txtARICode.Location = new Point(278, 41);
            txtARICode.Name = "txtARICode";
            txtARICode.Size = new Size(112, 25);
            txtARICode.TabIndex = 1;
            // 
            // lbARICode
            // 
            lbARICode.AutoSize = true;
            lbARICode.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbARICode.Location = new Point(161, 43);
            lbARICode.Name = "lbARICode";
            lbARICode.Size = new Size(82, 17);
            lbARICode.TabIndex = 0;
            lbARICode.Text = "Room Code:";
            // 
            // tpDeleteRoom
            // 
            tpDeleteRoom.Controls.Add(pnDR);
            tpDeleteRoom.Location = new Point(4, 64);
            tpDeleteRoom.Name = "tpDeleteRoom";
            tpDeleteRoom.Size = new Size(622, 422);
            tpDeleteRoom.TabIndex = 3;
            tpDeleteRoom.Text = "Delete Room";
            tpDeleteRoom.UseVisualStyleBackColor = true;
            // 
            // pnDR
            // 
            pnDR.BackColor = Color.WhiteSmoke;
            pnDR.BorderStyle = BorderStyle.FixedSingle;
            pnDR.Controls.Add(btnDRDelete);
            pnDR.Controls.Add(cbCRCode);
            pnDR.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            pnDR.Location = new Point(35, 142);
            pnDR.Name = "pnDR";
            pnDR.Size = new Size(545, 151);
            pnDR.TabIndex = 5;
            // 
            // btnDRDelete
            // 
            btnDRDelete.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnDRDelete.Location = new Point(222, 90);
            btnDRDelete.Name = "btnDRDelete";
            btnDRDelete.Size = new Size(98, 34);
            btnDRDelete.TabIndex = 9;
            btnDRDelete.Text = "Delete";
            btnDRDelete.UseVisualStyleBackColor = true;
            // 
            // cbCRCode
            // 
            cbCRCode.FormattingEnabled = true;
            cbCRCode.Location = new Point(207, 44);
            cbCRCode.Name = "cbCRCode";
            cbCRCode.Size = new Size(129, 25);
            cbCRCode.TabIndex = 0;
            // 
            // tpSeeHotel
            // 
            tpSeeHotel.Location = new Point(4, 64);
            tpSeeHotel.Name = "tpSeeHotel";
            tpSeeHotel.Size = new Size(622, 422);
            tpSeeHotel.TabIndex = 4;
            tpSeeHotel.Text = "See Hotel";
            tpSeeHotel.UseVisualStyleBackColor = true;
            // 
            // tpInsertHotel
            // 
            tpInsertHotel.Location = new Point(4, 64);
            tpInsertHotel.Name = "tpInsertHotel";
            tpInsertHotel.Size = new Size(622, 422);
            tpInsertHotel.TabIndex = 5;
            tpInsertHotel.Text = "Insert Hotel";
            tpInsertHotel.UseVisualStyleBackColor = true;
            // 
            // tpAlterHotel
            // 
            tpAlterHotel.Location = new Point(4, 64);
            tpAlterHotel.Name = "tpAlterHotel";
            tpAlterHotel.Size = new Size(622, 422);
            tpAlterHotel.TabIndex = 6;
            tpAlterHotel.Text = "AlterHotel";
            tpAlterHotel.UseVisualStyleBackColor = true;
            // 
            // tpDeleteHotel
            // 
            tpDeleteHotel.Location = new Point(4, 64);
            tpDeleteHotel.Name = "tpDeleteHotel";
            tpDeleteHotel.Size = new Size(622, 422);
            tpDeleteHotel.TabIndex = 7;
            tpDeleteHotel.Text = "Delete Hotel";
            tpDeleteHotel.UseVisualStyleBackColor = true;
            // 
            // tpAlterGuest
            // 
            tpAlterGuest.Location = new Point(4, 64);
            tpAlterGuest.Name = "tpAlterGuest";
            tpAlterGuest.Size = new Size(622, 422);
            tpAlterGuest.TabIndex = 8;
            tpAlterGuest.Text = "Alter Guest";
            tpAlterGuest.UseVisualStyleBackColor = true;
            // 
            // tpDeleteGuest
            // 
            tpDeleteGuest.Location = new Point(4, 64);
            tpDeleteGuest.Name = "tpDeleteGuest";
            tpDeleteGuest.Size = new Size(622, 422);
            tpDeleteGuest.TabIndex = 9;
            tpDeleteGuest.Text = "Delete Guest";
            tpDeleteGuest.UseVisualStyleBackColor = true;
            // 
            // tpInsertGuest
            // 
            tpInsertGuest.Location = new Point(4, 64);
            tpInsertGuest.Name = "tpInsertGuest";
            tpInsertGuest.Size = new Size(622, 422);
            tpInsertGuest.TabIndex = 10;
            tpInsertGuest.Text = "Insert Guest";
            tpInsertGuest.UseVisualStyleBackColor = true;
            // 
            // tpSeeGuest
            // 
            tpSeeGuest.Location = new Point(4, 64);
            tpSeeGuest.Name = "tpSeeGuest";
            tpSeeGuest.Size = new Size(622, 422);
            tpSeeGuest.TabIndex = 11;
            tpSeeGuest.Text = "See Guest";
            tpSeeGuest.UseVisualStyleBackColor = true;
            // 
            // tpCheckIn
            // 
            tpCheckIn.Location = new Point(4, 64);
            tpCheckIn.Name = "tpCheckIn";
            tpCheckIn.Size = new Size(622, 422);
            tpCheckIn.TabIndex = 12;
            tpCheckIn.Text = "Check In";
            tpCheckIn.UseVisualStyleBackColor = true;
            // 
            // tpCheckOut
            // 
            tpCheckOut.Location = new Point(4, 64);
            tpCheckOut.Name = "tpCheckOut";
            tpCheckOut.Size = new Size(622, 422);
            tpCheckOut.TabIndex = 13;
            tpCheckOut.Text = "Check Out";
            tpCheckOut.UseVisualStyleBackColor = true;
            // 
            // tpAlterHosting
            // 
            tpAlterHosting.Location = new Point(4, 64);
            tpAlterHosting.Name = "tpAlterHosting";
            tpAlterHosting.Size = new Size(622, 422);
            tpAlterHosting.TabIndex = 14;
            tpAlterHosting.Text = "Alter Hosting ";
            tpAlterHosting.UseVisualStyleBackColor = true;
            // 
            // tpSeeHosting
            // 
            tpSeeHosting.Location = new Point(4, 64);
            tpSeeHosting.Name = "tpSeeHosting";
            tpSeeHosting.Size = new Size(622, 422);
            tpSeeHosting.TabIndex = 15;
            tpSeeHosting.Text = "See Hosting";
            tpSeeHosting.UseVisualStyleBackColor = true;
            // 
            // frmIndex
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(808, 490);
            Controls.Add(tcManage);
            Controls.Add(pnMMenu);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmIndex";
            Text = "appHotel";
            pnMMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbIcon).EndInit();
            tcManage.ResumeLayout(false);
            tpSeeRooms.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtvSRooms).EndInit();
            tpInsertRoom.ResumeLayout(false);
            pnIR.ResumeLayout(false);
            pnIR.PerformLayout();
            tpAlterRoom.ResumeLayout(false);
            pnARI.ResumeLayout(false);
            pnARI.PerformLayout();
            pnCInfoARI.ResumeLayout(false);
            pnCInfoARI.PerformLayout();
            tpDeleteRoom.ResumeLayout(false);
            pnDR.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnMMenu;
        private Panel pnDivisorMHotel;
        private Button btnManageHotel;
        private Panel pnDivisorTOHosting;
        private Panel pnDivisorEHosting;
        private Panel pnDivisorMRoom;
        private Panel pnDivisorMGuest;
        private PictureBox pbIcon;
        private Button btnCheckOut;
        private Button btnCheckIn;
        private Button btnManageRoom;
        private Button btnManageGuest;
        private TabControl tcManage;
        private TabPage tpSeeRooms;
        private Button btnSRShow;
        private DataGridView dtvSRooms;
        private TabPage tpInsertRoom;
        private Panel pnIR;
        private Label lbEPInformation;
        private Button btnIREnter;
        private TextBox txtIRDescription;
        private TextBox txtIRCode;
        private TextBox txtIRPrice;
        private TextBox txtEPNumber;
        private TextBox txtEPMoney;
        private TextBox txtEPName;
        private Label lbIRDescription;
        private Label lbEPNumber;
        private Label lbRStatus;
        private Label lbIRPrice;
        private Label lbEPName;
        private TabPage tpAlterRoom;
        private Panel pnARI;
        private Panel pnCInfoARI;
        private Label lbAPIInformation;
        private Button btnARIAlter;
        private TextBox txtARIDescription;
        private TextBox txtARIPrice;
        private TextBox txtARICapacity;
        private Label lbARIDescription;
        private Label lbARIStatus;
        private Label lbARIPrice;
        private Label lbARICapacity;
        private Button btnARISearch;
        private TextBox txtARICode;
        private Label lbARICode;
        private TabPage tpDeleteRoom;
        private Panel pnDR;
        private Panel pnDivisorMHosting;
        private Button btnManageHosting;
        private TextBox txtIRCapacity;
        private Label lbIRCapacity;
        private Label lbIRCode;
        private ComboBox cbIRStatus;
        private ComboBox cbARIStatus;
        private Button btnDRDelete;
        private ComboBox cbCRCode;
        private TabPage tpSeeHotel;
        private TabPage tpInsertHotel;
        private TabPage tpAlterHotel;
        private TabPage tpDeleteHotel;
        private TabPage tpAlterGuest;
        private TabPage tpDeleteGuest;
        private TabPage tpInsertGuest;
        private TabPage tpSeeGuest;
        private TabPage tpCheckIn;
        private TabPage tpCheckOut;
        private TabPage tpAlterHosting;
        private TabPage tpSeeHosting;
    }
}
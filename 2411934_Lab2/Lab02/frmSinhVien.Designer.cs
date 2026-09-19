namespace Lab02
{
    partial class frmSinhVien
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.themToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xoaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelTongSV = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupboxTTSV = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnMacDinh = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.clbChuyenNganh = new System.Windows.Forms.CheckedListBox();
            this.rdNu = new System.Windows.Forms.RadioButton();
            this.rdNam = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtHinh = new System.Windows.Forms.TextBox();
            this.cboLop = new System.Windows.Forms.ComboBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.mtxtMaSo = new System.Windows.Forms.MaskedTextBox();
            this.pbHinh = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupboxDSSV = new System.Windows.Forms.GroupBox();
            this.lvSinhVien = new System.Windows.Forms.ListView();
            this.chMaSo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chHoTen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chNgaySinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDiaChi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chLop = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPhai = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chChuyenNganh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chHinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupboxTTSV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHinh)).BeginInit();
            this.groupboxDSSV.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1182, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.moFileToolStripMenuItem,
            this.thoatToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // moFileToolStripMenuItem
            // 
            this.moFileToolStripMenuItem.Name = "moFileToolStripMenuItem";
            this.moFileToolStripMenuItem.Size = new System.Drawing.Size(141, 26);
            this.moFileToolStripMenuItem.Text = "Mở File";
            this.moFileToolStripMenuItem.Click += new System.EventHandler(this.moFileToolStripMenuItem_Click);
            // 
            // thoatToolStripMenuItem
            // 
            this.thoatToolStripMenuItem.Name = "thoatToolStripMenuItem";
            this.thoatToolStripMenuItem.Size = new System.Drawing.Size(141, 26);
            this.thoatToolStripMenuItem.Text = "Thoát";
            this.thoatToolStripMenuItem.Click += new System.EventHandler(this.thoatToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.themToolStripMenuItem,
            this.xoaToolStripMenuItem,
            this.suaToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // themToolStripMenuItem
            // 
            this.themToolStripMenuItem.Name = "themToolStripMenuItem";
            this.themToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.T)));
            this.themToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            this.themToolStripMenuItem.Text = "Thêm";
            this.themToolStripMenuItem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // xoaToolStripMenuItem
            // 
            this.xoaToolStripMenuItem.Name = "xoaToolStripMenuItem";
            this.xoaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.Y)));
            this.xoaToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            this.xoaToolStripMenuItem.Text = "Xóa";
            this.xoaToolStripMenuItem.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // suaToolStripMenuItem
            // 
            this.suaToolStripMenuItem.Name = "suaToolStripMenuItem";
            this.suaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.S)));
            this.suaToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            this.suaToolStripMenuItem.Text = "Sửa";
            this.suaToolStripMenuItem.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelTongSV});
            this.statusStrip1.Location = new System.Drawing.Point(0, 680);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1182, 26);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelTongSV
            // 
            this.toolStripStatusLabelTongSV.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabelTongSV.Name = "toolStripStatusLabelTongSV";
            this.toolStripStatusLabelTongSV.Size = new System.Drawing.Size(134, 20);
            this.toolStripStatusLabelTongSV.Text = "Tổng Sinh Viên: 0";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 28);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupboxTTSV);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupboxDSSV);
            this.splitContainer1.Size = new System.Drawing.Size(1182, 652);
            this.splitContainer1.SplitterDistance = 580;
            this.splitContainer1.TabIndex = 2;
            // 
            // groupboxTTSV
            // 
            this.groupboxTTSV.Controls.Add(this.btnThoat);
            this.groupboxTTSV.Controls.Add(this.btnMacDinh);
            this.groupboxTTSV.Controls.Add(this.btnSua);
            this.groupboxTTSV.Controls.Add(this.btnXoa);
            this.groupboxTTSV.Controls.Add(this.btnThem);
            this.groupboxTTSV.Controls.Add(this.clbChuyenNganh);
            this.groupboxTTSV.Controls.Add(this.rdNu);
            this.groupboxTTSV.Controls.Add(this.rdNam);
            this.groupboxTTSV.Controls.Add(this.label9);
            this.groupboxTTSV.Controls.Add(this.label8);
            this.groupboxTTSV.Controls.Add(this.btnBrowse);
            this.groupboxTTSV.Controls.Add(this.txtHinh);
            this.groupboxTTSV.Controls.Add(this.cboLop);
            this.groupboxTTSV.Controls.Add(this.txtDiaChi);
            this.groupboxTTSV.Controls.Add(this.dtpNgaySinh);
            this.groupboxTTSV.Controls.Add(this.txtHoTen);
            this.groupboxTTSV.Controls.Add(this.mtxtMaSo);
            this.groupboxTTSV.Controls.Add(this.pbHinh);
            this.groupboxTTSV.Controls.Add(this.label7);
            this.groupboxTTSV.Controls.Add(this.label6);
            this.groupboxTTSV.Controls.Add(this.label5);
            this.groupboxTTSV.Controls.Add(this.label4);
            this.groupboxTTSV.Controls.Add(this.label3);
            this.groupboxTTSV.Controls.Add(this.label2);
            this.groupboxTTSV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupboxTTSV.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupboxTTSV.Location = new System.Drawing.Point(0, 0);
            this.groupboxTTSV.Name = "groupboxTTSV";
            this.groupboxTTSV.Size = new System.Drawing.Size(580, 652);
            this.groupboxTTSV.TabIndex = 0;
            this.groupboxTTSV.TabStop = false;
            this.groupboxTTSV.Text = "Thông tin sinh viên";
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.Purple;
            this.btnThoat.Location = new System.Drawing.Point(463, 600);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(95, 35);
            this.btnThoat.TabIndex = 23;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnMacDinh
            // 
            this.btnMacDinh.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMacDinh.ForeColor = System.Drawing.Color.Purple;
            this.btnMacDinh.Location = new System.Drawing.Point(344, 600);
            this.btnMacDinh.Name = "btnMacDinh";
            this.btnMacDinh.Size = new System.Drawing.Size(105, 35);
            this.btnMacDinh.TabIndex = 22;
            this.btnMacDinh.Text = "Mặc Định";
            this.btnMacDinh.UseVisualStyleBackColor = true;
            this.btnMacDinh.Click += new System.EventHandler(this.btnMacDinh_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.Purple;
            this.btnSua.Location = new System.Drawing.Point(234, 600);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(95, 35);
            this.btnSua.TabIndex = 21;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.Purple;
            this.btnXoa.Location = new System.Drawing.Point(125, 600);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(95, 35);
            this.btnXoa.TabIndex = 20;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.Purple;
            this.btnThem.Location = new System.Drawing.Point(16, 600);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(95, 35);
            this.btnThem.TabIndex = 19;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // clbChuyenNganh
            // 
            this.clbChuyenNganh.CheckOnClick = true;
            this.clbChuyenNganh.FormattingEnabled = true;
            this.clbChuyenNganh.Items.AddRange(new object[] {
            "Mạng truyền thông",
            "Công nghệ phần mềm",
            "Khoa học máy tính",
            "Trí tuệ nhân tạo",
            "Hệ thống thông tin",
            "Tin học ứng dụng"});
            this.clbChuyenNganh.Location = new System.Drawing.Point(155, 410);
            this.clbChuyenNganh.Name = "clbChuyenNganh";
            this.clbChuyenNganh.Size = new System.Drawing.Size(403, 158);
            this.clbChuyenNganh.TabIndex = 18;
            // 
            // rdNu
            // 
            this.rdNu.AutoSize = true;
            this.rdNu.Location = new System.Drawing.Point(268, 365);
            this.rdNu.Name = "rdNu";
            this.rdNu.Size = new System.Drawing.Size(51, 23);
            this.rdNu.TabIndex = 17;
            this.rdNu.Text = "Nữ";
            this.rdNu.UseVisualStyleBackColor = true;
            // 
            // rdNam
            // 
            this.rdNam.AutoSize = true;
            this.rdNam.Checked = true;
            this.rdNam.Location = new System.Drawing.Point(155, 365);
            this.rdNam.Name = "rdNam";
            this.rdNam.Size = new System.Drawing.Size(62, 23);
            this.rdNam.TabIndex = 16;
            this.rdNam.TabStop = true;
            this.rdNam.Text = "Nam";
            this.rdNam.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(15, 410);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 19);
            this.label9.TabIndex = 15;
            this.label9.Text = "Chuyên ngành";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 367);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 19);
            this.label8.TabIndex = 14;
            this.label8.Text = "Giới tính";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(518, 311);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(40, 28);
            this.btnBrowse.TabIndex = 13;
            this.btnBrowse.Text = "...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtHinh
            // 
            this.txtHinh.Location = new System.Drawing.Point(125, 312);
            this.txtHinh.Name = "txtHinh";
            this.txtHinh.ReadOnly = true;
            this.txtHinh.Size = new System.Drawing.Size(387, 27);
            this.txtHinh.TabIndex = 12;
            // 
            // cboLop
            // 
            this.cboLop.FormattingEnabled = true;
            this.cboLop.Items.AddRange(new object[] {
            "CTK31",
            "CTK32",
            "CTK33",
            "CTK34",
            "CTK32CD",
            "CTK33CD",
            "CTK34CD"});
            this.cboLop.Location = new System.Drawing.Point(298, 245);
            this.cboLop.Name = "cboLop";
            this.cboLop.Size = new System.Drawing.Size(260, 27);
            this.cboLop.TabIndex = 11;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(298, 195);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(260, 27);
            this.txtDiaChi.TabIndex = 10;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySinh.Location = new System.Drawing.Point(298, 145);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(260, 27);
            this.dtpNgaySinh.TabIndex = 9;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(298, 95);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(260, 27);
            this.txtHoTen.TabIndex = 8;
            // 
            // mtxtMaSo
            // 
            this.mtxtMaSo.Location = new System.Drawing.Point(298, 45);
            this.mtxtMaSo.Mask = "SV.00000";
            this.mtxtMaSo.Name = "mtxtMaSo";
            this.mtxtMaSo.Size = new System.Drawing.Size(260, 27);
            this.mtxtMaSo.TabIndex = 7;
            // 
            // pbHinh
            // 
            this.pbHinh.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbHinh.Location = new System.Drawing.Point(19, 45);
            this.pbHinh.Name = "pbHinh";
            this.pbHinh.Size = new System.Drawing.Size(175, 227);
            this.pbHinh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbHinh.TabIndex = 6;
            this.pbHinh.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 316);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 19);
            this.label7.TabIndex = 5;
            this.label7.Text = "Hình";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(211, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 19);
            this.label6.TabIndex = 4;
            this.label6.Text = "Lớp";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(211, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 19);
            this.label5.TabIndex = 3;
            this.label5.Text = "Địa chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(211, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ngày sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(211, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Họ tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(211, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã số";
            // 
            // groupboxDSSV
            // 
            this.groupboxDSSV.Controls.Add(this.lvSinhVien);
            this.groupboxDSSV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupboxDSSV.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupboxDSSV.Location = new System.Drawing.Point(0, 0);
            this.groupboxDSSV.Name = "groupboxDSSV";
            this.groupboxDSSV.Size = new System.Drawing.Size(598, 652);
            this.groupboxDSSV.TabIndex = 0;
            this.groupboxDSSV.TabStop = false;
            this.groupboxDSSV.Text = "Danh sách sinh viên";
            // 
            // lvSinhVien
            // 
            this.lvSinhVien.CheckBoxes = true;
            this.lvSinhVien.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chMaSo,
            this.chHoTen,
            this.chNgaySinh,
            this.chDiaChi,
            this.chLop,
            this.chPhai,
            this.chChuyenNganh,
            this.chHinh});
            this.lvSinhVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvSinhVien.FullRowSelect = true;
            this.lvSinhVien.GridLines = true;
            this.lvSinhVien.HideSelection = false;
            this.lvSinhVien.Location = new System.Drawing.Point(3, 23);
            this.lvSinhVien.Name = "lvSinhVien";
            this.lvSinhVien.Size = new System.Drawing.Size(592, 626);
            this.lvSinhVien.TabIndex = 0;
            this.lvSinhVien.UseCompatibleStateImageBehavior = false;
            this.lvSinhVien.View = System.Windows.Forms.View.Details;
            this.lvSinhVien.SelectedIndexChanged += new System.EventHandler(this.lvSinhVien_SelectedIndexChanged);
            // 
            // chMaSo
            // 
            this.chMaSo.Text = "Mã số";
            this.chMaSo.Width = 90;
            // 
            // chHoTen
            // 
            this.chHoTen.Text = "Họ tên";
            this.chHoTen.Width = 150;
            // 
            // chNgaySinh
            // 
            this.chNgaySinh.Text = "Ngày sinh";
            this.chNgaySinh.Width = 100;
            // 
            // chDiaChi
            // 
            this.chDiaChi.Text = "Địa chỉ";
            this.chDiaChi.Width = 110;
            // 
            // chLop
            // 
            this.chLop.Text = "Lớp";
            this.chLop.Width = 80;
            // 
            // chPhai
            // 
            this.chPhai.Text = "Phái";
            this.chPhai.Width = 60;
            // 
            // chChuyenNganh
            // 
            this.chChuyenNganh.Text = "Chuyên ngành";
            this.chChuyenNganh.Width = 200;
            // 
            // chHinh
            // 
            this.chHinh.Text = "Hình";
            this.chHinh.Width = 100;
            // 
            // frmSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 706);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmSinhVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Demo Sinh viên";
            this.Load += new System.EventHandler(this.frmSinhVien_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupboxTTSV.ResumeLayout(false);
            this.groupboxTTSV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHinh)).EndInit();
            this.groupboxDSSV.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem themToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xoaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suaToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelTongSV;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupboxTTSV;
        private System.Windows.Forms.GroupBox groupboxDSSV;
        private System.Windows.Forms.ListView lvSinhVien;
        private System.Windows.Forms.ColumnHeader chMaSo;
        private System.Windows.Forms.ColumnHeader chHoTen;
        private System.Windows.Forms.ColumnHeader chNgaySinh;
        private System.Windows.Forms.ColumnHeader chDiaChi;
        private System.Windows.Forms.ColumnHeader chLop;
        private System.Windows.Forms.ColumnHeader chPhai;
        private System.Windows.Forms.ColumnHeader chChuyenNganh;
        private System.Windows.Forms.ColumnHeader chHinh;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbHinh;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.MaskedTextBox mtxtMaSo;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.ComboBox cboLop;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtHinh;
        private System.Windows.Forms.RadioButton rdNu;
        private System.Windows.Forms.RadioButton rdNam;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckedListBox clbChuyenNganh;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnMacDinh;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
    }
}

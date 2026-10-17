namespace Lab_3
{
    partial class frmSinhVien
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblMSSV = new System.Windows.Forms.Label();
            this.mtbMSSV = new System.Windows.Forms.MaskedTextBox();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.rbNam = new System.Windows.Forms.RadioButton();
            this.rbNu = new System.Windows.Forms.RadioButton();
            this.lblHoVaTenLot = new System.Windows.Forms.Label();
            this.txtHoVaTenLot = new System.Windows.Forms.TextBox();
            this.lblTen = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.lblLop = new System.Windows.Forms.Label();
            this.cboLop = new System.Windows.Forms.ComboBox();
            this.lblCMND = new System.Windows.Forms.Label();
            this.mtbCMND = new System.Windows.Forms.MaskedTextBox();
            this.lblSDT = new System.Windows.Forms.Label();
            this.mtbSDT = new System.Windows.Forms.MaskedTextBox();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.lblMonHoc = new System.Windows.Forms.Label();
            this.clbMonHoc = new System.Windows.Forms.CheckedListBox();
            this.ctxMonHoc = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiThemMon = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiXoaMon = new System.Windows.Forms.ToolStripMenuItem();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnThemMoi = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.grpDanhSach = new System.Windows.Forms.GroupBox();
            this.lvSinhVien = new System.Windows.Forms.ListView();
            this.colMSSV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHoLot = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNgaySinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLop = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCMND = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSDT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDiaChi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ctxListView = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiXoaSinhVien = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiChonTatCa = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBoChonTatCa = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiTaiLai = new System.Windows.Forms.ToolStripMenuItem();
            this.lblDinhDang = new System.Windows.Forms.Label();
            this.cboDinhDangFile = new System.Windows.Forms.ComboBox();
            this.pnlGioiTinh = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslTongSV = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslFileDangDung = new System.Windows.Forms.ToolStripStatusLabel();
            this.ctxMonHoc.SuspendLayout();
            this.grpDanhSach.SuspendLayout();
            this.ctxListView.SuspendLayout();
            this.pnlGioiTinh.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMSSV
            // 
            this.lblMSSV.AutoSize = true;
            this.lblMSSV.Location = new System.Drawing.Point(30, 25);
            this.lblMSSV.Name = "lblMSSV";
            this.lblMSSV.Size = new System.Drawing.Size(54, 20);
            this.lblMSSV.TabIndex = 0;
            this.lblMSSV.Text = "MSSV :";
            // 
            // mtbMSSV
            // 
            this.mtbMSSV.Location = new System.Drawing.Point(150, 22);
            this.mtbMSSV.Mask = "0000000";
            this.mtbMSSV.Name = "mtbMSSV";
            this.mtbMSSV.PromptChar = ' ';
            this.mtbMSSV.Size = new System.Drawing.Size(200, 27);
            this.mtbMSSV.TabIndex = 1;
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Location = new System.Drawing.Point(395, 25);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(72, 20);
            this.lblGioiTinh.TabIndex = 2;
            this.lblGioiTinh.Text = "Giới tính :";
            // 
            // rbNam
            // 
            this.rbNam.AutoSize = true;
            this.rbNam.Checked = true;
            this.rbNam.Location = new System.Drawing.Point(3, 1);
            this.rbNam.Name = "rbNam";
            this.rbNam.Size = new System.Drawing.Size(62, 24);
            this.rbNam.TabIndex = 0;
            this.rbNam.TabStop = true;
            this.rbNam.Text = "Nam";
            this.rbNam.UseVisualStyleBackColor = true;
            // 
            // rbNu
            // 
            this.rbNu.AutoSize = true;
            this.rbNu.Location = new System.Drawing.Point(90, 1);
            this.rbNu.Name = "rbNu";
            this.rbNu.Size = new System.Drawing.Size(50, 24);
            this.rbNu.TabIndex = 1;
            this.rbNu.Text = "Nữ";
            this.rbNu.UseVisualStyleBackColor = true;
            // 
            // lblHoVaTenLot
            // 
            this.lblHoVaTenLot.AutoSize = true;
            this.lblHoVaTenLot.Location = new System.Drawing.Point(30, 60);
            this.lblHoVaTenLot.Name = "lblHoVaTenLot";
            this.lblHoVaTenLot.Size = new System.Drawing.Size(102, 20);
            this.lblHoVaTenLot.TabIndex = 4;
            this.lblHoVaTenLot.Text = "Họ và tên lót :";
            // 
            // txtHoVaTenLot
            // 
            this.txtHoVaTenLot.Location = new System.Drawing.Point(150, 57);
            this.txtHoVaTenLot.Name = "txtHoVaTenLot";
            this.txtHoVaTenLot.Size = new System.Drawing.Size(200, 27);
            this.txtHoVaTenLot.TabIndex = 5;
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Location = new System.Drawing.Point(395, 60);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(39, 20);
            this.lblTen.TabIndex = 6;
            this.lblTen.Text = "Tên :";
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(485, 57);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(215, 27);
            this.txtTen.TabIndex = 7;
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Location = new System.Drawing.Point(30, 95);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(81, 20);
            this.lblNgaySinh.TabIndex = 8;
            this.lblNgaySinh.Text = "Ngày sinh :";
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySinh.Location = new System.Drawing.Point(150, 92);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(200, 27);
            this.dtpNgaySinh.TabIndex = 9;
            // 
            // lblLop
            // 
            this.lblLop.AutoSize = true;
            this.lblLop.Location = new System.Drawing.Point(395, 95);
            this.lblLop.Name = "lblLop";
            this.lblLop.Size = new System.Drawing.Size(41, 20);
            this.lblLop.TabIndex = 10;
            this.lblLop.Text = "Lớp :";
            // 
            // cboLop
            // 
            this.cboLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLop.FormattingEnabled = true;
            this.cboLop.Items.AddRange(new object[] {
            "CTK41",
            "CTK42",
            "CTK43",
            "CTK44",
            "CTK45",
            "CTK46"});
            this.cboLop.Location = new System.Drawing.Point(485, 92);
            this.cboLop.Name = "cboLop";
            this.cboLop.Size = new System.Drawing.Size(215, 28);
            this.cboLop.TabIndex = 11;
            this.cboLop.SelectedIndexChanged += new System.EventHandler(this.cboLop_SelectedIndexChanged);
            // 
            // lblCMND
            // 
            this.lblCMND.AutoSize = true;
            this.lblCMND.Location = new System.Drawing.Point(30, 130);
            this.lblCMND.Name = "lblCMND";
            this.lblCMND.Size = new System.Drawing.Size(81, 20);
            this.lblCMND.TabIndex = 12;
            this.lblCMND.Text = "Số CMND :";
            // 
            // mtbCMND
            // 
            this.mtbCMND.Location = new System.Drawing.Point(150, 127);
            this.mtbCMND.Mask = "000000000";
            this.mtbCMND.Name = "mtbCMND";
            this.mtbCMND.PromptChar = ' ';
            this.mtbCMND.Size = new System.Drawing.Size(200, 27);
            this.mtbCMND.TabIndex = 13;
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Location = new System.Drawing.Point(395, 130);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(56, 20);
            this.lblSDT.TabIndex = 14;
            this.lblSDT.Text = "Số ĐT :";
            // 
            // mtbSDT
            // 
            this.mtbSDT.Location = new System.Drawing.Point(485, 127);
            this.mtbSDT.Mask = "0000000000";
            this.mtbSDT.Name = "mtbSDT";
            this.mtbSDT.PromptChar = ' ';
            this.mtbSDT.Size = new System.Drawing.Size(215, 27);
            this.mtbSDT.TabIndex = 15;
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Location = new System.Drawing.Point(30, 165);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(113, 20);
            this.lblDiaChi.TabIndex = 16;
            this.lblDiaChi.Text = "Địa chỉ liên lạc :";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(150, 162);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(550, 27);
            this.txtDiaChi.TabIndex = 17;
            // 
            // lblMonHoc
            // 
            this.lblMonHoc.AutoSize = true;
            this.lblMonHoc.Location = new System.Drawing.Point(30, 200);
            this.lblMonHoc.Name = "lblMonHoc";
            this.lblMonHoc.Size = new System.Drawing.Size(130, 20);
            this.lblMonHoc.TabIndex = 18;
            this.lblMonHoc.Text = "Môn học đăng ký :";
            // 
            // clbMonHoc
            // 
            this.clbMonHoc.CheckOnClick = true;
            this.clbMonHoc.ColumnWidth = 270;
            this.clbMonHoc.ContextMenuStrip = this.ctxMonHoc;
            this.clbMonHoc.FormattingEnabled = true;
            this.clbMonHoc.Items.AddRange(new object[] {
            "Mạng máy tính",
            "Hệ điều hành",
            "Lập trình CSDL",
            "Lập trình mạng",
            "Đồ án cơ sở",
            "Phương pháp NCKH",
            "Lập trình trên thiết bị di động",
            "An toàn và bảo mật hệ thống"});
            this.clbMonHoc.Location = new System.Drawing.Point(150, 197);
            this.clbMonHoc.MultiColumn = true;
            this.clbMonHoc.Name = "clbMonHoc";
            this.clbMonHoc.Size = new System.Drawing.Size(550, 92);
            this.clbMonHoc.TabIndex = 19;
            // 
            // ctxMonHoc
            // 
            this.ctxMonHoc.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ctxMonHoc.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiThemMon,
            this.tsmiXoaMon});
            this.ctxMonHoc.Name = "ctxMonHoc";
            this.ctxMonHoc.Size = new System.Drawing.Size(213, 52);
            // 
            // tsmiThemMon
            // 
            this.tsmiThemMon.Name = "tsmiThemMon";
            this.tsmiThemMon.Size = new System.Drawing.Size(212, 24);
            this.tsmiThemMon.Text = "Thêm môn học...";
            this.tsmiThemMon.Click += new System.EventHandler(this.tsmiThemMon_Click);
            // 
            // tsmiXoaMon
            // 
            this.tsmiXoaMon.Name = "tsmiXoaMon";
            this.tsmiXoaMon.Size = new System.Drawing.Size(212, 24);
            this.tsmiXoaMon.Text = "Xóa môn đang chọn";
            this.tsmiXoaMon.Click += new System.EventHandler(this.tsmiXoaMon_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(280, 308);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(90, 32);
            this.btnTimKiem.TabIndex = 20;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Location = new System.Drawing.Point(385, 308);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(90, 32);
            this.btnThemMoi.TabIndex = 21;
            this.btnThemMoi.Text = "Thêm mới";
            this.btnThemMoi.UseVisualStyleBackColor = true;
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(490, 308);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(90, 32);
            this.btnCapNhat.TabIndex = 22;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(610, 308);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(90, 32);
            this.btnThoat.TabIndex = 23;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // grpDanhSach
            // 
            this.grpDanhSach.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpDanhSach.Controls.Add(this.lvSinhVien);
            this.grpDanhSach.Location = new System.Drawing.Point(12, 348);
            this.grpDanhSach.Name = "grpDanhSach";
            this.grpDanhSach.Size = new System.Drawing.Size(760, 243);
            this.grpDanhSach.TabIndex = 24;
            this.grpDanhSach.TabStop = false;
            this.grpDanhSach.Text = "Danh sách sinh viên";
            // 
            // lvSinhVien
            // 
            this.lvSinhVien.CheckBoxes = true;
            this.lvSinhVien.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMSSV,
            this.colHoLot,
            this.colTen,
            this.colNgaySinh,
            this.colLop,
            this.colCMND,
            this.colSDT,
            this.colDiaChi});
            this.lvSinhVien.ContextMenuStrip = this.ctxListView;
            this.lvSinhVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvSinhVien.FullRowSelect = true;
            this.lvSinhVien.GridLines = true;
            this.lvSinhVien.HideSelection = false;
            this.lvSinhVien.Location = new System.Drawing.Point(3, 23);
            this.lvSinhVien.Name = "lvSinhVien";
            this.lvSinhVien.Size = new System.Drawing.Size(754, 217);
            this.lvSinhVien.TabIndex = 0;
            this.lvSinhVien.UseCompatibleStateImageBehavior = false;
            this.lvSinhVien.View = System.Windows.Forms.View.Details;
            this.lvSinhVien.SelectedIndexChanged += new System.EventHandler(this.lvSinhVien_SelectedIndexChanged);
            // 
            // colMSSV
            // 
            this.colMSSV.Text = "MSSV";
            this.colMSSV.Width = 80;
            // 
            // colHoLot
            // 
            this.colHoLot.Text = "Họ và tên lót";
            this.colHoLot.Width = 140;
            // 
            // colTen
            // 
            this.colTen.Text = "Tên";
            this.colTen.Width = 70;
            // 
            // colNgaySinh
            // 
            this.colNgaySinh.Text = "Ngày sinh";
            this.colNgaySinh.Width = 85;
            // 
            // colLop
            // 
            this.colLop.Text = "Lớp";
            this.colLop.Width = 65;
            // 
            // colCMND
            // 
            this.colCMND.Text = "Số CMND";
            this.colCMND.Width = 90;
            // 
            // colSDT
            // 
            this.colSDT.Text = "Số điện thoại";
            this.colSDT.Width = 95;
            // 
            // colDiaChi
            // 
            this.colDiaChi.Text = "Địa chỉ liên lạc";
            this.colDiaChi.Width = 120;
            // 
            // ctxListView
            // 
            this.ctxListView.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ctxListView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiXoaSinhVien,
            this.toolStripSeparator1,
            this.tsmiChonTatCa,
            this.tsmiBoChonTatCa,
            this.toolStripSeparator2,
            this.tsmiTaiLai});
            this.ctxListView.Name = "ctxListView";
            this.ctxListView.Size = new System.Drawing.Size(249, 112);
            // 
            // tsmiXoaSinhVien
            // 
            this.tsmiXoaSinhVien.Name = "tsmiXoaSinhVien";
            this.tsmiXoaSinhVien.Size = new System.Drawing.Size(248, 24);
            this.tsmiXoaSinhVien.Text = "Xóa các sinh viên đã chọn";
            this.tsmiXoaSinhVien.Click += new System.EventHandler(this.tsmiXoaSinhVien_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(245, 6);
            // 
            // tsmiChonTatCa
            // 
            this.tsmiChonTatCa.Name = "tsmiChonTatCa";
            this.tsmiChonTatCa.Size = new System.Drawing.Size(248, 24);
            this.tsmiChonTatCa.Text = "Chọn tất cả Checkbox";
            this.tsmiChonTatCa.Click += new System.EventHandler(this.tsmiChonTatCa_Click);
            // 
            // tsmiBoChonTatCa
            // 
            this.tsmiBoChonTatCa.Name = "tsmiBoChonTatCa";
            this.tsmiBoChonTatCa.Size = new System.Drawing.Size(248, 24);
            this.tsmiBoChonTatCa.Text = "Bỏ chọn tất cả";
            this.tsmiBoChonTatCa.Click += new System.EventHandler(this.tsmiBoChonTatCa_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(245, 6);
            // 
            // tsmiTaiLai
            // 
            this.tsmiTaiLai.Name = "tsmiTaiLai";
            this.tsmiTaiLai.Size = new System.Drawing.Size(248, 24);
            this.tsmiTaiLai.Text = "Tải lại danh sách từ file";
            this.tsmiTaiLai.Click += new System.EventHandler(this.tsmiTaiLai_Click);
            // 
            // lblDinhDang
            // 
            this.lblDinhDang.AutoSize = true;
            this.lblDinhDang.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDinhDang.Location = new System.Drawing.Point(30, 314);
            this.lblDinhDang.Name = "lblDinhDang";
            this.lblDinhDang.Size = new System.Drawing.Size(97, 19);
            this.lblDinhDang.TabIndex = 25;
            this.lblDinhDang.Text = "Định dạng file:";
            // 
            // cboDinhDangFile
            // 
            this.cboDinhDangFile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDinhDangFile.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDinhDangFile.FormattingEnabled = true;
            this.cboDinhDangFile.Items.AddRange(new object[] {
            "JSON (students.json)",
            "XML (students.xml)",
            "TXT (students.txt)"});
            this.cboDinhDangFile.Location = new System.Drawing.Point(135, 310);
            this.cboDinhDangFile.Name = "cboDinhDangFile";
            this.cboDinhDangFile.Size = new System.Drawing.Size(130, 27);
            this.cboDinhDangFile.TabIndex = 26;
            this.cboDinhDangFile.SelectedIndexChanged += new System.EventHandler(this.cboDinhDangFile_SelectedIndexChanged);
            // 
            // pnlGioiTinh
            // 
            this.pnlGioiTinh.Controls.Add(this.rbNam);
            this.pnlGioiTinh.Controls.Add(this.rbNu);
            this.pnlGioiTinh.Location = new System.Drawing.Point(485, 22);
            this.pnlGioiTinh.Name = "pnlGioiTinh";
            this.pnlGioiTinh.Size = new System.Drawing.Size(160, 26);
            this.pnlGioiTinh.TabIndex = 3;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslTongSV,
            this.tsslFileDangDung});
            this.statusStrip1.Location = new System.Drawing.Point(0, 595);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(784, 26);
            this.statusStrip1.TabIndex = 27;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsslTongSV
            // 
            this.tsslTongSV.Name = "tsslTongSV";
            this.tsslTongSV.Size = new System.Drawing.Size(138, 20);
            this.tsslTongSV.Text = "Tổng số sinh viên: 0";
            // 
            // tsslFileDangDung
            // 
            this.tsslFileDangDung.Name = "tsslFileDangDung";
            this.tsslFileDangDung.Size = new System.Drawing.Size(136, 20);
            this.tsslFileDangDung.Text = " | File: students.json";
            // 
            // frmSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 621);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pnlGioiTinh);
            this.Controls.Add(this.cboDinhDangFile);
            this.Controls.Add(this.lblDinhDang);
            this.Controls.Add(this.grpDanhSach);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnThemMoi);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.clbMonHoc);
            this.Controls.Add(this.lblMonHoc);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.lblDiaChi);
            this.Controls.Add(this.mtbSDT);
            this.Controls.Add(this.lblSDT);
            this.Controls.Add(this.mtbCMND);
            this.Controls.Add(this.lblCMND);
            this.Controls.Add(this.cboLop);
            this.Controls.Add(this.lblLop);
            this.Controls.Add(this.dtpNgaySinh);
            this.Controls.Add(this.lblNgaySinh);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.lblTen);
            this.Controls.Add(this.txtHoVaTenLot);
            this.Controls.Add(this.lblHoVaTenLot);
            this.Controls.Add(this.lblGioiTinh);
            this.Controls.Add(this.mtbMSSV);
            this.Controls.Add(this.lblMSSV);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(800, 660);
            this.Name = "frmSinhVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhập thông tin sinh viên";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSinhVien_FormClosing);
            this.Load += new System.EventHandler(this.frmSinhVien_Load);
            this.ctxMonHoc.ResumeLayout(false);
            this.grpDanhSach.ResumeLayout(false);
            this.ctxListView.ResumeLayout(false);
            this.pnlGioiTinh.ResumeLayout(false);
            this.pnlGioiTinh.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMSSV;
        private System.Windows.Forms.MaskedTextBox mtbMSSV;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.RadioButton rbNam;
        private System.Windows.Forms.RadioButton rbNu;
        private System.Windows.Forms.Label lblHoVaTenLot;
        private System.Windows.Forms.TextBox txtHoVaTenLot;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Label lblLop;
        private System.Windows.Forms.ComboBox cboLop;
        private System.Windows.Forms.Label lblCMND;
        private System.Windows.Forms.MaskedTextBox mtbCMND;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.MaskedTextBox mtbSDT;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label lblMonHoc;
        private System.Windows.Forms.CheckedListBox clbMonHoc;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnThemMoi;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.GroupBox grpDanhSach;
        private System.Windows.Forms.ListView lvSinhVien;
        private System.Windows.Forms.ColumnHeader colMSSV;
        private System.Windows.Forms.ColumnHeader colHoLot;
        private System.Windows.Forms.ColumnHeader colTen;
        private System.Windows.Forms.ColumnHeader colNgaySinh;
        private System.Windows.Forms.ColumnHeader colLop;
        private System.Windows.Forms.ColumnHeader colCMND;
        private System.Windows.Forms.ColumnHeader colSDT;
        private System.Windows.Forms.ColumnHeader colDiaChi;
        private System.Windows.Forms.ContextMenuStrip ctxMonHoc;
        private System.Windows.Forms.ToolStripMenuItem tsmiThemMon;
        private System.Windows.Forms.ToolStripMenuItem tsmiXoaMon;
        private System.Windows.Forms.ContextMenuStrip ctxListView;
        private System.Windows.Forms.ToolStripMenuItem tsmiXoaSinhVien;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmiChonTatCa;
        private System.Windows.Forms.ToolStripMenuItem tsmiBoChonTatCa;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem tsmiTaiLai;
        private System.Windows.Forms.Label lblDinhDang;
        private System.Windows.Forms.ComboBox cboDinhDangFile;
        private System.Windows.Forms.Panel pnlGioiTinh;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsslTongSV;
        private System.Windows.Forms.ToolStripStatusLabel tsslFileDangDung;
    }
}

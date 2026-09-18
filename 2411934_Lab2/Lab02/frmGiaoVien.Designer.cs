namespace Lab02
{
    partial class frmGiaoVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGiaoVien));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboMaSo = new System.Windows.Forms.ComboBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.rdNam = new System.Windows.Forms.RadioButton();
            this.rdNu = new System.Windows.Forms.RadioButton();
            this.mtxtSoDT = new System.Windows.Forms.MaskedTextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.chklbNgoaiNgu = new System.Windows.Forms.CheckedListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lbDanhSachMH = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnChon = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.linklblLienHe = new System.Windows.Forms.LinkLabel();
            this.lbMonHocDay = new System.Windows.Forms.ListBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnThêm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(116, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(503, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "THÔNG TIN GIÁO VIÊN KHOA CNTT";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Số";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Họ Tên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày Sinh";
            // 
            // cboMaSo
            // 
            this.cboMaSo.FormattingEnabled = true;
            this.cboMaSo.Items.AddRange(new object[] {
            "001",
            "002",
            "003",
            "004"});
            this.cboMaSo.Location = new System.Drawing.Point(139, 50);
            this.cboMaSo.Name = "cboMaSo";
            this.cboMaSo.Size = new System.Drawing.Size(165, 28);
            this.cboMaSo.TabIndex = 4;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(141, 102);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(218, 26);
            this.txtHoTen.TabIndex = 5;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySinh.Location = new System.Drawing.Point(136, 159);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(223, 26);
            this.dtpNgaySinh.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(426, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 23);
            this.label5.TabIndex = 7;
            this.label5.Text = "Giới Tính";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(426, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 23);
            this.label6.TabIndex = 8;
            this.label6.Text = "Số ĐT";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(426, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 23);
            this.label7.TabIndex = 9;
            this.label7.Text = "Địa chỉ mail";
            // 
            // rdNam
            // 
            this.rdNam.AutoSize = true;
            this.rdNam.Checked = true;
            this.rdNam.Location = new System.Drawing.Point(552, 55);
            this.rdNam.Name = "rdNam";
            this.rdNam.Size = new System.Drawing.Size(67, 24);
            this.rdNam.TabIndex = 10;
            this.rdNam.TabStop = true;
            this.rdNam.Text = "Nam";
            this.rdNam.UseVisualStyleBackColor = true;
            // 
            // rdNu
            // 
            this.rdNu.AutoSize = true;
            this.rdNu.Location = new System.Drawing.Point(635, 55);
            this.rdNu.Name = "rdNu";
            this.rdNu.Size = new System.Drawing.Size(54, 24);
            this.rdNu.TabIndex = 11;
            this.rdNu.Text = "Nữ";
            this.rdNu.UseVisualStyleBackColor = true;
            // 
            // mtxtSoDT
            // 
            this.mtxtSoDT.Location = new System.Drawing.Point(552, 99);
            this.mtxtSoDT.Mask = "(/0633).000.000";
            this.mtxtSoDT.Name = "mtxtSoDT";
            this.mtxtSoDT.Size = new System.Drawing.Size(211, 26);
            this.mtxtSoDT.TabIndex = 12;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(552, 161);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(215, 26);
            this.txtMail.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 211);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 23);
            this.label8.TabIndex = 14;
            this.label8.Text = "Ngoại Ngữ";
            // 
            // chklbNgoaiNgu
            // 
            this.chklbNgoaiNgu.FormattingEnabled = true;
            this.chklbNgoaiNgu.Items.AddRange(new object[] {
            "Tiếng Anh",
            "Tiếng Pháp",
            "Tiếng Nhật",
            "Tiếng Nga"});
            this.chklbNgoaiNgu.Location = new System.Drawing.Point(140, 217);
            this.chklbNgoaiNgu.Name = "chklbNgoaiNgu";
            this.chklbNgoaiNgu.Size = new System.Drawing.Size(146, 96);
            this.chklbNgoaiNgu.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(137, 337);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(170, 23);
            this.label9.TabIndex = 16;
            this.label9.Text = "Danh sách môn học";
            // 
            // lbDanhSachMH
            // 
            this.lbDanhSachMH.FormattingEnabled = true;
            this.lbDanhSachMH.ItemHeight = 20;
            this.lbDanhSachMH.Items.AddRange(new object[] {
            "Tin học cơ sở",
            "Lập trình cấu trúc C/C++",
            "Cơ sở dữ liệu",
            "Tiếng Anh B1",
            "Tiếng Anh B2",
            "Lập trình hướng đối tượng",
            "Mạng máy tính",
            "Công nghệ phần mềm",
            "Phân tích TKHDT"});
            this.lbDanhSachMH.Location = new System.Drawing.Point(140, 372);
            this.lbDanhSachMH.Name = "lbDanhSachMH";
            this.lbDanhSachMH.Size = new System.Drawing.Size(192, 184);
            this.lbDanhSachMH.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(458, 337);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(196, 23);
            this.label10.TabIndex = 18;
            this.label10.Text = "Môn học giáo viên dạy";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // btnChon
            // 
            this.btnChon.Location = new System.Drawing.Point(355, 389);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(68, 40);
            this.btnChon.TabIndex = 20;
            this.btnChon.Text = ">>";
            this.btnChon.UseVisualStyleBackColor = true;
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(355, 458);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(68, 40);
            this.btnXoa.TabIndex = 21;
            this.btnXoa.Text = "<<";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.Blue;
            this.btnLuu.Location = new System.Drawing.Point(319, 597);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(111, 36);
            this.btnLuu.TabIndex = 22;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Blue;
            this.btnExit.Location = new System.Drawing.Point(618, 597);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(111, 36);
            this.btnExit.TabIndex = 23;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Blue;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(462, 597);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(141, 36);
            this.btnCancel.TabIndex = 24;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(566, 646);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 23);
            this.label11.TabIndex = 25;
            this.label11.Text = "Website";
            // 
            // linklblLienHe
            // 
            this.linklblLienHe.AutoSize = true;
            this.linklblLienHe.Location = new System.Drawing.Point(683, 646);
            this.linklblLienHe.Name = "linklblLienHe";
            this.linklblLienHe.Size = new System.Drawing.Size(61, 20);
            this.linklblLienHe.TabIndex = 26;
            this.linklblLienHe.TabStop = true;
            this.linklblLienHe.Text = "Liên hệ";
            this.linklblLienHe.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblLienHe_LinkClicked);
            // 
            // lbMonHocDay
            // 
            this.lbMonHocDay.FormattingEnabled = true;
            this.lbMonHocDay.ItemHeight = 20;
            this.lbMonHocDay.Location = new System.Drawing.Point(466, 372);
            this.lbMonHocDay.Name = "lbMonHocDay";
            this.lbMonHocDay.Size = new System.Drawing.Size(188, 184);
            this.lbMonHocDay.TabIndex = 27;
            // 
            // btnTim
            // 
            this.btnTim.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.ForeColor = System.Drawing.Color.Blue;
            this.btnTim.Location = new System.Drawing.Point(16, 597);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(111, 36);
            this.btnTim.TabIndex = 28;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // btnThêm
            // 
            this.btnThêm.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThêm.ForeColor = System.Drawing.Color.Blue;
            this.btnThêm.Location = new System.Drawing.Point(175, 597);
            this.btnThêm.Name = "btnThêm";
            this.btnThêm.Size = new System.Drawing.Size(111, 36);
            this.btnThêm.TabIndex = 29;
            this.btnThêm.Text = "Thêm";
            this.btnThêm.UseVisualStyleBackColor = true;
            this.btnThêm.Click += new System.EventHandler(this.btnThêm_Click);
            // 
            // frmGiaoVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 678);
            this.Controls.Add(this.btnThêm);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.lbMonHocDay);
            this.Controls.Add(this.linklblLienHe);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnChon);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lbDanhSachMH);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.chklbNgoaiNgu);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.mtxtSoDT);
            this.Controls.Add(this.rdNu);
            this.Controls.Add(this.rdNam);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpNgaySinh);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.cboMaSo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmGiaoVien";
            this.Text = "frmGiaoVien";
            this.Load += new System.EventHandler(this.frmGiaoVien_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboMaSo;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rdNam;
        private System.Windows.Forms.RadioButton rdNu;
        private System.Windows.Forms.MaskedTextBox mtxtSoDT;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckedListBox chklbNgoaiNgu;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox lbDanhSachMH;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnChon;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.LinkLabel linklblLienHe;
        private System.Windows.Forms.ListBox lbMonHocDay;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btnThêm;
    }
}
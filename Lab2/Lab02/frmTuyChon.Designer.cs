namespace Lab02
{
    partial class frmTuyChon
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
            this.groupBoxKieu = new System.Windows.Forms.GroupBox();
            this.rdNgaySinh = new System.Windows.Forms.RadioButton();
            this.rdHoTen = new System.Windows.Forms.RadioButton();
            this.rdMaSV = new System.Windows.Forms.RadioButton();
            this.groupBoxTim = new System.Windows.Forms.GroupBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.txtNhapThongTin = new System.Windows.Forms.TextBox();
            this.lblNhapThongTin = new System.Windows.Forms.Label();
            this.btnSapXep = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBoxKieu.SuspendLayout();
            this.groupBoxTim.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxKieu
            // 
            this.groupBoxKieu.Controls.Add(this.rdNgaySinh);
            this.groupBoxKieu.Controls.Add(this.rdHoTen);
            this.groupBoxKieu.Controls.Add(this.rdMaSV);
            this.groupBoxKieu.Location = new System.Drawing.Point(16, 15);
            this.groupBoxKieu.Name = "groupBoxKieu";
            this.groupBoxKieu.Size = new System.Drawing.Size(390, 56);
            this.groupBoxKieu.TabIndex = 0;
            this.groupBoxKieu.TabStop = false;
            // 
            // rdNgaySinh
            // 
            this.rdNgaySinh.AutoSize = true;
            this.rdNgaySinh.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdNgaySinh.ForeColor = System.Drawing.Color.MediumBlue;
            this.rdNgaySinh.Location = new System.Drawing.Point(268, 20);
            this.rdNgaySinh.Name = "rdNgaySinh";
            this.rdNgaySinh.Size = new System.Drawing.Size(103, 23);
            this.rdNgaySinh.TabIndex = 2;
            this.rdNgaySinh.TabStop = true;
            this.rdNgaySinh.Text = "Ngày Sinh";
            this.rdNgaySinh.UseVisualStyleBackColor = true;
            this.rdNgaySinh.Click += new System.EventHandler(this.rdTuyChon_Click);
            // 
            // rdHoTen
            // 
            this.rdHoTen.AutoSize = true;
            this.rdHoTen.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdHoTen.ForeColor = System.Drawing.Color.MediumBlue;
            this.rdHoTen.Location = new System.Drawing.Point(145, 20);
            this.rdHoTen.Name = "rdHoTen";
            this.rdHoTen.Size = new System.Drawing.Size(83, 23);
            this.rdHoTen.TabIndex = 1;
            this.rdHoTen.TabStop = true;
            this.rdHoTen.Text = "Họ Tên";
            this.rdHoTen.UseVisualStyleBackColor = true;
            this.rdHoTen.Click += new System.EventHandler(this.rdTuyChon_Click);
            // 
            // rdMaSV
            // 
            this.rdMaSV.AutoSize = true;
            this.rdMaSV.Checked = true;
            this.rdMaSV.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdMaSV.ForeColor = System.Drawing.Color.MediumBlue;
            this.rdMaSV.Location = new System.Drawing.Point(23, 20);
            this.rdMaSV.Name = "rdMaSV";
            this.rdMaSV.Size = new System.Drawing.Size(78, 23);
            this.rdMaSV.TabIndex = 0;
            this.rdMaSV.TabStop = true;
            this.rdMaSV.Text = "Mã SV";
            this.rdMaSV.UseVisualStyleBackColor = true;
            this.rdMaSV.Click += new System.EventHandler(this.rdTuyChon_Click);
            // 
            // groupBoxTim
            // 
            this.groupBoxTim.Controls.Add(this.btnTim);
            this.groupBoxTim.Controls.Add(this.txtNhapThongTin);
            this.groupBoxTim.Controls.Add(this.lblNhapThongTin);
            this.groupBoxTim.Location = new System.Drawing.Point(16, 77);
            this.groupBoxTim.Name = "groupBoxTim";
            this.groupBoxTim.Size = new System.Drawing.Size(390, 56);
            this.groupBoxTim.TabIndex = 1;
            this.groupBoxTim.TabStop = false;
            // 
            // btnTim
            // 
            this.btnTim.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.ForeColor = System.Drawing.Color.Purple;
            this.btnTim.Location = new System.Drawing.Point(313, 17);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(68, 29);
            this.btnTim.TabIndex = 2;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // txtNhapThongTin
            // 
            this.txtNhapThongTin.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhapThongTin.Location = new System.Drawing.Point(135, 18);
            this.txtNhapThongTin.Name = "txtNhapThongTin";
            this.txtNhapThongTin.Size = new System.Drawing.Size(167, 27);
            this.txtNhapThongTin.TabIndex = 1;
            // 
            // lblNhapThongTin
            // 
            this.lblNhapThongTin.AutoSize = true;
            this.lblNhapThongTin.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhapThongTin.Location = new System.Drawing.Point(10, 22);
            this.lblNhapThongTin.Name = "lblNhapThongTin";
            this.lblNhapThongTin.Size = new System.Drawing.Size(117, 19);
            this.lblNhapThongTin.TabIndex = 0;
            this.lblNhapThongTin.Text = "Nhập Thông tin";
            // 
            // btnSapXep
            // 
            this.btnSapXep.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSapXep.ForeColor = System.Drawing.Color.Purple;
            this.btnSapXep.Location = new System.Drawing.Point(62, 149);
            this.btnSapXep.Name = "btnSapXep";
            this.btnSapXep.Size = new System.Drawing.Size(100, 34);
            this.btnSapXep.TabIndex = 2;
            this.btnSapXep.Text = "Sắp Xếp";
            this.btnSapXep.UseVisualStyleBackColor = true;
            this.btnSapXep.Click += new System.EventHandler(this.btnSapXep_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.Purple;
            this.btnThoat.Location = new System.Drawing.Point(250, 149);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(100, 34);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmTuyChon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 198);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnSapXep);
            this.Controls.Add(this.groupBoxTim);
            this.Controls.Add(this.groupBoxKieu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTuyChon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tùy chọn";
            this.Load += new System.EventHandler(this.frmTuyChon_Load);
            this.groupBoxKieu.ResumeLayout(false);
            this.groupBoxKieu.PerformLayout();
            this.groupBoxTim.ResumeLayout(false);
            this.groupBoxTim.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.GroupBox groupBoxKieu;
        public System.Windows.Forms.RadioButton rdNgaySinh;
        public System.Windows.Forms.RadioButton rdHoTen;
        public System.Windows.Forms.RadioButton rdMaSV;
        public System.Windows.Forms.GroupBox groupBoxTim;
        public System.Windows.Forms.Button btnTim;
        public System.Windows.Forms.TextBox txtNhapThongTin;
        public System.Windows.Forms.Label lblNhapThongTin;
        public System.Windows.Forms.Button btnSapXep;
        public System.Windows.Forms.Button btnThoat;
    }
}

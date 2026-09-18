namespace Lab02
{
    partial class frmTuyChon
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdNgaySinh = new System.Windows.Forms.RadioButton();
            this.rdHoTen = new System.Windows.Forms.RadioButton();
            this.rdMaSV = new System.Windows.Forms.RadioButton();
            this.groupBoxTim = new System.Windows.Forms.GroupBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSapXep = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBoxTim.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdNgaySinh);
            this.groupBox1.Controls.Add(this.rdHoTen);
            this.groupBox1.Controls.Add(this.rdMaSV);
            this.groupBox1.Location = new System.Drawing.Point(34, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(437, 76);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // rdNgaySinh
            // 
            this.rdNgaySinh.AutoSize = true;
            this.rdNgaySinh.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdNgaySinh.ForeColor = System.Drawing.Color.Blue;
            this.rdNgaySinh.Location = new System.Drawing.Point(298, 30);
            this.rdNgaySinh.Name = "rdNgaySinh";
            this.rdNgaySinh.Size = new System.Drawing.Size(103, 23);
            this.rdNgaySinh.TabIndex = 2;
            this.rdNgaySinh.TabStop = true;
            this.rdNgaySinh.Text = "Ngày Sinh";
            this.rdNgaySinh.UseVisualStyleBackColor = true;
            this.rdNgaySinh.CheckedChanged += new System.EventHandler(this.rdTuyChon_CheckedChanged);
            // 
            // rdHoTen
            // 
            this.rdHoTen.AutoSize = true;
            this.rdHoTen.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdHoTen.ForeColor = System.Drawing.Color.Blue;
            this.rdHoTen.Location = new System.Drawing.Point(162, 30);
            this.rdHoTen.Name = "rdHoTen";
            this.rdHoTen.Size = new System.Drawing.Size(83, 23);
            this.rdHoTen.TabIndex = 1;
            this.rdHoTen.TabStop = true;
            this.rdHoTen.Text = "Họ Tên";
            this.rdHoTen.UseVisualStyleBackColor = true;
            this.rdHoTen.CheckedChanged += new System.EventHandler(this.rdTuyChon_CheckedChanged);
            // 
            // rdMaSV
            // 
            this.rdMaSV.AutoSize = true;
            this.rdMaSV.Checked = true;
            this.rdMaSV.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdMaSV.ForeColor = System.Drawing.Color.Blue;
            this.rdMaSV.Location = new System.Drawing.Point(26, 30);
            this.rdMaSV.Name = "rdMaSV";
            this.rdMaSV.Size = new System.Drawing.Size(79, 23);
            this.rdMaSV.TabIndex = 0;
            this.rdMaSV.TabStop = true;
            this.rdMaSV.Text = "Mã SV";
            this.rdMaSV.UseVisualStyleBackColor = true;
            this.rdMaSV.CheckedChanged += new System.EventHandler(this.rdTuyChon_CheckedChanged);
            // 
            // groupBoxTim
            // 
            this.groupBoxTim.Controls.Add(this.btnTim);
            this.groupBoxTim.Controls.Add(this.txtTimKiem);
            this.groupBoxTim.Controls.Add(this.label1);
            this.groupBoxTim.Location = new System.Drawing.Point(34, 116);
            this.groupBoxTim.Name = "groupBoxTim";
            this.groupBoxTim.Size = new System.Drawing.Size(437, 76);
            this.groupBoxTim.TabIndex = 1;
            this.groupBoxTim.TabStop = false;
            // 
            // btnTim
            // 
            this.btnTim.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.ForeColor = System.Drawing.Color.Purple;
            this.btnTim.Location = new System.Drawing.Point(354, 25);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(71, 31);
            this.btnTim.TabIndex = 2;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(145, 27);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(193, 27);
            this.txtTimKiem.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập Thông tin";
            // 
            // btnSapXep
            // 
            this.btnSapXep.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSapXep.ForeColor = System.Drawing.Color.Purple;
            this.btnSapXep.Location = new System.Drawing.Point(92, 215);
            this.btnSapXep.Name = "btnSapXep";
            this.btnSapXep.Size = new System.Drawing.Size(110, 36);
            this.btnSapXep.TabIndex = 2;
            this.btnSapXep.Text = "Sắp Xếp";
            this.btnSapXep.UseVisualStyleBackColor = true;
            this.btnSapXep.Click += new System.EventHandler(this.btnSapXep_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.Purple;
            this.btnThoat.Location = new System.Drawing.Point(296, 215);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(110, 36);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmTuyChon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 275);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnSapXep);
            this.Controls.Add(this.groupBoxTim);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTuyChon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tùy chọn";
            this.Load += new System.EventHandler(this.frmTuyChon_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxTim.ResumeLayout(false);
            this.groupBoxTim.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdNgaySinh;
        private System.Windows.Forms.RadioButton rdHoTen;
        private System.Windows.Forms.RadioButton rdMaSV;
        private System.Windows.Forms.GroupBox groupBoxTim;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSapXep;
        private System.Windows.Forms.Button btnThoat;
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02
{
    public partial class frmGiaoVien : Form
    {
        public frmGiaoVien()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
        public QuanLyGiaoVien dsGV = new QuanLyGiaoVien();

        private void frmGiaoVien_Load(object sender, EventArgs e)
        {
            string lienhe = "https://cntt.dlu.edu.vn/";
            this.linklblLienHe.Links.Clear();
            this.linklblLienHe.Links.Add(0, this.linklblLienHe.Text.Length, lienhe);
            if (this.cboMaSo.Items.Count > 0)
                this.cboMaSo.SelectedIndex = 0;
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            while (this.lbDanhSachMH.SelectedItems.Count > 0)
            {
                object item = this.lbDanhSachMH.SelectedItems[0];
                this.lbMonHocDay.Items.Add(item);
                this.lbDanhSachMH.Items.Remove(item);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            while (this.lbMonHocDay.SelectedItems.Count > 0)
            {
                object item = this.lbMonHocDay.SelectedItems[0];
                this.lbDanhSachMH.Items.Add(item);
                this.lbMonHocDay.Items.Remove(item);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Reset();
        }

        public void Reset()
        {
            this.cboMaSo.Text = "";
            this.txtHoTen.Text = "";
            this.txtMail.Text = "";
            this.mtxtSoDT.Text = "";
            this.rdNam.Checked = true;

            for (int i = 0; i < chklbNgoaiNgu.Items.Count; i++)
                chklbNgoaiNgu.SetItemChecked(i, false);

            foreach (object ob in this.lbMonHocDay.Items)
                this.lbDanhSachMH.Items.Add(ob);
            this.lbMonHocDay.Items.Clear();
        }

        private void linklblLienHe_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                string s = e.Link.LinkData.ToString();
                Process.Start(s);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể mở liên kết: " + ex.Message);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            frmTBGiaoVien frm = new frmTBGiaoVien();
            frm.SetText(GetGiaoVien().ToString());
            frm.ShowDialog();
        }

        public GiaoVien GetGiaoVien()
        {
            string gt = "Nam";
            if (rdNu.Checked)
                gt = "Nữ";
            GiaoVien gv = new GiaoVien();
            gv.MaSo = this.cboMaSo.Text;
            gv.GioiTinh = gt;
            gv.HoTen = this.txtHoTen.Text;
            gv.NgaySinh = this.dtpNgaySinh.Value;
            gv.Mail = this.txtMail.Text;
            gv.SoDT = this.mtxtSoDT.Text;

            List<string> nn = new List<string>();
            for (int i = 0; i < chklbNgoaiNgu.Items.Count; i++)
            {
                if (chklbNgoaiNgu.GetItemChecked(i))
                    nn.Add(chklbNgoaiNgu.Items[i].ToString());
            }
            gv.NgoaiNgu = nn.ToArray();

            DanhSachMonHoc mh = new DanhSachMonHoc();
            foreach (object ob in lbMonHocDay.Items)
            {
                mh.Them(new MonHoc(ob.ToString()));
            }
            gv.dsMonHoc = mh;
            return gv;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThêm_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.cboMaSo.Text))
            {
                MessageBox.Show("Vui lòng chọn hoặc nhập Mã giáo viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(this.txtHoTen.Text))
            {
                MessageBox.Show("Vui lòng nhập Họ tên giáo viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            GiaoVien gv = GetGiaoVien();
            if (dsGV.Them(gv))
            {
                MessageBox.Show("Thêm giáo viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Mã giáo viên đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            frmTimKiem timKiem = new frmTimKiem(dsGV.dsGiaoVien);
            timKiem.ShowDialog();
        }
    }

    }

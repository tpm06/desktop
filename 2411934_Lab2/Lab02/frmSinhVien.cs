using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02
{
    public partial class frmSinhVien : Form
    {
        public QuanLySinhVien qlsv;

        public frmSinhVien()
        {
            InitializeComponent();
        }

        private void frmSinhVien_Load(object sender, EventArgs e)
        {
            qlsv = new QuanLySinhVien();
            string path = "DanhSachSV.txt";
            if (!File.Exists(path))
                path = Path.Combine(Application.StartupPath, "DanhSachSV.txt");
            if (!File.Exists(path))
                path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DanhSachSV.txt");

            qlsv.DocTuFile(path);
            LoadListView();
            CapNhatTongSV();
            if (this.cboLop.Items.Count > 0)
                this.cboLop.SelectedIndex = 0;

            if (this.lvSinhVien.Items.Count > 0)
            {
                this.lvSinhVien.Items[0].Selected = true;
            }
        }

        private void CapNhatTongSV()
        {
            int sl = qlsv != null && qlsv.dsSinhVien != null ? qlsv.dsSinhVien.Count : 0;
            this.toolStripStatusLabelTongSV.Text = "Tổng Sinh Viên: " + sl;
        }

        private void ThemSV(SinhVien sv)
        {
            ListViewItem lvitem = new ListViewItem(sv.MaSo);
            lvitem.SubItems.Add(sv.HoTen);
            lvitem.SubItems.Add(sv.NgaySinh.ToString("dd/MM/yyyy"));
            lvitem.SubItems.Add(sv.DiaChi);
            lvitem.SubItems.Add(sv.Lop);
            string gt = sv.GioiTinh ? "Nam" : "Nữ";
            lvitem.SubItems.Add(gt);
            string cn = string.Join(", ", sv.ChuyenNganh);
            lvitem.SubItems.Add(cn);
            lvitem.SubItems.Add(sv.Hinh);
            this.lvSinhVien.Items.Add(lvitem);
        }

        private void LoadListView()
        {
            this.lvSinhVien.Items.Clear();
            foreach (SinhVien sv in qlsv.dsSinhVien)
            {
                ThemSV(sv);
            }
            CapNhatTongSV();
        }

        private SinhVien GetSinhVien()
        {
            SinhVien sv = new SinhVien();
            bool gt = true;
            List<string> cn = new List<string>();
            sv.MaSo = this.mtxtMaSo.Text;
            sv.HoTen = this.txtHoTen.Text;
            sv.NgaySinh = this.dtpNgaySinh.Value;
            sv.DiaChi = this.txtDiaChi.Text;
            sv.Lop = this.cboLop.Text;
            sv.Hinh = this.txtHinh.Text;
            if (rdNu.Checked)
                gt = false;
            sv.GioiTinh = gt;

            for (int i = 0; i < this.clbChuyenNganh.Items.Count; i++)
            {
                if (clbChuyenNganh.GetItemChecked(i))
                    cn.Add(clbChuyenNganh.Items[i].ToString());
            }
            sv.ChuyenNganh = cn;
            return sv;
        }

        private SinhVien GetSinhVienLV(ListViewItem lvitem)
        {
            SinhVien sv = new SinhVien();
            sv.MaSo = lvitem.SubItems[0].Text;
            sv.HoTen = lvitem.SubItems[1].Text;
            DateTime ns;
            string[] formats = { "dd/MM/yyyy", "d/M/yyyy", "MM/dd/yyyy", "M/d/yyyy", "yyyy-MM-dd" };
            if (DateTime.TryParseExact(lvitem.SubItems[2].Text.Trim(), formats, CultureInfo.InvariantCulture, DateTimeStyles.None, out ns) ||
                DateTime.TryParse(lvitem.SubItems[2].Text.Trim(), CultureInfo.InvariantCulture, DateTimeStyles.None, out ns) ||
                DateTime.TryParse(lvitem.SubItems[2].Text.Trim(), out ns))
            {
                sv.NgaySinh = ns;
            }
            else
            {
                sv.NgaySinh = DateTime.Now;
            }
            sv.DiaChi = lvitem.SubItems[3].Text;
            sv.Lop = lvitem.SubItems[4].Text;
            sv.GioiTinh = false;
            if (lvitem.SubItems[5].Text == "Nam")
                sv.GioiTinh = true;

            List<string> cn = new List<string>();
            string[] s = lvitem.SubItems[6].Text.Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string t in s)
                cn.Add(t);
            sv.ChuyenNganh = cn;
            if (lvitem.SubItems.Count > 7)
                sv.Hinh = lvitem.SubItems[7].Text;
            return sv;
        }

        private void ThietLapThongTin(SinhVien sv)
        {
            this.mtxtMaSo.Text = sv.MaSo;
            this.txtHoTen.Text = sv.HoTen;
            this.dtpNgaySinh.Value = sv.NgaySinh;
            this.txtDiaChi.Text = sv.DiaChi;
            this.cboLop.Text = sv.Lop;
            this.txtHinh.Text = sv.Hinh;

            // Load picture
            LoadAnh(sv.Hinh);

            if (sv.GioiTinh)
                this.rdNam.Checked = true;
            else
                this.rdNu.Checked = true;

            for (int i = 0; i < this.clbChuyenNganh.Items.Count; i++)
                this.clbChuyenNganh.SetItemChecked(i, false);

            foreach (string s in sv.ChuyenNganh)
            {
                for (int i = 0; i < this.clbChuyenNganh.Items.Count; i++)
                {
                    if (string.Compare(s.Trim(), this.clbChuyenNganh.Items[i].ToString().Trim(), true) == 0)
                        this.clbChuyenNganh.SetItemChecked(i, true);
                }
            }
        }

        private void LoadAnh(string tenHinh)
        {
            if (string.IsNullOrWhiteSpace(tenHinh))
            {
                this.pbHinh.Image = null;
                return;
            }

            try
            {
                string path = tenHinh;
                if (!File.Exists(path))
                    path = Path.Combine(Application.StartupPath, tenHinh);
                if (!File.Exists(path))
                    path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, tenHinh);
                if (!File.Exists(path))
                    path = Path.Combine(Application.StartupPath, "bin", "Debug", tenHinh);

                if (File.Exists(path))
                    this.pbHinh.ImageLocation = path;
                else
                    this.pbHinh.Image = null;
            }
            catch
            {
                this.pbHinh.Image = null;
            }
        }

        private void lvSinhVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            int count = this.lvSinhVien.SelectedItems.Count;
            if (count > 0)
            {
                ListViewItem lvitem = this.lvSinhVien.SelectedItems[0];
                SinhVien sv = GetSinhVienLV(lvitem);
                ThietLapThongTin(sv);
            }
        }

        private int SoSanhTheoMa(object sv1, object sv2)
        {
            SinhVien sv = sv2 as SinhVien;
            if (sv == null) return -1;
            return string.Compare(sv.MaSo, sv1.ToString(), true);
        }

        private void btnMacDinh_Click(object sender, EventArgs e)
        {
            this.mtxtMaSo.Text = "";
            this.txtHoTen.Text = "";
            this.dtpNgaySinh.Value = DateTime.Now;
            this.txtDiaChi.Text = "";
            if (this.cboLop.Items.Count > 0)
                this.cboLop.SelectedIndex = 0;
            this.txtHinh.Text = "";
            this.pbHinh.Image = null;
            this.rdNam.Checked = true;
            for (int i = 0; i < this.clbChuyenNganh.Items.Count; i++)
                this.clbChuyenNganh.SetItemChecked(i, false);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string ma = this.mtxtMaSo.Text.Trim();
            if (string.IsNullOrWhiteSpace(ma) || ma == "SV.")
            {
                MessageBox.Show("Vui lòng nhập Mã số sinh viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.mtxtMaSo.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(this.txtHoTen.Text))
            {
                MessageBox.Show("Vui lòng nhập Họ tên sinh viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtHoTen.Focus();
                return;
            }

            SinhVien sv = GetSinhVien();
            SinhVien kq = qlsv.Tim(sv.MaSo, SoSanhTheoMa);
            if (kq != null)
            {
                MessageBox.Show("Mã sinh viên đã tồn tại!", "Lỗi thêm dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.qlsv.Them(sv);
                this.LoadListView();
                this.CapNhatTongSV();
                MessageBox.Show("Thêm sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int count = this.lvSinhVien.Items.Count - 1;
            bool coXoa = false;
            for (int i = count; i >= 0; i--)
            {
                ListViewItem lvitem = this.lvSinhVien.Items[i];
                if (lvitem.Checked)
                {
                    qlsv.Xoa(lvitem.SubItems[0].Text, SoSanhTheoMa);
                    coXoa = true;
                }
            }

            if (coXoa)
            {
                this.LoadListView();
                this.btnMacDinh.PerformClick();
                this.CapNhatTongSV();
                MessageBox.Show("Đã xóa các sinh viên được chọn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Vui lòng đánh dấu chọn (check) các sinh viên cần xóa trong danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            SinhVien sv = GetSinhVien();
            bool kqsua = qlsv.Sua(sv, sv.MaSo, SoSanhTheoMa);
            if (kqsua)
            {
                this.LoadListView();
                MessageBox.Show("Cập nhật thông tin sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Không tìm thấy sinh viên có mã tương ứng để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Hãy Chọn File";
            dlg.Filter = "Image File(*.bmp;*.jpg;*.png)|*.bmp;*.jpg;*.png|All File(*.*)|*.*";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                this.txtHinh.Text = dlg.SafeFileName;
                this.pbHinh.ImageLocation = dlg.FileName;
            }
        }

        private void moFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnBrowse.PerformClick();
        }

        private void thoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

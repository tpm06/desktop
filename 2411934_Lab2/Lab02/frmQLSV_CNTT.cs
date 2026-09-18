using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02
{
    public partial class frmQLSV_CNTT : Form
    {
        private List<SinhVienCNTT> dsSinhVien = new List<SinhVienCNTT>();
        private bool isModified = false;
        private readonly string fileName = "DSNV.txt";

        public frmQLSV_CNTT()
        {
            InitializeComponent();
        }

        private void frmQLSV_CNTT_Load(object sender, EventArgs e)
        {
            if (this.cboLop.Items.Count > 0)
                this.cboLop.SelectedIndex = 0;

            DocFileDSNV();
            LoadListView();
            isModified = false;
        }

        private string GetFilePath()
        {
            if (File.Exists(fileName))
                return fileName;
            return Path.Combine(Application.StartupPath, fileName);
        }

        private void DocFileDSNV()
        {
            dsSinhVien.Clear();
            string path = GetFilePath();
            if (!File.Exists(path))
                return;

            try
            {
                using (StreamReader sr = new StreamReader(new FileStream(path, FileMode.Open), Encoding.UTF8))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        if (string.IsNullOrWhiteSpace(line)) continue;
                        string[] s = line.Split('\t');
                        if (s.Length >= 9)
                        {
                            SinhVienCNTT sv = new SinhVienCNTT();
                            sv.MSSV = s[0].Trim();
                            sv.HoTen = s[1].Trim();
                            sv.Phai = s[2].Trim();
                            DateTime ns;
                            if (DateTime.TryParse(s[3].Trim(), out ns))
                                sv.NgaySinh = ns;
                            else
                                sv.NgaySinh = DateTime.Now;
                            sv.Lop = s[4].Trim();
                            sv.SDT = s[5].Trim();
                            sv.Email = s[6].Trim();
                            sv.DiaChi = s[7].Trim();
                            sv.Hinh = s[8].Trim();
                            dsSinhVien.Add(sv);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi đọc file: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LuuFileDSNV()
        {
            string path = GetFilePath();
            try
            {
                using (StreamWriter sw = new StreamWriter(new FileStream(path, FileMode.Create), Encoding.UTF8))
                {
                    foreach (SinhVienCNTT sv in dsSinhVien)
                    {
                        string line = string.Format("{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}\t{7}\t{8}",
                            sv.MSSV, sv.HoTen, sv.Phai, sv.NgaySinh.ToString("dd/MM/yyyy"),
                            sv.Lop, sv.SDT, sv.Email, sv.DiaChi, sv.Hinh);
                        sw.WriteLine(line);
                    }
                }
                isModified = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi file: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadListView()
        {
            this.lvSinhVienCNTT.Items.Clear();
            foreach (SinhVienCNTT sv in dsSinhVien)
            {
                ListViewItem lvi = new ListViewItem(sv.MSSV);
                lvi.SubItems.Add(sv.HoTen);
                lvi.SubItems.Add(sv.Phai);
                lvi.SubItems.Add(sv.NgaySinh.ToString("dd/MM/yyyy"));
                lvi.SubItems.Add(sv.Lop);
                lvi.SubItems.Add(sv.SDT);
                lvi.SubItems.Add(sv.Email);
                lvi.SubItems.Add(sv.DiaChi);
                lvi.SubItems.Add(sv.Hinh);
                this.lvSinhVienCNTT.Items.Add(lvi);
            }
        }

        private SinhVienCNTT GetSinhVienTuForm()
        {
            SinhVienCNTT sv = new SinhVienCNTT();
            sv.MSSV = this.mtxtMSSV.Text.Trim();
            sv.HoTen = this.txtHoTen.Text.Trim();
            sv.Email = this.txtEmail.Text.Trim();
            sv.DiaChi = this.txtDiaChi.Text.Trim();
            sv.NgaySinh = this.dtpNgaySinh.Value;
            sv.Phai = this.rdNam.Checked ? "Nam" : "Nữ";
            sv.Lop = this.cboLop.Text.Trim();
            sv.SDT = this.mtxtSDT.Text.Trim();
            sv.Hinh = this.txtHinh.Text.Trim();
            return sv;
        }

        private void ThietLapThongTin(SinhVienCNTT sv)
        {
            this.mtxtMSSV.Text = sv.MSSV;
            this.txtHoTen.Text = sv.HoTen;
            this.txtEmail.Text = sv.Email;
            this.txtDiaChi.Text = sv.DiaChi;
            this.dtpNgaySinh.Value = sv.NgaySinh;
            if (sv.Phai == "Nam")
                this.rdNam.Checked = true;
            else
                this.rdNu.Checked = true;

            this.cboLop.Text = sv.Lop;
            this.mtxtSDT.Text = sv.SDT;
            this.txtHinh.Text = sv.Hinh;
            LoadAnh(sv.Hinh);
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

        private void lvSinhVienCNTT_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lvSinhVienCNTT.SelectedItems.Count > 0)
            {
                ListViewItem lvi = this.lvSinhVienCNTT.SelectedItems[0];
                SinhVienCNTT sv = new SinhVienCNTT();
                sv.MSSV = lvi.SubItems[0].Text;
                sv.HoTen = lvi.SubItems[1].Text;
                sv.Phai = lvi.SubItems[2].Text;
                DateTime ns;
                if (DateTime.TryParse(lvi.SubItems[3].Text, out ns))
                    sv.NgaySinh = ns;
                else
                    sv.NgaySinh = DateTime.Now;
                sv.Lop = lvi.SubItems[4].Text;
                sv.SDT = lvi.SubItems[5].Text;
                sv.Email = lvi.SubItems[6].Text;
                sv.DiaChi = lvi.SubItems[7].Text;
                sv.Hinh = lvi.SubItems.Count > 8 ? lvi.SubItems[8].Text : "";
                ThietLapThongTin(sv);
            }
        }

        private void btnChonHinh_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Chọn hình ảnh sinh viên";
            dlg.Filter = "Image File(*.bmp;*.jpg;*.png)|*.bmp;*.jpg;*.png|All File(*.*)|*.*";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                this.txtHinh.Text = dlg.SafeFileName;
                this.pbHinh.ImageLocation = dlg.FileName;
            }
        }

        private void btnMacDinh_Click(object sender, EventArgs e)
        {
            this.mtxtMSSV.Text = "";
            this.txtHoTen.Text = "";
            this.txtEmail.Text = "";
            this.txtDiaChi.Text = "";
            this.dtpNgaySinh.Value = DateTime.Now;
            this.rdNam.Checked = true;
            if (this.cboLop.Items.Count > 0)
                this.cboLop.SelectedIndex = 0;
            this.mtxtSDT.Text = "";
            this.txtHinh.Text = "";
            this.pbHinh.Image = null;
            this.mtxtMSSV.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string mssv = this.mtxtMSSV.Text.Trim();
            if (mssv.Length < 7)
            {
                MessageBox.Show("Mã sinh viên phải gồm 7 ký tự số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.mtxtMSSV.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(this.txtHoTen.Text))
            {
                MessageBox.Show("Vui lòng nhập Họ và tên sinh viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtHoTen.Focus();
                return;
            }

            SinhVienCNTT svMoi = GetSinhVienTuForm();
            SinhVienCNTT svTonTai = dsSinhVien.Find(x => string.Compare(x.MSSV, svMoi.MSSV, true) == 0);

            if (svTonTai != null)
            {
                // Cập nhật sinh viên đã có
                svTonTai.HoTen = svMoi.HoTen;
                svTonTai.Phai = svMoi.Phai;
                svTonTai.NgaySinh = svMoi.NgaySinh;
                svTonTai.Lop = svMoi.Lop;
                svTonTai.SDT = svMoi.SDT;
                svTonTai.Email = svMoi.Email;
                svTonTai.DiaChi = svMoi.DiaChi;
                svTonTai.Hinh = svMoi.Hinh;
                MessageBox.Show("Đã cập nhật thông tin sinh viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Thêm mới sinh viên
                dsSinhVien.Add(svMoi);
                MessageBox.Show("Thêm mới sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            isModified = true;
            LoadListView();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void xoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.lvSinhVienCNTT.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất một sinh viên trong danh sách để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa những sinh viên đã chọn?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                foreach (ListViewItem lvi in this.lvSinhVienCNTT.SelectedItems)
                {
                    string ms = lvi.SubItems[0].Text;
                    dsSinhVien.RemoveAll(x => x.MSSV == ms);
                }
                isModified = true;
                LoadListView();
                btnMacDinh.PerformClick();
                MessageBox.Show("Đã xóa sinh viên được chọn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void taiLaiDanhSachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DocFileDSNV();
            LoadListView();
            isModified = false;
            MessageBox.Show("Đã tải lại danh sách sinh viên từ tập tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void frmQLSV_CNTT_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isModified)
            {
                DialogResult dr = MessageBox.Show(
                    "Danh sách sinh viên đã có sự thay đổi. Bạn có muốn lưu vào tập tin DSNV.txt không?",
                    "Xác nhận lưu dữ liệu",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    LuuFileDSNV();
                }
                else if (dr == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}

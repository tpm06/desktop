using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Lab_3.Business;
using Lab_3.Models;
using Lab_3.Storage;

namespace Lab_3
{
    public partial class frmSinhVien : System.Windows.Forms.Form
    {
        private readonly QLSinhVien _studentManager;
        private bool _isBinding = false;

        public frmSinhVien()
        {
            InitializeComponent();
            _studentManager = new QLSinhVien();
        }

        private void frmSinhVien_Load(object sender, EventArgs e)
        {
            cboDinhDangFile.SelectedIndex = 0; // JSON mặc định
            TaoDuLieuMauNeuChuaCo();
            NapDanhSachTuFile();

            if (cboLop.Items.Count > 0 && cboLop.SelectedIndex == -1)
            {
                cboLop.SelectedIndex = 2; // CTK43
            }
        }

        private void TaoDuLieuMauNeuChuaCo()
        {
            string txtPath = "students.txt";
            string xmlPath = "students.xml";
            string jsonPath = "students.json";

            if (!File.Exists(jsonPath) && !File.Exists(xmlPath) && !File.Exists(txtPath))
            {
                var dsMau = new List<Student>
                {
                    new Student("1910152", "Nguyễn Văn", "An", new DateTime(2001, 5, 12), true, "CTK43", "272564891", "0912345678", "1 Phù Đổng Thiên Vương, Đà Lạt", new List<string> { "Mạng máy tính", "Hệ điều hành", "Lập trình CSDL" }),
                    new Student("1910153", "Trần Thị", "Bích", new DateTime(2001, 8, 20), false, "CTK43", "272564892", "0987654321", "25 Phan Đình Phùng, Đà Lạt", new List<string> { "Lập trình CSDL", "Đồ án cơ sở", "Phương pháp NCKH" }),
                    new Student("2010214", "Lê Hoàng", "Cường", new DateTime(2002, 3, 15), true, "CTK44", "272564893", "0905123456", "10 Đinh Tiên Hoàng, Đà Lạt", new List<string> { "Lập trình mạng", "An toàn và bảo mật hệ thống" }),
                    new Student("2010215", "Phạm Thị", "Dung", new DateTime(2002, 11, 28), false, "CTK44", "272564894", "0934567890", "12 Bùi Thị Xuân, Đà Lạt", new List<string> { "Mạng máy tính", "Lập trình trên thiết bị di động" }),
                    new Student("1810089", "Võ Minh", "Đức", new DateTime(2000, 1, 10), true, "CTK42", "272564895", "0945678123", "45 Hai Bà Trưng, Đà Lạt", new List<string> { "Đồ án cơ sở", "Hệ điều hành" })
                };

                new JsonStudentStorage().Save(jsonPath, dsMau);
                new XmlStudentStorage().Save(xmlPath, dsMau);
                new TxtStudentStorage().Save(txtPath, dsMau);
            }
        }

        private void NapDanhSachTuFile()
        {
            try
            {
                _studentManager.LoadFromFile();
                HienThiDanhSach(_studentManager.DanhSachSinhVien);
                CapNhatThongKe();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách từ tập tin: " + ex.Message, "Thông báo lỗi", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void HienThiDanhSach(List<SinhVien> danhSach)
        {
            lvSinhVien.BeginUpdate();
            lvSinhVien.Items.Clear();

            if (danhSach != null)
            {
                foreach (var sv in danhSach)
                {
                    var item = new ListViewItem(sv.MSSV);
                    item.SubItems.Add(sv.HoVaTenLot);
                    item.SubItems.Add(sv.Ten);
                    item.SubItems.Add(sv.NgaySinh.ToString("dd/MM/yyyy"));
                    item.SubItems.Add(sv.Lop);
                    item.SubItems.Add(sv.SoCMND);
                    item.SubItems.Add(sv.SoDT);
                    item.SubItems.Add(sv.DiaChi);
                    item.Tag = sv;

                    lvSinhVien.Items.Add(item);
                }
            }

            lvSinhVien.EndUpdate();
            CapNhatThongKe(danhSach?.Count ?? 0);
        }

        private void CapNhatThongKe(int? count = null)
        {
            int sl = count ?? _studentManager.DanhSachSinhVien.Count;
            tsslTongSV.Text = $"Tổng số sinh viên: {sl}";
            tsslFileDangDung.Text = $" | Định dạng: {_studentManager.CurrentStorage.GetType().Name} ({_studentManager.CurrentFilePath})";
        }

        private void lvSinhVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvSinhVien.SelectedItems.Count == 0) return;

            var item = lvSinhVien.SelectedItems[0];
            if (item.Tag is SinhVien sv)
            {
                HienThiThongTinSinhVien(sv);
            }
        }

        private void HienThiThongTinSinhVien(SinhVien sv)
        {
            _isBinding = true;
            try
            {
                mtbMSSV.Text = sv.MSSV;
                txtHoVaTenLot.Text = sv.HoVaTenLot;
                txtTen.Text = sv.Ten;
                dtpNgaySinh.Value = sv.NgaySinh >= dtpNgaySinh.MinDate && sv.NgaySinh <= dtpNgaySinh.MaxDate
                    ? sv.NgaySinh
                    : DateTime.Today;

                if (sv.GioiTinh)
                    rbNam.Checked = true;
                else
                    rbNu.Checked = true;

                if (!string.IsNullOrEmpty(sv.Lop))
                {
                    int idx = cboLop.FindStringExact(sv.Lop);
                    if (idx >= 0)
                        cboLop.SelectedIndex = idx;
                    else
                    {
                        cboLop.Items.Add(sv.Lop);
                        cboLop.SelectedItem = sv.Lop;
                    }
                }

                mtbCMND.Text = sv.SoCMND;
                mtbSDT.Text = sv.SoDT;
                txtDiaChi.Text = sv.DiaChi;

                for (int i = 0; i < clbMonHoc.Items.Count; i++)
                {
                    string mon = clbMonHoc.Items[i].ToString();
                    bool isChecked = sv.MonHoc != null && sv.MonHoc.Any(m => m.Equals(mon, StringComparison.OrdinalIgnoreCase));
                    clbMonHoc.SetItemChecked(i, isChecked);
                }
            }
            finally
            {
                _isBinding = false;
            }
        }

        private SinhVien LayThongTinTuGiaoDien()
        {
            var sv = new SinhVien
            {
                MSSV = Regex.Replace(mtbMSSV.Text, @"\D", ""),
                HoVaTenLot = txtHoVaTenLot.Text.Trim(),
                Ten = txtTen.Text.Trim(),
                NgaySinh = dtpNgaySinh.Value,
                GioiTinh = rbNam.Checked,
                Lop = cboLop.Text.Trim(),
                SoCMND = Regex.Replace(mtbCMND.Text, @"\D", ""),
                SoDT = Regex.Replace(mtbSDT.Text, @"\D", ""),
                DiaChi = txtDiaChi.Text.Trim(),
                MonHoc = new List<string>()
            };

            foreach (var item in clbMonHoc.CheckedItems)
            {
                sv.MonHoc.Add(item.ToString());
            }

            return sv;
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            var sv = LayThongTinTuGiaoDien();

            if (!_studentManager.Them(sv, out string error))
            {
                MessageBox.Show(error, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            HienThiDanhSach(_studentManager.DanhSachSinhVien);
            MessageBox.Show($"Thêm thành công sinh viên: {sv.HoTen} ({sv.MSSV})", "Thành công", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            var sv = LayThongTinTuGiaoDien();

            if (!_studentManager.CapNhat(sv, out string error))
            {
                MessageBox.Show(error, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            HienThiDanhSach(_studentManager.DanhSachSinhVien);
            MessageBox.Show($"Cập nhật thành công sinh viên: {sv.HoTen} ({sv.MSSV})", "Thành công", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            using (var dlg = new frmTimKiem(_studentManager))
            {
                if (dlg.ShowDialog(this) == DialogResult.OK)
                {
                    if (dlg.XemTatCa)
                    {
                        HienThiDanhSach(_studentManager.DanhSachSinhVien);
                    }
                    else if (dlg.KetQuaTimKiem != null)
                    {
                        HienThiDanhSach(dlg.KetQuaTimKiem);
                        MessageBox.Show($"Tìm thấy {dlg.KetQuaTimKiem.Count} sinh viên phù hợp.", 
                            "Kết quả tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmSinhVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("Bạn có chắc chắn muốn thoát chương trình hay không?", 
                "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }

        private void cboLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_isBinding) return;

            string lop = cboLop.Text;
            string aa = QLSinhVien.GetExpectedYearCodeFromClass(lop);
            if (!string.IsNullOrEmpty(aa))
            {
                string current = Regex.Replace(mtbMSSV.Text, @"\D", "");
                if (string.IsNullOrEmpty(current) || current.Length < 4)
                {
                    mtbMSSV.Text = aa + "10";
                }
            }
        }

        private void tsmiXoaSinhVien_Click(object sender, EventArgs e)
        {
            var listMssv = new List<string>();
            foreach (ListViewItem item in lvSinhVien.CheckedItems)
            {
                if (item.Tag is SinhVien sv)
                {
                    listMssv.Add(sv.MSSV);
                }
            }

            if (listMssv.Count == 0 && lvSinhVien.SelectedItems.Count > 0)
            {
                if (lvSinhVien.SelectedItems[0].Tag is SinhVien sv)
                {
                    listMssv.Add(sv.MSSV);
                }
            }

            if (listMssv.Count == 0)
            {
                MessageBox.Show("Vui lòng tick chọn ít nhất một sinh viên cần xóa trong danh sách!", 
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var dialogResult = MessageBox.Show($"Bạn có chắc chắn muốn xóa {listMssv.Count} sinh viên đã chọn hay không?", 
                "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                int deleted = _studentManager.XoaNhieu(listMssv);
                HienThiDanhSach(_studentManager.DanhSachSinhVien);
                MessageBox.Show($"Đã xóa thành công {deleted} sinh viên và lưu vào file.", 
                    "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tsmiChonTatCa_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lvSinhVien.Items)
            {
                item.Checked = true;
            }
        }

        private void tsmiBoChonTatCa_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lvSinhVien.Items)
            {
                item.Checked = false;
            }
        }

        private void tsmiTaiLai_Click(object sender, EventArgs e)
        {
            NapDanhSachTuFile();
        }

        private void tsmiThemMon_Click(object sender, EventArgs e)
        {
            string tenMon = HienThiHopThoaiNhapLieu("Nhập tên môn học mới:", "Thêm môn học");
            if (!string.IsNullOrWhiteSpace(tenMon))
            {
                tenMon = tenMon.Trim();
                if (clbMonHoc.Items.Contains(tenMon))
                {
                    MessageBox.Show("Môn học này đã có trong danh sách!", "Thông báo", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                clbMonHoc.Items.Add(tenMon, true);
            }
        }

        private void tsmiXoaMon_Click(object sender, EventArgs e)
        {
            if (clbMonHoc.SelectedIndex >= 0)
            {
                string mon = clbMonHoc.SelectedItem.ToString();
                var result = MessageBox.Show($"Bạn có chắc chắn muốn xóa môn '{mon}' khỏi danh sách môn học?", 
                    "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    clbMonHoc.Items.RemoveAt(clbMonHoc.SelectedIndex);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhấp chọn môn học cần xóa trước!", "Thông báo", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private string HienThiHopThoaiNhapLieu(string prompt, string title)
        {
            using (var form = new Form())
            {
                form.Text = title;
                form.FormBorderStyle = FormBorderStyle.FixedDialog;
                form.StartPosition = FormStartPosition.CenterParent;
                form.ClientSize = new Size(380, 140);
                form.MaximizeBox = false;
                form.MinimizeBox = false;

                var lbl = new Label { Left = 20, Top = 20, Text = prompt, AutoSize = true };
                var txt = new TextBox { Left = 20, Top = 45, Width = 340 };
                var btnOk = new Button { Text = "Đồng ý", Left = 160, Top = 85, Width = 95, DialogResult = DialogResult.OK };
                var btnCancel = new Button { Text = "Hủy", Left = 265, Top = 85, Width = 95, DialogResult = DialogResult.Cancel };

                form.Controls.AddRange(new Control[] { lbl, txt, btnOk, btnCancel });
                form.AcceptButton = btnOk;
                form.CancelButton = btnCancel;

                return form.ShowDialog(this) == DialogResult.OK ? txt.Text : string.Empty;
            }
        }

        private void cboDinhDangFile_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboDinhDangFile.SelectedIndex)
            {
                case 0:
                    _studentManager.CurrentStorage = new JsonStudentStorage();
                    _studentManager.CurrentFilePath = "students.json";
                    break;
                case 1:
                    _studentManager.CurrentStorage = new XmlStudentStorage();
                    _studentManager.CurrentFilePath = "students.xml";
                    break;
                case 2:
                    _studentManager.CurrentStorage = new TxtStudentStorage();
                    _studentManager.CurrentFilePath = "students.txt";
                    break;
            }

            if (_studentManager.DanhSachSinhVien != null && _studentManager.DanhSachSinhVien.Count > 0)
            {
                _studentManager.SaveToFile();
            }
            else
            {
                _studentManager.LoadFromFile();
                HienThiDanhSach(_studentManager.DanhSachSinhVien);
            }

            CapNhatThongKe();
        }

        private void mtbCMND_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mtbSDT_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}

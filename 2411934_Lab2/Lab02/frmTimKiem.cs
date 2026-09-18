using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02
{
    public partial class frmTimKiem : Form
    {
        public List<GiaoVien> dsGV = new List<GiaoVien>();

        public frmTimKiem(List<GiaoVien> dsGVien)
        {
            InitializeComponent();
            this.dsGV = dsGVien ?? new List<GiaoVien>();
        }

        private void frmTimKiem_Load(object sender, EventArgs e)
        {
            this.rdMaGV.Checked = true;
            this.label2.Text = "Mã GV";

            this.rdMaGV.CheckedChanged += Rd_CheckedChanged;
            this.rdHoTen.CheckedChanged += Rd_CheckedChanged;
            this.rdSĐT.CheckedChanged += Rd_CheckedChanged;
        }

        private void Rd_CheckedChanged(object sender, EventArgs e)
        {
            if (rdMaGV.Checked)
                label2.Text = "Mã GV";
            else if (rdHoTen.Checked)
                label2.Text = "Họ Tên";
            else if (rdSĐT.Checked)
                label2.Text = "Số điện thoại";
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string tuKhoa = this.txtTimKiem.Text.Trim();
            if (string.IsNullOrEmpty(tuKhoa))
            {
                MessageBox.Show("Vui lòng nhập thông tin cần tìm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtTimKiem.Focus();
                return;
            }

            List<GiaoVien> ds = new List<GiaoVien>();
            if (this.rdMaGV.Checked)
                ds = this.dsGV.FindAll(x => x.MaSo != null && x.MaSo.ToLower().Contains(tuKhoa.ToLower()));
            else if (this.rdHoTen.Checked)
                ds = this.dsGV.FindAll(x => x.HoTen != null && x.HoTen.ToLower().Contains(tuKhoa.ToLower()));
            else if (this.rdSĐT.Checked)
            {
                string cleanKey = tuKhoa.Replace(".", "").Replace(" ", "");
                ds = this.dsGV.FindAll(x => x.SoDT != null && x.SoDT.Replace(".", "").Replace(" ", "").Contains(cleanKey));
            }

            if (ds != null && ds.Count > 0)
            {
                string st = "";
                foreach (GiaoVien g in ds)
                {
                    st += g.ToString() + "\n-----------------------------\n";
                }
                frmTBGiaoVien frmTB = new frmTBGiaoVien();
                frmTB.SetText(st);
                frmTB.ShowDialog();
            }
            else
            {
                MessageBox.Show("Không tìm thấy thông tin giáo viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

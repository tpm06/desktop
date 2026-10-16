using System;
using System.Windows.Forms;

namespace Lab02
{
    public enum TuyChon
    {
        MaSV,
        HoTen,
        NgaySinh
    }

    public partial class frmTuyChon : Form
    {
        public TuyChon Kieu = TuyChon.MaSV;
        public string ChuoiTim = "";

        public frmTuyChon()
        {
            InitializeComponent();
        }

        public frmTuyChon(bool isTimKiem) : this()
        {
            if (isTimKiem)
            {
                btnSapXep.Enabled = false;
                groupBoxTim.Enabled = true;
            }
            else
            {
                btnSapXep.Enabled = true;
                groupBoxTim.Enabled = false;
            }
        }

        private void frmTuyChon_Load(object sender, EventArgs e)
        {
            rdMaSV.Checked = true;
            Kieu = TuyChon.MaSV;
        }

        private void rdTuyChon_Click(object sender, EventArgs e)
        {
            if (rdMaSV.Checked)
                Kieu = TuyChon.MaSV;
            else if (rdHoTen.Checked)
                Kieu = TuyChon.HoTen;
            else if (rdNgaySinh.Checked)
                Kieu = TuyChon.NgaySinh;
        }

        private void btnSapXep_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNhapThongTin.Text))
            {
                MessageBox.Show("Hãy nhập thông tin tìm!", "Lỗi nhập thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNhapThongTin.Focus();
                return;
            }

            ChuoiTim = txtNhapThongTin.Text.Trim();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}

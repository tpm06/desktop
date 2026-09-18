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
    public enum TuyChon
    {
        MaSV,
        HoTen,
        NgaySinh
    }

    public partial class frmTuyChon : Form
    {
        public TuyChon Kieu;
        public string ChuoiTim;
        private bool isCheDoTimKiem;

        public frmTuyChon(bool isTimKiem = false)
        {
            InitializeComponent();
            this.isCheDoTimKiem = isTimKiem;
        }

        private void frmTuyChon_Load(object sender, EventArgs e)
        {
            this.rdMaSV.Checked = true;
            this.Kieu = TuyChon.MaSV;

            if (isCheDoTimKiem)
            {
                this.btnSapXep.Enabled = false;
                this.groupBoxTim.Enabled = true;
                this.txtTimKiem.Focus();
            }
            else
            {
                this.btnSapXep.Enabled = true;
                this.groupBoxTim.Enabled = false;
            }
        }

        private void rdTuyChon_CheckedChanged(object sender, EventArgs e)
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
            if (string.IsNullOrWhiteSpace(this.txtTimKiem.Text))
            {
                MessageBox.Show("Hãy nhập thông tin tìm!", "Lỗi nhập thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtTimKiem.Focus();
                return;
            }

            this.ChuoiTim = this.txtTimKiem.Text.Trim();
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

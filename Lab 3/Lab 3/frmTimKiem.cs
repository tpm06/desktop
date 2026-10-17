using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Lab_3.Business;
using Lab_3.Models;

namespace Lab_3
{
    public partial class frmTimKiem : Form
    {
        private readonly QLSinhVien _manager;
        public List<SinhVien> KetQuaTimKiem { get; private set; }
        public bool XemTatCa { get; private set; }

        public frmTimKiem()
        {
            InitializeComponent();
        }

        public frmTimKiem(QLSinhVien manager) : this()
        {
            _manager = manager;
            KetQuaTimKiem = null;
            XemTatCa = false;
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string mssv = txtMSSV.Text.Trim();
            string hoTen = txtHoTen.Text.Trim();
            string lop = txtLop.Text.Trim();
            string diaChi = txtDiaChi.Text.Trim();

            if (string.IsNullOrEmpty(mssv) && string.IsNullOrEmpty(hoTen) && 
                string.IsNullOrEmpty(lop) && string.IsNullOrEmpty(diaChi))
            {
                MessageBox.Show("Vui lòng nhập ít nhất một điều kiện để tìm kiếm!", "Thông báo", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (_manager != null)
            {
                KetQuaTimKiem = _manager.TimKiemNangCao(mssv, hoTen, lop, null, null, diaChi, null, null);
            }
            XemTatCa = false;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnDatLai_Click(object sender, EventArgs e)
        {
            txtMSSV.Clear();
            txtHoTen.Clear();
            txtLop.Clear();
            txtDiaChi.Clear();
            XemTatCa = true;
            KetQuaTimKiem = null;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

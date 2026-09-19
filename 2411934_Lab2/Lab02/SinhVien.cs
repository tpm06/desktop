using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02
{
    public class SinhVien
    {
        public string MaSo { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public string DiaChi { get; set; }
        public string Lop { get; set; }
        public string Hinh { get; set; }
        public bool GioiTinh { get; set; }
        public List<string> ChuyenNganh { get; set; }

        public SinhVien()
        {
            ChuyenNganh = new List<string>();
        }

        public SinhVien(string maso, string hoten, DateTime ngaysinh, string diachi, string lop, string hinh, bool gioitinh, List<string> chuyennganh)
        {
            this.MaSo = maso;
            this.HoTen = hoten;
            this.NgaySinh = ngaysinh;
            this.DiaChi = diachi;
            this.Lop = lop;
            this.Hinh = hinh;
            this.GioiTinh = gioitinh;
            this.ChuyenNganh = chuyennganh ?? new List<string>();
        }

        public override string ToString()
        {
            string cn = string.Join(", ", ChuyenNganh);
            return string.Format("{0} - {1} - {2} - {3} - {4} - {5} - {6}",
                MaSo, HoTen, NgaySinh.ToString("dd/MM/yyyy"), DiaChi, Lop, GioiTinh ? "Nam" : "Nữ", cn);
        }
    }
}

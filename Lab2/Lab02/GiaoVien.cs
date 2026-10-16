using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02
{
    public class GiaoVien
    {
        public string MaSo { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh;
        public DanhSachMonHoc dsMonHoc;
        public string GioiTinh;
        public string[] NgoaiNgu;
        public string SoDT;
        public string Mail;
        public GiaoVien()
        {
            dsMonHoc = new DanhSachMonHoc();
            NgoaiNgu = new string[10];
        }
        public GiaoVien (string maso, string hoten, DateTime ngaysinh, 
            DanhSachMonHoc ds, string gt, string []nn, string sdt, string mail)
        {
            this.MaSo = maso;
            this.HoTen = hoten;
            this.NgaySinh = ngaysinh;
            this.dsMonHoc = ds;
            this.GioiTinh = gt;  
            this.NgoaiNgu = nn;
            this.SoDT = sdt;
            this.Mail = mail;
        }
        public override string ToString()
        {
            string s = "Mã số: " + MaSo + "\n" + "Họ tên: " + HoTen + "\n"
                + "Ngày sinh: " + NgaySinh.ToString("dd/MM/yyyy") + "\n"
                + "Giới tính: " + GioiTinh + "\n"
                + "Số ĐT: " + SoDT + "\n"
                + "Mail: " + Mail + "\n";
            string sngoaingu = "Ngoại ngữ: ";
            if (NgoaiNgu != null)
            {
                foreach (string t in NgoaiNgu)
                {
                    if (!string.IsNullOrEmpty(t))
                        sngoaingu += t + "; ";
                }
            }
            string Monday = "Danh sách môn dạy: ";
            if (dsMonHoc != null && dsMonHoc.ds != null)
            {
                foreach (MonHoc mh in dsMonHoc.ds)
                    Monday += mh.ToString() + "; ";
            }
            s += sngoaingu + "\n" + Monday;
            return s;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Lab_3.Models
{
    [Serializable]
    public class SinhVien
    {
        public string MSSV { get; set; }
        public string HoVaTenLot { get; set; }
        public string Ten { get; set; }
        public DateTime NgaySinh { get; set; }
        public bool GioiTinh { get; set; } // true: Nam, false: Nữ
        public string Lop { get; set; }
        public string SoCMND { get; set; }
        public string SoDT { get; set; }
        public string DiaChi { get; set; }

        [XmlArray("DanhSachMonHoc")]
        [XmlArrayItem("MonHoc")]
        public List<string> MonHoc { get; set; }

        public SinhVien()
        {
            MonHoc = new List<string>();
            NgaySinh = DateTime.Now;
            GioiTinh = true;
        }

        public SinhVien(string mssv, string hoVaTenLot, string ten, DateTime ngaySinh, 
            bool gioiTinh, string lop, string soCMND, string soDT, string diaChi, List<string> monHoc)
        {
            MSSV = mssv;
            HoVaTenLot = hoVaTenLot;
            Ten = ten;
            NgaySinh = ngaySinh;
            GioiTinh = gioiTinh;
            Lop = lop;
            SoCMND = soCMND;
            SoDT = soDT;
            DiaChi = diaChi;
            MonHoc = monHoc ?? new List<string>();
        }

        [XmlIgnore]
        public string HoTen => $"{HoVaTenLot} {Ten}".Trim();

        [XmlIgnore]
        public string GioiTinhStr => GioiTinh ? "Nam" : "Nữ";

        public override string ToString()
        {
            return $"{MSSV} - {HoTen} - {Lop}";
        }
    }

    /// <summary>
    /// Lớp Student tương đương SinhVien theo yêu cầu đề bài: Student (SinhVien)
    /// </summary>
    [Serializable]
    public class Student : SinhVien
    {
        public Student() : base() { }

        public Student(string mssv, string hoVaTenLot, string ten, DateTime ngaySinh, 
            bool gioiTinh, string lop, string soCMND, string soDT, string diaChi, List<string> monHoc)
            : base(mssv, hoVaTenLot, ten, ngaySinh, gioiTinh, lop, soCMND, soDT, diaChi, monHoc)
        {
        }
    }
}

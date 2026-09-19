using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

namespace Lab02
{
    public delegate int SoSanh(object sv1, object sv2);

    public class QuanLySinhVien
    {
        public List<SinhVien> dsSinhVien;

        public QuanLySinhVien()
        {
            dsSinhVien = new List<SinhVien>();
        }

        public SinhVien this[int index]
        {
            get { return this.dsSinhVien[index]; }
            set { this.dsSinhVien[index] = value; }
        }

        public void Them(SinhVien sv)
        {
            this.dsSinhVien.Add(sv);
        }

        public SinhVien Tim(object obj, SoSanh ss)
        {
            SinhVien svresult = null;
            foreach (SinhVien sv in dsSinhVien)
            {
                if (ss(obj, sv) == 0)
                {
                    svresult = sv;
                    break;
                }
            }
            return svresult;
        }

        public bool Sua(SinhVien svsua, object obj, SoSanh ss)
        {
            int i, count;
            bool kq = false;
            count = this.dsSinhVien.Count;
            for (i = 0; i < count; i++)
            {
                if (ss(obj, this[i]) == 0)
                {
                    this[i] = svsua;
                    kq = true;
                    break;
                }
            }
            return kq;
        }

        public void Xoa(object obj, SoSanh ss)
        {
            int i = dsSinhVien.Count - 1;
            for (; i >= 0; i--)
            {
                if (ss(obj, this[i]) == 0)
                    this.dsSinhVien.RemoveAt(i);
            }
        }

        public void DocTuFile(string filename)
        {
            string t;
            string[] s;
            SinhVien sv;
            if (!File.Exists(filename))
                return;

            using (StreamReader sr = new StreamReader(new FileStream(filename, FileMode.Open), Encoding.UTF8))
            {
                while ((t = sr.ReadLine()) != null)
                {
                    if (string.IsNullOrWhiteSpace(t))
                        continue;
                    s = t.Split(new char[] { '\t' }, StringSplitOptions.RemoveEmptyEntries);
                    if (s.Length < 8)
                        continue;

                    sv = new SinhVien();
                    sv.MaSo = s[0].Trim();
                    sv.HoTen = s[1].Trim();
                    DateTime ns;
                    string[] formats = { "M/d/yyyy", "MM/dd/yyyy", "d/M/yyyy", "dd/MM/yyyy", "yyyy-MM-dd", "M-d-yyyy", "MM-dd-yyyy" };
                    if (DateTime.TryParseExact(s[2].Trim(), formats, CultureInfo.InvariantCulture, DateTimeStyles.None, out ns) ||
                        DateTime.TryParse(s[2].Trim(), CultureInfo.InvariantCulture, DateTimeStyles.None, out ns) ||
                        DateTime.TryParse(s[2].Trim(), out ns))
                    {
                        sv.NgaySinh = ns;
                    }
                    else
                    {
                        sv.NgaySinh = DateTime.Now;
                    }
                    sv.DiaChi = s[3].Trim();
                    sv.Lop = s[4].Trim();
                    sv.Hinh = s[5].Trim();
                    sv.GioiTinh = false;
                    if (s[6].Trim() == "1")
                        sv.GioiTinh = true;

                    string[] cn = s[7].Split(',');
                    foreach (string c in cn)
                    {
                        if (!string.IsNullOrWhiteSpace(c))
                            sv.ChuyenNganh.Add(c.Trim());
                    }
                    this.Them(sv);
                }
            }
        }

        public void GhiRaFile(string filename)
        {
            using (StreamWriter sw = new StreamWriter(new FileStream(filename, FileMode.Create), Encoding.UTF8))
            {
                foreach (SinhVien sv in dsSinhVien)
                {
                    string cn = string.Join(",", sv.ChuyenNganh);
                    string gt = sv.GioiTinh ? "1" : "0";
                    string line = string.Format("{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}\t{7}",
                        sv.MaSo, sv.HoTen, sv.NgaySinh.ToString("MM/dd/yyyy"), sv.DiaChi, sv.Lop, sv.Hinh, gt, cn);
                    sw.WriteLine(line);
                }
            }
        }
    }
}

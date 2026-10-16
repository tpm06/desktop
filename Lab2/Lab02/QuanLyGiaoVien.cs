using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02
{
    public class QuanLyGiaoVien
    {
        public List<GiaoVien> dsGiaoVien = new List<GiaoVien>();
        public GiaoVien this[int index]
        {
            get { return dsGiaoVien[index] as GiaoVien; }
            set { dsGiaoVien[index] = value; }
        }
        public QuanLyGiaoVien()
        {

        }
        public bool Them(GiaoVien gv)
        {
            if (dsGiaoVien.Find(h => string.Compare(h.MaSo, gv.MaSo, true) == 0) != null)
                return false;
            else dsGiaoVien.Add(gv);
            return true;
        }

        public enum KieuTim
        {
            TheoMa,
            TheoHoTen,
            TheoSDT
        }

        public List<GiaoVien> TimKiem(string giaTri, KieuTim kieu)
        {
            List<GiaoVien> res = new List<GiaoVien>();
            if (string.IsNullOrWhiteSpace(giaTri))
                return res;

            giaTri = giaTri.Trim().ToLower();

            foreach (GiaoVien gv in dsGiaoVien)
            {
                if (kieu == KieuTim.TheoMa && gv.MaSo != null && gv.MaSo.ToLower().Contains(giaTri))
                    res.Add(gv);
                else if (kieu == KieuTim.TheoHoTen && gv.HoTen != null && gv.HoTen.ToLower().Contains(giaTri))
                    res.Add(gv);
                else if (kieu == KieuTim.TheoSDT && gv.SoDT != null && gv.SoDT.Replace(".", "").Replace(" ", "").Contains(giaTri.Replace(".", "").Replace(" ", "")))
                    res.Add(gv);
            }
            return res;
        }
    }
}

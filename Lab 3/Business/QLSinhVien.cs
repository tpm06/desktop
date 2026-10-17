using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using Lab_3.Models;
using Lab_3.Storage;

namespace Lab_3.Business
{
    /// <summary>
    /// Lớp QLSinhVien / StudentManager theo yêu cầu đề bài
    /// </summary>
    public class QLSinhVien
    {
        public List<SinhVien> DanhSachSinhVien { get; private set; }
        public IStudentStorage CurrentStorage { get; set; }
        public string CurrentFilePath { get; set; }

        public QLSinhVien()
        {
            DanhSachSinhVien = new List<SinhVien>();
            CurrentStorage = new JsonStudentStorage();
            CurrentFilePath = "students.json";
        }

        public QLSinhVien(IStudentStorage storage, string filePath)
        {
            DanhSachSinhVien = new List<SinhVien>();
            CurrentStorage = storage ?? new JsonStudentStorage();
            CurrentFilePath = filePath ?? "students.json";
        }

        public void LoadFromFile(string filePath = null, IStudentStorage storage = null)
        {
            if (storage != null) CurrentStorage = storage;
            if (!string.IsNullOrEmpty(filePath)) CurrentFilePath = filePath;

            if (CurrentStorage != null && !string.IsNullOrEmpty(CurrentFilePath))
            {
                var loaded = CurrentStorage.Load(CurrentFilePath);
                DanhSachSinhVien = loaded != null 
                    ? loaded.Cast<SinhVien>().ToList() 
                    : new List<SinhVien>();
            }
        }

        public void SaveToFile(string filePath = null, IStudentStorage storage = null)
        {
            if (storage != null) CurrentStorage = storage;
            if (!string.IsNullOrEmpty(filePath)) CurrentFilePath = filePath;

            if (CurrentStorage != null && !string.IsNullOrEmpty(CurrentFilePath))
            {
                var list = DanhSachSinhVien.Select(s => new Student(
                    s.MSSV, s.HoVaTenLot, s.Ten, s.NgaySinh, s.GioiTinh, s.Lop, s.SoCMND, s.SoDT, s.DiaChi, s.MonHoc
                )).ToList();
                CurrentStorage.Save(CurrentFilePath, list);
            }
        }

        public static string GetExpectedYearCodeFromClass(string lop)
        {
            if (string.IsNullOrWhiteSpace(lop)) return string.Empty;

            var matchK = Regex.Match(lop, @"[kK](\d+)");
            if (matchK.Success && int.TryParse(matchK.Groups[1].Value, out int k))
            {
                int year = 1976 + k;
                return (year % 100).ToString("D2");
            }

            var match4Digits = Regex.Match(lop, @"(19\d{2}|20\d{2})");
            if (match4Digits.Success && int.TryParse(match4Digits.Groups[1].Value, out int fullYear))
            {
                return (fullYear % 100).ToString("D2");
            }

            var match2Digits = Regex.Match(lop, @"\d{2}");
            if (match2Digits.Success)
            {
                return match2Digits.Value;
            }

            return string.Empty;
        }

        public bool ValidateMSSV(string mssv, string lop, out string error)
        {
            error = string.Empty;
            if (string.IsNullOrWhiteSpace(mssv))
            {
                error = "MSSV không được để trống.";
                return false;
            }

            string cleanMSSV = Regex.Replace(mssv, @"\D", "");
            if (cleanMSSV.Length != 7)
            {
                error = $"MSSV phải gồm đúng 7 chữ số (hiện tại có {cleanMSSV.Length} số).";
                return false;
            }

            string expectedAA = GetExpectedYearCodeFromClass(lop);
            string aa = cleanMSSV.Substring(0, 2);
            string bb = cleanMSSV.Substring(2, 2);

            if (!string.IsNullOrEmpty(expectedAA) && aa != expectedAA)
            {
                error = $"MSSV không hợp lệ cho lớp '{lop}'. 2 số đầu (AA) phải là '{expectedAA}' (năm nhập học), bạn đang nhập '{aa}'.";
                return false;
            }

            if (bb != "10")
            {
                error = $"MSSV có định dạng AABBCCC: 2 số tiếp theo (BB) phải là '10', bạn đang nhập '{bb}'.";
                return false;
            }

            return true;
        }

        public bool ValidateStudent(SinhVien sv, bool isNew, out string error)
        {
            error = string.Empty;

            if (sv == null)
            {
                error = "Dữ liệu sinh viên không hợp lệ.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(sv.MSSV)) { error = "Vui lòng nhập MSSV."; return false; }
            if (string.IsNullOrWhiteSpace(sv.HoVaTenLot)) { error = "Vui lòng nhập Họ và tên lót."; return false; }
            if (string.IsNullOrWhiteSpace(sv.Ten)) { error = "Vui lòng nhập Tên sinh viên."; return false; }
            if (string.IsNullOrWhiteSpace(sv.Lop)) { error = "Vui lòng chọn hoặc nhập Lớp."; return false; }
            if (string.IsNullOrWhiteSpace(sv.SoCMND)) { error = "Vui lòng nhập Số CMND."; return false; }
            if (string.IsNullOrWhiteSpace(sv.SoDT)) { error = "Vui lòng nhập Số điện thoại."; return false; }
            if (string.IsNullOrWhiteSpace(sv.DiaChi)) { error = "Vui lòng nhập Địa chỉ liên lạc."; return false; }

            if (!ValidateMSSV(sv.MSSV, sv.Lop, out string mssvErr))
            {
                error = mssvErr;
                return false;
            }

            string cleanMSSV = Regex.Replace(sv.MSSV, @"\D", "");
            if (isNew)
            {
                if (DanhSachSinhVien.Any(s => Regex.Replace(s.MSSV, @"\D", "") == cleanMSSV))
                {
                    error = $"MSSV '{cleanMSSV}' đã tồn tại trong danh sách. Không được trùng MSSV.";
                    return false;
                }
            }
            else
            {
                if (DanhSachSinhVien.Count(s => Regex.Replace(s.MSSV, @"\D", "") == cleanMSSV) > 1)
                {
                    error = $"MSSV '{cleanMSSV}' đã bị trùng với sinh viên khác.";
                    return false;
                }
            }

            string cleanCMND = Regex.Replace(sv.SoCMND, @"\D", "");
            if (cleanCMND.Length != 9)
            {
                error = $"Số CMND phải gồm đúng 9 chữ số (hiện tại có {cleanCMND.Length} số).";
                return false;
            }

            string cleanSDT = Regex.Replace(sv.SoDT, @"\D", "");
            if (cleanSDT.Length != 10)
            {
                error = $"Số điện thoại phải gồm đúng 10 chữ số (hiện tại có {cleanSDT.Length} số).";
                return false;
            }

            return true;
        }

        // a. Thêm sinh viên (có lưu vào file)
        public bool Them(SinhVien sv, out string error)
        {
            if (!ValidateStudent(sv, true, out error))
            {
                return false;
            }

            DanhSachSinhVien.Add(sv);
            SaveToFile();
            return true;
        }

        public bool Add(SinhVien sv, out string error) => Them(sv, out error);

        // a. Cập nhật thông tin sinh viên (có lưu vào file)
        public bool CapNhat(SinhVien sv, out string error)
        {
            if (!ValidateStudent(sv, false, out error))
            {
                return false;
            }

            string cleanMSSV = Regex.Replace(sv.MSSV, @"\D", "");
            var index = DanhSachSinhVien.FindIndex(s => Regex.Replace(s.MSSV, @"\D", "") == cleanMSSV);
            if (index == -1)
            {
                error = $"Không tìm thấy sinh viên có MSSV {cleanMSSV} để cập nhật.";
                return false;
            }

            DanhSachSinhVien[index] = sv;
            SaveToFile();
            return true;
        }

        public bool Update(SinhVien sv, out string error) => CapNhat(sv, out error);

        // c. Xóa một sinh viên (có lưu vào file)
        public bool Xoa(string mssv)
        {
            if (string.IsNullOrWhiteSpace(mssv)) return false;
            string cleanMSSV = Regex.Replace(mssv, @"\D", "");
            int count = DanhSachSinhVien.RemoveAll(s => Regex.Replace(s.MSSV, @"\D", "") == cleanMSSV);
            if (count > 0)
            {
                SaveToFile();
                return true;
            }
            return false;
        }

        public bool Delete(string mssv) => Xoa(mssv);

        // c. Xóa nhiều sinh viên (có lưu vào file)
        public int XoaNhieu(IEnumerable<string> listMssv)
        {
            if (listMssv == null) return 0;
            var set = new HashSet<string>(listMssv.Select(m => Regex.Replace(m, @"\D", "")));
            int count = DanhSachSinhVien.RemoveAll(s => set.Contains(Regex.Replace(s.MSSV, @"\D", "")));
            if (count > 0)
            {
                SaveToFile();
            }
            return count;
        }

        public int DeleteMany(IEnumerable<string> listMssv) => XoaNhieu(listMssv);

        // b. Tìm kiếm sinh viên theo Tên, Lớp, MSSV
        public List<SinhVien> TimKiem(string mssv = null, string ten = null, string lop = null)
        {
            IEnumerable<SinhVien> query = DanhSachSinhVien;

            if (!string.IsNullOrWhiteSpace(mssv))
            {
                string cleanSearch = Regex.Replace(mssv, @"\D", "");
                query = query.Where(s => Regex.Replace(s.MSSV, @"\D", "").Contains(cleanSearch));
            }

            if (!string.IsNullOrWhiteSpace(ten))
            {
                string cleanTen = ten.Trim().ToLowerInvariant();
                query = query.Where(s => s.Ten.ToLowerInvariant().Contains(cleanTen) || 
                                         s.HoTen.ToLowerInvariant().Contains(cleanTen));
            }

            if (!string.IsNullOrWhiteSpace(lop))
            {
                string cleanLop = lop.Trim().ToLowerInvariant();
                query = query.Where(s => s.Lop != null && s.Lop.ToLowerInvariant().Contains(cleanLop));
            }

            return query.ToList();
        }

        public List<SinhVien> Search(string mssv = null, string ten = null, string lop = null) => TimKiem(mssv, ten, lop);

        // Tìm kiếm nâng cao đa điều kiện
        public List<SinhVien> TimKiemNangCao(string mssv, string hoTen, string lop, string cmnd, string sdt, string diaChi, bool? gioiTinh, string monHoc)
        {
            IEnumerable<SinhVien> query = DanhSachSinhVien;

            if (!string.IsNullOrWhiteSpace(mssv))
            {
                string cleanSearch = Regex.Replace(mssv, @"\D", "");
                query = query.Where(s => Regex.Replace(s.MSSV, @"\D", "").Contains(cleanSearch));
            }

            if (!string.IsNullOrWhiteSpace(hoTen))
            {
                string cleanTen = hoTen.Trim().ToLowerInvariant();
                query = query.Where(s => s.HoTen.ToLowerInvariant().Contains(cleanTen));
            }

            if (!string.IsNullOrWhiteSpace(lop))
            {
                string cleanLop = lop.Trim().ToLowerInvariant();
                query = query.Where(s => s.Lop != null && s.Lop.ToLowerInvariant().Contains(cleanLop));
            }

            if (!string.IsNullOrWhiteSpace(cmnd))
            {
                string clean = Regex.Replace(cmnd, @"\D", "");
                query = query.Where(s => Regex.Replace(s.SoCMND ?? "", @"\D", "").Contains(clean));
            }

            if (!string.IsNullOrWhiteSpace(sdt))
            {
                string clean = Regex.Replace(sdt, @"\D", "");
                query = query.Where(s => Regex.Replace(s.SoDT ?? "", @"\D", "").Contains(clean));
            }

            if (!string.IsNullOrWhiteSpace(diaChi))
            {
                string clean = diaChi.Trim().ToLowerInvariant();
                query = query.Where(s => (s.DiaChi ?? "").ToLowerInvariant().Contains(clean));
            }

            if (gioiTinh.HasValue)
            {
                query = query.Where(s => s.GioiTinh == gioiTinh.Value);
            }

            if (!string.IsNullOrWhiteSpace(monHoc))
            {
                string cleanMon = monHoc.Trim().ToLowerInvariant();
                query = query.Where(s => s.MonHoc != null && s.MonHoc.Any(m => m.ToLowerInvariant().Contains(cleanMon)));
            }

            return query.ToList();
        }

        public List<SinhVien> SearchAdvanced(string mssv, string hoTen, string lop, string cmnd, string sdt, string diaChi, bool? gioiTinh, string monHoc)
            => TimKiemNangCao(mssv, hoTen, lop, cmnd, sdt, diaChi, gioiTinh, monHoc);
    }

    /// <summary>
    /// Lớp StudentManager tương đương QLSinhVien theo yêu cầu đề bài: StudentManager(QLSinhVien)
    /// </summary>
    public class StudentManager : QLSinhVien
    {
        public StudentManager() : base() { }
        public StudentManager(IStudentStorage storage, string filePath) : base(storage, filePath) { }
    }
}

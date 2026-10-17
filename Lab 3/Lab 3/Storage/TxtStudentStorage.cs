using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using Lab_3.Models;

namespace Lab_3.Storage
{
    public class TxtStudentStorage : IStudentStorage
    {
        public string FileExtension => ".txt";
        public string FilterName => "Text files (*.txt)|*.txt";

        private const char Separator = '*';

        public List<Student> Load(string filePath)
        {
            var list = new List<Student>();
            if (!File.Exists(filePath))
            {
                return list;
            }

            string[] lines = File.ReadAllLines(filePath, Encoding.UTF8);
            foreach (string rawLine in lines)
            {
                string line = rawLine?.Trim();
                if (string.IsNullOrWhiteSpace(line)) continue;

                // Tách theo * hoặc \t nếu dùng tab
                char sep = line.Contains('*') ? '*' : '\t';
                string[] parts = line.Split(sep);
                if (parts.Length < 9) continue;

                var student = new Student
                {
                    MSSV = parts[0].Trim(),
                    HoVaTenLot = parts[1].Trim(),
                    Ten = parts[2].Trim()
                };

                if (DateTime.TryParseExact(parts[3].Trim(), "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime dt))
                {
                    student.NgaySinh = dt;
                }
                else if (DateTime.TryParse(parts[3].Trim(), out dt))
                {
                    student.NgaySinh = dt;
                }

                string gtStr = parts[4].Trim();
                student.GioiTinh = gtStr.Equals("Nam", StringComparison.OrdinalIgnoreCase) ||
                                   gtStr.Equals("True", StringComparison.OrdinalIgnoreCase) ||
                                   gtStr == "1";

                student.Lop = parts[5].Trim();
                student.SoCMND = parts[6].Trim();
                student.SoDT = parts[7].Trim();
                student.DiaChi = parts[8].Trim();

                if (parts.Length > 9 && !string.IsNullOrWhiteSpace(parts[9]))
                {
                    student.MonHoc = parts[9].Split(new[] { ',', ';' }, StringSplitOptions.RemoveEmptyEntries)
                                             .Select(m => m.Trim())
                                             .Where(m => !string.IsNullOrEmpty(m))
                                             .ToList();
                }

                list.Add(student);
            }

            return list;
        }

        public void Save(string filePath, List<Student> students)
        {
            var sb = new StringBuilder();
            foreach (var s in students)
            {
                string monHocStr = s.MonHoc != null && s.MonHoc.Count > 0
                    ? string.Join(",", s.MonHoc)
                    : string.Empty;

                string line = string.Join(Separator.ToString(),
                    s.MSSV ?? "",
                    s.HoVaTenLot ?? "",
                    s.Ten ?? "",
                    s.NgaySinh.ToString("dd/MM/yyyy"),
                    s.GioiTinh ? "Nam" : "Nữ",
                    s.Lop ?? "",
                    s.SoCMND ?? "",
                    s.SoDT ?? "",
                    s.DiaChi ?? "",
                    monHocStr
                );
                sb.AppendLine(line);
            }

            string dir = Path.GetDirectoryName(filePath);
            if (!string.IsNullOrEmpty(dir) && !Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }

            File.WriteAllText(filePath, sb.ToString(), Encoding.UTF8);
        }
    }
}

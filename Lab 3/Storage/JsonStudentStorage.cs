using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;
using Lab_3.Models;

namespace Lab_3.Storage
{
    public class JsonStudentStorage : IStudentStorage
    {
        public string FileExtension => ".json";
        public string FilterName => "JSON files (*.json)|*.json";

        public List<Student> Load(string filePath)
        {
            if (!File.Exists(filePath))
            {
                return new List<Student>();
            }

            try
            {
                string json = File.ReadAllText(filePath, Encoding.UTF8);
                if (string.IsNullOrWhiteSpace(json))
                {
                    return new List<Student>();
                }
                var list = JsonConvert.DeserializeObject<List<Student>>(json);
                return list ?? new List<Student>();
            }
            catch
            {
                return new List<Student>();
            }
        }

        public void Save(string filePath, List<Student> students)
        {
            string dir = Path.GetDirectoryName(filePath);
            if (!string.IsNullOrEmpty(dir) && !Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }

            string json = JsonConvert.SerializeObject(students ?? new List<Student>(), Formatting.Indented);
            File.WriteAllText(filePath, json, Encoding.UTF8);
        }
    }
}

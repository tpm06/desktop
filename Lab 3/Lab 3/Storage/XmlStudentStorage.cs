using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;
using Lab_3.Models;

namespace Lab_3.Storage
{
    public class XmlStudentStorage : IStudentStorage
    {
        public string FileExtension => ".xml";
        public string FilterName => "XML files (*.xml)|*.xml";

        private readonly XmlSerializer _serializer = new XmlSerializer(typeof(List<Student>), new XmlRootAttribute("ArrayOfStudent"));

        public List<Student> Load(string filePath)
        {
            if (!File.Exists(filePath))
            {
                return new List<Student>();
            }

            try
            {
                using (var reader = new StreamReader(filePath, Encoding.UTF8))
                {
                    var result = (List<Student>)_serializer.Deserialize(reader);
                    return result ?? new List<Student>();
                }
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

            using (var writer = new StreamWriter(filePath, false, Encoding.UTF8))
            {
                _serializer.Serialize(writer, students ?? new List<Student>());
            }
        }
    }
}

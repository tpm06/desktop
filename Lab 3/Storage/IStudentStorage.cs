using System.Collections.Generic;
using Lab_3.Models;

namespace Lab_3.Storage
{
    public interface IStudentStorage
    {
        string FileExtension { get; }
        string FilterName { get; }
        List<Student> Load(string filePath);
        void Save(string filePath, List<Student> students);
    }
}

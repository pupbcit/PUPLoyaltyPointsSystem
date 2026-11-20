using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;
using System.Text.Json;

namespace LoyaltyPointsData
{
    public class StudentJsonDataService
    {
        private List<Student> students = new List<Student>();
        private readonly string _jsonStudentFileName;

        public StudentJsonDataService()
        {
            _jsonStudentFileName = Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory, "Student.json");

            RetrieveDataFromJsonFile();
        }

        private void SaveDataToJsonFile()
        {
            using (var outputStream = File.OpenWrite(_jsonStudentFileName))
            {
                JsonSerializer.Serialize<List<Student>>(
                    new Utf8JsonWriter(outputStream, new JsonWriterOptions
                    { SkipValidation = true, Indented = true })
                    , students);
            }
        }

        private void RetrieveDataFromJsonFile()
        {
            using (var jsonFileReader = File.OpenText(_jsonStudentFileName))
            {
                students = JsonSerializer.Deserialize<List<Student>>(
                    jsonFileReader.ReadToEnd(),
                    new JsonSerializerOptions { PropertyNameCaseInsensitive = true })
                    ?? new List<Student>();
            }
        }

        public bool IsStudentNumberExists(string studentNumber)
        {
            if (string.IsNullOrWhiteSpace(studentNumber))
                return false;

            string target = studentNumber.Trim();

            return students.Any(f =>
                string.Equals(f.StudentID, target, StringComparison.OrdinalIgnoreCase));
        }

        public bool AddFaculty(Student student)
        {
            if (student == null || string.IsNullOrWhiteSpace(student.StudentID))
                return false;

            if (IsStudentNumberExists(student.StudentID))
                return false;

            students.Add(new Student
            {
                StudentID = student.StudentID.Trim(),
                StudentName = student.StudentName?.Trim() ?? string.Empty,
                Points = student.Points,
            });

            SaveDataToJsonFile();
            return true;
        }

        public List<Student> RetrieveAllFaculty()
        {
            return students;
        }
    }
}

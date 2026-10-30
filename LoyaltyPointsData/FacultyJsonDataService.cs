using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace LoyaltyPointsData
{
    public class FacultyJsonDataService
    {
        private List<Faculty> facultyIds = new List<Faculty>();
        private readonly string _jsonFacultyFileName;

        public FacultyJsonDataService()
        {
            _jsonFacultyFileName = Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory, "Faculty.json");

            RetrieveDataFromJsonFile();
        }

        private void SaveDataToJsonFile()
        {
            using (var outputStream = File.OpenWrite(_jsonFacultyFileName))
            {
                JsonSerializer.Serialize<List<Faculty>>(
                    new Utf8JsonWriter(outputStream, new JsonWriterOptions
                    { SkipValidation = true, Indented = true })
                    , facultyIds);
            }
        }

        private void RetrieveDataFromJsonFile()
        {
            using (var jsonFileReader = File.OpenText(_jsonFacultyFileName))
            {
                facultyIds = JsonSerializer.Deserialize<List<Faculty>>(
                    jsonFileReader.ReadToEnd(),
                    new JsonSerializerOptions { PropertyNameCaseInsensitive = true })
                    ?? new List<Faculty>();
            }
        }

        public bool IsFacultyNumberExists(string facultyNumber)
        {
            if (string.IsNullOrWhiteSpace(facultyNumber))
                return false;

            string target = facultyNumber.Trim();

            return facultyIds.Any(f =>
                string.Equals(f.FacultyID, target, StringComparison.OrdinalIgnoreCase));
        }

        public bool AddFaculty(Faculty faculty)
        {
            if (faculty == null || string.IsNullOrWhiteSpace(faculty.FacultyID))
                return false;

            if (IsFacultyNumberExists(faculty.FacultyID))
                return false; 

            facultyIds.Add(new Faculty
            {
                FacultyID = faculty.FacultyID.Trim(),
                FacultyName = faculty.FacultyName?.Trim() ?? string.Empty
            });

            SaveDataToJsonFile();
            return true;
        }

        public List<Faculty> RetrieveAllFaculty()
        {
            return facultyIds;
        }

    }
}
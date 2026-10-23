using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace LoyaltyPointsData
{
    public class FacultyJsonDataService
    {
        private List<string> facultyIds = new List<string>();
        private string _jsonFacultyFileName;

        public FacultyJsonDataService()
        {
            _jsonFacultyFileName =
                $"{AppDomain.CurrentDomain.BaseDirectory}/Faculty.json";

            RetrieveDataFromJsonFile();
        }

        //private void SaveDataToJsonFile()
        //{
        //    using (var outputStream = File.OpenWrite(_jsonFileName))
        //    {
        //        JsonSerializer.Serialize<List<Account>>(
        //            new Utf8JsonWriter(outputStream, new JsonWriterOptions
        //            { SkipValidation = true, Indented = true })
        //            , accounts);
        //    }
        //}

        private void RetrieveDataFromJsonFile()
        {
            using (var jsonFileReader = File.OpenText(_jsonFacultyFileName))
            {
                facultyIds = JsonSerializer.Deserialize<List<string>>
                    (jsonFileReader.ReadToEnd(), new JsonSerializerOptions
                    { PropertyNameCaseInsensitive = true })
                    .ToList();
            }
        }
    }
}

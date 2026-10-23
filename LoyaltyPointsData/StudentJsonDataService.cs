using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;
using System.Text.Json;

namespace LoyaltyPointsData
{
    internal class StudentJsonDataService
    {
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

        //private void RetrieveDataFromJsonFile()
        //{
        //    using (var jsonFileReader = File.OpenText(_jsonFileName))
        //    {
        //        accounts = JsonSerializer.Deserialize<List<Account>>
        //            (jsonFileReader.ReadToEnd(), new JsonSerializerOptions
        //            { PropertyNameCaseInsensitive = true })
        //            .ToList();
        //    }
        //}
    }
}

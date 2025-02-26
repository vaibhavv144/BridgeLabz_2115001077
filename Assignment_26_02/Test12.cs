using System;
using System.IO;
using Newtonsoft.Json.Linq;

class Test12{
    public static void Print(){
        string file1Path = "file1.json";
        string file2Path = "file2.json";

        // Create JSON files
        CreateJsonFile(file1Path, @"{ 'Name': 'Vaibhav Singh', 'Age': 25, 'Email': 'vaibhav@gmail.com' }");
        CreateJsonFile(file2Path, @"{ 'City': 'Raebareli', 'Country': 'India', 'Phone': '6306448229' }");

        // Merge JSON files
        if (File.Exists(file1Path) && File.Exists(file2Path))
        {
            string json1 = File.ReadAllText(file1Path);
            string json2 = File.ReadAllText(file2Path);

            JObject jsonObject1 = JObject.Parse(json1);
            JObject jsonObject2 = JObject.Parse(json2);

            jsonObject1.Merge(jsonObject2, new JsonMergeSettings
            {
                MergeArrayHandling = MergeArrayHandling.Union
            });

            string mergedJson = jsonObject1.ToString();
            Console.WriteLine("Merged JSON:\n" + mergedJson);
        }
        else
        {
            Console.WriteLine("One or both JSON files not found.");
        }
    }

    // Function to create a JSON file
    public static void CreateJsonFile(string filePath, string jsonData)
    {
        if (!File.Exists(filePath))
        {
            File.WriteAllText(filePath, jsonData);
            Console.WriteLine($"File created: {filePath}");
        }
        else
        {
            Console.WriteLine($"File already exists: {filePath}");
        }
    }
}

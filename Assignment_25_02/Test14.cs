using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

class Test14
{
    public static void Print()
    {
        string jsonFilePath = "students.json";
        string csvFilePath = "students.csv";
        string convertedJsonFilePath = "students_converted.json";

        // Create a sample JSON file
        CreateSampleJsonFile(jsonFilePath);

        // Convert JSON to CSV
        ConvertJsonToCsv(jsonFilePath, csvFilePath);

        // Convert CSV back to JSON
        ConvertCsvToJson(csvFilePath, convertedJsonFilePath);
    }

    static void CreateSampleJsonFile(string filePath)
    {
        var learners = new List<Learner>
        {
            new Learner { ID = 1, Name = "Shivam Kumar Rajput", Age = 20, Marks = 85 },
            new Learner { ID = 2, Name = "Vaibhav Singh", Age = 21, Marks = 79 },
            new Learner { ID = 3, Name = "Shudhanshu Trivedi", Age = 22, Marks = 88 }
        };

        string json = JsonConvert.SerializeObject(learners, Formatting.Indented); // Fixed this line
        File.WriteAllText(filePath, json);
        Console.WriteLine($"JSON file '{filePath}' created.");
    }

    static void ConvertJsonToCsv(string jsonFilePath, string csvFilePath)
    {
        if (!File.Exists(jsonFilePath))
        {
            Console.WriteLine("JSON file not found!");
            return;
        }

        var learners = JsonConvert.DeserializeObject<List<Learner>>(File.ReadAllText(jsonFilePath));
        var csvLines = new List<string> { "ID,Name,Age,Marks" }; // CSV Header

        csvLines.AddRange(learners.Select(s => $"{s.ID},\"{s.Name}\",{s.Age},{s.Marks}")); // Enclose Name in quotes to handle commas

        File.WriteAllLines(csvFilePath, csvLines);
        Console.WriteLine($"CSV file '{csvFilePath}' created.");
    }

    static void ConvertCsvToJson(string csvFilePath, string jsonFilePath)
    {
        if (!File.Exists(csvFilePath))
        {
            Console.WriteLine("CSV file not found!");
            return;
        }

        var lines = File.ReadAllLines(csvFilePath).Skip(1); // Skip header
        var learners = lines.Select(line =>
        {
            var data = line.Split(','); // Splitting directly can be unsafe for names with commas
            return new Learner
            {
                ID = int.Parse(data[0]),
                Name = data[1].Trim('"'), // Trim quotes if they exist
                Age = int.Parse(data[2]),
                Marks = int.Parse(data[3])
            };
        }).ToList();

        string json = JsonConvert.SerializeObject(learners, Formatting.Indented);
        File.WriteAllText(jsonFilePath, json);
        Console.WriteLine($"JSON file '{jsonFilePath}' created.");
    }
}

class Learner
{
    public int ID { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public int Marks { get; set; }
}

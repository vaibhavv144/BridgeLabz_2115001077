using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

class Test14
{
    public static void Print()
    {
        string csvFilePath = "dat2.csv"; // CSV file to read
        CreateCsvFile(csvFilePath); // Create sample CSV file

        if (File.Exists(csvFilePath))
        {
            // Read CSV and convert to JSON
            string[] csvLines = File.ReadAllLines(csvFilePath);
            if (csvLines.Length > 1)
            {
                string[] headers = csvLines[0].Split(',');
                List<Dictionary<string, string>> records = new List<Dictionary<string, string>>();

                for (int i = 1; i < csvLines.Length; i++)
                {
                    string[] values = csvLines[i].Split(',');
                    Dictionary<string, string> record = new Dictionary<string, string>();

                    for (int j = 0; j < headers.Length; j++)
                    {
                        record[headers[j]] = values[j];
                    }

                    records.Add(record);
                }

                string json = JsonConvert.SerializeObject(records, Formatting.Indented);
                Console.WriteLine("Converted JSON:\n" + json);
            }
            else
            {
                Console.WriteLine("CSV file is empty.");
            }
        }
        else
        {
            Console.WriteLine("CSV file not found.");
        }
    }

    // Function to create a sample CSV file
    public static void CreateCsvFile(string filePath)
    {
        if (!File.Exists(filePath))
        {
            string csvData = "Name,Age,Email\vaibhav,25,vaibhav@gmail.com\nRahul,30,vaibhav@gmail.com";
            File.WriteAllText(filePath, csvData);
            Console.WriteLine($"CSV file created: {filePath}");
        }
    }
}

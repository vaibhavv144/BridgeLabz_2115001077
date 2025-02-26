using System;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

class Test3
{
    public static void Print(){
        string filePath = "data.json";
        CreateJsonFile(filePath); // Create JSON file
        ReadJsonFile(filePath);   // Read and extract fields
    }
    public static void CreateJsonFile(string filePath){
        var person = new
        {
            Name = "Vaibhav Singh",
            Email = "vaibhav@gmail.com",
            Age = 22,
            Address = "India"
        };

        string json = JsonConvert.SerializeObject(person, Formatting.Indented);
        File.WriteAllText(filePath, json);
        Console.WriteLine("JSON file created successfully.");
    }

    public static void ReadJsonFile(string filePath) {
        if (File.Exists(filePath)) {
            string jsonContent = File.ReadAllText(filePath);
            JObject jsonObject = JObject.Parse(jsonContent);

            string name = jsonObject["Name"]?.ToString();
            string email = jsonObject["Email"]?.ToString();

            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Email: {email}");
        } else {
            Console.WriteLine("JSON file not found.");
        }
    }

}

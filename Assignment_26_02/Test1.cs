using System;
using Newtonsoft.Json;

class Test1{
    public static void Print(){
        var student = new
        {
            Name = "Vaibhav Singh",
            Age = 22,
            Subjects = new string[] { "Math", "Science", "History" }
        };

        // Convert object to JSON
        string json = JsonConvert.SerializeObject(student, Formatting.Indented);
        Console.WriteLine("JSON Representation:\n" + json);
    }
}

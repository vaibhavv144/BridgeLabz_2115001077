using System;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

class Test10{
    public static void Print()
    {
        string json = @"[
            { 'Name': 'Vaibhav Singh', 'Age': 25, 'Email': 'vaibhavsingh@gmail.com' },
            { 'Name': 'Ayush Srivastava', 'Age': 30, 'Email': 'ayush@gmail.com' },
            { 'Name': 'Aditya', 'Age': 28, 'Email': 'aditya@gmail.com' },
            { 'Name': 'Siddhnat', 'Age': 24, 'Email': 'siddhnat@gmail.com' }
        ]";

        // Parse JSON array
        JArray jsonArray = JArray.Parse(json);

        // Filter users older than 25
        var filteredUsers = jsonArray.Where(user => (int)user["Age"] > 25);

        // Convert filtered users back to JSON
        string filteredJson = JsonConvert.SerializeObject(filteredUsers, Formatting.Indented);
        Console.WriteLine("Filtered JSON (Users Age > 25):\n" + filteredJson);
    }
}

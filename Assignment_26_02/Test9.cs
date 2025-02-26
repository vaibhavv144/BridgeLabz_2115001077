using System;
using System.Collections.Generic;
using Newtonsoft.Json;

class Test9{
    public static void Print(){
        // List of Employee objects
        List<Employee> employees = new List<Employee>
        {
            new Employee { Name = "Vaibhav Singh", Age = 25, Position = "Software Engineer" },
            new Employee { Name = "Aditya Chaudhary", Age = 30, Position = "Project Manager" },
            new Employee { Name = "Ayush Srivastava", Age = 28, Position = "Data Analyst" }
        };

        // Convert list to JSON array
        string jsonArray = JsonConvert.SerializeObject(employees, Formatting.Indented);
        Console.WriteLine("JSON Array:\n" + jsonArray);
    }
}

// Employee class
class Employee{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Position { get; set; }
}

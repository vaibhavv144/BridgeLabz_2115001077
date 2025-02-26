using System;
using System.Collections.Generic;
using Newtonsoft.Json;

class Test6
{
    public static void Print()
    {
        // List of Vehicle objects
        List<Vehicle> vehicles = new List<Vehicle>
        {
            new Vehicle { Brand = "Tesla", Model = "Model S", Year = 2024 },
            new Vehicle { Brand = "BMW", Model = "X5", Year = 2023 },
            new Vehicle { Brand = "Audi", Model = "Q7", Year = 2022 }
        };

        // Convert list to JSON array
        string jsonArray = JsonConvert.SerializeObject(vehicles, Formatting.Indented);
        Console.WriteLine("JSON Array:\n" + jsonArray);
    }
}

// Vehicle class
class Vehicle
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
}

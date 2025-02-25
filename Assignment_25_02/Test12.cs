
using System;
using System.IO;
using System.Collections.Generic;
 
class Test12
{
	public static void Print()
	{
    	string filePath = "students3.csv";
   	
    	// Create a sample CSV file (for testing)
    	CreateSampleCSV(filePath); 
 
    	// Detect and print duplicate records
    	DetectDuplicateRecords(filePath);
	}
 
	static void CreateSampleCSV(string filePath)
	{
    	string[] csvData = {
        	"ID,Name,Age,Marks",
        	"1,Shivam Kumar Rajput,20,85",
        	"2,Vaibhav Singh,21,79",
        	"3,Shudhanshu Trivedi,22,88",
        	"4,Prabhat Kumar,23,76",
        	"5,Pramendra Pratap Singh,24,92",
        	"2,Vaibhav Singh,21,79",   // Duplicate
        	"4,Prabhat Kumar,23,76"	// Duplicate
    	};
    	File.WriteAllLines(filePath, csvData);
    	Console.WriteLine($"Sample CSV file '{filePath}' created.");
	}
 
	static void DetectDuplicateRecords(string filePath)
	{
    	if (!File.Exists(filePath))
    	{
        	Console.WriteLine("CSV file not found!");
        	return;
    	}
 
    	Dictionary<string, List<string>> recordMap = new Dictionary<string, List<string>>();
    	string[] lines = File.ReadAllLines(filePath);
   	
    	Console.WriteLine("\nChecking for duplicate records...\n");
 
    	for (int i = 1; i < lines.Length; i++) // Skip header row
    	{
        	string[] data = lines[i].Split(',');
        	string id = data[0];
 
        	if (recordMap.ContainsKey(id))
            {
                recordMap[id].Add(lines[i]);
            }
        	else
            {
                recordMap[id] = new List<string> { lines[i] };
            }
    	}
 
    	Console.WriteLine("Duplicate Records:");
    	Console.WriteLine(new string('-', 50));
    	Console.WriteLine("{0,-5} {1,-25} {2,-5} {3,-5}", "ID", "Name", "Age", "Marks");
    	Console.WriteLine(new string('-', 50));
 
    	bool duplicatesFound = false;
 
    	foreach (var entry in recordMap)
    	{
        	if (entry.Value.Count > 1) // More than 1 occurrence means duplicate
            {
                duplicatesFound = true;
                foreach (string record in entry.Value)
                {
                    string[] data = record.Split(',');
                    Console.WriteLine("{0,-5} {1,-25} {2,-5} {3,-5}", data[0], data[1], data[2], data[3]);
                }
            }
    	}
 
    	if (!duplicatesFound)
    	{
        	Console.WriteLine("No duplicate records found.");
    	}
	}
}
 





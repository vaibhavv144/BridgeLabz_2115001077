
using System;
using System.IO;
 
class Test3
{
	public static void Print()
	{
    	string filePath = "students.csv";
    	ReadAndPrintCSVFile(filePath);
    	CountCSVRows(filePath);
	}
 
	static void ReadAndPrintCSVFile(string filePath)
	{
    	if (File.Exists(filePath))
    	{
        	string[] lines = File.ReadAllLines(filePath);
       	
        	Console.WriteLine("{0,-5} {1,-25} {2,-10} {3,-5}", "ID", "Name", "Age", "Marks");
        	Console.WriteLine(new string('-', 50));
       	
        	for (int i = 1; i < lines.Length; i++) // Skip header row
            {
                string[] data = lines[i].Split(',');
                Console.WriteLine("{0,-5} {1,-25} {2,-10} {3,-5}", data[0], data[1], data[2], data[3]);
            }
    	}
    	else
    	{
        	Console.WriteLine("CSV file not found!");
    	}
	}
	static void CountCSVRows(string filePath)
	{
    	if (File.Exists(filePath))
    	{
        	int rowCount = File.ReadAllLines(filePath).Length - 1; // Exclude header
        	Console.WriteLine($"Total number of records: {rowCount}");
    	}
    	else
    	{
        	Console.WriteLine("CSV file not found!");
    	}
	}
}
 





using System;
using System.IO;
 
class Test1
{
	public static void Print()
	{
    	string filePath = "students.csv";
    	CreateCSVFile(filePath);
    	ReadAndPrintCSVFile(filePath);
	}
 
	static void CreateCSVFile(string filePath)
	{
    	string[] csvData = {
        	"ID,Name,Age,Marks",
        	"1,Shivam Kumar Rajput,20,85",
        	"2,Vaibhav Singh,21,90",
        	"3,Shudhanshu Trivedi,22,88",
        	"4,Prabhat Kumar,23,76",
        	"5,Pramendra Pratap Singh,24,92"
    	};
   	
    	File.WriteAllLines(filePath, csvData);
    	Console.WriteLine("CSV file created successfully.");
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
}


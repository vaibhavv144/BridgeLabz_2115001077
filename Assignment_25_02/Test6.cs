using System;
using System.IO;
 
class Test6
{
	public static void Print()
	{
    	string employeeFilePath = "employees.csv";
    	string updatedEmployeeFilePath = "updated_employees.csv";
   	
    	UpdateITDepartmentSalaries(employeeFilePath, updatedEmployeeFilePath);
    	ReadAndPrintCSVFile(updatedEmployeeFilePath);
	}
 
	static void UpdateITDepartmentSalaries(string inputFile, string outputFile)
	{
    	if (File.Exists(inputFile))
    	{
        	string[] lines = File.ReadAllLines(inputFile);
        	for (int i = 1; i < lines.Length; i++) // Skip header row
            {
                string[] data = lines[i].Split(',');
                if (data[2] == "IT")
                {
                    data[3] = (int.Parse(data[3]) * 1.1).ToString(); // Increase salary by 10%
                    lines[i] = string.Join(",", data);
                }
            }
        	File.WriteAllLines(outputFile, lines);
        	Console.WriteLine("Updated IT department salaries and saved to new file.");
    	}
    	else
    	{
        	Console.WriteLine("CSV file not found!");
    	}
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

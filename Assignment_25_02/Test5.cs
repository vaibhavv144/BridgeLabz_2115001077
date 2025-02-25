using System;
using System.IO;
 
class Test5
{
	public static void Print()
	{
   	
    	string employeeFilePath = "employees.csv";
    	SearchEmployeeByName(employeeFilePath, "Vaibhav Singh");
	}
	static void SearchEmployeeByName(string filePath, string name){
    	if (File.Exists(filePath))
    	{
        	string[] lines = File.ReadAllLines(filePath);
        	bool found = false;
       	
        	for (int i = 1; i < lines.Length; i++)
            {
                string[] data = lines[i].Split(',');
                if (data[1].Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"Employee Found: \n{data[1]}, \nDepartment: {data[2]}, \nSalary: {data[3]}");
                    found = true;
                    break;
                }
            }
       	
        	if (!found)
            {
                Console.WriteLine("Employee not found!");
            }
    	}
    	else
    	{
        	Console.WriteLine("CSV file not found!");
    	}
	}
}

using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
class Test7{
	public static void Print(){
    	string employeeFilePath = "employees.csv";
    	PrintTopPaidEmployees(employeeFilePath);
   	
	}
	static void PrintTopPaidEmployees(string filePath) {
    	if (File.Exists(filePath))
    	{
        	string[] lines = File.ReadAllLines(filePath).Skip(1).ToArray();
        	List<string[]> employees = lines.Select(line => line.Split(',')).ToList();
 
        	for (int i = 0; i < employees.Count - 1; i++)
            {
                for (int j = 0; j < employees.Count - i - 1; j++)
                {
                    if (int.Parse(employees[j][3]) < int.Parse(employees[j + 1][3]))
                    {
                    	string[] temp = employees[j];
                    	employees[j] = employees[j + 1];
                    	employees[j + 1] = temp;
                    }
                }
            }
 
        	Console.WriteLine("\nTop 5 Highest Paid Employees:");
        	Console.WriteLine("{0,-5} {1,-25} {2,-10} {3,-10}", "ID", "Name", "Department", "Salary");
        	Console.WriteLine(new string('-', 55));
       	
        	for (int i = 0; i < Math.Min(5, employees.Count); i++)
            {
                string[] data = employees[i];
                Console.WriteLine("{0,-5} {1,-25} {2,-10} {3,-10}", data[0], data[1], data[2], data[3]);
            }
    	}
    	else
    	{
        	Console.WriteLine("CSV file not found!");
    	}
	}
}

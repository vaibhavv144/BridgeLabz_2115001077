using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;
class Test8{
	public static void Print(){
    	string employeeFilePath = "employee1.csv";
    	CreateEmployeeCSV(employeeFilePath);
    	ValidateCSVData(employeeFilePath);
 	
	}
 
	static void CreateEmployeeCSV(string filePath){
    	string[] csvData = {
        	"ID,Name,Department,Salary,Email,Phone",
        	"1,Shivam Kumar Rajput,HR,50000,shivam@gmail.com,98765432110",
        	"2,Vaibhav Singh,IT,60000,12va@ibhav@gmail.com,8765432109",
        	"3,Shudhanshu Trivedi,Finance,55000,shudhanshu@gmail.com,7654321098",
        	"4,Prabhat Kumar,Marketing,52000,prabhat@gmail.com,6543210987",
        	"5,Pramendra Pratap Singh,Sales,58000,pramendra@gmail.com,5432109876"
    	};
    	File.WriteAllLines(filePath, csvData);
    	Console.WriteLine("CSV file 'employee1.csv' created successfully.");
	}
 
 
static void ValidateCSVData(string filePath){
    	if (File.Exists(filePath))
    	{
        	string[] lines = File.ReadAllLines(filePath);
        	Regex emailRegex = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        	Regex phoneRegex = new Regex(@"^\d{10}$");
       	
        	Console.WriteLine("\nInvalid Records:");
        	Console.WriteLine(new string('-', 90));
       	
        	for (int index = 1; index < lines.Length; index++)
            {
                string[] data = lines[index].Split(',');
                bool isEmailValid = emailRegex.IsMatch(data[4]);
                bool isPhoneValid = phoneRegex.IsMatch(data[5]);
              
                if (!isEmailValid || !isPhoneValid)
                {
                    Console.WriteLine("Invalid Record: {0,-5} {1,-25} {2,-10} {3,-10} {4,-30} {5,-15}", data[0], data[1], data[2], data[3], data[4], data[5]);
                }
            }
    	}
    	else
    	{
        	Console.WriteLine("CSV file not found!");
    	}
	}
}

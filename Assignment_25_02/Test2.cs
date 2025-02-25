
using System;
using System.IO;
class Test2{
	public static void Print(){
    	string filePath = "employees.csv";
 	
    	string[] csvData = {
        	"ID,Name,Department,Salary",
        	"1,Shivam Kumar Rajput,HR,50000",
        	"2,Vaibhav Singh,IT,60000",
        	"3,Shudhanshu Trivedi,Finance,55000",
        	"4,Prabhat Kumar,Marketing,52000",
        	"5,Pramendra Pratap Singh,Sales,58000"
    	};
   	
    	File.WriteAllLines(filePath, csvData);
    	Console.WriteLine("CSV file created successfully.");
   	
    	if (File.Exists(filePath))
    	{
        	string[] lines = File.ReadAllLines(filePath);
       	
        	Console.WriteLine("{0,-5} {1,-25} {2,-15} {3,-10}", "ID", "Name", "Department", "Salary");
        	Console.WriteLine(new string('-', 60));
       	
        	for (int i = 1; i < lines.Length; i++)
            {
                string[] data = lines[i].Split(',');
                Console.WriteLine("{0,-5} {1,-25} {2,-15} {3,-10}", data[0], data[1], data[2], data[3]);
            }
    	}
    	else
    	{
        	Console.WriteLine("CSV file not found!");
    	}
	}
}


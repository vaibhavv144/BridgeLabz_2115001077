using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
 
class Test10
{
	public static void Print()
	{
    	string file1 = "students1.csv";
    	string file2 = "students2.csv";
    	string mergedFile = "merged_students.csv";
 
    	CreateCSVFiles(file1, file2);
 
    	MergeCSVFiles(file1, file2, mergedFile);
 
    	Console.WriteLine($"Merged CSV file '{mergedFile}' created successfully.");
    	ReadAndPrintMergedCSVFile(mergedFile);
	}
 
	static void CreateCSVFiles(string file1, string file2)
	{
   	
    	string[] student1Data = {
        	"ID,Name,Age",
        	"1,Shivam Kumar Rajput,20",
        	"2,Vaibhav Singh,21",
        	"3,Shudhanshu Trivedi,22",
        	"4,Prabhat Kumar,23",
        	"5,Pramendra Pratap Singh,24"
    	};
    	File.WriteAllLines(file1, student1Data);
 
    	string[] student2Data = {
        	"ID,Marks,Grade",
        	"1,85,A",
        	"2,79,B",
        	"3,88,A",
        	"4,76,C",
        	"5,92,A+"
    	};
    	File.WriteAllLines(file2, student2Data);
 
    	Console.WriteLine("CSV files created successfully.");
	}
 
	static void ReadAndPrintMergedCSVFile(string filePath)
{
	if (File.Exists(filePath))
	{
    	string[] lines = File.ReadAllLines(filePath);
   	
    	Console.WriteLine("{0,-5} {1,-25} {2,-5} {3,-5} {4,-5}", "ID", "Name", "Age", "Marks", "Grade");
    	Console.WriteLine(new string('-', 60));
 
    	for (int i = 1; i < lines.Length; i++) // Skip header row
    	{
        	string[] data = lines[i].Split(',');
        	Console.WriteLine("{0,-5} {1,-25} {2,-5} {3,-5} {4,-5}", data[0], data[1], data[2], data[3], data[4]);
    	}
	}
	else
	{
    	Console.WriteLine("CSV file not found!");
	}
}
 
	static void MergeCSVFiles(string file1, string file2, string outputFile)
	{
    	Dictionary<string, string> students1 = new Dictionary<string, string>();
    	string[] lines1 = File.ReadAllLines(file1);
   	
    	for (int i = 1; i < lines1.Length; i++)
    	{
        	string[] data = lines1[i].Split(',');
        	string id = data[0];
        	string details = data[1] + "," + data[2];
        	students1[id] = details;
    	}
 
    	Dictionary<string, string> students2 = new Dictionary<string, string>();
    	string[] lines2 = File.ReadAllLines(file2);
 
    	for (int i = 1; i < lines2.Length; i++)
    	{
        	string[] data = lines2[i].Split(',');
        	string id = data[0];
        	string details = data[1] + "," + data[2];
        	students2[id] = details;
    	}
 
    	List<string> mergedData = new List<string>();
    	mergedData.Add("ID,Name,Age,Marks,Grade");
 
    	foreach (string id in students1.Keys)
    	{
        	if (students2.ContainsKey(id))
            {
                mergedData.Add(id + "," + students1[id] + "," + students2[id]);
            }
    	}
 
    	File.WriteAllLines(outputFile, mergedData);
	}
}

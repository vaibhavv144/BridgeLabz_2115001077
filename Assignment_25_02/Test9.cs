
using System;
using System.Collections.Generic;
using System.IO;
 
class Student
{
	public int ID { get; set; }
	public string Name { get; set; }
	public string Department { get; set; }
	public int Salary { get; set; }
	public string Email { get; set; }
	public string Phone { get; set; }
 
	public override string ToString()
	{
    	return $"ID: {ID}, Name: {Name}, Department: {Department}, Salary: {Salary}, Email: {Email}, Phone: {Phone}";
	}
}
 
class Test9
{
	public static void Print(){
    	string filePath = "employee1.csv"; // Ensure this file exists
    	List<Student> students = ReadCSV(filePath);
 
    	foreach (Student student in students)
    	{
        	Console.WriteLine(student);
    	}
	}
 
	static List<Student> ReadCSV(string filePath)
	{
    	List<Student> students = new List<Student>();
 
    	if (File.Exists(filePath))
    	{
        	string[] lines = File.ReadAllLines(filePath);
       	
        	for (int i = 1; i < lines.Length; i++) // Skip header
            {
                string[] data = lines[i].Split(',');
                if (data.Length == 6)
                {
                    Student student = new Student
                    {
                    	ID = int.Parse(data[0]),
                    	Name = data[1],
                    	Department = data[2],
                    	Salary = int.Parse(data[3]),
                    	Email = data[4],
                    	Phone = data[5]
                    };
                    students.Add(student);
                }
            }
    	}
    	else
    	{
        	Console.WriteLine("CSV file not found!");
    	}
 
    	return students;
	}
}
 


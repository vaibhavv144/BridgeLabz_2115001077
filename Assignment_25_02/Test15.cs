using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
 
class Test15
{
	private static readonly string EncryptionKey = "MySecretKey12345"; // Use a strong key in real applications
 
	public static void Print()
	{
    	string csvFilePath = "employees_encrypted.csv";
 
    	// Create CSV file with encrypted data
    	CreateEncryptedCSVFile(csvFilePath);
 
    	// Read and decrypt CSV data
    	ReadAndDecryptCSVFile(csvFilePath);
	}
 
	static void CreateEncryptedCSVFile(string filePath)
	{
    	var employees = new List<Employee>
    	{
        	new Employee { ID = 1, Name = "Shivam Kumar Rajput", Department = "HR", Salary = "50000", Email = "shivam@gmail.com" },
        	new Employee { ID = 2, Name = "Vaibhav Singh", Department = "IT", Salary = "60000", Email = "vaibhav@gmail.com" },
        	new Employee { ID = 3, Name = "Shudhanshu Trivedi", Department = "Finance", Salary = "55000", Email = "shudhanshu@gmail.com" }
    	};
 
    	var csvLines = new List<string> { "ID,Name,Department,Salary,Email" }; // CSV Header
 
    	foreach (var emp in employees)
    	{
        	string encryptedSalary = Encrypt(emp.Salary);
        	string encryptedEmail = Encrypt(emp.Email);
 
        	csvLines.Add($"{emp.ID},{emp.Name},{emp.Department},{encryptedSalary},{encryptedEmail}");
    	}
 
    	File.WriteAllLines(filePath, csvLines);
    	Console.WriteLine($"Encrypted CSV file '{filePath}' created.");
	}
 
	static void ReadAndDecryptCSVFile(string filePath)
	{
    	if (!File.Exists(filePath))
    	{
        	Console.WriteLine("CSV file not found!");
        	return;
    	}
 
    	var lines = File.ReadAllLines(filePath).Skip(1); // Skip header
 
    	Console.WriteLine("\nDecrypted Employee Data:");
    	Console.WriteLine("{0,-5} {1,-25} {2,-10} {3,-10} {4,-30}", "ID", "Name", "Dept", "Salary", "Email");
    	Console.WriteLine(new string('-', 80));
 
    	foreach (var line in lines)
    	{
        	var data = line.Split(',');
 
        	string decryptedSalary = Decrypt(data[3]);
        	string decryptedEmail = Decrypt(data[4]);
 
        	Console.WriteLine("{0,-5} {1,-25} {2,-10} {3,-10} {4,-30}", data[0], data[1], data[2], decryptedSalary, decryptedEmail);
    	}
	}
 
	static string Encrypt(string text)
	{
    	using (Aes aes = Aes.Create())
    	{
        	aes.Key = Encoding.UTF8.GetBytes(EncryptionKey);
        	aes.IV = new byte[16]; // Default zero IV for simplicity
 
        	using (var encryptor = aes.CreateEncryptor(aes.Key, aes.IV))
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(text);
                byte[] encryptedBytes = encryptor.TransformFinalBlock(inputBytes, 0, inputBytes.Length);
                return Convert.ToBase64String(encryptedBytes);
            }
    	}
	}
 
	static string Decrypt(string encryptedText)
	{
    	using (Aes aes = Aes.Create())
    	{
        	aes.Key = Encoding.UTF8.GetBytes(EncryptionKey);
        	aes.IV = new byte[16];
 
        	using (var decryptor = aes.CreateDecryptor(aes.Key, aes.IV))
            {
                byte[] encryptedBytes = Convert.FromBase64String(encryptedText);
                byte[] decryptedBytes = decryptor.TransformFinalBlock(encryptedBytes, 0, encryptedBytes.Length);
                return Encoding.UTF8.GetString(decryptedBytes);
            }
    	}
	}
}
 
class Employee
{
	public int ID { get; set; }
	public string Name { get; set; }
	public string Department { get; set; }
	public string Salary { get; set; }
	public string Email { get; set; }
}
 
 




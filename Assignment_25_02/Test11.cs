
using System;
using System.IO;
using System.Text;
 
class Test11
{
	public static void Print()
	{
    	string filePath = "largefile.csv";
 
    	// Create a large CSV file (~100MB)
    	CreateLargeCSVFile(filePath, 5_000_000);
 
    	// Read the large CSV file in chunks of 100 lines
    	ReadLargeCSVFile(filePath, 100);
	}
 
	static void CreateLargeCSVFile(string filePath, int numRecords)
	{
    	using (StreamWriter writer = new StreamWriter(filePath, false, Encoding.UTF8))
    	{
        	writer.WriteLine("ID,Name,Age,Marks"); // Header row
       	
        	for (int i = 1; i <= numRecords; i++)
            {
                writer.WriteLine($"{i},Student{i},{20 + (i % 5)},{50 + (i % 51)}");
              
                if (i % 3 == 0) // Print progress every 100K records
                {
                    // Console.WriteLine($"Generated {i} records...");
                }
            }
    	}
 
    	Console.WriteLine($"CSV file '{filePath}' created successfully with {numRecords} records.");
	}
 
	static void ReadLargeCSVFile(string filePath, int chunkSize)
	{
    	if (!File.Exists(filePath))
    	{
        	Console.WriteLine("CSV file not found!");
        	return;
    	}
 
    	using (StreamReader reader = new StreamReader(filePath))
    	{
        	string header = reader.ReadLine(); // Read and ignore header row
        	int totalRecords = 0;
        	int batchCount = 0;
 
        	while (!reader.EndOfStream)
            {
                batchCount++;
                int lineCount = 0;
 
                while (lineCount < chunkSize && !reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    totalRecords++;
                    lineCount++;
                }
 
                // Console.WriteLine($"Batch {batchCount}: Processed {lineCount} records (Total: {totalRecords})");
            }
 
    	Console.WriteLine($"Finished processing {totalRecords} records.");
    	}
 
	}
}
 


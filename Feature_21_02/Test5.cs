using System;
using System.IO;

class Test5{
    public static void Print()
    {
        string filePath = "info.txt";
       
        try
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                string firstLine = reader.ReadLine();
                Console.WriteLine(firstLine);
            }
        }
        catch (IOException)
        {
            Console.WriteLine("Error reading file");
        }
    }
}

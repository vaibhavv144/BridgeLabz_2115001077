
using System;
using System.IO;

class FileGenerator{
    public static void Print(){
        string filePath = "largefile.bin";
        long fileSize = 500 * 1024 * 1024; // 500MB

        Console.WriteLine("Generating a 500MB binary file...");

        using (FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write))
        {
            byte[] buffer = new byte[4096];
            Random random = new Random();
            long bytesWritten = 0;

            while (bytesWritten < fileSize)
            {
                random.NextBytes(buffer);
                fs.Write(buffer, 0, buffer.Length);
                bytesWritten += buffer.Length;
            }
        }

        Console.WriteLine("File created successfully: " + filePath);
    }
}

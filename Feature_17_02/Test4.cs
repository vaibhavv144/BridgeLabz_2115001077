using System;
using System.Diagnostics;
using System.IO;
using System.Text;

class Test4{
    public static void Print(){
        string filePath = "largefile.bin";

        Console.WriteLine("File Size | StreamReader (ms) | FileStream (ms)");
        Console.WriteLine("----------------------------------------------");

        double streamReaderTime = MeasureExecutionTime(ReadWithStreamReader, filePath);
        double fileStreamTime = MeasureExecutionTime(ReadWithFileStream, filePath);

        Console.WriteLine($" 500MB    | {streamReaderTime,15:F4} | {fileStreamTime,12:F4}");
    }

    static void ReadWithStreamReader(string filePath){
        using (StreamReader reader = new StreamReader(filePath))
        {
            while (reader.Read() != -1) { }
        }
    }

    static void ReadWithFileStream(string filePath){
        using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
        {
            byte[] buffer = new byte[4096];
            while (fs.Read(buffer, 0, buffer.Length) > 0) { }
        }
    }

    static double MeasureExecutionTime(Action<string> method, string filePath){
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        method(filePath);
        stopwatch.Stop();
        return (double)stopwatch.ElapsedTicks / Stopwatch.Frequency * 1000;
    }
}
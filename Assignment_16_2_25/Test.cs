using System;
using System.Text;
using System.Diagnostics;

class Test{
    public static void Print(){
        int iterations = 100000;
        string text = "Hello";
        
        // Measure time for string concatenation
        Stopwatch stopwatch = Stopwatch.StartNew();
        string result = "";
        for (int i = 0; i < iterations; i++){
            result += text;
        }
        stopwatch.Stop();
        Console.WriteLine("String concatenation time: " + stopwatch.ElapsedMilliseconds + " ms");
        
        // Measure time for StringBuilder
        stopwatch.Restart();
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < iterations; i++){
            sb.Append(text);
        }
        stopwatch.Stop();
        Console.WriteLine("StringBuilder time: " + stopwatch.ElapsedMilliseconds + " ms");
    }
}

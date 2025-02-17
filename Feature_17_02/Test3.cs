using System;
using System.Diagnostics;
using System.Text;

public class Test3{
    public static void Print() {
        int[] datasetSizes = { 1000, 10000, 1000000 };

        Console.WriteLine("Operations Count | String (ms) | StringBuilder (ms)");
        Console.WriteLine("--------------------------------------------------");

        foreach (int size in datasetSizes)  {
            double stringTime = (size > 10000) ? double.PositiveInfinity : MeasureExecutionTime(StringConcatenation, size);
            double stringBuilderTime = MeasureExecutionTime(StringBuilderConcatenation, size);

            Console.WriteLine($"{size,15} | {stringTime,10:F4} | {stringBuilderTime,16:F4}");
        }
    }

    static void StringConcatenation(int N) {
        string result = "";
        for (int i = 0; i < N; i++){
            result += "a";
        }
    }

    static void StringBuilderConcatenation(int N) {
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < N; i++) {
            sb.Append("a");
        }
    }

    static double MeasureExecutionTime(Action<int> method, int N){
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        method(N);
        stopwatch.Stop();
        return (double)stopwatch.ElapsedTicks / Stopwatch.Frequency * 1000;
    }
}
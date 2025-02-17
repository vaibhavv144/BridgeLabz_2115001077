using System;
using System.Diagnostics;

class Test5{
    public static void Print(){
        int[] fibonacciNumbers = { 10, 30, 50 };

        Console.WriteLine("Fibonacci (N) | Recursive (ms) | Iterative (ms)");
        Console.WriteLine("----------------------------------------------");

        foreach (int n in fibonacciNumbers) {
            double recursiveTime = (n > 30) ? double.PositiveInfinity : MeasureExecutionTime(FibonacciRecursive, n);
            double iterativeTime = MeasureExecutionTime(FibonacciIterative, n);

            Console.WriteLine($"{n,13} | {recursiveTime,13:F4} | {iterativeTime,13:F4}");
        }
    }

    public static int FibonacciRecursive(int n) {
        if (n <= 1) return n;
        return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
    }

    public static int FibonacciIterative(int n) {
        if (n <= 1) return n;

        int a = 0, b = 1, sum;
        for (int i = 2; i <= n; i++) {
            sum = a + b;
            a = b;
            b = sum;
        }
        return b;
    }

    public static double MeasureExecutionTime(Func<int, int> method, int n) {
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        method(n);
        stopwatch.Stop();
        return (double)stopwatch.ElapsedTicks / Stopwatch.Frequency * 1000;
    }
}
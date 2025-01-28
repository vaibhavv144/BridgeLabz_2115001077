// Question2.cs
using System;

class Ques2
{
    public void SumOfNaturalNumbers()
    {
        Console.Write("Enter a natural number: ");
        int number = int.Parse(Console.ReadLine());

        if (number < 0)
        {
            Console.WriteLine("Not a natural number.");
            return;
        }

        // Calculate sum using recursion
        int sumRecursive = SumRecursive(number);

        // Calculate sum using formula
        int sumFormula = SumFormula(number);

        // Display results
        Console.WriteLine($"Sum using recursion: {sumRecursive}");
        Console.WriteLine($"Sum using formula: {sumFormula}");
        Console.WriteLine($"Both methods give the same result: {sumRecursive == sumFormula}");
    }

    private int SumRecursive(int n)
    {
        if (n == 0)
            return 0;
        return n + SumRecursive(n - 1);
    }

    private int SumFormula(int n)
    {
        return n * (n + 1) / 2;
    }
}
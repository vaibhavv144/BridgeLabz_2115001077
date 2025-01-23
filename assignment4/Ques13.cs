using System;

class Ques13
{
    public static void CompareSumResults()
    {
        // Take user input
        Console.Write("Enter a natural number: ");
        int n = Convert.ToInt32(Console.ReadLine());

        // Check if the input is a natural number
        if (n <= 0)
        {
            Console.WriteLine($"The number {n} is not a natural number.");
            return;
        }

        // Compute the sum using the formula
        int formulaSum = n * (n + 1) / 2;

        // Compute the sum using a for loop
        int loopSum = 0;

        for (int i = 1; i <= n; i++)
        {
            loopSum += i;
        }

        // Compare and display the results
        Console.WriteLine($"Sum using formula: {formulaSum}");
        Console.WriteLine($"Sum using for loop: {loopSum}");

        if (formulaSum == loopSum)
        {
            Console.WriteLine("Both computations are correct!");
        }
        else
        {
            Console.WriteLine("There is a discrepancy in the results.");
        }
    }
}

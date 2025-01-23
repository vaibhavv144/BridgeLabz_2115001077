using System;

class Program
{
    public static void CalculateFactorial_ForLoop()
    {
        // Take user input
        Console.Write("Enter a positive integer to find its factorial: ");
        int number = Convert.ToInt32(Console.ReadLine());

        // Check if the input is a positive integer
        if (number < 0)
        {
            Console.WriteLine($"The number {number} is not a positive integer. Factorial is undefined for negative numbers.");
            return;
        }

        // Initialize factorial to 1
        int factorial = 1;

        // Compute factorial using a for loop
        for (int i = 1; i <= number; i++)
        {
            factorial *= i;
        }

        // Print the factorial
        Console.WriteLine($"The factorial of {number} is {factorial}.");
    }
}

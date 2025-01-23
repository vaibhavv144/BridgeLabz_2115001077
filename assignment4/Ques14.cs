using System;

class Ques14
{
    public static void CalculateFactorial()
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

        // Initialize variables
        int factorial = 1; // Factorial starts at 1
        int counter = number; // Counter starts from the input number

        // Compute factorial using a while loop
        while (counter > 0)
        {
            factorial *= counter;
            counter--; // Decrement the counter
        }

        // Print the factorial
        Console.WriteLine($"The factorial of {number} is {factorial}.");
    }
}

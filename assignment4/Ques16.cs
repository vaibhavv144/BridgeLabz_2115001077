using System;

class Ques16
{
    public static void PrintOddEvenNumbers()
    {
        // Take user input
        Console.Write("Enter a positive integer: ");
        int number = Convert.ToInt32(Console.ReadLine());

        // Check if the input is a natural number
        if (number <= 0)
        {
            Console.WriteLine($"The number {number} is not a natural number.");
            return;
        }

        // Iterate from 1 to the entered number and check for odd or even
        for (int i = 1; i <= number; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine($"{i} is an even number.");
            }
            else
            {
                Console.WriteLine($"{i} is an odd number.");
            }
        }
    }
}

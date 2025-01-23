using System;

class Ques18
{
    public static void PrintMultiplicationTable()
    {
        // Take user input
        Console.Write("Enter a number to find its multiplication table from 6 to 9: ");
        int number = Convert.ToInt32(Console.ReadLine());

        // Check for natural number
        if (number <= 0)
        {
            Console.WriteLine($"The number {number} is not a valid natural number.");
            return;
        }

        // Print the multiplication table for number from 6 to 9
        for (int i = 6; i <= 9; i++)
        {
            Console.WriteLine($"{number} * {i} = {number * i}");
        }
    }
}

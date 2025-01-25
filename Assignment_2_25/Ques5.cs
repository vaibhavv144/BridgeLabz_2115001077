using System;

public class Ques5
{
    public static void DisplayPartialMultiplicationTable()
    {
        // Prompt the user to enter a number
        Console.WriteLine("Enter a number:");
        int inputNumber = Convert.ToInt32(Console.ReadLine());

        // Initialize an array to store multiplication results for the range 6 to 9
        int[] results = new int[4];

        // Calculate the multiplication results for numbers 6 to 9
        for (int multiplier = 6; multiplier <= 9; multiplier++)
        {
            results[multiplier - 6] = inputNumber * multiplier;
        }

        // Display the multiplication table for the range
        Console.WriteLine($"\nMultiplication Table of {inputNumber} (from 6 to 9):");
        for (int multiplier = 6; multiplier <= 9; multiplier++)
        {
            Console.WriteLine($"{inputNumber} * {multiplier} = {results[multiplier - 6]}");
        }
    }
}

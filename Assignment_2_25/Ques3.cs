using System;

public class Ques3
{
    public static void DisplayMultiplicationTable()
    {
        // Prompt the user to enter a number
        Console.WriteLine("Enter a number:");
        int inputNumber = Convert.ToInt32(Console.ReadLine());

        // Validate the input number (must be non-negative)
        if (inputNumber < 0)
        {
            Console.Error.WriteLine("Invalid Number. Please enter a non-negative number.");
            Environment.Exit(0); // Exit the program if the input is invalid
        }

        // Initialize an array to store the multiplication table
        int[] table = new int[10];

        // Calculate the multiplication table for the entered number
        for (int index = 0; index < 10; index++)
        {
            table[index] = inputNumber * (index + 1);
        }

        // Display the multiplication table
        Console.WriteLine($"\nMultiplication Table for {inputNumber}:");
        for (int index = 0; index < 10; index++)
        {
            Console.WriteLine($"{inputNumber} * {index + 1} = {table[index]}");
        }
    }
}

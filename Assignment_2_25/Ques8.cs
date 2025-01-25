using System;

public class Ques8
{
    public static void FindFactors()
    {
        // Prompt the user to enter a number
        Console.WriteLine("Enter a number to find its factors:");
        int number = Convert.ToInt32(Console.ReadLine());

        // Validate that the input number is positive
        if (number <= 0)
        {
            Console.Error.WriteLine("Error: Please enter a positive number.");
            return;
        }

        // Initialize the array to store factors and set initial capacity
        int maxFactor = 10;
        int[] factors = new int[maxFactor];
        int index = 0;

        // Loop to find factors of the number
        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
                // If the factors array is full, double its size
                if (index == maxFactor)
                {
                    maxFactor *= 2;
                    int[] temp = new int[maxFactor];
                    Array.Copy(factors, temp, factors.Length);
                    factors = temp;
                }

                // Store the factor in the array
                factors[index] = i;
                index++;
            }
        }

        // Display the factors of the number
        Console.WriteLine($"\nFactors of {number}:");
        for (int i = 0; i < index; i++)
        {
            Console.Write(factors[i] + " ");
        }

        Console.WriteLine(); // Add a line break at the end
    }
}

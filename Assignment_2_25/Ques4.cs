using System;

public class Ques4
{
    public static void CollectAndSumNumbers()
    {
        // Initialize an array to store up to 10 numbers
        double[] storedNumbers = new double[10];
        double sumOfNumbers = 0.0;
        int currentIndex = 0;

        // Continuously accept numbers from the user
        while (true)
        {
            Console.WriteLine("Enter a number (0 or negative to stop):");
            double userInput = Convert.ToDouble(Console.ReadLine());

            // Stop input if the user enters 0, a negative number, or the array is full
            if (userInput <= 0 || currentIndex == 10)
            {
                break;
            }

            // Store the valid number in the array
            storedNumbers[currentIndex] = userInput;
            currentIndex++;
        }

        // Display the numbers entered by the user
        Console.WriteLine("\nNumbers entered:");
        for (int i = 0; i < currentIndex; i++)
        {
            Console.WriteLine(storedNumbers[i]);
            sumOfNumbers += storedNumbers[i]; // Add each number to the total sum
        }

        // Display the total sum of the numbers
        Console.WriteLine($"\nTotal sum of numbers: {sumOfNumbers}");
    }
}

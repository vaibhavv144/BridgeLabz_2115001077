using System;

public class Ques10
{
    public static void PrintFizzBuzz()
    {
        // Prompt the user to enter a positive integer
        Console.WriteLine("Enter a positive integer:");
        int number = Convert.ToInt32(Console.ReadLine());

        // Validate that the input is a positive integer
        if (number <= 0)
        {
            Console.Error.WriteLine("Error: Please enter a positive integer.");
            return;
        }

        // Create an array to store the FizzBuzz results
        string[] results = new string[number + 1];

        // Populate the array with Fizz, Buzz, or FizzBuzz
        for (int i = 1; i <= number; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                results[i] = "FizzBuzz"; // Divisible by both 3 and 5
            }
            else if (i % 3 == 0)
            {
                results[i] = "Fizz"; // Divisible by 3
            }
            else if (i % 5 == 0)
            {
                results[i] = "Buzz"; // Divisible by 5
            }
            else
            {
                results[i] = i.ToString(); // Not divisible by 3 or 5
            }
        }

        // Display the results for each position
        for (int i = 1; i <= number; i++)
        {
            Console.WriteLine($"Position {i} = {results[i]}");
        }
    }
}

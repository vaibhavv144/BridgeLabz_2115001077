using System;

class Ques10
{
    public static void CalculateSumUntilZero()
    {
        // Initialize total to 0.0
        double total = 0.0;

        // Variable to store user input
        double userInput;

        Console.WriteLine("Enter numbers to sum. Enter 0 to stop:");

        // Use a while loop to keep adding numbers until 0 is entered
        do
        {
            Console.Write("Enter a number: ");
            userInput = Convert.ToDouble(Console.ReadLine());

            if (userInput != 0)
            {
                total += userInput; // Add the input to the total
            }

        } while (userInput != 0);

        // Display the total
        Console.WriteLine($"The total sum is {total}");
    }
}

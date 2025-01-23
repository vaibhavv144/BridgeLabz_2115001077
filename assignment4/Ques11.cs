using System;

class Ques11
{
    public static void CalculateSum_0_Neg()
    {
        // Initialize total to 0.0
        double total = 0.0;

        Console.WriteLine("Enter numbers to sum. Enter 0 or a negative number to stop:");

        // Infinite while loop
        while (true)
        {
            Console.Write("Enter a number: ");
            double userInput = Convert.ToDouble(Console.ReadLine());

            // Break the loop if the input is 0 or negative
            if (userInput <= 0)
            {
                break;
            }

            // Add the input to the total
            total += userInput;
        }

        // Display the total
        Console.WriteLine($"The total sum is {total}");
    }
}

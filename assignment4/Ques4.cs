using System;

class Ques4
{
    public static void SumNaturalNumber()
    {
        // Take input from the user
        Console.Write("Enter a number: ");
        if (int.TryParse(Console.ReadLine(), out int number))
        {
            // Check if the number is a natural number
            if (number >= 0)
            {
                // Calculate the sum of n natural numbers
                int sum = number * (number + 1) / 2;
                Console.WriteLine($"The sum of {number} natural numbers is {sum}");
            }
            else
            {
                Console.WriteLine($"The number {number} is not a natural number");
            }
        }
        else
        {
            Console.WriteLine("Invalid input! Please enter a valid integer.");
        }
    }
}

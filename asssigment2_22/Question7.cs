using System;

// Class to swap two numbers and display the swapped values
public class Question7
{
    public static void SwapTwoNumbers()
    {
        // Take two numbers as input from the user
        Console.Write("Enter first number: ");
        int number1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter second number: ");
        int number2 = Convert.ToInt32(Console.ReadLine());

        // Swap the numbers
        (number1, number2) = (number2, number1);

        // Display the swapped numbers
        Console.WriteLine($"The swapped numbers are {number1} and {number2}");
    }
}

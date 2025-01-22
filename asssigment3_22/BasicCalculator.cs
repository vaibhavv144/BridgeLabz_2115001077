using System;

public class BasicCalculator
{
    // Method to perform arithmetic operations on two numbers
    public static void PerformOperations()
    {
        // Prompt the user for input
        Console.Write("Enter the first number: ");
        double number1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the second number: ");
        double number2 = Convert.ToDouble(Console.ReadLine());

        // Perform operations
        double addition = number1 + number2;
        double subtraction = number1 - number2;
        double multiplication = number1 * number2;
        double division = number2 != 0 ? number1 / number2 : double.NaN; // Handle division by zero

        // Display the results
        Console.WriteLine($"The addition, subtraction, multiplication, and division value of two numbers {number1} and {number2} is:");
        Console.WriteLine($" {addition:F2}");
        Console.WriteLine($" {subtraction:F2}");
        Console.WriteLine($" {multiplication:F2}");
        Console.WriteLine($"{division:F2}");
    }
}

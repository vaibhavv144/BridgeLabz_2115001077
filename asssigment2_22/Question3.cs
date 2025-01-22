using System;

// Class to perform double operations and display results
public class Question3
{
    public static void PerformDoubleOperations()
    {
        // Take three double values as input from the user
        Console.Write("Enter value for a: ");
        double a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter value for b: ");
        double b = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter value for c: ");
        double c = Convert.ToInt32(Console.ReadLine());

        // Perform operations based on operator precedence
        double result1 = a + b * c;
        double result2 = a * b + c;
        double result3 = c + a / b;
        double result4 = a % b + c;

        // Display the results
        Console.WriteLine($"The results of Double Operations are {result1}, {result2}, {result3}, and {result4}");
    }
}

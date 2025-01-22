using System;

// Class to perform integer operations and display results
public class Question2
{
    public static void PerformIntOperations()
    {
        // Take three integers as input from the user
        Console.Write("Enter value for a: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter value for b: ");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter value for c: ");
        int c = Convert.ToInt32(Console.ReadLine());

        // Perform operations based on operator precedence
        int result1 = a + b * c;
        int result2 = a * b + c;
        int result3 = c + a / b;
        int result4 = a % b + c;

        // Display the results
        Console.WriteLine($"The results of Int Operations are {result1}, {result2}, {result3}, and {result4}");
    }
}

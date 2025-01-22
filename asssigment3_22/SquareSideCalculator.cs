using System;

public class SquareSideCalculator
{
    // Method to calculate the side of a square from its perimeter
    public static void CalculateSide()
    {
        // Prompt the user for the perimeter
        Console.Write("Enter the perimeter of the square: ");
        double perimeter = Convert.ToDouble(Console.ReadLine());

        // Calculate the side length
        double side = perimeter / 4;

        // Display the result
        Console.WriteLine($"The length of the side is {side:F2} whose perimeter is {perimeter:F2}.");
    }
}

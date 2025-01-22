using System;

public class TriangleAreaCalculator
{
    // Method to calculate and display the area of a triangle
    public static void CalculateArea()
    {
        // Prompt the user for input
        Console.Write("Enter the base of the triangle (in cm): ");
        double baseCm = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the height of the triangle (in cm): ");
        double heightCm = Convert.ToDouble(Console.ReadLine());

        // Calculate area in square centimeters
        double areaCm2 = 0.5 * baseCm * heightCm;

        // Convert area to square inches (1 cm² = 0.155 square inches)
        double areaIn2 = areaCm2 * 0.155;

        // Display the results
        Console.WriteLine($"The area of the triangle is {areaCm2:F2} square centimeters and {areaIn2:F2} square inches.");
    }
}

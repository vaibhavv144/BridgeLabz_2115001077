using System;

public class DistanceConverter
{
    // Method to convert kilometers to miles and display the result
    public static void ConvertKmToMiles()
    {
        // Prompt the user for input
        Console.Write("Enter the distance in kilometers: ");
        double km = Convert.ToDouble(Console.ReadLine());

        // Conversion factor
        double miles = km / 1.6;

        // Display the result
        Console.WriteLine($"The total miles is {miles:F2} mile for the given {km} km");
    }
}

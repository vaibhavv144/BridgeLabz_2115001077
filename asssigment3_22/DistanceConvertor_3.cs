using System;

public class DistanceConverter_3
{
    // Method to calculate and display the distance in miles
    public static void DisplayDistanceInMiles()
    {
        // Distance in kilometers
        double kilometers = 10.8;

        // Conversion factor
        double conversionFactor = 1 / 1.6;

        // Convert kilometers to miles
        double miles = kilometers * conversionFactor;

        // Display the result
        Console.WriteLine($"The distance {kilometers} km in miles is {miles:F2}");
    }
}

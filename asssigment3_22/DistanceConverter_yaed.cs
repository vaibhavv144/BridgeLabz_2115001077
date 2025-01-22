using System;

public class DistanceConverter_yard
{
    // Method to convert distance in feet to yards and miles
    public static void ConvertFeetToYardsAndMiles()
    {
        // Prompt the user for the distance in feet
        Console.Write("Enter the distance in feet: ");
        double distanceInFeet = Convert.ToDouble(Console.ReadLine());

        // Conversion factors
        double distanceInYards = distanceInFeet / 3;
        double distanceInMiles = distanceInYards / 1760;

        // Display the results
        Console.WriteLine($"The distance in feet is {distanceInFeet:F2}, which is equivalent to:");
        Console.WriteLine($"Yards: {distanceInYards:F2}");
        Console.WriteLine($"Miles: {distanceInMiles:F2}");
    }
}

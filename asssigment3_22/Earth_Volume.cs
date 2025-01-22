using System;

public class Earth_Volume
{
    // Method to calculate and display the volume of Earth in km^3 and miles^3
    public static void ComputeEarthVolume()
    {
        // Radius of Earth in kilometers
        double radiusKm = 6378;

        // Conversion factor for kilometers to miles
        double kmToMiles = 1 / 1.609;

        // Volume of a sphere formula: (4/3) * pi * r^3
        double volumeKm3 = (4.0 / 3.0) * Math.PI * Math.Pow(radiusKm, 3);
        double volumeMiles3 = volumeKm3 * Math.Pow(kmToMiles, 3);

        // Display the results
        Console.WriteLine($"The volume of Earth in cubic kilometers is {volumeKm3:F2} and in cubic miles is {volumeMiles3:F2}");
    }
}

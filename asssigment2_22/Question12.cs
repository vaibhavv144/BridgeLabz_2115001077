using System;

// Class to convert weight from pounds to kilograms
public class Question12
{
    public static void ConvertPoundsToKilograms()
    {
        // Take weight in pounds as input
        Console.Write("Enter weight in pounds: ");
        double pounds = Convert.ToInt32(Console.ReadLine());

        // Convert pounds to kilograms
        double kilograms = pounds / 2.2;

        // Display the result
        Console.WriteLine($"The weight is {pounds} pounds, which is approximately {kilograms:F2} kilograms.");
    }
}

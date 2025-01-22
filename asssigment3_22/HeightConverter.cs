using System;

public class HeightConverter
{
    // Method to convert height from centimeters to feet and inches
    public static void ConvertHeight()
    {
        // Prompt the user for input
        Console.Write("Enter your height in centimeters: ");
        double heightCm = Convert.ToDouble(Console.ReadLine());

        // Conversion factors
        double totalInches = heightCm / 2.54;
        int feet = (int)(totalInches / 12);
        double inches = totalInches % 12;

        // Display the result
        Console.WriteLine($"Your Height in cm is {heightCm:F2} while in feet is {feet} and inches is {inches:F2}");
    }
}

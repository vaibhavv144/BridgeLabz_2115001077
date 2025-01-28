// Question5.cs
using System;

class Ques5
{
    public void UnitConverterExtended()
    {
        Console.WriteLine("Extended Unit Converter");

        // Convert yards to feet
        double yards = 10;
        double feet = ConvertYardsToFeet(yards);
        Console.WriteLine($"{yards} yards is {feet} feet");

        // Convert feet to yards
        feet = 30;
        yards = ConvertFeetToYards(feet);
        Console.WriteLine($"{feet} feet is {yards} yards");

        // Convert meters to inches
        double meters = 2;
        double inches = ConvertMetersToInches(meters);
        Console.WriteLine($"{meters} meters is {inches} inches");

        // Convert inches to meters
        inches = 78.74;
        meters = ConvertInchesToMeters(inches);
        Console.WriteLine($"{inches} inches is {meters} meters");

        // Convert inches to centimeters
        inches = 12;
        double cm = ConvertInchesToCm(inches);
        Console.WriteLine($"{inches} inches is {cm} centimeters");
    }

    public static double ConvertYardsToFeet(double yards)
    {
        double yards2feet = 3;
        return yards * yards2feet;
    }

    public static double ConvertFeetToYards(double feet)
    {
        double feet2yards = 0.333333;
        return feet * feet2yards;
    }

    public static double ConvertMetersToInches(double meters)
    {
        double meters2inches = 39.3701;
        return meters * meters2inches;
    }

    public static double ConvertInchesToMeters(double inches)
    {
        double inches2meters = 0.0254;
        return inches * inches2meters;
    }

    public static double ConvertInchesToCm(double inches)
    {
        double inches2cm = 2.54;
        return inches * inches2cm;
    }
}
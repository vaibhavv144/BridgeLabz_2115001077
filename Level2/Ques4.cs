// Question4.cs
using System;

class Ques4
{
    public void UnitConverter()
    {
        Console.WriteLine("Unit Converter");

        // Convert kilometers to miles
        double km = 10;
        double miles = ConvertKmToMiles(km);
        Console.WriteLine($"{km} kilometers is {miles} miles");

        // Convert miles to kilometers
        miles = 6.2;
        km = ConvertMilesToKm(miles);
        Console.WriteLine($"{miles} miles is {km} kilometers");

        // Convert meters to feet
        double meters = 100;
        double feet = ConvertMetersToFeet(meters);
        Console.WriteLine($"{meters} meters is {feet} feet");

        // Convert feet to meters
        feet = 328.084;
        meters = ConvertFeetToMeters(feet);
        Console.WriteLine($"{feet} feet is {meters} meters");
    }

    public static double ConvertKmToMiles(double km)
    {
        double km2miles = 0.621371;
        return km * km2miles;
    }

    public static double ConvertMilesToKm(double miles)
    {
        double miles2km = 1.60934;
        return miles * miles2km;
    }

    public static double ConvertMetersToFeet(double meters)
    {
        double meters2feet = 3.28084;
        return meters * meters2feet;
    }

    public static double ConvertFeetToMeters(double feet)
    {
        double feet2meters = 0.3048;
        return feet * feet2meters;
    }
}
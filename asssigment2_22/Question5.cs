using System;

// Class to convert temperature from Fahrenheit to Celsius
public class Question5
{
    public static void ConvertFahrenheitToCelsius()
    {
        // Take Fahrenheit temperature as input from the user
        Console.Write("Enter temperature in Fahrenheit: ");
        double fahrenheit = Convert.ToInt32(Console.ReadLine());

        // Convert Fahrenheit to Celsius
        double celsius = (fahrenheit - 32) * 5 / 9;

        // Display the result
        Console.WriteLine($"{fahrenheit} Fahrenheit is {celsius} Celsius");
    }
}

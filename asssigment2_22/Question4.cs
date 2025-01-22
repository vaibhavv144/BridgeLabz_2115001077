using System;

// Class to convert temperature from Celsius to Fahrenheit
public class Question4
{
    public static void ConvertCelsiusToFahrenheit()
    {
        // Take Celsius temperature as input from the user
        Console.Write("Enter temperature in Celsius: ");
        double celsius = Convert.ToInt32(Console.ReadLine());

        // Convert Celsius to Fahrenheit
        double fahrenheit = (celsius * 9 / 5) + 32;

        // Display the result
        Console.WriteLine($"{celsius} Celsius is {fahrenheit} Fahrenheit");
    }
}

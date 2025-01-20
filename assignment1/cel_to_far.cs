using System;

class cel_to_far
{
    static void Main(string []args)
    {
        Console.WriteLine("Enter temperature in Celsius:");
        double cel = double.Parse(Console.ReadLine());

        double fah = (cel * 9 / 5) + 32;
        Console.WriteLine("Temperature in Fahrenheit: " + fah);
    }
}

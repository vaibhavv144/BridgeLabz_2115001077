using System;

class Power
{
    static void Main(string[]args)
    {
        Console.WriteLine("Enter the base number:");
        double baseNumber = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the exponent:");
        double exponent = double.Parse(Console.ReadLine());

        double result = Math.Pow(baseNumber, exponent);
        Console.WriteLine("Result: " + result);
    }
}

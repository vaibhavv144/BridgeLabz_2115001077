using System;

class avg_of_3_nbr
{
    static void Main(string []args)
    {
        Console.WriteLine("Enter the first number:");
        double num1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the second number:");
        double num2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the third number:");
        double num3 = double.Parse(Console.ReadLine());

        double average = (num1 + num2 + num3) / 3;
        Console.WriteLine("Average: " + average);
    }
}

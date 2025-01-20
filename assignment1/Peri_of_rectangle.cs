using System;

class Peri_of_rectangle
{
    static void Main(string[]args)
    {
        Console.WriteLine("Enter the length of the rectangle:");
        double length = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the width of the rectangle:");
        double width = double.Parse(Console.ReadLine());

        double perimeter = 2 * (length + width);
        Console.WriteLine("Perimeter of the rectangle: " + perimeter);
    }
}

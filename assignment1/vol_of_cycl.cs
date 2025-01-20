using System;

class vol_of_cycl
{
    static void Main(string[]args)
    {
        Console.WriteLine("Enter the radius of the cylinder:");
        double radius = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the height of the cylinder:");
        double height = double.Parse(Console.ReadLine());

        double volume = Math.PI * Math.Pow(radius, 2) * height;
        Console.WriteLine("Volume of the cylinder: " + volume);
    }
}

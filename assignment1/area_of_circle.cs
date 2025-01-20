using System;

class area_of_circle
{
    static void Main(string []args)
    {
        Console.WriteLine("Enter the radius :");
        double radius = double.Parse(Console.ReadLine());

        double area = Math.PI * Math.Pow(radius, 2);
        Console.WriteLine("Area of the circle: " + area);
    }
}

// Question9.cs
using System;

class Question9
{
    public void CalculateDistanceAndLineEquation()
    {
        Console.Write("Enter x1: ");
        double x1 = double.Parse(Console.ReadLine());
        Console.Write("Enter y1: ");
        double y1 = double.Parse(Console.ReadLine());
        Console.Write("Enter x2: ");
        double x2 = double.Parse(Console.ReadLine());
        Console.Write("Enter y2: ");
        double y2 = double.Parse(Console.ReadLine());

        // Calculate Euclidean distance
        double distance = CalculateEuclideanDistance(x1, y1, x2, y2);

        // Calculate line equation
        (double slope, double yIntercept) = CalculateLineEquation(x1, y1, x2, y2);

        // Display results
        Console.WriteLine($"Euclidean distance: {distance:F2}");
        Console.WriteLine($"Line equation: y = {slope:F2}x + {yIntercept:F2}");
    }

    private double CalculateEuclideanDistance(double x1, double y1, double x2, double y2)
    {
        return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
    }

    private (double, double) CalculateLineEquation(double x1, double y1, double x2, double y2)
    {
        double slope = (y2 - y1) / (x2 - x1);
        double yIntercept = y1 - slope * x1;
        return (slope, yIntercept);
    }
}   
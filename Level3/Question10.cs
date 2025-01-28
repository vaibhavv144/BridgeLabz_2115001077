// Question10.cs
using System;

class Question10
{
    public void CheckCollinearity()
    {
        Console.Write("Enter x1: ");
        double x1 = double.Parse(Console.ReadLine());
        Console.Write("Enter y1: ");
        double y1 = double.Parse(Console.ReadLine());
        Console.Write("Enter x2: ");
        double x2 = double.Parse(Console.ReadLine());
        Console.Write("Enter y2: ");
        double y2 = double.Parse(Console.ReadLine());
        Console.Write("Enter x3: ");
        double x3 = double.Parse(Console.ReadLine());
        Console.Write("Enter y3: ");
        double y3 = double.Parse(Console.ReadLine());

        // Check collinearity using slope
        bool areCollinearSlope = CheckCollinearityUsingSlope(x1, y1, x2, y2, x3, y3);

        // Check collinearity using area
        bool areCollinearArea = CheckCollinearityUsingArea(x1, y1, x2, y2, x3, y3);

        // Display results
        Console.WriteLine($"Are points collinear using slope method? {areCollinearSlope}");
        Console.WriteLine($"Are points collinear using area method? {areCollinearArea}");
    }

    private bool CheckCollinearityUsingSlope(double x1, double y1, double x2, double y2, double x3, double y3)
    {
        double slopeAB = (y2 - y1) / (x2 - x1);
        double slopeBC = (y3 - y2) / (x3 - x2);
        double slopeAC = (y3 - y1) / (x3 - x1);
        return slopeAB == slopeBC && slopeBC == slopeAC;
    }

    private bool CheckCollinearityUsingArea(double x1, double y1, double x2, double y2, double x3, double y3)
    {
        double area = 0.5 * (x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2));
        return area == 0;
    }
}
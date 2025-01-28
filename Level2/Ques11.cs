// Question11.cs
using System;

class Ques11
{
    public void FindQuadraticRoots()
    {
        Console.Write("Enter coefficient a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter coefficient b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter coefficient c: ");
        double c = double.Parse(Console.ReadLine());

        // Find roots of the quadratic equation
        double[] roots = FindRoots(a, b, c);

        // Display results
        if (roots.Length == 0)
        {
            Console.WriteLine("The equation has no real roots.");
        }
        else if (roots.Length == 1)
        {
            Console.WriteLine($"The equation has one root: {roots[0]}");
        }
        else
        {
            Console.WriteLine($"The equation has two roots: {roots[0]} and {roots[1]}");
        }
    }

    private double[] FindRoots(double a, double b, double c)
    {
        double delta = Math.Pow(b, 2) - 4 * a * c;
        if (delta < 0)
        {
            return new double[0]; // No real roots
        }
        else if (delta == 0)
        {
            double root = -b / (2 * a);
            return new double[] { root }; // One root
        }
        else
        {
            double sqrtDelta = Math.Sqrt(delta);
            double root1 = (-b + sqrtDelta) / (2 * a);
            double root2 = (-b - sqrtDelta) / (2 * a);
            return new double[] { root1, root2 }; // Two roots
        }
    }
}
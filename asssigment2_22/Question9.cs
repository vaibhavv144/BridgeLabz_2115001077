using System;

// Class to calculate the number of rounds an athlete needs to run
public class Question9
{
    public static void CalculateRoundsForRun()
    {
        // Take the three sides of the triangular park as input
        Console.Write("Enter the length of side 1 (in meters): ");
        double side1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the length of side 2 (in meters): ");
        double side2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the length of side 3 (in meters): ");
        double side3 = Convert.ToInt32(Console.ReadLine());

        // Calculate the perimeter of the triangle
        double perimeter = side1 + side2 + side3;

        // Convert perimeter to kilometers
        double perimeterInKm = perimeter / 1000;

        // Calculate the number of rounds
        double rounds = 5 / perimeterInKm;

        // Display the result
        Console.WriteLine($"The athlete needs to complete {Math.Ceiling(rounds)} rounds to cover 5 km.");
    }
}

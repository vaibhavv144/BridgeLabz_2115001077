using System;

// Class to rewrite sample program 2 with user inputs
public class Question8
{
    public static void SampleProgram2WithInputs()
    {
        // Take user inputs for personal details and trip information
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();
        Console.Write("Enter the starting city: ");
        string fromCity = Console.ReadLine();
        Console.Write("Enter the via city: ");
        string viaCity = Console.ReadLine();
        Console.Write("Enter the destination city: ");
        string toCity = Console.ReadLine();
        Console.Write("Enter distance from starting city to via city (in miles): ");
        double fromToVia = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter distance from via city to destination city (in miles): ");
        double viaToFinalCity = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the total time taken for the journey (in hours): ");
        double timeTaken = Convert.ToInt32(Console.ReadLine());

        // Calculate total distance
        double totalDistance = fromToVia + viaToFinalCity;

        // Display the results
        Console.WriteLine($"Traveler: {name}");
        Console.WriteLine($"Journey: {fromCity} -> {viaCity} -> {toCity}");
        Console.WriteLine($"Total Distance: {totalDistance} miles");
        Console.WriteLine($"Total Time Taken: {timeTaken} hours");
    }
}

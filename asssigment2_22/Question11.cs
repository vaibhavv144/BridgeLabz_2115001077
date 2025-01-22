using System;

// Class to calculate simple interest based on principal, rate, and time
public class Question11
{
    public static void CalculateSimpleInterest()
    {
        // Take the principal, rate, and time as input
        Console.Write("Enter the principal amount: ");
        double principal = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the rate of interest (in %): ");
        double rate = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the time (in years): ");
        double time = Convert.ToInt32(Console.ReadLine());

        // Calculate simple interest
        double simpleInterest = (principal * rate * time) / 100;

        // Display the result
        Console.WriteLine($"The Simple Interest is {simpleInterest} for Principal {principal}, Rate {rate}%, and Time {time} years.");
    }
}

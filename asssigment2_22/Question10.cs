using System;

// Class to divide chocolates among children and display results
public class Question10
{
    public static void DivideChocolates()
    {
        // Take the number of chocolates and children as input
        Console.Write("Enter the total number of chocolates: ");
        int numberOfChocolates = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the number of children: ");
        int numberOfChildren = Convert.ToInt32(Console.ReadLine());

        // Calculate chocolates per child and remaining chocolates
        int chocolatesPerChild = numberOfChocolates / numberOfChildren;
        int remainingChocolates = numberOfChocolates % numberOfChildren;

        // Display the results
        Console.WriteLine($"Each child gets {chocolatesPerChild} chocolates, and {remainingChocolates} chocolates remain.");
    }
}

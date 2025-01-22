using System;

// Class to calculate total income based on salary and bonus
public class Question6
{
    public static void CalculateTotalIncome()
    {
        // Take salary and bonus as input from the user
        Console.Write("Enter salary: ");
        double salary = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter bonus: ");
        double bonus = Convert.ToInt32(Console.ReadLine());

        // Calculate total income
        double totalIncome = salary + bonus;

        // Display the total income
        Console.WriteLine($"The salary is INR {salary} and bonus is INR {bonus}. Hence Total Income is INR {totalIncome}");
    }
}

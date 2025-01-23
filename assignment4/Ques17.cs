using System;

class Ques17
{
    public static void CalculateEmployeeBonus()
    {
        // Take user inputs
        Console.Write("Enter the employee's salary: ");
        double salary = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the employee's years of service: ");
        int yearsOfService = Convert.ToInt32(Console.ReadLine());

        // Check if the employee is eligible for a bonus
        if (yearsOfService > 5)
        {
            double bonus = salary * 0.05; // Calculate 5% bonus
            Console.WriteLine($"The employee is eligible for a bonus of {bonus:C}.");
        }
        else
        {
            Console.WriteLine("The employee is not eligible for a bonus.");
        }
    }
}

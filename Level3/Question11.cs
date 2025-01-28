// Question11.cs
using System;

class Question11
{
    public void CalculateEmployeeBonus()
    {
        double[,] employeeData = GenerateEmployeeData();
        double[,] newSalariesAndBonuses = CalculateNewSalariesAndBonuses(employeeData);
        DisplaySalaryDetails(employeeData, newSalariesAndBonuses);
    }

    private double[,] GenerateEmployeeData()
    {
        double[,] data = new double[10, 2];
        Random rand = new Random();

        for (int i = 0; i < 10; i++)
        {
            data[i, 0] = rand.Next(10000, 100000); // Random 5-digit salary
            data[i, 1] = rand.Next(1, 11); // Random years of service
        }
        return data;
    }

    private double[,] CalculateNewSalariesAndBonuses(double[,] employeeData)
    {
        double[,] newSalariesAndBonuses = new double[10, 2];

        for (int i = 0; i < 10; i++)
        {
            double salary = employeeData[i, 0];
            double yearsOfService = employeeData[i, 1];
            double bonus = yearsOfService > 5 ? salary * 0.05 : salary * 0.02;
            double newSalary = salary + bonus;

            newSalariesAndBonuses[i, 0] = newSalary;
            newSalariesAndBonuses[i, 1] = bonus;
        }
        return newSalariesAndBonuses;
    }

    private void DisplaySalaryDetails(double[,] employeeData, double[,] newSalariesAndBonuses)
    {
        double totalOldSalary = 0, totalNewSalary = 0, totalBonus = 0;

        Console.WriteLine("Employee\tOld Salary\tNew Salary\tBonus");
        for (int i = 0; i < 10; i++)
        {
            double oldSalary = employeeData[i, 0];
            double newSalary = newSalariesAndBonuses[i, 0];
            double bonus = newSalariesAndBonuses[i, 1];

            totalOldSalary += oldSalary;
            totalNewSalary += newSalary;
            totalBonus += bonus;

            Console.WriteLine($"{i + 1}\t\t{oldSalary}\t{newSalary}\t{bonus}");
        }

        Console.WriteLine($"\nTotal Old Salary: {totalOldSalary}");
        Console.WriteLine($"Total New Salary: {totalNewSalary}");
        Console.WriteLine($"Total Bonus: {totalBonus}");
    }
}
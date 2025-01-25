class Ques1{
public static void CalculateEmployeeBonuses()
{
    // Arrays to store salary, years of service, bonus, and new salary for 10 employees
    double[] salaries = new double[10];
    double[] yearsOfService = new double[10];
    double[] bonuses = new double[10];
    double[] newSalaries = new double[10];

    // Variables to track total bonus, old salary, and new salary
    double totalBonus = 0;
    double totalOldSalary = 0;
    double totalNewSalary = 0;

    // Loop to input salary and years of service for each employee
    for (int i = 0; i < 10; i++)
    {
        while (true)
        {
            try
            {
                // Input salary
                Console.Write($"Enter the salary of employee {i + 1}: ");
                salaries[i] = Convert.ToDouble(Console.ReadLine());

                // Input years of service
                Console.Write($"Enter the years of service of employee {i + 1}: ");
                yearsOfService[i] = Convert.ToDouble(Console.ReadLine());

                // Check for valid input
                if (salaries[i] <= 0 || yearsOfService[i] < 0)
                {
                    Console.WriteLine("Invalid input. Please enter valid positive numbers.");
                    continue;
                }
                break; // Exit the loop if input is valid
            }
            catch
            {
                Console.WriteLine("Invalid input. Please enter valid numbers.");
            }
        }
    }

    // Loop to calculate bonuses, new salaries, and totals
    for (int i = 0; i < 10; i++)
    {
        // Calculate bonus based on years of service
        if (yearsOfService[i] > 5)
        {
            bonuses[i] = salaries[i] * 0.05; // 5% bonus
        }
        else
        {
            bonuses[i] = salaries[i] * 0.02; // 2% bonus
        }

        // Calculate new salary
        newSalaries[i] = salaries[i] + bonuses[i];

        // Update total values
        totalBonus += bonuses[i];
        totalOldSalary += salaries[i];
        totalNewSalary += newSalaries[i];
    }

    // Output results
   
    Console.WriteLine($"Total Bonus Payout: {totalBonus:C}");
    Console.WriteLine($"Total Old Salary: {totalOldSalary:C}");
    Console.WriteLine($"Total New Salary: {totalNewSalary:C}");
}
}
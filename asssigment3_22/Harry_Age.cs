using System;

public class Harry_Age
{
    // Method to calculate and display Harry's age
    public static void DisplayHarryAge()
    {
        int birthYear = 2000;
        int currentYear = 2024;
        int age = currentYear - birthYear;

        Console.WriteLine($"Harry's age in {currentYear} is {age}");
    }
}

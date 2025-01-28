
// Question3.cs
using System;

class Ques3
{
    public void CheckLeapYear()
    {
        Console.Write("Enter a year: ");
        int year = int.Parse(Console.ReadLine());

        // Check if the year is a leap year
        bool isLeapYear = IsLeapYear(year);

        // Display result
        Console.WriteLine($"The year {year} is {(isLeapYear ? "a Leap Year" : "not a Leap Year")}");
    }

    private bool IsLeapYear(int year)
    {
        if (year < 1582)
        {
            Console.WriteLine("The LeapYear program only works for year >= 1582.");
            return false;
        }
        return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
    }
}

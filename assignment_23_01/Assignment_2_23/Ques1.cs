using System;

class Ques1
{
    public static void CheckLeapYear()
    {
        // Input: Year
        Console.Write("Enter a year (>= 1582): ");
        int year = Convert.ToInt32(Console.ReadLine());

        // Validate Gregorian calendar year
        if (year < 1582)
        {
            Console.WriteLine("The program only works for years >= 1582.");
        }
        else
        {
            // Check for Leap Year using a single if statement
            if (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0))
            {
                Console.WriteLine($"{year} is a Leap Year.");
            }
            else
            {
                Console.WriteLine($"{year} is not a Leap Year.");
            }
        }
    }
}
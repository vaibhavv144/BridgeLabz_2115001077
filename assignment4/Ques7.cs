using System;

class Ques7
{
    public static void SpringSeason()
    {
        // Take month and day as input from the user
        Console.Write("Enter the month (1-12): ");
        int month = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the day (1-31): ");
        int day = Convert.ToInt32(Console.ReadLine());

        // Check if the date falls within the Spring season (March 20 to June 20)
        if ((month == 3 && day >= 20) || (month == 4) || (month == 5) || (month == 6 && day <= 20))
        {
            Console.WriteLine("It's a Spring Season");
        }
        else
        {
            Console.WriteLine("Not a Spring Season");
        }
    }
}

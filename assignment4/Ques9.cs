using System;

class Ques9
{
    public static void ForLoop()
    {
        // Take user input for the countdown start value
        Console.Write("Enter the starting value for the countdown: ");
        int counter = Convert.ToInt32(Console.ReadLine());

        // Perform the countdown using a for loop
        for (int i = counter; i >= 1; i--)
        {
            Console.WriteLine(i);
        }

       
    }
}

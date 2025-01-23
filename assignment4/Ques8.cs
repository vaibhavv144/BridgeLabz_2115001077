using System;

class Ques8
{
    public static void WhileLoop()
    {
        // Take user input for the countdown start value
        Console.Write("Enter the starting value for the countdown: ");
        int counter = Convert.ToInt32(Console.ReadLine());

        // Perform the countdown using a while loop
        while (counter >= 1)
        {
            Console.WriteLine(counter);
            counter--; // Decrement the counter
        }

        
    }
}

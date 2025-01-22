using System;

public class MarksCalculator
{
    // Method to calculate and display Sam's average mark
    public static void DisplayAverageMark()
    {
        // Marks in each subject
        int maths = 94;
        int physics = 95;
        int chemistry = 96;

        // Calculate the average percentage
        double average = (maths + physics + chemistry) / 3.0;

        // Display the result
        Console.WriteLine($"Sam’s average mark in PCM is {average}");
    }
}

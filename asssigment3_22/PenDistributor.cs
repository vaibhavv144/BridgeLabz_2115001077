using System;

public class PenDistributor
{
    // Method to calculate and display pens per student and remaining pens
    public static void DistributePens()
    {
        // Total pens and number of students
        int totalPens = 14;
        int numberOfStudents = 3;

        // Calculate pens per student and remaining pens
        int pensPerStudent = totalPens / numberOfStudents;
        int remainingPens = totalPens % numberOfStudents;

        // Display the result
        Console.WriteLine($"The Pen Per Student is {pensPerStudent} and the remaining pen not distributed is {remainingPens}");
    }
}

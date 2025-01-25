using System;
public class Ques9
{
    public static void Print()
    {
        // Prompt user to enter the number of students
        Console.WriteLine("Enter the number of students:");
        int numStudents = Convert.ToInt32(Console.ReadLine());

        // Create a 2D array to store marks for each subject for each student
        int[,] marks = new int[numStudents, 3];
        
        // Arrays to store calculated percentages and grades for each student
        double[] percentages = new double[numStudents];
        char[] grades = new char[numStudents];

        // Loop through each student
        for (int i = 0; i < numStudents; i++)
        {
            Console.WriteLine("\nStudent " + (i + 1) + ":");

            // Input marks for Physics, ensuring non-negative values
            do
            {
                Console.Write("Enter Physics marks: ");
                marks[i, 0] = Convert.ToInt32(Console.ReadLine());
            } while (marks[i, 0] < 0);

            // Input marks for Chemistry, ensuring non-negative values
            do
            {
                Console.Write("Enter Chemistry marks: ");
                marks[i, 1] = Convert.ToInt32(Console.ReadLine());
            } while (marks[i, 1] < 0);

            // Input marks for Maths, ensuring non-negative values
            do
            {
                Console.Write("Enter Maths marks: ");
                marks[i, 2] = Convert.ToInt32(Console.ReadLine());
            } while (marks[i, 2] < 0);

            // Calculate percentage
            percentages[i] = (marks[i, 0] + marks[i, 1] + marks[i, 2]) / 3.0;

            // Determine grade based on percentage
            if (percentages[i] >= 80)
            {
                grades[i] = 'A';
            }
            else if (percentages[i] >= 70)
            {
                grades[i] = 'B';
            }
            else if (percentages[i] >= 60)
            {
                grades[i] = 'C';
            }
            else if (percentages[i] >= 50)
            {
                grades[i] = 'D';
            }
            else if (percentages[i] >= 40)
            {
                grades[i] = 'E';
            }
            else
            {
                grades[i] = 'R'; // 'R' for Reappear
            }

            // Display the calculated percentage and grade for the student
            Console.WriteLine($"Student {i + 1}: Percentage: {percentages[i]:F2}, Grade: {grades[i]}");
        }
    }
}

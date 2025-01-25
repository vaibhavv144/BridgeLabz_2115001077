using System;

public class Ques1
{
    public static void PrintVotingEligibility()
    {
        // Initialize an array to store the ages of 10 students
        int[] studentAges = new int[10];
        
        // Loop to input the age of each student
        for (int i = 0; i < studentAges.Length; i++)
        {
            Console.WriteLine($"Enter the age of Student {i + 1}:");
            int enteredAge = Convert.ToInt32(Console.ReadLine());
            
            // Validate that the age is non-negative
            if (enteredAge < 0)
            {
                Console.Error.WriteLine("Invalid Age entered. Exiting program.");
                Environment.Exit(0); // Exit the program if invalid age is entered
            }

            // Store the valid age in the array
            studentAges[i] = enteredAge;
        }

        // Loop to check the voting eligibility of each student
        for (int index = 0; index < studentAges.Length; index++)
        {
            if (studentAges[index] >= 18)
            {
                Console.WriteLine($"Student {index + 1} with the age {studentAges[index]} can vote.");
            }
            else
            {
                Console.WriteLine($"Student {index + 1} with the age {studentAges[index]} cannot vote.");
            }
        }
    }
}

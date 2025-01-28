// Question7.cs
using System;

class Ques7
{
    public void CheckStudentVotingEligibility()
    {
        int[] ages = new int[10];
        for (int i = 0; i < ages.Length; i++)
        {
            Console.Write($"Enter age for student {i + 1}: ");
            ages[i] = int.Parse(Console.ReadLine());
        }

        // Check voting eligibility for each student
        foreach (int age in ages)
        {
            bool canVote = CanStudentVote(age);
            Console.WriteLine($"Student with age {age} can vote: {canVote}");
        }
    }

    public bool CanStudentVote(int age)
    {
        if (age < 0)
        {
            return false; // Invalid age
        }
        return age >= 18;
    }
}
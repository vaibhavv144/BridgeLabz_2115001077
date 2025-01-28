// Question12.cs
using System;

class Question12
{
    public void CalculateStudentScores()
    {
        Console.Write("Enter the number of students: ");
        int numberOfStudents = int.Parse(Console.ReadLine());

        int[,] scores = GenerateRandomScores(numberOfStudents);
        double[,] results = CalculateResults(scores);
        DisplayScorecard(scores, results);
    }

    private int[,] GenerateRandomScores(int numberOfStudents)
    {
        int[,] scores = new int[numberOfStudents, 3];
        Random rand = new Random();

        for (int i = 0; i < numberOfStudents; i++)
        {
            scores[i, 0] = rand.Next(10, 100); // Physics
            scores[i, 1] = rand.Next(10, 100); // Chemistry
            scores[i, 2] = rand.Next(10, 100); // Maths
        }
        return scores;
    }

    private double[,] CalculateResults(int[,] scores)
    {
        int numberOfStudents = scores.GetLength(0);
        double[,] results = new double[numberOfStudents, 3];

        for (int i = 0; i < numberOfStudents; i++)
        {
            int total = scores[i, 0] + scores[i, 1] + scores[i, 2];
            double average = total / 3.0;
            double percentage = (total / 300.0) * 100;

            results[i, 0] = total;
            results[i, 1] = Math.Round(average, 2);
            results[i, 2] = Math.Round(percentage, 2);
        }
        return results;
    }

    private void DisplayScorecard(int[,] scores, double[,] results)
    {
        Console.WriteLine("Student\tPhysics\tChemistry\tMaths\tTotal\tAverage\tPercentage");
        for (int i = 0; i < scores.GetLength(0); i++)
        {
            Console.WriteLine($"{i + 1}\t{scores[i, 0]}\t{scores[i, 1]}\t\t{scores[i, 2]}\t{results[i, 0]}\t{results[i, 1]}\t{results[i, 2]}");
        }
    }
}
// Question8.cs
using System;

class Ques8
{
    public void FindYoungestAndTallest()
    {
        int[] ages = new int[3];
        double[] heights = new double[3];
        string[] names = { "Amar", "Akbar", "Anthony" };

        // Input ages and heights
        for (int i = 0; i < 3; i++)
        {
            Console.Write($"Enter age of {names[i]}: ");
            ages[i] = int.Parse(Console.ReadLine());
            Console.Write($"Enter height of {names[i]} in cm: ");
            heights[i] = double.Parse(Console.ReadLine());
        }

        // Find youngest and tallest
        int youngestIndex = FindYoungest(ages);
        int tallestIndex = FindTallest(heights);

        // Display results
        Console.WriteLine($"The youngest friend is {names[youngestIndex]}");
        Console.WriteLine($"The tallest friend is {names[tallestIndex]}");
    }

    private int FindYoungest(int[] ages)
    {
        int youngestIndex = 0;
        for (int i = 1; i < ages.Length; i++)
        {
            if (ages[i] < ages[youngestIndex])
                youngestIndex = i;
        }
        return youngestIndex;
    }

    private int FindTallest(double[] heights)
    {
        int tallestIndex = 0;
        for (int i = 1; i < heights.Length; i++)
        {
            if (heights[i] > heights[tallestIndex])
                tallestIndex = i;
        }
        return tallestIndex;
    }
}
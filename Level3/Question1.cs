// Question1.cs
using System;

class Question1
{
    public void AnalyzeHeights()
    {
        int[] heights = new int[11];
        Random rand = new Random();

        // Generate random heights for players
        for (int i = 0; i < heights.Length; i++)
        {
            heights[i] = rand.Next(150, 251);
        }

        // Calculate sum, mean, shortest, and tallest heights
        int sum = FindSum(heights);
        double mean = FindMean(sum, heights.Length);
        int shortest = FindShortest(heights);
        int tallest = FindTallest(heights);

        // Display results
        Console.WriteLine($"Sum of heights: {sum}");
        Console.WriteLine($"Mean height: {mean:F2}");
        Console.WriteLine($"Shortest height: {shortest}");
        Console.WriteLine($"Tallest height: {tallest}");
    }

    private int FindSum(int[] heights)
    {
        int sum = 0;
        foreach (int height in heights)
        {
            sum += height;
        }
        return sum;
    }

    private double FindMean(int sum, int count)
    {
        return (double)sum / count;
    }

    private int FindShortest(int[] heights)
    {
        int shortest = heights[0];
        foreach (int height in heights)
        {
            if (height < shortest)
                shortest = height;
        }
        return shortest;
    }

    private int FindTallest(int[] heights)
    {
        int tallest = heights[0];
        foreach (int height in heights)
        {
            if (height > tallest)
                tallest = height;
        }
        return tallest;
    }
}
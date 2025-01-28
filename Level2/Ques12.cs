using System;

class Ques12
{
    public void GenerateRandomNumbers()
    {
        int[] randomNumbers = Generate4DigitRandomArray(5);

        // Calculate average, min, and max
        double[] results = FindAverageMinMax(randomNumbers);

        // Display results
        Console.WriteLine("Random numbers: " + string.Join(", ", randomNumbers));
        Console.WriteLine($"Average: {results[0]:F2}");
        Console.WriteLine($"Minimum: {results[1]}");
        Console.WriteLine($"Maximum: {results[2]}");
    }

    private int[] Generate4DigitRandomArray(int size)
    {
        Random random = new Random();
        int[] numbers = new int[size];
        for (int i = 0; i < size; i++)
        {
            numbers[i] = random.Next(1000, 10000);
        }
        return numbers;
    }

    private double[] FindAverageMinMax(int[] numbers)
    {
        int min = numbers[0];
        int max = numbers[0];
        double sum = 0;

        foreach (int number in numbers)
        {
            if (number < min)
                min = number;
            if (number > max)
                max = number;
            sum += number;
        }

        double average = sum / numbers.Length;
        return new double[] { average, min, max };
    }
}